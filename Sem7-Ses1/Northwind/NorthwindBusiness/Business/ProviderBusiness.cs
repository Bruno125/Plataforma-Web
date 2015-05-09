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

    public class ProviderBusiness : BaseBusiness<ProviderDto,int>
    {
        #region Patron singleton
        private static ProviderBusiness INSTANCE = new ProviderBusiness();
        private ProviderBusiness() { }
        public static ProviderBusiness ObtenerInstancia()
        {
            return INSTANCE;
        }
        #endregion

        private string Ruta = "E:\\Plataforma Web\\Sem7-Ses1\\Northwind\\files";

        public void Insertar(ProviderDto Entity)
        {
            XmlDocument XmlDocument = new XmlDocument();

        }

        public void Actualizar(ProviderDto Entity)
        {
            try
            {

                XmlDocument XmlDocument = new XmlDocument();
                XmlDocument.Load(this.Ruta);
                XmlNodeList XmlNodeList = XmlDocument.SelectNodes("providers/provider[@id=" + Entity.ProviderId + "]");
                XmlNodeList[0].Attributes["id"].InnerText = Convert.ToString(Entity.ProviderId);
                XmlNodeList[0]["name"].InnerText = Entity.Name;
                XmlNodeList[0]["descripcion"].InnerText = Entity.Description;

                XmlTextWriter XmlTextWriter = new XmlTextWriter(this.Ruta, null);
                XmlTextWriter.Formatting = Formatting.Indented;
                XmlDocument.Save(XmlTextWriter);
                XmlTextWriter.Close();

            }
            catch (Exception E)
            {
                throw new NothwindException("ProviderBusiness - actualizar: " + E.Message, E);
            }

        }

        public void Eliminar(int Id)
        {
            try
            {

                XmlDocument XmlDocument = new XmlDocument();
                XmlDocument.Load(this.Ruta);
                XmlNodeList XmlNodeList = XmlDocument.SelectNodes("providers/provider[@id=" + Id + "]");

                XmlNodeList[0].ParentNode.RemoveChild(XmlNodeList[0]);

                XmlTextWriter XmlTextWriter = new XmlTextWriter(this.Ruta, null);
                XmlTextWriter.Formatting = Formatting.Indented;
                XmlDocument.Save(XmlTextWriter);
                XmlTextWriter.Close();

            }
            catch (Exception E)
            {
                throw new NothwindException("");
            }
        }

        public ProviderDto Obtener(int Id)
        {
            ProviderDto ProviderDto = new ProviderDto();
            try
            {

                XmlDocument XmlDocument = new XmlDocument();
                XmlDocument.Load(this.Ruta);
                XmlNodeList XmlNodeList = XmlDocument.SelectNodes("providers/provider[@id=" + Id + "]");
                foreach (XmlNode XmlNode in XmlNodeList)
                {
                    ProviderDto.ProviderId = Convert.ToInt32(XmlNode.Attributes["id"].InnerText);
                    ProviderDto.Name = XmlNode.Attributes["name"].InnerText;
                    ProviderDto.Description = XmlNode.Attributes["descripcion"].InnerText;
                }
            }
            catch (Exception E)
            {
                throw new NothwindException("ProviderBusiness - obtener: " + E.Message, E);
            }
            return ProviderDto;
        }

        public List<ProviderDto> Listar()
        {
            List<ProviderDto> Lista = new List<ProviderDto>();
            try
            {
                DataSet DataSet = new DataSet();
                DataSet.ReadXml(this.Ruta);
                DataTable DataTableProviders = DataSet.Tables[0];
                foreach (DataRow Row in DataTableProviders.Rows)
                {
                    ProviderDto ProviderDto = new ProviderDto();
                    ProviderDto.ProviderId = Convert.ToInt32(Row["id"].ToString());
                    ProviderDto.Name = Row["name"].ToString();
                    ProviderDto.Description = Row["description"].ToString();
                    Lista.Add(ProviderDto);
                }
                DataSet.Dispose();
            }
            catch (Exception E)
            {
                throw new NothwindException("ProviderBusiness - listar: " + E.Message, E);
            }
            return Lista;


        }
    }
}
