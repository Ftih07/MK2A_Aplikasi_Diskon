namespace Aplikasi_Diskon
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

        private void button1_Click(object sender, EventArgs e)
        {
            int totalBelanja = int.Parse(txttotalbelanja.Text);
            int diskon = int.Parse(txtdiskon.Text);
            int diskonDapet = (int)((double)diskon / 100.0 * (double)totalBelanja);
            int sisaUang = totalBelanja - diskonDapet;
            txtharga.Text = sisaUang.ToString();
        }

        private void txtharga_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            txttotalbelanja.Text = "";
            txtdiskon.Text = "";
            txtharga.Text = "";
        }
    }
}