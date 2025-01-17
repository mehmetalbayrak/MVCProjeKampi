﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstract
{
    public interface IRepository<T>
    {
        T Get(Expression<Func<T, bool>> filter);
        List<T> List();
        void Insert(T entity);
        void Update(T entity);
        void Delete(T entity);

        List<T> List(Expression<Func<T, bool>> filter);
    }
}
