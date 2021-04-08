using System;
using System.Collections.Generic;
using CallACar.Repository;
using CallACarr.Domain;

namespace CallACar.Logic
{
    public class PaymentLogic
    {
        private AbstractRepository<Payment> _paymentRepository = new PaymentRepository();

        public object ProcessPayment(Payment payment)
        {
            throw new NotImplementedException();
        }
    }
}