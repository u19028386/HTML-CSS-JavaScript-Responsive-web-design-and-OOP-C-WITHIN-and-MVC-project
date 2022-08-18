using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace u19028386_HomeW04.Models
{
    public class Fish
    {
        private string _Name;
        private string _Country;
        private int _Amount;
        public Fish(string country, string name, int amount)
        {
            _Name = name;
            _Country = country;
            _Amount = amount;
        }

        public string Name
        {
            get { return _Name; }
            set { _Name = value; }
        }
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