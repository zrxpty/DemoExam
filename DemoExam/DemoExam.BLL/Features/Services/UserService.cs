using DemoExam.WinForm.Data;
using DemoExam.WinForm.Features.Interfaces;
using DemoExam.WinForm.Features.Utils;

namespace DemoExam.WinForm.Features.Services
{
    public class UserService : IUserService
    {
        private readonly AppDbContext _db;

        public UserService(AppDbContext db)
        {
            _db = db;
        }

        public bool AuthorizeUser(string username, string password)
        {
            var user = _db.Users.FirstOrDefault(x => x.Email == username);

            if(!HashPassword.ConfirmPassword(password, user.Password))
                return false;

            return true;
        }

        public Data.Models.User CreateUser(string username, string password)
        {
            var user = new Data.Models.User()
            {
                Email = username,
                Name = username,
                Password = HashPassword.EncodePassword(password)
            };

            _db.Users.Add(user);
            _db.SaveChanges();

            return user;
        }

        public Data.Models.User DeleteUser(Data.Models.User user)
        {
            var existUser = _db.Users.FirstOrDefault(x => x.Email == user.Email);

            if (existUser == null)
                throw new Exception("Не удалось найти юзера");

            _db.Users.Remove(existUser);
            _db.SaveChanges();

            return existUser;
        }

        public Data.Models.User EditUser(Data.Models.User user)
        {
            var existUser = _db.Users.FirstOrDefault(x => x.Email == user.Email);

            if (existUser == null)
                throw new Exception("Не удалось найти юзера");

            existUser.Email = user.Email;
            existUser.Name = user.Name;
            existUser.Password = HashPassword.EncodePassword(user.Password);

            _db.SaveChanges();

            return existUser;
        }

        public Data.Models.User GetUser(string username)
        {
            var existUser = _db.Users.FirstOrDefault(x => x.Email == username);

            if (existUser == null)
                throw new Exception("Не удалось найти юзера");

            return existUser;
        }

        public IEnumerable<Data.Models.User> GetUsers()
        {
            return _db.Users;
        }
    }
}
