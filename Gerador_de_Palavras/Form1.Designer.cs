namespace Gerador_de_Palavras
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
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox12 = new System.Windows.Forms.GroupBox();
            this.txtCaracteres_Selecionados = new System.Windows.Forms.TextBox();
            this.btnDesmarcar_Maiuscula_az = new System.Windows.Forms.Button();
            this.btnMarcar_Maiuscula_az = new System.Windows.Forms.Button();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.lskMaiuscula_az = new System.Windows.Forms.CheckedListBox();
            this.btnDesmarcar_Minuscula_az = new System.Windows.Forms.Button();
            this.btnMarcar_Minuscula_az = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lskMinuscula_az = new System.Windows.Forms.CheckedListBox();
            this.rotulo_dos_caracteres = new System.Windows.Forms.Label();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.lskPontuacao = new System.Windows.Forms.CheckedListBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.lskSimbolo = new System.Windows.Forms.CheckedListBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.lskMaiuscula = new System.Windows.Forms.CheckedListBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lskMinuscula = new System.Windows.Forms.CheckedListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lskDigitos = new System.Windows.Forms.CheckedListBox();
            this.btnMarcar_Digitos = new System.Windows.Forms.Button();
            this.btnMarcar_Minuscula = new System.Windows.Forms.Button();
            this.btnMarcar_Simbolo = new System.Windows.Forms.Button();
            this.btnDesmarcar_Simbolo = new System.Windows.Forms.Button();
            this.btnMarcar_Maiuscula = new System.Windows.Forms.Button();
            this.btnMarcar_Pontuacao = new System.Windows.Forms.Button();
            this.btnDesmarcar_Pontuacao = new System.Windows.Forms.Button();
            this.btnDesmarcar_Digito = new System.Windows.Forms.Button();
            this.btnDesmarcar_Maiuscula = new System.Windows.Forms.Button();
            this.btnDesmarcar_Minuscula = new System.Windows.Forms.Button();
            this.chkOrdenar_Ascii = new System.Windows.Forms.CheckBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox11 = new System.Windows.Forms.GroupBox();
            this.chkLog_Visivel = new System.Windows.Forms.CheckBox();
            this.log_geracao = new System.Windows.Forms.Label();
            this.groupBox10 = new System.Windows.Forms.GroupBox();
            this.upCaracteres_por_Palavra = new System.Windows.Forms.NumericUpDown();
            this.groupBox9 = new System.Windows.Forms.GroupBox();
            this.upLinhas_por_Arquivo = new System.Windows.Forms.NumericUpDown();
            this.btnParar = new System.Windows.Forms.Button();
            this.btnGerar = new System.Windows.Forms.Button();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.btnAbrir_Diretorio = new System.Windows.Forms.Button();
            this.txtDiretorio = new System.Windows.Forms.TextBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.dlgDiretorio = new System.Windows.Forms.FolderBrowserDialog();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.groupBox12.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox11.SuspendLayout();
            this.groupBox10.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.upCaracteres_por_Palavra)).BeginInit();
            this.groupBox9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.upLinhas_por_Arquivo)).BeginInit();
            this.groupBox8.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 615);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(909, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Location = new System.Drawing.Point(23, 30);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.splitContainer1.Size = new System.Drawing.Size(302, 261);
            this.splitContainer1.SplitterDistance = 55;
            this.splitContainer1.TabIndex = 3;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(909, 615);
            this.tabControl1.TabIndex = 4;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.tableLayoutPanel1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(901, 589);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Selecionar caracteres";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 7;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.Controls.Add(this.groupBox12, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.btnDesmarcar_Maiuscula_az, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.btnMarcar_Maiuscula_az, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.groupBox7, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnDesmarcar_Minuscula_az, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.btnMarcar_Minuscula_az, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.groupBox2, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.rotulo_dos_caracteres, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.groupBox6, 5, 1);
            this.tableLayoutPanel1.Controls.Add(this.groupBox5, 6, 1);
            this.tableLayoutPanel1.Controls.Add(this.groupBox4, 4, 1);
            this.tableLayoutPanel1.Controls.Add(this.groupBox3, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.groupBox1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnMarcar_Digitos, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.btnMarcar_Minuscula, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.btnMarcar_Simbolo, 6, 2);
            this.tableLayoutPanel1.Controls.Add(this.btnDesmarcar_Simbolo, 6, 3);
            this.tableLayoutPanel1.Controls.Add(this.btnMarcar_Maiuscula, 4, 2);
            this.tableLayoutPanel1.Controls.Add(this.btnMarcar_Pontuacao, 5, 2);
            this.tableLayoutPanel1.Controls.Add(this.btnDesmarcar_Pontuacao, 5, 3);
            this.tableLayoutPanel1.Controls.Add(this.btnDesmarcar_Digito, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.btnDesmarcar_Maiuscula, 4, 3);
            this.tableLayoutPanel1.Controls.Add(this.btnDesmarcar_Minuscula, 3, 3);
            this.tableLayoutPanel1.Controls.Add(this.chkOrdenar_Ascii, 6, 4);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 83F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 78.01608F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.434053F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.153478F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 21F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 19F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(895, 583);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // groupBox12
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.groupBox12, 6);
            this.groupBox12.Controls.Add(this.txtCaracteres_Selecionados);
            this.groupBox12.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox12.Location = new System.Drawing.Point(3, 566);
            this.groupBox12.Name = "groupBox12";
            this.groupBox12.Size = new System.Drawing.Size(756, 14);
            this.groupBox12.TabIndex = 28;
            this.groupBox12.TabStop = false;
            this.groupBox12.Text = "Digite os caracteres, ou selecione nas listas abaixo:";
            // 
            // txtCaracteres_Selecionados
            // 
            this.txtCaracteres_Selecionados.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtCaracteres_Selecionados.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCaracteres_Selecionados.Location = new System.Drawing.Point(3, 16);
            this.txtCaracteres_Selecionados.Multiline = true;
            this.txtCaracteres_Selecionados.Name = "txtCaracteres_Selecionados";
            this.txtCaracteres_Selecionados.Size = new System.Drawing.Size(750, 0);
            this.txtCaracteres_Selecionados.TabIndex = 0;
            // 
            // btnDesmarcar_Maiuscula_az
            // 
            this.btnDesmarcar_Maiuscula_az.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDesmarcar_Maiuscula_az.Location = new System.Drawing.Point(257, 505);
            this.btnDesmarcar_Maiuscula_az.Name = "btnDesmarcar_Maiuscula_az";
            this.btnDesmarcar_Maiuscula_az.Size = new System.Drawing.Size(121, 23);
            this.btnDesmarcar_Maiuscula_az.TabIndex = 25;
            this.btnDesmarcar_Maiuscula_az.Text = "Desmarcar todos";
            this.btnDesmarcar_Maiuscula_az.UseVisualStyleBackColor = true;
            this.btnDesmarcar_Maiuscula_az.Click += new System.EventHandler(this.btnDesmarcar_Maiuscula_az_Click);
            // 
            // btnMarcar_Maiuscula_az
            // 
            this.btnMarcar_Maiuscula_az.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMarcar_Maiuscula_az.Location = new System.Drawing.Point(257, 469);
            this.btnMarcar_Maiuscula_az.Name = "btnMarcar_Maiuscula_az";
            this.btnMarcar_Maiuscula_az.Size = new System.Drawing.Size(121, 23);
            this.btnMarcar_Maiuscula_az.TabIndex = 24;
            this.btnMarcar_Maiuscula_az.Text = "Marcar todos";
            this.btnMarcar_Maiuscula_az.UseVisualStyleBackColor = true;
            this.btnMarcar_Maiuscula_az.Click += new System.EventHandler(this.btnMarcar_Maiuscula_az_Click);
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.lskMaiuscula_az);
            this.groupBox7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox7.Location = new System.Drawing.Point(257, 86);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(121, 377);
            this.groupBox7.TabIndex = 23;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "De \'A\' a \'Z\' (maiúscula):";
            // 
            // lskMaiuscula_az
            // 
            this.lskMaiuscula_az.CheckOnClick = true;
            this.lskMaiuscula_az.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lskMaiuscula_az.FormattingEnabled = true;
            this.lskMaiuscula_az.Location = new System.Drawing.Point(3, 16);
            this.lskMaiuscula_az.Name = "lskMaiuscula_az";
            this.lskMaiuscula_az.Size = new System.Drawing.Size(115, 358);
            this.lskMaiuscula_az.TabIndex = 0;
            this.lskMaiuscula_az.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.checkBox_ItemCheck);
            // 
            // btnDesmarcar_Minuscula_az
            // 
            this.btnDesmarcar_Minuscula_az.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDesmarcar_Minuscula_az.Location = new System.Drawing.Point(130, 505);
            this.btnDesmarcar_Minuscula_az.Name = "btnDesmarcar_Minuscula_az";
            this.btnDesmarcar_Minuscula_az.Size = new System.Drawing.Size(121, 24);
            this.btnDesmarcar_Minuscula_az.TabIndex = 22;
            this.btnDesmarcar_Minuscula_az.Text = "Desmarcar todos";
            this.btnDesmarcar_Minuscula_az.UseVisualStyleBackColor = true;
            this.btnDesmarcar_Minuscula_az.Click += new System.EventHandler(this.btnDesmarcar_Minuscula_az_Click);
            // 
            // btnMarcar_Minuscula_az
            // 
            this.btnMarcar_Minuscula_az.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMarcar_Minuscula_az.Location = new System.Drawing.Point(130, 469);
            this.btnMarcar_Minuscula_az.Name = "btnMarcar_Minuscula_az";
            this.btnMarcar_Minuscula_az.Size = new System.Drawing.Size(121, 23);
            this.btnMarcar_Minuscula_az.TabIndex = 21;
            this.btnMarcar_Minuscula_az.Text = "Marcar todos";
            this.btnMarcar_Minuscula_az.UseVisualStyleBackColor = true;
            this.btnMarcar_Minuscula_az.Click += new System.EventHandler(this.btnMarcar_Minuscula_az_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lskMinuscula_az);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(130, 86);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(121, 377);
            this.groupBox2.TabIndex = 20;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "De \'a\' a \'z\' (minúscula):";
            // 
            // lskMinuscula_az
            // 
            this.lskMinuscula_az.CheckOnClick = true;
            this.lskMinuscula_az.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lskMinuscula_az.FormattingEnabled = true;
            this.lskMinuscula_az.Location = new System.Drawing.Point(3, 16);
            this.lskMinuscula_az.Name = "lskMinuscula_az";
            this.lskMinuscula_az.Size = new System.Drawing.Size(115, 358);
            this.lskMinuscula_az.TabIndex = 0;
            this.lskMinuscula_az.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.checkBox_ItemCheck);
            // 
            // rotulo_dos_caracteres
            // 
            this.rotulo_dos_caracteres.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.rotulo_dos_caracteres, 7);
            this.rotulo_dos_caracteres.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rotulo_dos_caracteres.ForeColor = System.Drawing.SystemColors.ControlText;
            this.rotulo_dos_caracteres.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.rotulo_dos_caracteres.Location = new System.Drawing.Point(3, 0);
            this.rotulo_dos_caracteres.Name = "rotulo_dos_caracteres";
            this.rotulo_dos_caracteres.Size = new System.Drawing.Size(98, 21);
            this.rotulo_dos_caracteres.TabIndex = 19;
            this.rotulo_dos_caracteres.Text = "sadfasdf";
            this.rotulo_dos_caracteres.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.lskPontuacao);
            this.groupBox6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox6.Location = new System.Drawing.Point(638, 86);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(121, 377);
            this.groupBox6.TabIndex = 5;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Pontuação:";
            // 
            // lskPontuacao
            // 
            this.lskPontuacao.CheckOnClick = true;
            this.lskPontuacao.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lskPontuacao.FormattingEnabled = true;
            this.lskPontuacao.Location = new System.Drawing.Point(3, 16);
            this.lskPontuacao.Name = "lskPontuacao";
            this.lskPontuacao.Size = new System.Drawing.Size(115, 358);
            this.lskPontuacao.TabIndex = 0;
            this.lskPontuacao.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.checkBox_ItemCheck);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.lskSimbolo);
            this.groupBox5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox5.Location = new System.Drawing.Point(765, 86);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(127, 377);
            this.groupBox5.TabIndex = 4;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Símbolos:";
            // 
            // lskSimbolo
            // 
            this.lskSimbolo.CheckOnClick = true;
            this.lskSimbolo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lskSimbolo.FormattingEnabled = true;
            this.lskSimbolo.Location = new System.Drawing.Point(3, 16);
            this.lskSimbolo.Name = "lskSimbolo";
            this.lskSimbolo.Size = new System.Drawing.Size(121, 358);
            this.lskSimbolo.TabIndex = 0;
            this.lskSimbolo.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.checkBox_ItemCheck);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.lskMaiuscula);
            this.groupBox4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox4.Location = new System.Drawing.Point(511, 86);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(121, 377);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Letras maiúsculas:";
            // 
            // lskMaiuscula
            // 
            this.lskMaiuscula.CheckOnClick = true;
            this.lskMaiuscula.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lskMaiuscula.FormattingEnabled = true;
            this.lskMaiuscula.Location = new System.Drawing.Point(3, 16);
            this.lskMaiuscula.Name = "lskMaiuscula";
            this.lskMaiuscula.Size = new System.Drawing.Size(115, 358);
            this.lskMaiuscula.TabIndex = 0;
            this.lskMaiuscula.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.checkBox_ItemCheck);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lskMinuscula);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox3.Location = new System.Drawing.Point(384, 86);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(121, 377);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Letras de \'a\' a \'z\':";
            // 
            // lskMinuscula
            // 
            this.lskMinuscula.CheckOnClick = true;
            this.lskMinuscula.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lskMinuscula.FormattingEnabled = true;
            this.lskMinuscula.Location = new System.Drawing.Point(3, 16);
            this.lskMinuscula.Name = "lskMinuscula";
            this.lskMinuscula.Size = new System.Drawing.Size(115, 358);
            this.lskMinuscula.TabIndex = 0;
            this.lskMinuscula.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.checkBox_ItemCheck);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lskDigitos);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(3, 86);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(121, 377);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Digitos:";
            // 
            // lskDigitos
            // 
            this.lskDigitos.CheckOnClick = true;
            this.lskDigitos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lskDigitos.FormattingEnabled = true;
            this.lskDigitos.Location = new System.Drawing.Point(3, 16);
            this.lskDigitos.Name = "lskDigitos";
            this.lskDigitos.Size = new System.Drawing.Size(115, 358);
            this.lskDigitos.TabIndex = 0;
            this.lskDigitos.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.checkBox_ItemCheck);
            // 
            // btnMarcar_Digitos
            // 
            this.btnMarcar_Digitos.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMarcar_Digitos.Location = new System.Drawing.Point(3, 469);
            this.btnMarcar_Digitos.Name = "btnMarcar_Digitos";
            this.btnMarcar_Digitos.Size = new System.Drawing.Size(121, 23);
            this.btnMarcar_Digitos.TabIndex = 6;
            this.btnMarcar_Digitos.Text = "Marcar todos";
            this.btnMarcar_Digitos.UseVisualStyleBackColor = true;
            this.btnMarcar_Digitos.Click += new System.EventHandler(this.btnMarcar_Digitos_Click_1);
            // 
            // btnMarcar_Minuscula
            // 
            this.btnMarcar_Minuscula.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMarcar_Minuscula.Location = new System.Drawing.Point(384, 469);
            this.btnMarcar_Minuscula.Name = "btnMarcar_Minuscula";
            this.btnMarcar_Minuscula.Size = new System.Drawing.Size(121, 23);
            this.btnMarcar_Minuscula.TabIndex = 7;
            this.btnMarcar_Minuscula.Text = "Marcar todos";
            this.btnMarcar_Minuscula.UseVisualStyleBackColor = true;
            this.btnMarcar_Minuscula.Click += new System.EventHandler(this.btnMarcar_Minuscula_Click);
            // 
            // btnMarcar_Simbolo
            // 
            this.btnMarcar_Simbolo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMarcar_Simbolo.Location = new System.Drawing.Point(765, 469);
            this.btnMarcar_Simbolo.Name = "btnMarcar_Simbolo";
            this.btnMarcar_Simbolo.Size = new System.Drawing.Size(127, 23);
            this.btnMarcar_Simbolo.TabIndex = 10;
            this.btnMarcar_Simbolo.Text = "Marcar todos";
            this.btnMarcar_Simbolo.UseVisualStyleBackColor = true;
            this.btnMarcar_Simbolo.Click += new System.EventHandler(this.btnMarcar_Simbolo_Click);
            // 
            // btnDesmarcar_Simbolo
            // 
            this.btnDesmarcar_Simbolo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDesmarcar_Simbolo.Location = new System.Drawing.Point(765, 505);
            this.btnDesmarcar_Simbolo.Name = "btnDesmarcar_Simbolo";
            this.btnDesmarcar_Simbolo.Size = new System.Drawing.Size(127, 24);
            this.btnDesmarcar_Simbolo.TabIndex = 13;
            this.btnDesmarcar_Simbolo.Text = "Desmarcar todos";
            this.btnDesmarcar_Simbolo.UseVisualStyleBackColor = true;
            this.btnDesmarcar_Simbolo.Click += new System.EventHandler(this.btnDesmarcar_Simbolo_Click);
            // 
            // btnMarcar_Maiuscula
            // 
            this.btnMarcar_Maiuscula.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMarcar_Maiuscula.Location = new System.Drawing.Point(511, 469);
            this.btnMarcar_Maiuscula.Name = "btnMarcar_Maiuscula";
            this.btnMarcar_Maiuscula.Size = new System.Drawing.Size(121, 23);
            this.btnMarcar_Maiuscula.TabIndex = 9;
            this.btnMarcar_Maiuscula.Text = "Marcar todos";
            this.btnMarcar_Maiuscula.UseVisualStyleBackColor = true;
            this.btnMarcar_Maiuscula.Click += new System.EventHandler(this.btnMarcar_Maiuscula_Click);
            // 
            // btnMarcar_Pontuacao
            // 
            this.btnMarcar_Pontuacao.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMarcar_Pontuacao.Location = new System.Drawing.Point(638, 469);
            this.btnMarcar_Pontuacao.Name = "btnMarcar_Pontuacao";
            this.btnMarcar_Pontuacao.Size = new System.Drawing.Size(121, 23);
            this.btnMarcar_Pontuacao.TabIndex = 11;
            this.btnMarcar_Pontuacao.Text = "Marcar todos";
            this.btnMarcar_Pontuacao.UseVisualStyleBackColor = true;
            this.btnMarcar_Pontuacao.Click += new System.EventHandler(this.btnMarcar_Pontuacao_Click);
            // 
            // btnDesmarcar_Pontuacao
            // 
            this.btnDesmarcar_Pontuacao.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDesmarcar_Pontuacao.Location = new System.Drawing.Point(638, 505);
            this.btnDesmarcar_Pontuacao.Name = "btnDesmarcar_Pontuacao";
            this.btnDesmarcar_Pontuacao.Size = new System.Drawing.Size(121, 24);
            this.btnDesmarcar_Pontuacao.TabIndex = 15;
            this.btnDesmarcar_Pontuacao.Text = "Desmarcar todos";
            this.btnDesmarcar_Pontuacao.UseVisualStyleBackColor = true;
            this.btnDesmarcar_Pontuacao.Click += new System.EventHandler(this.btnDesmarcar_Pontuacao_Click);
            // 
            // btnDesmarcar_Digito
            // 
            this.btnDesmarcar_Digito.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDesmarcar_Digito.Location = new System.Drawing.Point(3, 505);
            this.btnDesmarcar_Digito.Name = "btnDesmarcar_Digito";
            this.btnDesmarcar_Digito.Size = new System.Drawing.Size(121, 24);
            this.btnDesmarcar_Digito.TabIndex = 12;
            this.btnDesmarcar_Digito.Text = "Desmarcar todos";
            this.btnDesmarcar_Digito.UseVisualStyleBackColor = true;
            this.btnDesmarcar_Digito.Click += new System.EventHandler(this.btnDesmarcar_Digito_Click);
            // 
            // btnDesmarcar_Maiuscula
            // 
            this.btnDesmarcar_Maiuscula.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDesmarcar_Maiuscula.Location = new System.Drawing.Point(511, 505);
            this.btnDesmarcar_Maiuscula.Name = "btnDesmarcar_Maiuscula";
            this.btnDesmarcar_Maiuscula.Size = new System.Drawing.Size(121, 24);
            this.btnDesmarcar_Maiuscula.TabIndex = 14;
            this.btnDesmarcar_Maiuscula.Text = "Desmarcar todos";
            this.btnDesmarcar_Maiuscula.UseVisualStyleBackColor = true;
            this.btnDesmarcar_Maiuscula.Click += new System.EventHandler(this.btnDesmarcar_Maiuscula_Click);
            // 
            // btnDesmarcar_Minuscula
            // 
            this.btnDesmarcar_Minuscula.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDesmarcar_Minuscula.Location = new System.Drawing.Point(384, 505);
            this.btnDesmarcar_Minuscula.Name = "btnDesmarcar_Minuscula";
            this.btnDesmarcar_Minuscula.Size = new System.Drawing.Size(121, 24);
            this.btnDesmarcar_Minuscula.TabIndex = 8;
            this.btnDesmarcar_Minuscula.Text = "Desmarcar todos";
            this.btnDesmarcar_Minuscula.UseVisualStyleBackColor = true;
            this.btnDesmarcar_Minuscula.Click += new System.EventHandler(this.btnDesmarcar_Minuscula_Click);
            // 
            // chkOrdenar_Ascii
            // 
            this.chkOrdenar_Ascii.AutoSize = true;
            this.chkOrdenar_Ascii.Location = new System.Drawing.Point(765, 545);
            this.chkOrdenar_Ascii.Name = "chkOrdenar_Ascii";
            this.chkOrdenar_Ascii.Size = new System.Drawing.Size(127, 15);
            this.chkOrdenar_Ascii.TabIndex = 26;
            this.chkOrdenar_Ascii.Text = "Dispor em ordem ASCII";
            this.chkOrdenar_Ascii.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.chkOrdenar_Ascii.UseVisualStyleBackColor = true;
            this.chkOrdenar_Ascii.CheckedChanged += new System.EventHandler(this.chkOrdenar_Ascii_CheckedChanged);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.groupBox11);
            this.tabPage2.Controls.Add(this.groupBox10);
            this.tabPage2.Controls.Add(this.groupBox9);
            this.tabPage2.Controls.Add(this.btnParar);
            this.tabPage2.Controls.Add(this.btnGerar);
            this.tabPage2.Controls.Add(this.groupBox8);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(901, 589);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Gerar";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupBox11
            // 
            this.groupBox11.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox11.Controls.Add(this.chkLog_Visivel);
            this.groupBox11.Controls.Add(this.log_geracao);
            this.groupBox11.Location = new System.Drawing.Point(8, 120);
            this.groupBox11.Name = "groupBox11";
            this.groupBox11.Size = new System.Drawing.Size(880, 96);
            this.groupBox11.TabIndex = 5;
            this.groupBox11.TabStop = false;
            this.groupBox11.Text = "Log da geração dos arquivos:";
            // 
            // chkLog_Visivel
            // 
            this.chkLog_Visivel.AutoSize = true;
            this.chkLog_Visivel.Location = new System.Drawing.Point(690, 73);
            this.chkLog_Visivel.Name = "chkLog_Visivel";
            this.chkLog_Visivel.Size = new System.Drawing.Size(78, 17);
            this.chkLog_Visivel.TabIndex = 6;
            this.chkLog_Visivel.Text = "Log visível";
            this.chkLog_Visivel.UseVisualStyleBackColor = true;
            // 
            // log_geracao
            // 
            this.log_geracao.AutoSize = true;
            this.log_geracao.Dock = System.Windows.Forms.DockStyle.Fill;
            this.log_geracao.Location = new System.Drawing.Point(3, 16);
            this.log_geracao.Name = "log_geracao";
            this.log_geracao.Size = new System.Drawing.Size(0, 13);
            this.log_geracao.TabIndex = 1;
            this.log_geracao.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox10
            // 
            this.groupBox10.Controls.Add(this.upCaracteres_por_Palavra);
            this.groupBox10.Location = new System.Drawing.Point(8, 66);
            this.groupBox10.Name = "groupBox10";
            this.groupBox10.Size = new System.Drawing.Size(216, 48);
            this.groupBox10.TabIndex = 4;
            this.groupBox10.TabStop = false;
            this.groupBox10.Text = "Máximo de caracteres por palavra:(1-10)";
            // 
            // upCaracteres_por_Palavra
            // 
            this.upCaracteres_por_Palavra.Location = new System.Drawing.Point(11, 19);
            this.upCaracteres_por_Palavra.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.upCaracteres_por_Palavra.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.upCaracteres_por_Palavra.Name = "upCaracteres_por_Palavra";
            this.upCaracteres_por_Palavra.Size = new System.Drawing.Size(199, 20);
            this.upCaracteres_por_Palavra.TabIndex = 0;
            this.upCaracteres_por_Palavra.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.upCaracteres_por_Palavra.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.upCaracteres_por_Palavra.ValueChanged += new System.EventHandler(this.upCaracteres_por_Palavra_ValueChanged);
            // 
            // groupBox9
            // 
            this.groupBox9.Controls.Add(this.upLinhas_por_Arquivo);
            this.groupBox9.Location = new System.Drawing.Point(513, 66);
            this.groupBox9.Name = "groupBox9";
            this.groupBox9.Size = new System.Drawing.Size(188, 48);
            this.groupBox9.TabIndex = 3;
            this.groupBox9.TabStop = false;
            this.groupBox9.Text = "Quantidade de linhas por arquivo:";
            // 
            // upLinhas_por_Arquivo
            // 
            this.upLinhas_por_Arquivo.Increment = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.upLinhas_por_Arquivo.Location = new System.Drawing.Point(11, 19);
            this.upLinhas_por_Arquivo.Maximum = new decimal(new int[] {
            500000000,
            0,
            0,
            0});
            this.upLinhas_por_Arquivo.Minimum = new decimal(new int[] {
            500000,
            0,
            0,
            0});
            this.upLinhas_por_Arquivo.Name = "upLinhas_por_Arquivo";
            this.upLinhas_por_Arquivo.Size = new System.Drawing.Size(171, 20);
            this.upLinhas_por_Arquivo.TabIndex = 0;
            this.upLinhas_por_Arquivo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.upLinhas_por_Arquivo.Value = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.upLinhas_por_Arquivo.ValueChanged += new System.EventHandler(this.upLinhas_por_Arquivo_ValueChanged);
            // 
            // btnParar
            // 
            this.btnParar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnParar.Location = new System.Drawing.Point(813, 95);
            this.btnParar.Name = "btnParar";
            this.btnParar.Size = new System.Drawing.Size(75, 23);
            this.btnParar.TabIndex = 2;
            this.btnParar.Text = "&Parar...";
            this.btnParar.UseVisualStyleBackColor = true;
            this.btnParar.Click += new System.EventHandler(this.btnParar_Click);
            // 
            // btnGerar
            // 
            this.btnGerar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGerar.Location = new System.Drawing.Point(813, 66);
            this.btnGerar.Name = "btnGerar";
            this.btnGerar.Size = new System.Drawing.Size(75, 23);
            this.btnGerar.TabIndex = 1;
            this.btnGerar.Text = "&Gerar";
            this.btnGerar.UseVisualStyleBackColor = true;
            this.btnGerar.Click += new System.EventHandler(this.btnGerar_Click);
            // 
            // groupBox8
            // 
            this.groupBox8.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox8.Controls.Add(this.btnAbrir_Diretorio);
            this.groupBox8.Controls.Add(this.txtDiretorio);
            this.groupBox8.Location = new System.Drawing.Point(8, 11);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(886, 49);
            this.groupBox8.TabIndex = 0;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "&Diretório de destino: (automaticamente será criado um subdiretório no formato: Y" +
    "YYYMMDD_HHNNSS";
            // 
            // btnAbrir_Diretorio
            // 
            this.btnAbrir_Diretorio.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAbrir_Diretorio.Location = new System.Drawing.Point(805, 16);
            this.btnAbrir_Diretorio.Name = "btnAbrir_Diretorio";
            this.btnAbrir_Diretorio.Size = new System.Drawing.Size(75, 23);
            this.btnAbrir_Diretorio.TabIndex = 1;
            this.btnAbrir_Diretorio.Text = "&Abrir...";
            this.btnAbrir_Diretorio.UseVisualStyleBackColor = true;
            this.btnAbrir_Diretorio.Click += new System.EventHandler(this.btnAbrir_Diretorio_Click);
            // 
            // txtDiretorio
            // 
            this.txtDiretorio.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDiretorio.Location = new System.Drawing.Point(6, 19);
            this.txtDiretorio.Name = "txtDiretorio";
            this.txtDiretorio.Size = new System.Drawing.Size(793, 20);
            this.txtDiretorio.TabIndex = 0;
            this.txtDiretorio.TextChanged += new System.EventHandler(this.txtDiretorio_TextChanged);
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(898, 543);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Continuar de onde parou";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.WorkerReportsProgress = true;
            this.backgroundWorker1.WorkerSupportsCancellation = true;
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.backgroundWorker1.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorker1_ProgressChanged);
            this.backgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker1_RunWorkerCompleted);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(909, 637);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.statusStrip1);
            this.Name = "Form1";
            this.Text = "Gerador de Palavras";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.groupBox12.ResumeLayout(false);
            this.groupBox12.PerformLayout();
            this.groupBox7.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.groupBox11.ResumeLayout(false);
            this.groupBox11.PerformLayout();
            this.groupBox10.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.upCaracteres_por_Palavra)).EndInit();
            this.groupBox9.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.upLinhas_por_Arquivo)).EndInit();
            this.groupBox8.ResumeLayout(false);
            this.groupBox8.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.CheckedListBox lskPontuacao;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.CheckedListBox lskSimbolo;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.CheckedListBox lskMaiuscula;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.CheckedListBox lskMinuscula;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckedListBox lskDigitos;
        private System.Windows.Forms.Button btnMarcar_Digitos;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btnDesmarcar_Pontuacao;
        private System.Windows.Forms.Button btnDesmarcar_Maiuscula;
        private System.Windows.Forms.Button btnDesmarcar_Simbolo;
        private System.Windows.Forms.Button btnDesmarcar_Digito;
        private System.Windows.Forms.Button btnDesmarcar_Minuscula;
        private System.Windows.Forms.Button btnMarcar_Minuscula;
        private System.Windows.Forms.Button btnMarcar_Maiuscula;
        private System.Windows.Forms.Button btnMarcar_Simbolo;
        private System.Windows.Forms.Button btnMarcar_Pontuacao;
        private System.Windows.Forms.Label rotulo_dos_caracteres;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckedListBox lskMinuscula_az;
        private System.Windows.Forms.Button btnDesmarcar_Minuscula_az;
        private System.Windows.Forms.Button btnMarcar_Minuscula_az;
        private System.Windows.Forms.Button btnDesmarcar_Maiuscula_az;
        private System.Windows.Forms.Button btnMarcar_Maiuscula_az;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.CheckedListBox lskMaiuscula_az;
        private System.Windows.Forms.CheckBox chkOrdenar_Ascii;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.TextBox txtDiretorio;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button btnAbrir_Diretorio;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button btnGerar;
        private System.Windows.Forms.Button btnParar;
        private System.Windows.Forms.FolderBrowserDialog dlgDiretorio;
        private System.Windows.Forms.GroupBox groupBox9;
        private System.Windows.Forms.NumericUpDown upLinhas_por_Arquivo;
        private System.Windows.Forms.GroupBox groupBox10;
        private System.Windows.Forms.NumericUpDown upCaracteres_por_Palavra;
        private System.Windows.Forms.GroupBox groupBox11;
        private System.Windows.Forms.Label log_geracao;
        private System.Windows.Forms.CheckBox chkLog_Visivel;
        private System.Windows.Forms.GroupBox groupBox12;
        private System.Windows.Forms.TextBox txtCaracteres_Selecionados;
    }
}

