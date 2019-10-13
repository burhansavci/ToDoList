using Microsoft.Extensions.Options;
using Salesforce.Common.Models.Xml;
using Salesforce.Force;
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDoList.Project.Data.Service_References.Salesforce;
using ToDoList.Project.Models.Contracts;
using ToDoList.Project.Models.CustomConfig;
using ToDoList.Project.Models.Entities;

namespace ToDoList.Project.Data.Repositories
{
    public class Repository<TEntity> : IRepository<TEntity> where TEntity : class, IEntity, new()
    {
        private readonly IOptions<MyConfig> _config;
        protected readonly ForceClient _client;
        public Repository(IOptions<MyConfig> config)
        {
            _config = config;
            _client = new SalesforceService(_config.Value).GetForceClient().Result;
        }

        public async Task<List<TEntity>> Get(string sfObject, params string[] includedFields)
        {
            var query = new StringBuilder();
            query.Append("SELECT Id,");
            for (int i = 0; i < includedFields.Length; i++)
            {
                query.Append(includedFields[i] + ",");
            }
            query.Remove(query.Length - 1, 1);
            query.AppendFormat(" FROM {0}", sfObject);
            var result = await _client.QueryAsync<TEntity>(query.ToString());
            return result.Records;
        }

        public async Task<TEntity> GetById(string id, string sfObject, params string[] includedFields)
        {
            var query = new StringBuilder();
            query.Append("SELECT Id,");
            for (int i = 0; i < includedFields.Length; i++)
            {
                query.Append(includedFields[i] + ",");
            }
            query.Remove(query.Length - 1, 1);
            query.AppendFormat(" FROM {0} WHERE Id='{1}'", sfObject, id);
            var result = await _client.QueryAsync<TEntity>(query.ToString());
            return result.Records[0];
        }

        public async Task<string> Insert(TEntity entity)
        {
            var successResponse = await _client.CreateAsync(entity.GetType().Name + "__c", entity);
            return successResponse.Id;
        }

        public async Task<string> Update(TEntity entity)
        {
            IDictionary<string, object> sfObjectFields = new ExpandoObject();

            foreach (var propInfo in entity.GetType().GetProperties())
            {
                var propValue = propInfo.GetValue(entity);
                if (propInfo.Name == "Id" || propValue == null)
                    continue;
                sfObjectFields.Add(propInfo.Name, propValue);
            }
            var successResponse = await _client.UpdateAsync(entity.GetType().Name + "__c", entity.Id, sfObjectFields);
            return successResponse.Id;
        }

        public async Task<bool> Delete(string id, string sfObject)
        {
            var succesResponse = await _client.DeleteAsync(sfObject, id);
            return succesResponse;
        }
       
    }
}

