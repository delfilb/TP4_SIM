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
			this.tbxIteracion = new System.Windows.Forms.TextBox();
			this.tbxDesde = new System.Windows.Forms.TextBox();
			this.lblDesde = new System.Windows.Forms.Label();
			this.tbxHasta = new System.Windows.Forms.TextBox();
			this.lblHasta = new System.Windows.Forms.Label();
			this.lblMujer = new System.Windows.Forms.Label();
			this.lblHombre = new System.Windows.Forms.Label();
			this.dgv_datos = new System.Windows.Forms.DataGridView();
			this.lv_mujer = new System.Windows.Forms.ListView();
			this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.desde = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.hasta = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.btnGenerar = new System.Windows.Forms.Button();
			this.btnBorrar = new System.Windows.Forms.Button();
			this.lv_hombre = new System.Windows.Forms.ListView();
			this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.nroCasa = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.rndAbre = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.AbreNoAbre = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.rnd_Genero = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.MujerHombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.nroCompra = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.rndCompra = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.rndSuscripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Suscrpcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.utilidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.utilidadAcumulada = new System.Windows.Forms.DataGridViewTextBoxColumn();
			((System.ComponentModel.ISupportInitialize)(this.dgv_datos)).BeginInit();
			this.SuspendLayout();
			// 
			// lblIteracion
			// 
			this.lblIteracion.AutoSize = true;
			this.lblIteracion.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblIteracion.Location = new System.Drawing.Point(58, 83);
			this.lblIteracion.Name = "lblIteracion";
			this.lblIteracion.Size = new System.Drawing.Size(54, 16);
			this.lblIteracion.TabIndex = 0;
			this.lblIteracion.Text = "Iteracion";
			// 
			// tbxIteracion
			// 
			this.tbxIteracion.Location = new System.Drawing.Point(150, 77);
			this.tbxIteracion.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.tbxIteracion.Name = "tbxIteracion";
			this.tbxIteracion.Size = new System.Drawing.Size(100, 23);
			this.tbxIteracion.TabIndex = 1;
			// 
			// tbxDesde
			// 
			this.tbxDesde.Location = new System.Drawing.Point(150, 125);
			this.tbxDesde.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.tbxDesde.Name = "tbxDesde";
			this.tbxDesde.Size = new System.Drawing.Size(100, 23);
			this.tbxDesde.TabIndex = 3;
			// 
			// lblDesde
			// 
			this.lblDesde.AutoSize = true;
			this.lblDesde.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblDesde.Location = new System.Drawing.Point(58, 131);
			this.lblDesde.Name = "lblDesde";
			this.lblDesde.Size = new System.Drawing.Size(40, 16);
			this.lblDesde.TabIndex = 2;
			this.lblDesde.Text = "Desde";
			// 
			// tbxHasta
			// 
			this.tbxHasta.Location = new System.Drawing.Point(150, 171);
			this.tbxHasta.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.tbxHasta.Name = "tbxHasta";
			this.tbxHasta.Size = new System.Drawing.Size(100, 23);
			this.tbxHasta.TabIndex = 5;
			// 
			// lblHasta
			// 
			this.lblHasta.AutoSize = true;
			this.lblHasta.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblHasta.Location = new System.Drawing.Point(58, 177);
			this.lblHasta.Name = "lblHasta";
			this.lblHasta.Size = new System.Drawing.Size(38, 16);
			this.lblHasta.TabIndex = 4;
			this.lblHasta.Text = "Hasta";
			// 
			// lblMujer
			// 
			this.lblMujer.AutoSize = true;
			this.lblMujer.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblMujer.Location = new System.Drawing.Point(521, 45);
			this.lblMujer.Name = "lblMujer";
			this.lblMujer.Size = new System.Drawing.Size(39, 16);
			this.lblMujer.TabIndex = 8;
			this.lblMujer.Text = "Mujer";
			// 
			// lblHombre
			// 
			this.lblHombre.AutoSize = true;
			this.lblHombre.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblHombre.Location = new System.Drawing.Point(933, 45);
			this.lblHombre.Name = "lblHombre";
			this.lblHombre.Size = new System.Drawing.Size(52, 16);
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
            this.Suscrpcion,
            this.utilidad,
            this.utilidadAcumulada});
			this.dgv_datos.Location = new System.Drawing.Point(46, 329);
			this.dgv_datos.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.dgv_datos.Name = "dgv_datos";
			this.dgv_datos.RowTemplate.Height = 24;
			this.dgv_datos.Size = new System.Drawing.Size(1149, 293);
			this.dgv_datos.TabIndex = 10;
			// 
			// lv_mujer
			// 
			this.lv_mujer.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader3,
            this.columnHeader4,
            this.desde,
            this.hasta});
			this.lv_mujer.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lv_mujer.HideSelection = false;
			this.lv_mujer.Location = new System.Drawing.Point(374, 83);
			this.lv_mujer.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.lv_mujer.Name = "lv_mujer";
			this.lv_mujer.Size = new System.Drawing.Size(341, 184);
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
			this.columnHeader4.Text = "Probabillidad";
			this.columnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.columnHeader4.Width = 119;
			// 
			// desde
			// 
			this.desde.Text = "Desde";
			this.desde.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// hasta
			// 
			this.hasta.Text = "Hasta";
			this.hasta.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// btnGenerar
			// 
			this.btnGenerar.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnGenerar.Location = new System.Drawing.Point(159, 246);
			this.btnGenerar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.btnGenerar.Name = "btnGenerar";
			this.btnGenerar.Size = new System.Drawing.Size(91, 40);
			this.btnGenerar.TabIndex = 14;
			this.btnGenerar.Text = "Generar";
			this.btnGenerar.UseVisualStyleBackColor = true;
			this.btnGenerar.Click += new System.EventHandler(this.btnGenerar_Click);
			// 
			// btnBorrar
			// 
			this.btnBorrar.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnBorrar.Location = new System.Drawing.Point(61, 246);
			this.btnBorrar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.btnBorrar.Name = "btnBorrar";
			this.btnBorrar.Size = new System.Drawing.Size(82, 40);
			this.btnBorrar.TabIndex = 16;
			this.btnBorrar.Text = "Borrar";
			this.btnBorrar.UseVisualStyleBackColor = true;
			this.btnBorrar.Click += new System.EventHandler(this.btnBorrar_Click);
			// 
			// lv_hombre
			// 
			this.lv_hombre.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader5,
            this.columnHeader6});
			this.lv_hombre.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lv_hombre.HideSelection = false;
			this.lv_hombre.Location = new System.Drawing.Point(791, 83);
			this.lv_hombre.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.lv_hombre.Name = "lv_hombre";
			this.lv_hombre.Size = new System.Drawing.Size(336, 184);
			this.lv_hombre.TabIndex = 17;
			this.lv_hombre.UseCompatibleStateImageBehavior = false;
			this.lv_hombre.View = System.Windows.Forms.View.Details;
			// 
			// columnHeader1
			// 
			this.columnHeader1.Text = " ";
			this.columnHeader1.Width = 98;
			// 
			// columnHeader2
			// 
			this.columnHeader2.Text = "Probabillidad";
			this.columnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.columnHeader2.Width = 114;
			// 
			// columnHeader5
			// 
			this.columnHeader5.Text = "Desde";
			this.columnHeader5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// columnHeader6
			// 
			this.columnHeader6.Text = "Hasta";
			this.columnHeader6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// nroCasa
			// 
			this.nroCasa.HeaderText = "N° Casa";
			this.nroCasa.Name = "nroCasa";
			// 
			// rndAbre
			// 
			this.rndAbre.HeaderText = "RND (¿Abren?)";
			this.rndAbre.Name = "rndAbre";
			// 
			// AbreNoAbre
			// 
			this.AbreNoAbre.HeaderText = "Abre/No Abre";
			this.AbreNoAbre.Name = "AbreNoAbre";
			// 
			// rnd_Genero
			// 
			this.rnd_Genero.HeaderText = "RND (¿Quién abre?)";
			this.rnd_Genero.Name = "rnd_Genero";
			// 
			// MujerHombre
			// 
			this.MujerHombre.HeaderText = "Mujer/Hombre";
			this.MujerHombre.Name = "MujerHombre";
			// 
			// nroCompra
			// 
			this.nroCompra.HeaderText = "RND (Compra)";
			this.nroCompra.Name = "nroCompra";
			// 
			// rndCompra
			// 
			this.rndCompra.HeaderText = "Compra/No Compra";
			this.rndCompra.Name = "rndCompra";
			// 
			// rndSuscripcion
			// 
			this.rndSuscripcion.HeaderText = "RND (Suscripciones)";
			this.rndSuscripcion.Name = "rndSuscripcion";
			// 
			// Suscrpcion
			// 
			this.Suscrpcion.HeaderText = "Suscripciones";
			this.Suscrpcion.Name = "Suscrpcion";
			// 
			// utilidad
			// 
			this.utilidad.HeaderText = "Utilidad";
			this.utilidad.Name = "utilidad";
			// 
			// utilidadAcumulada
			// 
			this.utilidadAcumulada.HeaderText = "Utilidad Acumulada";
			this.utilidadAcumulada.Name = "utilidadAcumulada";
			// 
			// Menu
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoScroll = true;
			this.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.ClientSize = new System.Drawing.Size(1207, 670);
			this.Controls.Add(this.lv_hombre);
			this.Controls.Add(this.btnBorrar);
			this.Controls.Add(this.btnGenerar);
			this.Controls.Add(this.lv_mujer);
			this.Controls.Add(this.dgv_datos);
			this.Controls.Add(this.lblHombre);
			this.Controls.Add(this.lblMujer);
			this.Controls.Add(this.tbxHasta);
			this.Controls.Add(this.lblHasta);
			this.Controls.Add(this.tbxDesde);
			this.Controls.Add(this.lblDesde);
			this.Controls.Add(this.tbxIteracion);
			this.Controls.Add(this.lblIteracion);
			this.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.Name = "Menu";
			this.Text = "Form1";
			this.Load += new System.EventHandler(this.Menu_Load);
			((System.ComponentModel.ISupportInitialize)(this.dgv_datos)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblIteracion;
        private System.Windows.Forms.TextBox tbxIteracion;
        private System.Windows.Forms.TextBox tbxDesde;
        private System.Windows.Forms.Label lblDesde;
        private System.Windows.Forms.TextBox tbxHasta;
        private System.Windows.Forms.Label lblHasta;
        private System.Windows.Forms.Label lblMujer;
        private System.Windows.Forms.Label lblHombre;
        private System.Windows.Forms.DataGridView dgv_datos;
        private System.Windows.Forms.ListView lv_mujer;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.Button btnGenerar;
        private System.Windows.Forms.Button btnBorrar;
        private System.Windows.Forms.ColumnHeader desde;
        private System.Windows.Forms.ColumnHeader hasta;
        private System.Windows.Forms.ListView lv_hombre;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
		private System.Windows.Forms.DataGridViewTextBoxColumn nroCasa;
		private System.Windows.Forms.DataGridViewTextBoxColumn rndAbre;
		private System.Windows.Forms.DataGridViewTextBoxColumn AbreNoAbre;
		private System.Windows.Forms.DataGridViewTextBoxColumn rnd_Genero;
		private System.Windows.Forms.DataGridViewTextBoxColumn MujerHombre;
		private System.Windows.Forms.DataGridViewTextBoxColumn nroCompra;
		private System.Windows.Forms.DataGridViewTextBoxColumn rndCompra;
		private System.Windows.Forms.DataGridViewTextBoxColumn rndSuscripcion;
		private System.Windows.Forms.DataGridViewTextBoxColumn Suscrpcion;
		private System.Windows.Forms.DataGridViewTextBoxColumn utilidad;
		private System.Windows.Forms.DataGridViewTextBoxColumn utilidadAcumulada;
	}
}

