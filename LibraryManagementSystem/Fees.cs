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
    public partial class Fees : Form
    {
        public Fees()
        {
            InitializeComponent();
        }

        private void txtRegistrationNumber_TextChanged(object sender, EventArgs e)
        {
            if (txtRegistrationNumber.Text != "")
            {
                SqlConnection con = new SqlConnection();
                con.ConnectionString = "data source=DESKTOP-FGQ7142; database=collegems; integrated security=True";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = "Select FullName, FatherName,Duration From NewAdmission Where NAID =" + txtRegistrationNumber.Text + "";
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);               
            if (ds.Tables[0].Rows.Count != 0)
                {
                    fullNamelabel.Text = ds.Tables[0].Rows[0][0].ToString();
                    fatherNamelabel.Text = ds.Tables[0].Rows[0][1].ToString();
                    durationlabel.Text = ds.Tables[0].Rows[0][2].ToString();
                }
                else
                {
                    MessageBox.Show("No Record Found!", "No Match", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    fullNamelabel.Text = "------";
                    fatherNamelabel.Text = "------";
                    durationlabel.Text = "------";
                }
            }
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "data source=DESKTOP-8AT38FC; database=collegems; integrated security=True";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "Select * From fees Where NAID="+txtRegistrationNumber.Text+"";
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
       
                if (ds.Tables[0].Rows.Count == 0)
            {
                SqlConnection con1 = new SqlConnection();
                con1.ConnectionString = "data source=DESKTOP-8AT38FC; database=collegems; integrated security=True";
                SqlCommand cmd1 = new SqlCommand();
                cmd1.Connection = con1;
                cmd1.CommandText = "INSERT INTO fees (NAID,fees) VALUES(" + txtRegistrationNumber.Text + "," + txtFees.Text + ")";
                SqlDataAdapter da1 = new SqlDataAdapter(cmd1);
                DataSet ds1 = new DataSet();
                da1.Fill(ds1);

                if (MessageBox.Show("Fees Submition Successful.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Asterisk) == DialogResult.OK)
                {
                    txtRegistrationNumber.Text = "";
                    txtFees.Text = "";
                    fullNamelabel.Text = "------";
                    fatherNamelabel.Text = "------";
                    durationlabel.Text = "------";
                }          
            }
            else
            {
                MessageBox.Show("Fees is already submitted.");
                txtRegistrationNumber.Text = "";
                txtFees.Text = "";
                fullNamelabel.Text = "------";
                fatherNamelabel.Text = "------";
                durationlabel.Text = "------";
            }
        }
    }
}
