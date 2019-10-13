using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using ToDoList.Project.Models.Contracts;
using ToDoList.Project.Models.CustomConfig;
using ToDoList.Project.Models.Entities;
namespace ToDoList.Project.Data.Repositories
{
    public class ToDoListRepository : Repository<Models.Entities.ToDoList>, IToDoListRepository
    {
        public ToDoListRepository(IOptions<MyConfig> config) : base(config)
        {

        }

        public async Task<Models.Entities.ToDoList> GetWithChild(string parentId, string sfChildObject, string[] includedParentFields, params string[] includedChildFields)
        {
            var query = new StringBuilder();
            query.Append("SELECT Id,");
            for (int i = 0; i < includedParentFields.Length; i++)
            {
                query.Append(includedParentFields[i] + ",");
            }
            query.Append("(SELECT Id,");
            for (int i = 0; i < includedChildFields.Length; i++)
            {
                query.Append(includedChildFields[i] + ",");
            }
            query.Remove(query.Length - 1, 1);
            query.AppendFormat(" FROM {0})", sfChildObject);
            query.AppendFormat(" FROM ToDoList__c WHERE Id='{0}'", parentId);
            var result = await base._client.QueryAsync<Models.Entities.ToDoList>(query.ToString());
            return result.Records[0];
        }


    }
}