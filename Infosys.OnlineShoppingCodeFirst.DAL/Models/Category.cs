using System;
using System.Collections.Generic;
using System.Text;

namespace Infosys.OnlineShoppingCodeFirst.DAL.Models
{
    public class Category
    {
        public int Id { get; set; }        
        public string CategoryName { get; set; }

        //Navigation Property
        public Product Product { get; set; }
    }
}
