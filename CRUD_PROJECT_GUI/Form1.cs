using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace CRUD_PROJECT_GUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            ConectarConBaseDeDatos();
            dgvProductos.ColumnCount = 3;
            dgvProductos.Columns[0].Name = "Nombre";
            dgvProductos.Columns[1].Name = "Precio";
            dgvProductos.Columns[2].Name = "Cantidad";
            CargarProductos();
        }

        private string connectionString = "Server=localhost;Database=Tienda;Uid=root;Pwd=admin$1234";

        private void ConectarConBaseDeDatos()
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {

                try
                {
                    conn.Open();

                    MessageBox.Show("Conexion Exitosa a la base de datos");
                    

                }catch(MySqlException ex)
                {
                    MessageBox.Show($"Error al conectar con la bese de datos:{ex.Message}");
                }
            }
        }

        private void CargarProductos()
        {
            using(MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();

                string query = "SELECT * FROM Productos";
                using (MySqlCommand cmd = new MySqlCommand(query, conn)) { 
                using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        dgvProductos.Rows.Clear();

                        while (reader.Read()) {

                            dgvProductos.Rows.Add(reader["Nombre"],
                                reader["Precio"], reader["Cantidad"]
                                );

                        }
                    }
                        }
            }
        }

        private void btnAgregarProducto2_Click(object sender, EventArgs e)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();

                string query = "INSERT INTO Productos(Nombre,Precio,Cantidad) VALUES(@Nombre,@Precio,@Cantidad)";

                using (MySqlCommand cmd = new MySqlCommand(query,conn))
                {
                    //Parametros para evitar inyeccion SQL
                    cmd.Parameters.AddWithValue("@Nombre",txtNombre.Text);
                    cmd.Parameters.AddWithValue("@Precio",decimal.Parse(txtPrecio.Text));
                    cmd.Parameters.AddWithValue("@Cantidad",int.Parse(txtCantidad.Text));

                    cmd.ExecuteNonQuery(); //Ejecuta el comando SQL
                }
            }
            MessageBox.Show("Producto Agregado");
            CargarProductos();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
