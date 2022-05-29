using System;
using System.Collections.Generic;
using System.Data;
using MySql.Data.MySqlClient;

namespace CourseWork
{
    public class DataBase : IDataBase
    {
        private const string Server = "";
        private const string User = "";
        private const string Pwd = "";
        private const string Db = "";

        private const string ConcatConn = "server=" + Server+";user="+User+";pwd="+Pwd+";database="+Db+";SslMode=none;charset=utf8";
        
        private readonly MySqlConnection _sqlConnection = new MySqlConnection(ConcatConn);

        public void OpenConnection()
        {
            if (_sqlConnection.State == ConnectionState.Closed)
            {
                _sqlConnection.Open();
            }
        }
        
        public void CloseConnection()
        {
            if (_sqlConnection.State == ConnectionState.Open)
            {
                _sqlConnection.Close();
            }
        }

        public MySqlConnection GetConnection()
        {
            return _sqlConnection;
        }
    }

    public class UserDataBase : DataBase, IUserDataBase
    {

        public bool LoginUser(string userLogin, string userPassword)
        {
            string queryString =
                $"select user_id, user_name, user_password from users where user_name = '{userLogin}' and user_password = '{userPassword}'";
            
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            DataTable table = new DataTable();
            
            MySqlCommand command = new MySqlCommand(queryString, GetConnection());
            
            adapter.SelectCommand = command;
            adapter.Fill(table);

            if (table.Rows.Count < 1)
            {
                return false;
            }
            
            return true;
        }

        public bool CheckUser(string userLogin)
        {
            string queryString =
                $"select user_id, user_name, user_password from users where user_name = '{userLogin}'";
            
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            DataTable table = new DataTable();
            
            MySqlCommand command = new MySqlCommand(queryString, GetConnection());
            
            adapter.SelectCommand = command;
            adapter.Fill(table);

            if (table.Rows.Count < 1)
            {
                return false;
            }
            
            return true;
        }

        public bool RegisterUser(string userLogin, string userPassword)
        {

            string answersSimplePattern = "";
            string answersHardPattern = "";

            for (int i = 0; i != new QuestionsDataBase().GetCountSimpleQuestions() - 1; i++)
            {
                answersSimplePattern += ";";
            }
            
            for (int i = 0; i != new QuestionsDataBase().GetCountHardQuestions() - 1; i++)
            {
                answersHardPattern += ";";
            }

            string queryString = 
                $"insert into users(user_name, user_password, current_simple_question, current_hard_question, right_simple_answer, right_hard_answer, simple_answers, hard_answers) " +
                $"values ('{userLogin}', '{userPassword}', 0, 0, 0, 0, '{answersSimplePattern}', '{answersHardPattern}')";

            MySqlCommand command = new MySqlCommand(queryString, GetConnection());
            
            OpenConnection();
            if (command.ExecuteNonQuery() < 1)
            {
                return false;
            }
            CloseConnection();
            
            return true;
        }

        public int GetUserCurrentSimpleQuestion(string userName)
        {
            string queryString = $"select current_simple_question from users where user_name = '{userName}'";
            
            MySqlCommand command = new MySqlCommand(queryString, GetConnection());
            
            OpenConnection();
            int currentSimpleQuestion = Convert.ToInt32(command.ExecuteScalar());
            CloseConnection();

            return currentSimpleQuestion;
        }
        
        public int GetUserCurrentHardQuestion(string userName)
        {
            string queryString = $"select current_hard_question from users where user_name = '{userName}'";
            
            MySqlCommand command = new MySqlCommand(queryString, GetConnection());
            
            OpenConnection();
            int currentHardQuestion = Convert.ToInt32(command.ExecuteScalar());
            CloseConnection();

            return currentHardQuestion;
        }
        
        public int GetUserRightSimpleAnswer(string userName)
        {
            string queryString = $"select right_simple_answer from users where user_name = '{userName}'";
            
            MySqlCommand command = new MySqlCommand(queryString, GetConnection());
            
            OpenConnection();
            int rightSimpleQuestion = Convert.ToInt32(command.ExecuteScalar());
            CloseConnection();

            return rightSimpleQuestion;
        }
        
        public int GetUserRightHardAnswer(string userName)
        {
            string queryString = $"select right_hard_answer from users where user_name = '{userName}'";
            
            MySqlCommand command = new MySqlCommand(queryString, GetConnection());
            
            OpenConnection();
            int rightHardQuestion = Convert.ToInt32(command.ExecuteScalar());
            CloseConnection();

            return rightHardQuestion;
        }
        
        public void SetUserCurrentSimpleQuestion(string userName, int num)
        {
            string queryString = $"update users set current_simple_question = {num} where user_name = '{userName}';";
            
            MySqlCommand command = new MySqlCommand(queryString, GetConnection());
            
            OpenConnection();
            command.ExecuteNonQuery();
            CloseConnection();
        }
        
        public void SetUserCurrentHardQuestion(string userName, int num)
        {
            string queryString = $"update users set current_hard_question = {num} where user_name = '{userName}';";
            
            MySqlCommand command = new MySqlCommand(queryString, GetConnection());
            
            OpenConnection();
            command.ExecuteNonQuery();
            CloseConnection();
        }
        
        public void SetUserRightSimpleAnswer(string userName, int num)
        {
            string queryString = $"update users set right_simple_answer = {num} where user_name = '{userName}';";
            
            MySqlCommand command = new MySqlCommand(queryString, GetConnection());
            
            OpenConnection();
            command.ExecuteNonQuery();
            CloseConnection();
        }
        
        public void SetUserRightHardAnswer(string userName, int num)
        {
            string queryString = $"update users set right_hard_answer = {num} where user_name = '{userName}';";
            
            MySqlCommand command = new MySqlCommand(queryString, GetConnection());
            
            OpenConnection();
            command.ExecuteNonQuery();
            CloseConnection();
        }

        public void SetUserSimpleAnswers(string userName, string[] answers)
        {
            string answersString = "";

            foreach (string item in answers)
            {
                answersString += item + ";";
            }

            string queryString = $"update users set simple_answers = '{answersString}' where user_name = '{userName}'";

            MySqlCommand command = new MySqlCommand(queryString, GetConnection());
            
            OpenConnection();
            command.ExecuteNonQuery();
            CloseConnection();

        }
        
        public void SetUserHardAnswers(string userName, string[] answers)
        {
            string answersString = "";

            foreach (string item in answers)
            {
                answersString += item + ";";
            }

            string queryString = $"update users set hard_answers = '{answersString.Substring(0, answersString.Length - 1)}' where user_name = '{userName}'";

            MySqlCommand command = new MySqlCommand(queryString, GetConnection());
            
            OpenConnection();
            command.ExecuteNonQuery();
            CloseConnection();
        }
        
        public string[] GetUserSimpleAnswers(string userName)
        {
            string queryString = $"select simple_answers from users where user_name = '{userName}'";

            MySqlCommand command = new MySqlCommand(queryString, GetConnection());
            
            OpenConnection();
            MySqlDataReader reader = command.ExecuteReader();
            string result = "";

            while (reader.Read())
            {
                result = $"{reader["simple_answers"]}";
            }
            string[] listResult = result.Split(';');
            CloseConnection();

            return listResult;
        }
        
        public string[] GetUserHardAnswers(string userName)
        {
            string queryString = $"select hard_answers from users where user_name = '{userName}'";

            MySqlCommand command = new MySqlCommand(queryString, GetConnection());
            
            OpenConnection();
            MySqlDataReader reader = command.ExecuteReader();
            string result = "";

            while (reader.Read())
            {
                result = $"{reader["hard_answers"]}";
            }
            string[] listResult = result.Split(';');
            CloseConnection();

            return listResult;
        }

        public void LogActionUser(string username, string action)
        {
            string queryString =
                $"insert into logs(user_name, log_action, date) values ('{username}', '{action}', NOW())";

            MySqlCommand command = new MySqlCommand(queryString, GetConnection());
            
            OpenConnection();
            command.ExecuteNonQuery();
            CloseConnection();
            
        }

        public void UpdateUserStat(string username)
        {
            
            string answersSimplePattern = "";
            string answersHardPattern = "";

            for (int i = 0; i != new QuestionsDataBase().GetCountSimpleQuestions() - 1; i++)
            {
                answersSimplePattern += ";";
            }
            
            for (int i = 0; i != new QuestionsDataBase().GetCountHardQuestions() - 1; i++)
            {
                answersHardPattern += ";";
            }
            
            string queryString = $"update users set current_simple_question = 0, current_hard_question = 0, right_simple_answer = 0, right_hard_answer = 0, simple_answers = '{answersSimplePattern}', hard_answers = '{answersHardPattern}'  where user_name = '{username}'";
            
            MySqlCommand command = new MySqlCommand(queryString, GetConnection());
            
            OpenConnection();
            command.ExecuteNonQuery();
            CloseConnection();
        }
        
    }

    public class QuestionsDataBase : DataBase, IQuestionsDataBase
    {
        public List<string> GetSimpleQuestions()
        {
            string queryString = $"select question_text from simplequestions;";

            MySqlCommand command = new MySqlCommand(queryString, GetConnection());
            
            OpenConnection();
            MySqlDataReader reader = command.ExecuteReader();

            List<string> simpleQuestions = new List<string>();

            while (reader.Read())
            {
                simpleQuestions.Add($"{reader["question_text"]}");
            }
            CloseConnection();

            return simpleQuestions;
        }

        public List<string> GetSimpleQuestionsAnswers()
        {
            string queryString = $"select answers from simplequestions;";

            MySqlCommand command = new MySqlCommand(queryString, GetConnection());
            
            OpenConnection();
            MySqlDataReader reader = command.ExecuteReader();

            List<string> simpleQuestionsAnswers = new List<string>();

            while (reader.Read())
            {
                simpleQuestionsAnswers.Add($"{reader["answers"]}");
            }
            CloseConnection();

            return simpleQuestionsAnswers;
        }
        
        public List<string> GetSimpleQuestionsRightAnswer()
        {
            string queryString = $"select right_answer from simplequestions;";

            MySqlCommand command = new MySqlCommand(queryString, GetConnection());
            
            OpenConnection();
            MySqlDataReader reader = command.ExecuteReader();

            List<string> simpleQuestionsRightAnswer = new List<string>();

            while (reader.Read())
            {
                simpleQuestionsRightAnswer.Add($"{reader["right_answer"]}");
            }
            CloseConnection();

            return simpleQuestionsRightAnswer;
        }

        public int GetCountSimpleQuestions()
        {
            string queryString = $"select count(*) from simplequestions;";

            MySqlCommand command = new MySqlCommand(queryString, GetConnection());
            
            OpenConnection();
            int countSimpleQuestions = Convert.ToInt32(command.ExecuteScalar());
            CloseConnection();

            return countSimpleQuestions;
        }
        
        public List<string> GetHardQuestions()
        {
            string queryString = $"select question_text from hardquestions;";

            MySqlCommand command = new MySqlCommand(queryString, GetConnection());
            
            OpenConnection();
            MySqlDataReader reader = command.ExecuteReader();

            List<string> simpleQuestions = new List<string>();

            while (reader.Read())
            {
                simpleQuestions.Add($"{reader["question_text"]}");
            }
            CloseConnection();

            return simpleQuestions;
        }

        public List<string> GetHardQuestionsRightAnswer()
        {
            string queryString = $"select right_answer from hardquestions;";

            MySqlCommand command = new MySqlCommand(queryString, GetConnection());
            
            OpenConnection();
            MySqlDataReader reader = command.ExecuteReader();

            List<string> simpleQuestionsRightAnswer = new List<string>();

            while (reader.Read())
            {
                simpleQuestionsRightAnswer.Add($"{reader["right_answer"]}");
            }
            CloseConnection();

            return simpleQuestionsRightAnswer;
        }

        public int GetCountHardQuestions()
        {
            string queryString = $"select count(*) from hardquestions;";

            MySqlCommand command = new MySqlCommand(queryString, GetConnection());
            
            OpenConnection();
            int countSimpleQuestions = Convert.ToInt32(command.ExecuteScalar());
            CloseConnection();

            return countSimpleQuestions;
        }
    }
}