using System;
using System.Collections.Generic;
using System.Text;
using Interface.Entities;

namespace Interface.Services
{
    class ContractService
    {
        public IOnlinePaymentService OnlinePaymentService { get; private set; }

        public ContractService(IOnlinePaymentService onlinePaymentService)
        {
            OnlinePaymentService = onlinePaymentService;
        }

        public void ProcessContract(Contract contract, int months)
        {
            DateTime date = contract.Date;
            double amount = contract.TotalValue/months;
            for(int i = 1; i<=months; i++)
            {
                DateTime dueTime = date.AddMonths(i);
                contract.List.Add(new Installment(dueTime, OnlinePaymentService.PaymentFee(amount, i)));
            }
        }
    }
}
