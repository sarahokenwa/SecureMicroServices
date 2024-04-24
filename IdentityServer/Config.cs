using IdentityServer4.Models;
using IdentityServer4.Test;
using IdentityServer4.Validation;

namespace IdentityServer
{
    public class Config
    {
        public static IEnumerable<Client> Clients =>
            new Client[]
            {
               new Client
               {
                   ClientId = "filmClient",
                   AllowedGrantTypes = GrantTypes.ClientCredentials,
                   ClientSecrets =
                   {
                       new Secret("secret".Sha256())
                   },
                   AllowedScopes = {"filmAPI" }
               } 
            };

        public static IEnumerable <ApiResource> ApiResources =>
            new ApiResource[]
            {

            };

        public static IEnumerable <ApiScope> ApiScopes => 
            new ApiScope[]
            { 
                new ApiScope("filmAPI", "Films API")
            };

        public static IEnumerable<IdentityResource> IdentityResources =>
            new IdentityResource[] 
            {
            
            };

        public static List <TestUser> TestUsers =>
            new List<TestUser>
            {

            };

    }
}
