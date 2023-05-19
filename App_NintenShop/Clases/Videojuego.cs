using System;

namespace App_NintenShop
{
    class Videojuego : Consola, IConsola_juegos
    {
        protected String Title;
        protected String Gender;
        protected String Creators;
        protected double Price;
        protected int Folder;
        protected int Num_Image;

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

        public double PRICE
        {
            get { return Price; }
            set { Price = value; }
        }
        public int FOLDER
        {
            get { return Folder; }
            set { Folder = value; }
        }
        public int NUM_IMAGE
        {
            get { return Num_Image; }
            set { Num_Image = value; }
        }

        public Videojuego() : base()
        {
            Title = string.Empty;
            Gender = string.Empty;
            Creators = string.Empty;
            Price = 0;
            Folder = 0;
            Num_Image = 0;
        }

        public Videojuego(String title, String gender, String creators, double price, string console, int year, int bits, int folder, int num_image) : base(console, year, bits)
        {
            this.Title = title;
            this.Gender = gender;
            this.Creators = creators;
            this.Price = price;
            this.Folder = folder;
            this.Num_Image = num_image;
        }

        public override string ToString()
        {
            return $"Titulo: {Title.ToUpper()}" + ", " + $"Genero: {Gender.ToUpper()}" + ", " + $"Precio: ${Price}";
        }

        public override string Ticket()
        {
            return $"Titulo: {Title.ToUpper()}"
            + "\n" + $"Año: {Year}"
            + "\n" + $"Genero: {Gender.ToUpper()}"
            + "\n" + $"Consola: {Console.ToUpper()}"
            + "\n" + $"Creadores: {Creators.ToUpper()}"
            + "\n" + $"Precio: ${Price}"
            + "\n" + $"Bits: {Bits}"
            + "\n\n" + base.ToString();
        }
    }
}