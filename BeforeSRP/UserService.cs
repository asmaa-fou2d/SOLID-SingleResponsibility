using System;

namespace BeforeSRP
{
    public class UserService
    {
        public void Register(User user)
        {
            try
            {
                //implement adding user to database

                //implement sending him a confimation email

                Console.WriteLine("Please check your email for complete registration");
            }
            catch (Exception ex)
            {
                // implement logging error 
            }
        }

    }
}
