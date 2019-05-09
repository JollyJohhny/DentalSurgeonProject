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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        public string Connection_String = "Data Source=DESKTOP-79O75BR\\SQLEXPRESS;Initial Catalog=DBDentist;Integrated Security=True";


        
        public List<DateTime> LastSevenDays()
        {

            List<DateTime> daterange = new List<DateTime>();
            for (int i = 0; i < 7; i++)
            {
                DateTime t = DateTime.Now;
                daterange.Add(t.AddDays(i).Date);


            }
            DateTime today = DateTime.Now;
            daterange.Add(today.Date);

            return daterange;
        }

        private void Form6_Load(object sender, EventArgs e)
        {
            SqlConnection Connection = new SqlConnection(Connection_String);
            Connection.Open();
            List<DateTime> lastSevenDays = LastSevenDays();

            if (Connection.State == ConnectionState.Open)
            {
                //Getting seven days date from now
                string d1 = lastSevenDays[0].Year.ToString() + "-" + lastSevenDays[0].Month.ToString() + "-" + lastSevenDays[0].Day.ToString();

                string d2 = lastSevenDays[1].Year.ToString() + "-" + lastSevenDays[1].Month.ToString() + "-" + lastSevenDays[1].Day.ToString();

                string d3 = lastSevenDays[2].Year.ToString() + "-" + lastSevenDays[2].Month.ToString() + "-" + lastSevenDays[2].Day.ToString();
                string d4 = lastSevenDays[3].Year.ToString() + "-" + lastSevenDays[3].Month.ToString() + "-" + lastSevenDays[3].Day.ToString();
                string d5 = lastSevenDays[4].Year.ToString() + "-" + lastSevenDays[4].Month.ToString() + "-" + lastSevenDays[4].Day.ToString();
                string d6 = lastSevenDays[5].Year.ToString() + "-" + lastSevenDays[5].Month.ToString() + "-" + lastSevenDays[5].Day.ToString();
                string d7 = lastSevenDays[6].Year.ToString() + "-" + lastSevenDays[6].Month.ToString() + "-" + lastSevenDays[6].Day.ToString();
                string View_Query = "SELECT * FROM dbo.Appointment WHERE AppointmentDate = '" + d1 + "' OR AppointmentDate = '"+ d2 + "' OR AppointmentDate = '"+d3 + "' OR AppointmentDate = '"+d4+ "' OR AppointmentDate = '"+d5 + "' OR AppointmentDate = '"+d6 + "'";
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
