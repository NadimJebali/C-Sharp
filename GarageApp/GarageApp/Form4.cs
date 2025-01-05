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
    public partial class Form4 : Form
    {
        public event Action VehiculeAdded;
        public Form4(Object v)
        {
            Vehicule vehicule = v as Vehicule;
            InitializeComponent();
            setData(vehicule);
        }

        private void setData(Vehicule vehicule)
        {
            textBox1.Text = vehicule.Year;
            textBox2.Text = vehicule.Registration;
            textBox3.Text = vehicule.Color;
            textBox4.Text = vehicule.Brand;
            textBox5.Text = vehicule.Type;
            textBox2.Enabled = false;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Vehicule new_vehicule = new Vehicule();
            new_vehicule.Year = textBox1.Text;
            new_vehicule.Registration = textBox2.Text;
            new_vehicule.Color = textBox3.Text;
            new_vehicule.Brand = textBox4.Text;
            new_vehicule.Type = textBox5.Text;
            SqliteDataAccess.ModifieVehicule(new_vehicule);
            MessageBox.Show($"{new_vehicule.Registration} has been updated");
            VehiculeAdded?.Invoke();
            this.Close();
        }
    }
}
