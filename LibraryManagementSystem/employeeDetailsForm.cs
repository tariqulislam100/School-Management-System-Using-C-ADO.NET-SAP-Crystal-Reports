using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryManagementSystem
{
    public partial class employeeDetailsForm : Form
    {
        int inEmpID = 0;
        bool isDefaultImage = true;
        string strConnectionString = @"Data Source=DESKTOP-FGQ7142; Initial Catalog=collegems; Integrated Security=True;", strPreviousImage = "";
        public employeeDetailsForm()
        {
            InitializeComponent();
        }

        private void employeeDetailsForm_Load(object sender, EventArgs e)
        {
            PositioncomboBoxFill();
            FillEmployeeDataGridView();
            Clear();
        }
        void PositioncomboBoxFill()
        {
            using (SqlConnection sqlCon = new SqlConnection(strConnectionString))
            {
                sqlCon.Open();
                SqlDataAdapter sqlDa = new SqlDataAdapter("Select * From Position", sqlCon);
                DataTable dtbl = new DataTable();
                sqlDa.Fill(dtbl);
                DataRow topItem = dtbl.NewRow();
                topItem[0] = 0;
                topItem[1] = "-Select-";
                dtbl.Rows.InsertAt(topItem, 0);
                cmbPosition.ValueMember = dgbcmbPosition.ValueMember = "PositionID";
                cmbPosition.DisplayMember = dgbcmbPosition.DisplayMember = "Position";
                cmbPosition.DataSource = dtbl;
                dgbcmbPosition.DataSource = dtbl.Copy();
            }
        }

        private void exitSystemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure? This will delete unsaved data!", "Confirmation dialog!", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                Application.Exit();
            }
        }


        void Clear()
        {
            txtEmpCode.Text = txtEmpName.Text = "";
            cmbPosition.SelectedIndex = cmbGender.SelectedIndex = 0;
            dtpDOB.Value = DateTime.Now;
            rdbFullTime.Checked = true;
            if (dgvEmpIns.DataSource == null)
                dgvEmpIns.Rows.Clear();
            else
                dgvEmpIns.DataSource = (dgvEmpIns.DataSource as DataTable).Clone();
            inEmpID = 0;
            btnSave.Text = "Save";
            btnDelete.Enabled = false;
            pbxPhoto.Image = Image.FromFile(Application.StartupPath + "\\Images\\Male Avatar.gif");
            bool isDefaultImage = true;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            pbxPhoto.Image = new Bitmap(Application.StartupPath + "\\Images\\Male Avatar.gif");
            isDefaultImage = true;
            strPreviousImage = "";
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (ValidateCollegeDBForm())
            {
                int _EmpID = 0;
                using (SqlConnection sqlCon = new SqlConnection(strConnectionString))
                {
                    sqlCon.Open();
                    SqlCommand sqlCmd = new SqlCommand("EmployeeAddOrEdit", sqlCon);
                    sqlCmd.CommandType = CommandType.StoredProcedure;
                    sqlCmd.Parameters.AddWithValue("@EmpID", inEmpID);
                    sqlCmd.Parameters.AddWithValue("@EmpCode", txtEmpCode.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@EmpName", txtEmpName.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@PositionID", Convert.ToInt32(cmbPosition.SelectedValue));
                    sqlCmd.Parameters.AddWithValue("@DOB", dtpDOB.Value);
                    sqlCmd.Parameters.AddWithValue("@Gender", cmbGender.Text);
                    sqlCmd.Parameters.AddWithValue("@State", rdbFullTime.Checked ? "FullTime" : "PartTime");
                    if (isDefaultImage)
                        sqlCmd.Parameters.AddWithValue("@ImagePath", DBNull.Value);
                    else if (inEmpID > 0 && strPreviousImage != "")
                        sqlCmd.Parameters.AddWithValue("@ImagePath", strPreviousImage);
                    else
                        sqlCmd.Parameters.AddWithValue("@ImagePath", SaveImage(ofd.FileName));
                    _EmpID = Convert.ToInt32(sqlCmd.ExecuteScalar());
                }
                using (SqlConnection sqlCon = new SqlConnection(strConnectionString))
                {
                    sqlCon.Open();
                    foreach (DataGridViewRow dgvRow in dgvEmpIns.Rows)
                    {
                        if (dgvRow.IsNewRow) break;
                        else
                        {
                            SqlCommand sqlCmd = new SqlCommand("EmpInstitutionAddOrEdit", sqlCon);
                            sqlCmd.CommandType = CommandType.StoredProcedure;
                            sqlCmd.Parameters.AddWithValue("@EmpInsID", Convert.ToInt32(dgvRow.Cells["dgbtxtEmpInsID"].Value == DBNull.Value ? "0" : dgvRow.Cells["dgbtxtEmpInsID"].Value));
                            sqlCmd.Parameters.AddWithValue("@EmpID", _EmpID);
                            sqlCmd.Parameters.AddWithValue("@Institution", dgvRow.Cells["dgbtxtInsName"].Value == DBNull.Value ? "" : dgvRow.Cells["dgbtxtInsName"].Value);
                            sqlCmd.Parameters.AddWithValue("@PositionID", Convert.ToInt32(dgvRow.Cells["dgbcmbPosition"].Value == DBNull.Value ? "0" : dgvRow.Cells["dgbcmbPosition"].Value));
                            sqlCmd.Parameters.AddWithValue("@ExpYear", Convert.ToInt32(dgvRow.Cells["dgbtxtYear"].Value == DBNull.Value ? "0" : dgvRow.Cells["dgbtxtYear"].Value));
                            sqlCmd.ExecuteNonQuery();
                        }
                    }
                }
                FillEmployeeDataGridView();
                Clear();
                MessageBox.Show("Submitted Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        bool ValidateCollegeDBForm()
        {
            bool _isValid = true;
            if (txtEmpName.Text.Trim() == "")
            {
                MessageBox.Show("Employee Name is required");
                _isValid = false;
            }
            return _isValid;
        }
        string SaveImage(string _imagePath)
        {
            string _fileName = Path.GetFileNameWithoutExtension(_imagePath);
            string _extension = Path.GetExtension(_imagePath);
            _fileName = _fileName.Length <= 15 ? _fileName : _fileName.Substring(0, 15);
            _fileName = _fileName + DateTime.Now.ToString("yymmssfff") + _extension;
            pbxPhoto.Image.Save(Application.StartupPath + "\\Images\\" + _fileName);
            return _fileName;
        }
        void FillEmployeeDataGridView()
        {
            using (SqlConnection sqlCon = new SqlConnection(strConnectionString))
            {
                sqlCon.Open();
                SqlDataAdapter sqlDa = new SqlDataAdapter("EmployeeViewAll", sqlCon);
                sqlDa.SelectCommand.CommandType = CommandType.StoredProcedure;
                DataTable dtbl = new DataTable();
                sqlDa.Fill(dtbl);
                dgvEmployee.DataSource = dtbl;
                dgvEmployee.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dgvEmployee.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                dgvEmployee.Columns[0].Visible = false;
            }
        }

        private void dgvEmployee_DoubleClick(object sender, EventArgs e)
        {
            if (dgvEmployee.CurrentRow.Index != -1)
            {
                DataGridViewRow _dgvCurrentRow = dgvEmployee.CurrentRow;
                inEmpID = Convert.ToInt32(_dgvCurrentRow.Cells[0].Value);
                using (SqlConnection sqlCon = new SqlConnection(strConnectionString))
                {
                    sqlCon.Open();
                    SqlDataAdapter sqlDa = new SqlDataAdapter("EmployeeViewByID", sqlCon);
                    sqlDa.SelectCommand.CommandType = CommandType.StoredProcedure;
                    sqlDa.SelectCommand.Parameters.AddWithValue("@EmpID", inEmpID);
                    DataSet ds = new DataSet();
                    sqlDa.Fill(ds);
                    DataRow dr = ds.Tables[0].Rows[0];
                    txtEmpCode.Text = dr["EmpCode"].ToString();
                    txtEmpName.Text = dr["EmpName"].ToString();
                    cmbPosition.SelectedValue = Convert.ToInt32(dr["PositionID"].ToString());
                    dtpDOB.Value = Convert.ToDateTime(dr["DOB"].ToString());
                    cmbGender.Text = dr["Gender"].ToString();
                    if (dr["State"].ToString() == "Full Time")
                        rdbFullTime.Checked = true;
                    else
                        rdbPartTime.Checked = true;
                    if (dr["ImagePath"] == DBNull.Value)
                    {
                        pbxPhoto.Image = new Bitmap(Application.StartupPath + "\\Images\\Male Avatar.gif");
                        isDefaultImage = true;
                    }
                    else
                    {
                        pbxPhoto.Image = new Bitmap(Application.StartupPath + "\\Images\\" + dr["ImagePath"].ToString());
                        isDefaultImage = false;
                    }
                    dgvEmpIns.AutoGenerateColumns = false;
                    dgvEmpIns.DataSource = ds.Tables[1];
                    btnDelete.Enabled = true;
                    btnSave.Text = "Update";
                    tabControl1.SelectedIndex = 0;
                }
            }
        }

        private void dgvEmpIns_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            DataGridViewRow dgvRow = dgvEmpIns.CurrentRow;
            if (dgvRow.Cells["dgbtxtEmpInsID"].Value != DBNull.Value)
            {
                if (MessageBox.Show("Are you sure to delete this record?", "Warning", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    using (SqlConnection sqlCon = new SqlConnection(strConnectionString))
                    {
                        sqlCon.Open();
                        SqlCommand sqlCmd = new SqlCommand("EmpInstitutionDelete", sqlCon);
                        sqlCmd.CommandType = CommandType.StoredProcedure;
                        sqlCmd.Parameters.AddWithValue("@EmpInsID", Convert.ToInt32(dgvRow.Cells["dgbtxtEmpInsID"].Value));
                        sqlCmd.ExecuteNonQuery();
                    }
                }
                else
                {
                    e.Cancel = true;
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure to delete this record?", "Warning", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                using (SqlConnection sqlCon = new SqlConnection(strConnectionString))
                {
                    sqlCon.Open();
                    SqlCommand sqlCmd = new SqlCommand("EmployeeDelete", sqlCon);
                    sqlCmd.CommandType = CommandType.StoredProcedure;
                    sqlCmd.Parameters.AddWithValue("@EmpID", inEmpID);
                    sqlCmd.ExecuteNonQuery();
                    Clear();
                    FillEmployeeDataGridView();
                    MessageBox.Show("Deleted Successfully!");
                }
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            ofd.Filter = "Images(.jpg,.jpeg,.png,.bmp,.webp,.svg,.avif,.apng,.gif)|*.gif;*.apng;*.avif;*.svg;*.webp;*.bmp;*.png;*.jpeg;*.jpg";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                pbxPhoto.Image = new Bitmap(ofd.FileName);
                isDefaultImage = false;
                strPreviousImage = "";
            }
        }
    }
}
