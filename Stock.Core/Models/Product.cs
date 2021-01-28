using System;
using System.Collections.Generic;
using System.Text;

namespace Stock.Core.Models
{
   public class Product
    {

        public int ProductID { get; set; }
        public string ProductName { get; set; }

        public string BarcodeNo { get; set; }

        public decimal PurchasePrice { get; set; }

        public decimal SallingPrice { get; set; }

        public DateTime AddingDate  { get; set; }

        public string ProductDescription { get; set; }

        public int  CategoryID { get; set; }

        public int UnitID { get; set; }

        public int BrandID { get; set; }

        public virtual Unit Unit { get; set; }

        public virtual Category Category { get; set; }

        public virtual  Brand Brand { get; set; }









    }
}
