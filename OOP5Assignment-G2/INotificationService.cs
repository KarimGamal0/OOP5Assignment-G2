using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP5Assignment_G2
{
    internal interface INotificationService
    {
        public void SendNotification(string recipient, string message);
    }
}
