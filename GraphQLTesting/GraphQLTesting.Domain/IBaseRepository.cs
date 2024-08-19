﻿namespace GraphQLTesting.Domain;

public interface IBaseRepository<T> where T : class
{
    Task<T> GetByIdAsync(int id);

    Task<T> CreateAsync(T entity);

    Task<T> UpdateAsync(T entity);

    Task DeleteAsync(T entity);
}
