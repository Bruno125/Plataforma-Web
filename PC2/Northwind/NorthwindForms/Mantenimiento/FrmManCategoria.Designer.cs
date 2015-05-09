﻿namespace NorthwindForms.Mantenimiento
{
    partial class FrmManCategoria
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
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
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.DgvPrincipal = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtCodigo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtNombre = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtDescripcion = new System.Windows.Forms.TextBox();
            this.DgvCodigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DgvNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DgvDescripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            // 
            // TbpMantenimiento
            // 
            this.TbpMantenimiento.Controls.Add(this.TxtDescripcion);
            this.TbpMantenimiento.Controls.Add(this.label3);
            this.TbpMantenimiento.Controls.Add(this.TxtNombre);
            this.TbpMantenimiento.Controls.Add(this.label2);
            this.TbpMantenimiento.Controls.Add(this.TxtCodigo);
            this.TbpMantenimiento.Controls.Add(this.label1);
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
            this.DgvCodigo,
            this.DgvNombre,
            this.DgvDescripcion});
            this.DgvPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DgvPrincipal.Location = new System.Drawing.Point(3, 3);
            this.DgvPrincipal.MultiSelect = false;
            this.DgvPrincipal.Name = "DgvPrincipal";
            this.DgvPrincipal.ReadOnly = true;
            this.DgvPrincipal.RowTemplate.Height = 24;
            this.DgvPrincipal.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvPrincipal.Size = new System.Drawing.Size(1054, 558);
            this.DgvPrincipal.TabIndex = 0;
            this.DgvPrincipal.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvPrincipal_CellDoubleClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Código:";
            // 
            // TxtCodigo
            // 
            this.TxtCodigo.Location = new System.Drawing.Point(94, 22);
            this.TxtCodigo.Name = "TxtCodigo";
            this.TxtCodigo.ReadOnly = true;
            this.TxtCodigo.Size = new System.Drawing.Size(77, 22);
            this.TxtCodigo.TabIndex = 1;
            this.TxtCodigo.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Nombre:";
            // 
            // TxtNombre
            // 
            this.TxtNombre.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtNombre.Location = new System.Drawing.Point(94, 50);
            this.TxtNombre.Name = "TxtNombre";
            this.TxtNombre.Size = new System.Drawing.Size(958, 22);
            this.TxtNombre.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "Descripción:";
            // 
            // TxtDescripcion
            // 
            this.TxtDescripcion.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtDescripcion.Location = new System.Drawing.Point(94, 78);
            this.TxtDescripcion.Name = "TxtDescripcion";
            this.TxtDescripcion.Size = new System.Drawing.Size(958, 22);
            this.TxtDescripcion.TabIndex = 1;
            // 
            // DgvCodigo
            // 
            this.DgvCodigo.DataPropertyName = "CategoryID";
            this.DgvCodigo.HeaderText = "Código";
            this.DgvCodigo.Name = "DgvCodigo";
            this.DgvCodigo.ReadOnly = true;
            // 
            // DgvNombre
            // 
            this.DgvNombre.DataPropertyName = "CategoryName";
            this.DgvNombre.HeaderText = "Nombre";
            this.DgvNombre.MinimumWidth = 200;
            this.DgvNombre.Name = "DgvNombre";
            this.DgvNombre.ReadOnly = true;
            this.DgvNombre.Width = 200;
            // 
            // DgvDescripcion
            // 
            this.DgvDescripcion.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.DgvDescripcion.DataPropertyName = "Description";
            this.DgvDescripcion.HeaderText = "Descripción";
            this.DgvDescripcion.Name = "DgvDescripcion";
            this.DgvDescripcion.ReadOnly = true;
            // 
            // FrmManCategoria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.ClientSize = new System.Drawing.Size(1068, 754);
            this.Name = "FrmManCategoria";
            this.Text = "Mantenimiento de Categoria";
            this.Load += new System.EventHandler(this.FrmManCategoria_Load);
            this.TbcPrincipal.ResumeLayout(false);
            this.TbpBuscar.ResumeLayout(false);
            this.TbpMantenimiento.ResumeLayout(false);
            this.TbpMantenimiento.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvPrincipal)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DgvPrincipal;
        private System.Windows.Forms.TextBox TxtDescripcion;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtNombre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtCodigo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn DgvCodigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn DgvNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn DgvDescripcion;
    }
}
