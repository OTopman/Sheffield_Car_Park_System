using Sheffield_Car_Park_System.Dtos;

namespace Sheffield_Car_Park_System.Services.UserServices
{
    public class MySqlUserService : IUserService
    {
        AppDbContext context;

        public MySqlUserService(AppDbContext context)
        {
            this.context = context;
        }
        public AppResponse<User> Create(User user)
        {
            context.Users.Add(user);
            context.SaveChanges();

            return new AppResponse<User>()
            {
                Data = user,
                Status = "success",
                Message = "User created successfully."
            };
        }

        public AppResponse<User> Delete(int id)
        {
            User user = context.Users.FirstOrDefault(u => u.Id == id)!;

            // Check if user was found
            if (user == null)
            {
                return new AppResponse<User>()
                {
                    Data = user,
                    Status = "failed",
                    Message = "Record not found."
                };
            }
            context.Users.Remove(user);
            int result = context.SaveChanges();

            return new AppResponse<User>()
            {
                Data = user,
                Status = "success",
                Message = "Record deleted successfully."
            };


        }

        public AppResponse<List<User>> GetAll()
        {
            return new AppResponse<List<User>>()
            {
                Data = context.Users.AsEnumerable().ToList(),
                Status = "success",
                Message = "Records retrieved successfully."
            };

        }

        public AppResponse<User> GetById(int id)
        {
            User user = context.Users.FirstOrDefault(u => u.Id == id)!;
            return new AppResponse<User>()
            {
                Data = user,
                Status = "success",
                Message = "Record retrieved successfully."
            };
        }

        public AppResponse<User> Login(LoginDto loginDto)
        {
            throw new NotImplementedException();
        }

        public AppResponse<User> Update(User user)
        {
            throw new NotImplementedException();
        }
    }
}