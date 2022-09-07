using System;
using System.Collections.Generic;
using System.Text;

namespace Infosys.OnlineShoppingCodeFirst.DAL.Models
{
    public class CityInformation
    {
        public int Id { get; set; }
        public double Population { get; set; }

        //Navigation Property
        public City City { get; set; }
    }
}
