using Salesforce.Common;
using Salesforce.Force;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using ToDoList.Project.Models.CustomConfig;

namespace ToDoList.Project.Data.Service_References.Salesforce
{
    public class SalesforceService
    {
        private readonly MyConfig _configuration;
        private AuthenticationClient AuthenticationClient { get; }

        public SalesforceService(MyConfig configuration)
        {
            this.AuthenticationClient = new AuthenticationClient();
            _configuration = configuration;
        }

        public async Task<ForceClient> GetForceClient()
        {
            await this.AuthenticationClient.UsernamePasswordAsync(
                 _configuration.ConsumerKey,
                 _configuration.ConsumerSecret,
                 _configuration.Username,
                 _configuration.Password + _configuration.SecurityToken
                 );
            return new ForceClient(
                this.AuthenticationClient.InstanceUrl,
                this.AuthenticationClient.AccessToken,
                this.AuthenticationClient.ApiVersion);
        }
    }
}
