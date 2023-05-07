using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App_NintenShop
{
    class Videojuego : Consola, IConsola_juegos
    {
        protected String Title;
        protected String Gender;
        protected String Creators;
        protected int Price;
        protected int Quiantity;

        public string TITLE
        {
            get { return Title; }
            set { Title = value; }
        }

        public string GENERE
        {
            get { return Gender; }
            set { Gender = value; }
        }

        public string CREATORS
        {
            get { return Creators; }
            set { Creators = value; }
        }

        public int PRICE
        {
            get { return Price; }
            set { Price = value; }
        }
        public int QUANTITY
        {
            get { return Quiantity; }
            set { Quiantity = value; }
        }

        public Videojuego() : base()
        {
            Title = string.Empty;
            Gender = string.Empty;
            Creators = string.Empty;
            Price = 0;
            Quiantity = 1;
        }

        public Videojuego(String title, String gender, String creators, int price, string console, int year, int bits, int quiantity) : base(console, year, bits)
        {
            this.Title = title;
            this.Gender = gender;
            this.Creators = creators;
            this.Price = price;
            this.Quiantity = quiantity;
        }

        public override string ToString()
        {
            return $"Titulo: {Title.ToUpper()}" + ", " + $"Genero: {Gender.ToUpper()}" + ", " + $"Unidades: {Quiantity}" + ", " + $"Precio: ${Price}";
        }

        public override string Ticket()
        {
            return base.ToString() + $"Titulo: {Title.ToUpper()}" + "\n" + $"Genero: {Gender.ToUpper()}" + "\n" + $"Unidades: {Quiantity}" + "\n" + $"Precio: ${Price}" + "\n\n";
        }
    }
}