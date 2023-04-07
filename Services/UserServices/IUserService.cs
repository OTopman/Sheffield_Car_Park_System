using Sheffield_Car_Park_System.Dtos;

namespace Sheffield_Car_Park_System.Services.UserServices
{
    public interface IUserService
    {
        AppResponse<User> Create(User user);

        AppResponse<User> Update(User user);

        AppResponse<User> Delete(int id);

        AppResponse<List<User>> GetAll();

        AppResponse<User> GetById(int id);

        AppResponse<User> Login(LoginDto loginDto);
    }
}