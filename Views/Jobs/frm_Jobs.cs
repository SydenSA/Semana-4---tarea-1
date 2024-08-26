using _06Publicaciones.config;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _06Publicaciones
{
    public partial class frm_Jobs : Form
    {
        public frm_Jobs()
        {
            InitializeComponent();
        }

        private void frm_Jobs_Load(object sender, EventArgs e)
        {
            CargaJobs();
        }
        public void CargaJobs()
        {
            var list = Jobs.ObtenerTodos();
            listBox_trabajo.DataSource = null;
            listBox_trabajo.DataSource = list;
            listBox_trabajo.DisplayMember = "NombreCompleto";
            listBox_trabajo.ValueMember = "IdJobs";



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

        private void Boton_Insertar_jobs_Click(object sender, EventArgs e)
        {
            try
            {
                #region
            
                #endregion

                if (!validarcampos(textBox_IDjobs, textBox_trabajoDireccion, 
                    textBox_minimo, textBox_maximo))


                {
                    return;
                }

                var jobs = new Jobs
                {
                    IdJobs = textBox_IDjobs.Text,
                    Direc_Jobs = textBox_trabajoDireccion.Text,
                    min = textBox_minimo.Text,
                    max = textBox_maximo.Text,
                
                };

                var insertado = Jobs.Insertar(jobs);
                if (insertado != null)
                {
                  CargaJobs();
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

        private void Boton_cancelar_jobs_Click(object sender, EventArgs e)
        {
            textBox_IDjobs.Clear();
            textBox_trabajoDireccion.Clear();
            textBox_minimo.Clear();
            textBox_maximo.Clear();
         
        }
    }
}
