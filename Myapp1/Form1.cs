namespace Myapp1
{
    using CsvHelper;
    using System.Globalization;

    public partial class Form1 : Form
    {
        List<Persona> Registros = new List<Persona>();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCargar_Click(object sender, EventArgs e)
        {
            if (ofdcsv.ShowDialog() == DialogResult.OK)
            {
                var reader = new StreamReader(ofdcsv.FileName);
                var csv = new CsvHelper.CsvReader(reader, CultureInfo.InvariantCulture);
                Registros = csv.GetRecords<Persona>().ToList();
                foreach (var registro in Registros)
                {
                    dgvRegistros.Rows.Add(registro.id, registro.name, registro.email);
                }
            }
        }

        private void dgvRegistros_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           Form editar = new Form2(
           dgvRegistros.Rows[e.RowIndex].Cells[1].Value.ToString(),
           dgvRegistros.Rows[e.RowIndex].Cells[2].Value.ToString());

           if (editar.ShowDialog()==DialogResult.OK)
            {
                string nombre = editar.actualizarNombre;
                string correo = editar.actualizarCorreo;
                dgvRegistros.Rows[e.RowIndex].Cells[1].Value = nombre;
                dgvRegistros.Rows[e.RowIndex].Cells[2].Value = correo;
            }
        }
    }
}
