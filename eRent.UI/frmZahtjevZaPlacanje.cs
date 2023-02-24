using eRent.Models;
using eRent.Models.Requests.Payment;
using eRent.UI.Helpers;
using Newtonsoft.Json;
namespace eRent.UI
{
    public partial class frmZahtjevZaPlacanje : Form
    {
        public int BrojKorisnika { get; }
        public NekretninaModel Nekretnina { get; }

        public APIService PaymentRequestService { get; set; } = new APIService("PaymentRequest");

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
            string naslov = txtNaslov.Text + " - " + iznosPoKorisniku.ToString();
            await posaljiNotifikacijuAsync(komentar, naslov);
            await savePaymentRequestToDatabase();
        }

        private async Task savePaymentRequestToDatabase()
        {
            PaymentUpsertRequest paymentUpsertRequest = new PaymentUpsertRequest();
            paymentUpsertRequest.NekretninaPayment = Nekretnina.NekretninaId;
            var postPaymentRequest = await PaymentRequestService.Post<PaymentUpsertRequest>(paymentUpsertRequest);
            this.Close();
        }

        private async Task posaljiNotifikacijuAsync(string komentar = "", string naslov = "")
        {
            string fcmServerKey = "AAAAbOMTstM:APA91bFkF0lQHgpECturTYijOzuGRsduCjtvIGnCRH1AiSDuorCxNAuUmvdxhyJJ-MAXyatpfpsZrX8XQykh0ql_3i2-p9vVObo4gbdibGmsC9ah8qS2v9KQbaCQ0fdE1YlY4An9iV72";
            string fcmEndpoint = "https://fcm.googleapis.com/fcm/send";

            var httpClient = new HttpClient();
            var fcmNotification = new FCMNotification
            {
                to = "fuGeT558TbuDxLBxBrdj9V:APA91bFesLcGV5TWw7Vy43Yhlg8VqN01nvebfqqtFreVvEZR_Iw0_4BouTqyMC09OGooTb8oPTfx5X889K8jfVoMtVG6NLfkFmdT9wT7Mu9BcQQ6XEoTRklXCanyAf257QiiZ-2mvVnV",
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
