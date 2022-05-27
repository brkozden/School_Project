namespace SchoolProject
{
    partial class StudentForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StudentForm));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lblstudentnumber = new System.Windows.Forms.Label();
            this.lblStudentNumber2 = new System.Windows.Forms.Label();
            this.tbxClose = new System.Windows.Forms.PictureBox();
            this.lblNameSurname = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbxClose)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(79, 79);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 149);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(1054, 366);
            this.dataGridView1.TabIndex = 1;
            // 
            // lblstudentnumber
            // 
            this.lblstudentnumber.AutoSize = true;
            this.lblstudentnumber.BackColor = System.Drawing.Color.Transparent;
            this.lblstudentnumber.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblstudentnumber.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblstudentnumber.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblstudentnumber.ForeColor = System.Drawing.Color.AliceBlue;
            this.lblstudentnumber.Location = new System.Drawing.Point(90, 9);
            this.lblstudentnumber.Name = "lblstudentnumber";
            this.lblstudentnumber.Size = new System.Drawing.Size(177, 30);
            this.lblstudentnumber.TabIndex = 4;
            this.lblstudentnumber.Text = "Student Number:";
            this.lblstudentnumber.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblStudentNumber2
            // 
            this.lblStudentNumber2.AutoSize = true;
            this.lblStudentNumber2.BackColor = System.Drawing.Color.Transparent;
            this.lblStudentNumber2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblStudentNumber2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblStudentNumber2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblStudentNumber2.ForeColor = System.Drawing.Color.AliceBlue;
            this.lblStudentNumber2.Location = new System.Drawing.Point(273, 9);
            this.lblStudentNumber2.Name = "lblStudentNumber2";
            this.lblStudentNumber2.Size = new System.Drawing.Size(26, 30);
            this.lblStudentNumber2.TabIndex = 5;
            this.lblStudentNumber2.Text = "0";
            this.lblStudentNumber2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbxClose
            // 
            this.tbxClose.BackColor = System.Drawing.Color.Transparent;
            this.tbxClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tbxClose.Image = ((System.Drawing.Image)(resources.GetObject("tbxClose.Image")));
            this.tbxClose.Location = new System.Drawing.Point(1019, 2);
            this.tbxClose.Name = "tbxClose";
            this.tbxClose.Size = new System.Drawing.Size(57, 56);
            this.tbxClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.tbxClose.TabIndex = 6;
            this.tbxClose.TabStop = false;
            this.tbxClose.Click += new System.EventHandler(this.tbxClose_Click);
            // 
            // lblNameSurname
            // 
            this.lblNameSurname.AutoSize = true;
            this.lblNameSurname.BackColor = System.Drawing.Color.Transparent;
            this.lblNameSurname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblNameSurname.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblNameSurname.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblNameSurname.ForeColor = System.Drawing.Color.AliceBlue;
            this.lblNameSurname.Location = new System.Drawing.Point(90, 52);
            this.lblNameSurname.Name = "lblNameSurname";
            this.lblNameSurname.Size = new System.Drawing.Size(159, 30);
            this.lblNameSurname.TabIndex = 7;
            this.lblNameSurname.Text = "Name Surname";
            this.lblNameSurname.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // StudentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1078, 534);
            this.Controls.Add(this.lblNameSurname);
            this.Controls.Add(this.tbxClose);
            this.Controls.Add(this.lblStudentNumber2);
            this.Controls.Add(this.lblstudentnumber);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "StudentForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.StudentForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbxClose)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lblstudentnumber;
        private System.Windows.Forms.Label lblStudentNumber2;
        private System.Windows.Forms.PictureBox tbxClose;
        private System.Windows.Forms.Label lblNameSurname;
    }
}