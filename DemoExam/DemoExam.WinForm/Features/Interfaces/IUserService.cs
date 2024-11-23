using DemoExam.WinForm.Data.Models;

namespace DemoExam.WinForm.Features.Interfaces
{
    public interface IUserService
    {
        bool AuthorizeUser(string username, string password);
        IEnumerable<User> GetUsers();
        User GetUser(string username);
        User CreateUser(string username, string password);
        User EditUser(User user);
        User DeleteUser(User user);
    }
}
