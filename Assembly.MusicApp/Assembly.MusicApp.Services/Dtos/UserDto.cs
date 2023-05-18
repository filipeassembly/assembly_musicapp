using Assembly.MusicApp.Domain.Model;

namespace Assembly.MusicApp.Services.Dtos
{
    public class UserDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Description { get; set; }
        public int Age { get; set; }
    }
}
