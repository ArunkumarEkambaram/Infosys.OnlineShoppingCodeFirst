using System;
using System.Collections.Generic;
using System.Text;

namespace Infosys.OnlineShoppingCodeFirst.DAL.Models
{
    public class Order
    {
        public int OrderId { get; set; }
        public DateTime OrderDate { get; set; }
        public int OrderedQuantity { get; set; }
        public DateTime? ActualDeliveryDate { get; set; }
        public DateTime EstimatedDeliveryDate { get; set; } = DateTime.Now.AddDays(5);

        //Navigation Property or Reference Table
        public Product Product { get; set; }

        //Foreign Key - Naming Convention - ReferenceTableNameId or ReferenceTableName_Id
        public int ProductId { get; set; }

        //Navigation Property - Customer
        public Customer Customer { get; set; }

        //FK - Customer
        public int CustomerId { get; set; }
    }
}
