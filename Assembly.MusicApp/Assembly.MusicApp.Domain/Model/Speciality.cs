namespace Assembly.MusicApp.Domain.Model
{
    public class Speciality // Entitade (tabela)
    {
        public int Id { get; set; }
        public string Value { get; set; } 
        public List<string> Variations { get; set; } 
    }

}
