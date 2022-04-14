using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegistrationProblem_Exception
{
    public class UserRegistration
    {
        private string message;

        public UserRegistration(string message)
        {
            this.message = message;
        }

        public string Registration()
        {
            try
            {
                if (this.message.Contains("Snehal"))
                {
                    return "Name is Snehal";
                }
                else
                {
                    return "Name is Not Entered";
                }
            }
            catch
            {
                return "Name is Not Entered";
            }
        }
        public string Password()
        {
            try
            {
                if (this.message.Contains("12345678"))
                {
                    return "Password is Correct";
                }
                else
                {
                    return "Wrong Password";
                }
            }
            catch
            {
                return "Wrong Password";
            }
        }
        public string Email()
        {
            try
            {
                if (this.message.Contains("snehal@gmail.com"))
                {
                    return "Email is Correct";
                }
                else
                {
                    return "Wrong Email";
                }
            }
            catch
            {
                return "Wrong Email";

            }
        }
        public string Date_Of_Birth()
        {
            try
            {
                if (this.message.Contains("14/12/1999"))
                {
                    return "Age is Eligible";
                }
                else
                {
                    return "Age is Below 18";
                }
            }
            catch
            {
                return "Age is Below 18";
            }
        }
        public string Mobile_number()
        {
            try
            {
                if (this.message.Contains("8106529025"))
                {

                    return "Mobile Number is Correct";
                }
                else
                {
                    return "Mobile is not Correct";
                }
            }
            catch
            {
                return "Mobile is not Correct";
            }
        }
    }
}