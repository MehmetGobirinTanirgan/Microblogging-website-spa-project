﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using TwitterCore.Entities.CoreEntities;

namespace TwitterRepository.ComplexEntityRepository
{
    public interface IComplexEntityRepository<T> where T : ComplexEntity
    {
        Task CreateAsync(T entity);
        Task UpdateAsync(T entity);
        Task DeleteAsync(T entity);
        Task DeleteAsync(Guid id);      
        Task SaveAsync();
        Task<bool> AnyAsync(Expression<Func<T, bool>> exp);
        Task<T> GetOneByIDAsync(Guid id);
        Task<T> GetOneByExpressionAsync(Expression<Func<T, bool>> exp);
        IQueryable<T> GetAll();
        IQueryable<T> GetActives();
        IQueryable<T> GetListByExpression(Expression<Func<T, bool>> exp);      
       
    }
}