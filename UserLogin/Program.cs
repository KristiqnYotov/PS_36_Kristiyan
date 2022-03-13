using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.IO;
namespace UserLogin
{
    internal class Program
    {
        public static void onError(string str)
        {
            Console.WriteLine("!!! " + str + " !!!");

        }

        public static void AdminMenu()
        {
            Console.WriteLine("Welcome " + LoginValidation.currentUserRole + "\n" + "Select an Option:\n1 Change Role\n2" +
                " Change Active Date\n3 List Users\n4 check logs\n5 Current Acitve Logs\n0 Exit\n");
            int choice = Convert.ToInt32(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    Console.WriteLine("Enter Username and new Role");
                    UserData.setUserRole(Console.ReadLine(), (UserRoles)Convert.ToInt32(Console.ReadLine()));
                    break;
                case 2:
                    Console.WriteLine("Enter Username and date");
                    UserData.setUserActiveTo(Console.ReadLine(), Convert.ToDateTime(Console.ReadLine()));
                    break;
                case 3:
                    foreach (User u in UserData._testUsers)
                    {
                        Console.WriteLine(u.Name);
                    }
                    break;
                case 4:
                    StreamReader sr = new StreamReader("Logs.txt");
                    if (File.Exists("Logs.txt") == true)
                    {
                        while (sr.ReadLine() != null)
                            Console.WriteLine(sr.ReadLine());
                    }
                    break;
                case 5:
                    StringBuilder sb = new StringBuilder();
                    IEnumerable<string> list = Logger.GetCurrentSessionActivities();
                    foreach (string activity in list)
                    {
                        sb.Append(activity);
                    }
                    //?
                    Console.WriteLine(sb);
                    break;
                case 0: return;
                default: return;
            }

        }
        static void Main(string[] args)
        {

            User admin = new User();

            UserData[] testUsers;
            testUsers = new UserData[10];


            UserData.ResetTestUserData();
            Console.WriteLine("Enter Username And Password");
            LoginValidation loginValidation = new LoginValidation(Console.ReadLine(), Console.ReadLine(), onError);

            if (loginValidation.ValidateUserInput(ref admin))
            {
                Console.WriteLine(admin.Name + "\n" + admin.Password + "\n" + admin.facultyNumber + "\n" + admin.role);

            }

            switch (LoginValidation.currentUserRole)
            {
                case UserRoles.ADMIN:
                    AdminMenu();
                    break;
                case UserRoles.PROFESSOR:
                    Console.WriteLine("Welcome " + LoginValidation.currentUserRole);
                    break;
                case UserRoles.STUDENT:
                    Console.WriteLine("Welcome " + LoginValidation.currentUserRole);
                    break;
                case UserRoles.INSPECTOR:
                    Console.WriteLine("Welcome " + LoginValidation.currentUserRole);
                    break;
                case UserRoles.ANONYMOUS:
                    Console.WriteLine("Invalid Login:" + LoginValidation.currentUserRole);
                    break;

            }
            Thread.Sleep(5000);
        }
    }
}