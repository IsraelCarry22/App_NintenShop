using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App_NintenShop
{
    public abstract class Consola
    {
        protected String Console;
        protected int Year;
        protected int Bits;

        public string CONSOLE
        {
            get { return Console; }
            set { Console = value; }
        }

        public int YEAR
        {
            get { return Year; }
            set { Year = value; }
        }

        public int BITS
        {
            get { return Bits; }
            set { Bits = value; }
        }

        public Consola()
        {
            Console = string.Empty;
            Year = 0;
            Bits = 0;
        }

        public Consola(string console, int year, int bits) 
        {
            this.Console = console;
            this.Year = year;
            this.Bits = bits;
        }

        public override string ToString()
        {
            return "";
        }
        public virtual string Ticket()
        {
            return "";
        }
    }
}