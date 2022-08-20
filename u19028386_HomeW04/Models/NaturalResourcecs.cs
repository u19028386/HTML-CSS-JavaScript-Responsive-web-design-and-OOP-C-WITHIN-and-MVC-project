using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace u19028386_HomeW04.Models
{
    public class NaturalResourcecs
    {
        private string _Name;
        private string _Country;
        private int _MaxWeight;
        private int _Amount;

        public NaturalResourcecs(string name, string country, int amount, int maxweight)
        {
            _Name = name;
            _Country = country;
            _Amount = amount;
            _MaxWeight = maxweight;
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

        public int MaxWeight
        {
            get { return _MaxWeight; }
            set { _MaxWeight = value; }
        }

        public bool IsEndangered()
        {
            if (this.Amount == 50)
            {
                return true;
            }

            else return false;
        }
    }
}