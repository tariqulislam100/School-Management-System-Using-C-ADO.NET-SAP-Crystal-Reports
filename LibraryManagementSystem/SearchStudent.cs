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

namespace LibraryManagementSystem
{
    public partial class SearchStudent : Form
    {
        public SearchStudent()
        {
            InitializeComponent();
        }

        private void SearchStudent_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "data source=DESKTOP-FGQ7142; database=collegems; integrated security=True";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "Select NewAdmission.NAID as Student_ID, NewAdmission.FullName as Full_Name,NewAdmission.FatherName as Father_Name,NewAdmission.Gender,NewAdmission.DOB as Date_Of_Birth,NewAdmission.Mobile as Mobile,NewAdmission.Email as Email_ID,NewAdmission.Semester,NewAdmission.Prog as Programming_Language,NewAdmission.SchoolName,NewAdmission.Duration as Course_Duration,NewAdmission.Address,fees.fees as Fees from NewAdmission inner join fees on NewAdmission.NAID=fees.NAID";
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "data source=DESKTOP-8AT38FC; database=collegems; integrated security=True";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "Select * From NewAdmission Where NAID = "+txtRegistrationSearch.Text+"";
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
        }
    }
}
