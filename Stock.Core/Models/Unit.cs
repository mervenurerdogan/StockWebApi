using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace Stock.Core.Models
{
  public  class Unit
    {

        public Unit()
        {
            Products = new Collection<Product>();
        }
        public int UnitID { get; set; }
        public string UnitName { get; set; }
        public string UnitDestription { get; set; }


        public ICollection<Product> Products { get; set; }

    }
}
