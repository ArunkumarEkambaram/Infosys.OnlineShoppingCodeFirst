using System;
using System.Collections.Generic;
using System.Text;

namespace Infosys.OnlineShoppingCodeFirst.DAL.Models
{
    public class City
    {
        public int Id { get; set; }
        public string CityName { get; set; }

        //Navigation Property
        public CityInformation CityInformation { get; set; }

        //FK
        public int CityInformationId { get; set; }
    }
}
