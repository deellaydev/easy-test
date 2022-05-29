using System;
using System.Windows.Forms;

namespace CourseWork
{

    public partial class SimpleTest : Form
    {
        private event EventHandler RadioButtonCheck;
        private readonly SimpleQuestions _simpleQuestions;
        private readonly User _currentUser;
        private readonly UserDataBase _userDataBase = new UserDataBase();
        private readonly string[] _arrayAnswers;
        public SimpleTest(User currentUser, SimpleQuestions simpleQuestions)
        {
            _currentUser = currentUser;
            _simpleQuestions = simpleQuestions;
            _arrayAnswers = new string[_simpleQuestions.CountQuestions];
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }
        
        private void SimpleTest_Load(object sender, EventArgs e)
        {
            RadioButtonCheck += Handlers.RadioButtonCheck;
            for (int i = 0; i != _simpleQuestions.CountQuestions; i++)
            {
                _simpleQuestions.simpleQuestion[i] = new Question(_simpleQuestions.ListSimpleQuestions[i], _simpleQuestions.ListSimpleQuestionsRightAnswer[i], _currentUser.SimpleAnswers[i]);
            }

            PastQuestionButton.Enabled = _currentUser.CurrentSimpleQuestion + 1 != 1;
            NextQuestionButton.Enabled = _currentUser.CurrentSimpleQuestion + 1 != _simpleQuestions.CountQuestions;
            
            QuestionNumberLabel.Text = $"Вопрос {_currentUser.CurrentSimpleQuestion+1}/{_simpleQuestions.CountQuestions}";
            QuestionTextLabel.Text = _simpleQuestions.ListSimpleQuestions[_currentUser.CurrentSimpleQuestion];
            string[] answers = _simpleQuestions.ListSimpleQuestionsAnswers[_currentUser.CurrentSimpleQuestion]
                .Split(';');
            FirstAnswerButton.Text = answers[0].Trim();
            SecondAnswerButton.Text = answers[1].Trim();
            ThirdAnswerButton.Text = answers[2].Trim();
        }

        private void AnswerButton_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton radioButton = (RadioButton)sender;
            if (radioButton.Checked)
            {
                _simpleQuestions.simpleQuestion[_currentUser.CurrentSimpleQuestion].QuestionCurrentAnswer = radioButton.Text;
                _arrayAnswers[_currentUser.CurrentSimpleQuestion] = radioButton.Text;
            }
        }

        private void NextQuestionButton_Click(object sender, EventArgs e)
        {
            RadioButtonCheck.Invoke(_currentUser, _simpleQuestions.simpleQuestion[_currentUser.CurrentSimpleQuestion]);
            
            _currentUser.CurrentSimpleQuestion++;
            _userDataBase.LogActionUser(_currentUser.UserName, $"Перешёл к вопросу {_currentUser.CurrentSimpleQuestion + 1} в простом тесте");
            
            if (_currentUser.CurrentSimpleQuestion + 1 == _simpleQuestions.CountQuestions)
            {
                PastQuestionButton.Enabled = true;
                NextQuestionButton.Enabled = false;
            }
            else
            {
                NextQuestionButton.Enabled = true;
                PastQuestionButton.Enabled = true;
            }

            QuestionNumberLabel.Text = $"Вопрос {_currentUser.CurrentSimpleQuestion+1}/{_simpleQuestions.CountQuestions}";
            QuestionTextLabel.Text = _simpleQuestions.simpleQuestion[_currentUser.CurrentSimpleQuestion].QuestionText;
            string[] answers = _simpleQuestions.ListSimpleQuestionsAnswers[_currentUser.CurrentSimpleQuestion]
                .Split(';');
            FirstAnswerButton.Text = answers[0].Trim();
            SecondAnswerButton.Text = answers[1].Trim();
            ThirdAnswerButton.Text = answers[2].Trim();
        }

        private void PastQuestionButton_Click(object sender, EventArgs e)
        {
            RadioButtonCheck.Invoke(_currentUser, _simpleQuestions.simpleQuestion[_currentUser.CurrentSimpleQuestion]);
            _currentUser.CurrentSimpleQuestion--;
            
            _userDataBase.LogActionUser(_currentUser.UserName, $"Перешёл к вопросу {_currentUser.CurrentSimpleQuestion + 1} в простом тесте");

            if (_currentUser.CurrentSimpleQuestion + 1 == 1)
            {
                NextQuestionButton.Enabled = true;
                PastQuestionButton.Enabled = false;
            }
            else
            {
                NextQuestionButton.Enabled = true;
                PastQuestionButton.Enabled = true;
            }

            QuestionNumberLabel.Text = $"Вопрос {_currentUser.CurrentSimpleQuestion+1}/{_simpleQuestions.CountQuestions}";
            QuestionTextLabel.Text = _simpleQuestions.simpleQuestion[_currentUser.CurrentSimpleQuestion].QuestionText;
            string[] answers = _simpleQuestions.ListSimpleQuestionsAnswers[_currentUser.CurrentSimpleQuestion]
                .Split(';');
            FirstAnswerButton.Text = answers[0].Trim();
            SecondAnswerButton.Text = answers[1].Trim();
            ThirdAnswerButton.Text = answers[2].Trim();
        }

        private void EndTestButton_Click(object sender, EventArgs e)
        {
            
            RadioButtonCheck.Invoke(_currentUser, _simpleQuestions.simpleQuestion[_currentUser.CurrentSimpleQuestion]);
            
            _userDataBase.LogActionUser(_currentUser.UserName, "Закончил простой тест");
            _userDataBase.SetUserCurrentSimpleQuestion(_currentUser.UserName, _currentUser.CurrentSimpleQuestion);
            _userDataBase.SetUserSimpleAnswers(_currentUser.UserName, _arrayAnswers);
            _currentUser.SimpleAnswers = _userDataBase.GetUserSimpleAnswers(_currentUser.UserName);
            _userDataBase.SetUserRightSimpleAnswer(_currentUser.UserName, _currentUser.RightSimpleAnswer);
            MainMenu mainMenu = new MainMenu(_currentUser);
            mainMenu.Show();
            this.Hide();
        }
    }
}