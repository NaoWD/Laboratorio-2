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
    public partial class Conductores : Window
    {
        public Conductores()
        {
            InitializeComponent();
        }

        private void RegistrarConductor_Click(object sender, RoutedEventArgs e)
        {
            string nombreConductor = txtNombreConductor.Text;
            string licencia = txtLicencia.Text;
            string transporte = txtTransporte.Text;

            // Aquí puedes realizar la lógica para guardar la información o realizar la acción deseada
            // Por ejemplo, guardar los datos en una base de datos
            // o mostrar un mensaje de éxito.
            MessageBox.Show("Conductor registrado correctamente.");
        }
    }
}
