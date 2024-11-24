using DemoExam.WinForm.Data.Models;
using DemoExam.WinForm.Features.Interfaces;
using System;
namespace DemoExam.WinForm.Forms
{
    public partial class UsersForm : Form
    {
        private User? currentUser = null;

        private IUserService _userService;
        private CreateUser _createUser;

        private int _pageSize = 5;
        private int _currentPage = 1;
        private int _totalPages;

        public UsersForm(IUserService userService, CreateUser createUser)
        {
            _userService = userService;
            _createUser = createUser;

            InitializeComponent();
            FeelDataGrid();
            InitializePageSizeComboBox();
        }

        private void UsersDataGrid_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var selectedUser = (User)UsersDataGrid.Rows[e.RowIndex].DataBoundItem;

                currentUser = selectedUser;
            }
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

        private void CreateUserButtom_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            _createUser.Show();
        }

        private void UsersForm_Shown(object sender, EventArgs e)
        {
            FeelDataGrid();
        }

        private void pageSizeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            _pageSize = (int)pageSizeComboBox.SelectedItem;
            _currentPage = 1;
            FeelDataGrid();
        }

        private void InitializePageSizeComboBox()
        {
            pageSizeComboBox.DataSource = new List<int> { 3, 5, 10, 15, 20 };
            pageSizeComboBox.SelectedIndexChanged += pageSizeComboBox_SelectedIndexChanged;
            pageSizeComboBox.SelectedItem = _pageSize;
        }

        private void FeelDataGrid()
        {
            UsersDataGrid.DataSource = null;


            var users = _userService.GetUsers();

            _totalPages = (int)Math.Ceiling((double)users?.Count() / _pageSize);

            var pagedUsers = users
                            .Skip((_currentPage - 1) * _pageSize)
                            .Take(_pageSize)
                            .ToList();

            UsersDataGrid.DataSource = pagedUsers;
            UpdatePaginationInfo();
        }

        private void UpdatePaginationInfo()
        {
            paginationLabel.Text = $"Страница {_currentPage} из {_totalPages}";
        }

        private void NextPrevButton_Click_1(object sender, EventArgs e)
        {
            if (_currentPage < _totalPages)
            {
                _currentPage++;
                FeelDataGrid();
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (_currentPage > 1)
            {
                _currentPage--;
                FeelDataGrid();
            }
        }
    }
}
