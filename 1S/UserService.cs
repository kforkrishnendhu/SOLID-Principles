using System;
using System.ComponentModel.DataAnnotations;
using System.Net.Mail;

namespace SOLID.S
{
    public class UserService
    {
        public void Register(string email,string password)
        {
            var emailService = new EmailServices();
            if (!emailService.ValidateEmail(email))
                throw new ValidationException("");
            var user = new User(email, password);

            emailService.SendEmail(user);
            Console.WriteLine("Registration Success");
        }

        public void Login(string email,string password)
        {
            Console.WriteLine("Login Success");
        }

       
    }
}

