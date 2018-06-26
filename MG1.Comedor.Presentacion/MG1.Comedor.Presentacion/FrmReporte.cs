using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MG1.ComedorGeo.Datos;
using MG1.ComedorGeo.Negocio;
using MG1.ComedorGeo.Utilitarios;

namespace MG1.Comedor.Presentacion
{
    public partial class FrmReportes : Form
    {
        public FrmReportes()
        {
            InitializeComponent();
        }

        RNAlimento objRnAlimento = new RNAlimento();
        private void FrmReporte_Load(object sender, EventArgs e)
        {

            this.reportViewer1.RefreshReport();
        }

        public void mostrarReportes(Int32 nroReporte)
        {
            switch (nroReporte)
            {
                case 1:
                    this.reportViewer1.ProcessingMode = Microsoft.Reporting.WinForms.ProcessingMode.Local;
                    this.reportViewer1.LocalReport.ReportPath = Utilitarios.rutaReporte + "RptAlimentacionPersonal.rdlc";
                    this.reportViewer1.LocalReport.DataSources.Clear();
                    Int64 id;
                    if (Int64.TryParse(this.txtBuscar.Text, out id))
                        this.reportViewer1.LocalReport.DataSources.Add(new Microsoft.Reporting.WinForms.ReportDataSource("DataSet1", objRnAlimento.TraerDatos(0)));
                    else
                    {
                        /*txtBuscar por nombre*/
                    }
                    this.reportViewer1.LocalReport.Refresh();
                    break;
                default:
                    break;
            }
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            this.mostrarReportes(1);
        }
    }
}
