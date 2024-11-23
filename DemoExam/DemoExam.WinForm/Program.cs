using DemoExam.WinForm.Data;
using DemoExam.WinForm.Features.Interfaces;
using DemoExam.WinForm.Features.Services;
using DemoExam.WinForm.Forms;
using Microsoft.Extensions.DependencyInjection;

namespace DemoExam.WinForm
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            var services = new ServiceCollection()
                .AddDbContext<AppDbContext>()
                .AddTransient<IUserService, UserService>()
                .AddTransient<AuthForm>()
                .AddTransient<UsersForm>()
                .AddTransient<CreateUser>()
                .BuildServiceProvider();
            

            ApplicationConfiguration.Initialize();
            Application.Run(services.GetRequiredService<AuthForm>());
        }
    }
}