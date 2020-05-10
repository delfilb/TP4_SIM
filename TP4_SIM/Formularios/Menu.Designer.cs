namespace TP4_SIM
{
    partial class Menu
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
            this.lblIteracion = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.lblDesde = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.lblHasta = new System.Windows.Forms.Label();
            this.lblMujer = new System.Windows.Forms.Label();
            this.lblHombre = new System.Windows.Forms.Label();
            this.dgv_datos = new System.Windows.Forms.DataGridView();
            this.lv_hombre = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lv_mujer = new System.Windows.Forms.ListView();
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.nroCasa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rndAbre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AbreNoAbre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rnd_Genero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MujerHombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nroCompra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rndCompra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rndSuscripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Suscrpcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_datos)).BeginInit();
            this.SuspendLayout();
            // 
            // lblIteracion
            // 
            this.lblIteracion.AutoSize = true;
            this.lblIteracion.Location = new System.Drawing.Point(43, 98);
            this.lblIteracion.Name = "lblIteracion";
            this.lblIteracion.Size = new System.Drawing.Size(62, 17);
            this.lblIteracion.TabIndex = 0;
            this.lblIteracion.Text = "Iteracion";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(135, 93);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 22);
            this.textBox1.TabIndex = 1;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(135, 133);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 22);
            this.textBox2.TabIndex = 3;
            // 
            // lblDesde
            // 
            this.lblDesde.AutoSize = true;
            this.lblDesde.Location = new System.Drawing.Point(43, 138);
            this.lblDesde.Name = "lblDesde";
            this.lblDesde.Size = new System.Drawing.Size(49, 17);
            this.lblDesde.TabIndex = 2;
            this.lblDesde.Text = "Desde";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(135, 172);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 22);
            this.textBox3.TabIndex = 5;
            // 
            // lblHasta
            // 
            this.lblHasta.AutoSize = true;
            this.lblHasta.Location = new System.Drawing.Point(43, 177);
            this.lblHasta.Name = "lblHasta";
            this.lblHasta.Size = new System.Drawing.Size(45, 17);
            this.lblHasta.TabIndex = 4;
            this.lblHasta.Text = "Hasta";
            this.lblHasta.Click += new System.EventHandler(this.label3_Click);
            // 
            // lblMujer
            // 
            this.lblMujer.AutoSize = true;
            this.lblMujer.Location = new System.Drawing.Point(436, 41);
            this.lblMujer.Name = "lblMujer";
            this.lblMujer.Size = new System.Drawing.Size(43, 17);
            this.lblMujer.TabIndex = 8;
            this.lblMujer.Text = "Mujer";
            this.lblMujer.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblHombre
            // 
            this.lblHombre.AutoSize = true;
            this.lblHombre.Location = new System.Drawing.Point(723, 41);
            this.lblHombre.Name = "lblHombre";
            this.lblHombre.Size = new System.Drawing.Size(58, 17);
            this.lblHombre.TabIndex = 9;
            this.lblHombre.Text = "Hombre";
            // 
            // dgv_datos
            // 
            this.dgv_datos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_datos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nroCasa,
            this.rndAbre,
            this.AbreNoAbre,
            this.rnd_Genero,
            this.MujerHombre,
            this.nroCompra,
            this.rndCompra,
            this.rndSuscripcion,
            this.Suscrpcion});
            this.dgv_datos.Location = new System.Drawing.Point(46, 277);
            this.dgv_datos.Name = "dgv_datos";
            this.dgv_datos.RowTemplate.Height = 24;
            this.dgv_datos.Size = new System.Drawing.Size(1270, 306);
            this.dgv_datos.TabIndex = 10;
            // 
            // lv_hombre
            // 
            this.lv_hombre.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.lv_hombre.HideSelection = false;
            this.lv_hombre.Location = new System.Drawing.Point(620, 70);
            this.lv_hombre.Name = "lv_hombre";
            this.lv_hombre.Size = new System.Drawing.Size(272, 180);
            this.lv_hombre.TabIndex = 12;
            this.lv_hombre.UseCompatibleStateImageBehavior = false;
            this.lv_hombre.View = System.Windows.Forms.View.Details;
            this.lv_hombre.SelectedIndexChanged += new System.EventHandler(this.lv_hombre_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = " ";
            this.columnHeader1.Width = 98;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = " ";
            this.columnHeader2.Width = 98;
            // 
            // lv_mujer
            // 
            this.lv_mujer.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader3,
            this.columnHeader4});
            this.lv_mujer.HideSelection = false;
            this.lv_mujer.Location = new System.Drawing.Point(321, 70);
            this.lv_mujer.Name = "lv_mujer";
            this.lv_mujer.Size = new System.Drawing.Size(277, 180);
            this.lv_mujer.TabIndex = 13;
            this.lv_mujer.UseCompatibleStateImageBehavior = false;
            this.lv_mujer.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = " ";
            this.columnHeader3.Width = 98;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = " ";
            this.columnHeader4.Width = 98;
            // 
            // nroCasa
            // 
            this.nroCasa.HeaderText = "N°Casa";
            this.nroCasa.Name = "nroCasa";
            // 
            // rndAbre
            // 
            this.rndAbre.HeaderText = "N°";
            this.rndAbre.Name = "rndAbre";
            // 
            // AbreNoAbre
            // 
            this.AbreNoAbre.HeaderText = "Abre/NoAbre";
            this.AbreNoAbre.Name = "AbreNoAbre";
            // 
            // rnd_Genero
            // 
            this.rnd_Genero.HeaderText = "N°";
            this.rnd_Genero.Name = "rnd_Genero";
            // 
            // MujerHombre
            // 
            this.MujerHombre.HeaderText = "Mujer/Hombre";
            this.MujerHombre.Name = "MujerHombre";
            // 
            // nroCompra
            // 
            this.nroCompra.HeaderText = "N°";
            this.nroCompra.Name = "nroCompra";
            // 
            // rndCompra
            // 
            this.rndCompra.HeaderText = "Compra/NoCompra";
            this.rndCompra.Name = "rndCompra";
            // 
            // rndSuscripcion
            // 
            this.rndSuscripcion.HeaderText = "N°";
            this.rndSuscripcion.Name = "rndSuscripcion";
            // 
            // Suscrpcion
            // 
            this.Suscrpcion.HeaderText = "Suscripcion";
            this.Suscrpcion.Name = "Suscrpcion";
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1328, 610);
            this.Controls.Add(this.lv_mujer);
            this.Controls.Add(this.lv_hombre);
            this.Controls.Add(this.dgv_datos);
            this.Controls.Add(this.lblHombre);
            this.Controls.Add(this.lblMujer);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.lblHasta);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.lblDesde);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lblIteracion);
            this.Name = "Menu";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Menu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_datos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblIteracion;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label lblDesde;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label lblHasta;
        private System.Windows.Forms.Label lblMujer;
        private System.Windows.Forms.Label lblHombre;
        private System.Windows.Forms.DataGridView dgv_datos;
        private System.Windows.Forms.ListView lv_hombre;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ListView lv_mujer;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.DataGridViewTextBoxColumn nroCasa;
        private System.Windows.Forms.DataGridViewTextBoxColumn rndAbre;
        private System.Windows.Forms.DataGridViewTextBoxColumn AbreNoAbre;
        private System.Windows.Forms.DataGridViewTextBoxColumn rnd_Genero;
        private System.Windows.Forms.DataGridViewTextBoxColumn MujerHombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn nroCompra;
        private System.Windows.Forms.DataGridViewTextBoxColumn rndCompra;
        private System.Windows.Forms.DataGridViewTextBoxColumn rndSuscripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Suscrpcion;
    }
}

