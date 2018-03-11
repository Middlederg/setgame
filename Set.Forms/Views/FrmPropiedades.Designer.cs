namespace Set.Forms.Views
{
    partial class FrmPropiedades
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPropiedades));
            this.NudNumCartas = new System.Windows.Forms.NumericUpDown();
            this.CmbDificultad = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lbDif = new System.Windows.Forms.Label();
            this.lbTitulo = new System.Windows.Forms.Label();
            this.pPrincipal = new System.Windows.Forms.TableLayoutPanel();
            this.BtnVolver = new System.Windows.Forms.Button();
            this.BtnAceptar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.NudJugadores = new System.Windows.Forms.NumericUpDown();
            this.LvwNombres = new System.Windows.Forms.ListView();
            this.pGeneral = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.NudNumCartas)).BeginInit();
            this.pPrincipal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NudJugadores)).BeginInit();
            this.pGeneral.SuspendLayout();
            this.SuspendLayout();
            // 
            // NudNumCartas
            // 
            this.NudNumCartas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.NudNumCartas.Location = new System.Drawing.Point(209, 80);
            this.NudNumCartas.Margin = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.NudNumCartas.Maximum = new decimal(new int[] {
            81,
            0,
            0,
            0});
            this.NudNumCartas.Minimum = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.NudNumCartas.Name = "NudNumCartas";
            this.NudNumCartas.Size = new System.Drawing.Size(169, 26);
            this.NudNumCartas.TabIndex = 3;
            this.NudNumCartas.Value = new decimal(new int[] {
            27,
            0,
            0,
            0});
            // 
            // CmbDificultad
            // 
            this.CmbDificultad.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CmbDificultad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbDificultad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CmbDificultad.FormattingEnabled = true;
            this.CmbDificultad.Location = new System.Drawing.Point(209, 50);
            this.CmbDificultad.Margin = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.CmbDificultad.Name = "CmbDificultad";
            this.CmbDificultad.Size = new System.Drawing.Size(169, 27);
            this.CmbDificultad.TabIndex = 3;
            this.CmbDificultad.SelectedIndexChanged += new System.EventHandler(this.CmbDificultad_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(0, 80);
            this.label1.Margin = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(189, 30);
            this.label1.TabIndex = 1;
            this.label1.Text = "Número de cartas:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbDif
            // 
            this.lbDif.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbDif.Location = new System.Drawing.Point(0, 50);
            this.lbDif.Margin = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.lbDif.Name = "lbDif";
            this.lbDif.Size = new System.Drawing.Size(189, 30);
            this.lbDif.TabIndex = 1;
            this.lbDif.Text = "Dificultad:";
            this.lbDif.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbTitulo
            // 
            this.lbTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(52)))), ((int)(((byte)(54)))));
            this.lbTitulo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pPrincipal.SetColumnSpan(this.lbTitulo, 2);
            this.lbTitulo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbTitulo.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(236)))), ((int)(((byte)(236)))));
            this.lbTitulo.Location = new System.Drawing.Point(20, 0);
            this.lbTitulo.Margin = new System.Windows.Forms.Padding(20, 0, 20, 0);
            this.lbTitulo.Name = "lbTitulo";
            this.lbTitulo.Size = new System.Drawing.Size(358, 35);
            this.lbTitulo.TabIndex = 1;
            this.lbTitulo.Text = "Nueva partida";
            this.lbTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pPrincipal
            // 
            this.pPrincipal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(230)))), ((int)(((byte)(233)))));
            this.pPrincipal.ColumnCount = 2;
            this.pPrincipal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.pPrincipal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.pPrincipal.Controls.Add(this.label1, 0, 3);
            this.pPrincipal.Controls.Add(this.NudNumCartas, 1, 3);
            this.pPrincipal.Controls.Add(this.CmbDificultad, 1, 2);
            this.pPrincipal.Controls.Add(this.lbDif, 0, 2);
            this.pPrincipal.Controls.Add(this.lbTitulo, 0, 0);
            this.pPrincipal.Controls.Add(this.BtnVolver, 1, 7);
            this.pPrincipal.Controls.Add(this.BtnAceptar, 0, 7);
            this.pPrincipal.Controls.Add(this.label2, 0, 4);
            this.pPrincipal.Controls.Add(this.NudJugadores, 1, 4);
            this.pPrincipal.Controls.Add(this.LvwNombres, 0, 5);
            this.pPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pPrincipal.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pPrincipal.Location = new System.Drawing.Point(0, 0);
            this.pPrincipal.Name = "pPrincipal";
            this.pPrincipal.RowCount = 9;
            this.pPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.pPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 15F));
            this.pPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.pPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.pPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.pPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.pPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 15F));
            this.pPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.pPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 15F));
            this.pPrincipal.Size = new System.Drawing.Size(398, 298);
            this.pPrincipal.TabIndex = 4;
            // 
            // BtnVolver
            // 
            this.BtnVolver.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(52)))), ((int)(((byte)(54)))));
            this.BtnVolver.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnVolver.FlatAppearance.BorderSize = 0;
            this.BtnVolver.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(110)))), ((int)(((byte)(114)))));
            this.BtnVolver.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnVolver.Font = new System.Drawing.Font("Consolas", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnVolver.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(236)))), ((int)(((byte)(236)))));
            this.BtnVolver.Location = new System.Drawing.Point(209, 240);
            this.BtnVolver.Margin = new System.Windows.Forms.Padding(10, 5, 20, 5);
            this.BtnVolver.Name = "BtnVolver";
            this.BtnVolver.Size = new System.Drawing.Size(169, 40);
            this.BtnVolver.TabIndex = 1;
            this.BtnVolver.Text = "Volver";
            this.BtnVolver.UseVisualStyleBackColor = false;
            this.BtnVolver.Click += new System.EventHandler(this.BtnVolver_Click);
            // 
            // BtnAceptar
            // 
            this.BtnAceptar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(52)))), ((int)(((byte)(54)))));
            this.BtnAceptar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnAceptar.FlatAppearance.BorderSize = 0;
            this.BtnAceptar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(110)))), ((int)(((byte)(114)))));
            this.BtnAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAceptar.Font = new System.Drawing.Font("Consolas", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAceptar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(236)))), ((int)(((byte)(236)))));
            this.BtnAceptar.Location = new System.Drawing.Point(20, 240);
            this.BtnAceptar.Margin = new System.Windows.Forms.Padding(20, 5, 10, 5);
            this.BtnAceptar.Name = "BtnAceptar";
            this.BtnAceptar.Size = new System.Drawing.Size(169, 40);
            this.BtnAceptar.TabIndex = 1;
            this.BtnAceptar.Text = "Jugar";
            this.BtnAceptar.UseVisualStyleBackColor = false;
            this.BtnAceptar.Click += new System.EventHandler(this.BtnAceptar_Click);
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Location = new System.Drawing.Point(0, 110);
            this.label2.Margin = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(189, 30);
            this.label2.TabIndex = 4;
            this.label2.Text = "Jugadores:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // NudJugadores
            // 
            this.NudJugadores.Location = new System.Drawing.Point(209, 110);
            this.NudJugadores.Margin = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.NudJugadores.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.NudJugadores.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NudJugadores.Name = "NudJugadores";
            this.NudJugadores.Size = new System.Drawing.Size(169, 26);
            this.NudJugadores.TabIndex = 5;
            this.NudJugadores.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.NudJugadores.ValueChanged += new System.EventHandler(this.NudJugadores_ValueChanged);
            // 
            // LvwNombres
            // 
            this.pPrincipal.SetColumnSpan(this.LvwNombres, 2);
            this.LvwNombres.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LvwNombres.LabelEdit = true;
            this.LvwNombres.Location = new System.Drawing.Point(20, 150);
            this.LvwNombres.Margin = new System.Windows.Forms.Padding(20, 10, 20, 0);
            this.LvwNombres.MultiSelect = false;
            this.LvwNombres.Name = "LvwNombres";
            this.LvwNombres.Size = new System.Drawing.Size(358, 70);
            this.LvwNombres.TabIndex = 6;
            this.LvwNombres.UseCompatibleStateImageBehavior = false;
            this.LvwNombres.View = System.Windows.Forms.View.List;
            this.LvwNombres.AfterLabelEdit += new System.Windows.Forms.LabelEditEventHandler(this.LabelEditado);
            // 
            // pGeneral
            // 
            this.pGeneral.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pGeneral.Controls.Add(this.pPrincipal);
            this.pGeneral.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pGeneral.Location = new System.Drawing.Point(0, 0);
            this.pGeneral.Name = "pGeneral";
            this.pGeneral.Size = new System.Drawing.Size(400, 300);
            this.pGeneral.TabIndex = 5;
            // 
            // FrmPropiedades
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 300);
            this.ControlBox = false;
            this.Controls.Add(this.pGeneral);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmPropiedades";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Set Game";
            ((System.ComponentModel.ISupportInitialize)(this.NudNumCartas)).EndInit();
            this.pPrincipal.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.NudJugadores)).EndInit();
            this.pGeneral.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lbDif;
        private System.Windows.Forms.Label lbTitulo;
        private System.Windows.Forms.ComboBox CmbDificultad;
        private System.Windows.Forms.NumericUpDown NudNumCartas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TableLayoutPanel pPrincipal;
        private System.Windows.Forms.Button BtnVolver;
        private System.Windows.Forms.Button BtnAceptar;
        private System.Windows.Forms.Panel pGeneral;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown NudJugadores;
        private System.Windows.Forms.ListView LvwNombres;
    }
}