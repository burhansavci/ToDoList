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
        private MyConfig _configuration { get; set; }
        private AuthenticationClient AuthenticationClient { get; }
        private static SalesforceService Instance = null;
        private static object pLock = new object();

        private SalesforceService()
        {
            this.AuthenticationClient = new AuthenticationClient();
        }

        internal static SalesforceService GetSalesforceService
        {
            get
            {
                lock (pLock)
                {
                    if (Instance == null)
                    {
                        Instance = new SalesforceService();
                    }
                }
                return Instance;
            }
        }
        internal void InitConfig(MyConfig configuraton)
        {
            _configuration = configuraton;
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
