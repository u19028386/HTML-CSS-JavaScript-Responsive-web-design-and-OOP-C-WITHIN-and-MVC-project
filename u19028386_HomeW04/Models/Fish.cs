using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace u19028386_HomeW04.Models
{
    public class Fish : NaturalResourcecs
    {
      
        private bool _SeaWater;
        public Fish(string name, string country, int amount, int maxweight,bool seawater): base(name,country,amount,maxweight)
        {
            _SeaWater = seawater;
        }

        public bool SeaWater
        {
            get { return _SeaWater; }
            set { _SeaWater = value; }
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