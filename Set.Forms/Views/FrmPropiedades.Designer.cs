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
            this.DudNumCartas = new System.Windows.Forms.NumericUpDown();
            this.CmbDificultad = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lbDif = new System.Windows.Forms.Label();
            this.lbTitulo = new System.Windows.Forms.Label();
            this.pPrincipal = new System.Windows.Forms.TableLayoutPanel();
            this.BtnVolver = new System.Windows.Forms.Button();
            this.BtnAceptar = new System.Windows.Forms.Button();
            this.pGeneral = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.DudNumCartas)).BeginInit();
            this.pPrincipal.SuspendLayout();
            this.pGeneral.SuspendLayout();
            this.SuspendLayout();
            // 
            // DudNumCartas
            // 
            this.DudNumCartas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DudNumCartas.Location = new System.Drawing.Point(210, 80);
            this.DudNumCartas.Margin = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.DudNumCartas.Maximum = new decimal(new int[] {
            81,
            0,
            0,
            0});
            this.DudNumCartas.Minimum = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.DudNumCartas.Name = "DudNumCartas";
            this.DudNumCartas.Size = new System.Drawing.Size(171, 26);
            this.DudNumCartas.TabIndex = 3;
            this.DudNumCartas.Value = new decimal(new int[] {
            12,
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
            this.CmbDificultad.Location = new System.Drawing.Point(210, 50);
            this.CmbDificultad.Margin = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.CmbDificultad.Name = "CmbDificultad";
            this.CmbDificultad.Size = new System.Drawing.Size(171, 27);
            this.CmbDificultad.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(0, 80);
            this.label1.Margin = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(190, 30);
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
            this.lbDif.Size = new System.Drawing.Size(190, 30);
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
            this.lbTitulo.Size = new System.Drawing.Size(361, 35);
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
            this.pPrincipal.Controls.Add(this.DudNumCartas, 1, 3);
            this.pPrincipal.Controls.Add(this.CmbDificultad, 1, 2);
            this.pPrincipal.Controls.Add(this.lbDif, 0, 2);
            this.pPrincipal.Controls.Add(this.lbTitulo, 0, 0);
            this.pPrincipal.Controls.Add(this.BtnVolver, 1, 5);
            this.pPrincipal.Controls.Add(this.BtnAceptar, 0, 5);
            this.pPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pPrincipal.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pPrincipal.Location = new System.Drawing.Point(0, 0);
            this.pPrincipal.Name = "pPrincipal";
            this.pPrincipal.RowCount = 7;
            this.pPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.pPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 15F));
            this.pPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.pPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.pPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 15F));
            this.pPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.pPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 15F));
            this.pPrincipal.Size = new System.Drawing.Size(401, 184);
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
            this.BtnVolver.Location = new System.Drawing.Point(210, 130);
            this.BtnVolver.Margin = new System.Windows.Forms.Padding(10, 5, 20, 5);
            this.BtnVolver.Name = "BtnVolver";
            this.BtnVolver.Size = new System.Drawing.Size(171, 40);
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
            this.BtnAceptar.Location = new System.Drawing.Point(20, 130);
            this.BtnAceptar.Margin = new System.Windows.Forms.Padding(20, 5, 10, 5);
            this.BtnAceptar.Name = "BtnAceptar";
            this.BtnAceptar.Size = new System.Drawing.Size(170, 40);
            this.BtnAceptar.TabIndex = 1;
            this.BtnAceptar.Text = "Jugar";
            this.BtnAceptar.UseVisualStyleBackColor = false;
            this.BtnAceptar.Click += new System.EventHandler(this.BtnAceptar_Click);
            // 
            // pGeneral
            // 
            this.pGeneral.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pGeneral.Controls.Add(this.pPrincipal);
            this.pGeneral.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pGeneral.Location = new System.Drawing.Point(0, 0);
            this.pGeneral.Name = "pGeneral";
            this.pGeneral.Size = new System.Drawing.Size(403, 186);
            this.pGeneral.TabIndex = 5;
            // 
            // FrmPropiedades
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(403, 186);
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
            ((System.ComponentModel.ISupportInitialize)(this.DudNumCartas)).EndInit();
            this.pPrincipal.ResumeLayout(false);
            this.pGeneral.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lbDif;
        private System.Windows.Forms.Label lbTitulo;
        private System.Windows.Forms.ComboBox CmbDificultad;
        private System.Windows.Forms.NumericUpDown DudNumCartas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TableLayoutPanel pPrincipal;
        private System.Windows.Forms.Button BtnVolver;
        private System.Windows.Forms.Button BtnAceptar;
        private System.Windows.Forms.Panel pGeneral;
    }
}