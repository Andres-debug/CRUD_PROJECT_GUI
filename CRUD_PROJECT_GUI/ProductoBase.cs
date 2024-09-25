using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUD_PROJECT_GUI
{
    public abstract class ProductoBase
    {
        // Propiedades comunes a todos los productos
        public int Id { get; set; }
        public string Nombre { get; set; }
        public decimal Precio { get; set; }
        public int Cantidad { get; set; }

        // Método abstracto que obliga a las clases derivadas a implementarlo
        public abstract decimal CalcularValorTotal();

        // Método virtual que puede ser sobreescrito por clases hijas
        public virtual string Descripcion()
        {
            return $"{Nombre}: {Cantidad} unidades a {Precio:C}";
        }
    }
}
