using DelegatePractice.Model;
using System;
using System.Collections;

namespace DelegatePractice
{
    class Program
    {
        static void Main(string[] args)
        {
            string choice = "Y";
           
            UserDelegate userDelegate = new Company().Register;
            while (String.Equals(choice,"Y"))
            {
                User user = new User();
                user.Name = Console.ReadLine();
                user.Surname = Console.ReadLine();
                user.Password = Console.ReadLine();

                userDelegate.Invoke(user.Name,user.Surname,user.Password);
                choice = Console.ReadLine();  
                

            }
        }
        public delegate void UserDelegate(string name,string surname,string password);
    }
}
















