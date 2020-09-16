using System;
using System.Collections.Generic;
using System.Text;

namespace Interface.Services
{
    interface IOnlinePaymentService
    {
        double PaymentFee(double amount, int months);
    }
}
