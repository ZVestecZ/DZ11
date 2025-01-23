using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ_10_14
{
    [DeveloperInf("Берсенев Семён", "2025-01-15")]
    [DeveloperInf("Васильков Артём", "2025-01-20")]
    public class RationalNumber
    {
        public int Numerator { get; set; }
        public int Denominator { get; set; }

        public RationalNumber(int numerator, int denominator)
        {
            Numerator = numerator;
            Denominator = denominator;
        }

        public override string ToString()
        {
            return $"{Numerator}/{Denominator}";
        }
    }

}
