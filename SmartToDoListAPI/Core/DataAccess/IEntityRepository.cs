﻿
using SmartToDoListAPI.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace Core.DataAccess
{
    public interface IEntityRepository<T> where T : class, IEntity, new()
    {
        T Get(Expression<Func<T, bool>> filter, Expression<Func<T, object>>[] includes = null);
        IList<T> GetList(Expression<Func<T, bool>> filter = null, Expression<Func<T, object>>[] includes = null);
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
    }
}
