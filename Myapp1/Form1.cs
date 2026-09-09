using System.Runtime.Intrinsics.Arm;
using static System.Net.Mime.MediaTypeNames;

namespace Myapp1
{
    public partial class Form1 : Form
    {
        bool save = false;
        bool cambios = false;

        int contador = 0, minutos = 0;
        String path;

        public Form1()
        {
            InitializeComponent();
        }

        private void abrirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Abrir.ShowDialog() == DialogResult.OK)
            {
                path = Abrir.FileName;
                save = true;
                Texto.LoadFile(Abrir.FileName, RichTextBoxStreamType.PlainText);
                guardarToolStripMenuItem.Enabled = true;
            }
        }

        private void nuevoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Texto.Clear();
            Texto.Focus();

            save = false;
        }

        private void guardarComoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Guardar.ShowDialog() == DialogResult.OK)
            {
                path = Guardar.FileName;
                Texto.SaveFile(path, RichTextBoxStreamType.PlainText);
                guardarToolStripMenuItem.Enabled = true;
                save = true;
            }
        }

        private void guardarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (save == false)
            {
                if (Guardar.ShowDialog() == DialogResult.OK)
                {
                    path = Guardar.FileName;
                    save = true;
                }
                Texto.SaveFile(path, RichTextBoxStreamType.PlainText);
                guardarToolStripMenuItem.Enabled = false;

                contador++;
                DateTime tiempo = DateTime.Now;
                lbReloj.Text = DateTime.Now.ToString("HH:mm:ss");
                lbFecha.Text = tiempo.ToString("dd-MM-yyyy");
                if (contador == 30)
                {
                    contador = 0;
                    path = Guardar.FileName;
                    save = true;
                }
            }
                

            }
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Texto_TextChanged(object sender, EventArgs e)
        {
            cambios = true;
        }
    }
}
