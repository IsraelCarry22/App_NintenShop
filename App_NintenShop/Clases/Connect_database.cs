﻿namespace App_NintenShop
{
    internal class Connect_database
    {
        static string servidor = "localhost";
        static string bd = "consolas";
        static string usuario = "root";
        static string password = "220504";
        static string puerto = "3306";

        protected string cadena_conexion = "server=" + servidor + ";" + "port=" + puerto + ";" + "user id=" + usuario + ";" + "password=" + password + ";" + "database=" + bd + ";";

        public string CADENA_CONEXION
        {
            get { return cadena_conexion; }
            set { cadena_conexion = value; }
        }
    }
}