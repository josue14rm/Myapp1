using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Myapp1
{
    public partial class Form2 : Form
    {

        public string actualizarNombre { get; set; }
        public string actualizarCorreo { get; set; } 
        public Form2(string nombre, string correo)
        {
            InitializeComponent();
            textNombre.Text = nombre;
            textCorreo.Text = correo;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            actualizarNombre = textNombre.Text;
            actualizarCorreo = textCorreo.Text;
            this.DialogResult = DialogResult.OK;
            this.Close();

        }
    }
}
