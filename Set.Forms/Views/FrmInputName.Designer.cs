namespace Set.Forms.Views
{
    partial class FrmInputName
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
            this.label1 = new System.Windows.Forms.Label();
            this.TbxNombre = new System.Windows.Forms.TextBox();
            this.pGeneral = new System.Windows.Forms.Panel();
            this.pPrincipal = new System.Windows.Forms.TableLayoutPanel();
            this.lbTitulo = new System.Windows.Forms.Label();
            this.BtnAceptar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.LblPuntuacion = new System.Windows.Forms.Label();
            this.LblTiempo = new System.Windows.Forms.Label();
            this.LblSets = new System.Windows.Forms.Label();
            this.pGeneral.SuspendLayout();
            this.pPrincipal.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(4, 50);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(191, 30);
            this.label1.TabIndex = 3;
            this.label1.Text = "Nombre:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // TbxNombre
            // 
            this.TbxNombre.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TbxNombre.Location = new System.Drawing.Point(209, 50);
            this.TbxNombre.Margin = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.TbxNombre.Name = "TbxNombre";
            this.TbxNombre.Size = new System.Drawing.Size(170, 26);
            this.TbxNombre.TabIndex = 2;
            // 
            // pGeneral
            // 
            this.pGeneral.BackColor = System.Drawing.Color.Transparent;
            this.pGeneral.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pGeneral.Controls.Add(this.pPrincipal);
            this.pGeneral.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pGeneral.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pGeneral.Location = new System.Drawing.Point(0, 0);
            this.pGeneral.Margin = new System.Windows.Forms.Padding(4);
            this.pGeneral.Name = "pGeneral";
            this.pGeneral.Size = new System.Drawing.Size(401, 229);
            this.pGeneral.TabIndex = 1;
            // 
            // pPrincipal
            // 
            this.pPrincipal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(230)))), ((int)(((byte)(233)))));
            this.pPrincipal.ColumnCount = 2;
            this.pPrincipal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.pPrincipal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.pPrincipal.Controls.Add(this.lbTitulo, 0, 0);
            this.pPrincipal.Controls.Add(this.label1, 0, 2);
            this.pPrincipal.Controls.Add(this.BtnAceptar, 0, 6);
            this.pPrincipal.Controls.Add(this.TbxNombre, 1, 2);
            this.pPrincipal.Controls.Add(this.label2, 0, 3);
            this.pPrincipal.Controls.Add(this.label3, 0, 4);
            this.pPrincipal.Controls.Add(this.label4, 0, 5);
            this.pPrincipal.Controls.Add(this.LblPuntuacion, 1, 5);
            this.pPrincipal.Controls.Add(this.LblTiempo, 1, 4);
            this.pPrincipal.Controls.Add(this.LblSets, 1, 3);
            this.pPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pPrincipal.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pPrincipal.Location = new System.Drawing.Point(0, 0);
            this.pPrincipal.Name = "pPrincipal";
            this.pPrincipal.RowCount = 8;
            this.pPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.pPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 15F));
            this.pPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.pPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.pPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.pPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.pPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.pPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 15F));
            this.pPrincipal.Size = new System.Drawing.Size(399, 227);
            this.pPrincipal.TabIndex = 5;
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
            this.lbTitulo.Size = new System.Drawing.Size(359, 35);
            this.lbTitulo.TabIndex = 1;
            this.lbTitulo.Text = "Introduce tu nombre";
            this.lbTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BtnAceptar
            // 
            this.BtnAceptar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(52)))), ((int)(((byte)(54)))));
            this.pPrincipal.SetColumnSpan(this.BtnAceptar, 2);
            this.BtnAceptar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnAceptar.FlatAppearance.BorderSize = 0;
            this.BtnAceptar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(110)))), ((int)(((byte)(114)))));
            this.BtnAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAceptar.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAceptar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(236)))), ((int)(((byte)(236)))));
            this.BtnAceptar.Location = new System.Drawing.Point(80, 175);
            this.BtnAceptar.Margin = new System.Windows.Forms.Padding(80, 5, 80, 5);
            this.BtnAceptar.Name = "BtnAceptar";
            this.BtnAceptar.Size = new System.Drawing.Size(239, 40);
            this.BtnAceptar.TabIndex = 1;
            this.BtnAceptar.Text = "Aceptar";
            this.BtnAceptar.UseVisualStyleBackColor = false;
            this.BtnAceptar.Click += new System.EventHandler(this.BtnAceptarClick);
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Location = new System.Drawing.Point(4, 80);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(191, 30);
            this.label2.TabIndex = 4;
            this.label2.Text = "Sets / Fallos:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Location = new System.Drawing.Point(4, 110);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(191, 30);
            this.label3.TabIndex = 5;
            this.label3.Text = "Tiempo:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(4, 140);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(191, 30);
            this.label4.TabIndex = 6;
            this.label4.Text = "Puntuación:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // LblPuntuacion
            // 
            this.LblPuntuacion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LblPuntuacion.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblPuntuacion.Location = new System.Drawing.Point(209, 140);
            this.LblPuntuacion.Margin = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.LblPuntuacion.Name = "LblPuntuacion";
            this.LblPuntuacion.Size = new System.Drawing.Size(190, 30);
            this.LblPuntuacion.TabIndex = 7;
            this.LblPuntuacion.Text = "Puntuación:";
            this.LblPuntuacion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // LblTiempo
            // 
            this.LblTiempo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LblTiempo.Location = new System.Drawing.Point(209, 110);
            this.LblTiempo.Margin = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.LblTiempo.Name = "LblTiempo";
            this.LblTiempo.Size = new System.Drawing.Size(190, 30);
            this.LblTiempo.TabIndex = 8;
            this.LblTiempo.Text = "Tiempo:";
            this.LblTiempo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // LblSets
            // 
            this.LblSets.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LblSets.Location = new System.Drawing.Point(209, 80);
            this.LblSets.Margin = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.LblSets.Name = "LblSets";
            this.LblSets.Size = new System.Drawing.Size(190, 30);
            this.LblSets.TabIndex = 9;
            this.LblSets.Text = "Sets / Fallos:";
            this.LblSets.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // FrmInputName
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(401, 229);
            this.ControlBox = false;
            this.Controls.Add(this.pGeneral);
            this.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmInputName";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Introduce tu nombre";
            this.pGeneral.ResumeLayout(false);
            this.pPrincipal.ResumeLayout(false);
            this.pPrincipal.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TbxNombre;
        private System.Windows.Forms.Panel pGeneral;
        private System.Windows.Forms.TableLayoutPanel pPrincipal;
        private System.Windows.Forms.Label lbTitulo;
        private System.Windows.Forms.Button BtnAceptar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label LblPuntuacion;
        private System.Windows.Forms.Label LblTiempo;
        private System.Windows.Forms.Label LblSets;
    }
}