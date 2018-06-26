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
    public partial class FrmGrupo : Form
    {
        public FrmGrupo()
        {
            InitializeComponent();
            CargarGrupo();
        }

        Grupo objGrupo = new Grupo();

        RNGrupo objRnGrupo = new RNGrupo();

        private void CargarGrupo()
        {
            dg_Grupo.DataSource = objRnGrupo.ListaGrupo(0);
            dg_Grupo.AutoResizeColumns();
        }

        private void btn_Guardar_Click(object sender, EventArgs e)
        {
            objGrupo.id = objRnGrupo.GenerarId();
            objGrupo.NombreGrupo = txt_Grupo.Text;

            if (objRnGrupo.Insertar(objGrupo))
                MessageBox.Show("Grupo insertado con exito!");
            else
                MessageBox.Show("Error en la insercion del Grupo");
        }
    }
}
