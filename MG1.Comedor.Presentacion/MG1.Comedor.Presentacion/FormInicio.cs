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
    public partial class FormInicio : Form
    {
        public FormInicio()
        {
            InitializeComponent();
            CargarDatos();
        }

        Persona objPersona = new Persona();
        Empleado objEmpleado = new Empleado();
        Empresa objEmpresa = new Empresa();
        Area objArea = new Area();
        CentroCosto objCentroCosto = new CentroCosto();
        Programacion objProgramacion = new Programacion();
        Usuario objUsuario = new Usuario();
        Grupo objGrupo = new Grupo();
        Perfil objPerfil = new Perfil();
        VGrupoPerfil objGrupoPerfil = new VGrupoPerfil();
        VDetalleProgramacion objVDetalleProgramacion = new VDetalleProgramacion();
        DetalleProgramacion objDetalleProgramacion = new DetalleProgramacion();
        Estado objEstado = new Estado();
        Alimento objAlimento = new Alimento();
        DetalleEstadoServicio objDetalleEstadoServicio = new DetalleEstadoServicio();
        OrdenServicio objOrdenServicio = new OrdenServicio();
        MG1.ComedorGeo.Datos.Menu objMenu = new MG1.ComedorGeo.Datos.Menu();
        Bitacora objBitacora = new Bitacora();

        RNPersona objRnPersona = new RNPersona();
        RNEmpleado objRnEmpleado = new RNEmpleado();
        RNEmpresa objRnEmpresa = new RNEmpresa();
        RNArea objRnArea = new RNArea();
        RNCentroCosto objRnCentroCosto = new RNCentroCosto();
        RNProgramacion objRnProgramacion = new RNProgramacion();
        RNUsuario objRnUsuario = new RNUsuario();
        RNGrupo objRnGrupo = new RNGrupo();
        RNPerfil objRnPerfil = new RNPerfil();
        RNGrupoPerfil objRnGrupoPerfil = new RNGrupoPerfil();
        RNDetalleProgramacion objRnDetalleProgramacion = new RNDetalleProgramacion();
        RNEstado objRnEstado = new RNEstado();
        RNAlimento objRnAlimento = new RNAlimento();
        RNDetalleEstadoServicio objRnDetalleEstadoServicio = new RNDetalleEstadoServicio();
        RNOrdenServicio objRnOrdenServicio = new RNOrdenServicio();
        RNMenu objRnMenu = new RNMenu();
        RNBitacora objRnBitacora = new RNBitacora();

        bool sw;

        private void btn_Empleado_Click(object sender, EventArgs e)
        {
            tab_Principal.SelectedIndex = 1;
        }

        private void CargarDatos()
        {
            CargarEmpleado("");
            CargarSexo();
            CargarEmpresa();
            CargarCargo();
            CargarTurno();
            CargarCentroCosto();
            lb_Usuario.Text = Utilitarios.Nombre_Usuario;
            VistaPerfiles(Utilitarios.id_Grupo);
            CargarNombreCompleto();
            CargarGrupo();
            CargarPerfil();
            CargarUsuario();
            CargarDetalleProgramacion();
            CargarEmpleadoProgramacion();
            CargarArea();
            CargarCentro(1);
            CargarAlimento();
            CargarEmpleadoOrden();
            CargarDetalleServicio();
            CargarProgramacion();
            MostrarReporte(1);
            CargarBitacora();

            Utilitarios.id_Persona = 1;
            Utilitarios.id_Menu = 1;

            cb_Grupo.SelectedValue = objRnUsuario.TraerGrupoUsuario(Utilitarios.id_Usuario);

            sw = false;
        }

        void MostrarEmpleado(long grp, long prf)
        {
            if (objRnGrupoPerfil.ExistePerfil(grp, prf) == 0)
            {
                btn_Empleado.Visible = false;
                tab_Principal.Controls.Remove(tab_Empleado);
            }
            else
            {
                btn_Empleado.Visible = true;
                tab_Usuario.Parent.Visible = true;
                //tab_Principal.Controls.Add(tab_Empleado);
            }
        }

        void MostrarMenu(long grp, long prf)
        {
            if (objRnGrupoPerfil.ExistePerfil(grp, prf) == 0)
            {
                btn_Menu.Visible = false;
                tab_Principal.Controls.Remove(tab_Menu);
            }
            else
            {
                btn_Menu.Visible = true;
                //tab_Menu.Parent.Visible = true;
                //tab_Principal.Controls.Add(tab_Menu);
            }
        }

        void MostrarProgramacion(long grp, long prf)
        {
            if (objRnGrupoPerfil.ExistePerfil(grp, prf) == 0)
            {
                btn_Programacion.Visible = false;
                tab_Principal.Controls.Remove(tab_Programacion);
            }
            else
            {
                btn_Programacion.Visible = true;
                //tab_Programacion.Parent.Visible = true;
                //tab_Principal.Controls.Add(tab_Programacion);
            }
        }

        void MostrarGrupoPerfil(long grp, long prf)
        {
            if (objRnGrupoPerfil.ExistePerfil(grp, prf) == 0)
            {
                btn_GrupoPerfil.Visible = false;
                tab_Principal.Controls.Remove(tab_GrupoPerfil);
            }
            else
            {
                btn_GrupoPerfil.Visible = true;
                //tab_GrupoPerfil.Parent.Visible = true;
                //tab_Principal.Controls.Add(tab_GrupoPerfil);
            }
        }

        void MostrarReporte(long grp, long prf)
        {
            if (objRnGrupoPerfil.ExistePerfil(grp, prf) == 0)
            {
                btn_Reporte.Visible = false;
                tab_Principal.Controls.Remove(tab_Reporte);
            }
            else
            {
                btn_Reporte.Visible = true;
                //tab_Reporte.Parent.Visible = true;
                //tab_Principal.Controls.Add(tab_Reporte);
            }
        }

        void MostrarBitacora(long grp, long prf)
        {
            if (objRnGrupoPerfil.ExistePerfil(grp, prf) == 0)
            {
                //btn_Reporte.Visible = false;
                tab_Principal.Controls.Remove(tab_Bitacora);
            }
            else
            {
                //tab_Bitacora.Parent.Visible = true;
                //tab_Principal.Controls.Add(tab_Bitacora);
            }
        }

        private void VistaPerfiles(long g)
        {
            for (int p = 1; p <= 6; p++)
            {
                switch (p)
                {
                    case 1:
                        MostrarEmpleado(g, p);
                        break;
                    case 2:
                        MostrarMenu(g, p);
                        break;
                    case 3:
                        MostrarProgramacion(g, p);
                        break;
                    case 4:
                        MostrarGrupoPerfil(g, p);
                        break;
                    case 5:
                        MostrarReporte(g, p);
                        break;
                    case 6:
                        MostrarBitacora(g, p);
                        break;
                }
            }

        }
        private void CargarEmpleado(string a)
        {
            dg_Empleado.DataSource = objRnEmpleado.ListaEmpleado(a);
            dg_Empleado.Columns[0].Visible = false;
            dg_Empleado.Columns[2].Visible = false;
            dg_Empleado.Columns[5].Visible = false;
            dg_Empleado.Columns[7].Visible = false;
            dg_Empleado.Columns[9].Visible = false;
            dg_Empleado.Columns[11].Visible = false;
            dg_Empleado.Columns[13].Visible = false;

            cb_Empleado.DisplayMember = "NombreCompleto";
            cb_Empleado.ValueMember = "id";
            cb_Empleado.DataSource = objRnEmpleado.ListaEmpleadoProgramado(0);
        }

        private void CargarSexo()
        {
            cb_Sexo.Items.Add("Masculino");
            cb_Sexo.Items.Add("Femenino");
        }

        private void CargarEmpresa()
        { }

        private void CargarCargo()
        { }

        private void CargarTurno()
        { }

        private void CargarCentroCosto()
        {
            cb_CCostoProgramacion.DisplayMember = "NombreCentroCosto";
            cb_CCostoProgramacion.ValueMember = "id";
            cb_CCostoProgramacion.DataSource = objRnCentroCosto.ListaCentro(0);
        }

        private void CargarNombreCompleto()
        {
            cb_NombreCompleto.DisplayMember = "NombreCompleto";
            cb_NombreCompleto.ValueMember = "id";
            cb_NombreCompleto.DataSource = objRnPersona.ListaNombreCompleto(0);
        }

        private void CargarGrupo()
        {
            cb_Grupo.ValueMember = "id";
            cb_Grupo.DisplayMember = "NombreGrupo";
            cb_Grupo.DataSource = objRnGrupo.ListaGrupo(0);
        }

        private void CargarPerfil()
        {
            dg_Perfil.DataSource = objRnPerfil.ListaPerfil("");
            dg_Perfil.AutoResizeColumns();

            /*for (int i=0;i<=dg_Perfil.Rows.Count-1;i++)
            {
                if (i == 0)
                    if (objRnGrupoPerfil.ExistePerfil(Utilitarios.id_Grupo))
                        dg_Perfil.Rows[Convert.ToInt32(i)].Cells["Seleccionar"].Value = 1;

                if (i == 1)
                    if (objRnGrupoPerfil.ExisteMenu(Utilitarios.id_Grupo))
                        dg_Perfil.Rows[Convert.ToInt32(i)].Cells["Seleccionar"].Value = 1;

                if (i == 2)
                    if (objRnGrupoPerfil.ExisteProgramacion(Utilitarios.id_Grupo))
                        dg_Perfil.Rows[Convert.ToInt32(i)].Cells["Seleccionar"].Value = 1;

                if (i == 3)
                    if (objRnGrupoPerfil.ExisteUsuario(Utilitarios.id_Grupo))
                        dg_Perfil.Rows[Convert.ToInt32(i)].Cells["Seleccionar"].Value = 1;

                if (i==4)
                    if(objRnGrupoPerfil.ExisteReporte(Utilitarios.id_Grupo))
                        dg_Perfil.Rows[Convert.ToInt32(i)].Cells["Seleccionar"].Value = 1;
            }*/

            //foreach (DataGridViewRow row in dg_Perfil.Rows)
            //row.Cells["Seleccionar"].Value = CheckState.Checked;
            //if (objRnGrupoPerfil.ExisteEmpleado(c))
            //    row.Cells["Seleccionar"].Value = this.Seleccionar.TrueValue;

        }

        private void CargarUsuario()
        {
            tv_Grupo.Nodes.Clear();

            dgtv_Grupo.DataSource = objRnGrupo.ListaGrupo(0);
            //dgtv_Grupo.DataMember = "NombreGrupo";

            TreeNode padre = null;
            TreeNode hijo = null;

            for (int i = 0; i < dgtv_Grupo.RowCount; i++)
            {
                //MessageBox.Show(dgtv_Grupo[1, i].Value.ToString());

                padre = new TreeNode(dgtv_Grupo[1, i].Value.ToString());

                dgtv_Usuario.DataSource = objRnUsuario.ListaUsuario(Convert.ToInt64(dgtv_Grupo[0, i].Value));
                //dgtv_Usuario.DataMember = "NombreUsuario";

                for (int j = 0; j < dgtv_Usuario.RowCount; j++)
                {
                    //MessageBox.Show(dgtv_Usuario[1, j].Value.ToString());
                    hijo = new TreeNode(dgtv_Usuario[1, j].Value.ToString());
                    padre.Nodes.Add(hijo);
                }
                tv_Grupo.Nodes.Add(padre);

            }
        }

        private void CargarArea()
        {
            cb_AreaProgramacion.DisplayMember = "NombreArea";
            cb_AreaProgramacion.ValueMember = "id";
            cb_AreaProgramacion.DataSource = objRnArea.ListaArea("");
        }

        private void CargarPersona()
        {
            txt_Nombre.Text = objRnPersona.NombrePersona(Utilitarios.id_Persona);
            txt_ApPaterno.Text = objRnPersona.ApellidoPaterno(Utilitarios.id_Persona);
            txt_ApMaterno.Text = objRnPersona.ApellidoMaterno(Utilitarios.id_Persona);

            if (objRnPersona.Sexo(Utilitarios.id_Persona) == "m")
                cb_Sexo.SelectedItem = "Masculino";
            else
                cb_Sexo.SelectedItem = "Femenino";

            dateTPFechaNac.Value = objRnPersona.FechaNacimiento(Utilitarios.id_Persona);

            txt_Carnet.Text = objRnPersona.DocumentoIdentidad(Utilitarios.id_Persona).ToString();

        }

        private void CargarProgramacion()
        {
            cb_Programacion.DisplayMember = "FechaInicio";
            cb_Programacion.ValueMember = "idProgramacion";
            cb_Programacion.DataSource = objRnDetalleProgramacion.TraerIdEmp(Convert.ToInt64(cb_EmpleadoServicio.SelectedValue));
        }
        private void CargarDetalleProgramacion()
        {
            dg_DetalleProgramacion.DataSource = objRnDetalleProgramacion.Traer(0);
            dg_DetalleProgramacion.AutoResizeColumns();
        }

        private void CargarEmpleadoProgramacion()
        {
            dg_EmpleadoProgramacion.DataSource = objRnEmpleado.ListaEmpleado(0);
            dg_EmpleadoProgramacion.AutoResizeColumns();
        }

        private void CargarAlimentoTabla()
        {
            dg_Alimento.DataSource = objRnAlimento.ListaAlimentoMenu(0);
            dg_Alimento.Columns[3].Visible = false;
            dg_Alimento.Columns[4].Visible = false;
            dg_Alimento.AutoResizeColumns();
        }
        private void CargarAlimento()
        {
            cb_Alimento.DisplayMember = "NombreAlimento";
            cb_Alimento.ValueMember = "id";
            cb_Alimento.DataSource = objRnAlimento.ListaAlimento(0);
        }

        private void CargarEmpleadoOrden()
        {
            cb_EmpleadoServicio.DisplayMember = "NombreCompleto";
            cb_EmpleadoServicio.ValueMember = "id";
            cb_EmpleadoServicio.DataSource = objRnEmpleado.ListaEmpleadoProgramado(0);
        }

        private void CargarDetalleServicio()
        {
            dg_DetalleServicio.DataSource = objRnDetalleProgramacion.TraerDetalle(Convert.ToInt64(cb_EmpleadoServicio.SelectedValue), dateTPFechaMenu.Value);
        }

        private void GuardarEmpleado()
        {
            objPersona.id = objRnPersona.GenerarId();
            objPersona.NombrePersona = txt_Nombre.Text;
            objPersona.ApellidoPaterno = txt_ApPaterno.Text;
            objPersona.ApellidoMaterno = txt_ApMaterno.Text;

            if (cb_Sexo.SelectedItem.ToString() == "Masculino")
                objPersona.Sexo = "m";
            else
                objPersona.Sexo = "f";

            objPersona.FechaNacimiento = dateTPFechaNac.Value;
            objPersona.DocumentoIdentidad = Convert.ToInt64(txt_Carnet.Text);

            if (objRnPersona.Insertar(objPersona))
            {
                objEmpleado.id = objPersona.id;
                objEmpleado.idEmpresa = Convert.ToInt64(cb_Empresa.SelectedValue);
                objEmpleado.idCargo = Convert.ToInt64(cb_Cargo.SelectedValue);
                objEmpleado.idArea = Convert.ToInt64(cb_Area.SelectedValue);
                objEmpleado.idCentroCosto = Convert.ToInt64(cb_CentroCosto.SelectedValue);
                objEmpleado.FechaIngreso = dateTPFechaIngreso.Value;
                objEmpleado.idTurno = Convert.ToInt64(cb_Turno.SelectedValue);
                objEmpleado.idUsuario = Convert.ToInt64(cb_Usuario.SelectedValue);

                if (objRnEmpleado.Insertar(objEmpleado))
                    MessageBox.Show("Insertado con exito");
                else
                    MessageBox.Show("Error en la insercion de empleado");
            }
            else
                MessageBox.Show("Error en la insercion de persona");

            //try
            //{
                
            //}
            //catch (Exception)
            //{
            //    throw;
            //}

        }

        private void GuardarDetalleProgramacion()
        {
            objProgramacion.id = objRnProgramacion.GenerarId();
            objProgramacion.FechaInicio = dateTPProgDe.Value;
            objProgramacion.FechaFin = dateTPProgA.Value;

            objDetalleProgramacion.idEmpleado = Convert.ToInt64(cb_Empleado.SelectedValue);

            objDetalleProgramacion.idEstado = Convert.ToInt64(cb_AreaProgramacion.SelectedValue);

            if (objRnProgramacion.Insertar(objProgramacion))
            {
                objDetalleProgramacion.idProgramacion = objProgramacion.id;

                if (objRnDetalleProgramacion.Insertar(objDetalleProgramacion))
                {
                    MessageBox.Show("Detalle guardado con exito");
                    CargarDetalleProgramacion();
                }
                else
                    MessageBox.Show("Error al guardar el detalle");
            }

        }

        private void GuardarDetalleServicio()
        {
            objDetalleEstadoServicio.idEmpleado = Convert.ToInt64(cb_EmpleadoServicio.SelectedValue);
            objDetalleEstadoServicio.idProgramacion = Convert.ToInt64(cb_Programacion.SelectedValue);

            objOrdenServicio.id = objRnOrdenServicio.GenerarId();
            objOrdenServicio.Observacion = "";
            objOrdenServicio.idMenu = objRnMenu.TraerId(Convert.ToInt64(cb_EmpleadoServicio.SelectedValue), dateTPFechaMenu.Value);

            objDetalleEstadoServicio.idOrdenServicio = objOrdenServicio.id;
            objDetalleEstadoServicio.idEstado = 2;

            if (objRnOrdenServicio.Insertar(objOrdenServicio))
            {
                if (objRnDetalleEstadoServicio.Insertar(objDetalleEstadoServicio))
                    MessageBox.Show("Registro guardado con exito");
                else
                    MessageBox.Show("Error en el registro");
            }

        }

        private void CargarBitacora()
        {
            dg_Bitacora.DataSource = objRnBitacora.MostrarBitacora(0);
        }
        private void btn_Menu_Click(object sender, EventArgs e)
        {
            tab_Principal.SelectedIndex = 2;
        }

        private void btn_Programacion_Click(object sender, EventArgs e)
        {
            tab_Principal.SelectedIndex = 3;
        }

        private void FormInicio_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dbAlimentacionGeoDataSet.Perfil' Puede moverla o quitarla según sea necesario.
            this.perfilTableAdapter.Fill(this.dbAlimentacionGeoDataSet.Perfil);
            // TODO: esta línea de código carga datos en la tabla 'dbAlimentacionGeoDataSet.GrupoPerfil' Puede moverla o quitarla según sea necesario.
            this.grupoPerfilTableAdapter.Fill(this.dbAlimentacionGeoDataSet.GrupoPerfil);
            // TODO: esta línea de código carga datos en la tabla 'dbAlimentacionGeoDataSet.Grupo' Puede moverla o quitarla según sea necesario.
            this.grupoTableAdapter.Fill(this.dbAlimentacionGeoDataSet.Grupo);
            // TODO: esta línea de código carga datos en la tabla 'dbAlimentacionGeoDataSet.Usuario' Puede moverla o quitarla según sea necesario.
            this.usuarioTableAdapter.Fill(this.dbAlimentacionGeoDataSet.Usuario);
            // TODO: esta línea de código carga datos en la tabla 'dbAlimentacionGeoDataSet.CentroCosto' Puede moverla o quitarla según sea necesario.
            this.centroCostoTableAdapter.Fill(this.dbAlimentacionGeoDataSet.CentroCosto);
            // TODO: esta línea de código carga datos en la tabla 'dbAlimentacionGeoDataSet.Area' Puede moverla o quitarla según sea necesario.
            this.areaTableAdapter.Fill(this.dbAlimentacionGeoDataSet.Area);
            // TODO: esta línea de código carga datos en la tabla 'dbAlimentacionGeoDataSet.Turno' Puede moverla o quitarla según sea necesario.
            this.turnoTableAdapter.Fill(this.dbAlimentacionGeoDataSet.Turno);
            // TODO: esta línea de código carga datos en la tabla 'dbAlimentacionGeoDataSet.Cargo' Puede moverla o quitarla según sea necesario.
            this.cargoTableAdapter.Fill(this.dbAlimentacionGeoDataSet.Cargo);
            // TODO: esta línea de código carga datos en la tabla 'dbAlimentacionGeoDataSet.Empresa' Puede moverla o quitarla según sea necesario.
            this.empresaTableAdapter.Fill(this.dbAlimentacionGeoDataSet.Empresa);
            CargarDatos();
            this.reportViewer1.RefreshReport();
        }

        private void CargarCentro(int id_Area)
        {
            cb_CentroCosto.DisplayMember = "NombreCentroCosto";
            cb_CentroCosto.ValueMember = "id";
            cb_CentroCosto.DataSource = objRnCentroCosto.ListaCentro(id_Area);
        }

        private void cb_Area_SelectedIndexChanged(object sender, EventArgs e)
        {
            CargarCentro(Convert.ToInt32(cb_Area.SelectedValue));
        }

        private void btn_Guardar_Click(object sender, EventArgs e)
        {
            GuardarEmpleado();
        }

        private void txt_Buscar_TextChanged(object sender, EventArgs e)
        {
            CargarEmpleado(txt_Buscar.Text);
        }

        private void btn_Usuario_Click(object sender, EventArgs e)
        {
            tab_Principal.SelectedIndex = 4;
            sw = true;
        }

        private void dg_Perfil_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.ColumnIndex == 0)
            {
                for (int i = 0; i < dg_Perfil.Rows.Count - 1; i++)
                {
                }
            }
        }

        private void btn_guardarPerfil_Click(object sender, EventArgs e)
        {
            objGrupo.id = Convert.ToInt32(cb_Grupo.SelectedValue);

            foreach (DataGridViewRow row in dg_Perfil.Rows)
            {
                if (Convert.ToBoolean(row.Cells["Seleccionar"].Value))
                {
                    objGrupoPerfil.idGrupo = objGrupo.id;
                    objGrupoPerfil.idPerfil = Convert.ToInt32(row.Cells["id"].Value);
                }

                if (objRnGrupoPerfil.Insertar(objGrupoPerfil))
                    MessageBox.Show("Los datos fueron guardados satisfactoriamente.");

            }

        }

        private void btn_GuardarProgramacion_Click(object sender, EventArgs e)
        {
            GuardarDetalleProgramacion();
        }

        private void cb_Grupo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if ((Convert.ToInt64(cb_Grupo.SelectedValue) == 0) && (sw == false))
                Utilitarios.id_Grupo = 1;
            else
                Utilitarios.id_Grupo = Convert.ToInt64(cb_Grupo.SelectedValue);

            CargarPerfil();
            //VistaPerfiles();

            //if (sw)
            //{
            //    CargarPerfil();
            //    VistaPerfiles();
            //}
        }

        private void OcultarFormularios()
        {
            //tab_Principal.Controls.Remove(tab_Empleado);
            //tab_Principal.Controls.Remove(tab_Menu);
            //tab_Principal.Controls.Remove(tab_Programacion);
            //tab_Principal.Controls.Remove(tab_GrupoPerfil);
            //tab_Principal.Controls.Remove(tab_Reporte);
            //tab_Principal.Controls.Remove(tab_Bitacora);

            tab_Usuario.Parent.Visible = false;
            tab_Empleado.Parent.Visible = false;
            tab_Menu.Parent.Visible = false;
            tab_Programacion.Parent.Visible = false;
            tab_GrupoPerfil.Parent.Visible = false;
            tab_Reporte.Parent.Visible = false;
            tab_Bitacora.Parent.Visible = false;
        }

        private void MostrarFormularios()
        {
            //tab_Principal.Controls.Add(tab_Usuario);
            //tab_Principal.Controls.Add(tab_Empleado);
            //tab_Principal.Controls.Add(tab_Menu);
            //tab_Principal.Controls.Add(tab_Programacion);
            //tab_Principal.Controls.Add(tab_GrupoPerfil);
            //tab_Principal.Controls.Add(tab_Reporte);
            //tab_Principal.Controls.Add(tab_Bitacora);

            tab_Usuario.Parent.Visible = true;
            tab_Empleado.Parent.Visible = true;
            tab_Menu.Parent.Visible = true;
            tab_Programacion.Parent.Visible = true;
            tab_GrupoPerfil.Parent.Visible = true;
            tab_Reporte.Parent.Visible = true;
            tab_Bitacora.Parent.Visible = true;
        }

        private void lb_Usuario_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea cambiar de Usuario?", "CAMBIAR USUARIO", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (MessageBox.Show("¿Desea ocultar?", "OCULTAR", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    OcultarFormularios();
                if (MessageBox.Show("¿Desea mostrar?", "MOSTRAR", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    MostrarFormularios();
                tab_Principal.SelectedIndex = 0;
                //FrmLogin fr = new FrmLogin();
                //fr.Show();
                //this.Close();
            }
            else
            {
                MessageBox.Show("Ok");
            }

        }

        public void MostrarReporte(Int32 nroReporte)
        {
            switch (nroReporte)
            {
                case 1:
                    this.reportViewer1.ProcessingMode = Microsoft.Reporting.WinForms.ProcessingMode.Local;
                    this.reportViewer1.LocalReport.ReportPath = Utilitarios.rutaReporte + "RptDetalleServicio.rdlc";
                    this.reportViewer1.LocalReport.DataSources.Clear();
                    //Int64 id;
                    this.reportViewer1.LocalReport.DataSources.Add(new Microsoft.Reporting.WinForms.ReportDataSource("DataSet1", objRnDetalleProgramacion.TraerIdEmp(0)));
                    //if (Int64.TryParse(this.txtBuscar.Text, out id))
                    //    this.reportViewer1.LocalReport.DataSources.Add(new Microsoft.Reporting.WinForms.ReportDataSource("DataSet2", objRnDetalleProgramacion.TraerIdEmp(0)));
                    //else
                    //{
                    //    /*txtBuscar por nombre*/
                    //}
                    this.reportViewer1.LocalReport.Refresh();
                    break;
                default:
                    break;
            }
        }

        private void btn_Reporte_Click(object sender, EventArgs e)
        {
            tab_Principal.SelectedIndex = 5;
            MostrarReporte(1);
        }

        private void cb_NombreCompleto_SelectedIndexChanged(object sender, EventArgs e)
        {
            Utilitarios.id_Persona = Convert.ToInt64(cb_NombreCompleto.SelectedValue);
            CargarPersona();
        }

        private void btn_Grupo_Click(object sender, EventArgs e)
        {
            FrmGrupo fg = new FrmGrupo();
            fg.Show();
            CargarGrupo();
            CargarUsuario();
        }

        private void btn_Usuario_Click_1(object sender, EventArgs e)
        {
            FrmUsuario fu = new FrmUsuario();
            fu.Show();
        }

        private void dateTPFechaMenu_ValueChanged(object sender, EventArgs e)
        {
            CargarDetalleServicio();
        }

        private void cb_EmpleadoServicio_SelectedIndexChanged(object sender, EventArgs e)
        {
            CargarDetalleServicio();
        }

        private void btn_GuardarDetalleServicio_Click(object sender, EventArgs e)
        {
            GuardarDetalleServicio();
        }

        private void cb_Alimento_SelectedIndexChanged(object sender, EventArgs e)
        {
            Utilitarios.id_Menu = Convert.ToInt64(cb_Alimento.SelectedValue);
            CargarAlimentoTabla();
        }

        private void BuscarEmpleadoProgramacion(string a)
        {
            dg_EmpleadoProgramacion.DataSource = objRnEmpleado.ListaEmpleadoProgramacion(0);
            dg_EmpleadoProgramacion.AutoResizeColumns();
        }

        private void cb_AreaProgramacion_SelectedIndexChanged(object sender, EventArgs e)
        {
            BuscarEmpleadoProgramacion(cb_AreaProgramacion.SelectedValue.ToString());
        }

        private void btn_AdicionarCargo_Click(object sender, EventArgs e)
        {
            FrmCargo fc = new FrmCargo();
            fc.Show();
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
                Utilitarios.Nombre_Usuario = objRnUsuario.ExisteUsuarioNombre(txt_User.Text);
                Utilitarios.id_Grupo = objRnUsuario.TraerGrupoUsuario(Utilitarios.id_Usuario);
                MessageBox.Show("Bienvenido!!! " + txt_User.Text);
                lb_Usuario.Text = Utilitarios.Nombre_Usuario;
                VistaPerfiles(Utilitarios.id_Grupo);

                txt_User.Text = "";
                txt_Password.Text = "";
                tab_Usuario.Parent.Visible = false;
                //tab_Principal.Controls.Remove(tab_Usuario);
            }
            else
            {
                MessageBox.Show("Usuario y/o contraseña no coindicen");
            }
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            ValidarUsuario();
        }

    }
}
