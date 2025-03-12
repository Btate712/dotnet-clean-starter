using api.Endpoints;

namespace api;

public static class DependencyInjection
{
    public static void RegisterEndpoints(WebApplication app)
    {
        app.RegisterApi();
    }
}