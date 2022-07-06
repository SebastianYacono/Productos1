using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.OleDb;
using Entidades;

namespace Datos
{
    public class AdminProductos : DatosConexion
    {
        public int abmProductos(string accion, Producto objProducto)
        {
            int resultado = -1;
            string orden = string.Empty;

            if (accion == "Agregar")
                orden = "insert into Productos values (" + objProducto.PropCodigo +
                ",'" + objProducto.PropDescripcion + "'," + objProducto.PropStock + ");";

            if (accion == "Modificar")
                orden = "update Productos set Descripcion = '" + objProducto.PropDescripcion + "', Stock = " + objProducto.PropStock + " where Codigo = " + objProducto.PropCodigo + ";";

            // falta la orden de borrar

            OleDbCommand cmd = new OleDbCommand(orden, conexion);
            try
            {
                Abrirconexion();
                resultado = cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                throw new Exception("Error al tratar de Agregar,Borrar o Modificar de Productos",e);
            }
            finally
            {
                Cerrarconexion();
                cmd.Dispose();
            }
            return resultado;
        }

        public DataSet listadoProductos(string cual)
        {
            string orden = string.Empty;

            if (cual != "Todos")
                orden = "select * from Productos where Codigo = " + int.Parse(cual) + ";";
            else
                orden = "select * from Productos;";

            OleDbCommand cmd = new OleDbCommand(orden, conexion);
            DataSet ds = new DataSet();
            OleDbDataAdapter da = new OleDbDataAdapter();

            try
            {
                Abrirconexion();
                cmd.ExecuteNonQuery();
                da.SelectCommand = cmd;
                da.Fill(ds);
            }
            catch (Exception e)
            {
                throw new Exception("Error al listar Productos", e);
            }
            finally
            {
                Cerrarconexion();
                cmd.Dispose();
            }
            return ds;
        }
    }

}
