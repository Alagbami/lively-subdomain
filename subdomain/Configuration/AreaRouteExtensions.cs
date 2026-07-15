using Microsoft.AspNetCore.Routing;

namespace Lively.ModuleTraining.Configuration;

public static class AreaRouteExtensions
{
    public static IEndpointRouteBuilder MapModuleAreaRoutes(
        this IEndpointRouteBuilder endpoints)
    {
        endpoints.MapAreaControllerRoute(
            name: "ContactArea",
            areaName: "Contact",
            pattern: "Contact/{controller=Home}/{action=Index}/{id?}");

        endpoints.MapAreaControllerRoute(
            name: "CreatorArea",
            areaName: "Creator",
            pattern: "Creator/{controller=Home}/{action=Index}/{id?}");

        endpoints.MapAreaControllerRoute(
            name: "BlogsArea",
            areaName: "Blogs",
            pattern: "Blogs/{controller=Blog}/{action=Index}/{id?}");

        endpoints.MapAreaControllerRoute(
            name: "HelpCentreArea",
            areaName: "HelpCentre",
            pattern: "HelpCentre/{controller=Home}/{action=Index}/{id?}");

        endpoints.MapAreaControllerRoute(
            name: "SellerAcademyArea",
            areaName: "SellerAcademy",
            pattern: "SellerAcademy/{controller=Home}/{action=Index}/{id?}");

        endpoints.MapAreaControllerRoute(
            name: "CreatorAcademyArea",
            areaName: "CreatorAcademy",
            pattern: "CreatorAcademy/{controller=Home}/{action=Index}/{id?}");

        return endpoints;
    }
}