using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeTaskEncapsulation
{
    internal class User
    {
        public string Name { get; set; }
        public string SurName { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }

        public User(string name,string surname,string username,string password)
        {
            Name = name;
            SurName= surname;
            UserName = username;
            Password = password;
        }

        public User()
        {
            
        }

        public void GetInfo(Student student)
        {
            Console.WriteLine(student.Grade);
        }
    }
}
