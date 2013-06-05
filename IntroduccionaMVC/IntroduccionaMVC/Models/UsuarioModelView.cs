using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace IntroduccionaMVC.Models
{
    public class UsuarioModelView
    {
        public int id { set; get; }
        public int nombre { set; get; }
        public int apellido { set; get; }
        public int email { set; get; }
        public List<FacturaModelView> facturas { set; get; }
        public UsuarioModelView() {
            facturas = new List<FacturaModelView>();
        }
    }

    public class FacturaModelView
    {
        public int id { set; get; }
        public DateTime fecha { set; get; }
        public int apellido { set; get; }
        public int email { set; get; }
    }
}