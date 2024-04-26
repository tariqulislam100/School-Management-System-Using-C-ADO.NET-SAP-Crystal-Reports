using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryManagementSystem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            menuStrip1.Visible = false;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string Username = txtUsername.Text;
            string Password = txtPassword.Text;
            if (Username=="student" && Password == "student")
            {
                menuStrip1.Visible = true;
                panel1.Visible = false;
            }
            else
            {
                MessageBox.Show("Invalid UserId or Password","Error",MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void newAdmissionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            New_Admission na = new New_Admission();
            na.Show();
            na.MdiParent = this;
        }

        private void upgradeSemesterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Upgrade_Semester us = new Upgrade_Semester();
            us.Show();
            us.MdiParent = this;
        }

        private void feesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Fees fe = new Fees();
            fe.Show();
            fe.MdiParent = this;
        }

        private void searchStudentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SearchStudent ss = new SearchStudent();
            ss.Show();
            ss.MdiParent = this;
        }

        private void individualDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            IndividualDetails ID = new IndividualDetails();
            ID.Show();
            ID.MdiParent = this;
        }



        private void removeStudentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RemoveStudents rs = new RemoveStudents();
            rs.Show();
            rs.MdiParent = this;
        }

        private void aboutUsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            aboutUs au = new aboutUs();
            au.Show();
            au.MdiParent = this;
        }

        private void exitSystemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Are you sure? This will delete unsaved data!","Confirmation dialog!",MessageBoxButtons.OKCancel,MessageBoxIcon.Warning) == DialogResult.OK)
            {
                Application.Exit();
            }
        }

        private void employeeDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            employeeDetailsForm es = new employeeDetailsForm();
            es.Show();
            es.MdiParent = this;
        }

        private void employeeReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EmployeeReportRpt es = new EmployeeReportRpt();
            es.Show();
            es.MdiParent = this;
        }

        private void sPReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StoreProcedureReport sp = new StoreProcedureReport();
            sp.Show();
            sp.MdiParent = this;
        }
    }
}
