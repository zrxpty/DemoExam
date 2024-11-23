using DemoExam.WinForm.Data.Models;
using DemoExam.WinForm.Features.Interfaces;
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
    public partial class UsersForm : Form
    {
        private User? currentUser = null;

        private IUserService _userService;
        private CreateUser _createUser;

        public UsersForm(IUserService userService, CreateUser createUser)
        {
            _userService = userService;
            _createUser = createUser;

            InitializeComponent();
            FeelDataGrid();

        }

        private void FeelDataGrid()
        {
            UsersDataGrid.DataSource = null;
            var users = _userService.GetUsers();

            //foreach (var user in users)
            //{
            //    UsersDataGrid.Rows.Add(user.Id, user.Name, user.Email, user.Password);
            //}

            UsersDataGrid.DataSource = users.ToList();
        }

        private void UsersDataGrid_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var selectedUser = (User)UsersDataGrid.Rows[e.RowIndex].DataBoundItem;

                currentUser = selectedUser;
            }
        }

        private void UsersForm_Load(object sender, EventArgs e)
        {

        }

        private void DeleteUserButton_Click(object sender, EventArgs e)
        {
            if (currentUser == null)
            {
                MessageBox.Show("Пользователь не выбран");
                return;
            }

            var deleteUser = _userService.DeleteUser(currentUser);

            FeelDataGrid();
        }

        private void CreateUserButtom_Click(object sender, EventArgs e)
        {

        }

        private void CreateUserButtom_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            _createUser.Show();
        }

        private void UsersForm_Shown(object sender, EventArgs e)
        {
            FeelDataGrid();
        }
    }
}
