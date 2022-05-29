using System.Collections.Generic;
using MySql.Data.MySqlClient;

namespace CourseWork
{
    interface IDataBase
    {
        void OpenConnection();
        void CloseConnection();
        MySqlConnection GetConnection();
    }

    interface IUserDataBase
    {
        bool LoginUser(string userLogin, string userPassword);
        bool CheckUser(string userLogin);
        bool RegisterUser(string userLogin, string userPassword);
        int GetUserCurrentSimpleQuestion(string userName);
        int GetUserCurrentHardQuestion(string userName);
        int GetUserRightSimpleAnswer(string userName);
        int GetUserRightHardAnswer(string userName);
        void SetUserCurrentSimpleQuestion(string userName, int num);
        void SetUserCurrentHardQuestion(string userName, int num);
        void SetUserRightSimpleAnswer(string userName, int num);
        void SetUserRightHardAnswer(string userName, int num);
        void SetUserSimpleAnswers(string userName, string[] answers);
        void SetUserHardAnswers(string userName, string[] answers);
        string[] GetUserSimpleAnswers(string userName);
        string[] GetUserHardAnswers(string userName);
        void LogActionUser(string username, string action);
    }

    interface IQuestionsDataBase
    {
        List<string> GetSimpleQuestions();
        List<string> GetSimpleQuestionsAnswers();
        List<string> GetSimpleQuestionsRightAnswer();
        int GetCountSimpleQuestions();
        List<string> GetHardQuestions();
        List<string> GetHardQuestionsRightAnswer();
        int GetCountHardQuestions();
    }
}