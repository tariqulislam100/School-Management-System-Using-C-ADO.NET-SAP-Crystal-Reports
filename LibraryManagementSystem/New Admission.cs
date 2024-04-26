using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Net;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace LibraryManagementSystem
{
    public partial class New_Admission : Form
    {
        public New_Admission()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            String FullName = txtFullName.Text;
            String FatherName=txtFaName.Text;
            String Gender = "";
            bool isChecked = rbtnMale.Checked;
            if (isChecked)
            {
                Gender = rbtnMale.Text;
            }
            else
            {
                Gender = rbtnFemale.Text;
            }
            String DOB = dateTimePicker1.Text;
            Int64 Mobile = Int64.Parse(txtMobile.Text);
            String Email = txtEmail.Text;
            String Semester = cmbSemester.Text;
            String Prog = cmbProgramming.Text;
            String SchoolName = txtSchoolName.Text;
            String Duration = cmbDuration.Text;
            String Address = rtxtAddress.Text;
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "data source=DESKTOP-FGQ7142; database=collegems; integrated security=True";
            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "INSERT INTO NewAdmission (FullName,FatherName,Gender,DOB,Mobile,Email,Semester,Prog,SchoolName,Duration,Address) VALUES('" + FullName + "','" + FatherName + "','" + Gender + "','" + DOB + "'," + Mobile + ",'" + Email + "','" + Semester + "','" + Prog + "','" + SchoolName + "','" + Duration + "','" + Address + "')";
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            con.Close();
            MessageBox.Show("Data Saved. Remember the Registration ID", "Data", MessageBoxButtons.OK, MessageBoxIcon.Hand);
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtFullName.Clear();
            txtFaName.Clear();
            rbtnMale.Checked=false;
            rbtnFemale.Checked=false;
            dateTimePicker1.ResetText();
            txtMobile.Clear();
            txtEmail.Clear();
            cmbSemester.ResetText();
            cmbProgramming.ResetText();
            txtSchoolName.Clear();
            cmbDuration.ResetText();
            rtxtAddress.Clear();
        }

        private void New_Admission_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "data source=DESKTOP-FGQ7142; database=collegems; integrated security=True";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "SELECT MAX (NAID) FROM NewAdmission";
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            Int64 abc = Convert.ToInt64(ds.Tables[0].Rows[0][0]);
            label13.Text= (abc+1).ToString();
        }       
    }
}
