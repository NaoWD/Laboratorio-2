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
using System.Windows.Shapes;

namespace Laboratorio_2
{
    public partial class Menu : Window
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void Ingresos_Click(object sender, RoutedEventArgs e)
        {
            Operaciones operacionesWindow = new Operaciones();
            operacionesWindow.Show();
        }
        private void Salidas_Click(object sender, RoutedEventArgs e)
        {
            // Lógica para la opción "Salidas"
        }

        private void Conductores_Click(object sender, RoutedEventArgs e)
        {
            Conductores conductoresWindow = new Conductores();
            conductoresWindow.Show();
        }

        private void Transportistas_Click(object sender, RoutedEventArgs e)
        {
            ListaConductores listaconductoresWindow = new ListaConductores();
            listaconductoresWindow.Show();
        }

        private void Camiones_Click(object sender, RoutedEventArgs e)
        {
            // Lógica para la opción "Camiones"
        }

        private void Productos_Click(object sender, RoutedEventArgs e)
        {
            // Lógica para la opción "Productos"
        }

        private void Cargas_Click(object sender, RoutedEventArgs e)
        {
            // Lógica para la opción "Cargas"
        }

        private void IngresosReporte_Click(object sender, RoutedEventArgs e)
        {
            ListaIngresos listaingresosWindow = new ListaIngresos();
            listaingresosWindow.Show();
        }

        private void SalidasReporte_Click(object sender, RoutedEventArgs e)
        {
            // Lógica para la opción "Reporte de Salidas"
        }
    }
}




