using Salesforce.Common.Models.Json;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using ToDoList.Project.Models.Entities;

namespace ToDoList.Project.Models.Contracts
{
    public interface IRepository<TEntity> where TEntity : class, IEntity, new()
    {
        Task<List<TEntity>> Get(string sfObject, params string[] includedFields);
        Task<TEntity> GetById(string id, string sfObject, params string[] includedFields);
        Task<SuccessResponse> Insert(TEntity entity);
        Task<SuccessResponse> Update(TEntity entity);
        Task<bool> Delete(string id,string sfObject);
    }
}
