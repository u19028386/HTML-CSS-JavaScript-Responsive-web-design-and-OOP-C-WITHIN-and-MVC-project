using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace u19028386_HomeW04.Models
{
    public class Login
    {
        [Required(ErrorMessage ="Username can not be blank.")]
        private string _Username;

        [Required(ErrorMessage = "Password can not be blank.")]
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