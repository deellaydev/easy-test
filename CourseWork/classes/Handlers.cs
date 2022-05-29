using System.Windows.Forms;

namespace CourseWork
{

    delegate void EventHandler(User currentUser, Question question);
    delegate void InputEventHandler(User currentUser, Question question);
    delegate void ButtonEventHandler(User currentUser, Button button);
    delegate void ButtonHardEventHandler(User currentUser, Button button);
    
    public class Handlers
    {
        public static void RadioButtonCheck(User currentUser, Question question)
        {
            if (question.CheckRightQuestion())
            {
                ++currentUser.RightSimpleAnswer;
            }
            if (!question.CheckRightQuestion() && currentUser.RightSimpleAnswer > 0)
            {
                --currentUser.RightSimpleAnswer;
            }
        }

        public static void InputCheck(User currentUser, Question question)
        {
            if (question.CheckRightQuestion())
            {
                ++currentUser.RightHardAnswer;
            }
            if (!question.CheckRightQuestion() && currentUser.RightHardAnswer > 0)
            {
                --currentUser.RightHardAnswer;
            }
        }

        public static void BlockSimpleButton(User currentUser, Button button)
        {
            if (currentUser.RightSimpleAnswer == new QuestionsDataBase().GetCountSimpleQuestions())
            {
                button.Enabled = false;
            }
        }
        
        public static void BlockHardButton(User currentUser, Button button)
        {
            if (currentUser.RightHardAnswer == new QuestionsDataBase().GetCountHardQuestions())
            {
                button.Enabled = false;
            }
        }
    }
}