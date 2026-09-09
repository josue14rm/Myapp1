namespace Myapp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void BtCalcula_Click(object sender, EventArgs e)
        {
            int a, b = 0;
            a = Int32.Parse(txtNumero1.Text);
            b = Convert.ToInt32(txtNumero2.Text);

            //MessageBox.Show("la suma es: " + (a + b));
            txtResultado.Text = (a + b).ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtNumero1.Clear();
            txtNumero2.Clear();
            txtResultado.Clear();

            txtNumero1.Focus();
        }
    }
}
