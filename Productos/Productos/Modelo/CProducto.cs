using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Productos.Modelo
{
    public class CProducto
    {
        public CProducto()
        {
                
        }

        private int id;
        public int Id { get => id; set => id = value; }


        private string nombres;
        public string Nombres { get => nombres; set => nombres = value; }
        
        private string descripcion;
        public string Descripcion { get => descripcion; set => descripcion = value; }

        private string categoria;
        public string Categoria { get => categoria; set => categoria = value; }

    }
}
