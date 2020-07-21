namespace Alpha_Institute
{
    partial class ManageStudent
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
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.educationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.marksDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.alphaInstituteDataSet1 = new Alpha_Institute.AlphaInstituteDataSet1();
            this.studentTableAdapter = new Alpha_Institute.AlphaInstituteDataSet1TableAdapters.StudentTableAdapter();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.TabUpdateStudent = new System.Windows.Forms.TabPage();
            this.btnUpdateStudent = new System.Windows.Forms.Button();
            this.txtStudentMarks = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtStudentPhoneNo = new System.Windows.Forms.MaskedTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtStudentEmail = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtStudentName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.TabDeleteStudent = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.alphaInstituteDataSet1)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.TabUpdateStudent.SuspendLayout();
            this.TabDeleteStudent.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn,
            this.educationDataGridViewTextBoxColumn,
            this.phoneNoDataGridViewTextBoxColumn,
            this.marksDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.studentBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(73, 323);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(640, 150);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "Email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "Email";
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            // 
            // educationDataGridViewTextBoxColumn
            // 
            this.educationDataGridViewTextBoxColumn.DataPropertyName = "Education";
            this.educationDataGridViewTextBoxColumn.HeaderText = "Education";
            this.educationDataGridViewTextBoxColumn.Name = "educationDataGridViewTextBoxColumn";
            // 
            // phoneNoDataGridViewTextBoxColumn
            // 
            this.phoneNoDataGridViewTextBoxColumn.DataPropertyName = "PhoneNo";
            this.phoneNoDataGridViewTextBoxColumn.HeaderText = "PhoneNo";
            this.phoneNoDataGridViewTextBoxColumn.Name = "phoneNoDataGridViewTextBoxColumn";
            // 
            // marksDataGridViewTextBoxColumn
            // 
            this.marksDataGridViewTextBoxColumn.DataPropertyName = "Marks";
            this.marksDataGridViewTextBoxColumn.HeaderText = "Marks";
            this.marksDataGridViewTextBoxColumn.Name = "marksDataGridViewTextBoxColumn";
            // 
            // studentBindingSource
            // 
            this.studentBindingSource.DataMember = "Student";
            this.studentBindingSource.DataSource = this.alphaInstituteDataSet1;
            this.studentBindingSource.CurrentChanged += new System.EventHandler(this.studentBindingSource_CurrentChanged);
            // 
            // alphaInstituteDataSet1
            // 
            this.alphaInstituteDataSet1.DataSetName = "AlphaInstituteDataSet1";
            this.alphaInstituteDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // studentTableAdapter
            // 
            this.studentTableAdapter.ClearBeforeFill = true;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.TabUpdateStudent);
            this.tabControl1.Controls.Add(this.TabDeleteStudent);
            this.tabControl1.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(765, 305);
            this.tabControl1.TabIndex = 1;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // TabUpdateStudent
            // 
            this.TabUpdateStudent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.TabUpdateStudent.Controls.Add(this.btnUpdateStudent);
            this.TabUpdateStudent.Controls.Add(this.txtStudentMarks);
            this.TabUpdateStudent.Controls.Add(this.label1);
            this.TabUpdateStudent.Controls.Add(this.txtStudentPhoneNo);
            this.TabUpdateStudent.Controls.Add(this.label6);
            this.TabUpdateStudent.Controls.Add(this.txtStudentEmail);
            this.TabUpdateStudent.Controls.Add(this.label4);
            this.TabUpdateStudent.Controls.Add(this.txtStudentName);
            this.TabUpdateStudent.Controls.Add(this.label2);
            this.TabUpdateStudent.Controls.Add(this.listBox1);
            this.TabUpdateStudent.ForeColor = System.Drawing.Color.White;
            this.TabUpdateStudent.Location = new System.Drawing.Point(4, 29);
            this.TabUpdateStudent.Name = "TabUpdateStudent";
            this.TabUpdateStudent.Padding = new System.Windows.Forms.Padding(3);
            this.TabUpdateStudent.Size = new System.Drawing.Size(757, 272);
            this.TabUpdateStudent.TabIndex = 0;
            this.TabUpdateStudent.Text = "UpdateStudent";
            this.TabUpdateStudent.Click += new System.EventHandler(this.TabUpdateStudent_Click);
            // 
            // btnUpdateStudent
            // 
            this.btnUpdateStudent.ForeColor = System.Drawing.Color.Black;
            this.btnUpdateStudent.Location = new System.Drawing.Point(560, 202);
            this.btnUpdateStudent.Name = "btnUpdateStudent";
            this.btnUpdateStudent.Size = new System.Drawing.Size(169, 37);
            this.btnUpdateStudent.TabIndex = 28;
            this.btnUpdateStudent.Text = "Update Student";
            this.btnUpdateStudent.UseVisualStyleBackColor = true;
            this.btnUpdateStudent.Click += new System.EventHandler(this.btnUpdateStudent_Click);
            // 
            // txtStudentMarks
            // 
            this.txtStudentMarks.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.txtStudentMarks.Location = new System.Drawing.Point(379, 148);
            this.txtStudentMarks.Name = "txtStudentMarks";
            this.txtStudentMarks.Size = new System.Drawing.Size(181, 27);
            this.txtStudentMarks.TabIndex = 27;
            this.txtStudentMarks.TextChanged += new System.EventHandler(this.txtStudentMarks_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(241, 148);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 20);
            this.label1.TabIndex = 26;
            this.label1.Text = "Marks";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtStudentPhoneNo
            // 
            this.txtStudentPhoneNo.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.txtStudentPhoneNo.Location = new System.Drawing.Point(379, 104);
            this.txtStudentPhoneNo.Mask = "9999 0000000";
            this.txtStudentPhoneNo.Name = "txtStudentPhoneNo";
            this.txtStudentPhoneNo.Size = new System.Drawing.Size(181, 27);
            this.txtStudentPhoneNo.TabIndex = 25;
            this.txtStudentPhoneNo.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.txtStudentPhoneNo_MaskInputRejected);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(241, 104);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(95, 20);
            this.label6.TabIndex = 24;
            this.label6.Text = "PhoneNo.";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // txtStudentEmail
            // 
            this.txtStudentEmail.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.txtStudentEmail.Location = new System.Drawing.Point(379, 61);
            this.txtStudentEmail.Name = "txtStudentEmail";
            this.txtStudentEmail.Size = new System.Drawing.Size(181, 27);
            this.txtStudentEmail.TabIndex = 21;
            this.txtStudentEmail.TextChanged += new System.EventHandler(this.txtStudentEmail_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(241, 68);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 20);
            this.label4.TabIndex = 20;
            this.label4.Text = "Email";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // txtStudentName
            // 
            this.txtStudentName.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.txtStudentName.Location = new System.Drawing.Point(379, 17);
            this.txtStudentName.Name = "txtStudentName";
            this.txtStudentName.Size = new System.Drawing.Size(181, 27);
            this.txtStudentName.TabIndex = 17;
            this.txtStudentName.TextChanged += new System.EventHandler(this.txtStudentName_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(241, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 20);
            this.label2.TabIndex = 16;
            this.label2.Text = "Name";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 20;
            this.listBox1.Location = new System.Drawing.Point(6, 6);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(205, 244);
            this.listBox1.TabIndex = 0;
            this.listBox1.Click += new System.EventHandler(this.listBox1_Click);
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // TabDeleteStudent
            // 
            this.TabDeleteStudent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.TabDeleteStudent.Controls.Add(this.button1);
            this.TabDeleteStudent.Controls.Add(this.comboBox1);
            this.TabDeleteStudent.Location = new System.Drawing.Point(4, 29);
            this.TabDeleteStudent.Name = "TabDeleteStudent";
            this.TabDeleteStudent.Padding = new System.Windows.Forms.Padding(3);
            this.TabDeleteStudent.Size = new System.Drawing.Size(757, 272);
            this.TabDeleteStudent.TabIndex = 1;
            this.TabDeleteStudent.Text = "DeleteStudent";
            this.TabDeleteStudent.Click += new System.EventHandler(this.TabDeleteStudent_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(225, 91);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(235, 32);
            this.button1.TabIndex = 1;
            this.button1.Text = "Delete Student";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(225, 27);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(235, 28);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // ManageStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(800, 472);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "ManageStudent";
            this.Text = "ManageStudent";
            this.Load += new System.EventHandler(this.ManageStudent_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.alphaInstituteDataSet1)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.TabUpdateStudent.ResumeLayout(false);
            this.TabUpdateStudent.PerformLayout();
            this.TabDeleteStudent.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private AlphaInstituteDataSet1 alphaInstituteDataSet1;
        private System.Windows.Forms.BindingSource studentBindingSource;
        private AlphaInstituteDataSet1TableAdapters.StudentTableAdapter studentTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn educationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn marksDataGridViewTextBoxColumn;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage TabUpdateStudent;
        private System.Windows.Forms.TabPage TabDeleteStudent;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.TextBox txtStudentName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtStudentEmail;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnUpdateStudent;
        private System.Windows.Forms.TextBox txtStudentMarks;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox txtStudentPhoneNo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button1;
    }
}