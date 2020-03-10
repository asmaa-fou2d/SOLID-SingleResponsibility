using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AfterSRP
{
    public class UserService
    {
        private readonly Logger _logger;
        private readonly EmailSender _emailSender;

        public UserService()
        {
            _logger = new Logger();
            _emailSender = new EmailSender();
        }

        public void Register(User user)
        {
            try
            {
                //implement adding user to database

                _emailSender.SendEmail(user.Email, "Complete Registration ", "Complete Registration");

            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message);
            }
        }

    }
}
