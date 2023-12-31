﻿using ParkCinema.Domain.Entities.Common;
using System.Linq.Expressions;

namespace ParkCinema.Application.Abstraction.Repositories;

public interface IReadRepository<T>:IRepository<T> where T : BaseEntity, new()
{
    IQueryable<T> GetAll(bool isTracking = true, params string[] inculdes);
    IQueryable<T> GetAllExpression(Expression<Func<T, bool>> expression, int Skip, int Take, bool isTracking = true, params string[] inculdes);
    IQueryable<T> GetAllExpressionOrderBy(Expression<Func<T, bool>> expression, int Skip, int Take, Expression<Func<T, object>> expressionOrder, bool IsOrder = true, bool IsTracking = true, params string[] inculdes);
    Task<T> GetByIdAsync(Guid id);
    Task<T> GetByIdAsyncExpression(Expression<Func<T, bool>> expression, bool isTracking = true);
}
