using IdentityModel;
using IdentityServer4;
using IdentityServer4.Models;
using IdentityServer4.Test;
using IdentityServer4.Validation;
using System.Security.Claims;

namespace IdentityServer
{
    public class Config
    {
        public static IEnumerable<Client> Clients =>
            new Client[]
            {
               new Client
               {
                   //ClientId = "filmClient",
                   ClientId = "movieClient",
                   AllowedGrantTypes = GrantTypes.ClientCredentials,
                   ClientSecrets =
                   {
                       new Secret("secret".Sha256())
                   },
                   AllowedScopes = {"movieAPI" }
                  // AllowedScopes = {"filmAPI" }
               },
               new Client
               {
                   ClientId = "movies_mvc_client",
                   ClientName = "Movies Mvc Web App",
                   AllowedGrantTypes= GrantTypes.Code,
                   AllowRememberConsent = false,
                   RedirectUris = new List<string>()
                   {
                       "https://localhost:7054/signin-oidc"

                   },
                   PostLogoutRedirectUris = new List<string>()
                   {
                       "https://localhost:7054/signout-callback-oidc"
                   },
                   ClientSecrets = {
                        new Secret("secret".Sha256())
                   },
                   AllowedScopes = new List<string>()
                   {
                       IdentityServerConstants.StandardScopes.OpenId,
                       IdentityServerConstants.StandardScopes.Profile
                   }

               }
            };

        public static IEnumerable <ApiResource> ApiResources =>
            new ApiResource[]
            {

            };

        public static IEnumerable <ApiScope> ApiScopes => 
            new ApiScope[]
            { 
               // new ApiScope("filmAPI", "Film API")
               new ApiScope("movieAPI", "Movie API")
            };

        public static IEnumerable<IdentityResource> IdentityResources =>
            new IdentityResource[] 
            {
                new IdentityResources.OpenId(),
                new IdentityResources.Profile()

            };

        public static List <TestUser> TestUsers =>
            new List<TestUser>
            {
                new TestUser()
                {
                    SubjectId = Guid.NewGuid().ToString(),
                    Username = "duchess",
                    Password = "duchess",
                    Claims = new List<Claim>
                    {
                        new Claim(JwtClaimTypes.GivenName, "duchess"),
                        new Claim(JwtClaimTypes.FamilyName, "duke")
                    }
                }
            };

    }
}
