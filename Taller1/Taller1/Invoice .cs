using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace taller0101
{
    public class Invoice : Ipay
    {
        private List<Product> _products;

        public Invoice() { 
            _products=new List<Product>();
        }
    public decimal GetValueToPay()
        {
            decimal total = 0;
            foreach (Product p in _products)
            {

               total=total+p.GetValueToPay();

            }
            return total;

        }


        public void AddProduct(Product producto)
        {
            _products.Add(producto);
 
        }
        public override string ToString()
        {
            Console.WriteLine("RECEIPT");
            Console.WriteLine("-------------------------------------------------");
            foreach (Product p in _products)
            {
                Console.WriteLine(p.ToString());
            }
                return $"\n\t==============="+
              $"\n\tValue ......: {$"{GetValueToPay():C2}",15}";
        }

    }
}
