﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;

namespace ProyectoDiseñoSoft
{
    public partial class CuentaAdministrador : Form
    {
        public CuentaAdministrador()
        {
            InitializeComponent();
        }

        private void linkAtras_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //Para retoceder a Inicio Sesion
            InicioSesion inicioSesion = new InicioSesion();
            inicioSesion.Show();
            this.Close(); 
        }
    }
}
