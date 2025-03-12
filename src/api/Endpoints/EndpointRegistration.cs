namespace api.Endpoints;

public static class EndpointRegistration
{
    public static void RegisterApi(this WebApplication app)
    {
        RouteGroupBuilder group = app.MapGroup("api");
        
        group.RegisterBaseApiEndpoint();
    }
}