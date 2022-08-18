using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace u19028386_HomeW04.Models
{
    public class Login
    {
        private string _Username;
        private string _Password;
        public Login (string username, string password)
        {
            _Username = username;
            _Password = password;
        }
        public string Username
        {
            get { return _Username; }
            set { _Username = value; }
        }

        public string Password
        {
            get { return _Password; }
            set { _Password = value; }
        }

        
    }
}