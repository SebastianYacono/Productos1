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

namespace Productos1
{
    public partial class FormProductos : Form

    {
        Producto NuevoProd;
        Producto ProdExistente;
        int fila;

        public FormProductos()
        {
            InitializeComponent();
            CrearDgv();
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

        private void btn_Cargar_Click(object sender, EventArgs e)
        {
            NuevoProd = new Producto(int.Parse(tb_Codigo.Text), tb_Descripcion.Text);

            lbl_codigo.Text = Convert.ToString(NuevoProd.PropCodigo);
            lbl_Descripcion.Text = NuevoProd.PropDescripcion;
            lbl_stock.Text = Convert.ToString(NuevoProd.PropStock);

            tb_Codigo.Clear();
            tb_Descripcion.Clear();

            tab_Productos.SelectedTab = tabPage2;
            tb_Cantidad.Clear();
            tb_Cantidad.Focus();

            LlevarProdAldgv(NuevoProd);
        }

        void LlevarProdAldgv(Producto Prod)
        {
            dgv_Productos.Rows.Add(Prod.PropCodigo.ToString(), Prod.PropDescripcion, Prod.PropStock.ToString());
            fila = (dgv_Productos.Rows.Count - 1);
        }

        void LlevarProdAldgv(Producto Prod, int lugar)
        {
            dgv_Productos[0, lugar].Value = Prod.PropCodigo.ToString();
            dgv_Productos[1, lugar].Value = Prod.PropDescripcion;
            dgv_Productos[2, lugar].Value = Prod.PropStock.ToString();
        }



        private void btn_Aceptar_Click(object sender, EventArgs e)
        {
            if (rbtn_Ingreso.Checked == true)
            {
                NuevoProd.Ingreso(int.Parse(tb_Cantidad.Text));
            }
            if (rbtn_Egreso.Checked == true)
            {
                NuevoProd.Egreso(int.Parse(tb_Cantidad.Text));
            }
            
            LlevarProdAldgv(NuevoProd, fila);

            lbl_codigo.Text = "Código";
            lbl_Descripcion.Text = "Descripción";
            tb_Cantidad.Clear();
            rbtn_Ingreso.Checked = false;
            rbtn_Egreso.Checked = false;
        }

        private void dgv_Productos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            ProdExistente =new Producto(Convert.ToInt32(dgv_Productos.CurrentRow.Cells[0].Value),dgv_Productos.CurrentRow.Cells[1].Value.ToString(),Convert.ToInt32(dgv_Productos.CurrentRow.Cells[2].Value));
            lbl_codigo.Text = ProdExistente.PropCodigo.ToString();
            lbl_Descripcion.Text = ProdExistente.PropDescripcion;
            lbl_stock.Text = ProdExistente.PropStock.ToString();
            tb_Cantidad.Clear();
            fila = e.RowIndex;
        }
    }
}
