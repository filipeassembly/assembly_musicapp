using Assembly.MusicApp.Services.Dtos;

namespace Assembly.MusicApp.Services.Contracts
{
    public interface IUserService
    {
        List<UserDto> GetAll();
        List<UserDto> GetAllWithAccounts();
        UserDto GetById(int id);
        UserDto Add(UserDto dto);
        UserDto Update(UserDto dto);
        UserDto Delete(int id);
    }
}
