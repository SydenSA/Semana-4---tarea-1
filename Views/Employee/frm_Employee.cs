using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using _06Publicaciones.config;
using _06Publicaciones.Controllers;


namespace _06Publicaciones
{
    public partial class frm_Employee : Form
    {
        public frm_Employee()
        {
            InitializeComponent();
        }

        private void textBox_IDempleado_TextChanged(object sender, EventArgs e)
        {

        }

        private void listBox_Empleados_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }
        private void frm_Employee_Load(object sender, EventArgs e)
        {
            CargaEmployee();
        }
        public void CargaEmployee()
        {
            var listaEmployee = Employee.ObtenerTodos();
            listBox_Empleados.DataSource = null;
            listBox_Empleados.DataSource = listaEmployee;
            listBox_Empleados.DisplayMember = "NombreCompleto";
            listBox_Empleados.ValueMember = "IdEmployee";



        }

        private bool validarcampos(params TextBox[] cajadetexto)
        {
            foreach (var caja in cajadetexto)
            {
                if (string.IsNullOrWhiteSpace(caja.Text))
                {
                    ErrorHandler.ManejarErrorGeneral(null, "Complete la informacion");
                    return false;
                }
            }
            return true;



        }

        private void Boton_Insertar_Employee_Click(object sender, EventArgs e)
        {
            try
            {
                #region
                /*if (string.IsNullOrWhiteSpace(textBoxIdAutor.Text)|| 
                    string.IsNullOrWhiteSpace(textBox_NombreEmpleado.Text) ||
                    string.IsNullOrWhiteSpace(textBoxNombre.Text) ||
                    string.IsNullOrWhiteSpace(textBoxCiudad.Text) ||
                    string.IsNullOrWhiteSpace(textBoxCodigoPostal.Text) ||
                    string.IsNullOrWhiteSpace(textBoxDireccion.Text) ||
                    string.IsNullOrWhiteSpace(textBoxTelefono.Text) ||
                    string.IsNullOrWhiteSpace(textBoxEstado.Text) 
                    ) {
                    ErrorHandler.ManejarErrorGeneral(null, "Complete todo los campos");
                    return;
                }*/
                #endregion

                if (!validarcampos(textBox_IDempleado, textBox_NombreEmpleado, textBox_Minit, textBox_ApellidoEmpleado,
                    textBox_IDtrabajo, textBox_NivelEmpleado, textBox_FechaContratacion))


                {
                    return;
                }

                var employee = new Employee
                {
                    IdEmployee = textBox_IDempleado.Text,
                    Nombre_em = textBox_NombreEmpleado.Text,
                    Minit = textBox_Minit.Text,
                    Apellido_em = textBox_ApellidoEmpleado.Text,
                    Idtrabajo = textBox_IDtrabajo.Text,
                    IdNivel = textBox_NivelEmpleado.Text,
                   IdPub = textBox_IdPub.Text,
                    contrato_em = textBox_FechaContratacion.Text
                };

                var insertado = Employee.Insertar(employee);
                if (insertado != null)
                {
                    CargaEmployee();
                    ErrorHandler.ManejarInsertar();
                }
                else
                {
                    return;
                }
            }
            catch (Exception ex)
            {
                ErrorHandler.ManejarErrorGeneral(ex, "");
            }
        }

        private void Boton_cancelar_Employee_Click(object sender, EventArgs e)
        {
            textBox_IDempleado.Clear();
            textBox_NombreEmpleado.Clear();
            textBox_Minit.Clear();
            textBox_ApellidoEmpleado.Clear();
            textBox_IDtrabajo.Clear();
            textBox_NivelEmpleado.Clear();
            textBox_IdPub.Clear();
            textBox_FechaContratacion.Clear();
        }
    }
}
