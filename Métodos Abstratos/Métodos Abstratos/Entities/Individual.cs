using System;
using System.Collections.Generic;
using System.Text;

namespace Métodos_Abstratos.Entities
{
    class Individual : TaxPayer
    {
        public double HealthExpenditures { get; set; }

        public Individual()
        {
        }

        public Individual(string name, double anualIncome, double healthExpenditures)
            : base(name, anualIncome)
        {
            HealthExpenditures = healthExpenditures;
        }

        public override double Tax()
        {
            if (AnualIncome < 2000)
            {
                return (AnualIncome * 0.15) - (HealthExpenditures * 0.50);
            }
            else 
            {
                return (AnualIncome * 0.25) - (HealthExpenditures * 0.50);
            }
        }
    }
}
