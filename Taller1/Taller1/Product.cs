using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace taller0101
{
	public abstract class Product: Ipay
    {
		 public int Id { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public float Tax { get; set; }

        public abstract decimal GetValueToPay();
        public override string ToString()
        {
            return $"{Id} - {Description} " ;
        }
    }
}
