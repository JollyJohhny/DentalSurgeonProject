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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        public string Connection_String = "Data Source=DESKTOP-79O75BR\\SQLEXPRESS;Initial Catalog=DBDentist;Integrated Security=True";


        private void Form4_Load(object sender, EventArgs e)
        {

        }

        private void btnFilter_Click(object sender, EventArgs e)
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

        private void btnShowAll_Click(object sender, EventArgs e)
        {
            SqlConnection Connection = new SqlConnection(Connection_String);
            Connection.Open();
            if (Connection.State == ConnectionState.Open)
            {
                string View_Query = "SELECT * FROM dbo.Appointment";
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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            SqlConnection Connection = new SqlConnection(Connection_String);

            Connection.Open();
            if (e.ColumnIndex == dataGridView1.Columns["Cancel"].Index)
            {
                var confirmResult = MessageBox.Show("Are you sure to Cancel/Delete this Appointment??",
                                     "Confirm InActivation!!",
                                     MessageBoxButtons.YesNo);

                if (confirmResult == DialogResult.Yes)
                {
                    int row = e.RowIndex;
                    int id = Convert.ToInt32(dataGridView1.Rows[row].Cells["Id"].Value);


                    string InActive_Query = "DELETE FROM dbo.Appointment WHERE Id = '" + id + "'";
                    SqlCommand cmd = new SqlCommand(InActive_Query, Connection);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Appointment has Been Canceled!");
                    this.dataGridView1.Rows.RemoveAt(e.RowIndex);
                }
                else
                {

                }


            }
            
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

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form5 frm = new Form5();
            frm.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form4 frm = new Form4();
            frm.Show();
        }
    }
}
