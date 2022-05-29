using System;
using System.Windows.Forms;

namespace CourseWork
{
    public partial class SignUp : Form
    {
        private readonly UserDataBase _userDataBase = new UserDataBase();
        public SignUp()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }
        
        private void SignUp_Load(object sender, EventArgs e)
        {
            PasswordInput.UseSystemPasswordChar = true;
            ConfirmPasswordInput.UseSystemPasswordChar = true;
            Eye.Visible = false;
            EyeConfirm.Visible = true;
            LoginInput.MaxLength = 50;
            PasswordInput.MaxLength = 50;
            ConfirmPasswordInput.MaxLength = 50;
        }

        private void SignUpButton_Click(object sender, EventArgs e)
        {
            string userLogin = LoginInput.Text;
            string userPassword = PasswordInput.Text;
            string userConfirmPassword = ConfirmPasswordInput.Text;

            if (userPassword != userConfirmPassword)
            {
                MessageBox.Show("Пароли не совпадают");
                return;
            }

            if (_userDataBase.CheckUser(userLogin))
            {
                MessageBox.Show("Пользователь с таким именем существует");
                return;
            }

            try
            {
                _userDataBase.RegisterUser(userLogin, userPassword);
                MessageBox.Show("Регистрация прошла успешно!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SignIn signIn = new SignIn();
            signIn.Show();
            this.Hide();
        }

        private void Eye_Click(object sender, EventArgs e)
        {
            PasswordInput.UseSystemPasswordChar = true;
            ClosedEye.Visible = true;
            Eye.Visible = false;
        }

        private void ClosedEye_Click(object sender, EventArgs e)
        {
            PasswordInput.UseSystemPasswordChar = false;
            ClosedEye.Visible = false;
            Eye.Visible = true;
        }

        private void EyeConfirm_Click(object sender, EventArgs e)
        {
            ConfirmPasswordInput.UseSystemPasswordChar = true;
            ClosedEyeConfirm.Visible = true;
            EyeConfirm.Visible = false;
        }

        private void ClosedEyeConfirm_Click(object sender, EventArgs e)
        {
            ConfirmPasswordInput.UseSystemPasswordChar = false;
            ClosedEyeConfirm.Visible = false;
            EyeConfirm.Visible = true;
        }

        private void ExitBox_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}