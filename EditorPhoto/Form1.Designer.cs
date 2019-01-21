namespace EditorPhoto
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.arquivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.abrirImagemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salvarImagemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.button6 = new System.Windows.Forms.Button();
            this.groupBox12 = new System.Windows.Forms.GroupBox();
            this.quantoBrilho = new System.Windows.Forms.Label();
            this.aplicaBrilho = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.brilho = new System.Windows.Forms.TrackBar();
            this.groupBox11 = new System.Windows.Forms.GroupBox();
            this.quantoContraste = new System.Windows.Forms.Label();
            this.aplicaContraste = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.contraste = new System.Windows.Forms.TrackBar();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.filtro_sobel_hy = new System.Windows.Forms.Button();
            this.filtro_sobel_hx = new System.Windows.Forms.Button();
            this.filtro_prewitt_hy_hx = new System.Windows.Forms.Button();
            this.filtro_prewitt_hx = new System.Windows.Forms.Button();
            this.filtro_passas_altas_generico = new System.Windows.Forms.Button();
            this.filtro_laplaciano = new System.Windows.Forms.Button();
            this.filtro_gaussiano = new System.Windows.Forms.Button();
            this.aplicar_filtro = new System.Windows.Forms.Button();
            this.i = new System.Windows.Forms.NumericUpDown();
            this.h = new System.Windows.Forms.NumericUpDown();
            this.f = new System.Windows.Forms.NumericUpDown();
            this.mid = new System.Windows.Forms.NumericUpDown();
            this.c = new System.Windows.Forms.NumericUpDown();
            this.b = new System.Windows.Forms.NumericUpDown();
            this.g = new System.Windows.Forms.NumericUpDown();
            this.d = new System.Windows.Forms.NumericUpDown();
            this.a = new System.Windows.Forms.NumericUpDown();
            this.ZoomIn = new System.Windows.Forms.Button();
            this.ZoomOut = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.ZoomSx = new System.Windows.Forms.NumericUpDown();
            this.ZoomSy = new System.Windows.Forms.NumericUpDown();
            this.rotacao_horaria = new System.Windows.Forms.Button();
            this.Rotacao_Anti_Horaria = new System.Windows.Forms.Button();
            this.Checkbox_127 = new System.Windows.Forms.CheckBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            this.groupBox12.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.brilho)).BeginInit();
            this.groupBox11.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.contraste)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.i)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.h)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.f)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.c)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.b)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.g)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.d)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.a)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ZoomSx)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ZoomSy)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.arquivoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1191, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // arquivoToolStripMenuItem
            // 
            this.arquivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.abrirImagemToolStripMenuItem,
            this.salvarImagemToolStripMenuItem,
            this.sairToolStripMenuItem});
            this.arquivoToolStripMenuItem.Name = "arquivoToolStripMenuItem";
            this.arquivoToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.arquivoToolStripMenuItem.Text = "Arquivo";
            // 
            // abrirImagemToolStripMenuItem
            // 
            this.abrirImagemToolStripMenuItem.Name = "abrirImagemToolStripMenuItem";
            this.abrirImagemToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.abrirImagemToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.abrirImagemToolStripMenuItem.Text = "Abrir Imagem";
            this.abrirImagemToolStripMenuItem.Click += new System.EventHandler(this.abrirImagemToolStripMenuItem_Click);
            // 
            // salvarImagemToolStripMenuItem
            // 
            this.salvarImagemToolStripMenuItem.Name = "salvarImagemToolStripMenuItem";
            this.salvarImagemToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.salvarImagemToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.salvarImagemToolStripMenuItem.Text = "Salvar Imagem";
            this.salvarImagemToolStripMenuItem.Click += new System.EventHandler(this.salvarImagemToolStripMenuItem_Click);
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Q)));
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.sairToolStripMenuItem.Text = "Sair";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(85, 30);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Copiar Imagem";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(85, 59);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(94, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "Flip Horizontal";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(85, 88);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(94, 23);
            this.button3.TabIndex = 3;
            this.button3.Text = "Flip Vertical";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(85, 116);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(94, 23);
            this.button4.TabIndex = 4;
            this.button4.Text = "Escala de Cinza";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(68, 145);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 5;
            this.button5.Text = "Quantizar";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(146, 147);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            256,
            0,
            0,
            0});
            this.numericUpDown1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(45, 20);
            this.numericUpDown1.TabIndex = 6;
            this.numericUpDown1.Value = new decimal(new int[] {
            256,
            0,
            0,
            0});
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(9, 696);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(1170, 13);
            this.progressBar1.TabIndex = 7;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Location = new System.Drawing.Point(265, 72);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(400, 400);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox5.TabIndex = 8;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox6
            // 
            this.pictureBox6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox6.Location = new System.Drawing.Point(673, 72);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(400, 400);
            this.pictureBox6.TabIndex = 8;
            this.pictureBox6.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(414, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Imagem Original";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(823, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Imagem Modificada";
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(71, 174);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(114, 23);
            this.button6.TabIndex = 1;
            this.button6.Text = "Obter Histograma";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.botaoHistograma_Click);
            // 
            // groupBox12
            // 
            this.groupBox12.Controls.Add(this.quantoBrilho);
            this.groupBox12.Controls.Add(this.aplicaBrilho);
            this.groupBox12.Controls.Add(this.label3);
            this.groupBox12.Controls.Add(this.label5);
            this.groupBox12.Controls.Add(this.brilho);
            this.groupBox12.Location = new System.Drawing.Point(12, 401);
            this.groupBox12.Name = "groupBox12";
            this.groupBox12.Size = new System.Drawing.Size(247, 71);
            this.groupBox12.TabIndex = 19;
            this.groupBox12.TabStop = false;
            this.groupBox12.Text = "Brilho";
            // 
            // quantoBrilho
            // 
            this.quantoBrilho.AutoSize = true;
            this.quantoBrilho.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.quantoBrilho.Location = new System.Drawing.Point(228, 12);
            this.quantoBrilho.Name = "quantoBrilho";
            this.quantoBrilho.Size = new System.Drawing.Size(13, 13);
            this.quantoBrilho.TabIndex = 6;
            this.quantoBrilho.Text = "0";
            // 
            // aplicaBrilho
            // 
            this.aplicaBrilho.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.aplicaBrilho.Location = new System.Drawing.Point(166, 42);
            this.aplicaBrilho.Name = "aplicaBrilho";
            this.aplicaBrilho.Size = new System.Drawing.Size(75, 23);
            this.aplicaBrilho.TabIndex = 5;
            this.aplicaBrilho.Text = "Aplicar";
            this.aplicaBrilho.UseVisualStyleBackColor = true;
            this.aplicaBrilho.Click += new System.EventHandler(this.aplicaBrilho_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label3.Location = new System.Drawing.Point(216, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(25, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "255";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label5.Location = new System.Drawing.Point(4, 25);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(28, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "-255";
            // 
            // brilho
            // 
            this.brilho.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.brilho.LargeChange = 1;
            this.brilho.Location = new System.Drawing.Point(7, 13);
            this.brilho.Maximum = 255;
            this.brilho.Minimum = -255;
            this.brilho.Name = "brilho";
            this.brilho.Size = new System.Drawing.Size(234, 45);
            this.brilho.TabIndex = 0;
            this.brilho.TickStyle = System.Windows.Forms.TickStyle.None;
            // 
            // groupBox11
            // 
            this.groupBox11.Controls.Add(this.quantoContraste);
            this.groupBox11.Controls.Add(this.aplicaContraste);
            this.groupBox11.Controls.Add(this.label4);
            this.groupBox11.Controls.Add(this.label6);
            this.groupBox11.Controls.Add(this.contraste);
            this.groupBox11.Location = new System.Drawing.Point(12, 322);
            this.groupBox11.Name = "groupBox11";
            this.groupBox11.Size = new System.Drawing.Size(247, 73);
            this.groupBox11.TabIndex = 20;
            this.groupBox11.TabStop = false;
            this.groupBox11.Text = "Contraste";
            // 
            // quantoContraste
            // 
            this.quantoContraste.AutoSize = true;
            this.quantoContraste.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.quantoContraste.Location = new System.Drawing.Point(228, 13);
            this.quantoContraste.Name = "quantoContraste";
            this.quantoContraste.Size = new System.Drawing.Size(13, 13);
            this.quantoContraste.TabIndex = 7;
            this.quantoContraste.Text = "0";
            // 
            // aplicaContraste
            // 
            this.aplicaContraste.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.aplicaContraste.Location = new System.Drawing.Point(166, 42);
            this.aplicaContraste.Name = "aplicaContraste";
            this.aplicaContraste.Size = new System.Drawing.Size(75, 23);
            this.aplicaContraste.TabIndex = 7;
            this.aplicaContraste.Text = "Aplicar";
            this.aplicaContraste.UseVisualStyleBackColor = true;
            this.aplicaContraste.Click += new System.EventHandler(this.aplicaContraste_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label4.Location = new System.Drawing.Point(216, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(25, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "255";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label6.Location = new System.Drawing.Point(6, 26);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(22, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "0.1";
            // 
            // contraste
            // 
            this.contraste.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.contraste.LargeChange = 1;
            this.contraste.Location = new System.Drawing.Point(7, 13);
            this.contraste.Maximum = 2550;
            this.contraste.Minimum = 1;
            this.contraste.Name = "contraste";
            this.contraste.Size = new System.Drawing.Size(234, 45);
            this.contraste.TabIndex = 1;
            this.contraste.TickStyle = System.Windows.Forms.TickStyle.None;
            this.contraste.Value = 1;
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(85, 231);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(94, 23);
            this.button7.TabIndex = 4;
            this.button7.Text = "Negativo";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.negativarImagem_Click);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(71, 203);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(114, 23);
            this.button8.TabIndex = 1;
            this.button8.Text = "Equalizar Histograma";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.botaoEqualizarHistograma_Click);
            // 
            // filtro_sobel_hy
            // 
            this.filtro_sobel_hy.Location = new System.Drawing.Point(266, 660);
            this.filtro_sobel_hy.Name = "filtro_sobel_hy";
            this.filtro_sobel_hy.Size = new System.Drawing.Size(120, 23);
            this.filtro_sobel_hy.TabIndex = 37;
            this.filtro_sobel_hy.Text = "Sobel Hy ";
            this.filtro_sobel_hy.UseVisualStyleBackColor = true;
            this.filtro_sobel_hy.Click += new System.EventHandler(this.filtro_sobel_hy_Click);
            // 
            // filtro_sobel_hx
            // 
            this.filtro_sobel_hx.Location = new System.Drawing.Point(266, 631);
            this.filtro_sobel_hx.Name = "filtro_sobel_hx";
            this.filtro_sobel_hx.Size = new System.Drawing.Size(120, 23);
            this.filtro_sobel_hx.TabIndex = 36;
            this.filtro_sobel_hx.Text = "Sobel Hx ";
            this.filtro_sobel_hx.UseVisualStyleBackColor = true;
            this.filtro_sobel_hx.Click += new System.EventHandler(this.filtro_sobel_hx_Click);
            // 
            // filtro_prewitt_hy_hx
            // 
            this.filtro_prewitt_hy_hx.Location = new System.Drawing.Point(266, 602);
            this.filtro_prewitt_hy_hx.Name = "filtro_prewitt_hy_hx";
            this.filtro_prewitt_hy_hx.Size = new System.Drawing.Size(120, 23);
            this.filtro_prewitt_hy_hx.TabIndex = 35;
            this.filtro_prewitt_hy_hx.Text = "Prewitt Hy Hx";
            this.filtro_prewitt_hy_hx.UseVisualStyleBackColor = true;
            this.filtro_prewitt_hy_hx.Click += new System.EventHandler(this.filtro_prewitt_hy_hx_Click);
            // 
            // filtro_prewitt_hx
            // 
            this.filtro_prewitt_hx.Location = new System.Drawing.Point(266, 573);
            this.filtro_prewitt_hx.Name = "filtro_prewitt_hx";
            this.filtro_prewitt_hx.Size = new System.Drawing.Size(120, 23);
            this.filtro_prewitt_hx.TabIndex = 34;
            this.filtro_prewitt_hx.Text = "Prewitt Hx";
            this.filtro_prewitt_hx.UseVisualStyleBackColor = true;
            this.filtro_prewitt_hx.Click += new System.EventHandler(this.filtro_prewitt_hx_Click);
            // 
            // filtro_passas_altas_generico
            // 
            this.filtro_passas_altas_generico.Location = new System.Drawing.Point(266, 544);
            this.filtro_passas_altas_generico.Name = "filtro_passas_altas_generico";
            this.filtro_passas_altas_generico.Size = new System.Drawing.Size(120, 23);
            this.filtro_passas_altas_generico.TabIndex = 33;
            this.filtro_passas_altas_generico.Text = "Passa Altas Genérico";
            this.filtro_passas_altas_generico.UseVisualStyleBackColor = true;
            this.filtro_passas_altas_generico.Click += new System.EventHandler(this.filtro_passas_altas_generico_Click);
            // 
            // filtro_laplaciano
            // 
            this.filtro_laplaciano.Location = new System.Drawing.Point(266, 514);
            this.filtro_laplaciano.Name = "filtro_laplaciano";
            this.filtro_laplaciano.Size = new System.Drawing.Size(120, 23);
            this.filtro_laplaciano.TabIndex = 32;
            this.filtro_laplaciano.Text = "Laplaciano";
            this.filtro_laplaciano.UseVisualStyleBackColor = true;
            this.filtro_laplaciano.Click += new System.EventHandler(this.filtro_laplaciano_Click);
            // 
            // filtro_gaussiano
            // 
            this.filtro_gaussiano.Location = new System.Drawing.Point(266, 484);
            this.filtro_gaussiano.Name = "filtro_gaussiano";
            this.filtro_gaussiano.Size = new System.Drawing.Size(120, 23);
            this.filtro_gaussiano.TabIndex = 31;
            this.filtro_gaussiano.Text = "Gaussiano";
            this.filtro_gaussiano.UseVisualStyleBackColor = true;
            this.filtro_gaussiano.Click += new System.EventHandler(this.filtro_gaussiano_Click);
            // 
            // aplicar_filtro
            // 
            this.aplicar_filtro.Location = new System.Drawing.Point(85, 635);
            this.aplicar_filtro.Name = "aplicar_filtro";
            this.aplicar_filtro.Size = new System.Drawing.Size(75, 23);
            this.aplicar_filtro.TabIndex = 30;
            this.aplicar_filtro.Text = "Aplicar Filtro";
            this.aplicar_filtro.UseVisualStyleBackColor = true;
            this.aplicar_filtro.Click += new System.EventHandler(this.aplicar_filtro_Click);
            // 
            // i
            // 
            this.i.DecimalPlaces = 4;
            this.i.Increment = new decimal(new int[] {
            1,
            0,
            0,
            262144});
            this.i.Location = new System.Drawing.Point(175, 582);
            this.i.Maximum = new decimal(new int[] {
            9,
            0,
            0,
            0});
            this.i.Minimum = new decimal(new int[] {
            9,
            0,
            0,
            -2147483648});
            this.i.Name = "i";
            this.i.Size = new System.Drawing.Size(55, 20);
            this.i.TabIndex = 21;
            this.i.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // h
            // 
            this.h.DecimalPlaces = 4;
            this.h.Increment = new decimal(new int[] {
            1,
            0,
            0,
            262144});
            this.h.Location = new System.Drawing.Point(96, 582);
            this.h.Maximum = new decimal(new int[] {
            9,
            0,
            0,
            0});
            this.h.Minimum = new decimal(new int[] {
            9,
            0,
            0,
            -2147483648});
            this.h.Name = "h";
            this.h.Size = new System.Drawing.Size(55, 20);
            this.h.TabIndex = 27;
            this.h.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // f
            // 
            this.f.DecimalPlaces = 4;
            this.f.Increment = new decimal(new int[] {
            1,
            0,
            0,
            262144});
            this.f.Location = new System.Drawing.Point(175, 556);
            this.f.Maximum = new decimal(new int[] {
            9,
            0,
            0,
            0});
            this.f.Minimum = new decimal(new int[] {
            9,
            0,
            0,
            -2147483648});
            this.f.Name = "f";
            this.f.Size = new System.Drawing.Size(55, 20);
            this.f.TabIndex = 26;
            this.f.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // mid
            // 
            this.mid.DecimalPlaces = 4;
            this.mid.Increment = new decimal(new int[] {
            1,
            0,
            0,
            262144});
            this.mid.Location = new System.Drawing.Point(96, 556);
            this.mid.Maximum = new decimal(new int[] {
            9,
            0,
            0,
            0});
            this.mid.Minimum = new decimal(new int[] {
            9,
            0,
            0,
            -2147483648});
            this.mid.Name = "mid";
            this.mid.Size = new System.Drawing.Size(55, 20);
            this.mid.TabIndex = 25;
            this.mid.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.mid.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // c
            // 
            this.c.DecimalPlaces = 4;
            this.c.Increment = new decimal(new int[] {
            1,
            0,
            0,
            262144});
            this.c.Location = new System.Drawing.Point(175, 530);
            this.c.Maximum = new decimal(new int[] {
            9,
            0,
            0,
            0});
            this.c.Minimum = new decimal(new int[] {
            9,
            0,
            0,
            -2147483648});
            this.c.Name = "c";
            this.c.Size = new System.Drawing.Size(55, 20);
            this.c.TabIndex = 24;
            this.c.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // b
            // 
            this.b.DecimalPlaces = 4;
            this.b.Increment = new decimal(new int[] {
            1,
            0,
            0,
            262144});
            this.b.Location = new System.Drawing.Point(96, 530);
            this.b.Maximum = new decimal(new int[] {
            9,
            0,
            0,
            0});
            this.b.Minimum = new decimal(new int[] {
            9,
            0,
            0,
            -2147483648});
            this.b.Name = "b";
            this.b.Size = new System.Drawing.Size(55, 20);
            this.b.TabIndex = 23;
            this.b.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // g
            // 
            this.g.DecimalPlaces = 4;
            this.g.Increment = new decimal(new int[] {
            1,
            0,
            0,
            262144});
            this.g.Location = new System.Drawing.Point(13, 582);
            this.g.Maximum = new decimal(new int[] {
            9,
            0,
            0,
            0});
            this.g.Minimum = new decimal(new int[] {
            9,
            0,
            0,
            -2147483648});
            this.g.Name = "g";
            this.g.Size = new System.Drawing.Size(57, 20);
            this.g.TabIndex = 22;
            this.g.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // d
            // 
            this.d.DecimalPlaces = 4;
            this.d.Increment = new decimal(new int[] {
            1,
            0,
            0,
            262144});
            this.d.Location = new System.Drawing.Point(13, 556);
            this.d.Maximum = new decimal(new int[] {
            9,
            0,
            0,
            0});
            this.d.Minimum = new decimal(new int[] {
            9,
            0,
            0,
            -2147483648});
            this.d.Name = "d";
            this.d.Size = new System.Drawing.Size(57, 20);
            this.d.TabIndex = 28;
            this.d.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // a
            // 
            this.a.DecimalPlaces = 4;
            this.a.Increment = new decimal(new int[] {
            1,
            0,
            0,
            262144});
            this.a.Location = new System.Drawing.Point(13, 530);
            this.a.Maximum = new decimal(new int[] {
            9,
            0,
            0,
            0});
            this.a.Minimum = new decimal(new int[] {
            9,
            0,
            0,
            -2147483648});
            this.a.Name = "a";
            this.a.Size = new System.Drawing.Size(57, 20);
            this.a.TabIndex = 29;
            this.a.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // ZoomIn
            // 
            this.ZoomIn.Location = new System.Drawing.Point(912, 488);
            this.ZoomIn.Name = "ZoomIn";
            this.ZoomIn.Size = new System.Drawing.Size(75, 23);
            this.ZoomIn.TabIndex = 38;
            this.ZoomIn.Text = "ZoomIn";
            this.ZoomIn.UseVisualStyleBackColor = true;
            this.ZoomIn.Click += new System.EventHandler(this.ZoomIn_Click);
            // 
            // ZoomOut
            // 
            this.ZoomOut.Location = new System.Drawing.Point(993, 488);
            this.ZoomOut.Name = "ZoomOut";
            this.ZoomOut.Size = new System.Drawing.Size(75, 23);
            this.ZoomOut.TabIndex = 39;
            this.ZoomOut.Text = "ZoomOut";
            this.ZoomOut.UseVisualStyleBackColor = true;
            this.ZoomOut.Click += new System.EventHandler(this.ZoomOut_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(916, 518);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(22, 13);
            this.label7.TabIndex = 40;
            this.label7.Text = "Sx:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(997, 518);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(22, 13);
            this.label8.TabIndex = 40;
            this.label8.Text = "Sy:";
            // 
            // ZoomSx
            // 
            this.ZoomSx.Location = new System.Drawing.Point(942, 514);
            this.ZoomSx.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.ZoomSx.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.ZoomSx.Name = "ZoomSx";
            this.ZoomSx.Size = new System.Drawing.Size(36, 20);
            this.ZoomSx.TabIndex = 41;
            this.ZoomSx.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // ZoomSy
            // 
            this.ZoomSy.Location = new System.Drawing.Point(1025, 514);
            this.ZoomSy.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.ZoomSy.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.ZoomSy.Name = "ZoomSy";
            this.ZoomSy.Size = new System.Drawing.Size(36, 20);
            this.ZoomSy.TabIndex = 41;
            this.ZoomSy.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // rotacao_horaria
            // 
            this.rotacao_horaria.Location = new System.Drawing.Point(673, 487);
            this.rotacao_horaria.Name = "rotacao_horaria";
            this.rotacao_horaria.Size = new System.Drawing.Size(100, 23);
            this.rotacao_horaria.TabIndex = 42;
            this.rotacao_horaria.Text = "Rotação Horária";
            this.rotacao_horaria.UseVisualStyleBackColor = true;
            this.rotacao_horaria.Click += new System.EventHandler(this.Rotacao_Horaria_Click);
            // 
            // Rotacao_Anti_Horaria
            // 
            this.Rotacao_Anti_Horaria.Location = new System.Drawing.Point(779, 487);
            this.Rotacao_Anti_Horaria.Name = "Rotacao_Anti_Horaria";
            this.Rotacao_Anti_Horaria.Size = new System.Drawing.Size(115, 23);
            this.Rotacao_Anti_Horaria.TabIndex = 43;
            this.Rotacao_Anti_Horaria.Text = "Rotação Anti-Horária";
            this.Rotacao_Anti_Horaria.UseVisualStyleBackColor = true;
            this.Rotacao_Anti_Horaria.Click += new System.EventHandler(this.Rotacao_Anti_Horaria_Click);
            // 
            // Checkbox_127
            // 
            this.Checkbox_127.AutoSize = true;
            this.Checkbox_127.Location = new System.Drawing.Point(13, 609);
            this.Checkbox_127.Name = "Checkbox_127";
            this.Checkbox_127.Size = new System.Drawing.Size(74, 17);
            this.Checkbox_127.TabIndex = 44;
            this.Checkbox_127.Text = "Soma 127";
            this.Checkbox_127.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1191, 719);
            this.Controls.Add(this.Checkbox_127);
            this.Controls.Add(this.Rotacao_Anti_Horaria);
            this.Controls.Add(this.rotacao_horaria);
            this.Controls.Add(this.ZoomSy);
            this.Controls.Add(this.ZoomSx);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.ZoomOut);
            this.Controls.Add(this.ZoomIn);
            this.Controls.Add(this.filtro_sobel_hy);
            this.Controls.Add(this.filtro_sobel_hx);
            this.Controls.Add(this.filtro_prewitt_hy_hx);
            this.Controls.Add(this.filtro_prewitt_hx);
            this.Controls.Add(this.filtro_passas_altas_generico);
            this.Controls.Add(this.filtro_laplaciano);
            this.Controls.Add(this.filtro_gaussiano);
            this.Controls.Add(this.aplicar_filtro);
            this.Controls.Add(this.i);
            this.Controls.Add(this.h);
            this.Controls.Add(this.f);
            this.Controls.Add(this.mid);
            this.Controls.Add(this.c);
            this.Controls.Add(this.b);
            this.Controls.Add(this.g);
            this.Controls.Add(this.d);
            this.Controls.Add(this.a);
            this.Controls.Add(this.groupBox11);
            this.Controls.Add(this.groupBox12);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "EditorPhoto";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            this.groupBox12.ResumeLayout(false);
            this.groupBox12.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.brilho)).EndInit();
            this.groupBox11.ResumeLayout(false);
            this.groupBox11.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.contraste)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.i)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.h)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.f)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.c)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.b)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.g)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.d)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.a)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ZoomSx)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ZoomSy)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem arquivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem abrirImagemToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salvarImagemToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.GroupBox groupBox12;
        private System.Windows.Forms.Label quantoBrilho;
        private System.Windows.Forms.Button aplicaBrilho;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.TrackBar brilho;
        private System.Windows.Forms.GroupBox groupBox11;
        private System.Windows.Forms.Button aplicaContraste;
        private System.Windows.Forms.Label quantoContraste;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        public System.Windows.Forms.TrackBar contraste;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        public System.Windows.Forms.PictureBox pictureBox5;
        public System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.Button filtro_sobel_hy;
        private System.Windows.Forms.Button filtro_sobel_hx;
        private System.Windows.Forms.Button filtro_prewitt_hy_hx;
        private System.Windows.Forms.Button filtro_prewitt_hx;
        private System.Windows.Forms.Button filtro_passas_altas_generico;
        private System.Windows.Forms.Button filtro_laplaciano;
        private System.Windows.Forms.Button filtro_gaussiano;
        private System.Windows.Forms.Button aplicar_filtro;
        public System.Windows.Forms.NumericUpDown i;
        public System.Windows.Forms.NumericUpDown h;
        public System.Windows.Forms.NumericUpDown f;
        public System.Windows.Forms.NumericUpDown mid;
        public System.Windows.Forms.NumericUpDown c;
        public System.Windows.Forms.NumericUpDown b;
        public System.Windows.Forms.NumericUpDown g;
        public System.Windows.Forms.NumericUpDown d;
        public System.Windows.Forms.NumericUpDown a;
        private System.Windows.Forms.Button ZoomIn;
        private System.Windows.Forms.Button ZoomOut;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown ZoomSx;
        private System.Windows.Forms.NumericUpDown ZoomSy;
        private System.Windows.Forms.Button rotacao_horaria;
        private System.Windows.Forms.Button Rotacao_Anti_Horaria;
        private System.Windows.Forms.CheckBox Checkbox_127;
    }
}

