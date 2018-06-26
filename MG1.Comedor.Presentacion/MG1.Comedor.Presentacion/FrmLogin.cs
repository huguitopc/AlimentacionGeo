using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MG1.ComedorGeo.Negocio;
using MG1.ComedorGeo.Datos;
using MG1.ComedorGeo.Utilitarios;
using System.Security.Cryptography;

namespace MG1.Comedor.Presentacion
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        RNUsuario objRnUsuario = new RNUsuario();

        public static string EncodePassword(string originalPassword)
        {
            SHA1 sha1 = new SHA1CryptoServiceProvider();

            byte[] inputBytes = (new UnicodeEncoding()).GetBytes(originalPassword);
            byte[] hash = sha1.ComputeHash(inputBytes);

            return Convert.ToBase64String(hash);
        }
        public void ValidarUsuario()
        {
            Usuario objUsuario = new Usuario();
            objUsuario.NombreUsuario = txt_User.Text;
            //objUsuario.Contraseña = EncodePassword(txt_Password.Text);
            objUsuario.Contraseña = txt_Password.Text;

            if (objRnUsuario.ExisteUsuario(objUsuario))
            {
                Utilitarios.id_Usuario = objRnUsuario.ExisteUsuarioId(txt_User.Text);
                Utilitarios.Nombre_Usuario = txt_User.Text;
                Utilitarios.id_Grupo = objRnUsuario.TraerGrupoUsuario(Utilitarios.id_Usuario);
                MessageBox.Show("Bienvenido!!! " + txt_User.Text);
                FrmPrincipal frm = new FrmPrincipal();
                FormInicio frm1 = new FormInicio();
                //frm.Show();
                frm1.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Usuario y/o contraseña no coindicen");
                //this.Close();
            }
        }
        private void btnIngresar_Click(object sender, EventArgs e)
        {
            ValidarUsuario();
        }
    }
}
