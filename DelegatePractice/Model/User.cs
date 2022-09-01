using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatePractice.Model
{
    public class User
    {
        public int Id { get; set; }
         private static int id;
        public string? Name { get; set; }
        public string? Surname { get; set; }
        public string? Password { get; set; }
        public string? Email { get; set; }
        public string? UserName { get; set; }
        
        public User()
        {
            this.Id = System.Threading.Interlocked.Increment(ref id);
        }
    }
}
