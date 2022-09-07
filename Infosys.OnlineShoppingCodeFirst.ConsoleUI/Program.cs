using Infosys.OnlineShoppingCodeFirst.DAL;
using Infosys.OnlineShoppingCodeFirst.DAL.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;

namespace Infosys.OnlineShoppingCodeFirst.ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            //using (OnlineShoppingRepository repository = new OnlineShoppingRepository())
            //{
            //    //var genres = repository.GetGenres();
            //    //Console.WriteLine($"Genre Id\tGenre Name");
            //    //Console.WriteLine("--------------------------");
            //    //foreach (var g in genres)
            //    //{
            //    //    Console.WriteLine($"{g.Id}\t{g.GenreName}");
            //    //}



            //}

            //Movie and GenreName
            //using (var context = new ApplicationDbContext())
            //{
            //    var movieDetails = context.Movies.Select(m => new
            //    {
            //        MovieName = m.MovieName,
            //        ActorName = m.Actors,
            //        Budget = m.Budget,
            //        GenreName = m.Genre.GenreName
            //    });
            //    foreach (var item in movieDetails)
            //    {
            //        Console.WriteLine($"Name :{item.MovieName}\tActor :{item.ActorName}\tBudget :{item.Budget}\tGenre Name :{item.GenreName}");
            //    }
            //}
        }
    }
}
