using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Music_Application_With_SQL
{
    public class Login
    {
        int number = 0;

        public string GenerateCaptcha()
        {
            int number = 0;
            Random ran_num = new Random();
            number = ran_num.Next(1, 9999);
            return number.ToString();
            
        }
        public bool ValidateCaptcha(string userCaptcha)
        {
            if (number.ToString() == userCaptcha)
            {
                return true;
            }
            else
            {
                return false;
            }
        }


    }
}
