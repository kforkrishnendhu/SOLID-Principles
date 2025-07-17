using System;
namespace SOLID.S
{
	public class EmailServices
	{
        public void SendEmail(User message)
        {
            Console.WriteLine("send message");
        }
            


        public virtual bool ValidateEmail(string email)
        {
            return email.Contains('@');
        }
    }
}

