using System;
using System.Threading.Tasks;
using Microsoft.Graph;
using Microsoft.Graph.Auth;
using Microsoft.Graph.Core;
using Microsoft.Identity.Client;

namespace FirstGraphApp
{
    class Program
    {
        static async Task Main(string[] args)
        {
            //Auth Process
            //creat variables
            string clientID = "fa066690-a151-458d-a393-7d8459853c83";
            string tenantID = "d4023def-41d0-46cd-922f-985e54a71bd4";
            string clientSecret = "P1f_Xp-~9f5brS5-A0g8eUEgXhkX~YiSOc";
            //create client application
            IConfidentialClientApplication confidentialClientApplication = ConfidentialClientApplicationBuilder
                .Create(clientID)
                .WithTenantId(tenantID)
                .WithClientSecret(clientSecret)
                .Build();

            //Create an authentication provider by passing in a client application
            ClientCredentialProvider authProvider = new ClientCredentialProvider(confidentialClientApplication);
            // Create a new instance of GraphServiceClient with the authentication provider.
            GraphServiceClient graphClient = new GraphServiceClient(authProvider);

            var users = await graphClient.Users
                .Request()
                .GetAsync();
            // look at and report results
            foreach(User in users)
            {

            }
        }
    }
}
