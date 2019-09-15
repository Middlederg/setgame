namespace Set.Forms.Views
{
    partial class MainView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainView));
            this.InfoCards = new System.Windows.Forms.Label();
            this.InfoMistakes = new System.Windows.Forms.Label();
            this.InfoSets = new System.Windows.Forms.Label();
            this.panelTiempo = new System.Windows.Forms.Panel();
            this.LblTiempo = new System.Windows.Forms.Label();
            this.Info = new System.Windows.Forms.Label();
            this.pCartas = new System.Windows.Forms.Panel();
            this.timerTiempo = new System.Windows.Forms.Timer(this.components);
            this.TlpPrincipal = new System.Windows.Forms.TableLayoutPanel();
            this.LblRaya = new System.Windows.Forms.Label();
            this.LblTitulo = new System.Windows.Forms.Label();
            this.FlpBotonesArriba = new System.Windows.Forms.FlowLayoutPanel();
            this.BtnClose = new FontAwesome.Sharp.IconButton();
            this.BtnMin = new FontAwesome.Sharp.IconButton();
            this.FlpBotones = new System.Windows.Forms.FlowLayoutPanel();
            this.LvwLog = new System.Windows.Forms.ListView();
            this.PositionsList = new Set.Forms.UserControls.UcClasificacion();
            this.BtnHelp = new Set.Forms.CustomIconButton();
            this.BtnHowMany = new Set.Forms.CustomIconButton();
            this.BtnCheck = new Set.Forms.CustomIconButton();
            this.panelTiempo.SuspendLayout();
            this.TlpPrincipal.SuspendLayout();
            this.FlpBotonesArriba.SuspendLayout();
            this.SuspendLayout();
            // 
            // InfoCards
            // 
            this.InfoCards.BackColor = System.Drawing.Color.Transparent;
            this.InfoCards.Dock = System.Windows.Forms.DockStyle.Fill;
            this.InfoCards.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InfoCards.Location = new System.Drawing.Point(20, 642);
            this.InfoCards.Margin = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.InfoCards.Name = "InfoCards";
            this.InfoCards.Size = new System.Drawing.Size(259, 20);
            this.InfoCards.TabIndex = 4;
            this.InfoCards.Text = "Cartas restantes: 0";
            this.InfoCards.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // InfoMistakes
            // 
            this.InfoMistakes.BackColor = System.Drawing.Color.Transparent;
            this.InfoMistakes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.InfoMistakes.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InfoMistakes.Location = new System.Drawing.Point(20, 622);
            this.InfoMistakes.Margin = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.InfoMistakes.Name = "InfoMistakes";
            this.InfoMistakes.Size = new System.Drawing.Size(259, 20);
            this.InfoMistakes.TabIndex = 4;
            this.InfoMistakes.Text = "Fallos cometidos: 0";
            this.InfoMistakes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // InfoSets
            // 
            this.InfoSets.BackColor = System.Drawing.Color.Transparent;
            this.InfoSets.Dock = System.Windows.Forms.DockStyle.Fill;
            this.InfoSets.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InfoSets.Location = new System.Drawing.Point(20, 602);
            this.InfoSets.Margin = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.InfoSets.Name = "InfoSets";
            this.InfoSets.Size = new System.Drawing.Size(259, 20);
            this.InfoSets.TabIndex = 4;
            this.InfoSets.Text = "Sets encontrados: 0";
            this.InfoSets.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
            // Info
            // 
            this.Info.BackColor = System.Drawing.Color.Transparent;
            this.TlpPrincipal.SetColumnSpan(this.Info, 4);
            this.Info.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Info.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Info.Location = new System.Drawing.Point(20, 587);
            this.Info.Margin = new System.Windows.Forms.Padding(20, 5, 20, 0);
            this.Info.Name = "Info";
            this.Info.Size = new System.Drawing.Size(679, 15);
            this.Info.TabIndex = 3;
            this.Info.Text = "label1";
            this.Info.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pCartas
            // 
            this.pCartas.BackColor = System.Drawing.Color.Transparent;
            this.pCartas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TlpPrincipal.SetColumnSpan(this.pCartas, 4);
            this.pCartas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pCartas.Location = new System.Drawing.Point(20, 72);
            this.pCartas.Margin = new System.Windows.Forms.Padding(20, 0, 20, 5);
            this.pCartas.Name = "pCartas";
            this.TlpPrincipal.SetRowSpan(this.pCartas, 2);
            this.pCartas.Size = new System.Drawing.Size(679, 505);
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
            this.TlpPrincipal.ColumnCount = 5;
            this.TlpPrincipal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 49.99999F));
            this.TlpPrincipal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.00002F));
            this.TlpPrincipal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.TlpPrincipal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.TlpPrincipal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 343F));
            this.TlpPrincipal.Controls.Add(this.LblRaya, 0, 1);
            this.TlpPrincipal.Controls.Add(this.LblTitulo, 0, 0);
            this.TlpPrincipal.Controls.Add(this.InfoMistakes, 0, 7);
            this.TlpPrincipal.Controls.Add(this.InfoSets, 0, 6);
            this.TlpPrincipal.Controls.Add(this.InfoCards, 0, 8);
            this.TlpPrincipal.Controls.Add(this.pCartas, 0, 3);
            this.TlpPrincipal.Controls.Add(this.Info, 0, 5);
            this.TlpPrincipal.Controls.Add(this.FlpBotonesArriba, 1, 0);
            this.TlpPrincipal.Controls.Add(this.panelTiempo, 0, 2);
            this.TlpPrincipal.Controls.Add(this.FlpBotones, 3, 2);
            this.TlpPrincipal.Controls.Add(this.LvwLog, 4, 4);
            this.TlpPrincipal.Controls.Add(this.PositionsList, 4, 2);
            this.TlpPrincipal.Controls.Add(this.BtnHelp, 3, 7);
            this.TlpPrincipal.Controls.Add(this.BtnHowMany, 2, 7);
            this.TlpPrincipal.Controls.Add(this.BtnCheck, 1, 7);
            this.TlpPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TlpPrincipal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(52)))), ((int)(((byte)(54)))));
            this.TlpPrincipal.Location = new System.Drawing.Point(0, 0);
            this.TlpPrincipal.Name = "TlpPrincipal";
            this.TlpPrincipal.RowCount = 10;
            this.TlpPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.TlpPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 2F));
            this.TlpPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.TlpPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TlpPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TlpPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.TlpPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.TlpPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.TlpPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.TlpPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 15F));
            this.TlpPrincipal.Size = new System.Drawing.Size(1063, 678);
            this.TlpPrincipal.TabIndex = 1;
            // 
            // LblRaya
            // 
            this.LblRaya.AutoSize = true;
            this.LblRaya.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(52)))), ((int)(((byte)(54)))));
            this.TlpPrincipal.SetColumnSpan(this.LblRaya, 5);
            this.LblRaya.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LblRaya.Location = new System.Drawing.Point(20, 30);
            this.LblRaya.Margin = new System.Windows.Forms.Padding(20, 0, 20, 0);
            this.LblRaya.Name = "LblRaya";
            this.LblRaya.Size = new System.Drawing.Size(1023, 2);
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
            this.LblTitulo.Size = new System.Drawing.Size(259, 30);
            this.LblTitulo.TabIndex = 6;
            this.LblTitulo.Text = "Set Game";
            this.LblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // FlpBotonesArriba
            // 
            this.FlpBotonesArriba.BackColor = System.Drawing.Color.Transparent;
            this.TlpPrincipal.SetColumnSpan(this.FlpBotonesArriba, 4);
            this.FlpBotonesArriba.Controls.Add(this.BtnClose);
            this.FlpBotonesArriba.Controls.Add(this.BtnMin);
            this.FlpBotonesArriba.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FlpBotonesArriba.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.FlpBotonesArriba.Location = new System.Drawing.Point(279, 0);
            this.FlpBotonesArriba.Margin = new System.Windows.Forms.Padding(0, 0, 20, 0);
            this.FlpBotonesArriba.Name = "FlpBotonesArriba";
            this.FlpBotonesArriba.Size = new System.Drawing.Size(764, 30);
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
            this.BtnClose.Location = new System.Drawing.Point(734, 0);
            this.BtnClose.Margin = new System.Windows.Forms.Padding(0);
            this.BtnClose.Name = "BtnClose";
            this.BtnClose.Rotation = 0D;
            this.BtnClose.Size = new System.Drawing.Size(30, 30);
            this.BtnClose.TabIndex = 0;
            this.BtnClose.UseVisualStyleBackColor = false;
            this.BtnClose.Click += new System.EventHandler(this.OnCloseClicked);
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
            this.BtnMin.Location = new System.Drawing.Point(704, 0);
            this.BtnMin.Margin = new System.Windows.Forms.Padding(0);
            this.BtnMin.Name = "BtnMin";
            this.BtnMin.Rotation = 0D;
            this.BtnMin.Size = new System.Drawing.Size(30, 30);
            this.BtnMin.TabIndex = 2;
            this.BtnMin.UseVisualStyleBackColor = false;
            this.BtnMin.Click += new System.EventHandler(this.OnMinimizeClicked);
            // 
            // FlpBotones
            // 
            this.FlpBotones.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FlpBotones.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.FlpBotones.Location = new System.Drawing.Point(639, 32);
            this.FlpBotones.Margin = new System.Windows.Forms.Padding(0, 0, 20, 0);
            this.FlpBotones.Name = "FlpBotones";
            this.FlpBotones.Size = new System.Drawing.Size(60, 40);
            this.FlpBotones.TabIndex = 8;
            // 
            // LvwLog
            // 
            this.LvwLog.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LvwLog.Location = new System.Drawing.Point(719, 342);
            this.LvwLog.Margin = new System.Windows.Forms.Padding(0, 15, 20, 0);
            this.LvwLog.Name = "LvwLog";
            this.TlpPrincipal.SetRowSpan(this.LvwLog, 5);
            this.LvwLog.Size = new System.Drawing.Size(324, 320);
            this.LvwLog.TabIndex = 9;
            this.LvwLog.UseCompatibleStateImageBehavior = false;
            this.LvwLog.View = System.Windows.Forms.View.Details;
            // 
            // PositionsList
            // 
            this.PositionsList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PositionsList.Location = new System.Drawing.Point(719, 32);
            this.PositionsList.Margin = new System.Windows.Forms.Padding(0, 0, 20, 0);
            this.PositionsList.Name = "PositionsList";
            this.TlpPrincipal.SetRowSpan(this.PositionsList, 2);
            this.PositionsList.Size = new System.Drawing.Size(324, 295);
            this.PositionsList.TabIndex = 10;
            // 
            // BtnHelp
            // 
            this.BtnHelp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(52)))), ((int)(((byte)(54)))));
            this.BtnHelp.FlatAppearance.BorderSize = 0;
            this.BtnHelp.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(110)))), ((int)(((byte)(114)))));
            this.BtnHelp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnHelp.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.BtnHelp.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold);
            this.BtnHelp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(236)))), ((int)(((byte)(236)))));
            this.BtnHelp.IconChar = FontAwesome.Sharp.IconChar.QuestionCircle;
            this.BtnHelp.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(236)))), ((int)(((byte)(236)))));
            this.BtnHelp.IconSize = 36;
            this.BtnHelp.Location = new System.Drawing.Point(639, 622);
            this.BtnHelp.Margin = new System.Windows.Forms.Padding(0);
            this.BtnHelp.Name = "BtnHelp";
            this.BtnHelp.Rotation = 0D;
            this.TlpPrincipal.SetRowSpan(this.BtnHelp, 2);
            this.BtnHelp.Size = new System.Drawing.Size(60, 40);
            this.BtnHelp.TabIndex = 13;
            this.BtnHelp.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnHelp.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnHelp.UseVisualStyleBackColor = false;
            this.BtnHelp.Click += new System.EventHandler(this.OnHelpClickedAsync);
            // 
            // BtnHowMany
            // 
            this.BtnHowMany.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(52)))), ((int)(((byte)(54)))));
            this.BtnHowMany.FlatAppearance.BorderSize = 0;
            this.BtnHowMany.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(110)))), ((int)(((byte)(114)))));
            this.BtnHowMany.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnHowMany.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.BtnHowMany.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold);
            this.BtnHowMany.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(236)))), ((int)(((byte)(236)))));
            this.BtnHowMany.IconChar = FontAwesome.Sharp.IconChar.InfoCircle;
            this.BtnHowMany.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(236)))), ((int)(((byte)(236)))));
            this.BtnHowMany.IconSize = 36;
            this.BtnHowMany.Location = new System.Drawing.Point(559, 622);
            this.BtnHowMany.Margin = new System.Windows.Forms.Padding(0);
            this.BtnHowMany.Name = "BtnHowMany";
            this.BtnHowMany.Rotation = 0D;
            this.TlpPrincipal.SetRowSpan(this.BtnHowMany, 2);
            this.BtnHowMany.Size = new System.Drawing.Size(60, 40);
            this.BtnHowMany.TabIndex = 12;
            this.BtnHowMany.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnHowMany.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnHowMany.UseVisualStyleBackColor = false;
            this.BtnHowMany.Click += new System.EventHandler(this.OnHowManyButtonClickedAsync);
            // 
            // BtnCheck
            // 
            this.BtnCheck.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(52)))), ((int)(((byte)(54)))));
            this.BtnCheck.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnCheck.FlatAppearance.BorderSize = 0;
            this.BtnCheck.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(110)))), ((int)(((byte)(114)))));
            this.BtnCheck.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCheck.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.BtnCheck.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold);
            this.BtnCheck.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(236)))), ((int)(((byte)(236)))));
            this.BtnCheck.IconChar = FontAwesome.Sharp.IconChar.Play;
            this.BtnCheck.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(236)))), ((int)(((byte)(236)))));
            this.BtnCheck.IconSize = 30;
            this.BtnCheck.Location = new System.Drawing.Point(279, 622);
            this.BtnCheck.Margin = new System.Windows.Forms.Padding(0, 0, 20, 0);
            this.BtnCheck.Name = "BtnCheck";
            this.BtnCheck.Rotation = 0D;
            this.TlpPrincipal.SetRowSpan(this.BtnCheck, 2);
            this.BtnCheck.Size = new System.Drawing.Size(260, 40);
            this.BtnCheck.TabIndex = 11;
            this.BtnCheck.Text = "Comprobar SET";
            this.BtnCheck.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnCheck.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnCheck.UseVisualStyleBackColor = false;
            this.BtnCheck.Click += new System.EventHandler(this.OnCheckButtonClicked);
            // 
            // MainView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1063, 678);
            this.ControlBox = false;
            this.Controls.Add(this.TlpPrincipal);
            this.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Set Game";
            this.panelTiempo.ResumeLayout(false);
            this.TlpPrincipal.ResumeLayout(false);
            this.TlpPrincipal.PerformLayout();
            this.FlpBotonesArriba.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pCartas;
        private System.Windows.Forms.Label Info;
        private System.Windows.Forms.Panel panelTiempo;
        private System.Windows.Forms.Label LblTiempo;
        private System.Windows.Forms.Timer timerTiempo;
        private System.Windows.Forms.Label InfoSets;
        private System.Windows.Forms.Label InfoMistakes;
        private System.Windows.Forms.Label InfoCards;
        private System.Windows.Forms.TableLayoutPanel TlpPrincipal;
        private System.Windows.Forms.FlowLayoutPanel FlpBotonesArriba;
        private FontAwesome.Sharp.IconButton BtnClose;
        private FontAwesome.Sharp.IconButton BtnMin;
        private System.Windows.Forms.Label LblTitulo;
        private System.Windows.Forms.Label LblRaya;
        private System.Windows.Forms.FlowLayoutPanel FlpBotones;
        private System.Windows.Forms.ListView LvwLog;
        private UserControls.UcClasificacion PositionsList;
        private CustomIconButton BtnCheck;
        private CustomIconButton BtnHowMany;
        private CustomIconButton BtnHelp;
    }
}

