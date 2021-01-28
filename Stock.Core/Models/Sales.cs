using System;
using System.Collections.Generic;
using System.Text;

namespace Stock.Core.Models
{
    public class Sales
    {

        public int SalesID { get; set; }

        public int ProductID { get; set; }

        public int CartID { get; set; }
        public string BarcodeNo { get; set; }

        public decimal UnitPrice { get; set; }

        public int Pieces { get; set; }

        public decimal TotalPrice { get; set; }

        public DateTime SallinDate { get; set; }

        public virtual Product Product { get; set; }

        public virtual Cart Cart { get; set; }

    }

    }
