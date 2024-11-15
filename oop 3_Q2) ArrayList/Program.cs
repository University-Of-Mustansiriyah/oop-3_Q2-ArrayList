using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_3_Q2__ArrayList
{
    class useraccount
    {
        public string email;
        public string username;
        public string password;
        public useraccount(string email, string username, string password)
        {
            this.email = email;
            this.username = username;
            this.password = password;
        }
        public useraccount(useraccount u)
        {
            email = u.email;
            username = u.username;
            password = u.password;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            ArrayList a = new ArrayList();
            useraccount user = new useraccount("mustafa@gmail.com", "mustafa", "1234");
            a.Add(user);
            Console.WriteLine("enter username");
            string un = Console.ReadLine();
            Console.WriteLine("enter password");
            string pa = Console.ReadLine();
            foreach (useraccount ac in a)
            {
                if (ac.username == un && ac.password == pa)
                {
                    Console.WriteLine("Correct");                  
                }
                else
                {
                    Console.WriteLine("invalid");
                }
            }
            Console.ReadLine();
        }
    }
}
