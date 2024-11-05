using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CRUD
{
    public class BLTiendas
    {
        TiendaEntities modelo = new TiendaEntities();

        public List<Locales> GetLocales 
        {
            get
            {
                return modelo.Locales.ToList();
            }
        }

    }
}