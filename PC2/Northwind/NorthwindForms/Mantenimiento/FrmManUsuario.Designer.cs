namespace NorthwindForms.Mantenimiento
{
    partial class FrmManUsuario
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
            this.TxtClave = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.TxtUsuario = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.TxtApellido = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TxtNombre = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtCodigo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.DtpBirthday = new System.Windows.Forms.DateTimePicker();
            this.TbcPrincipal.SuspendLayout();
            this.TbpBuscar.SuspendLayout();
            this.TbpMantenimiento.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvPrincipal)).BeginInit();
            this.SuspendLayout();
            // 
            // TbpBuscar
            // 
            this.TbpBuscar.Controls.Add(this.DgvPrincipal);
            this.TbpBuscar.Location = new System.Drawing.Point(4, 22);
            this.TbpBuscar.Size = new System.Drawing.Size(793, 453);
            // 
            // TbpMantenimiento
            // 
            this.TbpMantenimiento.Controls.Add(this.DtpBirthday);
            this.TbpMantenimiento.Controls.Add(this.TxtClave);
            this.TbpMantenimiento.Controls.Add(this.label7);
            this.TbpMantenimiento.Controls.Add(this.TxtUsuario);
            this.TbpMantenimiento.Controls.Add(this.label6);
            this.TbpMantenimiento.Controls.Add(this.label5);
            this.TbpMantenimiento.Controls.Add(this.TxtApellido);
            this.TbpMantenimiento.Controls.Add(this.label4);
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
            this.DgvCodigo,
            this.DgvNombre});
            this.DgvPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DgvPrincipal.Location = new System.Drawing.Point(2, 2);
            this.DgvPrincipal.Margin = new System.Windows.Forms.Padding(2);
            this.DgvPrincipal.MultiSelect = false;
            this.DgvPrincipal.Name = "DgvPrincipal";
            this.DgvPrincipal.ReadOnly = true;
            this.DgvPrincipal.RowTemplate.Height = 24;
            this.DgvPrincipal.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvPrincipal.Size = new System.Drawing.Size(789, 449);
            this.DgvPrincipal.TabIndex = 1;
            this.DgvPrincipal.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvPrincipal_CellDoubleClick);
            // 
            // DgvCodigo
            // 
            this.DgvCodigo.DataPropertyName = "UserId";
            this.DgvCodigo.HeaderText = "ID";
            this.DgvCodigo.Name = "DgvCodigo";
            this.DgvCodigo.ReadOnly = true;
            // 
            // DgvNombre
            // 
            this.DgvNombre.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.DgvNombre.DataPropertyName = "NombreCompleto";
            this.DgvNombre.HeaderText = "Nombre completo";
            this.DgvNombre.MinimumWidth = 200;
            this.DgvNombre.Name = "DgvNombre";
            this.DgvNombre.ReadOnly = true;
            // 
            // TxtClave
            // 
            this.TxtClave.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtClave.Location = new System.Drawing.Point(90, 135);
            this.TxtClave.Margin = new System.Windows.Forms.Padding(2);
            this.TxtClave.Name = "TxtClave";
            this.TxtClave.Size = new System.Drawing.Size(340, 20);
            this.TxtClave.TabIndex = 27;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(13, 138);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(34, 13);
            this.label7.TabIndex = 33;
            this.label7.Text = "Clave";
            // 
            // TxtUsuario
            // 
            this.TxtUsuario.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtUsuario.Location = new System.Drawing.Point(90, 111);
            this.TxtUsuario.Margin = new System.Windows.Forms.Padding(2);
            this.TxtUsuario.Name = "TxtUsuario";
            this.TxtUsuario.Size = new System.Drawing.Size(340, 20);
            this.TxtUsuario.TabIndex = 25;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 114);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 13);
            this.label6.TabIndex = 32;
            this.label6.Text = "Usuario";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 90);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 13);
            this.label5.TabIndex = 31;
            this.label5.Text = "Fec. Nac.";
            // 
            // TxtApellido
            // 
            this.TxtApellido.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtApellido.Location = new System.Drawing.Point(90, 63);
            this.TxtApellido.Margin = new System.Windows.Forms.Padding(2);
            this.TxtApellido.Name = "TxtApellido";
            this.TxtApellido.Size = new System.Drawing.Size(696, 20);
            this.TxtApellido.TabIndex = 23;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 66);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 30;
            this.label4.Text = "Apellido";
            // 
            // TxtNombre
            // 
            this.TxtNombre.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtNombre.Location = new System.Drawing.Point(90, 39);
            this.TxtNombre.Margin = new System.Windows.Forms.Padding(2);
            this.TxtNombre.Name = "TxtNombre";
            this.TxtNombre.Size = new System.Drawing.Size(696, 20);
            this.TxtNombre.TabIndex = 22;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 42);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 26;
            this.label2.Text = "Nombre:";
            // 
            // TxtCodigo
            // 
            this.TxtCodigo.Location = new System.Drawing.Point(90, 15);
            this.TxtCodigo.Margin = new System.Windows.Forms.Padding(2);
            this.TxtCodigo.Name = "TxtCodigo";
            this.TxtCodigo.ReadOnly = true;
            this.TxtCodigo.Size = new System.Drawing.Size(59, 20);
            this.TxtCodigo.TabIndex = 29;
            this.TxtCodigo.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 18);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 28;
            this.label1.Text = "Código:";
            // 
            // DtpBirthday
            // 
            this.DtpBirthday.Location = new System.Drawing.Point(90, 88);
            this.DtpBirthday.Name = "DtpBirthday";
            this.DtpBirthday.Size = new System.Drawing.Size(200, 20);
            this.DtpBirthday.TabIndex = 34;
            // 
            // FrmManUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(801, 609);
            this.Name = "FrmManUsuario";
            this.Text = "Mantenimiento usuario";
            this.Load += new System.EventHandler(this.FrmManUsuario_Load);
            this.TbcPrincipal.ResumeLayout(false);
            this.TbpBuscar.ResumeLayout(false);
            this.TbpMantenimiento.ResumeLayout(false);
            this.TbpMantenimiento.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvPrincipal)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DgvPrincipal;
        private System.Windows.Forms.TextBox TxtClave;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox TxtUsuario;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TxtApellido;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TxtNombre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtCodigo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker DtpBirthday;
        private System.Windows.Forms.DataGridViewTextBoxColumn DgvCodigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn DgvNombre;
    }
}
