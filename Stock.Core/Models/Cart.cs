using System;
using System.Collections.Generic;
using System.Text;

namespace Stock.Core.Models
{
  public  class Cart
    {

        public int CartID { get; set; }
        public int ProductID { get; set; }

        public int CategoryID { get; set; }
        public int BrandID { get; set; }

        public string BarcodeNo { get; set; }

        public decimal PurchasePrice { get; set; }
        public decimal SallingPrice{ get; set; }

        public decimal TotalPrice { get; set; }

        public int Pieces { get; set; }

        public DateTime CartAddDate { get; set; }

        public virtual Product Product { get; set; }
        public virtual Category Category { get; set; }

        public virtual Brand Brand { get; set; }


    }
}
