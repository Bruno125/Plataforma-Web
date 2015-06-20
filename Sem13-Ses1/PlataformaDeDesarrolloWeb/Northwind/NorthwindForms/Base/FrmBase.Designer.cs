namespace NorthwindForms.Base
{
    partial class FrmBase
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.BtEliminar = new System.Windows.Forms.Button();
            this.BtnNuevo = new System.Windows.Forms.Button();
            this.BtnGuardar = new System.Windows.Forms.Button();
            this.BtnCancelar = new System.Windows.Forms.Button();
            this.TbcPrincipal = new System.Windows.Forms.TabControl();
            this.TbpBuscar = new System.Windows.Forms.TabPage();
            this.TbpMantenimiento = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.LblTitulo = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2.SuspendLayout();
            this.TbcPrincipal.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.BtEliminar);
            this.panel2.Controls.Add(this.BtnNuevo);
            this.panel2.Controls.Add(this.BtnGuardar);
            this.panel2.Controls.Add(this.BtnCancelar);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 660);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1068, 94);
            this.panel2.TabIndex = 1;
            // 
            // BtEliminar
            // 
            this.BtEliminar.Image = global::NorthwindForms.Properties.Resources.delete;
            this.BtEliminar.Location = new System.Drawing.Point(12, 11);
            this.BtEliminar.Name = "BtEliminar";
            this.BtEliminar.Size = new System.Drawing.Size(85, 70);
            this.BtEliminar.TabIndex = 0;
            this.BtEliminar.Text = "&Elimiar";
            this.BtEliminar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtEliminar.UseVisualStyleBackColor = true;
            // 
            // BtnNuevo
            // 
            this.BtnNuevo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnNuevo.Image = global::NorthwindForms.Properties.Resources.newobject;
            this.BtnNuevo.Location = new System.Drawing.Point(789, 11);
            this.BtnNuevo.Name = "BtnNuevo";
            this.BtnNuevo.Size = new System.Drawing.Size(85, 70);
            this.BtnNuevo.TabIndex = 0;
            this.BtnNuevo.Text = "&Nuevo";
            this.BtnNuevo.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnNuevo.UseVisualStyleBackColor = true;
            // 
            // BtnGuardar
            // 
            this.BtnGuardar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnGuardar.Image = global::NorthwindForms.Properties.Resources.save;
            this.BtnGuardar.Location = new System.Drawing.Point(880, 11);
            this.BtnGuardar.Name = "BtnGuardar";
            this.BtnGuardar.Size = new System.Drawing.Size(85, 70);
            this.BtnGuardar.TabIndex = 0;
            this.BtnGuardar.Text = "&Guardar";
            this.BtnGuardar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnGuardar.UseVisualStyleBackColor = true;
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnCancelar.Image = global::NorthwindForms.Properties.Resources.cancel;
            this.BtnCancelar.Location = new System.Drawing.Point(971, 11);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(85, 70);
            this.BtnCancelar.TabIndex = 0;
            this.BtnCancelar.Text = "&Cancelar";
            this.BtnCancelar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnCancelar.UseVisualStyleBackColor = true;
            // 
            // TbcPrincipal
            // 
            this.TbcPrincipal.Controls.Add(this.TbpBuscar);
            this.TbcPrincipal.Controls.Add(this.TbpMantenimiento);
            this.TbcPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TbcPrincipal.Location = new System.Drawing.Point(0, 67);
            this.TbcPrincipal.Name = "TbcPrincipal";
            this.TbcPrincipal.SelectedIndex = 0;
            this.TbcPrincipal.Size = new System.Drawing.Size(1068, 593);
            this.TbcPrincipal.TabIndex = 2;
            // 
            // TbpBuscar
            // 
            this.TbpBuscar.Location = new System.Drawing.Point(4, 25);
            this.TbpBuscar.Name = "TbpBuscar";
            this.TbpBuscar.Padding = new System.Windows.Forms.Padding(3);
            this.TbpBuscar.Size = new System.Drawing.Size(1060, 564);
            this.TbpBuscar.TabIndex = 0;
            this.TbpBuscar.Text = "Buscar";
            this.TbpBuscar.UseVisualStyleBackColor = true;
            // 
            // TbpMantenimiento
            // 
            this.TbpMantenimiento.Location = new System.Drawing.Point(4, 25);
            this.TbpMantenimiento.Name = "TbpMantenimiento";
            this.TbpMantenimiento.Padding = new System.Windows.Forms.Padding(3);
            this.TbpMantenimiento.Size = new System.Drawing.Size(1060, 564);
            this.TbpMantenimiento.TabIndex = 1;
            this.TbpMantenimiento.Text = "Mantenimiento";
            this.TbpMantenimiento.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::NorthwindForms.Properties.Resources.hgradient;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.LblTitulo);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1068, 67);
            this.panel1.TabIndex = 0;
            // 
            // LblTitulo
            // 
            this.LblTitulo.AutoSize = true;
            this.LblTitulo.BackColor = System.Drawing.Color.Transparent;
            this.LblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTitulo.ForeColor = System.Drawing.Color.White;
            this.LblTitulo.Location = new System.Drawing.Point(69, 9);
            this.LblTitulo.Name = "LblTitulo";
            this.LblTitulo.Size = new System.Drawing.Size(118, 32);
            this.LblTitulo.TabIndex = 1;
            this.LblTitulo.Text = "<Titulo>";
            this.LblTitulo.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::NorthwindForms.Properties.Resources.credicard;
            this.pictureBox1.Location = new System.Drawing.Point(12, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(51, 52);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // FrmBase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1068, 754);
            this.Controls.Add(this.TbcPrincipal);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "FrmBase";
            this.Text = "FrmBase";
            this.Load += new System.EventHandler(this.FrmBase_Load);
            this.panel2.ResumeLayout(false);
            this.TbcPrincipal.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label LblTitulo;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
        protected internal System.Windows.Forms.TabControl TbcPrincipal;
        protected System.Windows.Forms.TabPage TbpBuscar;
        protected System.Windows.Forms.TabPage TbpMantenimiento;
        protected internal System.Windows.Forms.Button BtEliminar;
        protected internal System.Windows.Forms.Button BtnNuevo;
        protected internal System.Windows.Forms.Button BtnGuardar;
        protected internal System.Windows.Forms.Button BtnCancelar;
    }
}