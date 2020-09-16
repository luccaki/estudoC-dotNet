using System;
using System.Collections.Generic;
using System.Text;

namespace Interface.Services
{
    class PaypalService : IOnlinePaymentService
    {
        public double PaymentFee(double amount, int months)
        {
            return (amount * ((0.01*months)+1)) * 1.02;
        }
    }
}
