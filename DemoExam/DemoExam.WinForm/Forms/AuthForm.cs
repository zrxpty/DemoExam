using DemoExam.WinForm.Data;
using DemoExam.WinForm.Features.Interfaces;
using DemoExam.WinForm.Features.Utils;

namespace DemoExam.WinForm.Forms
{
    public partial class AuthForm : Form
    {
        private string _captchatext = string.Empty;

        private readonly IUserService _userService;
        private readonly UsersForm _usersForm;

        public AuthForm(IUserService userService, UsersForm usersForm)
        {
            _userService = userService;
            _usersForm = usersForm;

            InitializeComponent();
            GenerateNewCaptcha();
            
        }

        private void GenerateNewCaptcha()
        {
            _captchatext = GenerateCaptcha.GenerateCaptchaText();
            captchaBox.Image = GenerateCaptcha.GenerateCaptchaImage(_captchatext, captchaBox.Width, captchaBox.Height);
        }

        private void AuthForm_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var login = LoginTextBox.Text;
            var password = PasswordTextBox.Text;

            if(login == null || password == null) 
            {
                MessageBox.Show("Введите Логин или Пароль.\nПопробуйте еще раз.");
                return; 
            }

            if(TextBoxCaptcha.Text  != _captchatext)
            {
                MessageBox.Show("Не верно введена Captcha.\nПопробуйте еще раз.");
                return;
            }

            if(!_userService.AuthorizeUser(login, password))
            {
                MessageBox.Show("Не верно введены Логин или Пароль.\nПопробуйте еще раз.");
                return;
            }

            _usersForm.Show();
            this.Hide();
        }

        private void captchaBox_Click(object sender, EventArgs e)
        {

        }
    }
}
