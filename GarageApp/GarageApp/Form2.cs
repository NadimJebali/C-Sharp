using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GarageApp
{
    public partial class Form2 : Form
    {
        public event Action VehiculeAdded;
        public Form2()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
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
            if (String.IsNullOrWhiteSpace(textBox1.Text) || String.IsNullOrWhiteSpace(textBox2.Text) || String.IsNullOrWhiteSpace(textBox3.Text) || String.IsNullOrWhiteSpace(textBox4.Text) || String.IsNullOrWhiteSpace(textBox5.Text))
            {
                MessageBox.Show("All fields must be filled !");
            }
            else 
            {
                Vehicule vehicule = new Vehicule();
                vehicule.Year = textBox1.Text;
                vehicule.Registration = textBox2.Text;
                vehicule.Color = textBox3.Text;
                vehicule.Brand = textBox4.Text;
                vehicule.Type = textBox5.Text;
                SqliteDataAccess.SaveVehicule(vehicule);
                MessageBox.Show("Vehicule added");
                VehiculeAdded?.Invoke();
                this.Close();
            }
            
        }
    }
}
