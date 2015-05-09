using NorthwindBusiness.Business;
using NorthwindEntity.Entity;
using NorthwindForms.Util;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Linq;

namespace NorthwindForms.Mantenimiento
{
    public partial class FrmManUsuario : NorthwindForms.Base.FrmBase
    {
        private UserBusiness UserBusiness = UserBusiness.ObtenerInstancia();
        List<UsuarioWrapper> Users;
        public FrmManUsuario()
        {
            InitializeComponent();
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
        private void LlenarDatagrid()
        {
            IList <UserDto> UsersAux =  UserBusiness.Listar();
            Users = (from users in UsersAux
                     select new UsuarioWrapper
                     {
                         UserId=users.UserId,
                         NombreCompleto = users.Name + " " + users.LastName
                     }).ToList();

            this.DgvPrincipal.DataSource = Users;
        }

        private void BtnNuevo_Click(object sender, EventArgs e)
        {
            this.EsNuevo = false;
            this.Limpiar();
            this.TbcPrincipal.SelectedIndex = 1;
            this.TxtNombre.Focus();
        }

        private void Limpiar()
        {
            this.TxtCodigo.Text = string.Empty;
            this.TxtNombre.Text = string.Empty;
            this.TxtApellido.Text = string.Empty;
            this.DtpBirthday.Value = DateTime.Now;
            this.TxtUsuario.Text = string.Empty;
            this.TxtClave.Text = string.Empty;
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (!EsNuevo)
                {
                    UserDto UserDto = new UserDto();
                    UserDto.Name = this.TxtNombre.Text.Trim();
                    UserDto.LastName = this.TxtNombre.Text.Trim();
                    UserDto.Birthday = DtpBirthday.Value.ToString();
                    UserDto.UserName = this.TxtUsuario.Text.Trim();
                    UserDto.Password = this.TxtClave.Text.Trim();
                    if (this.TxtCodigo.Text.Length <= 0)
                    {
                        this.UserBusiness.Insertar(UserDto);
                        UtilForms.MensajeExito(this, string.Format(Constantes.EXITO_GUARDAR, "Usuario"));
                        this.Limpiar();
                    }
                    else
                    {
                        UserDto.UserId = Convert.ToInt32(this.TxtCodigo.Text);
                        this.UserBusiness.Actualizar(UserDto);
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

        private void DgvPrincipal_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0)
                {

                    UserDto UserDto =
                        UserBusiness.Obtener(Convert.ToInt32(DgvPrincipal.Rows[e.RowIndex].Cells[0].Value));
                    this.EsNuevo = false;
                    this.TxtCodigo.Text = UserDto.UserId.ToString();
                    this.TxtNombre.Text = UserDto.Name;
                    this.TxtApellido.Text = UserDto.LastName;
                    this.DtpBirthday.Value = DateTime.Parse(UserDto.Birthday);
                    this.TxtUsuario.Text = UserDto.UserName;
                    this.TxtClave.Text = UserDto.Password;
                    this.TbcPrincipal.SelectedIndex = 1;
                }

            }
            catch (Exception E)
            {
                UtilForms.MensajeError(this, string.Format(Constantes.ERROR, E.Message));
            }
        }

        private void BtEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.DgvPrincipal.SelectedRows[0].Index >= 0)
                {
                    UserBusiness.Eliminar(Convert.ToInt32(
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

        public class UsuarioWrapper{
            public int UserId {get; set; }
            public string NombreCompleto {get; set;}
        }

    }
}
