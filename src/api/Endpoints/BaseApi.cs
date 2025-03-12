namespace api.Endpoints;

public static class BaseApi
{
    public static void RegisterBaseApiEndpoint(this RouteGroupBuilder groupBuilder)
    {
        // ToDo: Update "Base API with the name of your API
        groupBuilder.MapGet("/", () => Results.Ok("Base API"));
    }
}