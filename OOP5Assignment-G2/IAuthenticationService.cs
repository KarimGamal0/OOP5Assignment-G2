using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP5Assignment_G2
{
    internal interface IAuthenticationService
    {
        public bool AuthenticateUser(string username,string password);
        public bool AuthorizeUser(string username, string role);
    }
}
