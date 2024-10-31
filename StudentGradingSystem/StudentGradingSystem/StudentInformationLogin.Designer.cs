namespace StudentGradingSystem
{
    partial class StudentInformationLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StudentInformationLogin));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.studentno_box = new System.Windows.Forms.MaskedTextBox();
            this.login_bttn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.teacher_login = new System.Windows.Forms.Button();
            this.teacher_box = new System.Windows.Forms.MaskedTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.exit_bttn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(7, 61);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(76, 63);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(102, 83);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 22);
            this.label1.TabIndex = 1;
            this.label1.Text = "Student Number : ";
            // 
            // studentno_box
            // 
            this.studentno_box.Location = new System.Drawing.Point(262, 80);
            this.studentno_box.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.studentno_box.Mask = "0000";
            this.studentno_box.Name = "studentno_box";
            this.studentno_box.Size = new System.Drawing.Size(142, 30);
            this.studentno_box.TabIndex = 2;
            // 
            // login_bttn
            // 
            this.login_bttn.BackColor = System.Drawing.Color.LightGray;
            this.login_bttn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.login_bttn.Location = new System.Drawing.Point(312, 116);
            this.login_bttn.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.login_bttn.Name = "login_bttn";
            this.login_bttn.Size = new System.Drawing.Size(92, 29);
            this.login_bttn.TabIndex = 3;
            this.login_bttn.Text = "Login";
            this.login_bttn.UseVisualStyleBackColor = false;
            this.login_bttn.Click += new System.EventHandler(this.login_bttn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(138, 26);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(157, 23);
            this.label3.TabIndex = 5;
            this.label3.Text = "Student Entrance";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(137, 27);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(160, 23);
            this.label4.TabIndex = 11;
            this.label4.Text = "Teacher Entrance";
            // 
            // teacher_login
            // 
            this.teacher_login.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.teacher_login.Location = new System.Drawing.Point(321, 116);
            this.teacher_login.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.teacher_login.Name = "teacher_login";
            this.teacher_login.Size = new System.Drawing.Size(92, 29);
            this.teacher_login.TabIndex = 9;
            this.teacher_login.Text = "Login";
            this.teacher_login.UseVisualStyleBackColor = true;
            this.teacher_login.Click += new System.EventHandler(this.teacher_login_Click);
            // 
            // teacher_box
            // 
            this.teacher_box.Location = new System.Drawing.Point(271, 80);
            this.teacher_box.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.teacher_box.Mask = "0000";
            this.teacher_box.Name = "teacher_box";
            this.teacher_box.Size = new System.Drawing.Size(142, 30);
            this.teacher_box.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(111, 83);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(157, 22);
            this.label6.TabIndex = 7;
            this.label6.Text = "Teacher Number : ";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(16, 61);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(76, 63);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 6;
            this.pictureBox2.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.studentno_box);
            this.groupBox1.Controls.Add(this.login_bttn);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(17, 66);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(433, 161);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.pictureBox2);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.teacher_box);
            this.groupBox2.Controls.Add(this.teacher_login);
            this.groupBox2.Location = new System.Drawing.Point(456, 66);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(434, 161);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(40, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(426, 26);
            this.label2.TabIndex = 14;
            this.label2.Text = "Welcome to the Student Information System";
            // 
            // exit_bttn
            // 
            this.exit_bttn.BackColor = System.Drawing.Color.Transparent;
            this.exit_bttn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("exit_bttn.BackgroundImage")));
            this.exit_bttn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.exit_bttn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.exit_bttn.Location = new System.Drawing.Point(859, 7);
            this.exit_bttn.Name = "exit_bttn";
            this.exit_bttn.Size = new System.Drawing.Size(37, 33);
            this.exit_bttn.TabIndex = 15;
            this.exit_bttn.UseVisualStyleBackColor = false;
            this.exit_bttn.Click += new System.EventHandler(this.exit_bttn_Click);
            // 
            // StudentInformationLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(903, 236);
            this.Controls.Add(this.exit_bttn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "StudentInformationLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Student Information Login";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox studentno_box;
        private System.Windows.Forms.Button login_bttn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button teacher_login;
        private System.Windows.Forms.MaskedTextBox teacher_box;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button exit_bttn;
    }
}

