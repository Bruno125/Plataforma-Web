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
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Categoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TxtNombre = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtCodigo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.ComboCategoria = new System.Windows.Forms.ComboBox();
            this.ChbDiscontinued = new System.Windows.Forms.CheckBox();
            this.TxtUnitPrice = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TxtUnitStock = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.TxtUnitOrder = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.TxtReorder = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.TxtSupplier = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.TbcPrincipal.SuspendLayout();
            this.TbpBuscar.SuspendLayout();
            this.TbpMantenimiento.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvPrincipal)).BeginInit();
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
            this.TbpBuscar.Size = new System.Drawing.Size(793, 453);
            // 
            // TbpMantenimiento
            // 
            this.TbpMantenimiento.Controls.Add(this.TxtSupplier);
            this.TbpMantenimiento.Controls.Add(this.label8);
            this.TbpMantenimiento.Controls.Add(this.TxtReorder);
            this.TbpMantenimiento.Controls.Add(this.label7);
            this.TbpMantenimiento.Controls.Add(this.TxtUnitOrder);
            this.TbpMantenimiento.Controls.Add(this.label6);
            this.TbpMantenimiento.Controls.Add(this.TxtUnitStock);
            this.TbpMantenimiento.Controls.Add(this.label5);
            this.TbpMantenimiento.Controls.Add(this.TxtUnitPrice);
            this.TbpMantenimiento.Controls.Add(this.label4);
            this.TbpMantenimiento.Controls.Add(this.ChbDiscontinued);
            this.TbpMantenimiento.Controls.Add(this.ComboCategoria);
            this.TbpMantenimiento.Controls.Add(this.label3);
            this.TbpMantenimiento.Controls.Add(this.TxtNombre);
            this.TbpMantenimiento.Controls.Add(this.label2);
            this.TbpMantenimiento.Controls.Add(this.TxtCodigo);
            this.TbpMantenimiento.Controls.Add(this.label1);
            this.TbpMantenimiento.Location = new System.Drawing.Point(4, 22);
            this.TbpMantenimiento.Size = new System.Drawing.Size(793, 453);
            // 
            // BtEliminar
            // 
            this.BtEliminar.Click += new System.EventHandler(this.BtEliminar_Click);
            // 
            // BtnNuevo
            // 
            this.BtnNuevo.Click += new System.EventHandler(this.BtnNuevo_Click);
            // 
            // BtnGuardar
            // 
            this.BtnGuardar.Click += new System.EventHandler(this.BtnGuardar_Click);
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
            // 
            // DgvPrincipal
            // 
            this.DgvPrincipal.AllowUserToAddRows = false;
            this.DgvPrincipal.AllowUserToDeleteRows = false;
            this.DgvPrincipal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvPrincipal.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Nombre,
            this.Categoria});
            this.DgvPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DgvPrincipal.Location = new System.Drawing.Point(2, 2);
            this.DgvPrincipal.MultiSelect = false;
            this.DgvPrincipal.Name = "DgvPrincipal";
            this.DgvPrincipal.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvPrincipal.Size = new System.Drawing.Size(789, 449);
            this.DgvPrincipal.TabIndex = 0;
            this.DgvPrincipal.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvPrincipal_CellDoubleClick);
            // 
            // ID
            // 
            this.ID.DataPropertyName = "ProductID";
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            // 
            // Nombre
            // 
            this.Nombre.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Nombre.DataPropertyName = "ProductName";
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            // 
            // Categoria
            // 
            this.Categoria.DataPropertyName = "Categories";
            this.Categoria.HeaderText = "Categoria";
            this.Categoria.Name = "Categoria";
            this.Categoria.Width = 200;
            // 
            // TxtNombre
            // 
            this.TxtNombre.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtNombre.Location = new System.Drawing.Point(98, 41);
            this.TxtNombre.Margin = new System.Windows.Forms.Padding(2);
            this.TxtNombre.Name = "TxtNombre";
            this.TxtNombre.Size = new System.Drawing.Size(679, 20);
            this.TxtNombre.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 44);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Nombre:";
            // 
            // TxtCodigo
            // 
            this.TxtCodigo.Location = new System.Drawing.Point(98, 17);
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
            this.label1.Location = new System.Drawing.Point(21, 20);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Código:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 201);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Categoria:";
            // 
            // ComboCategoria
            // 
            this.ComboCategoria.FormattingEnabled = true;
            this.ComboCategoria.Location = new System.Drawing.Point(98, 198);
            this.ComboCategoria.Name = "ComboCategoria";
            this.ComboCategoria.Size = new System.Drawing.Size(164, 21);
            this.ComboCategoria.TabIndex = 9;
            // 
            // ChbDiscontinued
            // 
            this.ChbDiscontinued.AutoSize = true;
            this.ChbDiscontinued.Location = new System.Drawing.Point(24, 225);
            this.ChbDiscontinued.Name = "ChbDiscontinued";
            this.ChbDiscontinued.Size = new System.Drawing.Size(88, 17);
            this.ChbDiscontinued.TabIndex = 11;
            this.ChbDiscontinued.Text = "Discontinued";
            this.ChbDiscontinued.UseVisualStyleBackColor = true;
            // 
            // TxtUnitPrice
            // 
            this.TxtUnitPrice.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtUnitPrice.Location = new System.Drawing.Point(98, 65);
            this.TxtUnitPrice.Margin = new System.Windows.Forms.Padding(2);
            this.TxtUnitPrice.Name = "TxtUnitPrice";
            this.TxtUnitPrice.Size = new System.Drawing.Size(103, 20);
            this.TxtUnitPrice.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 68);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Unit price:";
            // 
            // TxtUnitStock
            // 
            this.TxtUnitStock.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtUnitStock.Location = new System.Drawing.Point(98, 89);
            this.TxtUnitStock.Margin = new System.Windows.Forms.Padding(2);
            this.TxtUnitStock.Name = "TxtUnitStock";
            this.TxtUnitStock.Size = new System.Drawing.Size(103, 20);
            this.TxtUnitStock.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 92);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Unit stock:";
            // 
            // TxtUnitOrder
            // 
            this.TxtUnitOrder.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtUnitOrder.Location = new System.Drawing.Point(98, 113);
            this.TxtUnitOrder.Margin = new System.Windows.Forms.Padding(2);
            this.TxtUnitOrder.Name = "TxtUnitOrder";
            this.TxtUnitOrder.Size = new System.Drawing.Size(103, 20);
            this.TxtUnitOrder.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(21, 116);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 13);
            this.label6.TabIndex = 17;
            this.label6.Text = "Unit order:";
            // 
            // TxtReorder
            // 
            this.TxtReorder.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtReorder.Location = new System.Drawing.Point(98, 137);
            this.TxtReorder.Margin = new System.Windows.Forms.Padding(2);
            this.TxtReorder.Name = "TxtReorder";
            this.TxtReorder.Size = new System.Drawing.Size(103, 20);
            this.TxtReorder.TabIndex = 5;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(21, 140);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(73, 13);
            this.label7.TabIndex = 19;
            this.label7.Text = "Reorder level:";
            // 
            // TxtSupplier
            // 
            this.TxtSupplier.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtSupplier.Location = new System.Drawing.Point(98, 162);
            this.TxtSupplier.Margin = new System.Windows.Forms.Padding(2);
            this.TxtSupplier.Name = "TxtSupplier";
            this.TxtSupplier.Size = new System.Drawing.Size(103, 20);
            this.TxtSupplier.TabIndex = 20;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(21, 165);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(54, 13);
            this.label8.TabIndex = 21;
            this.label8.Text = "SupplierId";
            // 
            // FrmManProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(801, 609);
            this.Name = "FrmManProducto";
            this.Text = "Mantenimiento productos";
            this.Load += new System.EventHandler(this.FrmManProducto_Load);
            this.TbcPrincipal.ResumeLayout(false);
            this.TbpBuscar.ResumeLayout(false);
            this.TbpMantenimiento.ResumeLayout(false);
            this.TbpMantenimiento.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvPrincipal)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DgvPrincipal;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtNombre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtCodigo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox ChbDiscontinued;
        private System.Windows.Forms.ComboBox ComboCategoria;
        private System.Windows.Forms.TextBox TxtReorder;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox TxtUnitOrder;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TxtUnitStock;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TxtUnitPrice;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Categoria;
        private System.Windows.Forms.TextBox TxtSupplier;
        private System.Windows.Forms.Label label8;
    }
}
