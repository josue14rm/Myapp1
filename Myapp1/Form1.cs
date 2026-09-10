using System.Runtime.Intrinsics.Arm;
using static System.Net.Mime.MediaTypeNames;

namespace Myapp1
{
    public partial class Form1 : Form
    {
        bool save = false;
        bool cambios = false;

        int contador = 0;
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

        private void statusStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
        }

        private void timerReloj_Tick(object sender, EventArgs e)
        {
            if (save == true)
            {
                
                contador++;
                if (contador == 10)
                {
                    if (path != null)
                    {
                        Texto.SaveFile(path, RichTextBoxStreamType.PlainText);

                        toolStripStatusLabel2.Visible = true;
                    }
                    contador = 0;

                }
                 
            }
        }

        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {

        }

        private void archivoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void toolStripStatusLabel2_Click(object sender, EventArgs e)
        {

        }
    }
}
