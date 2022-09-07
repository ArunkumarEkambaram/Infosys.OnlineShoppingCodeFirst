using Infosys.OnlineShoppingCodeFirst.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Infosys.OnlineShoppingCodeFirst.DAL
{
    public class OnlineShoppingRepository : IDisposable
    {
        private readonly ApplicationDbContext _dbContext = null;

        public OnlineShoppingRepository()
        {
            _dbContext = new ApplicationDbContext();
        }

        public void Dispose()
        {
            GC.SuppressFinalize(_dbContext);
            _dbContext.Dispose();
        }

        //Retreive Genre
        public List<Genre> GetGenres()
        {
            return _dbContext.Genres.ToList();
        }        
                
    }
}
