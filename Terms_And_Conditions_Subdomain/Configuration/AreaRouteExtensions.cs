using Microsoft.AspNetCore.Routing;

namespace YourNamespace.Configuration
{
    public static class AreaRouteExtensions
    {
        public static void MapCustomAreaRoutes(this IEndpointRouteBuilder endpoints)
        {
            endpoints.MapAreaControllerRoute(
                name: "Legal",
                areaName: "Legal",
                pattern: "Legal/{controller=Legal}/{action=TermsAndConditions}/{id?}");
        }
    }
}