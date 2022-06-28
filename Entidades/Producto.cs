using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Producto
    {
        #region Atributos
        private int codigo;
        private string descripcion;
        private int stock;
        #endregion

        #region Propiedades
        public int PropCodigo
        {
            set {codigo = value; } get { return codigo; }
        }
        public string PropDescripcion
        {
            set { descripcion = value; } get { return descripcion; }
        }
        public int PropStock
        {
            get { return stock; }
        }
        #endregion

        #region Constructores
        public Producto()
        {}
        public Producto(int cod, string desc)
        {
            codigo = cod;
            descripcion = desc;
            stock = 0;
        }

        public Producto(int cod, string desc, int cant)
        {
            codigo = cod;
            descripcion = desc;
            stock = cant;
        }
        #endregion

        #region Metodos
        public void Ingreso(int cant)
        {
            stock = stock + cant;
        }

        public void Egreso(int cant)
        {
            stock= stock - cant;
        }
        #endregion
    }
}
