using Assembly.MusicApp.Domain.Model;
using Assembly.MusicApp.Services.Contracts;
using Assembly.MusicApp.Services.Dtos;
using System.Text.Json;

namespace Assembly.MusicApp.Services
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;

        public UserService(IUserRepository userRepository)
        {
            this._userRepository = userRepository;
        }

        public List<UserDto> GetAll()
        {
            var entities = _userRepository.GetAll();

            var dtos = new List<UserDto>();

            foreach (var item in entities)
            {
                var imaageBase64 = "_blobService.GetImage(item.Id)";
                dtos.Add(new UserDto()
                {
                    Id = item.Id,
                    Name = item.Name,
                    Description = item.Description,
                    Image = imaageBase64,
                    Specialities = item.Specialities,
                    Username = item.Account.Username
                });
            }

            return dtos;
        }

        public List<UserDto> GetAllWithAccounts()
        {
            var entities = _userRepository.GetAll();

            var dtos = new List<UserDto>();


        }

        public UserDto GetById(int id)
        {
            throw new NotImplementedException();
        }

        public UserDto Add(UserDto dto)
        {
            User user = JsonSerializer.Deserialize<User>("{}");

            string json = JsonSerializer.Serialize(new User());


            return null;
        }

        public UserDto Update(UserDto dto)
        {
            throw new NotImplementedException();
        }

        public UserDto Delete(int id)
        {
            throw new NotImplementedException();
        }

        
    }
}
