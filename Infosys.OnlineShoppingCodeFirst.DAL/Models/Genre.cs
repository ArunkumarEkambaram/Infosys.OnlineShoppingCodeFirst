using System;
using System.Collections.Generic;
using System.Text;

namespace Infosys.OnlineShoppingCodeFirst.DAL.Models
{
    public class Genre
    {
        public int Id { get; set; }
        public string GenreName { get; set; }

        public Movie Movie { get; set; }
    }
}
