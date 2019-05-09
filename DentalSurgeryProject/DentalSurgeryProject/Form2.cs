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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        public string Connection_String = "Data Source=DESKTOP-79O75BR\\SQLEXPRESS;Initial Catalog=DBDentist;Integrated Security=True";


        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            SqlConnection Connection = new SqlConnection(Connection_String);
            Connection.Open();
            if (Connection.State == ConnectionState.Open)
            {
                string UniqueQuery = "SELECT * FROM Appointment";
                SqlCommand command = new SqlCommand(UniqueQuery, Connection);
                var reader = command.ExecuteReader();

                bool check = true;
                while(reader.Read())
                {
                    //Checking Uniqueness of Appointment
                    if ((reader[2].ToString() == txtPname.Text && reader[3].ToString() == txtPaddress.Text && reader[4].ToString() == txtPmail.Text && reader[13].ToString() == txtDname.Text) || (reader[10].ToString() == dtpDate.ToString()))
                    {
                        check = false;
                    }
                }
                reader.Close();
                if(check == true)
                {
                    String Add_Query = "INSERT INTO dbo.Appointment(PatientDetails,PatientName,PatientAddress,PatientTelephoneNumber,PatientEmailAddress,PatientType,ApointmentDetails,AppointmentType,OtherDetails,AppointmentDate,AppointmentStartTime,AppointmentEndTime,DentistName) VALUES('"+txtPDetails.Text+"','"+txtPname.Text+ "','"+txtPaddress.Text+ "','"+txtPtelephone.Text+ "','"+txtPmail.Text+ "','"+cmbPtype.Text+ "','"+txtAdetails.Text+ "','"+cmbAtype.Text+ "','"+txtOtherDetails.Text+ "','"+dtpDate.Text+ "','"+txtstarttime.Text+ "','"+txtendtime.Text+ "','"+txtDname.Text+"')";                                       
                    SqlCommand cmd = new SqlCommand(Add_Query, Connection);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Appointment has been added!");
                    this.Hide();
                    Form1 frm = new Form1();
                    frm.Show();
                }
                else
                {
                    MessageBox.Show("No Double Appointments");
                }



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
