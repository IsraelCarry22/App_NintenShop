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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.inicioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.carritoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.List_juegos = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_titulo = new System.Windows.Forms.Label();
            this.lbl_creadores = new System.Windows.Forms.Label();
            this.lbl_genero = new System.Windows.Forms.Label();
            this.lbl_año = new System.Windows.Forms.Label();
            this.lbl_consola = new System.Windows.Forms.Label();
            this.btn_comprar = new System.Windows.Forms.Button();
            this.btn_añadir_carrito = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.btm_filter_gba = new System.Windows.Forms.PictureBox();
            this.btm_filter_n64 = new System.Windows.Forms.PictureBox();
            this.btm_filter_gb = new System.Windows.Forms.PictureBox();
            this.btm_filter_snes = new System.Windows.Forms.PictureBox();
            this.btm_filter_nes = new System.Windows.Forms.PictureBox();
            this.btn_carrito = new System.Windows.Forms.PictureBox();
            this.Pic_Caratulas = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbl_precio = new System.Windows.Forms.Label();
            this.lbl_bits = new System.Windows.Forms.Label();
            this.lbl_contador_carrito = new System.Windows.Forms.Label();
            this.Panel_Carrito = new System.Windows.Forms.Panel();
            this.Dgv_Carrito = new System.Windows.Forms.DataGridView();
            this.Btn_imprimir_carrito = new System.Windows.Forms.Button();
            this.btn_eliminar_carrito = new System.Windows.Forms.Button();
            this.lbl_compra_total_carrito = new System.Windows.Forms.Label();
            this.llbl_compra_iva_carrito = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Titulo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Genero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Consola = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btm_filter_gba)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btm_filter_n64)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btm_filter_gb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btm_filter_snes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btm_filter_nes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_carrito)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pic_Caratulas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.Panel_Carrito.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Carrito)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.inicioToolStripMenuItem,
            this.carritoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(906, 24);
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
            // List_juegos
            // 
            this.List_juegos.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.List_juegos.FormattingEnabled = true;
            this.List_juegos.HorizontalScrollbar = true;
            this.List_juegos.ItemHeight = 25;
            this.List_juegos.Location = new System.Drawing.Point(8, 149);
            this.List_juegos.Name = "List_juegos";
            this.List_juegos.ScrollAlwaysVisible = true;
            this.List_juegos.Size = new System.Drawing.Size(347, 429);
            this.List_juegos.TabIndex = 9;
            this.List_juegos.SelectedIndexChanged += new System.EventHandler(this.List_juegos_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 115);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(163, 21);
            this.label1.TabIndex = 10;
            this.label1.Text = "Selecciona un juego";
            // 
            // lbl_titulo
            // 
            this.lbl_titulo.AutoSize = true;
            this.lbl_titulo.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_titulo.Location = new System.Drawing.Point(451, 408);
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
            this.lbl_creadores.Location = new System.Drawing.Point(451, 429);
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
            this.lbl_genero.Location = new System.Drawing.Point(451, 450);
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
            this.lbl_año.Location = new System.Drawing.Point(451, 471);
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
            this.lbl_consola.Location = new System.Drawing.Point(451, 492);
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
            this.btn_comprar.Location = new System.Drawing.Point(623, 540);
            this.btn_comprar.Name = "btn_comprar";
            this.btn_comprar.Size = new System.Drawing.Size(271, 37);
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
            this.btn_añadir_carrito.Location = new System.Drawing.Point(371, 541);
            this.btn_añadir_carrito.Name = "btn_añadir_carrito";
            this.btn_añadir_carrito.Size = new System.Drawing.Size(246, 37);
            this.btn_añadir_carrito.TabIndex = 20;
            this.btn_añadir_carrito.Text = "Añadir al carrito";
            this.btn_añadir_carrito.UseVisualStyleBackColor = false;
            this.btn_añadir_carrito.Click += new System.EventHandler(this.Btn_añadir_carrito_Click);
            // 
            // btm_filter_gba
            // 
            this.btm_filter_gba.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btm_filter_gba.Image = ((System.Drawing.Image)(resources.GetObject("btm_filter_gba.Image")));
            this.btm_filter_gba.Location = new System.Drawing.Point(707, 27);
            this.btm_filter_gba.Name = "btm_filter_gba";
            this.btm_filter_gba.Size = new System.Drawing.Size(78, 63);
            this.btm_filter_gba.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btm_filter_gba.TabIndex = 8;
            this.btm_filter_gba.TabStop = false;
            this.toolTip1.SetToolTip(this.btm_filter_gba, "Filtro Gba");
            this.btm_filter_gba.Click += new System.EventHandler(this.Btm_filter_gba_Click);
            // 
            // btm_filter_n64
            // 
            this.btm_filter_n64.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btm_filter_n64.Image = ((System.Drawing.Image)(resources.GetObject("btm_filter_n64.Image")));
            this.btm_filter_n64.Location = new System.Drawing.Point(623, 27);
            this.btm_filter_n64.Name = "btm_filter_n64";
            this.btm_filter_n64.Size = new System.Drawing.Size(78, 63);
            this.btm_filter_n64.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btm_filter_n64.TabIndex = 7;
            this.btm_filter_n64.TabStop = false;
            this.toolTip1.SetToolTip(this.btm_filter_n64, "Filtro N64");
            this.btm_filter_n64.Click += new System.EventHandler(this.Btm_filter_n64_Click);
            // 
            // btm_filter_gb
            // 
            this.btm_filter_gb.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btm_filter_gb.Image = ((System.Drawing.Image)(resources.GetObject("btm_filter_gb.Image")));
            this.btm_filter_gb.Location = new System.Drawing.Point(455, 27);
            this.btm_filter_gb.Name = "btm_filter_gb";
            this.btm_filter_gb.Size = new System.Drawing.Size(78, 63);
            this.btm_filter_gb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btm_filter_gb.TabIndex = 6;
            this.btm_filter_gb.TabStop = false;
            this.toolTip1.SetToolTip(this.btm_filter_gb, "Filtro Gb");
            this.btm_filter_gb.Click += new System.EventHandler(this.Btm_filter_gb_Click);
            // 
            // btm_filter_snes
            // 
            this.btm_filter_snes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btm_filter_snes.Image = ((System.Drawing.Image)(resources.GetObject("btm_filter_snes.Image")));
            this.btm_filter_snes.Location = new System.Drawing.Point(539, 27);
            this.btm_filter_snes.Name = "btm_filter_snes";
            this.btm_filter_snes.Size = new System.Drawing.Size(78, 63);
            this.btm_filter_snes.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btm_filter_snes.TabIndex = 5;
            this.btm_filter_snes.TabStop = false;
            this.toolTip1.SetToolTip(this.btm_filter_snes, "Filtro Snes");
            this.btm_filter_snes.Click += new System.EventHandler(this.Btm_filter_snes_Click);
            // 
            // btm_filter_nes
            // 
            this.btm_filter_nes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btm_filter_nes.Image = ((System.Drawing.Image)(resources.GetObject("btm_filter_nes.Image")));
            this.btm_filter_nes.Location = new System.Drawing.Point(371, 27);
            this.btm_filter_nes.Name = "btm_filter_nes";
            this.btm_filter_nes.Size = new System.Drawing.Size(78, 63);
            this.btm_filter_nes.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btm_filter_nes.TabIndex = 4;
            this.btm_filter_nes.TabStop = false;
            this.toolTip1.SetToolTip(this.btm_filter_nes, "Filtro Nes");
            this.btm_filter_nes.Click += new System.EventHandler(this.Btm_filter_nes_Click);
            // 
            // btn_carrito
            // 
            this.btn_carrito.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_carrito.Image = ((System.Drawing.Image)(resources.GetObject("btn_carrito.Image")));
            this.btn_carrito.Location = new System.Drawing.Point(791, 27);
            this.btn_carrito.Name = "btn_carrito";
            this.btn_carrito.Size = new System.Drawing.Size(55, 47);
            this.btn_carrito.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btn_carrito.TabIndex = 2;
            this.btn_carrito.TabStop = false;
            this.toolTip1.SetToolTip(this.btn_carrito, "Ver carrito");
            this.btn_carrito.Click += new System.EventHandler(this.Btn_carrito_Click);
            // 
            // Pic_Caratulas
            // 
            this.Pic_Caratulas.BackColor = System.Drawing.Color.Gray;
            this.Pic_Caratulas.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Pic_Caratulas.Location = new System.Drawing.Point(455, 96);
            this.Pic_Caratulas.Name = "Pic_Caratulas";
            this.Pic_Caratulas.Size = new System.Drawing.Size(391, 309);
            this.Pic_Caratulas.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Pic_Caratulas.TabIndex = 12;
            this.Pic_Caratulas.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(181, 27);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(177, 63);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(7, 27);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(177, 63);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // lbl_precio
            // 
            this.lbl_precio.AutoSize = true;
            this.lbl_precio.BackColor = System.Drawing.Color.White;
            this.lbl_precio.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_precio.ForeColor = System.Drawing.Color.Lime;
            this.lbl_precio.Location = new System.Drawing.Point(649, 508);
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
            this.lbl_bits.Location = new System.Drawing.Point(451, 515);
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
            this.lbl_contador_carrito.Location = new System.Drawing.Point(852, 51);
            this.lbl_contador_carrito.Name = "lbl_contador_carrito";
            this.lbl_contador_carrito.Size = new System.Drawing.Size(24, 23);
            this.lbl_contador_carrito.TabIndex = 28;
            this.lbl_contador_carrito.Text = "--";
            this.lbl_contador_carrito.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Panel_Carrito
            // 
            this.Panel_Carrito.Controls.Add(this.Dgv_Carrito);
            this.Panel_Carrito.Controls.Add(this.Btn_imprimir_carrito);
            this.Panel_Carrito.Controls.Add(this.btn_eliminar_carrito);
            this.Panel_Carrito.Controls.Add(this.lbl_compra_total_carrito);
            this.Panel_Carrito.Controls.Add(this.llbl_compra_iva_carrito);
            this.Panel_Carrito.Controls.Add(this.label6);
            this.Panel_Carrito.Controls.Add(this.label5);
            this.Panel_Carrito.Controls.Add(this.label4);
            this.Panel_Carrito.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Panel_Carrito.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Panel_Carrito.Location = new System.Drawing.Point(0, 24);
            this.Panel_Carrito.Name = "Panel_Carrito";
            this.Panel_Carrito.Size = new System.Drawing.Size(906, 564);
            this.Panel_Carrito.TabIndex = 29;
            this.Panel_Carrito.Visible = false;
            // 
            // Dgv_Carrito
            // 
            this.Dgv_Carrito.AllowUserToAddRows = false;
            this.Dgv_Carrito.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Dgv_Carrito.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.Dgv_Carrito.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Dgv_Carrito.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.Dgv_Carrito.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_Carrito.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Titulo,
            this.Genero,
            this.Consola,
            this.Precio});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.Dgv_Carrito.DefaultCellStyle = dataGridViewCellStyle3;
            this.Dgv_Carrito.Location = new System.Drawing.Point(36, 72);
            this.Dgv_Carrito.Name = "Dgv_Carrito";
            this.Dgv_Carrito.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Dgv_Carrito.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Dgv_Carrito.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.Dgv_Carrito.Size = new System.Drawing.Size(831, 354);
            this.Dgv_Carrito.TabIndex = 9;
            // 
            // Btn_imprimir_carrito
            // 
            this.Btn_imprimir_carrito.BackColor = System.Drawing.Color.Blue;
            this.Btn_imprimir_carrito.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_imprimir_carrito.ForeColor = System.Drawing.Color.Transparent;
            this.Btn_imprimir_carrito.Location = new System.Drawing.Point(684, 517);
            this.Btn_imprimir_carrito.Name = "Btn_imprimir_carrito";
            this.Btn_imprimir_carrito.Size = new System.Drawing.Size(210, 37);
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
            this.btn_eliminar_carrito.Location = new System.Drawing.Point(468, 517);
            this.btn_eliminar_carrito.Name = "btn_eliminar_carrito";
            this.btn_eliminar_carrito.Size = new System.Drawing.Size(210, 37);
            this.btn_eliminar_carrito.TabIndex = 6;
            this.btn_eliminar_carrito.Text = "Eliminar";
            this.btn_eliminar_carrito.UseVisualStyleBackColor = false;
            this.btn_eliminar_carrito.Click += new System.EventHandler(this.Btn_eliminar_carrito_Click);
            // 
            // lbl_compra_total_carrito
            // 
            this.lbl_compra_total_carrito.AutoSize = true;
            this.lbl_compra_total_carrito.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_compra_total_carrito.ForeColor = System.Drawing.Color.Green;
            this.lbl_compra_total_carrito.Location = new System.Drawing.Point(133, 513);
            this.lbl_compra_total_carrito.Name = "lbl_compra_total_carrito";
            this.lbl_compra_total_carrito.Size = new System.Drawing.Size(37, 37);
            this.lbl_compra_total_carrito.TabIndex = 5;
            this.lbl_compra_total_carrito.Text = "--";
            // 
            // llbl_compra_iva_carrito
            // 
            this.llbl_compra_iva_carrito.AutoSize = true;
            this.llbl_compra_iva_carrito.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.llbl_compra_iva_carrito.Location = new System.Drawing.Point(246, 456);
            this.llbl_compra_iva_carrito.Name = "llbl_compra_iva_carrito";
            this.llbl_compra_iva_carrito.Size = new System.Drawing.Size(37, 37);
            this.llbl_compra_iva_carrito.TabIndex = 4;
            this.llbl_compra_iva_carrito.Text = "--";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(30, 458);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(210, 31);
            this.label6.TabIndex = 3;
            this.label6.Text = "Sub total de Iva:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(29, 513);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 37);
            this.label5.TabIndex = 2;
            this.label5.Text = "Total:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(29, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(177, 41);
            this.label4.TabIndex = 1;
            this.label4.Text = "Tu Carrito:";
            // 
            // Titulo
            // 
            this.Titulo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Titulo.HeaderText = "Titulo del juego";
            this.Titulo.Name = "Titulo";
            this.Titulo.ReadOnly = true;
            this.Titulo.Width = 141;
            // 
            // Genero
            // 
            this.Genero.HeaderText = "Genero del juego";
            this.Genero.Name = "Genero";
            this.Genero.ReadOnly = true;
            // 
            // Consola
            // 
            this.Consola.HeaderText = "Consola del juego";
            this.Consola.Name = "Consola";
            this.Consola.ReadOnly = true;
            // 
            // Precio
            // 
            this.Precio.HeaderText = "Precio del juego";
            this.Precio.Name = "Precio";
            this.Precio.ReadOnly = true;
            // 
            // From_NintenShop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(906, 588);
            this.Controls.Add(this.Panel_Carrito);
            this.Controls.Add(this.lbl_contador_carrito);
            this.Controls.Add(this.lbl_bits);
            this.Controls.Add(this.lbl_precio);
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
            this.Load += new System.EventHandler(this.From_NintenShop_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btm_filter_gba)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btm_filter_n64)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btm_filter_gb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btm_filter_snes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btm_filter_nes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_carrito)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pic_Caratulas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.Panel_Carrito.ResumeLayout(false);
            this.Panel_Carrito.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Carrito)).EndInit();
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
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label lbl_precio;
        private System.Windows.Forms.Label lbl_bits;
        private System.Windows.Forms.Label lbl_contador_carrito;
        private System.Windows.Forms.Panel Panel_Carrito;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbl_compra_total_carrito;
        private System.Windows.Forms.Label llbl_compra_iva_carrito;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button Btn_imprimir_carrito;
        private System.Windows.Forms.Button btn_eliminar_carrito;
        private System.Windows.Forms.DataGridView Dgv_Carrito;
        private System.Windows.Forms.DataGridViewTextBoxColumn Titulo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Genero;
        private System.Windows.Forms.DataGridViewTextBoxColumn Consola;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio;
    }
}

