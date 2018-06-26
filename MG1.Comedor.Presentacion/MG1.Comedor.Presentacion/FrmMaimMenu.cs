using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MG1.Comedor.Presentacion
{
    public partial class FrmMaimMenu : Form
    {
        public FrmMaimMenu()
        {
            InitializeComponent();
        }
        private void AbrirFrm(object FrmPrincipal)
        {
            if (this.Contenedor.Controls.Count > 0)
                this.Contenedor.Controls.RemoveAt(0);
            Form Fh = FrmPrincipal as Form;
            Fh.TopLevel = false;
            Fh.Dock = DockStyle.Fill;
            this.Contenedor.Controls.Add(Fh);
            this.Contenedor.Tag = Fh;
            Fh.Show();

        }
        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            AbrirFrm(new FrmEmpleado());
            
        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            AbrirFrm(new FrmMenu());

        }

        private void bunifuFlatButton3_Click(object sender, EventArgs e)
        {
            AbrirFrm(new FrmProgramacion());
        }

        private void bunifuFlatButton5_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
