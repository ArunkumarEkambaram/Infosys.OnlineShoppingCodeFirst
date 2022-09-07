using System;
using System.Collections.Generic;
using System.Text;

namespace Infosys.OnlineShoppingCodeFirst.DAL.Models
{
    public class Movie
    {
        public int Id { get; set; }
        public string MovieName { get; set; }
        public string Language { get; set; }
        public string Actors { get; set; }
        public decimal Budget { get; set; }
        public DateTime? ReleaseDate { get; set; }

        //Navigation Property
        public Genre Genre { get; set; }

        //Genre -FK
        public int GenreId { get; set; }

        //Collection or List
        public List<Genre> Genres { get; set; } 

    }
}
