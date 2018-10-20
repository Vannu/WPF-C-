using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Productos.Modelo;

namespace Productos.ViewModel
{
    class ProductoViewModel
    {
        CProducto objProducto;
        public ProductoViewModel()
        {

        }

        public int Id
        {
            get
            {
                return objProducto.Id;
            }
            set
            {
                objProducto.Id = value;
            }

        }

        public string Nombres
        {
            get
            {
                return objProducto.Nombres;
            }
            set
            {
                objProducto.Nombres = value;
            }
       
        }

        public string Descripcion
        {
            get
            {
                return objProducto.Descripcion;
            }
            set
            {
                objProducto.Descripcion = value;
            }

        }

        public string Categoria
        {
            get
            {
                return objProducto.Categoria;
            }
            set
            {
                objProducto.Categoria = value;
            }

        }
    }
}
