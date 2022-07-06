using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Datos;
using Entidades;


namespace Negocio
{
    public class NegProductos
    {
        AdminProductos DatosObjProducto = new AdminProductos();

        public int abmProductos (string accion, Producto objProducto)
        {
            return DatosObjProducto.abmProductos (accion, objProducto);
        }

        public DataSet listadoProductos (string cual)
        {
            return DatosObjProducto.listadoProductos (cual);
        }
    }
}
