using System;

namespace CRUD_PROJECT_GUI
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        // Limpieza de los recursos usados
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.txtDescuento = new System.Windows.Forms.TextBox();
            this.dgvProductos = new System.Windows.Forms.DataGridView();
            this.btnAgregarProducto = new System.Windows.Forms.Button();
            this.btnEditarProducto = new System.Windows.Forms.Button();
            this.btnEliminarProducto = new System.Windows.Forms.Button();
            this.btnCargarProductos = new System.Windows.Forms.Button();
            this.btnAplicarDescuento = new System.Windows.Forms.Button();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.lblDescuento = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(100, 20);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(200, 20);
            this.txtNombre.TabIndex = 0;
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(100, 60);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(200, 20);
            this.txtPrecio.TabIndex = 1;
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(100, 100);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(200, 20);
            this.txtCantidad.TabIndex = 2;
            // 
            // txtDescuento
            // 
            this.txtDescuento.Location = new System.Drawing.Point(100, 140);
            this.txtDescuento.Name = "txtDescuento";
            this.txtDescuento.Size = new System.Drawing.Size(200, 20);
            this.txtDescuento.TabIndex = 3;
            // 
            // dgvProductos
            // 
            this.dgvProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProductos.Location = new System.Drawing.Point(320, 20);
            this.dgvProductos.Name = "dgvProductos";
            this.dgvProductos.RowHeadersWidth = 51;
            this.dgvProductos.RowTemplate.Height = 24;
            this.dgvProductos.Size = new System.Drawing.Size(450, 200);
            this.dgvProductos.TabIndex = 4;
            // 
            // btnAgregarProducto
            // 
            this.btnAgregarProducto.Location = new System.Drawing.Point(100, 180);
            this.btnAgregarProducto.Name = "btnAgregarProducto";
            this.btnAgregarProducto.Size = new System.Drawing.Size(200, 30);
            this.btnAgregarProducto.TabIndex = 5;
            this.btnAgregarProducto.Text = "Agregar Producto";
            this.btnAgregarProducto.UseVisualStyleBackColor = true;
            this.btnAgregarProducto.Click += new System.EventHandler(this.btnAgregarProducto_Click);
            // 
            // btnEditarProducto
            // 
            this.btnEditarProducto.Location = new System.Drawing.Point(100, 220);
            this.btnEditarProducto.Name = "btnEditarProducto";
            this.btnEditarProducto.Size = new System.Drawing.Size(200, 30);
            this.btnEditarProducto.TabIndex = 6;
            this.btnEditarProducto.Text = "Editar Producto";
            this.btnEditarProducto.UseVisualStyleBackColor = true;
            this.btnEditarProducto.Click += new System.EventHandler(this.btnEditarProducto_Click);
            // 
            // btnEliminarProducto
            // 
            this.btnEliminarProducto.Location = new System.Drawing.Point(100, 260);
            this.btnEliminarProducto.Name = "btnEliminarProducto";
            this.btnEliminarProducto.Size = new System.Drawing.Size(200, 30);
            this.btnEliminarProducto.TabIndex = 7;
            this.btnEliminarProducto.Text = "Eliminar Producto";
            this.btnEliminarProducto.UseVisualStyleBackColor = true;
            this.btnEliminarProducto.Click += new System.EventHandler(this.btnEliminarProducto_Click);
            // 
            // btnCargarProductos
            // 
            this.btnCargarProductos.Location = new System.Drawing.Point(320, 230);
            this.btnCargarProductos.Name = "btnCargarProductos";
            this.btnCargarProductos.Size = new System.Drawing.Size(200, 30);
            this.btnCargarProductos.TabIndex = 8;
            this.btnCargarProductos.Text = "Cargar Productos";
            this.btnCargarProductos.UseVisualStyleBackColor = true;
            this.btnCargarProductos.Click += new System.EventHandler(this.btnCargarProductos_Click);
            // 
            // btnAplicarDescuento
            // 
            this.btnAplicarDescuento.Location = new System.Drawing.Point(320, 270);
            this.btnAplicarDescuento.Name = "btnAplicarDescuento";
            this.btnAplicarDescuento.Size = new System.Drawing.Size(200, 30);
            this.btnAplicarDescuento.TabIndex = 9;
            this.btnAplicarDescuento.Text = "Aplicar Descuento";
            this.btnAplicarDescuento.UseVisualStyleBackColor = true;
            this.btnAplicarDescuento.Click += new System.EventHandler(this.btnAplicarDescuento_Click);
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(30, 20);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(44, 13);
            this.lblNombre.TabIndex = 10;
            this.lblNombre.Text = "Nombre";
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.Location = new System.Drawing.Point(30, 60);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(37, 13);
            this.lblPrecio.TabIndex = 11;
            this.lblPrecio.Text = "Precio";
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Location = new System.Drawing.Point(30, 100);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(49, 13);
            this.lblCantidad.TabIndex = 12;
            this.lblCantidad.Text = "Cantidad";
            // 
            // lblDescuento
            // 
            this.lblDescuento.AutoSize = true;
            this.lblDescuento.Location = new System.Drawing.Point(30, 140);
            this.lblDescuento.Name = "lblDescuento";
            this.lblDescuento.Size = new System.Drawing.Size(59, 13);
            this.lblDescuento.TabIndex = 13;
            this.lblDescuento.Text = "Descuento";
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(821, 338);
            this.Controls.Add(this.lblDescuento);
            this.Controls.Add(this.lblCantidad);
            this.Controls.Add(this.lblPrecio);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.btnAplicarDescuento);
            this.Controls.Add(this.btnCargarProductos);
            this.Controls.Add(this.btnEliminarProducto);
            this.Controls.Add(this.btnEditarProducto);
            this.Controls.Add(this.btnAgregarProducto);
            this.Controls.Add(this.dgvProductos);
            this.Controls.Add(this.txtDescuento);
            this.Controls.Add(this.txtCantidad);
            this.Controls.Add(this.txtPrecio);
            this.Controls.Add(this.txtNombre);
            this.Name = "Form1";
            this.Text = "CRUD de Productos con MySQL";
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void btnEliminarProducto_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void btnAplicarDescuento_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void btnCargarProductos_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void btnEditarProducto_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void btnAgregarProducto_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.TextBox txtDescuento;
        private System.Windows.Forms.DataGridView dgvProductos;
        private System.Windows.Forms.Button btnAgregarProducto;
        private System.Windows.Forms.Button btnEditarProducto;
        private System.Windows.Forms.Button btnEliminarProducto;
        private System.Windows.Forms.Button btnCargarProductos;
        private System.Windows.Forms.Button btnAplicarDescuento;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.Label lblDescuento;
    }
}

