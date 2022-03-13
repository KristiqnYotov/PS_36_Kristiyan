using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserLogin
{
    public class LoginValidation
    {
        public delegate void ActionOnError(string errorMsg);
        private static void errorMessage(string error)
        {
            Console.WriteLine(error);
        }
        private string _username;
        private string _password;
        private string _errorMSG;

        public LoginValidation(string username, string password, ActionOnError aon)
        {
            _username = username;
            _password = password;
        }
        public static UserRoles currentUserRole { get; private set; }
        public static string currentUserName { get; private set; }
        public Boolean ValidateUserInput(ref User user)
        {

            if (_username.Length <= 5 || _password.Length <= 5)
            {
                ActionOnError aon = new ActionOnError(errorMessage);
                aon("Password or USername too short");

                currentUserRole = UserRoles.ANONYMOUS;
                return false;
            }

            if (UserData.IsUserPasswordCorrect(_username, _password) == null)
            {
                ActionOnError aon = new ActionOnError(errorMessage);
                aon("Invalid Username or Password");

                return false;
            }
            user = UserData.IsUserPasswordCorrect(_username, _password);
            currentUserRole = (UserRoles)user.role;

            Logger.LogActivity("Succesfull Login");

            return true;
        }
    }
}
