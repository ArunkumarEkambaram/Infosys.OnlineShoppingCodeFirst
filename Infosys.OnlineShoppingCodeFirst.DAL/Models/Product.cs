using System;
using System.Collections.Generic;
using System.Text;

namespace Infosys.OnlineShoppingCodeFirst.DAL.Models
{
    public class Product
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }

        //Auditable Columns
        public DateTime AddedDate { get; set; } = DateTime.Now;
        public DateTime? ModifiedDate { get; set; }

    }
}
