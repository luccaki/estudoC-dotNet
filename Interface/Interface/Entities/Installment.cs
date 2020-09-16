using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace Interface.Entities
{
    class Installment
    {
        public DateTime DueTime { get; private set; }
        public double Amount { get; private set; }

        public Installment(DateTime dueTime, double amount)
        {
            DueTime = dueTime;
            Amount = amount;
        }
    }
}
