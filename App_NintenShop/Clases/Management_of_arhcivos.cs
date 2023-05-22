using System;
using System.Collections.Generic;
using System.IO;
using System.Security.AccessControl;

namespace App_NintenShop
{
    internal class Management_of_arhcivos
    {
        private StreamWriter file_tiket;

        public Management_of_arhcivos(List<Videojuego> cart_Video_Games_List, int ticket_quantity, double final_purchase_with_Iva, double final_purchase)
        {
            string Date_Time_Ticket = DateTime.Now.ToString();
            string Desktop = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            string Ticket = Path.Combine(Desktop, $"NintenShop {ticket_quantity}.txt");
            using (file_tiket = new StreamWriter(Ticket))
            {
                file_tiket.WriteLine($"NintenShop Inc.                  {Date_Time_Ticket}\n");
                foreach (Consola Console in cart_Video_Games_List)
                {
                    file_tiket.WriteLine(Console.Ticket());
                }
                string Salida_1 = string.Format("{0:C2}", final_purchase_with_Iva);
                string Salida_2 = string.Format("{0:C2}", final_purchase);
                file_tiket.WriteLine($"Iva: {Salida_1}");
                file_tiket.WriteLine($"Compra Total: {Salida_2}");
                file_tiket.WriteLine("\nGracias por comprar en NintenShop Inc.");
            }
        }
        ~Management_of_arhcivos()
        {
            file_tiket.Close();
        }
    }
}