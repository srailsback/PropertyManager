using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PropertyManager.Infrastructure.Repositories
{
    public class BaseRepository
    {
        protected readonly DataContext _context;
        public BaseRepository(DataContext context)
        {
            this._context = context;
        }
    }
}