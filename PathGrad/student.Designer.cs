namespace PathGrad
{
    partial class student
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
            this.welcomeTitle = new System.Windows.Forms.Label();
            this.expectedGrad = new System.Windows.Forms.Label();
            this.currentGPA = new System.Windows.Forms.Label();
            this.currentCourses = new System.Windows.Forms.Label();
            this.nextSemester = new System.Windows.Forms.Label();
            this.currCourse = new System.Windows.Forms.GroupBox();
            this.nextCourses = new System.Windows.Forms.GroupBox();
            this.viewMore = new System.Windows.Forms.Button();
            this.displayGPA = new System.Windows.Forms.TextBox();
            this.displayGraduation = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.CourseName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.courseNum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.creditHour = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.preReq = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.currCourse.SuspendLayout();
            this.nextCourses.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // welcomeTitle
            // 
            this.welcomeTitle.AutoSize = true;
            this.welcomeTitle.Location = new System.Drawing.Point(278, 13);
            this.welcomeTitle.Name = "welcomeTitle";
            this.welcomeTitle.Size = new System.Drawing.Size(163, 17);
            this.welcomeTitle.TabIndex = 0;
            this.welcomeTitle.Text = "Welcome Fellow Spartan";
            // 
            // expectedGrad
            // 
            this.expectedGrad.AutoSize = true;
            this.expectedGrad.Location = new System.Drawing.Point(12, 55);
            this.expectedGrad.Name = "expectedGrad";
            this.expectedGrad.Size = new System.Drawing.Size(141, 17);
            this.expectedGrad.TabIndex = 1;
            this.expectedGrad.Text = "Expected Graduation";
            // 
            // currentGPA
            // 
            this.currentGPA.AutoSize = true;
            this.currentGPA.Location = new System.Drawing.Point(278, 55);
            this.currentGPA.Name = "currentGPA";
            this.currentGPA.Size = new System.Drawing.Size(88, 17);
            this.currentGPA.TabIndex = 2;
            this.currentGPA.Text = "Current GPA";
            this.currentGPA.Click += new System.EventHandler(this.currentGPA_Click);
            // 
            // currentCourses
            // 
            this.currentCourses.AutoSize = true;
            this.currentCourses.Location = new System.Drawing.Point(99, 18);
            this.currentCourses.Name = "currentCourses";
            this.currentCourses.Size = new System.Drawing.Size(111, 17);
            this.currentCourses.TabIndex = 3;
            this.currentCourses.Text = "Current Courses";
            // 
            // nextSemester
            // 
            this.nextSemester.AutoSize = true;
            this.nextSemester.Location = new System.Drawing.Point(54, 18);
            this.nextSemester.Name = "nextSemester";
            this.nextSemester.Size = new System.Drawing.Size(156, 17);
            this.nextSemester.TabIndex = 4;
            this.nextSemester.Text = "Next Semester Courses";
            // 
            // currCourse
            // 
            this.currCourse.Controls.Add(this.dataGridView2);
            this.currCourse.Controls.Add(this.currentCourses);
            this.currCourse.Location = new System.Drawing.Point(15, 103);
            this.currCourse.Name = "currCourse";
            this.currCourse.Size = new System.Drawing.Size(503, 442);
            this.currCourse.TabIndex = 5;
            this.currCourse.TabStop = false;
            // 
            // nextCourses
            // 
            this.nextCourses.Controls.Add(this.dataGridView1);
            this.nextCourses.Controls.Add(this.nextSemester);
            this.nextCourses.Location = new System.Drawing.Point(536, 103);
            this.nextCourses.Name = "nextCourses";
            this.nextCourses.Size = new System.Drawing.Size(499, 442);
            this.nextCourses.TabIndex = 6;
            this.nextCourses.TabStop = false;
            // 
            // viewMore
            // 
            this.viewMore.Location = new System.Drawing.Point(681, 27);
            this.viewMore.Name = "viewMore";
            this.viewMore.Size = new System.Drawing.Size(120, 50);
            this.viewMore.TabIndex = 7;
            this.viewMore.Text = "View More";
            this.viewMore.UseVisualStyleBackColor = true;
            this.viewMore.Click += new System.EventHandler(this.viewMore_Click);
            // 
            // displayGPA
            // 
            this.displayGPA.Location = new System.Drawing.Point(398, 52);
            this.displayGPA.Name = "displayGPA";
            this.displayGPA.Size = new System.Drawing.Size(100, 22);
            this.displayGPA.TabIndex = 8;
            // 
            // displayGraduation
            // 
            this.displayGraduation.Location = new System.Drawing.Point(160, 55);
            this.displayGraduation.Name = "displayGraduation";
            this.displayGraduation.Size = new System.Drawing.Size(100, 22);
            this.displayGraduation.TabIndex = 9;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CourseName,
            this.courseNum,
            this.creditHour,
            this.preReq});
            this.dataGridView1.Location = new System.Drawing.Point(22, 38);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(460, 383);
            this.dataGridView1.TabIndex = 5;
            // 
            // CourseName
            // 
            this.CourseName.HeaderText = "Course Name";
            this.CourseName.Name = "CourseName";
            // 
            // courseNum
            // 
            this.courseNum.HeaderText = "Course Number";
            this.courseNum.Name = "courseNum";
            // 
            // creditHour
            // 
            this.creditHour.HeaderText = "Credit Hour";
            this.creditHour.Name = "creditHour";
            // 
            // preReq
            // 
            this.preReq.HeaderText = "PreReq";
            this.preReq.Name = "preReq";
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.dataGridView2.Location = new System.Drawing.Point(6, 40);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(460, 383);
            this.dataGridView2.TabIndex = 6;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Course Name";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Course Number";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "Credit Hour";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "PreReq";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // student
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1047, 577);
            this.Controls.Add(this.displayGraduation);
            this.Controls.Add(this.displayGPA);
            this.Controls.Add(this.viewMore);
            this.Controls.Add(this.nextCourses);
            this.Controls.Add(this.currCourse);
            this.Controls.Add(this.currentGPA);
            this.Controls.Add(this.expectedGrad);
            this.Controls.Add(this.welcomeTitle);
            this.Name = "student";
            this.Text = "student";
            this.currCourse.ResumeLayout(false);
            this.currCourse.PerformLayout();
            this.nextCourses.ResumeLayout(false);
            this.nextCourses.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label welcomeTitle;
        private System.Windows.Forms.Label expectedGrad;
        private System.Windows.Forms.Label currentGPA;
        private System.Windows.Forms.Label currentCourses;
        private System.Windows.Forms.Label nextSemester;
        private System.Windows.Forms.GroupBox currCourse;
        private System.Windows.Forms.GroupBox nextCourses;
        private System.Windows.Forms.Button viewMore;
        private System.Windows.Forms.TextBox displayGPA;
        private System.Windows.Forms.TextBox displayGraduation;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn CourseName;
        private System.Windows.Forms.DataGridViewTextBoxColumn courseNum;
        private System.Windows.Forms.DataGridViewTextBoxColumn creditHour;
        private System.Windows.Forms.DataGridViewTextBoxColumn preReq;
    }
}