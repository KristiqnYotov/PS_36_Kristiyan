
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserLogin
{
    public class UserData
    {
        //static public User[] _testUsers = new User[10];
        static public List<User> _testUsers = new List<User>();
        static public User TestUser
        {
            get
            {
                ResetTestUserData();
                return _testUsers[0];
            }
            set
            { }
        }

        static public void ResetTestUserData()
        {
            if (_testUsers.Count == 0)
            {
                _testUsers.Add
                    (new User()
                    {
                        Name = "Radomir",
                        Password = "123321",
                        facultyNumber = "501219054",
                        role = 1,
                        Created = DateTime.Now,
                        activeUntill = DateTime.MaxValue
                    });
                _testUsers.Add(new User
                {
                    Name = "Dragan",
                    Password = "12332112",
                    facultyNumber = "501219053",
                    role = 4,
                    Created = DateTime.Now,
                    activeUntill = DateTime.MaxValue
                });
                _testUsers.Add(new User
                {
                    Name = "Ivanka",
                    Password = "1233211234",
                    facultyNumber = "501219052",
                    role = 4,
                    Created = DateTime.Now,
                    activeUntill = DateTime.MaxValue
                });
            }
            else
            {
                return;
            }
        }
        static public User IsUserPasswordCorrect(string username, string pass)
        {
            return (from u in _testUsers where u.Name.Equals(username) where u.Password.Equals(pass) select u).First();

        }
        static public void setUserRole(string name, UserRoles roles)
        {
            foreach (User user in _testUsers)
            {
                if (name.Equals(user?.Name))
                {
                    user.role = Convert.ToInt32(roles);
                    Logger.LogActivity("Changed Role of " + user);
                    return;
                }
            }
        }
        static public void setUserActiveTo(string name, DateTime date)
        {
            foreach (User user in _testUsers)
            {
                if (name.Equals(user?.Name))
                {
                    user.activeUntill = date;
                    Logger.LogActivity("Changed Activiy" + user);
                    return;
                }
            }

        }
    }
}