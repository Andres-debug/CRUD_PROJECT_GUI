using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUD_PROJECT_GUI
{
    public class Producto : ProductoBase, IDescontable
    {
        // Implementación del método abstracto CalcularValorTotal
        public override decimal CalcularValorTotal()
        {
            return Precio * Cantidad;
        }

        // Implementación de la interfaz IDescontable para aplicar un descuento al precio
        public decimal AplicarDescuento(decimal porcentaje)
        {
            if (porcentaje < 0 || porcentaje > 100)
                throw new ArgumentException("El porcentaje de descuento debe estar entre 0 y 100.");

            decimal descuento = Precio * (porcentaje / 100);
            return Precio - descuento;
        }

        // Sobrescribir el método Descripcion para añadir más detalles
        public override string Descripcion()
        {
            return base.Descripcion() + $" (Precio con descuento disponible)";
        }
    }
}
