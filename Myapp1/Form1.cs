using System.Reflection;

namespace Myapp1
{
    public partial class Form1 : Form
    {
        int contador = 0, minutos = 0;
        bool bandera = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void TimeReloj_Tick(object sender, EventArgs e)
        {
            contador++;
            DateTime tiempo = DateTime.Now;
            lbReloj.Text = DateTime.Now.ToString("HH:mm:ss");
            lbFecha.Text = tiempo.ToString("dd-MM-yyyy");
            if (contador == 60)
            {
                minutos++;
                contador = 0;
            }
            lbEjecucion.Text = "Tiempo de ejcucion" + minutos.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (bandera == false)
            {
                bandera = true;
                lbReloj.Enabled = true;
                btnEncender.Text = "Apagar";

            }
            else
            {
                bandera = false;
                lbReloj.Enabled = false;
                btnEncender.Text = "Encender";
            }
        }
    }
}
