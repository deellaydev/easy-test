using System.Collections.Generic;

namespace CourseWork
{
    public class User : IUser
    {
        private readonly UserDataBase _userDataBase = new UserDataBase();

        public User(string userName)
        {
            UserName = userName;
            CurrentSimpleQuestion = _userDataBase.GetUserCurrentSimpleQuestion(userName);
            CurrentHardQuestion = _userDataBase.GetUserCurrentHardQuestion(userName);
            RightSimpleAnswer = _userDataBase.GetUserRightSimpleAnswer(userName);
            RightHardAnswer = _userDataBase.GetUserRightHardAnswer(userName);
            SimpleAnswers = _userDataBase.GetUserSimpleAnswers(userName);
            HardAnswers = _userDataBase.GetUserHardAnswers(userName);
        }
        public string UserName { get; }

        public int CurrentSimpleQuestion { get; set; }

        public int CurrentHardQuestion { get; set; }

        public int RightSimpleAnswer { get; set; }

        public int RightHardAnswer { get; set; }
        public string[] SimpleAnswers { get; set; }
        public string[] HardAnswers { get; set; }
    }
}