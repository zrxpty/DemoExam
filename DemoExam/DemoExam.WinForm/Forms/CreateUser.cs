using DemoExam.WinForm.Features.Interfaces;
using Microsoft.Extensions.DependencyInjection;

namespace DemoExam.WinForm.Forms
{
    public partial class CreateUser : Form
    {
        private readonly IUserService _userService;
        private readonly IServiceProvider _serviceProvider;

        public CreateUser(IUserService userService, IServiceProvider serviceProvider)
        {
            _userService = userService;
            _serviceProvider = serviceProvider;

            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            _userService.CreateUser(textBox1.Text, textBox3.Text);

            this.Hide();
            var usersForm = _serviceProvider.GetRequiredService<UsersForm>();

            usersForm.Show();
        }
    }
}
