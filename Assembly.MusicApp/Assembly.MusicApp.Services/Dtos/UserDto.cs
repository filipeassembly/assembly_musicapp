using Assembly.MusicApp.Domain.Model;

namespace Assembly.MusicApp.Services.Dtos
{
    public class UserDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }
        public IList<Speciality> Specialities { get; set; }
        public string Username { get; set; }
    }

    public class CreateUserDto
    {

    }

    public class RequestDeleteUserDto
    {
        public int Id { get; set; }
    }

    public class ResponseDeleteUserDto
    {
        public UserDto User { get; set; }
    }
}
