using Microsoft.AspNetCore.Routing;

namespace YourNamespace.Configuration
{
    public static class AreaRouteExtensions
    {
        public static void MapCustomAreaRoutes(this IEndpointRouteBuilder endpoints)
        {
            endpoints.MapAreaControllerRoute(
                name: "LegalTerms",
                areaName: "Legal",
                pattern: "termsandconditions",
                defaults: new { controller = "Legal", action = "TermsAndConditions" });

            endpoints.MapAreaControllerRoute(
                name: "LegalPrivacy",
                areaName: "Legal",
                pattern: "privacypolicy",
                defaults: new { controller = "Legal", action = "PrivacyPolicy" });
        }
    }
}