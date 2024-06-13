using ClassAssistReport.DAO;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClassAssistReport
{
    public partial class frmGenerar2 : Form
    {
        public frmGenerar2(string nombreAlumno)
        {
            InitializeComponent();
            GenerarInforme(nombreAlumno);
        }

        private void GenerarInforme(string nombreAlumno)
        {
            try
            {
                // Crea una instancia del informe
                ReportDocument crystalReport = new ReportDocument();

                // Carga el archivo del informe usando la ruta absoluta
                string reportPath = @"C:\Users\maget\OneDrive\MiEscritorioASUS\Documentos\GitHub\ClassAssist_Report\ClassAssistReport\ClassAssistReport\CrystalReport2.rpt";
                crystalReport.Load(reportPath);

                
                // Pasa el parámetro al informe
                crystalReport.SetParameterValue("NombreAlumno", nombreAlumno);

                // Establece el informe al CrystalReportViewer
                crystalReportViewer1.ReportSource = crystalReport;
                crystalReportViewer1.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {

        }
    }
}
