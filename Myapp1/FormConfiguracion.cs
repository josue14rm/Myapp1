using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Myapp1
{
    public partial class FormConfiguracion : Form
    {
        public DateTime Hora { get; set; };

        public FormConfiguracion()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Hora = DTPConfigura.Value;
            this.DialogResult = DialogResult.OK;
            this.Close();

            
        }
    }
}
