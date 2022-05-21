﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion.Mensajes
{
    public partial class Afirmacion : Form
    {
        public Afirmacion(string titulo, string parrafo)
        {
            InitializeComponent();

            lblTitulo.Text = titulo;
            txtParrafo.Text = parrafo;
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Close();
        }
    }
}
