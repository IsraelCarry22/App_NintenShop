﻿using System;
using MySql.Data.MySqlClient;
using System.Linq;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Media;
using System.IO;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Diagnostics;
using System.Text.RegularExpressions;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace App_NintenShop
{
    public partial class From_NintenShop : Form
    {
        Management_of_arhcivos Files_Doc;
        Videojuego[] videojuegos_nes, videojuegos_snes, videojuegos_n64, videojuegos_gb, videojuegos_gba;
        List<Videojuego> Cart_Video_Games_List;
        int Accountan, Index_Dgv, Ticket_quantity = 0;
        double Final_purchase_with_Iva, Final_purchase = 0.00;
        bool Filter_Nes, Filter_Snes, Filter_Gb, Filter_N64, Filter_Gba;
        string Main_folder, Music;
        string[,] Image_Paths;
        public From_NintenShop()
        {
            InitializeComponent();
            this.MaximizeBox = false;
            Main_folder = @"C:\Users\Israe\Pictures\NintenShop";
            Music = @"C:\Users\Israe\Pictures\NintenShop\NintenShop.wav";
            SoundPlayer player = new SoundPlayer(Music);
            player.PlayLooping();
            videojuegos_nes = new Videojuego[15];
            videojuegos_gb = new Videojuego[15];
            videojuegos_snes = new Videojuego[15];
            videojuegos_n64 = new Videojuego[15];
            videojuegos_gba = new Videojuego[15];
            Cart_Video_Games_List = new List<Videojuego>();
            Image_Paths = new string[5, 15];
            Filter_Nes = true;
            Filter_Snes = false;
            Filter_Gb = false;
            Filter_N64 = false;
            Filter_Gba = false;
        }

        private void From_NintenShop_Load(object sender, EventArgs e)
        {
            Datos_MySql_Arreglos();
            for (int i = 0; i < 5; i++)
            {
                string Folder = Path.Combine(Main_folder, $"Carpeta {i + 1}");
                string[] File = Directory.GetFiles(Folder, "*.jpg");
                Array.Sort(File);
                for (int j = 0; j < File.Length && j < 15; j++)
                {
                    Image_Paths[i, j] = File[j];
                }
            }
        }

        public void Btm_filter_nes_Click(object sender, EventArgs e)
        {
            Filter_Nes = true;
            Filter_Snes = false;
            Filter_Gb = false;
            Filter_N64 = false;
            Filter_Gba = false;
            Filter_Games(Filter_Nes, videojuegos_nes);
        }

        public void Btm_filter_gb_Click(object sender, EventArgs e)
        {
            Filter_Nes = false;
            Filter_Snes = false;
            Filter_Gb = true;
            Filter_N64 = false;
            Filter_Gba = false;
            Filter_Games(Filter_Gb, videojuegos_gb);
        }

        public void Btm_filter_snes_Click(object sender, EventArgs e)
        {
            Filter_Nes = false;
            Filter_Snes = true;
            Filter_Gb = false;
            Filter_N64 = false;
            Filter_Gba = false;
            Filter_Games(Filter_Snes, videojuegos_snes);
        }

        public void Btm_filter_n64_Click(object sender, EventArgs e)
        {
            Filter_Nes = false;
            Filter_Snes = false;
            Filter_Gb = false;
            Filter_N64 = true;
            Filter_Gba = false;
            Filter_Games(Filter_N64, videojuegos_n64);
        }

        public void Btm_filter_gba_Click(object sender, EventArgs e)
        {
            Filter_Nes = false;
            Filter_Snes = false;
            Filter_Gb = false;
            Filter_N64 = false;
            Filter_Gba = true;
            Filter_Games(Filter_Gba, videojuegos_gba);
        }

        private void ayudaToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Panel_Carrito.Visible = true;
            Panel_Ayuda.Visible = true;
        }

        private void InicioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Panel_Carrito.Visible = false;
            Panel_Ayuda.Visible = false;
        }

        private void CarritoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Panel_Carrito.Visible = true;
            Panel_Ayuda.Visible = false;
        }

        private void Btn_carrito_Click(object sender, EventArgs e)
        {
            Panel_Carrito.Visible = true;
            Panel_Ayuda.Visible = false;
        }

        private void Btn_comprar_Click(object sender, EventArgs e)
        {
            int Selected_Game_Buy = List_juegos.SelectedIndex;
            if (Filter_Nes == true)
            {
                Comprar_Unidad(videojuegos_nes, Selected_Game_Buy);
            }
            else if (Filter_Gb == true)
            {
                Comprar_Unidad(videojuegos_gb, Selected_Game_Buy);
            }
            else if (Filter_Snes == true)
            {
                Comprar_Unidad(videojuegos_snes, Selected_Game_Buy);
            }
            else if (Filter_N64 == true)
            {
                Comprar_Unidad(videojuegos_n64, Selected_Game_Buy);
            }
            else
            {
                Comprar_Unidad(videojuegos_gba, Selected_Game_Buy);
            }
        }

        private void Btn_añadir_carrito_Click(object sender, EventArgs e)
        {
            int Selected_Game_Buy = List_juegos.SelectedIndex;
            Videojuego Selected_Game;
            if (Selected_Game_Buy != -1)
            {
                if (Filter_Nes == true)
                {
                    Selected_Game = videojuegos_nes[Selected_Game_Buy];
                    Add_Cart_Item(Selected_Game);
                }
                else if (Filter_Gb == true)
                {
                    Selected_Game = videojuegos_gb[Selected_Game_Buy];
                    Add_Cart_Item(Selected_Game);
                }
                else if (Filter_Snes == true)
                {
                    Selected_Game = videojuegos_snes[Selected_Game_Buy];
                    Add_Cart_Item(Selected_Game);
                }
                else if (Filter_N64 == true)
                {
                    Selected_Game = videojuegos_n64[Selected_Game_Buy];
                    Add_Cart_Item(Selected_Game);
                }
                else
                {
                    Selected_Game = videojuegos_gba[Selected_Game_Buy];
                    Add_Cart_Item(Selected_Game);
                }
            }
        }

        private void List_juegos_SelectedIndexChanged(object sender, EventArgs e)
        {
            int Selected_Index = List_juegos.SelectedIndex;
            if (Selected_Index != -1)
            {
                Videojuego Selected_Game;
                if (Filter_Nes == true)
                {
                    Selected_Game = videojuegos_nes[Selected_Index];
                    Information_Game(videojuegos_nes, Selected_Index);
                }
                else if (Filter_Gb == true)
                {
                    Selected_Game = videojuegos_gb[Selected_Index];
                    Information_Game(videojuegos_gb, Selected_Index);
                }
                else if (Filter_Snes == true)
                {
                    Selected_Game = videojuegos_snes[Selected_Index];
                    Information_Game(videojuegos_snes, Selected_Index);
                }
                else if (Filter_N64 == true)
                {
                    Selected_Game = videojuegos_n64[Selected_Index];
                    Information_Game(videojuegos_n64, Selected_Index);
                }
                else
                {
                    Selected_Game = videojuegos_gba[Selected_Index];
                    Information_Game(videojuegos_gba, Selected_Index);
                }
            }
        }

        private void Btn_eliminar_carrito_Click(object sender, EventArgs e)
        {
            int selectedRowIndex = Dgv_Carrito.SelectedCells[0].RowIndex;
            if (selectedRowIndex != -1)
            {
                Videojuego deletedVideoGame = Cart_Video_Games_List[selectedRowIndex];
                Final_purchase -= deletedVideoGame.PRICE;
                Final_purchase_with_Iva -= Math.Round(deletedVideoGame.PRICE * 0.16, 2);
                Dgv_Carrito.Rows.RemoveAt(selectedRowIndex);
                Cart_Video_Games_List.RemoveAt(selectedRowIndex);
                Accountan--;
                llbl_compra_iva_carrito.Text = $"${Math.Round(Final_purchase * 0.16, 2)}";
                lbl_compra_total_carrito.Text = $"${Final_purchase}";
                lbl_contador_carrito.Text = Accountan.ToString();
            }
        }

        private void Btn_imprimir_carrito_Click(object sender, EventArgs e)
        {
            if (Cart_Video_Games_List.Count > 0)
            {
                Ticket_quantity++;
                try
                {
                    Files_Doc = new Management_of_arhcivos(Cart_Video_Games_List, Ticket_quantity, Final_purchase_with_Iva, Final_purchase);
                    Console.Beep();
                    MessageBox.Show("Ticke impreso exitosamente...");
                    Dgv_Carrito.Rows.Clear();
                    Cart_Video_Games_List.Clear();
                    llbl_compra_iva_carrito.Text = "--";
                    lbl_compra_total_carrito.Text = "--";
                    lbl_contador_carrito.Text = "0";
                    Accountan = 0;
                    Final_purchase_with_Iva = 0.00;
                    Final_purchase = 0.00;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al imprimir el ticket..." + ex.Message);
                }
            }
        }

        private void Add_Cart_Item(Videojuego Game)
        {
            if (!Cart_Video_Games_List.Contains(Game))
            {
                Index_Dgv = Dgv_Carrito.Rows.Add();
                Cart_Video_Games_List.Add(Game);
                Accountan++;
                lbl_contador_carrito.Text = Accountan.ToString();
                Final_purchase += Game.PRICE;
                Final_purchase_with_Iva = Math.Round((Final_purchase * 0.16), 2);
                Console.Beep();
                Videojuego Add_Console = Cart_Video_Games_List.Last();
                string Salida_Precio = string.Format("{0:C2}",Add_Console.PRICE);
                Dgv_Carrito.Rows[Index_Dgv].Cells[0].Value = Add_Console.TITLE;
                Dgv_Carrito.Rows[Index_Dgv].Cells[1].Value = Add_Console.GENERE;
                Dgv_Carrito.Rows[Index_Dgv].Cells[2].Value = Add_Console.CONSOLE;
                Dgv_Carrito.Rows[Index_Dgv].Cells[3].Value = Salida_Precio;
                string Salida_1 = string.Format("{0:C2}", Final_purchase_with_Iva);
                string Salida_2 = string.Format("{0:C2}", Final_purchase);
                llbl_compra_iva_carrito.Text = $"{Salida_1}";
                lbl_compra_total_carrito.Text = $"{Salida_2}";
            }
        }

        private void Filter_Games(bool Filter, Videojuego[] Video_Games)
        {
            if (Filter != false)
            {
                List_juegos.Items.Clear();
                foreach (Consola Consoles in Video_Games)
                {
                    if (Consoles is Videojuego Video_Game)
                    {
                        List_juegos.Items.Add(Video_Game.TITLE);
                    }
                }
                List_juegos.SelectedIndex = 0;
                return;
            }
        }

        private void Comprar_Unidad(Videojuego[] Video_Games, int Selected_Index)
        {
            if (Selected_Index != -1)
            {
                Videojuego Selected_Game = Video_Games[Selected_Index];
                double Buy = Selected_Game.PRICE;
                double Iva = Math.Round((Buy / 1.16) * .16, 2);
                Buy = Math.Round(Buy - Iva, 2);
                double Final_Purchase = Buy + Iva;
                string Salida_1 = string.Format("{0:C2}", Iva);
                string Salida_2 = string.Format("{0:C2}", Buy);
                string Salida_3 = string.Format("{0:C2}", Final_Purchase);
                Console.Beep();
                MessageBox.Show(
                    $"NintenShop            {DateTime.Now}\n\n"
                    + "Titulo: " + $"{Selected_Game.TITLE}" + "\n"
                    + "Genero: " + $"{Selected_Game.GENERE}" + "\n"
                    + "Año: " + $"{Selected_Game.YEAR}" + "\n"
                    + "Precio: " + $"{Selected_Game.PRICE}" + "\n\n"
                    + "Sub Iva: " + $"{Salida_1}" + "\n"
                    + "Total: " + $"{Salida_2}\n\n"
                    + "Sub Total Final:" + $"{Salida_3}\n"
                    + "Gracias por su compra.");
            }
        }

        private void Information_Game(Videojuego[] Video_Games, int Selected_Image)
        {
            Videojuego Selected_Game = Video_Games[Selected_Image];
            string SAL_Inf_Precio = string.Format("{0:C2}", Selected_Game.PRICE);
            lbl_titulo.Text = "Título: " + Selected_Game.TITLE + ".";
            lbl_genero.Text = "Género: " + Selected_Game.GENERE + ".";
            lbl_creadores.Text = "Creador(es): " + Selected_Game.CREATORS + ".";
            lbl_año.Text = "Año: " + Selected_Game.YEAR.ToString() + ".";
            lbl_consola.Text = "Consola: " + Selected_Game.CONSOLE + ".";
            lbl_precio.Text = $" {SAL_Inf_Precio}";
            lbl_bits.Text = "Bits: " + Selected_Game.BITS.ToString() + ".";
            int fila = Selected_Game.FOLDER;
            int columna = Selected_Game.NUM_IMAGE;
            if (fila >= 0 && columna >= 0 && fila < Image_Paths.GetLength(0) && columna < Image_Paths.GetLength(1))
            {
                string rutaImagen = Image_Paths[fila, columna];
                Pic_Caratulas.Image = Image.FromFile(rutaImagen);
            }
        }

        private void Datos_Tablas_MySql(List<Videojuego> consoleList, MySqlCommand commandConsole, MySqlDataReader readerConsole)
        {
            while (readerConsole.Read())
            {
                Videojuego videojuego = new Videojuego();
                videojuego.TITLE = readerConsole["Titulo"].ToString();
                videojuego.GENERE = readerConsole["Genero"].ToString();
                videojuego.CREATORS = readerConsole["Creadores"].ToString();
                videojuego.PRICE = Convert.ToDouble(readerConsole["Precio"]);
                videojuego.CONSOLE = readerConsole["Consola"].ToString();
                videojuego.YEAR = Convert.ToInt32(readerConsole["Año"]);
                videojuego.BITS = Convert.ToInt32(readerConsole["Bits"]);
                videojuego.FOLDER = Convert.ToInt32(readerConsole["Carpeta"]);
                videojuego.NUM_IMAGE = Convert.ToInt32(readerConsole["Imagen"]);
                consoleList.Add(videojuego);
            }
            readerConsole.Close();
        }

        private void Datos_MySql_Arreglos()
        {
            Connect_database Cadena = new Connect_database();
            using (MySqlConnection connection = new MySqlConnection(Cadena.CADENA_CONEXION))
            {
                try
                {
                    connection.Open();
                    Console.Beep();
                    if (connection.State != ConnectionState.Open)
                    {
                        return;
                    }
                    string[] consoleArr = { "nes", "gb", "snes", "n64", "gba" };
                    for (int i = 0; i < consoleArr.Length; i++)
                    {
                        string console = consoleArr[i];
                        MySqlCommand command = new MySqlCommand($"SELECT Titulo, Genero, Creadores, Precio, Consola, Año, Bits, Carpeta, Imagen FROM videojuegos_{console}", connection);
                        MySqlDataReader readerTable = command.ExecuteReader();
                        List<Videojuego> TableList = new List<Videojuego>();
                        Datos_Tablas_MySql(TableList, command, readerTable);
                        switch (console.ToLower())
                        {
                            case "nes":
                                videojuegos_nes = TableList.ToArray();
                                break;
                            case "gb":
                                videojuegos_gb = TableList.ToArray();
                                break;
                            case "snes":
                                videojuegos_snes = TableList.ToArray();
                                break;
                            case "n64":
                                videojuegos_n64 = TableList.ToArray();
                                break;
                            case "gba":
                                videojuegos_gba = TableList.ToArray();
                                break;
                            default : return;
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al obtener datos: " + ex.Message);
                    return;
                }
                finally
                {
                    connection.Close();
                }
            }
        }
    }
}