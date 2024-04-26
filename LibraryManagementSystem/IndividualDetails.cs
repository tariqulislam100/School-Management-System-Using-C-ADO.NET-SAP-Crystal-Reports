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
    public partial class IndividualDetails : Form
    {
        public IndividualDetails()
        {
            InitializeComponent();
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
           
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "data source=DESKTOP-FGQ7142; database=collegems; integrated security=True";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "Select * From NewAdmission Where NAID =" + txtRegId.Text + "";
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            if (ds.Tables[0].Rows.Count != 0)
            {
                labelFullName.Text = ds.Tables[0].Rows[0][1].ToString();
                labelFatherName.Text = ds.Tables[0].Rows[0][2].ToString();
                labelGender.Text = ds.Tables[0].Rows[0][3].ToString();
                labelDOB.Text = ds.Tables[0].Rows[0][4].ToString();
                labelMobile.Text = ds.Tables[0].Rows[0][5].ToString();
                labelEmail.Text = ds.Tables[0].Rows[0][6].ToString();
                labelStandard.Text = ds.Tables[0].Rows[0][7].ToString();
                labelMedium.Text = ds.Tables[0].Rows[0][8].ToString();
                labelSchoolName.Text = ds.Tables[0].Rows[0][9].ToString();
                labelYear.Text = ds.Tables[0].Rows[0][10].ToString();
                labelAddress.Text = ds.Tables[0].Rows[0][11].ToString();
            }
            else
            {
                MessageBox.Show("No Record Found!","No Match",MessageBoxButtons.OK,MessageBoxIcon.Error);
                labelFullName.Text = "______";
                labelFatherName.Text = "______";
                labelGender.Text = "______";
                labelDOB.Text = "______";
                labelMobile.Text = "______";
                labelEmail.Text = "______";
                labelStandard.Text = "______";
                labelMedium.Text = "______";
                labelSchoolName.Text = "______";
                labelYear.Text = "______";
                labelAddress.Text = "______";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            labelFullName.Text = "______";
            labelFatherName.Text = "______";
            labelGender.Text = "______";
            labelDOB.Text = "______";
            labelMobile.Text = "______";
            labelEmail.Text = "______";
            labelStandard.Text = "______";
            labelMedium.Text = "______";
            labelSchoolName.Text = "______";
            labelYear.Text = "______";
            labelAddress.Text = "______";
            txtRegId.Text = "";
        }
    }
}
