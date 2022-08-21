using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace u19028386_HomeW04.Models
{
    public class Plant : NaturalResourcecs
    {
        private int _MaxHeight;

        public Plant(string name, string country, int amount, int maxweight, int maxheight) : base(name, country, amount, maxweight)
        {
            _MaxHeight = maxheight;
        }
        public int MaxHeight
        {
            get { return _MaxHeight; }
            set { _MaxHeight = value; }
        }

        public override string getInfo()
        {
            return base.getInfo();
        }
        public override bool FoundInDesert()
        {
            return true;
        }
    }
}