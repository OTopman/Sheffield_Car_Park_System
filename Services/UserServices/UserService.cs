using Sheffield_Car_Park_System.Dtos;

namespace Sheffield_Car_Park_System.Services.UserServices
{
    public class UserService : IUserService
    {
        private List<User> _users = new List<User>(){
            new User(){
                EmailAddress = "okunlolatopman14@gmail.com",
                FirstName = "Raphael",
                LastName = "Okunlola",
                Password ="12345",
                Id = 1
            },
             new User(){
                EmailAddress = "aliu.adegold@gmail.com",
                FirstName = "Aliu",
                LastName = "Azeez",
                Password ="11111",
                Id = 2
            }
        };

        public AppResponse<User> Create(User user)
        {
            _users.Add(user);
            return new AppResponse<User>()
            {
                Data = user,
                Status = "success",
                Message = "User created successfully."
            };
        }

        public AppResponse<User> Delete(int id)
        {
            AppResponse<User> user = this.GetById(id);
            _users.Remove(user.Data);
            return new AppResponse<User>()
            {
                Data = user.Data,
                Status = "success",
                Message = "User deleted successfully."
            };
        }

        public AppResponse<List<User>> GetAll()
        {
            return new AppResponse<List<User>>()
            {
                Data = _users,
                Status = "success",
                Message = "Records retrieved successfully."
            };
        }

        public AppResponse<User> GetById(int id)
        {
            User user = _users.FirstOrDefault(u => u.Id == id)!;
            return new AppResponse<User>()
            {
                Data = user,
                Message = "Record retrieved successfully.",
                Status = "success",
            };
        }

        public AppResponse<User> Login(LoginDto loginDto)
        {
            User user = _users.FirstOrDefault(u => u.EmailAddress == loginDto.Email && u.Password == loginDto.Password)!;

            return new AppResponse<User>()
            {
                Data = user,
                Status = "success",
                Message = "User authenticated successfully."
            };
        }

        public AppResponse<User> Update(User user)
        {
            AppResponse<User> user1 = GetById(user.Id);

            // user1.EmailAddress = user.EmailAddress ?? user1.EmailAddress;
            // user1.Password = user.Password ?? user1.Password;
            // user1.FirstName = user.FirstName ?? user1.FirstName;
            // user1.LastName = user.LastName ?? user1.LastName;
            this.Delete(user1.Data.Id);
            this.Create(user);

            return new AppResponse<User>()
            {
                Data = user,
                Status = "success",
                Message = "User deleted successfully."
            };
        }
    }
}