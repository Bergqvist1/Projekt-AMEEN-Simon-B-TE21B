namespace Projekt_AMEEN___Simon_B_TE21B
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            listBox1.Items.Add(10);
            listBox1.Items.Add(20);

            listBox1.SelectedItem = listBox1.Items[0];
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string h�gstaTal = listBox1.SelectedItem.ToString();
            int st�rstaTal = int.Parse(h�gstaTal);
            Random slump = new Random();

            int DatorTal = slump.Next(1, st�rstaTal + 1);
            int anv�ndarTal = int.Parse(textBox1.Text);

            if (anv�ndarTal == DatorTal)
            {
                label6.Text = "Du vann! Du valde samma som datorn!";
                label3.Text = "Datorn valde talet: " + DatorTal;
            }

            else if (anv�ndarTal < DatorTal)
            {
                label6.Text = "Du f�rlorade! Du valde l�gre tal �n datorn.";
                label3.Text = "Datorn valde talet: " + DatorTal;
            }

            else
            {
                label6.Text = " Du f�rlorade! Du valde h�gre tal �n datorn";
                label3.Text = "Datorn valde talet: " + DatorTal;
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}