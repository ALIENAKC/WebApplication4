using Abp.Domain.Entities;
using Abp.Domain.Uow;
using MailChimp.Net.Models;
using Microsoft.VisualStudio.Services.Account;
using Octopus.Client.Repositories.Async;
using System;

public interface IRepository<TEntity>
    where TEntity : IEntity
{
    Task<TEntity> GetById(Guid Id);
    Task<IReadOnlyList<TEntity>> GetAll();
    Task Add(TEntity entity);
    Task Update(TEntity entity);
}