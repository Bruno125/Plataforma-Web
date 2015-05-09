using NorthwindBusiness.Base;
using NorthwindEntity.Entity;
using NorthwindUtil.ExceptionPer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace NorthwindBusiness.Business
{
    public class UserBusiness : BaseBusiness<UserDto,int>
    {
        private readonly string Ruta = "../../Users.xml";

        #region Patron singleton
        private static UserBusiness INSTANCE = new UserBusiness();
        private UserBusiness() { }
        public static UserBusiness ObtenerInstancia()
        {
            return INSTANCE;
        }

        #endregion

        private void CrearArchivo(UserDto UserDto)
        {
            XmlTextWriter XmlTextWriter = new XmlTextWriter(this.Ruta, null);
            XmlTextWriter.Formatting = Formatting.Indented;
            XmlTextWriter.WriteStartDocument();

            //Apertura de <users>
            XmlTextWriter.WriteStartElement("users");
            //Apertura de <user>
            XmlTextWriter.WriteStartElement("user");
            XmlTextWriter.WriteAttributeString("id", "1");
            XmlTextWriter.WriteElementString("name", UserDto.Name);
            XmlTextWriter.WriteElementString("lastname", UserDto.LastName);
            XmlTextWriter.WriteElementString("birthday", UserDto.LastName);
            XmlTextWriter.WriteElementString("userId", UserDto.UserName);
            XmlTextWriter.WriteElementString("password", UserDto.Password);
            //Cierre de <user>
            XmlTextWriter.WriteEndElement();
            //Cierre de <users>
            XmlTextWriter.WriteEndElement();
            XmlTextWriter.Flush();//Para que grabe y libere recursos
            XmlTextWriter.Close();//Cerrar el archivo
        }

        private void AgregarElemento(UserDto UserDto)
        {
            //Generemos un ID automatico
            List<UserDto> ListaUsuarios = this.Listar();
            int Id = ListaUsuarios[ListaUsuarios.Count - 1].UserId + 1;
            //Cargando la estructura
            XmlDocument XmlDocument = new XmlDocument();
            XmlDocument.Load(this.Ruta);
            //Creando el elemento <user>
            XmlElement ElementoUser = XmlDocument.CreateElement("user");
            //Creando el atributo <user id="">
            ElementoUser.SetAttribute("id", Convert.ToString(Id));
            //Creando el elemento <name>
            XmlElement ElementoName = XmlDocument.CreateElement("name");
            ElementoName.InnerText = UserDto.Name;
            ElementoUser.AppendChild(ElementoName);
            //Creando el elemento <lastname>
            XmlElement ElementoLastName = XmlDocument.CreateElement("lastname");
            ElementoLastName.InnerText = UserDto.LastName;
            ElementoUser.AppendChild(ElementoLastName);
            //Creando el elemento <birthday>
            XmlElement ElementoBirthday = XmlDocument.CreateElement("birthday");
            ElementoBirthday.InnerText = UserDto.Birthday;
            ElementoUser.AppendChild(ElementoBirthday);
            //Creando el elemento <userId>
            XmlElement ElementoUsername = XmlDocument.CreateElement("userId");
            ElementoUsername.InnerText = UserDto.UserName;
            ElementoUser.AppendChild(ElementoUsername);
            //Creando el elemento <password>
            XmlElement ElementoPass = XmlDocument.CreateElement("password");
            ElementoPass.InnerText = UserDto.Password;
            ElementoUser.AppendChild(ElementoPass);

            XmlDocument.DocumentElement.AppendChild(ElementoUser);

            XmlTextWriter XmlTextWriter = new XmlTextWriter(this.Ruta, null);
            XmlTextWriter.Formatting = Formatting.Indented;
            XmlDocument.WriteContentTo(XmlTextWriter);
            //Cerrar el archivo
            XmlTextWriter.Close();
        }

        public void Insertar(UserDto Entity)
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

                throw new NothwindException("UserBusiness - Insertar: " +
                    E.Message, E);
            }
        }

        public void Actualizar(UserDto Entity)
        {
            try
            {
                XmlDocument XmlDocument = new XmlDocument();
                XmlDocument.Load(this.Ruta);
                //Buscar un elemento que puede ser por el atributo o por el valor del elemento
                XmlNodeList XmlNodeList = XmlDocument.SelectNodes("users/user[@id=" +
                    Entity.UserId + "]");

                XmlNodeList[0].Attributes["id"].InnerText = Convert.ToString(Entity.UserId);
                XmlNodeList[0]["name"].InnerText = Entity.Name;
                XmlNodeList[0]["lastname"].InnerText = Entity.LastName;
                XmlNodeList[0]["birthday"].InnerText = Entity.Birthday;
                XmlNodeList[0]["userId"].InnerText = Entity.UserName;
                XmlNodeList[0]["password"].InnerText = Entity.Password;

                XmlTextWriter XmlTextWriter = new XmlTextWriter(this.Ruta, null);
                XmlTextWriter.Formatting = Formatting.Indented;
                XmlDocument.Save(XmlTextWriter);
                XmlTextWriter.Close();

            }
            catch (Exception E)
            {

                throw new NothwindException("UsersBusiness - Actualizar: " +
                    E.Message, E);
            }
        }

        public void Eliminar(int Id)
        {
            try
            {
                XmlDocument XmlDocument = new XmlDocument();
                XmlDocument.Load(this.Ruta);
                //Buscar un elemento que puede ser por el atributo o por el valor del elemento
                XmlNodeList XmlNodeList = XmlDocument.SelectNodes("users/user[@id=" +
                    Id + "]");
                XmlNodeList[0].ParentNode.RemoveChild(XmlNodeList[0]);

                XmlTextWriter XmlTextWriter = new XmlTextWriter(this.Ruta, null);
                XmlTextWriter.Formatting = Formatting.Indented;
                XmlDocument.Save(XmlTextWriter);
                XmlTextWriter.Close();
            }
            catch (Exception E)
            {

                throw new NothwindException("UserBusiness - Eliminar: " +
                    E.Message, E);
            }
        }

        public UserDto Obtener(int Id)
        {
            UserDto UserDto = new UserDto();
            try
            {
                XmlDocument XmlDocument = new XmlDocument();
                XmlDocument.Load(this.Ruta);
                //Buscar un elemento que puede ser por el atributo o por el valor del elemento
                XmlNodeList XmlNodeList = XmlDocument.SelectNodes("users/user[@id=" +
                    Id + "]");
                foreach (XmlNode XmlNode in XmlNodeList)
                {
                    UserDto.UserId =
                        Convert.ToInt32(XmlNode.Attributes["id"].InnerText);
                    UserDto.Name = XmlNode["name"].InnerText;
                    UserDto.LastName = XmlNode["lastname"].InnerText;
                    UserDto.Birthday = XmlNode["birthday"].InnerText.ToUpper();
                    UserDto.UserName = XmlNode["userId"].InnerText;
                    UserDto.Password = XmlNode["password"].InnerText;
                }

            }
            catch (Exception E)
            {
                throw new NothwindException("UserBusiness - Obtener: " +
                    E.Message, E);
            }
            return UserDto;
        }

        public List<UserDto> Listar()
        {
            List<UserDto> Lista = new List<UserDto>();
            try
            {
                DataSet DataSet = new DataSet();
                DataSet.ReadXml(this.Ruta);
                DataTable DataTableProviders = DataSet.Tables[0];
                foreach (DataRow Row in DataTableProviders.Rows)
                {
                    UserDto UserDto = new UserDto();
                    UserDto.UserId =
                        Convert.ToInt32(Row["id"].ToString());
                    UserDto.Name = Row["name"].ToString();
                    UserDto.LastName = Row["lastname"].ToString();
                    UserDto.Birthday = Row["birthday"].ToString().ToUpper();
                    UserDto.UserName = Row["userId"].ToString();
                    UserDto.Password = Row["password"].ToString();
                    Lista.Add(UserDto);
                }
                DataSet.Dispose();
            }
            catch (Exception E)
            {
                throw new NothwindException("UserBusiness - Listar: " +
                    E.Message, E);
            }
            return Lista;
        }
    }
}
