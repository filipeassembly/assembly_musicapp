namespace Assembly.MusicApp.Domain.Model
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Description { get; set; }
        public int Age { get; set; }
        public Account Account { get; set; }
        public IList<Role> Roles { get; set; }
        public IList<Speciality> Specialities { get; set; }
    }
}
