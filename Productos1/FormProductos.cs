using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;
using Negocio;


namespace Productos1
{
    public partial class FormProductos : Form

    {
        Producto NuevoProd;
        Producto ProdExistente;
        NegProductos DatosObjProducto = new NegProductos();
        int fila;
        bool Nuevo;

        public FormProductos()
        {
            InitializeComponent();
            CrearDgv();
            LlenarDgv();
            rbtn_Ingreso.Checked = true;
        }

        private void CrearDgv()
        {
            dgv_Productos.Columns.Add("0", "Código");
            dgv_Productos.Columns.Add("1", "Descripción");
            dgv_Productos.Columns.Add("2", "Stock");

            dgv_Productos.Columns[0].Width = 100;
            dgv_Productos.Columns[1].Width = 380;
            dgv_Productos.Columns[2].Width = 60;
        }

        private void LlenarDgv()
        {
            dgv_Productos.Rows.Clear();

            DataSet ds = new DataSet();
            ds = DatosObjProducto.listadoProductos("Todos");

            if (ds.Tables[0].Rows.Count > 0)
            {
                foreach (DataRow dr in ds.Tables[0].Rows)
                {
                    dgv_Productos.Rows.Add(dr[0].ToString(), dr[1], dr[2].ToString());
                }
            }
            else
                MessageBox.Show("No hay Productos cargados en el sistema");
        }

        private void btn_Cargar_Click(object sender, EventArgs e)
        {
            int nGrabados = -1;

            NuevoProd = new Producto(Convert.ToInt32(tb_Codigo.Text), tb_Descripcion.Text);

            nGrabados = DatosObjProducto.abmProductos("Agregar", NuevoProd);

            if (nGrabados == -1)
                {
                MessageBox.Show("No se pudo grabar el Producto en el sistema");
                }
            else
            {
                lbl_codigo.Text = Convert.ToString(NuevoProd.PropCodigo);
                lbl_Descripcion.Text = NuevoProd.PropDescripcion;
                lbl_stock.Text = Convert.ToString(NuevoProd.PropStock);

                tb_Codigo.Clear();
                tb_Descripcion.Clear();

                tab_Productos.SelectedTab = tabPage2;
                tb_Cantidad.Clear();
                tb_Cantidad.Focus();

                Nuevo = true;
                LlenarDgv();
            }            
        }

        private void btn_Aceptar_Click(object sender, EventArgs e)
        {
            
            if (Nuevo == false)
            { 
                if (rbtn_Ingreso.Checked == true)
                {
                    ProdExistente.Ingreso(int.Parse(tb_Cantidad.Text));
                                }
                if (rbtn_Egreso.Checked == true)
                {
                    ProdExistente.Egreso(int.Parse(tb_Cantidad.Text));
                }

                int nResultado = -1;

                nResultado = DatosObjProducto.abmProductos("Modificar", ProdExistente);
                if (nResultado != -1)
                {
                    LlenarDgv();
                }
                else
                {
                    MessageBox.Show("Error", "Se produjo un error al intentar modificar el Producto");
                }
            }
            else
            {
                if (rbtn_Ingreso.Checked == true)
                {
                    NuevoProd.Ingreso(int.Parse(tb_Cantidad.Text));
                }
                if (rbtn_Egreso.Checked == true)
                {
                    NuevoProd.Egreso(int.Parse(tb_Cantidad.Text));
                }

                int nResultado = -1;

                nResultado = DatosObjProducto.abmProductos("Modificar", NuevoProd);
                if (nResultado != -1)
                {
                    LlenarDgv();
                }
                else
                {
                    MessageBox.Show("Error", "Se produjo un error al intentar modificar el Producto");
                }
            }
        }

        private void dgv_Productos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            ProdExistente =new Producto(Convert.ToInt32(dgv_Productos.CurrentRow.Cells[0].Value),dgv_Productos.CurrentRow.Cells[1].Value.ToString(),Convert.ToInt32(dgv_Productos.CurrentRow.Cells[2].Value));

            DataSet ds = new DataSet();

            Nuevo = false;

            ds = DatosObjProducto.listadoProductos(ProdExistente.PropCodigo.ToString());

            if (ds.Tables[0].Rows.Count > 0)
            {
                Ds_controles(ds);
            }            
        }

        private void Ds_controles (DataSet ds)
        {
            lbl_codigo.Text = ProdExistente.PropCodigo.ToString();
            lbl_Descripcion.Text = ProdExistente.PropDescripcion;
            lbl_stock.Text = ProdExistente.PropStock.ToString();
            tb_Cantidad.Clear();
        }
    }
}
