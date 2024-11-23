using DemoExam.WinForm.Features.Interfaces;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
