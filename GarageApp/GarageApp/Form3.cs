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
    public partial class Form3 : Form
    {
        public Form3(Object v)
        {
            Vehicule vehicule = v as Vehicule;
            InitializeComponent();
            createtableView(vehicule);
            label1.Text = vehicule.Registration;

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void createtableView(Vehicule v)
        {
            tableLayoutPanel1.Controls.Clear();
            tableLayoutPanel1.ColumnCount = 5;
            tableLayoutPanel1.Controls.Add(new Label { Text = "Year", Font = new System.Drawing.Font("Arial", 10, System.Drawing.FontStyle.Bold) }, 0, 0);
            tableLayoutPanel1.Controls.Add(new Label { Text = "Registration", Font = new System.Drawing.Font("Arial", 10, System.Drawing.FontStyle.Bold) }, 1, 0);
            tableLayoutPanel1.Controls.Add(new Label { Text = "Color", Font = new System.Drawing.Font("Arial", 10, System.Drawing.FontStyle.Bold) }, 2, 0);
            tableLayoutPanel1.Controls.Add(new Label { Text = "Brand", Font = new System.Drawing.Font("Arial", 10, System.Drawing.FontStyle.Bold) }, 3, 0);
            tableLayoutPanel1.Controls.Add(new Label { Text = "Type", Font = new System.Drawing.Font("Arial", 10, System.Drawing.FontStyle.Bold) }, 4, 0);

            tableLayoutPanel1.Controls.Add(new Label { Text = v.Year }, 0, 1);
            tableLayoutPanel1.Controls.Add(new Label { Text = v.Registration }, 1, 1);
            tableLayoutPanel1.Controls.Add(new Label { Text = v.Color }, 2, 1);
            tableLayoutPanel1.Controls.Add(new Label { Text = v.Brand }, 3, 1);
            tableLayoutPanel1.Controls.Add(new Label { Text = v.Type }, 4, 1);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
