namespace Myapp1
{
    public partial class Form1 : Form
    {
        DateTime tiempo;
        public Form1()
        {
            InitializeComponent();
        }

        private void configurarAlarmaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormConfiguracion ventanaAlarma = new FormConfiguracion();
            if (ventanaAlarma.ShowDialog() == DialogResult.OK)
            {
                tiempo = ventanaAlarma.Hora;
                MessageBox.Show(tiempo.ToLongTimeString());
            }
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void timerReloj_Tick(object sender, EventArgs e)
        {

            lb1.Text = DateTime.Now.ToLongTimeString();
            if (DateTime.Now.ToLongTimeString() == tiempo.ToLongTimeString())
            {
                axWindowsMediaPlayer1.URL = @"C:\Users\RMJosue14\Downloads\dragon-studio-rooster-crowing-364473.mp3";
                axWindowsMediaPlayer1.Ctlcontrols.play();
            }
        }

        private void archivoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
