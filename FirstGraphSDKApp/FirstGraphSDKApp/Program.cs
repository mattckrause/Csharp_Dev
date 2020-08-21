using System;
using Microsoft.Graph;
using Microsoft.Graph.Auth;
using Microsoft.Graph.Core;

namespace GraphTutorial
{
    class Program
    {
        private static void Main()
        {
            confidentialClientApplication confidentialClientApplication = ConfidentialClientApplicationBuilder
                .Create("fa066690 - a151 - 458d - a393 - 7d8459853c83")
                .WithTenantId("d4023def-41d0-46cd-922f-985e54a71bd4")
                .WithClientSecret("P1f_Xp-~9f5brS5-A0g8eUEgXhkX~YiSOc")
                .Build();

            ClientCredentialProvider authenticationProvider = new ClientCredentialProvider(confidentialClientApplication);
        }
    }
}