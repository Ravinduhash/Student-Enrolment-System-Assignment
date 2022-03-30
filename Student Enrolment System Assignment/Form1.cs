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

namespace Student_Enrolment_System_Assignment
{
    public partial class Login : Form
    {
        private Form2 fm;

        public Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            if (username.Text == "admin" && password.Text == "1234")
            {
                fm = new Form2();
                fm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid username or password");
                username.Clear();
                password.Clear(); 
                return;
                
                

            }
            
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {

            String dbConnctionString = "Data Source=MSI\\SQLEXPRESS;Initial Catalog=DbTester;Persist Security Info=True;User ID=ravindu;Password=Asd@12345";
            SqlConnection connnn = new SqlConnection(dbConnctionString);
            //   SqlConnection con = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=C:\USERS\RHATU\DOCUMENTS\STUDENTDB.MDF;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");

            connnn.Open();
            SqlCommand cmd = new SqlCommand("insert into Customer values (2,'Gayan')", connnn);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Student successfully added to the system");
            connnn.Close();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
