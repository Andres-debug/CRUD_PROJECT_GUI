using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUD_PROJECT_GUI
{
    internal interface IDescontable
    {
        // Método para aplicar un descuento sobre el precio de un producto
        decimal AplicarDescuento(decimal porcentaje);
    }
}
