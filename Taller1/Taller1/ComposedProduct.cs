using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace taller0101
{
    public class ComposedProduct : Product
    {
        public float Discount { get; set; }
        public List<Product> Products { get; set; }
        public override decimal GetValueToPay()
        {
            decimal total = 0;
            foreach (Product p in Products)
            {
                
                total=total+p.GetValueToPay();
                  
                
            }
            return total - (total*(decimal)Discount);
        }
        public override string ToString()
        { String productsConcat="";
            foreach (Product p in Products)
            {
                if (p.Equals(Products.Last()))
                {
                    productsConcat = productsConcat + p.Description ;
                }
                else
                {
                    productsConcat = productsConcat + p.Description+", ";
                }
                
            }

            return $"{base.ToString()}" +
              $"\n\tProducts.......:{productsConcat}" + 
              $"\n\tDiscount.....:{$"{Discount*100:C2}",15}" +
              $"\n\tValue to pay: {$"{GetValueToPay():C2}",15}";
        }
    }
}
									