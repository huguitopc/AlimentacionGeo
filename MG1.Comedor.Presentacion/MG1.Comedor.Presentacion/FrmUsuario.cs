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
    public partial class FrmUsuario : Form
    {
        public FrmUsuario()
        {
            InitializeComponent();
            CargarDatos();
        }

        Usuario objUsuario = new Usuario();
        Grupo objGrupo = new Grupo();

        RNUsuario objRnUsuario = new RNUsuario();
        RNGrupo objRnGrupo = new RNGrupo();

        private void CargarDatos()
        {
            CargarUsuario();
            CargarGrupo();
        }

        private void CargarGrupo()
        {
            cb_Grupo.DisplayMember = "NombreGrupo";
            cb_Grupo.ValueMember = "id";
            cb_Grupo.DataSource = objRnGrupo.ListaGrupo(0);
        }

        private void CargarUsuario()
        {
            dg_Usuario.DataSource = objRnUsuario.ListaUsuario(0);
            dg_Usuario.AutoResizeColumns();
        }

        private void btn_Guardar_Click(object sender, EventArgs e)
        {
            objUsuario.id = objRnUsuario.GenerarId();
            objUsuario.NombreUsuario = txt_Usuario.Text;
            objUsuario.Contraseña = txt_Contraseña.Text;
            objUsuario.idGrupo = Convert.ToInt64(cb_Grupo.SelectedValue);

            if (objRnUsuario.Insertar(objUsuario))
                MessageBox.Show("Usuario insertado con exito!");
            else
                MessageBox.Show("Error en la insercion del Usuario");
        }
    }
}
