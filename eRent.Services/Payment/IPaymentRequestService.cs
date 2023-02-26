using eRent.Models.Requests.Payment;
using eRent.Models.Search_Objects;

namespace eRent.Services.Payment
{
    public interface IPaymentRequestService : ICRUDService<Models.PaymentRequestModel,PaymentRequestSearchObject,PaymentUpsertRequest, PaymentUpsertRequest>
    {
    }
}
