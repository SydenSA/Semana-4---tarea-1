﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using _06Publicaciones.Views.Empleados;
using _06Publicaciones.Views.Autores;


namespace _06Publicaciones.Views
{
    public partial class General : Form
    {
        public General()
        {
            InitializeComponent();
        }

        private void empleadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_empleados _Empleados = new frm_empleados();
            _Empleados.ShowDialog();
        }

        private void autoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_Autores _Autores = new frm_Autores();
            _Autores.ShowDialog();

        }

        private void trabajosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void employeeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_Employee _Employee = new frm_Employee();
            _Employee.ShowDialog();
        }

        private void jobsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_Jobs _Jobs= new frm_Jobs();
            _Jobs.ShowDialog();
        }
    }
}
