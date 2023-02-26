using System;
using System.Collections.Generic;
using System.Text;

namespace eRent.Models.Requests.Payment
{
    public class PaymentUpsertRequest
    {
        public string Naslov { get; set; }  
        public int NekretninaPayment { get; set; }

        public string Komentar { get; set; }

        public double Iznos { get; set; }

        public bool? Mjesecno { get; set; }

    }
}
