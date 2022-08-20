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
        private int _MaxWeight;
        private int _Amount;
        private string _WaterType;
        private string _Category;
        public Fish(string name,string country, int amount, int maxweight, string watertype, string category)
        {
            _Name = name;
            _Country = country;
            _Amount = amount;
            _MaxWeight = maxweight;
            _WaterType = watertype;
            _Category = category;
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

        public string WaterType
        {
            get { return _WaterType; }
            set { _WaterType = value; }
        }

        public string Category
        {
            get { return _Category; }
            set { _Category = value; }
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
    }
}