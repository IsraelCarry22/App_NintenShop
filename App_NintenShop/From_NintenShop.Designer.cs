using System.Drawing;

namespace App_NintenShop
{
    partial class From_NintenShop
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(From_NintenShop));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.inicioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.carritoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ayudaToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.List_juegos = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_titulo = new System.Windows.Forms.Label();
            this.lbl_creadores = new System.Windows.Forms.Label();
            this.lbl_genero = new System.Windows.Forms.Label();
            this.lbl_año = new System.Windows.Forms.Label();
            this.lbl_consola = new System.Windows.Forms.Label();
            this.btn_comprar = new System.Windows.Forms.Button();
            this.btn_añadir_carrito = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.btm_filter_gba = new System.Windows.Forms.PictureBox();
            this.btm_filter_n64 = new System.Windows.Forms.PictureBox();
            this.btm_filter_gb = new System.Windows.Forms.PictureBox();
            this.btm_filter_snes = new System.Windows.Forms.PictureBox();
            this.btm_filter_nes = new System.Windows.Forms.PictureBox();
            this.btn_carrito = new System.Windows.Forms.PictureBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.Pic_Caratulas = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbl_precio = new System.Windows.Forms.Label();
            this.lbl_bits = new System.Windows.Forms.Label();
            this.lbl_contador_carrito = new System.Windows.Forms.Label();
            this.Panel_Carrito = new System.Windows.Forms.Panel();
            this.Panel_Ayuda = new System.Windows.Forms.Panel();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.Btn_imprimir_carrito = new System.Windows.Forms.Button();
            this.btn_eliminar_carrito = new System.Windows.Forms.Button();
            this.lbl_compra_total_carrito = new System.Windows.Forms.Label();
            this.llbl_compra_iva_carrito = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.List_carrito = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btm_filter_gba)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btm_filter_n64)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btm_filter_gb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btm_filter_snes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btm_filter_nes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_carrito)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pic_Caratulas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.Panel_Carrito.SuspendLayout();
            this.Panel_Ayuda.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.inicioToolStripMenuItem,
            this.carritoToolStripMenuItem,
            this.ayudaToolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(826, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // inicioToolStripMenuItem
            // 
            this.inicioToolStripMenuItem.Name = "inicioToolStripMenuItem";
            this.inicioToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.inicioToolStripMenuItem.Text = "Inicio";
            this.inicioToolStripMenuItem.Click += new System.EventHandler(this.InicioToolStripMenuItem_Click);
            // 
            // carritoToolStripMenuItem
            // 
            this.carritoToolStripMenuItem.Name = "carritoToolStripMenuItem";
            this.carritoToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.carritoToolStripMenuItem.Text = "Carrito";
            this.carritoToolStripMenuItem.Click += new System.EventHandler(this.CarritoToolStripMenuItem_Click);
            // 
            // ayudaToolStripMenuItem1
            // 
            this.ayudaToolStripMenuItem1.Name = "ayudaToolStripMenuItem1";
            this.ayudaToolStripMenuItem1.Size = new System.Drawing.Size(53, 20);
            this.ayudaToolStripMenuItem1.Text = "Ayuda";
            this.ayudaToolStripMenuItem1.Click += new System.EventHandler(this.ayudaToolStripMenuItem1_Click);
            // 
            // List_juegos
            // 
            this.List_juegos.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.List_juegos.FormattingEnabled = true;
            this.List_juegos.ItemHeight = 20;
            this.List_juegos.Location = new System.Drawing.Point(8, 174);
            this.List_juegos.Name = "List_juegos";
            this.List_juegos.Size = new System.Drawing.Size(318, 344);
            this.List_juegos.TabIndex = 9;
            this.List_juegos.SelectedIndexChanged += new System.EventHandler(this.List_juegos_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 134);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(163, 21);
            this.label1.TabIndex = 10;
            this.label1.Text = "Selecciona un juego";
            // 
            // lbl_titulo
            // 
            this.lbl_titulo.AutoSize = true;
            this.lbl_titulo.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_titulo.Location = new System.Drawing.Point(357, 341);
            this.lbl_titulo.Name = "lbl_titulo";
            this.lbl_titulo.Size = new System.Drawing.Size(24, 21);
            this.lbl_titulo.TabIndex = 11;
            this.lbl_titulo.Text = "--";
            this.lbl_titulo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_creadores
            // 
            this.lbl_creadores.AutoSize = true;
            this.lbl_creadores.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_creadores.Location = new System.Drawing.Point(357, 362);
            this.lbl_creadores.Name = "lbl_creadores";
            this.lbl_creadores.Size = new System.Drawing.Size(24, 21);
            this.lbl_creadores.TabIndex = 13;
            this.lbl_creadores.Text = "--";
            this.lbl_creadores.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_genero
            // 
            this.lbl_genero.AutoSize = true;
            this.lbl_genero.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_genero.Location = new System.Drawing.Point(357, 383);
            this.lbl_genero.Name = "lbl_genero";
            this.lbl_genero.Size = new System.Drawing.Size(24, 21);
            this.lbl_genero.TabIndex = 15;
            this.lbl_genero.Text = "--";
            this.lbl_genero.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_año
            // 
            this.lbl_año.AutoSize = true;
            this.lbl_año.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_año.Location = new System.Drawing.Point(357, 404);
            this.lbl_año.Name = "lbl_año";
            this.lbl_año.Size = new System.Drawing.Size(24, 21);
            this.lbl_año.TabIndex = 14;
            this.lbl_año.Text = "--";
            this.lbl_año.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_consola
            // 
            this.lbl_consola.AutoSize = true;
            this.lbl_consola.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_consola.Location = new System.Drawing.Point(357, 425);
            this.lbl_consola.Name = "lbl_consola";
            this.lbl_consola.Size = new System.Drawing.Size(24, 21);
            this.lbl_consola.TabIndex = 16;
            this.lbl_consola.Text = "--";
            this.lbl_consola.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btn_comprar
            // 
            this.btn_comprar.BackColor = System.Drawing.Color.Lime;
            this.btn_comprar.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_comprar.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_comprar.Location = new System.Drawing.Point(637, 481);
            this.btn_comprar.Name = "btn_comprar";
            this.btn_comprar.Size = new System.Drawing.Size(177, 37);
            this.btn_comprar.TabIndex = 19;
            this.btn_comprar.Text = "Comprar";
            this.btn_comprar.UseVisualStyleBackColor = false;
            this.btn_comprar.Click += new System.EventHandler(this.Btn_comprar_Click);
            // 
            // btn_añadir_carrito
            // 
            this.btn_añadir_carrito.BackColor = System.Drawing.Color.Blue;
            this.btn_añadir_carrito.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_añadir_carrito.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_añadir_carrito.Location = new System.Drawing.Point(359, 481);
            this.btn_añadir_carrito.Name = "btn_añadir_carrito";
            this.btn_añadir_carrito.Size = new System.Drawing.Size(199, 37);
            this.btn_añadir_carrito.TabIndex = 20;
            this.btn_añadir_carrito.Text = "Añadir al carrito";
            this.btn_añadir_carrito.UseVisualStyleBackColor = false;
            this.btn_añadir_carrito.Click += new System.EventHandler(this.Btn_añadir_carrito_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(272, 21);
            this.label2.TabIndex = 22;
            this.label2.Text = "Selecciona una consola para filtrar";
            // 
            // btm_filter_gba
            // 
            this.btm_filter_gba.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btm_filter_gba.Image = global::App_NintenShop.Properties.Resources.Gba;
            this.btm_filter_gba.Location = new System.Drawing.Point(559, 27);
            this.btm_filter_gba.Name = "btm_filter_gba";
            this.btm_filter_gba.Size = new System.Drawing.Size(60, 50);
            this.btm_filter_gba.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btm_filter_gba.TabIndex = 8;
            this.btm_filter_gba.TabStop = false;
            this.toolTip1.SetToolTip(this.btm_filter_gba, "Filtro Gba");
            this.btm_filter_gba.Click += new System.EventHandler(this.Btm_filter_gba_Click);
            // 
            // btm_filter_n64
            // 
            this.btm_filter_n64.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btm_filter_n64.Image = global::App_NintenShop.Properties.Resources.N64;
            this.btm_filter_n64.Location = new System.Drawing.Point(493, 27);
            this.btm_filter_n64.Name = "btm_filter_n64";
            this.btm_filter_n64.Size = new System.Drawing.Size(60, 50);
            this.btm_filter_n64.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btm_filter_n64.TabIndex = 7;
            this.btm_filter_n64.TabStop = false;
            this.toolTip1.SetToolTip(this.btm_filter_n64, "Filtro N64");
            this.btm_filter_n64.Click += new System.EventHandler(this.Btm_filter_n64_Click);
            // 
            // btm_filter_gb
            // 
            this.btm_filter_gb.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btm_filter_gb.Image = global::App_NintenShop.Properties.Resources.Gb;
            this.btm_filter_gb.Location = new System.Drawing.Point(361, 27);
            this.btm_filter_gb.Name = "btm_filter_gb";
            this.btm_filter_gb.Size = new System.Drawing.Size(60, 50);
            this.btm_filter_gb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btm_filter_gb.TabIndex = 6;
            this.btm_filter_gb.TabStop = false;
            this.toolTip1.SetToolTip(this.btm_filter_gb, "Filtro Gb");
            this.btm_filter_gb.Click += new System.EventHandler(this.Btm_filter_gb_Click);
            // 
            // btm_filter_snes
            // 
            this.btm_filter_snes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btm_filter_snes.Image = global::App_NintenShop.Properties.Resources.Snes;
            this.btm_filter_snes.Location = new System.Drawing.Point(427, 27);
            this.btm_filter_snes.Name = "btm_filter_snes";
            this.btm_filter_snes.Size = new System.Drawing.Size(60, 50);
            this.btm_filter_snes.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btm_filter_snes.TabIndex = 5;
            this.btm_filter_snes.TabStop = false;
            this.toolTip1.SetToolTip(this.btm_filter_snes, "Filtro Snes");
            this.btm_filter_snes.Click += new System.EventHandler(this.Btm_filter_snes_Click);
            // 
            // btm_filter_nes
            // 
            this.btm_filter_nes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btm_filter_nes.Image = global::App_NintenShop.Properties.Resources.Nes;
            this.btm_filter_nes.Location = new System.Drawing.Point(295, 27);
            this.btm_filter_nes.Name = "btm_filter_nes";
            this.btm_filter_nes.Size = new System.Drawing.Size(60, 50);
            this.btm_filter_nes.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btm_filter_nes.TabIndex = 4;
            this.btm_filter_nes.TabStop = false;
            this.toolTip1.SetToolTip(this.btm_filter_nes, "Filtro Nes");
            this.btm_filter_nes.Click += new System.EventHandler(this.Btm_filter_nes_Click);
            // 
            // btn_carrito
            // 
            this.btn_carrito.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_carrito.Image = global::App_NintenShop.Properties.Resources.carrito;
            this.btn_carrito.Location = new System.Drawing.Point(697, 27);
            this.btn_carrito.Name = "btn_carrito";
            this.btn_carrito.Size = new System.Drawing.Size(46, 36);
            this.btn_carrito.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btn_carrito.TabIndex = 2;
            this.btn_carrito.TabStop = false;
            this.toolTip1.SetToolTip(this.btn_carrito, "Ver carrito");
            this.btn_carrito.Click += new System.EventHandler(this.Btn_carrito_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Pic_Caratulas
            // 
            this.Pic_Caratulas.BackColor = System.Drawing.Color.Gray;
            this.Pic_Caratulas.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Pic_Caratulas.Location = new System.Drawing.Point(361, 101);
            this.Pic_Caratulas.Name = "Pic_Caratulas";
            this.Pic_Caratulas.Size = new System.Drawing.Size(346, 237);
            this.Pic_Caratulas.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Pic_Caratulas.TabIndex = 12;
            this.Pic_Caratulas.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::App_NintenShop.Properties.Resources.logo2;
            this.pictureBox2.Location = new System.Drawing.Point(134, 27);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(127, 50);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::App_NintenShop.Properties.Resources.logo1;
            this.pictureBox1.Location = new System.Drawing.Point(8, 27);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(127, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // lbl_precio
            // 
            this.lbl_precio.AutoSize = true;
            this.lbl_precio.BackColor = System.Drawing.Color.White;
            this.lbl_precio.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_precio.ForeColor = System.Drawing.Color.Green;
            this.lbl_precio.Location = new System.Drawing.Point(713, 310);
            this.lbl_precio.Name = "lbl_precio";
            this.lbl_precio.Size = new System.Drawing.Size(30, 28);
            this.lbl_precio.TabIndex = 24;
            this.lbl_precio.Text = "--";
            this.lbl_precio.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_bits
            // 
            this.lbl_bits.AutoSize = true;
            this.lbl_bits.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_bits.Location = new System.Drawing.Point(357, 448);
            this.lbl_bits.Name = "lbl_bits";
            this.lbl_bits.Size = new System.Drawing.Size(24, 21);
            this.lbl_bits.TabIndex = 25;
            this.lbl_bits.Text = "--";
            this.lbl_bits.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_contador_carrito
            // 
            this.lbl_contador_carrito.AutoSize = true;
            this.lbl_contador_carrito.Font = new System.Drawing.Font("Microsoft YaHei UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_contador_carrito.Location = new System.Drawing.Point(749, 27);
            this.lbl_contador_carrito.Name = "lbl_contador_carrito";
            this.lbl_contador_carrito.Size = new System.Drawing.Size(24, 23);
            this.lbl_contador_carrito.TabIndex = 28;
            this.lbl_contador_carrito.Text = "--";
            this.lbl_contador_carrito.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Panel_Carrito
            // 
            this.Panel_Carrito.Controls.Add(this.Panel_Ayuda);
            this.Panel_Carrito.Controls.Add(this.Btn_imprimir_carrito);
            this.Panel_Carrito.Controls.Add(this.btn_eliminar_carrito);
            this.Panel_Carrito.Controls.Add(this.lbl_compra_total_carrito);
            this.Panel_Carrito.Controls.Add(this.llbl_compra_iva_carrito);
            this.Panel_Carrito.Controls.Add(this.label6);
            this.Panel_Carrito.Controls.Add(this.label5);
            this.Panel_Carrito.Controls.Add(this.label4);
            this.Panel_Carrito.Controls.Add(this.List_carrito);
            this.Panel_Carrito.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Panel_Carrito.Location = new System.Drawing.Point(0, 24);
            this.Panel_Carrito.Name = "Panel_Carrito";
            this.Panel_Carrito.Size = new System.Drawing.Size(826, 502);
            this.Panel_Carrito.TabIndex = 29;
            this.Panel_Carrito.Visible = false;
            // 
            // Panel_Ayuda
            // 
            this.Panel_Ayuda.Controls.Add(this.label7);
            this.Panel_Ayuda.Controls.Add(this.label3);
            this.Panel_Ayuda.Controls.Add(this.pictureBox4);
            this.Panel_Ayuda.Controls.Add(this.pictureBox3);
            this.Panel_Ayuda.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.Panel_Ayuda.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Panel_Ayuda.Location = new System.Drawing.Point(0, 0);
            this.Panel_Ayuda.Name = "Panel_Ayuda";
            this.Panel_Ayuda.Size = new System.Drawing.Size(826, 502);
            this.Panel_Ayuda.TabIndex = 8;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.pictureBox4.Image = global::App_NintenShop.Properties.Resources.logo2;
            this.pictureBox4.Location = new System.Drawing.Point(403, 30);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(216, 68);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 1;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.pictureBox3.Image = global::App_NintenShop.Properties.Resources.logo1;
            this.pictureBox3.Location = new System.Drawing.Point(187, 30);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(216, 68);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 0;
            this.pictureBox3.TabStop = false;
            // 
            // Btn_imprimir_carrito
            // 
            this.Btn_imprimir_carrito.BackColor = System.Drawing.Color.Blue;
            this.Btn_imprimir_carrito.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_imprimir_carrito.ForeColor = System.Drawing.Color.Transparent;
            this.Btn_imprimir_carrito.Location = new System.Drawing.Point(592, 431);
            this.Btn_imprimir_carrito.Name = "Btn_imprimir_carrito";
            this.Btn_imprimir_carrito.Size = new System.Drawing.Size(181, 44);
            this.Btn_imprimir_carrito.TabIndex = 7;
            this.Btn_imprimir_carrito.Text = "Imprimir recibo";
            this.Btn_imprimir_carrito.UseVisualStyleBackColor = false;
            this.Btn_imprimir_carrito.Click += new System.EventHandler(this.Btn_imprimir_carrito_Click);
            // 
            // btn_eliminar_carrito
            // 
            this.btn_eliminar_carrito.BackColor = System.Drawing.Color.Red;
            this.btn_eliminar_carrito.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_eliminar_carrito.ForeColor = System.Drawing.Color.Transparent;
            this.btn_eliminar_carrito.Location = new System.Drawing.Point(637, 380);
            this.btn_eliminar_carrito.Name = "btn_eliminar_carrito";
            this.btn_eliminar_carrito.Size = new System.Drawing.Size(136, 32);
            this.btn_eliminar_carrito.TabIndex = 6;
            this.btn_eliminar_carrito.Text = "Eliminar";
            this.btn_eliminar_carrito.UseVisualStyleBackColor = false;
            this.btn_eliminar_carrito.Click += new System.EventHandler(this.Btn_eliminar_carrito_Click);
            // 
            // lbl_compra_total_carrito
            // 
            this.lbl_compra_total_carrito.AutoSize = true;
            this.lbl_compra_total_carrito.Font = new System.Drawing.Font("Microsoft YaHei UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_compra_total_carrito.ForeColor = System.Drawing.Color.Green;
            this.lbl_compra_total_carrito.Location = new System.Drawing.Point(177, 444);
            this.lbl_compra_total_carrito.Name = "lbl_compra_total_carrito";
            this.lbl_compra_total_carrito.Size = new System.Drawing.Size(34, 31);
            this.lbl_compra_total_carrito.TabIndex = 5;
            this.lbl_compra_total_carrito.Text = "--";
            // 
            // llbl_compra_iva_carrito
            // 
            this.llbl_compra_iva_carrito.AutoSize = true;
            this.llbl_compra_iva_carrito.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.llbl_compra_iva_carrito.Location = new System.Drawing.Point(178, 401);
            this.llbl_compra_iva_carrito.Name = "llbl_compra_iva_carrito";
            this.llbl_compra_iva_carrito.Size = new System.Drawing.Size(28, 25);
            this.llbl_compra_iva_carrito.TabIndex = 4;
            this.llbl_compra_iva_carrito.Text = "--";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(29, 401);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(125, 25);
            this.label6.TabIndex = 3;
            this.label6.Text = "Total de Iva:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(28, 444);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 31);
            this.label5.TabIndex = 2;
            this.label5.Text = "Total:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(29, 13);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(177, 41);
            this.label4.TabIndex = 1;
            this.label4.Text = "Tu Carrito:";
            // 
            // List_carrito
            // 
            this.List_carrito.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.List_carrito.FormattingEnabled = true;
            this.List_carrito.HorizontalScrollbar = true;
            this.List_carrito.ItemHeight = 25;
            this.List_carrito.Location = new System.Drawing.Point(32, 71);
            this.List_carrito.Name = "List_carrito";
            this.List_carrito.ScrollAlwaysVisible = true;
            this.List_carrito.Size = new System.Drawing.Size(741, 279);
            this.List_carrito.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(38, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(735, 192);
            this.label3.TabIndex = 2;
            this.label3.Text = resources.GetString("label3.Text");
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.label7.Font = new System.Drawing.Font("MV Boli", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(40, 455);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(531, 20);
            this.label7.TabIndex = 3;
            this.label7.Text = "Gracias por darle un uso correcto al software: Attm. J. Israel C. Moncada.";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // From_NintenShop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(826, 526);
            this.Controls.Add(this.Panel_Carrito);
            this.Controls.Add(this.lbl_contador_carrito);
            this.Controls.Add(this.lbl_bits);
            this.Controls.Add(this.lbl_precio);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_añadir_carrito);
            this.Controls.Add(this.btn_comprar);
            this.Controls.Add(this.lbl_consola);
            this.Controls.Add(this.lbl_genero);
            this.Controls.Add(this.lbl_año);
            this.Controls.Add(this.lbl_creadores);
            this.Controls.Add(this.Pic_Caratulas);
            this.Controls.Add(this.lbl_titulo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.List_juegos);
            this.Controls.Add(this.btm_filter_gba);
            this.Controls.Add(this.btm_filter_n64);
            this.Controls.Add(this.btm_filter_gb);
            this.Controls.Add(this.btm_filter_snes);
            this.Controls.Add(this.btm_filter_nes);
            this.Controls.Add(this.btn_carrito);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "From_NintenShop";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btm_filter_gba)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btm_filter_n64)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btm_filter_gb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btm_filter_snes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btm_filter_nes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_carrito)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pic_Caratulas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.Panel_Carrito.ResumeLayout(false);
            this.Panel_Carrito.PerformLayout();
            this.Panel_Ayuda.ResumeLayout(false);
            this.Panel_Ayuda.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox btn_carrito;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem inicioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem carritoToolStripMenuItem;
        private System.Windows.Forms.PictureBox btm_filter_nes;
        private System.Windows.Forms.PictureBox btm_filter_snes;
        private System.Windows.Forms.PictureBox btm_filter_gb;
        private System.Windows.Forms.PictureBox btm_filter_n64;
        private System.Windows.Forms.PictureBox btm_filter_gba;
        private System.Windows.Forms.ToolStripMenuItem ayudaToolStripMenuItem1;
        private System.Windows.Forms.ListBox List_juegos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_titulo;
        private System.Windows.Forms.PictureBox Pic_Caratulas;
        private System.Windows.Forms.Label lbl_creadores;
        private System.Windows.Forms.Label lbl_genero;
        private System.Windows.Forms.Label lbl_año;
        private System.Windows.Forms.Label lbl_consola;
        private System.Windows.Forms.Button btn_comprar;
        private System.Windows.Forms.Button btn_añadir_carrito;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Label lbl_precio;
        private System.Windows.Forms.Label lbl_bits;
        private System.Windows.Forms.Label lbl_contador_carrito;
        private System.Windows.Forms.Panel Panel_Carrito;
        private System.Windows.Forms.ListBox List_carrito;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbl_compra_total_carrito;
        private System.Windows.Forms.Label llbl_compra_iva_carrito;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button Btn_imprimir_carrito;
        private System.Windows.Forms.Button btn_eliminar_carrito;
        private System.Windows.Forms.Panel Panel_Ayuda;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label3;
    }
}

