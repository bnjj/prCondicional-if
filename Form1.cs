namespace prCondicional_if
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {


            
            // Entrada de datos
            double horasT, horasE, pagoHoraE, pagoHoraT, numHijos,Total;
            horasT = Convert.ToDouble(txtHorasT.Text);
            horasE = Convert.ToDouble(txtHorasE.Text);
            pagoHoraE = Convert.ToDouble(txtPagoHoraE.Text);
            pagoHoraT = Convert.ToDouble(txtPagoHoraT.Text);
            numHijos = Convert.ToDouble(CnumHijos.Value);

            // Proceso
            Total= (horasT * pagoHoraT) + (horasE* pagoHoraE);

            if(solicitud.Checked == true)
            {
                Total = Total + (numHijos * 20);
            }

            txtTotal.Text=Total.ToString();


        }

        private void txtNumHijos_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            txtHorasE.Clear();
            txtHorasT.Clear();
            txtPagoHoraE.Clear();
            txtPagoHoraT.Clear();
            txtTotal.Clear();

        }
    }
}