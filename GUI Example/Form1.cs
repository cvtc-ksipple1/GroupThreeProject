using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace GUI_Example
{
    public partial class GUI_Example : Form
    {
        public GUI_Example()
        {
            InitializeComponent();
        }

        private void Name_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=E:\\Downloads\\Downloads\\School stuff\\Agile Prog with Design Patterns\\Week 4\\GUI Example\\GUI Example\\SampleDatabase.mdf";Integrated Security=True");
            DataTable dt = new DataTable();
            SqlDataAdapter SDA = new SqlDataAdapter("SELECT * FROM SampleDatabase.mdf WHERE ID like " + firstName.Text, conn);
            SDA.Fill(dt);
            dataGridView1.DataSource = dt;
        }
    }
}
