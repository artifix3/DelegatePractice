using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatePractice.Model
{
    public static class LogRegistration
    {
        public static void Creating(string name, string surname, ref User user, List<User> users)
        {
            string username=name.ToLower()+surname.ToLower();
            
            int c = 0;
            for (int i = 0; i < users.Count;)
            {
                if (username == users[i].UserName)
                {
                    Console.WriteLine("Duplicate Name");
                    c++;
                    username = name + surname + c.ToString();
                    i = 0;
                }
                else i++;
              
            }

            user.UserName=username;
            //user.Email = useremail;

        }
        public static void CreatingEmail(string name, string surname, ref User user, List<User> users)
        {
            string useremail = name.ToLower() + surname.ToLower() + "@gmail.com";
            int c = 0;
            for (int i = 0; i < users.Count;)
            {
                if (useremail == users[i].Email)
                {
                    Console.WriteLine("Duplicate Name");
                    c++;
                    useremail = name + surname + c.ToString();
                    i = 0;
                }
                else i++;

            }
            user.Email = useremail;

        }



    }
}
