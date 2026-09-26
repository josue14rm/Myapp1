namespace Myapp1
{
    using CsvHelper;
    using System.Globalization;

    public partial class Form1 : Form
    {
        List<Persona> Registros = new List <Persona>();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCargar_Click(object sender, EventArgs e)
        {
            if (ofdcsv.ShowDialog() == DialogResult.OK) { 
                var reader = new StreamReader(ofdcsv.FileName);
                var csv = new CsvHelper.CsvReader(reader,CultureInfo.InvariantCulture);
                Registros = csv.GetRecords<Persona>().ToList();
                foreach (var registro in Registros)
                {
                    dgvRegistros.Rows.Add(registro.id, registro.name, registro.email);
                }
            }
        }
    }
}
