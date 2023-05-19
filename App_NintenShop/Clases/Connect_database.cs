using System;
using MySql.Data.MySqlClient;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App_NintenShop
{
    internal class Connect_database
    {
        MySqlConnection Conexion = new MySqlConnection();

        static string servidor = "localhost";
        static string bd = "consolas";
        static string usuario = "root";
        static string password = "220504";
        static string puerto = "3306";

        static string cadena_conexion = "server=" + servidor + ";" + "port=" + puerto + ";" + "user id=" + usuario + ";" + "password=" + password + ";" + "database=" + bd + ";";

        public MySqlConnection establecer_conexion()
        {
            try
            {
                Conexion.ConnectionString = cadena_conexion;
                Conexion.Open();
                MessageBox.Show("Base de datos: Conexion establecida");
            }
            catch (MySqlException Error)
            {
                MessageBox.Show("Error al conectar la base de datos" + Error.ToString());
            }
            return Conexion;
        }
    }
}