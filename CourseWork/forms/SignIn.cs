using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace CourseWork
{
    public partial class SignIn : Form
    {
        private readonly UserDataBase _userDataBase = new UserDataBase();
        private readonly QuestionsDataBase _questionsDataBase = new QuestionsDataBase();
        
        public SignIn()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }


        private void SignIn_Load(object sender, EventArgs e)
        {
            PasswordInput.UseSystemPasswordChar = true;
            Eye.Visible = false;
            LoginInput.MaxLength = 50;
            PasswordInput.MaxLength = 50;
            _questionsDataBase.GetSimpleQuestions();
        }

        private void SignInButton_Click(object sender, EventArgs e)
        {
            try
            {
                string userLogin = LoginInput.Text;
                string userPassword = PasswordInput.Text;

                if (_userDataBase.LoginUser(userLogin, userPassword))
                {
                    User currentUser = new User(userLogin);
                    MainMenu mainMenu = new MainMenu(currentUser);
                    mainMenu.Show();
                    this.Hide();
                }
                else
                {
                    DialogResult result = MessageBox.Show(
                        "Логин или пароль не верный.\nПерейти к регистрации?",
                        "Ошибка авторизации!",
                        MessageBoxButtons.YesNo
                    );
                    if (result == DialogResult.Yes)
                    {
                        SignUp signUp = new SignUp();
                        signUp.Show();
                        this.Hide();
                    }
                    else
                    {
                        LoginInput.Clear();
                        PasswordInput.Clear();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SignUp signUp = new SignUp();
            signUp.Show();
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

        private void ExitBox_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}