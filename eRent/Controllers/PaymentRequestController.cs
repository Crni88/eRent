using eRent.Models;
using eRent.Models.Requests.Payment;
using eRent.Models.Search_Objects;
using eRent.Services.Payment;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace eRent.Controllers
{
    public class PaymentRequestController :
        BaseCRUDController<PaymentRequestModel, PaymentRequestSearchObject, PaymentUpsertRequest, PaymentUpsertRequest>
    {
        public PaymentRequestController(IPaymentRequestService service) : base(service)
        {
        }
    }
}
