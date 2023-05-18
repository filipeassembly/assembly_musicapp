using Assembly.MusicApp.Domain.Model;
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

        public bool Add(UserDto dto)
        {
            if (dto is null)
            {
                return false;
            }

            if (string.IsNullOrEmpty(dto.Name) || dto.Name.Length < 3)
            {
                return false;
            }
            
            if (!_userRepository.IsEmailUnique(dto.Email))
            {
                return false;
            }

            User user = new User()
            {
                Name = dto.Name,
                Email = dto.Email,
                Age = dto.Age,
                Description = dto.Description
            };

            return _userRepository.Add(user) is not null;
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
