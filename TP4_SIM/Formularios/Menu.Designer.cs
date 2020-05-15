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
            this.lblProb = new System.Windows.Forms.Label();
            this.lbltxt = new System.Windows.Forms.Label();
            this.lv_hombre = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnBorrar = new System.Windows.Forms.Button();
            this.btnGenerar = new System.Windows.Forms.Button();
            this.lv_mujer = new System.Windows.Forms.ListView();
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.desde = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.hasta = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.dgv_datos = new System.Windows.Forms.DataGridView();
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
            this.cont = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblHombre = new System.Windows.Forms.Label();
            this.lblMujer = new System.Windows.Forms.Label();
            this.tbxHasta = new System.Windows.Forms.TextBox();
            this.lblHasta = new System.Windows.Forms.Label();
            this.tbxDesde = new System.Windows.Forms.TextBox();
            this.lblDesde = new System.Windows.Forms.Label();
            this.tbxIteracion = new System.Windows.Forms.TextBox();
            this.lblIteracion = new System.Windows.Forms.Label();
            this.lv_abre = new System.Windows.Forms.ListView();
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lblAbre = new System.Windows.Forms.Label();
            this.lv_utilidad = new System.Windows.Forms.ListView();
            this.columnHeader11 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader12 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            ((System.ComponentModel.ISupportInitialize)(this.dgv_datos)).BeginInit();
            this.SuspendLayout();
            // 
            // lblProb
            // 
            this.lblProb.AutoSize = true;
            this.lblProb.Location = new System.Drawing.Point(256, 630);
            this.lblProb.Name = "lblProb";
            this.lblProb.Size = new System.Drawing.Size(50, 19);
            this.lblProb.TabIndex = 34;
            this.lblProb.Text = "label1";
            this.lblProb.Visible = false;
            // 
            // lbltxt
            // 
            this.lbltxt.AutoSize = true;
            this.lbltxt.Location = new System.Drawing.Point(33, 630);
            this.lbltxt.Name = "lbltxt";
            this.lbltxt.Size = new System.Drawing.Size(273, 19);
            this.lbltxt.TabIndex = 33;
            this.lbltxt.Text = "Probabilidad de venta de Suscripciones:";
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
            this.lv_hombre.Location = new System.Drawing.Point(966, 81);
            this.lv_hombre.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lv_hombre.Name = "lv_hombre";
            this.lv_hombre.Size = new System.Drawing.Size(310, 184);
            this.lv_hombre.TabIndex = 32;
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
            this.columnHeader2.Text = "P()";
            this.columnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader2.Width = 79;
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
            // btnBorrar
            // 
            this.btnBorrar.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBorrar.Location = new System.Drawing.Point(73, 244);
            this.btnBorrar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(82, 40);
            this.btnBorrar.TabIndex = 31;
            this.btnBorrar.Text = "Borrar";
            this.btnBorrar.UseVisualStyleBackColor = true;
            this.btnBorrar.Click += new System.EventHandler(this.btnBorrar_Click_1);
            // 
            // btnGenerar
            // 
            this.btnGenerar.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerar.Location = new System.Drawing.Point(171, 244);
            this.btnGenerar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnGenerar.Name = "btnGenerar";
            this.btnGenerar.Size = new System.Drawing.Size(91, 40);
            this.btnGenerar.TabIndex = 30;
            this.btnGenerar.Text = "Generar";
            this.btnGenerar.UseVisualStyleBackColor = true;
            this.btnGenerar.Click += new System.EventHandler(this.btnGenerar_Click_1);
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
            this.lv_mujer.Location = new System.Drawing.Point(637, 81);
            this.lv_mujer.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lv_mujer.Name = "lv_mujer";
            this.lv_mujer.Size = new System.Drawing.Size(310, 184);
            this.lv_mujer.TabIndex = 29;
            this.lv_mujer.UseCompatibleStateImageBehavior = false;
            this.lv_mujer.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = " ";
            this.columnHeader3.Width = 97;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "P()";
            this.columnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader4.Width = 88;
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
            this.utilidadAcumulada,
            this.cont});
            this.dgv_datos.Location = new System.Drawing.Point(24, 317);
            this.dgv_datos.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgv_datos.Name = "dgv_datos";
            this.dgv_datos.RowTemplate.Height = 24;
            this.dgv_datos.Size = new System.Drawing.Size(1244, 293);
            this.dgv_datos.TabIndex = 28;
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
            // cont
            // 
            this.cont.HeaderText = "Contador de Ventas";
            this.cont.Name = "cont";
            // 
            // lblHombre
            // 
            this.lblHombre.AutoSize = true;
            this.lblHombre.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHombre.Location = new System.Drawing.Point(1096, 43);
            this.lblHombre.Name = "lblHombre";
            this.lblHombre.Size = new System.Drawing.Size(64, 19);
            this.lblHombre.TabIndex = 27;
            this.lblHombre.Text = "Hombre";
            // 
            // lblMujer
            // 
            this.lblMujer.AutoSize = true;
            this.lblMujer.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMujer.Location = new System.Drawing.Point(776, 43);
            this.lblMujer.Name = "lblMujer";
            this.lblMujer.Size = new System.Drawing.Size(47, 19);
            this.lblMujer.TabIndex = 26;
            this.lblMujer.Text = "Mujer";
            // 
            // tbxHasta
            // 
            this.tbxHasta.Location = new System.Drawing.Point(162, 169);
            this.tbxHasta.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbxHasta.Name = "tbxHasta";
            this.tbxHasta.Size = new System.Drawing.Size(100, 27);
            this.tbxHasta.TabIndex = 25;
            // 
            // lblHasta
            // 
            this.lblHasta.AutoSize = true;
            this.lblHasta.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHasta.Location = new System.Drawing.Point(70, 175);
            this.lblHasta.Name = "lblHasta";
            this.lblHasta.Size = new System.Drawing.Size(47, 19);
            this.lblHasta.TabIndex = 24;
            this.lblHasta.Text = "Hasta";
            // 
            // tbxDesde
            // 
            this.tbxDesde.Location = new System.Drawing.Point(162, 123);
            this.tbxDesde.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbxDesde.Name = "tbxDesde";
            this.tbxDesde.Size = new System.Drawing.Size(100, 27);
            this.tbxDesde.TabIndex = 23;
            // 
            // lblDesde
            // 
            this.lblDesde.AutoSize = true;
            this.lblDesde.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDesde.Location = new System.Drawing.Point(70, 129);
            this.lblDesde.Name = "lblDesde";
            this.lblDesde.Size = new System.Drawing.Size(51, 19);
            this.lblDesde.TabIndex = 22;
            this.lblDesde.Text = "Desde";
            // 
            // tbxIteracion
            // 
            this.tbxIteracion.Location = new System.Drawing.Point(162, 75);
            this.tbxIteracion.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbxIteracion.Name = "tbxIteracion";
            this.tbxIteracion.Size = new System.Drawing.Size(100, 27);
            this.tbxIteracion.TabIndex = 21;
            // 
            // lblIteracion
            // 
            this.lblIteracion.AutoSize = true;
            this.lblIteracion.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIteracion.Location = new System.Drawing.Point(70, 81);
            this.lblIteracion.Name = "lblIteracion";
            this.lblIteracion.Size = new System.Drawing.Size(67, 19);
            this.lblIteracion.TabIndex = 20;
            this.lblIteracion.Text = "Iteracion";
            // 
            // lv_abre
            // 
            this.lv_abre.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader7,
            this.columnHeader8,
            this.columnHeader9,
            this.columnHeader10});
            this.lv_abre.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lv_abre.HideSelection = false;
            this.lv_abre.Location = new System.Drawing.Point(337, 81);
            this.lv_abre.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lv_abre.Name = "lv_abre";
            this.lv_abre.Size = new System.Drawing.Size(278, 107);
            this.lv_abre.TabIndex = 35;
            this.lv_abre.UseCompatibleStateImageBehavior = false;
            this.lv_abre.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = " ";
            this.columnHeader7.Width = 75;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "P()";
            this.columnHeader8.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader8.Width = 78;
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "Desde";
            this.columnHeader9.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // columnHeader10
            // 
            this.columnHeader10.Text = "Hasta";
            this.columnHeader10.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblAbre
            // 
            this.lblAbre.AutoSize = true;
            this.lblAbre.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAbre.Location = new System.Drawing.Point(421, 43);
            this.lblAbre.Name = "lblAbre";
            this.lblAbre.Size = new System.Drawing.Size(114, 19);
            this.lblAbre.TabIndex = 36;
            this.lblAbre.Text = "Abre o No Abre";
            // 
            // lv_utilidad
            // 
            this.lv_utilidad.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader11,
            this.columnHeader12});
            this.lv_utilidad.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lv_utilidad.HideSelection = false;
            this.lv_utilidad.Location = new System.Drawing.Point(337, 196);
            this.lv_utilidad.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lv_utilidad.Name = "lv_utilidad";
            this.lv_utilidad.Size = new System.Drawing.Size(278, 69);
            this.lv_utilidad.TabIndex = 37;
            this.lv_utilidad.UseCompatibleStateImageBehavior = false;
            this.lv_utilidad.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader11
            // 
            this.columnHeader11.Text = " ";
            this.columnHeader11.Width = 137;
            // 
            // columnHeader12
            // 
            this.columnHeader12.Text = "";
            this.columnHeader12.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader12.Width = 136;
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1317, 696);
            this.Controls.Add(this.lv_utilidad);
            this.Controls.Add(this.lblAbre);
            this.Controls.Add(this.lv_abre);
            this.Controls.Add(this.lblProb);
            this.Controls.Add(this.lbltxt);
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

        private System.Windows.Forms.Label lblProb;
        private System.Windows.Forms.Label lbltxt;
        private System.Windows.Forms.ListView lv_hombre;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.Button btnBorrar;
        private System.Windows.Forms.Button btnGenerar;
        private System.Windows.Forms.ListView lv_mujer;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader desde;
        private System.Windows.Forms.ColumnHeader hasta;
        private System.Windows.Forms.DataGridView dgv_datos;
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
        private System.Windows.Forms.DataGridViewTextBoxColumn cont;
        private System.Windows.Forms.Label lblHombre;
        private System.Windows.Forms.Label lblMujer;
        private System.Windows.Forms.TextBox tbxHasta;
        private System.Windows.Forms.Label lblHasta;
        private System.Windows.Forms.TextBox tbxDesde;
        private System.Windows.Forms.Label lblDesde;
        private System.Windows.Forms.TextBox tbxIteracion;
        private System.Windows.Forms.Label lblIteracion;
        private System.Windows.Forms.ListView lv_abre;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.ColumnHeader columnHeader10;
        private System.Windows.Forms.Label lblAbre;
        private System.Windows.Forms.ListView lv_utilidad;
        private System.Windows.Forms.ColumnHeader columnHeader11;
        private System.Windows.Forms.ColumnHeader columnHeader12;
    }
}

