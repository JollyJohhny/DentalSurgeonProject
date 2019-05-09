using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DentalSurgeryProject
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        public string Connection_String = "Data Source=DESKTOP-79O75BR\\SQLEXPRESS;Initial Catalog=DBDentist;Integrated Security=True";


        private void Form3_Load(object sender, EventArgs e)
        {
            
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            SqlConnection Connection = new SqlConnection(Connection_String);
            Connection.Open();
            if (Connection.State == ConnectionState.Open)
            {
                string View_Query = "SELECT * FROM dbo.Appointment WHERE AppointmentDate = '" + dtpDate.Text + "'";
                SqlCommand cmd = new SqlCommand(View_Query, Connection);
                SqlDataAdapter View_Data = new SqlDataAdapter(cmd);
                DataTable Table = new DataTable(cmd.ToString());

                View_Data.Fill(Table);
                dataGridView1.DataSource = Table;
            }
            else
            {
                MessageBox.Show("DataBase Failed!");
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 frm = new Form2();
            frm.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form3 frm = new Form3();
            frm.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form4 frm = new Form4();
            frm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form5 frm = new Form5();
            frm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form6 frm = new Form6();
            frm.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form7 frm = new Form7();
            frm.Show();
        }
    }
}
