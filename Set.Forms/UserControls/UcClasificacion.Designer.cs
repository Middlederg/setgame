namespace Set.Forms.UserControls
{
    partial class UcClasificacion
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

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.pPrincipal = new System.Windows.Forms.TableLayoutPanel();
            this.lbTitulo = new System.Windows.Forms.Label();
            this.Lvw = new System.Windows.Forms.ListView();
            this.pPrincipal.SuspendLayout();
            this.SuspendLayout();
            // 
            // pPrincipal
            // 
            this.pPrincipal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(230)))), ((int)(((byte)(233)))));
            this.pPrincipal.ColumnCount = 1;
            this.pPrincipal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.pPrincipal.Controls.Add(this.lbTitulo, 0, 0);
            this.pPrincipal.Controls.Add(this.Lvw, 0, 1);
            this.pPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pPrincipal.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pPrincipal.Location = new System.Drawing.Point(0, 0);
            this.pPrincipal.Name = "pPrincipal";
            this.pPrincipal.RowCount = 2;
            this.pPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.pPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.pPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.pPrincipal.Size = new System.Drawing.Size(445, 318);
            this.pPrincipal.TabIndex = 7;
            // 
            // lbTitulo
            // 
            this.lbTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(52)))), ((int)(((byte)(54)))));
            this.lbTitulo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbTitulo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbTitulo.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(236)))), ((int)(((byte)(236)))));
            this.lbTitulo.Location = new System.Drawing.Point(20, 0);
            this.lbTitulo.Margin = new System.Windows.Forms.Padding(20, 0, 20, 0);
            this.lbTitulo.Name = "lbTitulo";
            this.lbTitulo.Size = new System.Drawing.Size(405, 35);
            this.lbTitulo.TabIndex = 1;
            this.lbTitulo.Text = "Clasificación";
            this.lbTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Lvw
            // 
            this.Lvw.AllowColumnReorder = true;
            this.Lvw.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Lvw.GridLines = true;
            this.Lvw.Location = new System.Drawing.Point(20, 45);
            this.Lvw.Margin = new System.Windows.Forms.Padding(20, 10, 20, 20);
            this.Lvw.MultiSelect = false;
            this.Lvw.Name = "Lvw";
            this.Lvw.Size = new System.Drawing.Size(405, 253);
            this.Lvw.TabIndex = 1;
            this.Lvw.UseCompatibleStateImageBehavior = false;
            this.Lvw.View = System.Windows.Forms.View.Details;
            // 
            // UcClasificacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pPrincipal);
            this.Name = "UcClasificacion";
            this.Size = new System.Drawing.Size(445, 318);
            this.pPrincipal.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel pPrincipal;
        private System.Windows.Forms.Label lbTitulo;
        private System.Windows.Forms.ListView Lvw;
    }
}
