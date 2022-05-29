using System;
using System.Windows.Forms;

namespace CourseWork
{
    public partial class MainMenu : Form
    {
        private event ButtonEventHandler ButtonEventHandler;
        private event ButtonHardEventHandler ButtonHardEventHandler;
        private readonly SimpleQuestions _simpleQuestions = new SimpleQuestions();
        private readonly HardQuestions _hardQuestions = new HardQuestions();
        private User _currentUser;
        private readonly UserDataBase _userDataBase = new UserDataBase();
        public MainMenu(User currentUser)
        {
            _currentUser = currentUser;
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        public MainMenu(User currentUser, SimpleQuestions simpleQuestions)
        {
            _currentUser = currentUser;
            _simpleQuestions = simpleQuestions;
        }

        public MainMenu(User currentUser, HardQuestions hardQuestions)
        {
            _currentUser = currentUser;
            _hardQuestions = hardQuestions;
        }
        
        private void MainMenu_Load(object sender, EventArgs e)
        {
            ButtonEventHandler += Handlers.BlockSimpleButton;
            ButtonHardEventHandler += Handlers.BlockHardButton;
            UserNameLabel.Text = _currentUser.UserName;
            SimpleTestLabel.Text = Convert.ToString(_currentUser.RightSimpleAnswer) + '/' + Convert.ToString(_simpleQuestions.CountQuestions);
            HardTestLabel.Text = Convert.ToString(_currentUser.RightHardAnswer) + '/' + Convert.ToString(_hardQuestions.CountQuestions);
            ButtonEventHandler.Invoke(_currentUser, SimpleTestButton);
            ButtonHardEventHandler.Invoke(_currentUser, HardTestButton);
        }

        private void ExitBox_Click(object sender, EventArgs e)
        {
            _userDataBase.LogActionUser(_currentUser.UserName, "Вышел из программы");
            Close();
        }


        private void SimpleTestButton_Click(object sender, EventArgs e)
        {
            _userDataBase.LogActionUser(_currentUser.UserName, "Начал простой тест");
            SimpleTest simpleTest = new SimpleTest(_currentUser, _simpleQuestions);
            simpleTest.Show();
            this.Hide();
        }

        private void HardTestButton_Click(object sender, EventArgs e)
        {
            _userDataBase.LogActionUser(_currentUser.UserName, "Начал сложный тест");
            HardTest hardTest = new HardTest(_currentUser, new HardQuestions());
            hardTest.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            _userDataBase.UpdateUserStat(_currentUser.UserName);
            MessageBox.Show("Статистика сброшена!");
            _currentUser = new User(_currentUser.UserName);
            MainMenu mainMenu = new MainMenu(_currentUser);
            mainMenu.Show();
            this.Hide();
        }
    }
}