using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Productos.Modelo;

namespace Productos
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
      //private CProducto objProducto;
        public MainWindow()
        {
            InitializeComponent();
        //  objProducto = new CProducto();
        //  objProducto.Id = 1;
        //  objProducto.Nombres = "leche";
        //  objProducto.Descripcion = "litro";
        //  objProducto.Categoria = "bebidas";
        //  DisplayProd(objProducto);
        }
    //  private void DisplayProd(CProducto obj)
    //  {
    //      IdTextBox.Text = obj.Id.ToString();
    //      NombreTextBox.Text = obj.Nombres;
    //      DescripcionTextBox.Text = obj.Descripcion;
    //      CategoriaTextBox.Text = obj.Categoria;
    //      ActivoCh.IsChecked = true;
//
    //  }
    }
}
