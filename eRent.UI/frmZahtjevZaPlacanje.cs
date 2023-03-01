using eRent.Models;
using eRent.Models.Requests.Payment;
using eRent.Models.Search_Objects;
using eRent.UI.Helpers;
using Newtonsoft.Json;
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
            float iznosPoKorisniku = float.Parse(txtIznos.Text) / BrojKorisnika;
            string komentar = txtKomentar.Text;
            string naslov = txtNaslov.Text + " - " + iznosPoKorisniku.ToString()+ " KM";
            KorisnikSearchObject korisnikObj = new KorisnikSearchObject();
            korisnikObj.KorisnikId = 2016;
            List<KorisnikModel> korisnik = await _korisnikService.Get<List<KorisnikModel>>(korisnikObj);
            await posaljiNotifikacijuAsync(komentar, naslov, korisnik[0].FcmDeviceToken);
            await savePaymentRequestToDatabase();
        }

        private void showMessage()
        {
            AutoClosingMessageBox.Show("Zahtjev za plaćanje je uspješno poslan.", "Zahtjev poslan!", 3000);
        }

        private async Task savePaymentRequestToDatabase()
        {
            //TODO add for each customer to send separate payment request
            PaymentUpsertRequest paymentUpsertRequest = new PaymentUpsertRequest();
            paymentUpsertRequest.NekretninaPayment = Nekretnina.NekretninaId;
            paymentUpsertRequest.Komentar = txtKomentar.Text;
            paymentUpsertRequest.Iznos = int.Parse(txtIznos.Text);
            paymentUpsertRequest.Mjesecno = cbMjesecno.Checked;
            paymentUpsertRequest.Naslov = txtNaslov.Text;
            paymentUpsertRequest.IsProcessed = false;
            paymentUpsertRequest.KorisnikPaymentId = 2016;
            var postPaymentRequest = await PaymentRequestService.Post<PaymentUpsertRequest>(paymentUpsertRequest);
            showMessage();
            this.Close();
        }

        private async Task posaljiNotifikacijuAsync(string komentar = "", string naslov = "",string fcmToken = "")
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
    }
}
