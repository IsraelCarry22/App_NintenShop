using System;
using MySql.Data.MySqlClient;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Media;
using System.IO;
using System.Data;
using System.Drawing;

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
            Information_Game(videojuegos_nes, 0);
            Filter_Games(Filter_Nes, videojuegos_nes);
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
            if (Selected_Game_Buy != -1)
            {
                Videojuego[] selectedList = GetSelectedGameList();
                Comprar_Unidad(selectedList, Selected_Game_Buy);
            }
        }

        private void Btn_añadir_carrito_Click(object sender, EventArgs e)
        {
            int Selected_Game_Buy = List_juegos.SelectedIndex;
            if (Selected_Game_Buy != -1)
            {
                Videojuego[] selectedList = GetSelectedGameList();
                Videojuego Selected_Game = selectedList[Selected_Game_Buy];
                Add_Cart_Item(Selected_Game);
            }
        }

        private void List_juegos_SelectedIndexChanged(object sender, EventArgs e)
        {
            int Selected_Index = List_juegos.SelectedIndex;
            if (Selected_Index != -1)
            {
                Videojuego[] selectedList = GetSelectedGameList();
                Information_Game(selectedList, Selected_Index);
            }
        }

        private Videojuego[] GetSelectedGameList()
        {
            if (Filter_Nes) return videojuegos_nes;
            if (Filter_Gb) return videojuegos_gb;
            if (Filter_Snes) return videojuegos_snes;
            if (Filter_N64) return videojuegos_n64;
            return videojuegos_gba; // Por defecto
        }

        private void Btn_eliminar_carrito_Click(object sender, EventArgs e)
        {
            if (Dgv_Carrito.SelectedCells.Count == 0) return;

            int selectedRowIndex = Dgv_Carrito.SelectedCells[0].RowIndex;
            if (selectedRowIndex == -1) return;

            Videojuego deletedVideoGame = Cart_Video_Games_List[selectedRowIndex];
            double price = deletedVideoGame.PRICE;

            RemoveFromCart(selectedRowIndex, price);
            UpdateUI();
        }

        private void RemoveFromCart(int selectedRowIndex, double price)
        {
            Final_purchase -= price;
            Final_purchase_with_Iva -= Math.Round(price * 0.16, 2);

            Dgv_Carrito.Rows.RemoveAt(selectedRowIndex);
            Cart_Video_Games_List.RemoveAt(selectedRowIndex);

            Accountan--;
        }

        private void UpdateUI()
        {
            string totalWithIva = string.Format("{0:C2}", Final_purchase + Math.Round(Final_purchase * 0.16, 2));

            lbl_compra_total_carrito.Text = totalWithIva;
            lbl_contador_carrito.Text = Accountan.ToString();
        }

        private void Btn_imprimir_carrito_Click(object sender, EventArgs e)
        {
            if (Cart_Video_Games_List.Count == 0)
            {
                MessageBox.Show("No hay productos en el carrito.");
                return;
            }

            Ticket_quantity++;

            try
            {
                PrintTicket();
                ResetCart();
                MessageBox.Show("Ticket impreso exitosamente...");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al imprimir el ticket: {ex.Message}");
            }
        }

        private void PrintTicket()
        {
            Files_Doc = new Management_of_arhcivos(Cart_Video_Games_List, Ticket_quantity, Final_purchase_with_Iva, Final_purchase);
            Console.Beep();
        }

        private void ResetCart()
        {
            Dgv_Carrito.Rows.Clear();
            Cart_Video_Games_List.Clear();
            lbl_compra_total_carrito.Text = "--";
            lbl_contador_carrito.Text = "0";
            Accountan = 0;
            Final_purchase_with_Iva = 0.00;
            Final_purchase = 0.00;
        }

        private void Add_Cart_Item(Videojuego Game)
        {
            if (Cart_Video_Games_List.Contains(Game)) return;

            Index_Dgv = Dgv_Carrito.Rows.Add();
            Cart_Video_Games_List.Add(Game);
            Accountan++;
            
            Final_purchase += Game.PRICE;
            Final_purchase_with_Iva = Math.Round(Final_purchase * 0.16, 2);

            Console.Beep();
            UpdateUI();
            AddItemToGrid(Game);
        }

        private void AddItemToGrid(Videojuego game)
        {
            string formattedPrice = string.Format("{0:C2}", game.PRICE);
            Dgv_Carrito.Rows[Index_Dgv].Cells[0].Value = game.TITLE;
            Dgv_Carrito.Rows[Index_Dgv].Cells[1].Value = formattedPrice;
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
            if (Selected_Index == -1) return;

            Videojuego Selected_Game = Video_Games[Selected_Index];
            double Buy = Selected_Game.PRICE;
            double Iva = Math.Round((Buy / 1.16) * 0.16, 2);
            Buy = Math.Round(Buy - Iva, 2);
            double Final_Purchase = Buy + Iva;

            string formattedIva = string.Format("{0:C2}", Iva);
            string formattedBuy = string.Format("{0:C2}", Buy);
            string formattedFinalPurchase = string.Format("{0:C2}", Final_Purchase);

            Console.Beep();
            ShowPurchaseDetails(Selected_Game, formattedIva, formattedBuy, formattedFinalPurchase);
        }

        private void ShowPurchaseDetails(Videojuego game, string iva, string buy, string finalPurchase)
        {
            MessageBox.Show(
                $"NintenShop            {DateTime.Now}\n\n"
                + $"Titulo: {game.TITLE}\n"
                + $"Genero: {game.GENERE}\n"
                + $"Año: {game.YEAR}\n"
                + $"Precio: {string.Format("{0:C2}", game.PRICE)}\n\n"
                + $"Sub Iva: {iva}\n"
                + $"Total: {buy}\n\n"
                + $"Sub Total Final: {finalPurchase}\n"
                + "Gracias por su compra.");
        }

        private void Information_Game(Videojuego[] Video_Games, int Selected_Image)
        {
            if (Selected_Image < 0 || Selected_Image >= Video_Games.Length) return;

            Videojuego Selected_Game = Video_Games[Selected_Image];
            string formattedPrice = string.Format("{0:C2}", Selected_Game.PRICE);

            lbl_titulo.Text = $"Título: {Selected_Game.TITLE}.";
            lbl_genero.Text = $"Género: {Selected_Game.GENERE}.";
            lbl_creadores.Text = $"Creador(es): {Selected_Game.CREATORS}.";
            lbl_año.Text = $"Año: {Selected_Game.YEAR}.";
            lbl_consola.Text = $"Consola: {Selected_Game.CONSOLE}.";
            lbl_precio.Text = formattedPrice;
            lbl_bits.Text = $"Bits: {Selected_Game.BITS}.";

            LoadGameImage(Selected_Game.FOLDER, Selected_Game.NUM_IMAGE);
        }

        private void LoadGameImage(int row, int column)
        {
            if (row >= 0 && column >= 0 && row < Image_Paths.GetLength(0) && column < Image_Paths.GetLength(1))
            {
                string imagePath = Image_Paths[row, column];
                Pic_Caratulas.Image = Image.FromFile(imagePath);
            }
        }

        private void Datos_Tablas_MySql(List<Videojuego> consoleList, MySqlCommand commandConsole, MySqlDataReader readerConsole)
        {
            while (readerConsole.Read())
            {
                Videojuego videojuego = new Videojuego
                {
                    TITLE = readerConsole["Titulo"].ToString(),
                    GENERE = readerConsole["Genero"].ToString(),
                    CREATORS = readerConsole["Creadores"].ToString(),
                    PRICE = Convert.ToDouble(readerConsole["Precio"]),
                    CONSOLE = readerConsole["Consola"].ToString(),
                    YEAR = Convert.ToInt32(readerConsole["Año"]),
                    BITS = Convert.ToInt32(readerConsole["Bits"]),
                    FOLDER = Convert.ToInt32(readerConsole["Carpeta"]),
                    NUM_IMAGE = Convert.ToInt32(readerConsole["Imagen"])
                };

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
                    if (connection.State != ConnectionState.Open) return;

                    string[] consoleArr = { "nes", "gb", "snes", "n64", "gba" };

                    foreach (string console in consoleArr)
                    {
                        MySqlCommand command = new MySqlCommand($"SELECT Titulo, Genero, Creadores, Precio, Consola, Año, Bits, Carpeta, Imagen FROM videojuegos_{console}", connection);
                        using (MySqlDataReader readerTable = command.ExecuteReader())
                        {
                            List<Videojuego> TableList = new List<Videojuego>();
                            Datos_Tablas_MySql(TableList, command, readerTable);

                            SetConsoleVideoGames(console.ToLower(), TableList);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al obtener datos: " + ex.Message);
                }
            }
        }

        private void SetConsoleVideoGames(string console, List<Videojuego> TableList)
        {
            switch (console)
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
            }
        }
    }
}