namespace BdRecordCompany
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void mensajeGeneral(int r)
        {
            if (r > 0)
            {
                MessageBox.Show("Persona registrada", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                MessageBox.Show("Persona no registrada", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
        private void btnProductorGuardarR_Click(object sender, EventArgs e)
        {
            int empresaId, r = 0;
            string empresaNombre, empresaTipo;
            empresaId = int.Parse(txtEmpresaId.Text);
            empresaNombre = txtEmpresaNombre.Text;

            if (rbEmpresaSubsidiaria.Checked)
            {
                empresaTipo = "Subsidiaria";
            }
            else if (rbEmpresaCasaMatriz.Checked)
            {
                empresaTipo = "Casa Matriz";
            }
            // Colocar la parte de la logica de la clase registro
            mensajeGeneral(r);
        }


        private void btnEmpresaGuardar_Click(object sender, EventArgs e)
        {
            int productorId, r = 0;
            string productorNombre, productorAnios, productorClasificacion;
            productorNombre = txtProductorNombre.Text;
            productorId = int.Parse(txtProductorTarjeta.Text);
            productorAnios = cbxProductorAniosExp.SelectedItem.ToString();
            productorClasificacion = cbxProductorClasificacion.SelectedItem.ToString();
            // Colocar la parte de la logica de la clase Productor
            mensajeGeneral(r);
        }

        

        private void btnVincualacionGuardar_Click(object sender, EventArgs e)
        {
            int r = 0;
            // Colocar la parte de la logica de la clase Productor
            mensajeGeneral(r);
        }
    }
}
