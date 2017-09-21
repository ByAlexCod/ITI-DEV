using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITI.User
{
    class Program
    {
        static void Main(string[] args)
        {
            
            User john = new User();
            john.UserName = "John";
            Console.WriteLine("Ecris ton mot de passe");
            
            string mdp = Console.ReadLine();
            john.SetPassword(mdp);

            if (john.PasswordMatch("password"))
            {
                Console.WriteLine("Success !");
            } else
            {
                Console.WriteLine("Problem occured...");
            }
            Console.ReadLine();
        }
    }
}
