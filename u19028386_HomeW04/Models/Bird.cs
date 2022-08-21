using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace u19028386_HomeW04.Models
{
    public class Bird : NaturalResourcecs
    {
       
        private int _Speed;

        public Bird(string name, string country, int amount, int maxweight, int speed) : base(name, country, amount, maxweight)
        {
            _Speed = speed;
        }
        public int Speed
        {
            get { return _Speed; }
            set { _Speed = value; }
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