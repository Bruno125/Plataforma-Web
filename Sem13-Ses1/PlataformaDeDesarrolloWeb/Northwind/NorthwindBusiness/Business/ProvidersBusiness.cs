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
    public sealed class ProvidersBusiness : BaseBusiness<ProvidersDto, int>
    {

        private readonly string Ruta = "../../Providers.xml";

        #region
        private static ProvidersBusiness PROVIDERS_BUSINESS = new ProvidersBusiness();
        private ProvidersBusiness()
        {

        }
        public static ProvidersBusiness ObtenerInstancia()
        {
            return PROVIDERS_BUSINESS;
        }
        #endregion

        private void CrearArchivo(ProvidersDto ProvidersDto)
        {
            //Establecer en donde se creara el archivo
            XmlTextWriter XmlTextWriter = new XmlTextWriter(this.Ruta, null);
            //Se genere el archivo con formato
            XmlTextWriter.Formatting = Formatting.Indented;
            //Inicio del documento
            XmlTextWriter.WriteStartDocument();
            //Apertura de <providers>
            XmlTextWriter.WriteStartElement("providers");
            //Apertura de <provider>
            XmlTextWriter.WriteStartElement("provider");
            XmlTextWriter.WriteAttributeString("id", "1");
            //Apertura y cierre de <name>_________</name>
            XmlTextWriter.WriteElementString("name", ProvidersDto.Name);
            //Apertura y cierre de <description>_________</description>
            XmlTextWriter.WriteElementString("description", ProvidersDto.Description);
            //Cierre de <provider>
            XmlTextWriter.WriteEndElement();
            //Cierre de <providers>
            XmlTextWriter.WriteEndElement();
            XmlTextWriter.Flush();//Para que grabe y libere recursos
            XmlTextWriter.Close();//Cerrar el archivo
        }

        private void AgregarElemento(ProvidersDto ProvidersDto)
        {
            //Generemos un ID automatico
            List<ProvidersDto> ListaProviders = this.Listar();
            int Id = ListaProviders[ListaProviders.Count - 1].ProvidersId + 1;
            //Cargando la estructura
            XmlDocument XmlDocument = new XmlDocument();
            XmlDocument.Load(this.Ruta);
            //Creando el elemento <provider>
            XmlElement ElementoProvider = XmlDocument.CreateElement("provider");
            //Creando el atributo <provider id="">
            ElementoProvider.SetAttribute("id", Convert.ToString(Id));
            //Creando el elemento <name>
            XmlElement ElementoName = XmlDocument.CreateElement("name");
            //Agregando el valor al elemento <name>________</name>
            ElementoName.InnerText = ProvidersDto.Name;
            //Que su padre sea el <provider>
            ElementoProvider.AppendChild(ElementoName);

            XmlElement ElementoDescription = XmlDocument.CreateElement("description");
            ElementoDescription.InnerText = ProvidersDto.Description;
            ElementoProvider.AppendChild(ElementoDescription);

            XmlDocument.DocumentElement.AppendChild(ElementoProvider);

            XmlTextWriter XmlTextWriter = new XmlTextWriter(this.Ruta, null);
            XmlTextWriter.Formatting = Formatting.Indented;
            //Toda la estructura que cree lo adicione
            XmlDocument.WriteContentTo(XmlTextWriter);
            //Cerrar el archivo
            XmlTextWriter.Close();
        }


        public void Insertar(ProvidersDto Entity)
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

                throw new NothwindException("ProvidersBusiness - Insertar: " +
                    E.Message, E);
            }
        }

        public void Actualizar(ProvidersDto Entity)
        {
            try
            {
                XmlDocument XmlDocument = new XmlDocument();
                XmlDocument.Load(this.Ruta);
                //Buscar un elemento que puede ser por el atributo o por el valor del elemento
                XmlNodeList XmlNodeList = XmlDocument.SelectNodes("providers/provider[@id=" +
                    Entity.ProvidersId + "]");

                XmlNodeList[0].Attributes["id"].InnerText = Convert.ToString(Entity.ProvidersId);
                XmlNodeList[0]["name"].InnerText = Entity.Name;
                XmlNodeList[0]["description"].InnerText = Entity.Description;

                XmlTextWriter XmlTextWriter = new XmlTextWriter(this.Ruta, null);
                XmlTextWriter.Formatting = Formatting.Indented;
                XmlDocument.Save(XmlTextWriter);
                XmlTextWriter.Close();

            }
            catch (Exception E)
            {

                throw new NothwindException("ProvidersBusiness - Actualizar: " +
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
                XmlNodeList XmlNodeList = XmlDocument.SelectNodes("providers/provider[@id=" +
                    Id + "]");
                XmlNodeList[0].ParentNode.RemoveChild(XmlNodeList[0]);

                XmlTextWriter XmlTextWriter = new XmlTextWriter(this.Ruta, null);
                XmlTextWriter.Formatting = Formatting.Indented;
                XmlDocument.Save(XmlTextWriter);
                XmlTextWriter.Close();
            }
            catch (Exception E)
            {

                throw new NothwindException("ProvidersBusiness - Eliminar: " +
                    E.Message, E);
            }
        }

        public ProvidersDto Obtener(int Id)
        {
            ProvidersDto ProvidersDto = new ProvidersDto();
            try
            {
                XmlDocument XmlDocument = new XmlDocument();
                XmlDocument.Load(this.Ruta);
                //Buscar un elemento que puede ser por el atributo o por el valor del elemento
                XmlNodeList XmlNodeList = XmlDocument.SelectNodes("providers/provider[@id=" +
                    Id + "]");
                foreach (XmlNode XmlNode in XmlNodeList)
                {
                    ProvidersDto.ProvidersId =
                        Convert.ToInt32(XmlNode.Attributes["id"].InnerText);
                    ProvidersDto.Name = XmlNode["name"].InnerText.ToUpper();
                    ProvidersDto.Description = XmlNode["description"].InnerText.ToUpper();
                }

            }
            catch (Exception E)
            {
                throw new NothwindException("ProvidersBusiness - Obtener: " +
                    E.Message, E);
            }
            return ProvidersDto;
        }

        public List<ProvidersDto> Listar()
        {
            List<ProvidersDto> Lista = new List<ProvidersDto>();
            try
            {
                DataSet DataSet = new DataSet();
                DataSet.ReadXml(this.Ruta);
                DataTable DataTableProviders = DataSet.Tables[0];
                foreach (DataRow Row in DataTableProviders.Rows)
                {
                    ProvidersDto ProvidersDto = new ProvidersDto();
                    ProvidersDto.ProvidersId =
                        Convert.ToInt32(Row["id"].ToString());
                    ProvidersDto.Name = Row["name"].ToString().ToUpper();
                    ProvidersDto.Description = Row["description"].ToString().ToUpper();
                    Lista.Add(ProvidersDto);
                }
                DataSet.Dispose();
            }
            catch (Exception E)
            {
                throw new NothwindException("ProvidersBusiness - Listar: " +
                    E.Message, E);
            }
            return Lista;
        }
    }
}
