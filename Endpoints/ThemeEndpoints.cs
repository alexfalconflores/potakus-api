using Microsoft.AspNetCore.Mvc;
using PotakusAPI.Repositories;
using PotakusAPI.Utils;

namespace PotakusAPI.Endpoints;

public static class ThemeEndpoints
{
    public static void MapThemeEndpoints(this IEndpointRouteBuilder routes)
    {
        var group = routes.MapGroup(ApiVersion.V1("themes"));
        group.WithTags("Themes");

        group.MapGet("/", async (IThemeRepository themeR) =>
        {
            var themes = await themeR.GetAll();
            return Results.Ok(themes);
        })
        .WithName("GetAllThemes");
    }
}
