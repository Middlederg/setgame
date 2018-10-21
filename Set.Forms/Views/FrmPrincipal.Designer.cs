namespace Set.Forms.Views
{
    partial class FrmPrincipal
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPrincipal));
            this.lbNumCartas = new System.Windows.Forms.Label();
            this.lbPuntos = new System.Windows.Forms.Label();
            this.lbnumsets = new System.Windows.Forms.Label();
            this.panelTiempo = new System.Windows.Forms.Panel();
            this.LblTiempo = new System.Windows.Forms.Label();
            this.lbInfo = new System.Windows.Forms.Label();
            this.pCartas = new System.Windows.Forms.Panel();
            this.timerTiempo = new System.Windows.Forms.Timer(this.components);
            this.TlpPrincipal = new System.Windows.Forms.TableLayoutPanel();
            this.LblRaya = new System.Windows.Forms.Label();
            this.LblTitulo = new System.Windows.Forms.Label();
            this.BtnRendirse = new System.Windows.Forms.Button();
            this.BtnNoSets = new System.Windows.Forms.Button();
            this.BtnComprobarSet = new System.Windows.Forms.Button();
            this.FlpBotonesArriba = new System.Windows.Forms.FlowLayoutPanel();
            this.BtnClose = new FontAwesome.Sharp.IconButton();
            this.BtnMin = new FontAwesome.Sharp.IconButton();
            this.FlpBotones = new System.Windows.Forms.FlowLayoutPanel();
            this.BtnLog = new System.Windows.Forms.Button();
            this.BtnClasificacion = new System.Windows.Forms.Button();
            this.panelTiempo.SuspendLayout();
            this.TlpPrincipal.SuspendLayout();
            this.FlpBotonesArriba.SuspendLayout();
            this.FlpBotones.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbNumCartas
            // 
            this.lbNumCartas.BackColor = System.Drawing.Color.Transparent;
            this.lbNumCartas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbNumCartas.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNumCartas.Location = new System.Drawing.Point(20, 603);
            this.lbNumCartas.Margin = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.lbNumCartas.Name = "lbNumCartas";
            this.lbNumCartas.Size = new System.Drawing.Size(220, 20);
            this.lbNumCartas.TabIndex = 4;
            this.lbNumCartas.Text = "Cartas: 0";
            this.lbNumCartas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbPuntos
            // 
            this.lbPuntos.BackColor = System.Drawing.Color.Transparent;
            this.lbPuntos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbPuntos.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPuntos.Location = new System.Drawing.Point(20, 643);
            this.lbPuntos.Margin = new System.Windows.Forms.Padding(20, 0, 0, 5);
            this.lbPuntos.Name = "lbPuntos";
            this.lbPuntos.Size = new System.Drawing.Size(220, 15);
            this.lbPuntos.TabIndex = 4;
            this.lbPuntos.Text = "Puntuación: 0";
            this.lbPuntos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbnumsets
            // 
            this.lbnumsets.BackColor = System.Drawing.Color.Transparent;
            this.lbnumsets.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbnumsets.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbnumsets.Location = new System.Drawing.Point(20, 623);
            this.lbnumsets.Margin = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.lbnumsets.Name = "lbnumsets";
            this.lbnumsets.Size = new System.Drawing.Size(220, 20);
            this.lbnumsets.TabIndex = 4;
            this.lbnumsets.Text = "Sets: 0";
            this.lbnumsets.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panelTiempo
            // 
            this.panelTiempo.BackColor = System.Drawing.Color.Transparent;
            this.panelTiempo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelTiempo.Controls.Add(this.LblTiempo);
            this.panelTiempo.Location = new System.Drawing.Point(20, 42);
            this.panelTiempo.Margin = new System.Windows.Forms.Padding(20, 10, 0, 0);
            this.panelTiempo.Name = "panelTiempo";
            this.panelTiempo.Size = new System.Drawing.Size(89, 30);
            this.panelTiempo.TabIndex = 5;
            // 
            // LblTiempo
            // 
            this.LblTiempo.BackColor = System.Drawing.Color.Transparent;
            this.LblTiempo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LblTiempo.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTiempo.Location = new System.Drawing.Point(0, 0);
            this.LblTiempo.Name = "LblTiempo";
            this.LblTiempo.Size = new System.Drawing.Size(87, 28);
            this.LblTiempo.TabIndex = 4;
            this.LblTiempo.Text = "00:00";
            this.LblTiempo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbInfo
            // 
            this.lbInfo.BackColor = System.Drawing.Color.Transparent;
            this.TlpPrincipal.SetColumnSpan(this.lbInfo, 2);
            this.lbInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbInfo.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbInfo.Location = new System.Drawing.Point(20, 588);
            this.lbInfo.Margin = new System.Windows.Forms.Padding(20, 5, 5, 0);
            this.lbInfo.Name = "lbInfo";
            this.lbInfo.Size = new System.Drawing.Size(456, 15);
            this.lbInfo.TabIndex = 3;
            this.lbInfo.Text = "label1";
            this.lbInfo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pCartas
            // 
            this.pCartas.BackColor = System.Drawing.Color.Transparent;
            this.pCartas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TlpPrincipal.SetColumnSpan(this.pCartas, 3);
            this.pCartas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pCartas.Location = new System.Drawing.Point(20, 72);
            this.pCartas.Margin = new System.Windows.Forms.Padding(20, 0, 20, 5);
            this.pCartas.Name = "pCartas";
            this.pCartas.Size = new System.Drawing.Size(683, 506);
            this.pCartas.TabIndex = 1;
            // 
            // timerTiempo
            // 
            this.timerTiempo.Enabled = true;
            this.timerTiempo.Interval = 1000;
            this.timerTiempo.Tick += new System.EventHandler(this.TimerTiempo_Tick);
            // 
            // TlpPrincipal
            // 
            this.TlpPrincipal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(230)))), ((int)(((byte)(233)))));
            this.TlpPrincipal.ColumnCount = 3;
            this.TlpPrincipal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33332F));
            this.TlpPrincipal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.TlpPrincipal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.TlpPrincipal.Controls.Add(this.LblRaya, 0, 1);
            this.TlpPrincipal.Controls.Add(this.LblTitulo, 0, 0);
            this.TlpPrincipal.Controls.Add(this.lbPuntos, 0, 7);
            this.TlpPrincipal.Controls.Add(this.lbnumsets, 0, 6);
            this.TlpPrincipal.Controls.Add(this.lbNumCartas, 0, 5);
            this.TlpPrincipal.Controls.Add(this.BtnRendirse, 2, 6);
            this.TlpPrincipal.Controls.Add(this.pCartas, 0, 3);
            this.TlpPrincipal.Controls.Add(this.BtnNoSets, 1, 6);
            this.TlpPrincipal.Controls.Add(this.lbInfo, 0, 4);
            this.TlpPrincipal.Controls.Add(this.BtnComprobarSet, 2, 4);
            this.TlpPrincipal.Controls.Add(this.FlpBotonesArriba, 1, 0);
            this.TlpPrincipal.Controls.Add(this.panelTiempo, 0, 2);
            this.TlpPrincipal.Controls.Add(this.FlpBotones, 2, 2);
            this.TlpPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TlpPrincipal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(52)))), ((int)(((byte)(54)))));
            this.TlpPrincipal.Location = new System.Drawing.Point(0, 0);
            this.TlpPrincipal.Name = "TlpPrincipal";
            this.TlpPrincipal.RowCount = 9;
            this.TlpPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.TlpPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 2F));
            this.TlpPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.TlpPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TlpPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.TlpPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.TlpPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.TlpPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.TlpPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 15F));
            this.TlpPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.TlpPrincipal.Size = new System.Drawing.Size(723, 678);
            this.TlpPrincipal.TabIndex = 1;
            // 
            // LblRaya
            // 
            this.LblRaya.AutoSize = true;
            this.LblRaya.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(52)))), ((int)(((byte)(54)))));
            this.TlpPrincipal.SetColumnSpan(this.LblRaya, 3);
            this.LblRaya.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LblRaya.Location = new System.Drawing.Point(20, 30);
            this.LblRaya.Margin = new System.Windows.Forms.Padding(20, 0, 20, 0);
            this.LblRaya.Name = "LblRaya";
            this.LblRaya.Size = new System.Drawing.Size(683, 2);
            this.LblRaya.TabIndex = 2;
            this.LblRaya.Text = "label1";
            // 
            // LblTitulo
            // 
            this.LblTitulo.AutoSize = true;
            this.LblTitulo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LblTitulo.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTitulo.Location = new System.Drawing.Point(20, 0);
            this.LblTitulo.Margin = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.LblTitulo.Name = "LblTitulo";
            this.LblTitulo.Size = new System.Drawing.Size(220, 30);
            this.LblTitulo.TabIndex = 6;
            this.LblTitulo.Text = "Set Game";
            this.LblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // BtnRendirse
            // 
            this.BtnRendirse.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(52)))), ((int)(((byte)(54)))));
            this.BtnRendirse.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnRendirse.FlatAppearance.BorderSize = 0;
            this.BtnRendirse.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(110)))), ((int)(((byte)(114)))));
            this.BtnRendirse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnRendirse.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnRendirse.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(236)))), ((int)(((byte)(236)))));
            this.BtnRendirse.Location = new System.Drawing.Point(486, 628);
            this.BtnRendirse.Margin = new System.Windows.Forms.Padding(5, 5, 20, 5);
            this.BtnRendirse.Name = "BtnRendirse";
            this.TlpPrincipal.SetRowSpan(this.BtnRendirse, 2);
            this.BtnRendirse.Size = new System.Drawing.Size(217, 30);
            this.BtnRendirse.TabIndex = 4;
            this.BtnRendirse.Text = "Rendirse";
            this.BtnRendirse.UseVisualStyleBackColor = false;
            this.BtnRendirse.Click += new System.EventHandler(this.BtnRendirse_Click);
            // 
            // BtnNoSets
            // 
            this.BtnNoSets.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(52)))), ((int)(((byte)(54)))));
            this.BtnNoSets.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnNoSets.FlatAppearance.BorderSize = 0;
            this.BtnNoSets.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(110)))), ((int)(((byte)(114)))));
            this.BtnNoSets.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnNoSets.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnNoSets.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(236)))), ((int)(((byte)(236)))));
            this.BtnNoSets.Location = new System.Drawing.Point(260, 628);
            this.BtnNoSets.Margin = new System.Windows.Forms.Padding(20, 5, 5, 5);
            this.BtnNoSets.Name = "BtnNoSets";
            this.TlpPrincipal.SetRowSpan(this.BtnNoSets, 2);
            this.BtnNoSets.Size = new System.Drawing.Size(216, 30);
            this.BtnNoSets.TabIndex = 3;
            this.BtnNoSets.Text = "No hay sets";
            this.BtnNoSets.UseVisualStyleBackColor = false;
            this.BtnNoSets.Click += new System.EventHandler(this.BtnNoSets_Click);
            // 
            // BtnComprobarSet
            // 
            this.BtnComprobarSet.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(52)))), ((int)(((byte)(54)))));
            this.BtnComprobarSet.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnComprobarSet.FlatAppearance.BorderSize = 0;
            this.BtnComprobarSet.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(110)))), ((int)(((byte)(114)))));
            this.BtnComprobarSet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnComprobarSet.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnComprobarSet.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(236)))), ((int)(((byte)(236)))));
            this.BtnComprobarSet.Location = new System.Drawing.Point(486, 588);
            this.BtnComprobarSet.Margin = new System.Windows.Forms.Padding(5, 5, 20, 5);
            this.BtnComprobarSet.Name = "BtnComprobarSet";
            this.TlpPrincipal.SetRowSpan(this.BtnComprobarSet, 2);
            this.BtnComprobarSet.Size = new System.Drawing.Size(217, 30);
            this.BtnComprobarSet.TabIndex = 2;
            this.BtnComprobarSet.Text = "Comprobar set";
            this.BtnComprobarSet.UseVisualStyleBackColor = false;
            this.BtnComprobarSet.Click += new System.EventHandler(this.BtnComprobarSet_Click);
            // 
            // FlpBotonesArriba
            // 
            this.FlpBotonesArriba.BackColor = System.Drawing.Color.Transparent;
            this.TlpPrincipal.SetColumnSpan(this.FlpBotonesArriba, 2);
            this.FlpBotonesArriba.Controls.Add(this.BtnClose);
            this.FlpBotonesArriba.Controls.Add(this.BtnMin);
            this.FlpBotonesArriba.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FlpBotonesArriba.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.FlpBotonesArriba.Location = new System.Drawing.Point(240, 0);
            this.FlpBotonesArriba.Margin = new System.Windows.Forms.Padding(0, 0, 20, 0);
            this.FlpBotonesArriba.Name = "FlpBotonesArriba";
            this.FlpBotonesArriba.Size = new System.Drawing.Size(463, 30);
            this.FlpBotonesArriba.TabIndex = 5;
            // 
            // BtnClose
            // 
            this.BtnClose.BackColor = System.Drawing.Color.Transparent;
            this.BtnClose.FlatAppearance.BorderSize = 0;
            this.BtnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(204)))), ((int)(((byte)(192)))));
            this.BtnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnClose.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.BtnClose.IconChar = FontAwesome.Sharp.IconChar.Times;
            this.BtnClose.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(52)))), ((int)(((byte)(54)))));
            this.BtnClose.IconSize = 20;
            this.BtnClose.Location = new System.Drawing.Point(433, 0);
            this.BtnClose.Margin = new System.Windows.Forms.Padding(0);
            this.BtnClose.Name = "BtnClose";
            this.BtnClose.Rotation = 0D;
            this.BtnClose.Size = new System.Drawing.Size(30, 30);
            this.BtnClose.TabIndex = 0;
            this.BtnClose.UseVisualStyleBackColor = false;
            this.BtnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // BtnMin
            // 
            this.BtnMin.BackColor = System.Drawing.Color.Transparent;
            this.BtnMin.FlatAppearance.BorderSize = 0;
            this.BtnMin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(204)))), ((int)(((byte)(192)))));
            this.BtnMin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnMin.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.BtnMin.IconChar = FontAwesome.Sharp.IconChar.WindowMinimize;
            this.BtnMin.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(52)))), ((int)(((byte)(54)))));
            this.BtnMin.IconSize = 20;
            this.BtnMin.Location = new System.Drawing.Point(403, 0);
            this.BtnMin.Margin = new System.Windows.Forms.Padding(0);
            this.BtnMin.Name = "BtnMin";
            this.BtnMin.Rotation = 0D;
            this.BtnMin.Size = new System.Drawing.Size(30, 30);
            this.BtnMin.TabIndex = 2;
            this.BtnMin.UseVisualStyleBackColor = false;
            this.BtnMin.Click += new System.EventHandler(this.BtnMin_Click);
            // 
            // FlpBotones
            // 
            this.FlpBotones.Controls.Add(this.BtnLog);
            this.FlpBotones.Controls.Add(this.BtnClasificacion);
            this.FlpBotones.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FlpBotones.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.FlpBotones.Location = new System.Drawing.Point(481, 32);
            this.FlpBotones.Margin = new System.Windows.Forms.Padding(0, 0, 20, 0);
            this.FlpBotones.Name = "FlpBotones";
            this.FlpBotones.Size = new System.Drawing.Size(222, 40);
            this.FlpBotones.TabIndex = 8;
            // 
            // BtnLog
            // 
            this.BtnLog.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(52)))), ((int)(((byte)(54)))));
            this.BtnLog.FlatAppearance.BorderSize = 0;
            this.BtnLog.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(110)))), ((int)(((byte)(114)))));
            this.BtnLog.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnLog.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnLog.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(236)))), ((int)(((byte)(236)))));
            this.BtnLog.Location = new System.Drawing.Point(172, 15);
            this.BtnLog.Margin = new System.Windows.Forms.Padding(0, 15, 0, 0);
            this.BtnLog.Name = "BtnLog";
            this.BtnLog.Size = new System.Drawing.Size(50, 25);
            this.BtnLog.TabIndex = 7;
            this.BtnLog.Text = "Log";
            this.BtnLog.UseVisualStyleBackColor = false;
            this.BtnLog.Click += new System.EventHandler(this.BtnLog_Click);
            // 
            // BtnClasificacion
            // 
            this.BtnClasificacion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(52)))), ((int)(((byte)(54)))));
            this.BtnClasificacion.FlatAppearance.BorderSize = 0;
            this.BtnClasificacion.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(110)))), ((int)(((byte)(114)))));
            this.BtnClasificacion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnClasificacion.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnClasificacion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(236)))), ((int)(((byte)(236)))));
            this.BtnClasificacion.Location = new System.Drawing.Point(120, 15);
            this.BtnClasificacion.Margin = new System.Windows.Forms.Padding(0, 15, 2, 0);
            this.BtnClasificacion.Name = "BtnClasificacion";
            this.BtnClasificacion.Size = new System.Drawing.Size(50, 25);
            this.BtnClasificacion.TabIndex = 9;
            this.BtnClasificacion.Text = "Jug.";
            this.BtnClasificacion.UseVisualStyleBackColor = false;
            this.BtnClasificacion.Visible = false;
            this.BtnClasificacion.Click += new System.EventHandler(this.BtnClasificacion_Click);
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(723, 678);
            this.ControlBox = false;
            this.Controls.Add(this.TlpPrincipal);
            this.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Set Game";
            this.panelTiempo.ResumeLayout(false);
            this.TlpPrincipal.ResumeLayout(false);
            this.TlpPrincipal.PerformLayout();
            this.FlpBotonesArriba.ResumeLayout(false);
            this.FlpBotones.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pCartas;
        private System.Windows.Forms.Label lbInfo;
        private System.Windows.Forms.Panel panelTiempo;
        private System.Windows.Forms.Label LblTiempo;
        private System.Windows.Forms.Timer timerTiempo;
        private System.Windows.Forms.Label lbnumsets;
        private System.Windows.Forms.Label lbPuntos;
        private System.Windows.Forms.Label lbNumCartas;
        private System.Windows.Forms.TableLayoutPanel TlpPrincipal;
        private System.Windows.Forms.Button BtnComprobarSet;
        private System.Windows.Forms.Button BtnNoSets;
        private System.Windows.Forms.Button BtnRendirse;
        private System.Windows.Forms.FlowLayoutPanel FlpBotonesArriba;
        private FontAwesome.Sharp.IconButton BtnClose;
        private FontAwesome.Sharp.IconButton BtnMin;
        private System.Windows.Forms.Label LblTitulo;
        private System.Windows.Forms.Label LblRaya;
        private System.Windows.Forms.Button BtnLog;
        private System.Windows.Forms.FlowLayoutPanel FlpBotones;
        private System.Windows.Forms.Button BtnClasificacion;
    }
}

