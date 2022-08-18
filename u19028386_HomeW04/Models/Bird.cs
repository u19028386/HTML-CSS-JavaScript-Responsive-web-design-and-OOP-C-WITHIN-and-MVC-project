using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace u19028386_HomeW04.Models
{
    public class Bird
    {
        private string _Country;
        private int _Amount;

        public string Country
        {
            get { return _Country; }
            set { _Country = value; }
        }

        public int Amount
        {
            get { return _Amount; }
            set { _Amount = value; }
        }
    }
}