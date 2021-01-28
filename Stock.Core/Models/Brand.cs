using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace Stock.Core.Models
{
    public class Brand
    {
        public Brand()
        {

            Products = new Collection<Product>();

        }
        public int BrandID { get; set; }
        public string BrandName { get; set; }
        public string BrandDescription { get; set; }

        public int CategoryID { get; set; }

        public virtual Category Category { get; set; }

        public ICollection<Product> Products { get; set; }
    }
}
