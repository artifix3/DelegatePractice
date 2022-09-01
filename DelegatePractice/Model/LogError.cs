using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatePractice.Model
{
    public class LogError
    {
        public static void ErrorMessage(string message)
        {
            Console.Error.WriteLine(message);
        }
    }
}
