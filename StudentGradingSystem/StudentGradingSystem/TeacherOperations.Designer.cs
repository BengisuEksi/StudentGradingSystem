namespace StudentGradingSystem
{
    partial class TeacherOperations
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TeacherOperations));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.list_bttn = new System.Windows.Forms.Button();
            this.status_lbl = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.delete_bttn = new System.Windows.Forms.Button();
            this.clear_bttn = new System.Windows.Forms.Button();
            this.add_bttn = new System.Windows.Forms.Button();
            this.avg_lbl = new System.Windows.Forms.Label();
            this.update_bttn = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.exam3_box = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.exam2_box = new System.Windows.Forms.TextBox();
            this.exam1_box = new System.Windows.Forms.TextBox();
            this.lbl = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.surname_box = new System.Windows.Forms.TextBox();
            this.name_box = new System.Windows.Forms.TextBox();
            this.number_box = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.fail_lbl = new System.Windows.Forms.Label();
            this.pass_lbl = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.stIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stSurnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stE1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stE2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stE3DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stAvgDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stStatusDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.tblStudentGradesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dBGradeSystemDataSet = new StudentGradingSystem.DBGradeSystemDataSet();
            this.label9 = new System.Windows.Forms.Label();
            this.exit_bttn = new System.Windows.Forms.Button();
            this.teacher_name = new System.Windows.Forms.Label();
            this.tbl_StudentGradesTableAdapter = new StudentGradingSystem.DBGradeSystemDataSetTableAdapters.Tbl_StudentGradesTableAdapter();
            this.teacher_number = new System.Windows.Forms.Label();
            this.sign_out_bttn = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblStudentGradesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBGradeSystemDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox1.Controls.Add(this.list_bttn);
            this.groupBox1.Controls.Add(this.status_lbl);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.delete_bttn);
            this.groupBox1.Controls.Add(this.clear_bttn);
            this.groupBox1.Controls.Add(this.add_bttn);
            this.groupBox1.Controls.Add(this.avg_lbl);
            this.groupBox1.Controls.Add(this.update_bttn);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.exam3_box);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.exam2_box);
            this.groupBox1.Controls.Add(this.exam1_box);
            this.groupBox1.Controls.Add(this.lbl);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.surname_box);
            this.groupBox1.Controls.Add(this.name_box);
            this.groupBox1.Controls.Add(this.number_box);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 88);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(652, 250);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Student Information";
            // 
            // list_bttn
            // 
            this.list_bttn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.list_bttn.Location = new System.Drawing.Point(72, 167);
            this.list_bttn.Name = "list_bttn";
            this.list_bttn.Size = new System.Drawing.Size(91, 28);
            this.list_bttn.TabIndex = 29;
            this.list_bttn.Text = "List";
            this.list_bttn.UseVisualStyleBackColor = true;
            this.list_bttn.Click += new System.EventHandler(this.list_bttn_Click);
            // 
            // status_lbl
            // 
            this.status_lbl.AutoSize = true;
            this.status_lbl.Location = new System.Drawing.Point(485, 211);
            this.status_lbl.Name = "status_lbl";
            this.status_lbl.Size = new System.Drawing.Size(39, 19);
            this.status_lbl.TabIndex = 28;
            this.status_lbl.Text = "Null";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(328, 211);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(120, 19);
            this.label11.TabIndex = 27;
            this.label11.Text = "Student\'s Status:";
            // 
            // delete_bttn
            // 
            this.delete_bttn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.delete_bttn.Location = new System.Drawing.Point(398, 167);
            this.delete_bttn.Name = "delete_bttn";
            this.delete_bttn.Size = new System.Drawing.Size(87, 28);
            this.delete_bttn.TabIndex = 26;
            this.delete_bttn.Text = "Delete";
            this.delete_bttn.UseVisualStyleBackColor = true;
            this.delete_bttn.Click += new System.EventHandler(this.delete_bttn_Click);
            // 
            // clear_bttn
            // 
            this.clear_bttn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clear_bttn.Location = new System.Drawing.Point(503, 167);
            this.clear_bttn.Name = "clear_bttn";
            this.clear_bttn.Size = new System.Drawing.Size(87, 28);
            this.clear_bttn.TabIndex = 25;
            this.clear_bttn.Text = "Clear";
            this.clear_bttn.UseVisualStyleBackColor = true;
            this.clear_bttn.Click += new System.EventHandler(this.clear_bttn_Click);
            // 
            // add_bttn
            // 
            this.add_bttn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.add_bttn.Location = new System.Drawing.Point(180, 167);
            this.add_bttn.Name = "add_bttn";
            this.add_bttn.Size = new System.Drawing.Size(91, 27);
            this.add_bttn.TabIndex = 6;
            this.add_bttn.Text = "Add";
            this.add_bttn.UseVisualStyleBackColor = true;
            this.add_bttn.Click += new System.EventHandler(this.add_bttn_Click);
            // 
            // avg_lbl
            // 
            this.avg_lbl.AutoSize = true;
            this.avg_lbl.Location = new System.Drawing.Point(210, 211);
            this.avg_lbl.Name = "avg_lbl";
            this.avg_lbl.Size = new System.Drawing.Size(27, 19);
            this.avg_lbl.TabIndex = 24;
            this.avg_lbl.Text = "00";
            // 
            // update_bttn
            // 
            this.update_bttn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.update_bttn.Location = new System.Drawing.Point(289, 167);
            this.update_bttn.Name = "update_bttn";
            this.update_bttn.Size = new System.Drawing.Size(91, 28);
            this.update_bttn.TabIndex = 12;
            this.update_bttn.Text = "Update";
            this.update_bttn.UseVisualStyleBackColor = true;
            this.update_bttn.Click += new System.EventHandler(this.update_bttn_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(53, 211);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(132, 19);
            this.label8.TabIndex = 23;
            this.label8.Text = "Student\'s Average:";
            // 
            // exam3_box
            // 
            this.exam3_box.Location = new System.Drawing.Point(446, 111);
            this.exam3_box.Name = "exam3_box";
            this.exam3_box.Size = new System.Drawing.Size(144, 27);
            this.exam3_box.TabIndex = 22;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(375, 114);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 19);
            this.label4.TabIndex = 21;
            this.label4.Text = "Exam 3:";
            // 
            // exam2_box
            // 
            this.exam2_box.Location = new System.Drawing.Point(446, 72);
            this.exam2_box.Name = "exam2_box";
            this.exam2_box.Size = new System.Drawing.Size(144, 27);
            this.exam2_box.TabIndex = 20;
            // 
            // exam1_box
            // 
            this.exam1_box.Location = new System.Drawing.Point(446, 33);
            this.exam1_box.Name = "exam1_box";
            this.exam1_box.Size = new System.Drawing.Size(144, 27);
            this.exam1_box.TabIndex = 19;
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.Location = new System.Drawing.Point(375, 75);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(65, 19);
            this.lbl.TabIndex = 18;
            this.lbl.Text = "Exam 2:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(375, 36);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 19);
            this.label5.TabIndex = 17;
            this.label5.Text = "Exam 1:";
            // 
            // surname_box
            // 
            this.surname_box.Location = new System.Drawing.Point(128, 113);
            this.surname_box.Name = "surname_box";
            this.surname_box.Size = new System.Drawing.Size(144, 27);
            this.surname_box.TabIndex = 5;
            // 
            // name_box
            // 
            this.name_box.Location = new System.Drawing.Point(128, 74);
            this.name_box.Name = "name_box";
            this.name_box.Size = new System.Drawing.Size(144, 27);
            this.name_box.TabIndex = 4;
            // 
            // number_box
            // 
            this.number_box.Location = new System.Drawing.Point(128, 33);
            this.number_box.Mask = "0000";
            this.number_box.Name = "number_box";
            this.number_box.Size = new System.Drawing.Size(144, 27);
            this.number_box.TabIndex = 3;
            this.number_box.ValidatingType = typeof(int);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(49, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "Surname:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(68, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Name:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(53, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Number:";
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox3.Controls.Add(this.fail_lbl);
            this.groupBox3.Controls.Add(this.pass_lbl);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Location = new System.Drawing.Point(670, 88);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(307, 250);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Class Status";
            // 
            // fail_lbl
            // 
            this.fail_lbl.AutoSize = true;
            this.fail_lbl.Location = new System.Drawing.Point(242, 136);
            this.fail_lbl.Name = "fail_lbl";
            this.fail_lbl.Size = new System.Drawing.Size(18, 19);
            this.fail_lbl.TabIndex = 16;
            this.fail_lbl.Text = "0";
            // 
            // pass_lbl
            // 
            this.pass_lbl.AutoSize = true;
            this.pass_lbl.Location = new System.Drawing.Point(242, 95);
            this.pass_lbl.Name = "pass_lbl";
            this.pass_lbl.Size = new System.Drawing.Size(18, 19);
            this.pass_lbl.TabIndex = 15;
            this.pass_lbl.Text = "0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(46, 136);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(196, 19);
            this.label6.TabIndex = 13;
            this.label6.Text = "Number of Failed Students:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(41, 95);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(201, 19);
            this.label7.TabIndex = 12;
            this.label7.Text = "Number of Passed Students:";
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox4.Controls.Add(this.dataGridView1);
            this.groupBox4.Location = new System.Drawing.Point(12, 344);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(965, 285);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Grades";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.stIDDataGridViewTextBoxColumn,
            this.stNumberDataGridViewTextBoxColumn,
            this.stNameDataGridViewTextBoxColumn,
            this.stSurnameDataGridViewTextBoxColumn,
            this.stE1DataGridViewTextBoxColumn,
            this.stE2DataGridViewTextBoxColumn,
            this.stE3DataGridViewTextBoxColumn,
            this.stAvgDataGridViewTextBoxColumn,
            this.stStatusDataGridViewCheckBoxColumn});
            this.dataGridView1.DataSource = this.tblStudentGradesBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 23);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(959, 259);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // stIDDataGridViewTextBoxColumn
            // 
            this.stIDDataGridViewTextBoxColumn.DataPropertyName = "StID";
            this.stIDDataGridViewTextBoxColumn.HeaderText = "StID";
            this.stIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.stIDDataGridViewTextBoxColumn.Name = "stIDDataGridViewTextBoxColumn";
            this.stIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // stNumberDataGridViewTextBoxColumn
            // 
            this.stNumberDataGridViewTextBoxColumn.DataPropertyName = "StNumber";
            this.stNumberDataGridViewTextBoxColumn.HeaderText = "StNumber";
            this.stNumberDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.stNumberDataGridViewTextBoxColumn.Name = "stNumberDataGridViewTextBoxColumn";
            // 
            // stNameDataGridViewTextBoxColumn
            // 
            this.stNameDataGridViewTextBoxColumn.DataPropertyName = "StName";
            this.stNameDataGridViewTextBoxColumn.HeaderText = "StName";
            this.stNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.stNameDataGridViewTextBoxColumn.Name = "stNameDataGridViewTextBoxColumn";
            // 
            // stSurnameDataGridViewTextBoxColumn
            // 
            this.stSurnameDataGridViewTextBoxColumn.DataPropertyName = "StSurname";
            this.stSurnameDataGridViewTextBoxColumn.HeaderText = "StSurname";
            this.stSurnameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.stSurnameDataGridViewTextBoxColumn.Name = "stSurnameDataGridViewTextBoxColumn";
            // 
            // stE1DataGridViewTextBoxColumn
            // 
            this.stE1DataGridViewTextBoxColumn.DataPropertyName = "StE1";
            this.stE1DataGridViewTextBoxColumn.HeaderText = "StE1";
            this.stE1DataGridViewTextBoxColumn.MinimumWidth = 6;
            this.stE1DataGridViewTextBoxColumn.Name = "stE1DataGridViewTextBoxColumn";
            // 
            // stE2DataGridViewTextBoxColumn
            // 
            this.stE2DataGridViewTextBoxColumn.DataPropertyName = "StE2";
            this.stE2DataGridViewTextBoxColumn.HeaderText = "StE2";
            this.stE2DataGridViewTextBoxColumn.MinimumWidth = 6;
            this.stE2DataGridViewTextBoxColumn.Name = "stE2DataGridViewTextBoxColumn";
            // 
            // stE3DataGridViewTextBoxColumn
            // 
            this.stE3DataGridViewTextBoxColumn.DataPropertyName = "StE3";
            this.stE3DataGridViewTextBoxColumn.HeaderText = "StE3";
            this.stE3DataGridViewTextBoxColumn.MinimumWidth = 6;
            this.stE3DataGridViewTextBoxColumn.Name = "stE3DataGridViewTextBoxColumn";
            // 
            // stAvgDataGridViewTextBoxColumn
            // 
            this.stAvgDataGridViewTextBoxColumn.DataPropertyName = "StAvg";
            this.stAvgDataGridViewTextBoxColumn.HeaderText = "StAvg";
            this.stAvgDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.stAvgDataGridViewTextBoxColumn.Name = "stAvgDataGridViewTextBoxColumn";
            // 
            // stStatusDataGridViewCheckBoxColumn
            // 
            this.stStatusDataGridViewCheckBoxColumn.DataPropertyName = "StStatus";
            this.stStatusDataGridViewCheckBoxColumn.HeaderText = "StStatus";
            this.stStatusDataGridViewCheckBoxColumn.MinimumWidth = 6;
            this.stStatusDataGridViewCheckBoxColumn.Name = "stStatusDataGridViewCheckBoxColumn";
            // 
            // tblStudentGradesBindingSource
            // 
            this.tblStudentGradesBindingSource.DataMember = "Tbl_StudentGrades";
            this.tblStudentGradesBindingSource.DataSource = this.dBGradeSystemDataSet;
            // 
            // dBGradeSystemDataSet
            // 
            this.dBGradeSystemDataSet.DataSetName = "DBGradeSystemDataSet";
            this.dBGradeSystemDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(57, 27);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(134, 34);
            this.label9.TabIndex = 1;
            this.label9.Text = "Welcome,";
            // 
            // exit_bttn
            // 
            this.exit_bttn.BackColor = System.Drawing.Color.Transparent;
            this.exit_bttn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("exit_bttn.BackgroundImage")));
            this.exit_bttn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.exit_bttn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.exit_bttn.Location = new System.Drawing.Point(950, 2);
            this.exit_bttn.Name = "exit_bttn";
            this.exit_bttn.Size = new System.Drawing.Size(37, 33);
            this.exit_bttn.TabIndex = 7;
            this.exit_bttn.UseVisualStyleBackColor = false;
            this.exit_bttn.Click += new System.EventHandler(this.exit_bttn_Click);
            // 
            // teacher_name
            // 
            this.teacher_name.AutoSize = true;
            this.teacher_name.Font = new System.Drawing.Font("Times New Roman", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.teacher_name.Location = new System.Drawing.Point(186, 27);
            this.teacher_name.Name = "teacher_name";
            this.teacher_name.Size = new System.Drawing.Size(70, 34);
            this.teacher_name.TabIndex = 8;
            this.teacher_name.Text = "Null";
            // 
            // tbl_StudentGradesTableAdapter
            // 
            this.tbl_StudentGradesTableAdapter.ClearBeforeFill = true;
            // 
            // teacher_number
            // 
            this.teacher_number.AutoSize = true;
            this.teacher_number.Location = new System.Drawing.Point(483, 34);
            this.teacher_number.Name = "teacher_number";
            this.teacher_number.Size = new System.Drawing.Size(60, 19);
            this.teacher_number.TabIndex = 9;
            this.teacher_number.Text = "label10";
            this.teacher_number.Visible = false;
            // 
            // sign_out_bttn
            // 
            this.sign_out_bttn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.sign_out_bttn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.sign_out_bttn.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.sign_out_bttn.Location = new System.Drawing.Point(441, 632);
            this.sign_out_bttn.Name = "sign_out_bttn";
            this.sign_out_bttn.Size = new System.Drawing.Size(111, 24);
            this.sign_out_bttn.TabIndex = 18;
            this.sign_out_bttn.Text = "Sign Out";
            this.sign_out_bttn.UseVisualStyleBackColor = false;
            this.sign_out_bttn.Click += new System.EventHandler(this.sign_out_bttn_Click);
            // 
            // TeacherOperations
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(989, 669);
            this.Controls.Add(this.sign_out_bttn);
            this.Controls.Add(this.teacher_number);
            this.Controls.Add(this.teacher_name);
            this.Controls.Add(this.exit_bttn);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "TeacherOperations";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Teacher Operations";
            this.Load += new System.EventHandler(this.TeacherOperations_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblStudentGradesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBGradeSystemDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button add_bttn;
        private System.Windows.Forms.TextBox surname_box;
        private System.Windows.Forms.TextBox name_box;
        private System.Windows.Forms.MaskedTextBox number_box;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button update_bttn;
        private System.Windows.Forms.Label fail_lbl;
        private System.Windows.Forms.Label pass_lbl;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private DBGradeSystemDataSet dBGradeSystemDataSet;
        private System.Windows.Forms.BindingSource tblStudentGradesBindingSource;
        private DBGradeSystemDataSetTableAdapters.Tbl_StudentGradesTableAdapter tbl_StudentGradesTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn stIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stSurnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stE1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stE2DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stE3DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stAvgDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn stStatusDataGridViewCheckBoxColumn;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button exit_bttn;
        private System.Windows.Forms.Label teacher_name;
        private System.Windows.Forms.Label teacher_number;
        private System.Windows.Forms.Button sign_out_bttn;
        private System.Windows.Forms.Button clear_bttn;
        private System.Windows.Forms.Label avg_lbl;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox exam3_box;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox exam2_box;
        private System.Windows.Forms.TextBox exam1_box;
        private System.Windows.Forms.Label lbl;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button delete_bttn;
        private System.Windows.Forms.Label status_lbl;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button list_bttn;
    }
}