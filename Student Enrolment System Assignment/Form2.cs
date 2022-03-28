﻿using System;
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
    public partial class Form2 : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=C:\USERS\RHATU\DOCUMENTS\STUDENTDB.MDF;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        string gender;
        //var today = DateTime.Today;
        //var age = today.Year - DateTimePicker.Year;
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text=="" || textBox2.Text=="" || textBox3.Text=="" || textBox4.Text=="" || dateTimePicker1.Text=="" || comboBox1.Text=="")
            {
                MessageBox.Show("Enter valid inputs");
                return;

            }
            else if ((radioButton1.Checked == true && radioButton2.Checked ==true) || (radioButton1.Checked == false && radioButton2.Checked == false) )
            {
                MessageBox.Show("Enter valid inputs");
                return ;
            }
            else
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("insert into dboTabale values("+textBox1.Text+","+textBox2.Text+","+dateTimePicker1.Value.Date+","+textBox3+","+gender+","+comboBox1.SelectedItem+","+textBox4.Text+"",con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Student successfully added to the system");
                con.Close();
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            DateTime bdate = dateTimePicker1.Value.Date;
            DateTime fdate = DateTime.Now;

            string diff = (bdate - fdate).TotalDays.ToString();
            int totaldays = Convert.ToInt32(diff);
            int year = totaldays / 365;
            int remainingdays = totaldays % 365;
            int month = remainingdays / 30 ;
            //remainingdays = remainingdays % 30 ;
            int day = remainingdays % 30 ;  
            
            string textBox3 = day.ToString() + "/" + month.ToString() + "/" + year.ToString();

            if (year < 18)
            {
                MessageBox.Show("Cannot Enroll – Below 18 years");
                return;
            }

        }
    }
}
