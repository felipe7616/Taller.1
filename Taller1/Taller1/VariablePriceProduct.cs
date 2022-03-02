using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace taller0101
{
    public class VariablePriceProduct : Product
    {
        public string Measurement { get; set; }
        public float Quantity { get; set; }
        public override decimal GetValueToPay()
        {
            return Price * (decimal)Quantity * ((decimal)Tax) + Price * (decimal)Quantity;
        }
        public override string ToString()
        {
            return $"{base.ToString()}" +
              $"\n\tMeasurement.: {Measurement}"+
              $"\n\tQuantity....: {$"{Quantity:C2}",15}" +
              $"\n\tPrice.......: {$"{Price:N2}",15}" +
              $"\n\tTax..........: {$"{Tax*100:C2}"+"%",15}" +
              $"\n\tValue.......: {$"{GetValueToPay():C2}",15}";
        }
    }
}
