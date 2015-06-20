using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
//Importaciones
using System.IO;

namespace NorthwindWeb.Util {
    public static class UtilWeb {
        public static void LogException(Exception Exception, String recurso) 
        {
            string RutaDelArchivo =
                System.Configuration.ConfigurationManager.AppSettings["RutaLog"].ToString();
            StreamWriter StreamWriter = new StreamWriter(RutaDelArchivo, true);
            StreamWriter.WriteLine("******* {0} *******", DateTime.Now);
            if (Exception.InnerException != null) 
            {
                StreamWriter.Write("Inner Exception Type: ");
                StreamWriter.WriteLine(Exception.InnerException.GetType().ToString());
                StreamWriter.Write("Inner Exception:");
                StreamWriter.WriteLine(Exception.InnerException.Message);
                StreamWriter.Write("Inner Source:");
                StreamWriter.WriteLine(Exception.InnerException.Source);
                if (Exception.InnerException.StackTrace != null) 
                {
                    StreamWriter.WriteLine("Inner Stack Trace:");
                    StreamWriter.WriteLine(Exception.InnerException.StackTrace);
                }
            }
            StreamWriter.Write("Exception type:");
            StreamWriter.WriteLine(Exception.GetType().ToString());
            StreamWriter.WriteLine("Exception:" + Exception.Message);
            StreamWriter.WriteLine("Source: " + Exception.Source);
            if (Exception.StackTrace != null) 
            {
                StreamWriter.WriteLine("Stack Trace: ");
                StreamWriter.WriteLine(Exception.StackTrace);
                StreamWriter.WriteLine();
            }
            StreamWriter.Close();
        }
    }
}