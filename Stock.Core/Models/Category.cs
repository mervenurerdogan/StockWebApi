using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace Stock.Core.Models
{
   public class Category
    {

        public Category()
        {
            Products = new Collection<Product>();
            Brands = new Collection<Brand>();
        }

        public int CategoryID { get; set; }
        public string CategoryName { get; set; }
        public string CategoryDescription { get; set; }

        public ICollection<Product> Products { get; set; }

        public ICollection<Brand> Brands { get; set; }
    }
}
