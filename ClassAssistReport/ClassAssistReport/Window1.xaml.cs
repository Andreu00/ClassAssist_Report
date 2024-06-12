using ClassAssistReport.DAO;
using ClassAssistReport.DTO;
using CrystalDecisions.CrystalReports.Engine;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ClassAssistReport
{
    /// <summary>
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        public Window1()
        {
            InitializeComponent();
            ocultarBotones();
            CargarAlumnos();
        }

        private void btnGenerarInforme_Click(object sender, RoutedEventArgs e)
        {
            mostrarBotones();
        }

        private void btnUnSoloAlumno_Click(object sender, RoutedEventArgs e)
        {
            cmbNombres.Visibility = Visibility.Visible;
            btnGenerarInfo.Visibility = Visibility.Visible;
            btnDeLaClase.Visibility = Visibility.Collapsed;
        }

        private void btnDeLaClase_Click(object sender, RoutedEventArgs e)
        {
            frmGenerar informe = new frmGenerar();
            informe.Show();
        }

        private void mostrarBotones()
        {
            btnGenerarInforme.Visibility = Visibility.Collapsed;
            btnDeLaClase.Visibility = Visibility.Visible;
            btnUnSoloAlumno.Visibility = Visibility.Visible;
        }

        private void ocultarBotones()
        {
            btnDeLaClase.Visibility = Visibility.Collapsed;
            btnUnSoloAlumno.Visibility = Visibility.Collapsed;
            cmbNombres.Visibility = Visibility.Collapsed;
            btnGenerarInfo.Visibility = Visibility.Collapsed;
        }

        private void CargarAlumnos()
        {
            DAOAlumno daoAlumno = new DAOAlumno();
            List<Alumno> alumnos = daoAlumno.ObtenerAlumnos();

            cmbNombres.ItemsSource = alumnos;
            cmbNombres.DisplayMemberPath = "Nombre";
            cmbNombres.SelectedValuePath = "Nombre";
        }

        private void btnGenerarInfo_Click(object sender, RoutedEventArgs e)
        {
            if (cmbNombres.SelectedItem != null)
            {
                string nombreAlumno = cmbNombres.SelectedItem.ToString();
                // Llama al formulario del informe y pasa el nombre del alumno como parámetro
                frmGenerar2 informeForm = new frmGenerar2(nombreAlumno);
                informeForm.Show();
            }
            else
            {
                MessageBox.Show("Por favor, selecciona un nombre.");
            }
        }
    }
}
