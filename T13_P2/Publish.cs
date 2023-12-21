using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T13_P2
{
    class Publish
    {
        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        private string fam;

        public string Fam
        {
            get { return fam; }
            set { fam = value; }
        }

        private int year;

        public int Year
        {
            get { return year; }
            set { year =(value<1998||value>2023)?0:value; }
        }


        public Publish() { }
        public Publish(string name,string fam,int year)
        {
            this.Name = name;
            this.Fam = fam;
            this.Year = year;
        
        }

        public override string ToString()
        {
            return $"{Name}\n{Fam}\n{Year}";
        }


        public int Plus(int x)
        {
            return x += Year;
        }


    }
}
