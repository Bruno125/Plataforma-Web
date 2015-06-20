using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
//Importaciones
using NorthwindBusiness.Business;
using NorthwindEntity.Entity;
using NorthwindForms.Util;
namespace NorthwindForms.Mantenimiento
{
    public partial class FrmManUsuario : NorthwindForms.Base.FrmBase
    {

        private UsersBusiness UsersBusiness = UsersBusiness.ObtenerInstancia();

        private void LlenarDatagrid()
        {
            this.DgvPrincipal.AutoGenerateColumns = false;
            this.DgvPrincipal.DataSource = UsersBusiness.Listar();
        }

        private void Limpiar()
        {
            this.TxtCodigo.Text = string.Empty;
            this.TxtNombre.Text = string.Empty;
            this.TxtApellido.Text = string.Empty;
            this.DtpFechaNacimiento.Value = DateTime.Today;
            this.TxtUsuario.Text = string.Empty;
            this.TxtClave.Text = string.Empty;
        }

        public FrmManUsuario()
        {
            InitializeComponent();
        }

        private void BtEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.DgvPrincipal.SelectedRows[0].Index >= 0)
                {
                    UsersBusiness.Eliminar(Convert.ToInt32(
                        DgvPrincipal.Rows[DgvPrincipal.SelectedRows[0].Index].Cells[0].Value.ToString()));
                    this.LlenarDatagrid();
                    UtilForms.MensajeExito(this, string.Format(Constantes.EXITO_ELIMINAR, "Usuario"));
                    this.EsNuevo = true;
                    this.Limpiar();
                }
            }
            catch (Exception Ex)
            {
                UtilForms.MensajeError(this, string.Format(Constantes.ERROR, Ex.Message));
            }
        }

        private void BtnNuevo_Click(object sender, EventArgs e)
        {
            this.EsNuevo = false;
            this.Limpiar();
            this.TbcPrincipal.SelectedIndex = 1;
            this.TxtNombre.Focus();
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (!EsNuevo)
                {
                    UsersDto UsersDto = new UsersDto();
                    UsersDto.Name = this.TxtNombre.Text.Trim().ToUpper();
                    UsersDto.LastName = this.TxtApellido.Text.Trim().ToUpper();
                    UsersDto.Birthdate = this.DtpFechaNacimiento.Value;
                    UsersDto.UserId = this.TxtUsuario.Text;
                    UsersDto.Password = this.TxtClave.Text;

                    if (this.TxtCodigo.Text.Length <= 0)
                    {
                        this.UsersBusiness.Insertar(UsersDto);
                        UtilForms.MensajeExito(this, string.Format(Constantes.EXITO_GUARDAR, "Usuario"));
                        this.Limpiar();
                    }
                    else
                    {
                        UsersDto.Id = Convert.ToInt32(this.TxtCodigo.Text);
                        this.UsersBusiness.Actualizar(UsersDto);
                        UtilForms.MensajeExito(this, string.Format(Constantes.EXITO_ACTUALIZAR, "Usuario"));
                    }
                    this.TxtNombre.Focus();
                    this.LlenarDatagrid();
                }
            }
            catch (Exception Ex)
            {

                UtilForms.MensajeError(this, string.Format(Constantes.ERROR, Ex.Message));
            }
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            this.Limpiar();
            this.EsNuevo = true;
            this.TbcPrincipal.SelectedIndex = 0;
        }

        private void FrmManUsuario_Load(object sender, EventArgs e)
        {
            try
            {
                this.LlenarDatagrid();
            }
            catch (Exception Ex)
            {
                UtilForms.MensajeError(this, string.Format(Constantes.ERROR, Ex.Message));
            }
        }

        private void DgvPrincipal_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                this.EsNuevo = false;
                this.TxtCodigo.Text = DgvPrincipal.Rows[e.RowIndex].Cells[0].Value.ToString();
                UsersDto UsersDto = UsersBusiness.Obtener(Convert.ToInt32(this.TxtCodigo.Text));
                this.TxtNombre.Text = UsersDto.Name;
                this.TxtApellido.Text = UsersDto.LastName;
                this.DtpFechaNacimiento.Value = UsersDto.Birthdate;
                this.TxtUsuario.Text = UsersDto.UserId;
                this.TxtClave.Text = UsersDto.Password;
                this.TbcPrincipal.SelectedIndex = 1;
            }
        }

        private void TbcPrincipal_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (EsNuevo && TbcPrincipal.SelectedIndex != 0)
            {
                this.TbcPrincipal.SelectedIndex = 0;
                UtilForms.MensajeInformativo(this);
            }
        }
    }
}
