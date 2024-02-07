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
    internal class BrandRepository : Repo<BrandEntity>
    {
        public BrandRepository(DataContext context) : base(context)
        {
        }

        internal void Delete(int id)
        {
            throw new NotImplementedException();
        }

        internal BrandEntity GetById(int id)
        {
            throw new NotImplementedException();
        }

        internal BrandEntity Update(BrandEntity brandEntity)
        {
            throw new NotImplementedException();
        }
    }
}
