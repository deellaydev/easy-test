using System.Collections.Generic;

namespace CourseWork
{
    public class Question : IQuestion
    {
        public string QuestionText { get; }

        public string QuestionCurrentAnswer { get; set; }

        public string QuestionRightAnswer { get; }

        public Question(string questionText, string questionRightAnswer, string questionCurrentAnswer)
        {
            QuestionText = questionText;
            QuestionRightAnswer = questionRightAnswer;
            QuestionCurrentAnswer = questionCurrentAnswer;
        }

        public bool CheckRightQuestion()
        {
            return QuestionCurrentAnswer == QuestionRightAnswer;
        }

    }

    public class SimpleQuestions : ISimpleQuestion
    {
        private static readonly QuestionsDataBase QuestionsDataBase = new QuestionsDataBase();
        public List<string> ListSimpleQuestions { get; }
        public List<string> ListSimpleQuestionsAnswers { get; }
        public List<string> ListSimpleQuestionsRightAnswer { get; }
        public int CountQuestions { get; }
        public SimpleQuestions()
        {
            ListSimpleQuestions = QuestionsDataBase.GetSimpleQuestions();
            ListSimpleQuestionsAnswers = QuestionsDataBase.GetSimpleQuestionsAnswers();
            ListSimpleQuestionsRightAnswer = QuestionsDataBase.GetSimpleQuestionsRightAnswer();
            CountQuestions = QuestionsDataBase.GetCountSimpleQuestions();
        }
        
        public Question[] simpleQuestion = new Question[QuestionsDataBase.GetCountSimpleQuestions()];

        public Question this[int index]
        {
            get => simpleQuestion[index];
            set => simpleQuestion[index] = value;
        }
        
    }
    
    
    
    public class HardQuestions : IHardQuestion
    {
        private static readonly QuestionsDataBase QuestionsDataBase = new QuestionsDataBase();
        public List<string> ListHardQuestions { get; }
        public List<string> ListHardQuestionsRightAnswer { get; }
        public int CountQuestions { get; }
        public HardQuestions()
        {
            ListHardQuestions = QuestionsDataBase.GetHardQuestions();
            ListHardQuestionsRightAnswer = QuestionsDataBase.GetHardQuestionsRightAnswer();
            CountQuestions = QuestionsDataBase.GetCountHardQuestions();
        }
        
        public Question[] hardQuestion = new Question[QuestionsDataBase.GetCountHardQuestions()];

        public Question this[int index]
        {
            get => hardQuestion[index];
            set => hardQuestion[index] = value;
        }
    }
}