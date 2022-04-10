public record GetPokemonResponce
{
    public List<Pokemon> Pokemons { get; set; } = new List<Pokemon>();
    public record Pokemon
    {
        //Data modellen er ikke korrekt, translation skal være en record/class for sig, samme gælder for base. Type skal være et array for at data kan deserialize
        public int Id { get; set; }
        public string? Name { get; set; }

        // For at få et poc - Proff Of Concept, har jeg minimaliseret data modellen til 2 attributter
        /*
        public string? translationsengb { get; set; }
        public string? translationsjajp { get; set; }
        public string? translationszhcn { get; set; }
        public string? translationsfrfr { get; set; }
        public string? type0 { get; set; }
        public string? type1 { get; set; }
        public int? baseHP { get; set; }
        public int? baseAttack { get; set; }
        public int? baseDefense { get; set; }
        public int? baseSp_Attack { get; set; }
        public int? baseSp_Defense { get; set; }
        public int? baseSpeed { get; set; }
        */
    }
}