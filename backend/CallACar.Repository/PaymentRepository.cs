using System;
using System.Linq;
using CallACarr.Domain;

namespace CallACar.Repository
{
    public class PaymentRepository : AbstractRepository<Payment>
    {
        public PaymentRepository(){
            Entities = DatabaseMock.Payments.ToList();
        }
    }
}