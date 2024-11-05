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

        public void Crear(string nombre, string direccion, string telefono, string encargado, string descripcion)
        {
            if (string.IsNullOrWhiteSpace(nombre))
            {
                throw new ArgumentException("Debe ingresar el nombre");
            }

            Locales local = new Locales()
            {
                Nombre = nombre,
                Direccion = direccion,
                Telefono = telefono,
                Encargado = encargado,
                Descripcion = descripcion,
                Estado = true
            };

            modelo.Locales.Add(local);
            modelo.SaveChanges();

        }

    }
}