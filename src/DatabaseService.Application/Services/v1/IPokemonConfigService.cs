public interface IPokemonConfigService
{
    public Task<GetPokemonResponce> GetAllPokemons();
    public Task<GetPokemonResponce> GetPokemonById(int id);
}