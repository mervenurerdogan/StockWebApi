using System;
using System.Collections.Generic;
using System.Text;

namespace Stock.Core.Models
{
  public   class Customer
    {

        public int CustomerID { get; set; }
        public  string CustomerName { get; set; }

        public string CustomerSurname { get; set; }
        public string Mail { get; set; }

        public string Phone { get; set; }
        public string RegisteredDate { get; set; }

        public string Password { get; set; }

    }
}
