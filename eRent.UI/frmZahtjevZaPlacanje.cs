using eRent.Models;
using eRent.Models.Requests.Payment;
using eRent.UI.Helpers;
using Newtonsoft.Json;
using System.Text.RegularExpressions;

namespace eRent.UI
{
    public partial class frmZahtjevZaPlacanje : Form
    {
        public int BrojKorisnika { get; }
        public NekretninaModel Nekretnina { get; }
        public APIService PaymentRequestService { get; set; } = new APIService("PaymentRequest");
        public APIService _korisnikService { get; set; } = new APIService("Korisnici");

        public frmZahtjevZaPlacanje(int brojKorisnika, NekretninaModel nekretnina)
        {
            InitializeComponent();
            BrojKorisnika = brojKorisnika;
            Nekretnina = nekretnina;
        }

        private void frmZahtjevZaPlacanje_Load(object sender, EventArgs e)
        {
            txtNekretnina.Text = Nekretnina.NazivNekretnine;
        }

        private async void btnPosalji_Click(object sender, EventArgs e)
        {
            if (ValidateChildren())
            {
                double iznosPoKorisniku = double.Parse(txtIznos.Text) / BrojKorisnika;
                string komentar = txtKomentar.Text;
                string naslov = txtNaslov.Text + " - " + iznosPoKorisniku.ToString() + " KM";
                var korisnik = await _korisnikService.GetById<KorisnikModel>(2);
                await posaljiNotifikacijuAsync(komentar, naslov, korisnik.FcmDeviceToken);
                await savePaymentRequestToDatabase(iznosPoKorisniku);
            }
        }

        private async Task savePaymentRequestToDatabase(double iznosPoKorisniku)
        {
            //TODO add for each customer to send separate payment request
            PaymentUpsertRequest paymentUpsertRequest = new PaymentUpsertRequest();
            paymentUpsertRequest.NekretninaPayment = Nekretnina.NekretninaId;
            paymentUpsertRequest.Komentar = txtKomentar.Text;
            paymentUpsertRequest.Iznos = Math.Round(iznosPoKorisniku, 2); //returns 1.99
            paymentUpsertRequest.Mjesecno = cbMjesecno.Checked;
            paymentUpsertRequest.Naslov = txtNaslov.Text;
            paymentUpsertRequest.IsProcessed = false;
            paymentUpsertRequest.KorisnikPaymentId = 2;
            var postPaymentRequest = await PaymentRequestService.Post<PaymentUpsertRequest>(paymentUpsertRequest);
            if (postPaymentRequest != null)
            {
                AutoClosingMessageBox.Show("Zahtjev poslan!", "Zahtjev za plaćanje je uspješno poslan.", 3000);
                this.Close();
            }
        }

        private async Task posaljiNotifikacijuAsync(string komentar = "", string naslov = "", string fcmToken = "")
        {
            string fcmServerKey = "AAAAbOMTstM:APA91bFkF0lQHgpECturTYijOzuGRsduCjtvIGnCRH1AiSDuorCxNAuUmvdxhyJJ-MAXyatpfpsZrX8XQykh0ql_3i2-p9vVObo4gbdibGmsC9ah8qS2v9KQbaCQ0fdE1YlY4An9iV72";
            string fcmEndpoint = "https://fcm.googleapis.com/fcm/send";

            var httpClient = new HttpClient();
            var fcmNotification = new FCMNotification
            {
                to = fcmToken,
                notification = new notification
                {
                    title = naslov,
                    body = komentar
                }
            };

            var json = JsonConvert.SerializeObject(fcmNotification);
            var request = new HttpRequestMessage(HttpMethod.Post, fcmEndpoint);
            request.Headers.TryAddWithoutValidation("Authorization", $"key={fcmServerKey}");
            request.Content = new StringContent(json, System.Text.Encoding.UTF8, "application/json");

            var response = await httpClient.SendAsync(request);
            var responseContent = await response.Content.ReadAsStringAsync();

            Console.WriteLine($"FCM Notification Response: {response.StatusCode} - {responseContent}");
        }
        private void txtNaslov_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNaslov.Text))
            {
                e.Cancel = true;
                txtNaslov.Focus();
                err.SetError(txtNaslov, "Obavezno polje");
            }
            else
            {
                e.Cancel = false;
                err.SetError(txtNaslov, "");
            }
        }

        bool IsNumber(string text)
        {
            Regex regex = new Regex(@"^[-+]?[0-9]*\.?[0-9]+$");
            return regex.IsMatch(text);
        }

        private void txtIznos_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtIznos.Text))
            {
                e.Cancel = true;
                txtIznos.Focus();
                err.SetError(txtIznos, "Obavezno polje!");
            }
            else if (!IsNumber(txtIznos.Text))
            {
                e.Cancel = true;
                txtIznos.Focus();
                err.SetError(txtIznos, "Iznos treba da bude broj.");
            }
            else
            {
                e.Cancel = false;
                err.SetError(txtIznos, "");
            }
        }
    }
}
