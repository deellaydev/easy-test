using System;
using System.Windows.Forms;

namespace CourseWork
{
    public partial class HardTest : Form
    {
        private event InputEventHandler InputCheck;
        private readonly HardQuestions _hardQuestions = new HardQuestions();
        private readonly User _currentUser;
        private readonly UserDataBase _userDataBase = new UserDataBase();
        private readonly string[] _arrayAnswers;
        
        public HardTest(User currentUser, HardQuestions hardQuestions)
        {
            _currentUser = currentUser;
            _hardQuestions = hardQuestions;
            _arrayAnswers = new string[_hardQuestions.CountQuestions];
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void HardTest_Load(object sender, EventArgs e)
        {
            InputCheck += Handlers.InputCheck;
            for (int i = 0; i != _hardQuestions.CountQuestions; i++)
            {
                _hardQuestions.hardQuestion[i] = new Question(_hardQuestions.ListHardQuestions[i], _hardQuestions.ListHardQuestionsRightAnswer[i], _currentUser.HardAnswers[i]);
            }
            
            PastQuestionButton.Enabled = _currentUser.CurrentHardQuestion + 1 != 1;
            NextQuestionButton.Enabled = _currentUser.CurrentHardQuestion + 1 != _hardQuestions.CountQuestions;
            
            QuestionNumberLabel.Text = $"Вопрос {_currentUser.CurrentHardQuestion+1}/{_hardQuestions.CountQuestions}";
            QuestionTextLabel.Text = _hardQuestions.ListHardQuestions[_currentUser.CurrentHardQuestion];
            AnswerInput.Text = _currentUser.HardAnswers[_currentUser.CurrentHardQuestion];
            
        }

        private void AnswerInput_TextChanged(object sender, EventArgs e)
        {
            _hardQuestions.hardQuestion[_currentUser.CurrentHardQuestion].QuestionCurrentAnswer = AnswerInput.Text;
            _arrayAnswers[_currentUser.CurrentHardQuestion] = AnswerInput.Text;
        }

        private void PastQuestionButton_Click(object sender, EventArgs e)
        {
            InputCheck.Invoke(_currentUser, _hardQuestions.hardQuestion[_currentUser.CurrentHardQuestion]);
            
            _currentUser.CurrentHardQuestion--;
            
            _userDataBase.LogActionUser(_currentUser.UserName, $"Перешёл к вопросу {_currentUser.CurrentHardQuestion + 1} в сложном тесте");
            
            if (_currentUser.CurrentHardQuestion + 1 == 1)
            {
                NextQuestionButton.Enabled = true;
                PastQuestionButton.Enabled = false;
            }
            else
            {
                NextQuestionButton.Enabled = true;
                PastQuestionButton.Enabled = true;
            }
            
            
            QuestionNumberLabel.Text = $"Вопрос {_currentUser.CurrentHardQuestion+1}/{_hardQuestions.CountQuestions}";
            QuestionTextLabel.Text = _hardQuestions.hardQuestion[_currentUser.CurrentHardQuestion].QuestionText;
            AnswerInput.Text = _currentUser.HardAnswers[_currentUser.CurrentHardQuestion];
            
            
        }

        private void NextQuestionButton_Click(object sender, EventArgs e)
        {
            InputCheck.Invoke(_currentUser, _hardQuestions.hardQuestion[_currentUser.CurrentHardQuestion]);
            
            _currentUser.CurrentHardQuestion++;
            
            _userDataBase.LogActionUser(_currentUser.UserName, $"Перешёл к вопросу {_currentUser.CurrentHardQuestion + 1} в сложном тесте");
            
            if (_currentUser.CurrentHardQuestion + 1 == _hardQuestions.CountQuestions)
            {
                PastQuestionButton.Enabled = true;
                NextQuestionButton.Enabled = false;
            }
            else
            {
                NextQuestionButton.Enabled = true;
                PastQuestionButton.Enabled = true;
            }
            
            QuestionNumberLabel.Text = $"Вопрос {_currentUser.CurrentHardQuestion+1}/{_hardQuestions.CountQuestions}";
            QuestionTextLabel.Text = _hardQuestions.hardQuestion[_currentUser.CurrentHardQuestion].QuestionText;
            AnswerInput.Text = _currentUser.HardAnswers[_currentUser.CurrentHardQuestion];
            
        }

        private void EndTestButton_Click(object sender, EventArgs e)
        {
            InputCheck.Invoke(_currentUser, _hardQuestions.hardQuestion[_currentUser.CurrentHardQuestion]);
            
            _userDataBase.LogActionUser(_currentUser.UserName, "Закончил сложный тест");
            _userDataBase.SetUserCurrentHardQuestion(_currentUser.UserName, _currentUser.CurrentHardQuestion);
            _userDataBase.SetUserHardAnswers(_currentUser.UserName, _arrayAnswers);
            _currentUser.HardAnswers = _userDataBase.GetUserHardAnswers(_currentUser.UserName);
            _userDataBase.SetUserRightHardAnswer(_currentUser.UserName, _currentUser.RightHardAnswer);
            MainMenu mainMenu = new MainMenu(_currentUser);
            mainMenu.Show();
            this.Hide();
        }
    }
}