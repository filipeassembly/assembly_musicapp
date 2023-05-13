using Assembly.MusicApp.Services.Contracts;
using Assembly.MusicApp.Services.Dtos;

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
                
                dtos.Add(new UserDto()
                {
                    Id = item.Id,
                    Name = item.Name,
                    Description = item.Description,
                    Username = ""
                });
            }

            return dtos;
        }

        public List<UserDto> GetAllWithAccounts()
        {
            var entities = _userRepository.GetAll();

            var dtos = new List<UserDto>();

            return null;
        }

        public UserDto GetById(int id)
        {
            throw new NotImplementedException();
        }

        public UserDto Add(UserDto dto)
        {



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
