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
    internal class ProductReviewRepository : Repo<ProductReviewEntity>
    {
        public ProductReviewRepository(DataContext context) : base(context)
        {
        }
    }
}
