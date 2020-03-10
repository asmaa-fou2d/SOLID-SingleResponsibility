using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeforeSRP
{
    class Program
    {
        static void Main(string[] args)
        {
            User user = new User();
            Console.WriteLine("Please enter your Name");
            user.Name = Console.ReadLine();

            Console.WriteLine("Please enter your Email");
            user.Email = Console.ReadLine();

            UserService service = new UserService();
            service.Register(user);
        }

    }
}
