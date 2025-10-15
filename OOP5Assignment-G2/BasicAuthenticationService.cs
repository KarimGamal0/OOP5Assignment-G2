using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP5Assignment_G2
{
    internal class BasicAuthenticationService : IAuthenticationService
    {
        private string userName = "User";
        private string password = "123";
        private string role = "Admin";

        public bool AuthenticateUser(string username, string password)
        {
            if(this.userName== username && this.password == password) 
                return true;

            return false;
        }

        public bool AuthorizeUser(string username, string role)
        {
            if (this.userName == username && this.role == role)
                return true;

            return false;
        }
    }
}
