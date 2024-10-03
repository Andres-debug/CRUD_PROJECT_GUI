using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRUD_PROJECT_GUI
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        private string connectionString = "Server=localhost;Database=Tienda;Uid=root;Pwd=admin$1234";
        private List<Categoria> CargarCategorias()
        {
            List<Categoria> categorias = new List<Categoria>();
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT * FROM Categorias";
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        categorias.Add(new Categoria
                        {
                            Id = Convert.ToInt32(reader["Id"]),
                            Nombre = reader["Nombre"].ToString()
                        });
                    }
                }
            }
            return categorias;
        }

        private void AgregarCategorias(string nombreCategoria)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                string query = "INSERT INTO Categorias (Nombre) VALUES";
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Nombre", nombreCategoria);
                    cmd.ExecuteNonQuery();
                }
            }
            MessageBox.Show("Categoria Agregada exitosamente");
        }

        private void AgregarProducto(string nombre, decimal precio, int cantidad, int categoriaId)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                string query = "INSERT INTO producto (Nombre,Precio,Cantidad,CategoriaId) VALUES(@Nombre,@Precio,@Cantidad,@CategoriaId)";
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Nombre",nombre);
                    cmd.Parameters.AddWithValue("@Precio", precio);
                    cmd.Parameters.AddWithValue("@Cantidad", cantidad);
                    cmd.Parameters.AddWithValue("@CategoriaId", categoriaId);
                    cmd.ExecuteNonQuery ();
                }
            }

        }
        private void Example()
        {

        }
    }
    }
