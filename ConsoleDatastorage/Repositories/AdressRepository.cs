using ConsoleDatastorage.Contexts;
using ConsoleDatastorage.Entities;
using ConsoleDatastorage.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleDatastorage.Repositories
{
    internal class AdressRepository : Repo<AdressEntity>
    {
        public AdressRepository(DataContext context) : base(context)
        {
        }
    }
}
