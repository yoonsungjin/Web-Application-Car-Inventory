using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBLib.entities
{  
    public class Member
    {
        public string Name { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public string Password { get; set; }
    
        public Member(string name, string phone, string email, string address, string password) {
            Name = name;
            Phone = phone;
            Email = email;
            Address = address;
            Password = password;

        }
    }
}
