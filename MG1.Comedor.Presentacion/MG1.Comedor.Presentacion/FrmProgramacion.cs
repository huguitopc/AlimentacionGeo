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
    public partial class FrmProgramacion : Form
    {
        public FrmProgramacion()
        {
            InitializeComponent();
            MostrarProgramacion();
        }

        RNEmpleado objRnEmpleado = new RNEmpleado();
        RNProgramacion objRnProgramacion = new RNProgramacion();
        RNEstado objRnEstadoProgramacion = new RNEstado ();
        public void MostrarProgramacion()
        {
            //dg_Programacion.DataSource = objRnEmpleado.ListaEmpleado("");
        }

        //void Guardar()
        //{
            
        //    for (int i = 0; i < dg_Programacion.RowCount - 1; i++)
        //    {
        //        Programacion objProgramacion = new Programacion();
                
        //        if (dg_Programacion.Rows[i].Cells[0].Value!= null)
        //        {
        //            objProgramacion.id = objRnProgramacion.GenerarId();
        //            //objProgramacion.idEmpleado = Int32.Parse(dg_Programacion.Rows[i].Cells[1].Value.ToString());
        //            objProgramacion.FechaInicio = dateTPProgDe.Value;
        //            objProgramacion.FechaFin = dateTPProgA.Value;
        //            //objProgramacion.idEstadoProgramacion = 1;
        //            if (objRnProgramacion.Insertar(objProgramacion))
        //                MessageBox.Show("Empleado programado");
        //            else
        //                MessageBox.Show("Error en la programacion");
        //        }
        //    }
        //}

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            //Guardar();
        }

        private void BuscarNombre()
        {
            //dg_Programacion.DataSource = objRnEmpleado.TraerEmpleadoNombre(txt_Empleado.Text);
        }

        private void txt_Empleado_TextChanged(object sender, EventArgs e)
        {
            BuscarNombre();
        }
    }
}
