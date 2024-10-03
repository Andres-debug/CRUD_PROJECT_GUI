using System;

namespace CRUD_PROJECT_GUI
{
    public class Orden
    {
        public int Id { get; set; }
        public Cliente Cliente { get; set; }
        public DateTime Fecha { get; set; }
    }
}
