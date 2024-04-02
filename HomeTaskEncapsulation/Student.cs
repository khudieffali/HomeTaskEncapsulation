using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeTaskEncapsulation
{
    internal class Student:User
    {
        public int Grade { get; set; }

     
        public Student(string name,string surname,string username,string password,int grade) : base(name, surname,username, password)
        {
            Grade=grade;
        }


        public void Login(User[] userArr, Student[] stuArr)
        {
            Console.WriteLine("Zehmet olmasa username daxil edin");
            string username = Console.ReadLine();
            Console.WriteLine("Zehmet olmasa password daxil edin");
            string password = Console.ReadLine();
            int count = 0;
            bool check = false;
            for (int i = 0; i < userArr.Length; i++)
            {
                if (userArr[i].UserName == username)
                {
                    if (userArr[i].Password == password)
                    {
                        check = true;
                        count++;
                        break;
                    }
                    else
                    {
                        Console.WriteLine("passwordu duzgun qeyd edin");
                    }
                }
            }
            if (count==0)
            {
                Console.WriteLine("Bele istifadeci movcud deyil");
            }
            count = 0;
            int counter = 0;
            foreach (var item in stuArr)
            {
            if (check)
            {
                if (item.UserName == username)
                {
                    if (item.Password == password)
                    {
                        Console.WriteLine(item.Name + " " +item.SurName);
                       Console.WriteLine(item.Grade);
                            counter++;
                    }
                    else
                    {
                        Console.WriteLine("passwordu duzgun qeyd edin");
                    }
                }
            }

            }
            if (counter == 0)
            {
                Console.WriteLine("Istifadeci Telebe deyil");
            }

        }



        public void GetInfo()
        {
            Console.WriteLine(Grade);
        }

    }
}
