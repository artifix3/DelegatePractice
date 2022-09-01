using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatePractice.Model
{
    public delegate void ErrorMessage(string message);
    public delegate void CompanyDelegate(string name, string surname, List<User> users, ref User user);
    public class Company
    {
        public int Name { get; set; }
        public List<User> Users { get; set; }
        public Company(string name)
        {
            Users = new List<User>();
        }

        public void Register()
        {
            ErrorMessage errorMessage = new ErrorMessage(LogError.ErrorMessage);
            CompanyDelegate companyDelegate = new CompanyDelegate(LogRegistration.CreatingEmail);
            

        }
        public bool CheckPass(string pass)
        {
            bool isdigit = false;
            bool passcorrect = false;
            foreach (var item in pass)
            {
                if (char.IsDigit(item))
                {
                    isdigit = true;
                     passcorrect = false;
                    break;
                }
            }
            if (pass.Length >= 8 && char.IsUpper(pass[0]) && isdigit)
            {
                passcorrect = true;

            }
            return passcorrect;
        }
    }
}
