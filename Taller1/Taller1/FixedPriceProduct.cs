using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace taller0101
{
    public class FixedPriceProduct : Product
    {
        

        public override decimal GetValueToPay()
        {
            return Price * ((decimal)Tax) + Price;
        }
        public override string ToString()
        {
            return $"{base.ToString()}" +
              $"\n\tPrice.......: {$"{Price:C2}",15}" +
              $"\n\tTax.........: {$"{Tax*100:C2}",15}" +
              $"\n\tValue ......: {$"{GetValueToPay():C2}",15}";
        }
    }
}
