namespace LibraryManagementSystem
{
    partial class employeeDetailsForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(employeeDetailsForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabController = new System.Windows.Forms.TabPage();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.dgvEmpIns = new System.Windows.Forms.DataGridView();
            this.dgbtxtEmpInsID = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dgbtxtInsName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgbcmbPosition = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dgbtxtYear = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.pbxPhoto = new System.Windows.Forms.PictureBox();
            this.rdbFullTime = new System.Windows.Forms.RadioButton();
            this.rdbPartTime = new System.Windows.Forms.RadioButton();
            this.cmbGender = new System.Windows.Forms.ComboBox();
            this.dtpDOB = new System.Windows.Forms.DateTimePicker();
            this.cmbPosition = new System.Windows.Forms.ComboBox();
            this.txtEmpName = new System.Windows.Forms.TextBox();
            this.txtEmpCode = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.employeeTab = new System.Windows.Forms.TabPage();
            this.dgvEmployee = new System.Windows.Forms.DataGridView();
            this.ofd = new System.Windows.Forms.OpenFileDialog();
            this.tabControl1.SuspendLayout();
            this.tabController.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmpIns)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxPhoto)).BeginInit();
            this.employeeTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployee)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabController);
            this.tabControl1.Controls.Add(this.employeeTab);
            this.tabControl1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(34, 4);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(790, 558);
            this.tabControl1.TabIndex = 5;
            // 
            // tabController
            // 
            this.tabController.BackColor = System.Drawing.Color.Thistle;
            this.tabController.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tabController.BackgroundImage")));
            this.tabController.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabController.Controls.Add(this.btnReset);
            this.tabController.Controls.Add(this.btnDelete);
            this.tabController.Controls.Add(this.btnSave);
            this.tabController.Controls.Add(this.dgvEmpIns);
            this.tabController.Controls.Add(this.btnClear);
            this.tabController.Controls.Add(this.btnBrowse);
            this.tabController.Controls.Add(this.pbxPhoto);
            this.tabController.Controls.Add(this.rdbFullTime);
            this.tabController.Controls.Add(this.rdbPartTime);
            this.tabController.Controls.Add(this.cmbGender);
            this.tabController.Controls.Add(this.dtpDOB);
            this.tabController.Controls.Add(this.cmbPosition);
            this.tabController.Controls.Add(this.txtEmpName);
            this.tabController.Controls.Add(this.txtEmpCode);
            this.tabController.Controls.Add(this.label6);
            this.tabController.Controls.Add(this.label5);
            this.tabController.Controls.Add(this.label4);
            this.tabController.Controls.Add(this.label3);
            this.tabController.Controls.Add(this.label2);
            this.tabController.Controls.Add(this.label1);
            this.tabController.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabController.Location = new System.Drawing.Point(4, 32);
            this.tabController.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabController.Name = "tabController";
            this.tabController.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabController.Size = new System.Drawing.Size(782, 522);
            this.tabController.TabIndex = 0;
            this.tabController.Text = "Employee Details";
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.Color.Wheat;
            this.btnReset.ForeColor = System.Drawing.SystemColors.InfoText;
            this.btnReset.Location = new System.Drawing.Point(475, 465);
            this.btnReset.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(105, 37);
            this.btnReset.TabIndex = 9;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Wheat;
            this.btnDelete.ForeColor = System.Drawing.SystemColors.InfoText;
            this.btnDelete.Location = new System.Drawing.Point(335, 465);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(105, 37);
            this.btnDelete.TabIndex = 9;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.Wheat;
            this.btnSave.ForeColor = System.Drawing.SystemColors.InfoText;
            this.btnSave.Location = new System.Drawing.Point(194, 465);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(105, 37);
            this.btnSave.TabIndex = 9;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // dgvEmpIns
            // 
            this.dgvEmpIns.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvEmpIns.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgvEmpIns.BackgroundColor = System.Drawing.Color.Honeydew;
            this.dgvEmpIns.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvEmpIns.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmpIns.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgbtxtEmpInsID,
            this.dgbtxtInsName,
            this.dgbcmbPosition,
            this.dgbtxtYear});
            this.dgvEmpIns.GridColor = System.Drawing.SystemColors.Info;
            this.dgvEmpIns.Location = new System.Drawing.Point(30, 289);
            this.dgvEmpIns.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvEmpIns.Name = "dgvEmpIns";
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvEmpIns.RowHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvEmpIns.RowHeadersWidth = 51;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.dgvEmpIns.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvEmpIns.RowTemplate.Height = 24;
            this.dgvEmpIns.Size = new System.Drawing.Size(724, 168);
            this.dgvEmpIns.TabIndex = 8;
            this.dgvEmpIns.UserDeletingRow += new System.Windows.Forms.DataGridViewRowCancelEventHandler(this.dgvEmpIns_UserDeletingRow);
            // 
            // dgbtxtEmpInsID
            // 
            this.dgbtxtEmpInsID.DataPropertyName = "EmpInsID";
            this.dgbtxtEmpInsID.HeaderText = "EmpInsID";
            this.dgbtxtEmpInsID.MinimumWidth = 6;
            this.dgbtxtEmpInsID.Name = "dgbtxtEmpInsID";
            this.dgbtxtEmpInsID.Visible = false;
            this.dgbtxtEmpInsID.Width = 125;
            // 
            // dgbtxtInsName
            // 
            this.dgbtxtInsName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dgbtxtInsName.DataPropertyName = "Institution";
            this.dgbtxtInsName.HeaderText = "Institutuion Name";
            this.dgbtxtInsName.MinimumWidth = 6;
            this.dgbtxtInsName.Name = "dgbtxtInsName";
            this.dgbtxtInsName.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dgbtxtInsName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // dgbcmbPosition
            // 
            this.dgbcmbPosition.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dgbcmbPosition.DataPropertyName = "PositionID";
            this.dgbcmbPosition.HeaderText = "Position";
            this.dgbcmbPosition.MinimumWidth = 6;
            this.dgbcmbPosition.Name = "dgbcmbPosition";
            this.dgbcmbPosition.Width = 70;
            // 
            // dgbtxtYear
            // 
            this.dgbtxtYear.DataPropertyName = "ExpYear";
            this.dgbtxtYear.HeaderText = "Year";
            this.dgbtxtYear.MinimumWidth = 6;
            this.dgbtxtYear.Name = "dgbtxtYear";
            this.dgbtxtYear.Width = 70;
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.Wheat;
            this.btnClear.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.ForeColor = System.Drawing.SystemColors.InfoText;
            this.btnClear.Location = new System.Drawing.Point(663, 252);
            this.btnClear.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(92, 37);
            this.btnClear.TabIndex = 7;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            // 
            // btnBrowse
            // 
            this.btnBrowse.BackColor = System.Drawing.Color.Wheat;
            this.btnBrowse.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBrowse.ForeColor = System.Drawing.SystemColors.InfoText;
            this.btnBrowse.Location = new System.Drawing.Point(514, 252);
            this.btnBrowse.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(91, 37);
            this.btnBrowse.TabIndex = 7;
            this.btnBrowse.Text = "Browse";
            this.btnBrowse.UseVisualStyleBackColor = false;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // pbxPhoto
            // 
            this.pbxPhoto.BackColor = System.Drawing.Color.Transparent;
            this.pbxPhoto.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pbxPhoto.Location = new System.Drawing.Point(514, 24);
            this.pbxPhoto.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pbxPhoto.Name = "pbxPhoto";
            this.pbxPhoto.Size = new System.Drawing.Size(240, 219);
            this.pbxPhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxPhoto.TabIndex = 6;
            this.pbxPhoto.TabStop = false;
            // 
            // rdbFullTime
            // 
            this.rdbFullTime.AutoSize = true;
            this.rdbFullTime.BackColor = System.Drawing.Color.Honeydew;
            this.rdbFullTime.Location = new System.Drawing.Point(250, 255);
            this.rdbFullTime.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rdbFullTime.Name = "rdbFullTime";
            this.rdbFullTime.Size = new System.Drawing.Size(87, 24);
            this.rdbFullTime.TabIndex = 5;
            this.rdbFullTime.TabStop = true;
            this.rdbFullTime.Text = "Full Time";
            this.rdbFullTime.UseVisualStyleBackColor = false;
            // 
            // rdbPartTime
            // 
            this.rdbPartTime.AutoSize = true;
            this.rdbPartTime.BackColor = System.Drawing.Color.Honeydew;
            this.rdbPartTime.Location = new System.Drawing.Point(382, 255);
            this.rdbPartTime.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rdbPartTime.Name = "rdbPartTime";
            this.rdbPartTime.Size = new System.Drawing.Size(94, 24);
            this.rdbPartTime.TabIndex = 5;
            this.rdbPartTime.TabStop = true;
            this.rdbPartTime.Text = "Part Time";
            this.rdbPartTime.UseVisualStyleBackColor = false;
            // 
            // cmbGender
            // 
            this.cmbGender.BackColor = System.Drawing.Color.Honeydew;
            this.cmbGender.FormattingEnabled = true;
            this.cmbGender.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.cmbGender.Location = new System.Drawing.Point(250, 207);
            this.cmbGender.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbGender.Name = "cmbGender";
            this.cmbGender.Size = new System.Drawing.Size(248, 28);
            this.cmbGender.TabIndex = 4;
            // 
            // dtpDOB
            // 
            this.dtpDOB.CalendarMonthBackground = System.Drawing.Color.Honeydew;
            this.dtpDOB.CalendarTitleBackColor = System.Drawing.Color.Honeydew;
            this.dtpDOB.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDOB.Location = new System.Drawing.Point(250, 160);
            this.dtpDOB.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtpDOB.Name = "dtpDOB";
            this.dtpDOB.Size = new System.Drawing.Size(248, 26);
            this.dtpDOB.TabIndex = 3;
            // 
            // cmbPosition
            // 
            this.cmbPosition.BackColor = System.Drawing.Color.Honeydew;
            this.cmbPosition.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbPosition.FormattingEnabled = true;
            this.cmbPosition.Items.AddRange(new object[] {
            "Administrator",
            "Consultant",
            "Trainer",
            "Senior Software Engineer",
            "Junior Software Engineer",
            "Central Manager"});
            this.cmbPosition.Location = new System.Drawing.Point(250, 113);
            this.cmbPosition.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbPosition.Name = "cmbPosition";
            this.cmbPosition.Size = new System.Drawing.Size(248, 29);
            this.cmbPosition.TabIndex = 2;
            // 
            // txtEmpName
            // 
            this.txtEmpName.BackColor = System.Drawing.Color.Honeydew;
            this.txtEmpName.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmpName.Location = new System.Drawing.Point(250, 66);
            this.txtEmpName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtEmpName.Name = "txtEmpName";
            this.txtEmpName.Size = new System.Drawing.Size(248, 28);
            this.txtEmpName.TabIndex = 1;
            // 
            // txtEmpCode
            // 
            this.txtEmpCode.BackColor = System.Drawing.Color.Honeydew;
            this.txtEmpCode.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmpCode.Location = new System.Drawing.Point(250, 25);
            this.txtEmpCode.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtEmpCode.Name = "txtEmpCode";
            this.txtEmpCode.Size = new System.Drawing.Size(248, 28);
            this.txtEmpCode.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Honeydew;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(146, 257);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 19);
            this.label6.TabIndex = 0;
            this.label6.Text = "State";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Honeydew;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(146, 213);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 19);
            this.label5.TabIndex = 0;
            this.label5.Text = "Gender";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Honeydew;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(146, 164);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 19);
            this.label4.TabIndex = 0;
            this.label4.Text = "Date Of Birth";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Honeydew;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(146, 118);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 19);
            this.label3.TabIndex = 0;
            this.label3.Text = "Position";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Honeydew;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(146, 71);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 19);
            this.label2.TabIndex = 0;
            this.label2.Text = "Emp Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Honeydew;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(146, 28);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Emp Code";
            // 
            // employeeTab
            // 
            this.employeeTab.Controls.Add(this.dgvEmployee);
            this.employeeTab.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.employeeTab.Location = new System.Drawing.Point(4, 32);
            this.employeeTab.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.employeeTab.Name = "employeeTab";
            this.employeeTab.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.employeeTab.Size = new System.Drawing.Size(782, 522);
            this.employeeTab.TabIndex = 1;
            this.employeeTab.Text = "Employee Register";
            this.employeeTab.UseVisualStyleBackColor = true;
            // 
            // dgvEmployee
            // 
            this.dgvEmployee.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmployee.Location = new System.Drawing.Point(8, 8);
            this.dgvEmployee.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvEmployee.Name = "dgvEmployee";
            this.dgvEmployee.RowHeadersWidth = 51;
            this.dgvEmployee.RowTemplate.Height = 24;
            this.dgvEmployee.Size = new System.Drawing.Size(765, 491);
            this.dgvEmployee.TabIndex = 0;
            this.dgvEmployee.DoubleClick += new System.EventHandler(this.dgvEmployee_DoubleClick);
            // 
            // ofd
            // 
            this.ofd.FileName = "openFileDialog1";
            // 
            // employeeDetailsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(854, 554);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "employeeDetailsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "employeeDetailsForm";
            this.Load += new System.EventHandler(this.employeeDetailsForm_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabController.ResumeLayout(false);
            this.tabController.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmpIns)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxPhoto)).EndInit();
            this.employeeTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployee)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabController;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.DataGridView dgvEmpIns;
        private System.Windows.Forms.DataGridViewComboBoxColumn dgbtxtEmpInsID;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgbtxtInsName;
        private System.Windows.Forms.DataGridViewComboBoxColumn dgbcmbPosition;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgbtxtYear;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.PictureBox pbxPhoto;
        private System.Windows.Forms.RadioButton rdbFullTime;
        private System.Windows.Forms.RadioButton rdbPartTime;
        private System.Windows.Forms.ComboBox cmbGender;
        private System.Windows.Forms.DateTimePicker dtpDOB;
        private System.Windows.Forms.ComboBox cmbPosition;
        private System.Windows.Forms.TextBox txtEmpName;
        private System.Windows.Forms.TextBox txtEmpCode;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage employeeTab;
        private System.Windows.Forms.DataGridView dgvEmployee;
        private System.Windows.Forms.OpenFileDialog ofd;
    }
}