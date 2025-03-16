namespace PO_WIZ_kalkulator_cen_komputera
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void bKomputer_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
            this.Hide();
        }

        private void bMonitor_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.Show();
            this.Hide();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int suma = Class1.LiczbaZOkna2 + Class1.LiczbaZOkna3;
            textBox1.Text = suma.ToString();
        }
    }
}
