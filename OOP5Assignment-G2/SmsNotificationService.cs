using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP5Assignment_G2
{
    internal class SmsNotificationService : INotificationService
    {
        public void SendNotification(string recipient, string message = "Sms")
        {
            Console.WriteLine($"{recipient} send message contain {message} using sms");
        }
    }
}
