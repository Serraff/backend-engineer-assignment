//using DatabaseService/ DatabaseService.Application / IPokemonConfigService;
public static class UserEndpoints
{
    public static void MapUsersEndpoints(this WebApplication app)
    {
        app.MapGet("/v1/Pokemons", GetAllUsers);
        app.MapGet("/v1/Pokemons/{id}", GetUserById);
    }

    public static void AddUserServices(this IServiceCollection service)
    {
        service.AddHttpClient<IPokemonConfigService, PokemonConfigService>();
    }

    internal static IResult GetAllUsers(IPokemonConfigService service)
    {
        var users = service.GetAllPokemons().Result.Pokemons;

        return users is not null ? Results.Ok(users) : Results.NotFound();
    }

    internal static IResult GetUserById(IPokemonConfigService service, int id)
    {
        var user = service.GetPokemonById(id).Result.Pokemons.SingleOrDefault();

        return user is not null ? Results.Ok(user) : Results.NotFound();
    }
}