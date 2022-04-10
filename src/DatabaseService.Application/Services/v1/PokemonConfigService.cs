using Newtonsoft.Json;
using static GetPokemonResponce;
public class PokemonConfigService : IPokemonConfigService
{
    private readonly HttpClient _httpClient;

    public PokemonConfigService(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }
    public async Task<GetPokemonResponce> GetAllPokemons()
    {
        // Har haft databasen til at køre lokalt, men kunne ikke få det til at køre i docker, derefter ville den lokale base heller ikke spille med :( (SQL Server)
        // Skal flyttes til en klasse/funktion (Genbrug) + fejl håndtering
        //Data Source = DESKTOP-GNVQLGD; Initial Catalog = PokemonDB; Integrated Security = True
        // Data Source=localhost;Initial Catalog=PokemonDB;Integrated Security=True
        // Data Source=localhost;Initial Catalog=PokemonDB;Persist Security Info=True;User ID=sa;Password=
        //string connString = "Data Source=localhost;Initial Catalog=PokemonDB;User ID=sa;Password=Secret1! ";

        // Connect string til docker database, virker ikke
        // string connString = "Server=db,1433;Initial Catalog=mytable;User=sa;Password=Secret1!;TrustServerCertificate=true";
        //SqlConnection sqlConn = new SqlConnection(connString);
        //SqlDataAdapter sqlDA = new SqlDataAdapter("select * from master.dbo.", sqlConn);
        //DataTable dtPokemons = new DataTable();

        //sqlConn.Open();
        //try
        //{
        //sqlDA.Fill(dtPokemons);
        //}
        //catch (Exception)
        //{
        //    throw;
        //}
        //sqlConn.Close();
        //var pokemonResponce = new GetPokemonResponce();
        //string JSONresult = JsonConvert.SerializeObject(dtPokemons);

        //Data modellen er ikke korrekt, translation skal være en record/class for sig, samme gælder for base. Type skal være et array for at data kan deserialize
        //string someJson = @"[{""id"": 1, ""name"": ""Bulbasaur"", ""translations"": {""en-gb"": ""Bulbasaur"", ""ja-jp"": ""フシギダネ"", ""zh-cn"": ""妙蛙种子"", ""fr-fr"": ""Bulbizarre""}, ""type"": [""Grass"", ""Poison""], ""base"": {""HP"": 45, ""Attack"": 49, ""Defense"": 49, ""Sp. Attack"": 65, ""Sp. Defense"": 65, ""Speed"": 45}}]";
        var pokemonResponce = new GetPokemonResponce();
        string someJson = @"[{""id"": 1, ""name"": ""Bulbasaur""},
                            {""id"": 2, ""name"": ""Ivysaur""}]";
        string JSONresult = someJson;
        pokemonResponce.Pokemons = JsonConvert.DeserializeObject<List<Pokemon>>(JSONresult);

        return pokemonResponce;

    }

    public async Task<GetPokemonResponce> GetPokemonById(int id)
    {
        // Skal flyttes til en klasse/funktion (Genbrug) + fejl håndtering
        //string connString = "Data Source=localhost;Initial Catalog=PokemonDB; Trusted_Connection=True";
        //SqlConnection sqlConn = new SqlConnection(connString);
        //SqlDataAdapter sqlDA = new SqlDataAdapter("select * from PokemonDB.dbo.pokemon where PokemonDB.dbo.pokemon.Id = " + id, sqlConn);
        //DataTable dtPokemons = new DataTable();

        //sqlConn.Open();
        //sqlDA.Fill(dtPokemons);
        //sqlConn.Close();

        var pokemonResponce = new GetPokemonResponce();
        //string JSONresult = JsonConvert.SerializeObject(dtPokemons);
        string someJson = @"{""id"": 1, ""name"": ""Bulbasaur"", ""translations"": {""en-gb"": ""Bulbasaur"", ""ja-jp"": ""フシギダネ"", ""zh-cn"": ""妙蛙种子"", ""fr-fr"": ""Bulbizarre""}, ""type"": [""Grass"", ""Poison""], ""base"": {""HP"": 45, ""Attack"": 49, ""Defense"": 49, ""Sp. Attack"": 65, ""Sp. Defense"": 65, ""Speed"": 45}}";
        string JSONresult = someJson;
        pokemonResponce.Pokemons = JsonConvert.DeserializeObject<List<Pokemon>>(JSONresult);

        return pokemonResponce;
    }
}