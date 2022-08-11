namespace ControlMultasTran
{
    public partial class FrmMultas : Form
    {
        public FrmMultas()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lblFecha.Text = DateTime.Today.Date.ToString();
            lblHora.Text = DateTime.Now.ToShortTimeString();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void btnregistrar_Click(object sender, EventArgs e)
        {
            //Calculando datos

            String placa = txtPlaca.Text;
            double velocidad= double.Parse(txtVelocidad.Text);
            DateTime fecha = DateTime .Parse(lblFecha.Text);
            DateTime hora = DateTime .Parse(lblHora.Text);

            //procesando

            double multa = 0;
            if (velocidad <= 70)
                multa = 0;
            else if (velocidad > 70 && velocidad <= 90)
                multa = 120;
            else if (velocidad > 90 && velocidad <= 100)
                multa = 240;
            else if (velocidad > 100)
                multa = 350;

            //imprimiendo datos

            ListViewItem fila = new ListViewItem(placa);
            fila.SubItems.Add(lblFecha.Text);
            fila.SubItems.Add(lblHora.Text);
            fila.SubItems.Add(velocidad.ToString("0.00"));
            fila.SubItems.Add(multa.ToString("0.00"));
            fila.SubItems.Add(multa.ToString("C"));
            lvMultas.Items.Add(fila);
        }

        ListViewItem itm;


        private void lvMultas_MouseClick(object sender, MouseEventArgs e)
        {

            itm = lvMultas.GetItemAt(e.X, e.Y);
        }

        private void buttobtnEliminar_Click(object sender, EventArgs e)
        {
            if (itm != null)
            {
                lvMultas.Items.Remove(itm);
                MessageBox.Show("¡Multa eliminada correctamente");

            }
            else
            {
                MessageBox.Show("Debe seleccionar una multa de lista");
            }
        }
    }
}