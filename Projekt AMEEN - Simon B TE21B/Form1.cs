namespace Projekt_AMEEN___Simon_B_TE21B
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            listBox1.Items.Add(3);
            listBox1.Items.Add(9);

            listBox1.SelectedItem = listBox1.Items[0];
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string högstaTal = listBox1.SelectedItem.ToString();
            int störstaTal = int.Parse(högstaTal);
            Random slump = new Random();

            int DatorTal = slump.Next(1, störstaTal + 1);
            int användarTal = int.Parse(textBox1.Text);

            if (användarTal == DatorTal)
            {
                label6.Text = "Du vann! Du valde samma som datorn!";
                label3.Text = "Datorn valde talet: " + DatorTal;
            }

            else if (användarTal < DatorTal)
            {
                label6.Text = "Du förlorade! Du valde lägre tal än datorn.";
                label3.Text = "Datorn valde talet: " + DatorTal;
            }

            else
            {
                label6.Text = " Du förlorade! Du valde högre tal än datorn";
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
