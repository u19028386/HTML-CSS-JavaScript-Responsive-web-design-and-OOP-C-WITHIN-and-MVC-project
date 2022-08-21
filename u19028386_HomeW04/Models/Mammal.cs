using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace u19028386_HomeW04.Models
{
    public class Mammal : NaturalResourcecs
    {
      
        private string _Type;

        public Mammal(string name, string country, int amount, int maxweight, string type) : base(name, country, amount, maxweight)
        {
            _Type = type;
        }
        public string Type
        {
            get { return _Type; }
            set { _Type = value; }
        }

        public override string getInfo()
        {
            return base.getInfo();
        }
        public override bool FoundInDesert()
        {
            return false;
        }
    }
}