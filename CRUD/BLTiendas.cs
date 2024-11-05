using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CRUD
{
    public class BLTiendas
    {
        TiendaEntities modelo = new TiendaEntities();

        public Locales GetLocal(int id) => modelo.Locales.FirstOrDefault(x=>x.Id == id);

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

        public void Editar(int id, string nombre, string direccion, string telefono, string encargado, string descripcion)
        {
            if (string.IsNullOrWhiteSpace(nombre))
            {
                throw new ArgumentException("Debe ingresar el nombre");
            }

            Locales local = modelo.Locales.FirstOrDefault(x=>x.Id == id);
            if(local != null)
            {
                local.Nombre = nombre;
                local.Direccion = direccion;
                local.Telefono = telefono;
                local.Encargado = encargado;
                local.Descripcion = descripcion;
            }

            modelo.SaveChanges();
        }

    }
}