namespace NorthwindForms.Mantenimiento
{
    partial class FrmManProducto
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
            this.DgvPrincipal = new System.Windows.Forms.DataGridView();
            this.DgvCodigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DgvNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DgvCategory = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtNombre = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtCodigo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.CboCategoria = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TxtUnidad = new System.Windows.Forms.TextBox();
            this.NudPu = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.NudStock = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.NudPedidos = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.NudOrdenar = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.ChkDiscontinuado = new System.Windows.Forms.CheckBox();
            this.TbcPrincipal.SuspendLayout();
            this.TbpBuscar.SuspendLayout();
            this.TbpMantenimiento.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvPrincipal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NudPu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NudStock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NudPedidos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NudOrdenar)).BeginInit();
            this.SuspendLayout();
            // 
            // TbcPrincipal
            // 
            this.TbcPrincipal.SelectedIndexChanged += new System.EventHandler(this.TbcPrincipal_SelectedIndexChanged);
            // 
            // TbpBuscar
            // 
            this.TbpBuscar.Controls.Add(this.DgvPrincipal);
            this.TbpBuscar.Location = new System.Drawing.Point(4, 22);
            this.TbpBuscar.Size = new System.Drawing.Size(793, 457);
            // 
            // TbpMantenimiento
            // 
            this.TbpMantenimiento.Controls.Add(this.ChkDiscontinuado);
            this.TbpMantenimiento.Controls.Add(this.label9);
            this.TbpMantenimiento.Controls.Add(this.NudOrdenar);
            this.TbpMantenimiento.Controls.Add(this.NudPedidos);
            this.TbpMantenimiento.Controls.Add(this.NudStock);
            this.TbpMantenimiento.Controls.Add(this.NudPu);
            this.TbpMantenimiento.Controls.Add(this.label8);
            this.TbpMantenimiento.Controls.Add(this.CboCategoria);
            this.TbpMantenimiento.Controls.Add(this.label7);
            this.TbpMantenimiento.Controls.Add(this.label3);
            this.TbpMantenimiento.Controls.Add(this.label6);
            this.TbpMantenimiento.Controls.Add(this.TxtUnidad);
            this.TbpMantenimiento.Controls.Add(this.label5);
            this.TbpMantenimiento.Controls.Add(this.label4);
            this.TbpMantenimiento.Controls.Add(this.TxtNombre);
            this.TbpMantenimiento.Controls.Add(this.label2);
            this.TbpMantenimiento.Controls.Add(this.TxtCodigo);
            this.TbpMantenimiento.Controls.Add(this.label1);
            this.TbpMantenimiento.Location = new System.Drawing.Point(4, 22);
            this.TbpMantenimiento.Size = new System.Drawing.Size(793, 457);
            // 
            // BtEliminar
            // 
            this.BtEliminar.TabIndex = 11;
            this.BtEliminar.Click += new System.EventHandler(this.BtEliminar_Click);
            // 
            // BtnNuevo
            // 
            this.BtnNuevo.TabIndex = 10;
            this.BtnNuevo.Click += new System.EventHandler(this.BtnNuevo_Click);
            // 
            // BtnGuardar
            // 
            this.BtnGuardar.TabIndex = 8;
            this.BtnGuardar.Click += new System.EventHandler(this.BtnGuardar_Click);
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.TabIndex = 9;
            this.BtnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
            // 
            // DgvPrincipal
            // 
            this.DgvPrincipal.AllowUserToAddRows = false;
            this.DgvPrincipal.AllowUserToDeleteRows = false;
            this.DgvPrincipal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvPrincipal.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DgvCodigo,
            this.DgvNombre,
            this.DgvCategory});
            this.DgvPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DgvPrincipal.Location = new System.Drawing.Point(2, 2);
            this.DgvPrincipal.Margin = new System.Windows.Forms.Padding(2);
            this.DgvPrincipal.MultiSelect = false;
            this.DgvPrincipal.Name = "DgvPrincipal";
            this.DgvPrincipal.ReadOnly = true;
            this.DgvPrincipal.RowTemplate.Height = 24;
            this.DgvPrincipal.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvPrincipal.Size = new System.Drawing.Size(789, 453);
            this.DgvPrincipal.TabIndex = 1;
            this.DgvPrincipal.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvPrincipal_CellContentDoubleClick);
            // 
            // DgvCodigo
            // 
            this.DgvCodigo.DataPropertyName = "ProductID";
            this.DgvCodigo.HeaderText = "Código";
            this.DgvCodigo.Name = "DgvCodigo";
            this.DgvCodigo.ReadOnly = true;
            // 
            // DgvNombre
            // 
            this.DgvNombre.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.DgvNombre.DataPropertyName = "ProductName";
            this.DgvNombre.HeaderText = "Nombre";
            this.DgvNombre.MinimumWidth = 200;
            this.DgvNombre.Name = "DgvNombre";
            this.DgvNombre.ReadOnly = true;
            // 
            // DgvCategory
            // 
            this.DgvCategory.DataPropertyName = "Categories";
            this.DgvCategory.HeaderText = "Categoria";
            this.DgvCategory.MinimumWidth = 200;
            this.DgvCategory.Name = "DgvCategory";
            this.DgvCategory.ReadOnly = true;
            this.DgvCategory.Width = 200;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 55);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Categoria:";
            // 
            // TxtNombre
            // 
            this.TxtNombre.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtNombre.Location = new System.Drawing.Point(73, 27);
            this.TxtNombre.Margin = new System.Windows.Forms.Padding(2);
            this.TxtNombre.Name = "TxtNombre";
            this.TxtNombre.Size = new System.Drawing.Size(712, 20);
            this.TxtNombre.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 31);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Nombre:";
            // 
            // TxtCodigo
            // 
            this.TxtCodigo.Location = new System.Drawing.Point(73, 4);
            this.TxtCodigo.Margin = new System.Windows.Forms.Padding(2);
            this.TxtCodigo.Name = "TxtCodigo";
            this.TxtCodigo.ReadOnly = true;
            this.TxtCodigo.Size = new System.Drawing.Size(59, 20);
            this.TxtCodigo.TabIndex = 7;
            this.TxtCodigo.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 8);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Código:";
            // 
            // CboCategoria
            // 
            this.CboCategoria.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CboCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CboCategoria.FormattingEnabled = true;
            this.CboCategoria.Location = new System.Drawing.Point(74, 52);
            this.CboCategoria.Name = "CboCategoria";
            this.CboCategoria.Size = new System.Drawing.Size(711, 21);
            this.CboCategoria.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 82);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Unidad:";
            // 
            // TxtUnidad
            // 
            this.TxtUnidad.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtUnidad.Location = new System.Drawing.Point(74, 78);
            this.TxtUnidad.Margin = new System.Windows.Forms.Padding(2);
            this.TxtUnidad.Name = "TxtUnidad";
            this.TxtUnidad.Size = new System.Drawing.Size(711, 20);
            this.TxtUnidad.TabIndex = 2;
            // 
            // NudPu
            // 
            this.NudPu.DecimalPlaces = 4;
            this.NudPu.Location = new System.Drawing.Point(74, 103);
            this.NudPu.Maximum = new decimal(new int[] {
            1410065408,
            2,
            0,
            0});
            this.NudPu.Name = "NudPu";
            this.NudPu.Size = new System.Drawing.Size(81, 20);
            this.NudPu.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(38, 107);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "P.U.:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(159, 107);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "Stock:";
            // 
            // NudStock
            // 
            this.NudStock.Location = new System.Drawing.Point(202, 103);
            this.NudStock.Maximum = new decimal(new int[] {
            1569325056,
            23283064,
            0,
            0});
            this.NudStock.Name = "NudStock";
            this.NudStock.Size = new System.Drawing.Size(81, 20);
            this.NudStock.TabIndex = 4;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(292, 107);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 13);
            this.label7.TabIndex = 4;
            this.label7.Text = "Pedidos:";
            // 
            // NudPedidos
            // 
            this.NudPedidos.Location = new System.Drawing.Point(345, 103);
            this.NudPedidos.Maximum = new decimal(new int[] {
            1569325056,
            23283064,
            0,
            0});
            this.NudPedidos.Name = "NudPedidos";
            this.NudPedidos.ReadOnly = true;
            this.NudPedidos.Size = new System.Drawing.Size(81, 20);
            this.NudPedidos.TabIndex = 5;
            this.NudPedidos.TabStop = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(433, 107);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(48, 13);
            this.label8.TabIndex = 4;
            this.label8.Text = "Ordenar:";
            // 
            // NudOrdenar
            // 
            this.NudOrdenar.Location = new System.Drawing.Point(486, 103);
            this.NudOrdenar.Maximum = new decimal(new int[] {
            1569325056,
            23283064,
            0,
            0});
            this.NudOrdenar.Name = "NudOrdenar";
            this.NudOrdenar.Size = new System.Drawing.Size(81, 20);
            this.NudOrdenar.TabIndex = 6;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(31, 131);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(38, 13);
            this.label9.TabIndex = 10;
            this.label9.Text = "Desc.:";
            // 
            // ChkDiscontinuado
            // 
            this.ChkDiscontinuado.AutoSize = true;
            this.ChkDiscontinuado.Location = new System.Drawing.Point(75, 131);
            this.ChkDiscontinuado.Name = "ChkDiscontinuado";
            this.ChkDiscontinuado.Size = new System.Drawing.Size(15, 14);
            this.ChkDiscontinuado.TabIndex = 7;
            this.ChkDiscontinuado.UseVisualStyleBackColor = true;
            // 
            // FrmManProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(801, 613);
            this.Name = "FrmManProducto";
            this.Text = "Mantenimiento Producto";
            this.Load += new System.EventHandler(this.FrmManProducto_Load);
            this.TbcPrincipal.ResumeLayout(false);
            this.TbpBuscar.ResumeLayout(false);
            this.TbpMantenimiento.ResumeLayout(false);
            this.TbpMantenimiento.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvPrincipal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NudPu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NudStock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NudPedidos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NudOrdenar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DgvPrincipal;
        private System.Windows.Forms.DataGridViewTextBoxColumn DgvCodigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn DgvNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn DgvCategory;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtNombre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtCodigo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox CboCategoria;
        private System.Windows.Forms.NumericUpDown NudOrdenar;
        private System.Windows.Forms.NumericUpDown NudPedidos;
        private System.Windows.Forms.NumericUpDown NudStock;
        private System.Windows.Forms.NumericUpDown NudPu;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TxtUnidad;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox ChkDiscontinuado;
        private System.Windows.Forms.Label label9;
    }
}
