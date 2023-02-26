using AutoMapper;
using eRent.Models;
using eRent.Models.Requests.Payment;
using eRent.Models.Search_Objects;
using eRent.Services.DataDB;

namespace eRent.Services.Payment
{
    public class PaymentRequestService
        : BaseCRUDService<PaymentRequestModel, DataDB.PaymentRequest, PaymentRequestSearchObject, PaymentUpsertRequest, PaymentUpsertRequest>, IPaymentRequestService
    {
        public PaymentRequestService(ERentContext eRentContext, IMapper mapper) : base(eRentContext, mapper)
        {
        }

        public override void BeforeInsert(PaymentUpsertRequest insert, DataDB.PaymentRequest entity)
        {
            entity.Nekretnina =
               Context.Nekretninas.Where(x => x.NekretninaId == insert.NekretninaPayment).Select(x => x.NazivNekretnine).FirstOrDefault();

            base.BeforeInsert(insert, entity);
        }
    }
}
