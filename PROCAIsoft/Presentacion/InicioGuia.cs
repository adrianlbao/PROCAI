﻿using Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion
{
    public partial class InicioGuia : Form
    {
        public InicioGuia()
        {
            InitializeComponent();
        }
        public InicioGuia(Usuario u)
        {            
            InitializeComponent();
            lblNombreUsu.Text += u.NombreUsuario;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            frmRegYeditEncuestas R = new frmRegYeditEncuestas(0);
            this.Visible = false;
            R.StartPosition = FormStartPosition.CenterScreen;
            if (R.ShowDialog() == DialogResult.OK)
            {
            }
            this.Visible = true;
        }

        private void InicioGuia_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Dispose();
        }
    }
}
