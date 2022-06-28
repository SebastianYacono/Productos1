namespace Productos1
{
    partial class FormProductos
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_Cargar = new System.Windows.Forms.Button();
            this.tab_Productos = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tb_Stock = new System.Windows.Forms.TextBox();
            this.tb_Descripcion = new System.Windows.Forms.TextBox();
            this.tb_Codigo = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.lbl_stock = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_Aceptar = new System.Windows.Forms.Button();
            this.rbtn_Egreso = new System.Windows.Forms.RadioButton();
            this.rbtn_Ingreso = new System.Windows.Forms.RadioButton();
            this.tb_Cantidad = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.lbl_Descripcion = new System.Windows.Forms.Label();
            this.lbl_codigo = new System.Windows.Forms.Label();
            this.dgv_Productos = new System.Windows.Forms.DataGridView();
            this.tab_Productos.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Productos)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nro. Código";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(16, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Descripción";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(16, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Stock inicial";
            // 
            // btn_Cargar
            // 
            this.btn_Cargar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Cargar.Location = new System.Drawing.Point(20, 118);
            this.btn_Cargar.Name = "btn_Cargar";
            this.btn_Cargar.Size = new System.Drawing.Size(539, 35);
            this.btn_Cargar.TabIndex = 3;
            this.btn_Cargar.Text = "Cargar";
            this.btn_Cargar.UseVisualStyleBackColor = true;
            this.btn_Cargar.Click += new System.EventHandler(this.btn_Cargar_Click);
            // 
            // tab_Productos
            // 
            this.tab_Productos.Controls.Add(this.tabPage1);
            this.tab_Productos.Controls.Add(this.tabPage2);
            this.tab_Productos.Location = new System.Drawing.Point(12, 12);
            this.tab_Productos.Name = "tab_Productos";
            this.tab_Productos.SelectedIndex = 0;
            this.tab_Productos.Size = new System.Drawing.Size(589, 192);
            this.tab_Productos.TabIndex = 4;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.tb_Stock);
            this.tabPage1.Controls.Add(this.tb_Descripcion);
            this.tabPage1.Controls.Add(this.tb_Codigo);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.btn_Cargar);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(581, 166);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Carga de Productos";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tb_Stock
            // 
            this.tb_Stock.Enabled = false;
            this.tb_Stock.Location = new System.Drawing.Point(135, 80);
            this.tb_Stock.Name = "tb_Stock";
            this.tb_Stock.Size = new System.Drawing.Size(424, 20);
            this.tb_Stock.TabIndex = 6;
            // 
            // tb_Descripcion
            // 
            this.tb_Descripcion.Location = new System.Drawing.Point(135, 51);
            this.tb_Descripcion.Name = "tb_Descripcion";
            this.tb_Descripcion.Size = new System.Drawing.Size(424, 20);
            this.tb_Descripcion.TabIndex = 5;
            // 
            // tb_Codigo
            // 
            this.tb_Codigo.Location = new System.Drawing.Point(135, 23);
            this.tb_Codigo.Name = "tb_Codigo";
            this.tb_Codigo.Size = new System.Drawing.Size(424, 20);
            this.tb_Codigo.TabIndex = 4;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.lbl_stock);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.btn_Aceptar);
            this.tabPage2.Controls.Add(this.rbtn_Egreso);
            this.tabPage2.Controls.Add(this.rbtn_Ingreso);
            this.tabPage2.Controls.Add(this.tb_Cantidad);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.lbl_Descripcion);
            this.tabPage2.Controls.Add(this.lbl_codigo);
            this.tabPage2.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(581, 166);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Movimiento de Productos";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // lbl_stock
            // 
            this.lbl_stock.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_stock.Location = new System.Drawing.Point(111, 85);
            this.lbl_stock.Name = "lbl_stock";
            this.lbl_stock.Size = new System.Drawing.Size(73, 28);
            this.lbl_stock.TabIndex = 10;
            this.lbl_stock.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 93);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Cantidad actual: ";
            // 
            // btn_Aceptar
            // 
            this.btn_Aceptar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Aceptar.Location = new System.Drawing.Point(20, 118);
            this.btn_Aceptar.Name = "btn_Aceptar";
            this.btn_Aceptar.Size = new System.Drawing.Size(539, 35);
            this.btn_Aceptar.TabIndex = 8;
            this.btn_Aceptar.Text = "Aceptar";
            this.btn_Aceptar.UseVisualStyleBackColor = true;
            this.btn_Aceptar.Click += new System.EventHandler(this.btn_Aceptar_Click);
            // 
            // rbtn_Egreso
            // 
            this.rbtn_Egreso.AutoSize = true;
            this.rbtn_Egreso.Location = new System.Drawing.Point(502, 89);
            this.rbtn_Egreso.Name = "rbtn_Egreso";
            this.rbtn_Egreso.Size = new System.Drawing.Size(58, 17);
            this.rbtn_Egreso.TabIndex = 7;
            this.rbtn_Egreso.TabStop = true;
            this.rbtn_Egreso.Text = "Egreso";
            this.rbtn_Egreso.UseVisualStyleBackColor = true;
            // 
            // rbtn_Ingreso
            // 
            this.rbtn_Ingreso.AutoSize = true;
            this.rbtn_Ingreso.Location = new System.Drawing.Point(401, 89);
            this.rbtn_Ingreso.Name = "rbtn_Ingreso";
            this.rbtn_Ingreso.Size = new System.Drawing.Size(60, 17);
            this.rbtn_Ingreso.TabIndex = 6;
            this.rbtn_Ingreso.TabStop = true;
            this.rbtn_Ingreso.Text = "Ingreso";
            this.rbtn_Ingreso.UseVisualStyleBackColor = true;
            // 
            // tb_Cantidad
            // 
            this.tb_Cantidad.Location = new System.Drawing.Point(264, 88);
            this.tb_Cantidad.Name = "tb_Cantidad";
            this.tb_Cantidad.Size = new System.Drawing.Size(121, 20);
            this.tb_Cantidad.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(209, 93);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "Cantidad";
            // 
            // lbl_Descripcion
            // 
            this.lbl_Descripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Descripcion.Location = new System.Drawing.Point(20, 52);
            this.lbl_Descripcion.Name = "lbl_Descripcion";
            this.lbl_Descripcion.Size = new System.Drawing.Size(539, 28);
            this.lbl_Descripcion.TabIndex = 1;
            this.lbl_Descripcion.Text = "Descripción";
            this.lbl_Descripcion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_codigo
            // 
            this.lbl_codigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_codigo.Location = new System.Drawing.Point(20, 14);
            this.lbl_codigo.Name = "lbl_codigo";
            this.lbl_codigo.Size = new System.Drawing.Size(539, 28);
            this.lbl_codigo.TabIndex = 0;
            this.lbl_codigo.Text = "Código";
            this.lbl_codigo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dgv_Productos
            // 
            this.dgv_Productos.AllowUserToAddRows = false;
            this.dgv_Productos.AllowUserToDeleteRows = false;
            this.dgv_Productos.AllowUserToResizeColumns = false;
            this.dgv_Productos.AllowUserToResizeRows = false;
            this.dgv_Productos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Productos.Location = new System.Drawing.Point(13, 210);
            this.dgv_Productos.Name = "dgv_Productos";
            this.dgv_Productos.ReadOnly = true;
            this.dgv_Productos.Size = new System.Drawing.Size(585, 228);
            this.dgv_Productos.TabIndex = 5;
            this.dgv_Productos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Productos_CellClick);
            // 
            // FormProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(613, 450);
            this.Controls.Add(this.dgv_Productos);
            this.Controls.Add(this.tab_Productos);
            this.Name = "FormProductos";
            this.Text = "Productos";
            this.tab_Productos.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Productos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_Cargar;
        private System.Windows.Forms.TabControl tab_Productos;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox tb_Stock;
        private System.Windows.Forms.TextBox tb_Descripcion;
        private System.Windows.Forms.TextBox tb_Codigo;
        private System.Windows.Forms.RadioButton rbtn_Egreso;
        private System.Windows.Forms.RadioButton rbtn_Ingreso;
        private System.Windows.Forms.TextBox tb_Cantidad;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lbl_Descripcion;
        private System.Windows.Forms.Label lbl_codigo;
        private System.Windows.Forms.DataGridView dgv_Productos;
        private System.Windows.Forms.Button btn_Aceptar;
        private System.Windows.Forms.Label lbl_stock;
        private System.Windows.Forms.Label label4;
    }
}

