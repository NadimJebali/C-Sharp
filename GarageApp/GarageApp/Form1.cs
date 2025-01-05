namespace GarageApp
{
    public partial class Form1 : Form
    {
        List<Vehicule> vehicules = new List<Vehicule>();
        public Form1()
        {
            InitializeComponent();
            form1_loadList();
        }

        private void form1_loadList()
        {
            vehicules = SqliteDataAccess.LoadVehicules();
            listBox1.Items.Clear();
            foreach (var vehicule in vehicules)
            {
                listBox1.Items.Add(vehicule);
            }
        }

        private void form2_VehiculeAdded()
        {
            form1_loadList();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged_1(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            foreach (var vehicule in vehicules)
            {
                if (vehicule.Type == "car")
                {
                    listBox1.Items.Add(vehicule);
                }
            }
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.VehiculeAdded += form2_VehiculeAdded;
            form2.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem != null)
            {
                Form3 form3 = new Form3(vehicules[listBox1.SelectedIndex]);
                form3.Show();
            }
            else
            {
                MessageBox.Show("Please select an item to view details.");
            }

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem != null)
            {
                label4.Text = vehicules[listBox1.SelectedIndex].Registration;
                label5.Text = vehicules[listBox1.SelectedIndex].Year;
                label6.Text = vehicules[listBox1.SelectedIndex].Type;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem != null)
            {
                SqliteDataAccess.DeleteVehicule(vehicules[listBox1.SelectedIndex]);
                form1_loadList();
            }

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            foreach (var vehicule in vehicules)
            {
                if (vehicule.Type == "bike")
                {
                    listBox1.Items.Add(vehicule);
                }
            }
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            form1_loadList();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem != null)
            {
                Form4 form4 = new Form4(vehicules[listBox1.SelectedIndex]);
                form4.VehiculeAdded += form2_VehiculeAdded;
                form4.Show();
            }
            else
            {
                MessageBox.Show("Please select an item Update.");
            }
        }
    }
}
