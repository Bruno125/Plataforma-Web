using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Importaciones
using NorthwindUtil.ExceptionPer;
using NorthwindEntity.Entity;
using NorthwindBusiness.Base;
using NorthwindBusiness.Util;
using System.Data;
using System.Xml;

namespace NorthwindBusiness.Business
{
    public sealed class UsersBusiness : BaseBusiness<UsersDto, int>
    {
        private readonly string Ruta = "../../Users.xml";

        #region
        private static UsersBusiness USERS_BUSINESS = new UsersBusiness();

        private UsersBusiness()
        {

        }
        public static UsersBusiness ObtenerInstancia()
        {
            return USERS_BUSINESS;
        }
        #endregion

        private void CrearArchivo(UsersDto UsersDto)
        {
            XmlTextWriter XmlTextWriter = new XmlTextWriter(this.Ruta, null);
            XmlTextWriter.Formatting = Formatting.Indented;
            XmlTextWriter.WriteStartDocument();
            XmlTextWriter.WriteStartElement("users");
            XmlTextWriter.WriteStartElement("user");
            XmlTextWriter.WriteAttributeString("id", "1");
            XmlTextWriter.WriteElementString("name", UsersDto.Name);
            XmlTextWriter.WriteElementString("lastname", UsersDto.LastName);
            XmlTextWriter.WriteElementString("birthdate", UsersDto.Birthdate.ToString());
            XmlTextWriter.WriteElementString("userid", UsersDto.UserId);
            XmlTextWriter.WriteElementString("password", UsersDto.Password);
            XmlTextWriter.WriteEndElement();
            XmlTextWriter.WriteEndElement();
            XmlTextWriter.Flush();
            XmlTextWriter.Close();
        }

        private void AgregarElemento(UsersDto UsersDto)
        {
            List<UsersDto> ListaUsers = this.Listar();
            int Id = ListaUsers[ListaUsers.Count - 1].Id + 1;
            XmlDocument XmlDocument = new XmlDocument();
            XmlDocument.Load(this.Ruta);

            XmlElement ElementoUser = XmlDocument.CreateElement("user");
            ElementoUser.SetAttribute("id", Convert.ToString(Id));

            XmlElement ElementoName = XmlDocument.CreateElement("name");
            ElementoName.InnerText = UsersDto.Name;
            ElementoUser.AppendChild(ElementoName);

            XmlElement ElementoLastName = XmlDocument.CreateElement("lastname");
            ElementoLastName.InnerText = UsersDto.LastName;
            ElementoUser.AppendChild(ElementoLastName);

            XmlElement ElementoBirthdate = XmlDocument.CreateElement("birthdate");
            ElementoBirthdate.InnerText = UsersDto.Birthdate.ToString();
            ElementoUser.AppendChild(ElementoBirthdate);

            XmlElement ElementoUserid = XmlDocument.CreateElement("userid");
            ElementoUserid.InnerText = UsersDto.UserId;
            ElementoUser.AppendChild(ElementoUserid);

            XmlElement ElementoPassword = XmlDocument.CreateElement("password");
            ElementoPassword.InnerText = UsersDto.Password;
            ElementoUser.AppendChild(ElementoPassword);


            XmlDocument.DocumentElement.AppendChild(ElementoUser);
            XmlTextWriter XmlTextWriter = new XmlTextWriter(this.Ruta, null);
            XmlTextWriter.Formatting = Formatting.Indented;
            XmlDocument.WriteContentTo(XmlTextWriter);
            XmlTextWriter.Close();
        }

        public void Insertar(UsersDto Entity)
        {
            try
            {
                if (System.IO.File.Exists(this.Ruta))
                {
                    AgregarElemento(Entity);
                }
                else
                {
                    CrearArchivo(Entity);
                }
            }
            catch (Exception E)
            {
                throw new NothwindException("UsersBusiness - Insertar: " + E.Message, E);
            }
        }

        public void Actualizar(UsersDto Entity)
        {
            try
            {
                XmlDocument XmlDocument = new XmlDocument();
                XmlDocument.Load(this.Ruta);
                XmlNodeList XmlNodeList = XmlDocument.SelectNodes("users/user[@id=" + Entity.Id + "]");
                XmlNodeList[0].Attributes["id"].InnerText = Convert.ToString(Entity.Id);
                XmlNodeList[0]["name"].InnerText = Entity.Name;
                XmlNodeList[0]["lastname"].InnerText = Entity.LastName;
                XmlNodeList[0]["birthdate"].InnerText = Entity.Birthdate.ToString();
                XmlNodeList[0]["userid"].InnerText = Entity.UserId;
                XmlNodeList[0]["password"].InnerText = Entity.Password;
                XmlTextWriter XmlTextWriter = new XmlTextWriter(this.Ruta, null);
                XmlTextWriter.Formatting = Formatting.Indented;
                XmlDocument.Save(XmlTextWriter);
                XmlTextWriter.Close();
            }
            catch (Exception E)
            {

                throw new NothwindException("UsersBusiness - Actualizar: " + E.Message, E);
            }
        }

        public void Eliminar(int Id)
        {
            try
            {
                XmlDocument XmlDocument = new XmlDocument();
                XmlDocument.Load(this.Ruta);
                XmlNodeList XmlNodeList = XmlDocument.SelectNodes("users/user[@id=" + Id + "]");
                XmlNodeList[0].ParentNode.RemoveChild(XmlNodeList[0]);
                XmlTextWriter XmlTextWriter = new XmlTextWriter(this.Ruta, null);
                XmlTextWriter.Formatting = Formatting.Indented;
                XmlDocument.Save(XmlTextWriter);
                XmlTextWriter.Close();
            }
            catch (Exception E)
            {
                throw new NothwindException("UsersBusiness - Eliminar: " + E.Message, E);
            }
        }

        public UsersDto Obtener(int Id)
        {
            UsersDto UsersDto = new UsersDto();
            try
            {
                XmlDocument XmlDocument = new XmlDocument();
                XmlDocument.Load(this.Ruta);
                XmlNodeList XmlNodeList = XmlDocument.SelectNodes("users/user[@id=" + Id + "]");
                foreach (XmlNode XmlNode in XmlNodeList)
                {
                    UsersDto.Id = Convert.ToInt32(XmlNode.Attributes["id"].InnerText);
                    UsersDto.Name = XmlNode["name"].InnerText.ToUpper();
                    UsersDto.LastName = XmlNode["lastname"].InnerText.ToUpper();
                    UsersDto.Birthdate = Convert.ToDateTime(XmlNode["birthdate"].InnerText);
                    UsersDto.UserId = XmlNode["userid"].InnerText;
                    UsersDto.Password = XmlNode["password"].InnerText;
                }

            }
            catch (Exception E)
            {
                throw new NothwindException("UsersBusiness - Obtener: " + E.Message, E);
            }
            return UsersDto;
        }

        public List<UsersDto> Listar()
        {
            List<UsersDto> Lista = new List<UsersDto>();
            try
            {
                DataSet DataSet = new DataSet();
                DataSet.ReadXml(this.Ruta);
                DataTable DataTableProviders = DataSet.Tables[0];
                foreach (DataRow Row in DataTableProviders.Rows)
                {
                    UsersDto UsersDto = new UsersDto();
                    UsersDto.Id = Convert.ToInt32(Row["id"].ToString());
                    UsersDto.Name = Row["name"].ToString().ToUpper() ;
                    UsersDto.LastName = Row["lastname"].ToString().ToUpper();
                    UsersDto.Birthdate = Convert.ToDateTime(Row["birthdate"].ToString());
                    UsersDto.UserId = Row["userid"].ToString();
                    UsersDto.Password = Row["password"].ToString();
                    UsersDto.FullName = Row["lastname"].ToString().ToUpper() + ", " + Row["name"].ToString().ToUpper();
                    Lista.Add(UsersDto);
                }
                DataSet.Dispose();
            }
            catch (Exception E)
            {
                throw new NothwindException("UsersBusiness - Listar: " + E.Message, E);
            }
            return Lista;
        }
    }
}
