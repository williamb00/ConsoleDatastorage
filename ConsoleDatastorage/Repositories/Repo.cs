﻿using ConsoleDatastorage.Contexts;
using Microsoft.EntityFrameworkCore.Query.SqlExpressions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleDatastorage.Repositories
{
    internal class Repo<TEntity> where TEntity : class
    {
        private readonly DataContext _context;

        public Repo(DataContext context)
        {
            _context = context;
        }



        public virtual TEntity Create(TEntity entity)
        {
            _context.Set<TEntity>().Add(entity);
            _context.SaveChanges();
            return entity;
        }

        public virtual IEnumerable<TEntity> GetAll()
        {
            return _context.Set<TEntity>().ToList();
        }

        public virtual TEntity Get(Expression<Func<TEntity, bool>> expression)
        {
            var entity = _context.Set<TEntity>().FirstOrDefault(expression);
            return entity!;
        }

        public virtual TEntity Update(Expression<Func<TEntity, bool>> expression, TEntity entity)
        {
            var entityToUpdate = _context.Set<TEntity>().FirstOrDefault(expression);
            _context.Entry(entityToUpdate!).CurrentValues.SetValues(entity);
            _context.SaveChanges();

            return entityToUpdate!;
        }


        public virtual void Delete(Expression<Func<TEntity, bool>> expression)
        {
            var entity = _context.Set<TEntity>().FirstOrDefault(expression);
            _context.Remove(entity!);
            _context.SaveChanges();
        }


    }
}
