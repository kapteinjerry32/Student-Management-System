namespace Student_Management_System
{
    partial class Form1
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
            this.dgvStudentView = new System.Windows.Forms.DataGridView();
            this.btnViewStudents = new System.Windows.Forms.Button();
            this.lbStudentID = new System.Windows.Forms.Label();
            this.lbName = new System.Windows.Forms.Label();
            this.lbCourse = new System.Windows.Forms.Label();
            this.lbAge = new System.Windows.Forms.Label();
            this.txtStudentID = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtAge = new System.Windows.Forms.TextBox();
            this.txtCourse = new System.Windows.Forms.TextBox();
            this.btnRegister = new System.Windows.Forms.Button();
            this.btnUpdateStudent = new System.Windows.Forms.Button();
            this.btnSearchStudent = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.lvSummaryReport = new System.Windows.Forms.ListView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudentView)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvStudentView
            // 
            this.dgvStudentView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStudentView.Location = new System.Drawing.Point(672, 12);
            this.dgvStudentView.Name = "dgvStudentView";
            this.dgvStudentView.RowHeadersWidth = 51;
            this.dgvStudentView.RowTemplate.Height = 24;
            this.dgvStudentView.Size = new System.Drawing.Size(426, 465);
            this.dgvStudentView.TabIndex = 0;
            // 
            // btnViewStudents
            // 
            this.btnViewStudents.Location = new System.Drawing.Point(765, 514);
            this.btnViewStudents.Name = "btnViewStudents";
            this.btnViewStudents.Size = new System.Drawing.Size(186, 46);
            this.btnViewStudents.TabIndex = 1;
            this.btnViewStudents.Text = "View Student Details";
            this.btnViewStudents.UseVisualStyleBackColor = true;
            // 
            // lbStudentID
            // 
            this.lbStudentID.AutoSize = true;
            this.lbStudentID.Location = new System.Drawing.Point(22, 94);
            this.lbStudentID.Name = "lbStudentID";
            this.lbStudentID.Size = new System.Drawing.Size(65, 16);
            this.lbStudentID.TabIndex = 2;
            this.lbStudentID.Text = "StudentID";
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Location = new System.Drawing.Point(22, 206);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(44, 16);
            this.lbName.TabIndex = 3;
            this.lbName.Text = "Name";
            // 
            // lbCourse
            // 
            this.lbCourse.AutoSize = true;
            this.lbCourse.Location = new System.Drawing.Point(22, 408);
            this.lbCourse.Name = "lbCourse";
            this.lbCourse.Size = new System.Drawing.Size(50, 16);
            this.lbCourse.TabIndex = 5;
            this.lbCourse.Text = "Course";
            // 
            // lbAge
            // 
            this.lbAge.AutoSize = true;
            this.lbAge.Location = new System.Drawing.Point(22, 310);
            this.lbAge.Name = "lbAge";
            this.lbAge.Size = new System.Drawing.Size(32, 16);
            this.lbAge.TabIndex = 6;
            this.lbAge.Text = "Age";
            // 
            // txtStudentID
            // 
            this.txtStudentID.Location = new System.Drawing.Point(126, 88);
            this.txtStudentID.Name = "txtStudentID";
            this.txtStudentID.Size = new System.Drawing.Size(212, 22);
            this.txtStudentID.TabIndex = 7;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(126, 203);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(212, 22);
            this.txtName.TabIndex = 8;
            // 
            // txtAge
            // 
            this.txtAge.Location = new System.Drawing.Point(126, 304);
            this.txtAge.Name = "txtAge";
            this.txtAge.Size = new System.Drawing.Size(212, 22);
            this.txtAge.TabIndex = 9;
            // 
            // txtCourse
            // 
            this.txtCourse.Location = new System.Drawing.Point(126, 402);
            this.txtCourse.Name = "txtCourse";
            this.txtCourse.Size = new System.Drawing.Size(212, 22);
            this.txtCourse.TabIndex = 10;
            // 
            // btnRegister
            // 
            this.btnRegister.Location = new System.Drawing.Point(39, 452);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(136, 38);
            this.btnRegister.TabIndex = 11;
            this.btnRegister.Text = "Register Student";
            this.btnRegister.UseVisualStyleBackColor = true;
            // 
            // btnUpdateStudent
            // 
            this.btnUpdateStudent.Location = new System.Drawing.Point(255, 452);
            this.btnUpdateStudent.Name = "btnUpdateStudent";
            this.btnUpdateStudent.Size = new System.Drawing.Size(136, 41);
            this.btnUpdateStudent.TabIndex = 12;
            this.btnUpdateStudent.Text = "Update Student";
            this.btnUpdateStudent.UseVisualStyleBackColor = true;
            // 
            // btnSearchStudent
            // 
            this.btnSearchStudent.Location = new System.Drawing.Point(447, 439);
            this.btnSearchStudent.Name = "btnSearchStudent";
            this.btnSearchStudent.Size = new System.Drawing.Size(146, 38);
            this.btnSearchStudent.TabIndex = 13;
            this.btnSearchStudent.Text = "Summary Report";
            this.btnSearchStudent.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(142, 519);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(146, 41);
            this.button4.TabIndex = 14;
            this.button4.Text = "Delete Student";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // lvSummaryReport
            // 
            this.lvSummaryReport.HideSelection = false;
            this.lvSummaryReport.Location = new System.Drawing.Point(415, 12);
            this.lvSummaryReport.Name = "lvSummaryReport";
            this.lvSummaryReport.Size = new System.Drawing.Size(211, 412);
            this.lvSummaryReport.TabIndex = 15;
            this.lvSummaryReport.UseCompatibleStateImageBehavior = false;
            this.lvSummaryReport.View = System.Windows.Forms.View.Details;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1110, 590);
            this.Controls.Add(this.lvSummaryReport);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.btnSearchStudent);
            this.Controls.Add(this.btnUpdateStudent);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.txtCourse);
            this.Controls.Add(this.txtAge);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtStudentID);
            this.Controls.Add(this.lbAge);
            this.Controls.Add(this.lbCourse);
            this.Controls.Add(this.lbName);
            this.Controls.Add(this.lbStudentID);
            this.Controls.Add(this.btnViewStudents);
            this.Controls.Add(this.dgvStudentView);
            this.Name = "Form1";
            this.Text = "Student Details";
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudentView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvStudentView;
        private System.Windows.Forms.Button btnViewStudents;
        private System.Windows.Forms.Label lbStudentID;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.Label lbCourse;
        private System.Windows.Forms.Label lbAge;
        private System.Windows.Forms.TextBox txtStudentID;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtAge;
        private System.Windows.Forms.TextBox txtCourse;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.Button btnUpdateStudent;
        private System.Windows.Forms.Button btnSearchStudent;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.ListView lvSummaryReport;
    }
}

