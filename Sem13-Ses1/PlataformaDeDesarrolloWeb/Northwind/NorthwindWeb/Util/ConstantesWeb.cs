using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NorthwindWeb.Util {
    public static class ConstantesWeb {

        public static readonly String EXITO_GUARDAR 
            = "Se guardo correctamente el(la) {0}";

        public static readonly String EXITO_ACTUALIZAR
            = "Se actualizo correctamente el(la) {0}";

        public static readonly String EXITO_ELIMINAR
            = "Se elimino correctamente el(la) {0}";

        public static readonly String SESION_USUARIOINICIO
            = "UsuarioInicio";

        public static readonly String USUARIO_CLAVE_INVALIDA
            = "Usuario o clave invalida";

        public static readonly String USUARIO_NO_SESION
            = "No puede acceder a la pagina porque no inicio sesión";

    }
}