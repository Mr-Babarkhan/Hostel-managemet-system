namespace Hostel_management_system
{
    partial class Student
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.studentid = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.studentname = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.student_fname = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.studentaddress = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.student_phone = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.stud_room = new System.Windows.Forms.ComboBox();
            this.stud_status = new System.Windows.Forms.ComboBox();
            this.studDGV = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.student_email = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.student_clg = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.studDGV)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Crimson;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(816, 91);
            this.panel1.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Blue;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.panel2.Location = new System.Drawing.Point(0, 63);
            this.panel2.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(816, 28);
            this.panel2.TabIndex = 16;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label7.Location = new System.Drawing.Point(792, 3);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(20, 23);
            this.label7.TabIndex = 15;
            this.label7.Text = "X";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(256, 13);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(322, 42);
            this.label1.TabIndex = 0;
            this.label1.Text = "Student  Information";
            // 
            // studentid
            // 
            this.studentid.BackColor = System.Drawing.Color.WhiteSmoke;
            this.studentid.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.studentid.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.studentid.ForeColor = System.Drawing.Color.Crimson;
            this.studentid.HintForeColor = System.Drawing.Color.Empty;
            this.studentid.HintText = "";
            this.studentid.isPassword = false;
            this.studentid.LineFocusedColor = System.Drawing.Color.Navy;
            this.studentid.LineIdleColor = System.Drawing.Color.Maroon;
            this.studentid.LineMouseHoverColor = System.Drawing.Color.DodgerBlue;
            this.studentid.LineThickness = 4;
            this.studentid.Location = new System.Drawing.Point(61, 141);
            this.studentid.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.studentid.Name = "studentid";
            this.studentid.Size = new System.Drawing.Size(256, 41);
            this.studentid.TabIndex = 2;
            this.studentid.Text = "Studentid";
            this.studentid.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // studentname
            // 
            this.studentname.BackColor = System.Drawing.Color.WhiteSmoke;
            this.studentname.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.studentname.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.studentname.ForeColor = System.Drawing.Color.Crimson;
            this.studentname.HintForeColor = System.Drawing.Color.Empty;
            this.studentname.HintText = "";
            this.studentname.isPassword = false;
            this.studentname.LineFocusedColor = System.Drawing.Color.Navy;
            this.studentname.LineIdleColor = System.Drawing.Color.Maroon;
            this.studentname.LineMouseHoverColor = System.Drawing.Color.DodgerBlue;
            this.studentname.LineThickness = 4;
            this.studentname.Location = new System.Drawing.Point(61, 196);
            this.studentname.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.studentname.Name = "studentname";
            this.studentname.Size = new System.Drawing.Size(256, 41);
            this.studentname.TabIndex = 3;
            this.studentname.Text = "Name";
            this.studentname.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // student_fname
            // 
            this.student_fname.BackColor = System.Drawing.Color.WhiteSmoke;
            this.student_fname.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.student_fname.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.student_fname.ForeColor = System.Drawing.Color.Crimson;
            this.student_fname.HintForeColor = System.Drawing.Color.Empty;
            this.student_fname.HintText = "";
            this.student_fname.isPassword = false;
            this.student_fname.LineFocusedColor = System.Drawing.Color.Navy;
            this.student_fname.LineIdleColor = System.Drawing.Color.Maroon;
            this.student_fname.LineMouseHoverColor = System.Drawing.Color.DodgerBlue;
            this.student_fname.LineThickness = 4;
            this.student_fname.Location = new System.Drawing.Point(61, 255);
            this.student_fname.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.student_fname.Name = "student_fname";
            this.student_fname.Size = new System.Drawing.Size(256, 41);
            this.student_fname.TabIndex = 4;
            this.student_fname.Text = "Father name";
            this.student_fname.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // studentaddress
            // 
            this.studentaddress.BackColor = System.Drawing.Color.WhiteSmoke;
            this.studentaddress.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.studentaddress.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.studentaddress.ForeColor = System.Drawing.Color.Crimson;
            this.studentaddress.HintForeColor = System.Drawing.Color.Empty;
            this.studentaddress.HintText = "";
            this.studentaddress.isPassword = false;
            this.studentaddress.LineFocusedColor = System.Drawing.Color.Navy;
            this.studentaddress.LineIdleColor = System.Drawing.Color.Maroon;
            this.studentaddress.LineMouseHoverColor = System.Drawing.Color.DodgerBlue;
            this.studentaddress.LineThickness = 4;
            this.studentaddress.Location = new System.Drawing.Point(61, 316);
            this.studentaddress.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.studentaddress.Name = "studentaddress";
            this.studentaddress.Size = new System.Drawing.Size(256, 41);
            this.studentaddress.TabIndex = 5;
            this.studentaddress.Text = "Address";
            this.studentaddress.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // student_phone
            // 
            this.student_phone.BackColor = System.Drawing.Color.WhiteSmoke;
            this.student_phone.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.student_phone.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.student_phone.ForeColor = System.Drawing.Color.Crimson;
            this.student_phone.HintForeColor = System.Drawing.Color.Empty;
            this.student_phone.HintText = "";
            this.student_phone.isPassword = false;
            this.student_phone.LineFocusedColor = System.Drawing.Color.Navy;
            this.student_phone.LineIdleColor = System.Drawing.Color.Maroon;
            this.student_phone.LineMouseHoverColor = System.Drawing.Color.DodgerBlue;
            this.student_phone.LineThickness = 4;
            this.student_phone.Location = new System.Drawing.Point(61, 377);
            this.student_phone.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.student_phone.Name = "student_phone";
            this.student_phone.Size = new System.Drawing.Size(256, 41);
            this.student_phone.TabIndex = 6;
            this.student_phone.Text = "Phone No";
            this.student_phone.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.student_phone.OnValueChanged += new System.EventHandler(this.bunifuMaterialTextbox5_OnValueChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label5.Location = new System.Drawing.Point(57, 572);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 19);
            this.label5.TabIndex = 8;
            this.label5.Text = "Room Num";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label2.Location = new System.Drawing.Point(57, 608);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 19);
            this.label2.TabIndex = 9;
            this.label2.Text = "Student Status";
            // 
            // stud_room
            // 
            this.stud_room.FormattingEnabled = true;
            this.stud_room.Items.AddRange(new object[] {
            "Active ",
            "Not-Active"});
            this.stud_room.Location = new System.Drawing.Point(167, 570);
            this.stud_room.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.stud_room.Name = "stud_room";
            this.stud_room.Size = new System.Drawing.Size(150, 21);
            this.stud_room.TabIndex = 10;
            // 
            // stud_status
            // 
            this.stud_status.FormattingEnabled = true;
            this.stud_status.Items.AddRange(new object[] {
            "Living",
            "Left"});
            this.stud_status.Location = new System.Drawing.Point(167, 606);
            this.stud_status.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.stud_status.Name = "stud_status";
            this.stud_status.Size = new System.Drawing.Size(150, 21);
            this.stud_status.TabIndex = 11;
            // 
            // studDGV
            // 
            this.studDGV.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.studDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.studDGV.Location = new System.Drawing.Point(366, 141);
            this.studDGV.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.studDGV.Name = "studDGV";
            this.studDGV.Size = new System.Drawing.Size(399, 427);
            this.studDGV.TabIndex = 13;
            this.studDGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label3.Location = new System.Drawing.Point(475, 93);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(192, 42);
            this.label3.TabIndex = 12;
            this.label3.Text = "Student List";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Crimson;
            this.panel3.Controls.Add(this.label6);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 668);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(816, 33);
            this.panel3.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Location = new System.Drawing.Point(258, 2);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(206, 26);
            this.label6.TabIndex = 1;
            this.label6.Text = "Jinnah Hostel For Boys";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Green;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Arial Narrow", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(429, 588);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(65, 32);
            this.button1.TabIndex = 15;
            this.button1.Text = "Add";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Green;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Arial Narrow", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(514, 588);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(87, 32);
            this.button2.TabIndex = 16;
            this.button2.Text = "Update";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Arial Narrow", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(617, 588);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(77, 32);
            this.button3.TabIndex = 17;
            this.button3.Text = "Delete";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Green;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Arial Narrow", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.Location = new System.Drawing.Point(514, 627);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(87, 32);
            this.button4.TabIndex = 18;
            this.button4.Text = "Back";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // student_email
            // 
            this.student_email.BackColor = System.Drawing.Color.WhiteSmoke;
            this.student_email.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.student_email.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.student_email.ForeColor = System.Drawing.Color.Crimson;
            this.student_email.HintForeColor = System.Drawing.Color.Empty;
            this.student_email.HintText = "";
            this.student_email.isPassword = false;
            this.student_email.LineFocusedColor = System.Drawing.Color.Navy;
            this.student_email.LineIdleColor = System.Drawing.Color.Maroon;
            this.student_email.LineMouseHoverColor = System.Drawing.Color.DodgerBlue;
            this.student_email.LineThickness = 4;
            this.student_email.Location = new System.Drawing.Point(61, 436);
            this.student_email.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.student_email.Name = "student_email";
            this.student_email.Size = new System.Drawing.Size(256, 41);
            this.student_email.TabIndex = 19;
            this.student_email.Text = "Email";
            this.student_email.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // student_clg
            // 
            this.student_clg.BackColor = System.Drawing.Color.WhiteSmoke;
            this.student_clg.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.student_clg.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.student_clg.ForeColor = System.Drawing.Color.Crimson;
            this.student_clg.HintForeColor = System.Drawing.Color.Empty;
            this.student_clg.HintText = "";
            this.student_clg.isPassword = false;
            this.student_clg.LineFocusedColor = System.Drawing.Color.Navy;
            this.student_clg.LineIdleColor = System.Drawing.Color.Maroon;
            this.student_clg.LineMouseHoverColor = System.Drawing.Color.DodgerBlue;
            this.student_clg.LineThickness = 4;
            this.student_clg.Location = new System.Drawing.Point(61, 490);
            this.student_clg.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.student_clg.Name = "student_clg";
            this.student_clg.Size = new System.Drawing.Size(256, 41);
            this.student_clg.TabIndex = 20;
            this.student_clg.Text = "Institute";
            this.student_clg.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // Student
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(816, 701);
            this.Controls.Add(this.student_clg);
            this.Controls.Add(this.student_email);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.studDGV);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.stud_status);
            this.Controls.Add(this.stud_room);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.student_phone);
            this.Controls.Add(this.studentaddress);
            this.Controls.Add(this.student_fname);
            this.Controls.Add(this.studentname);
            this.Controls.Add(this.studentid);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Student";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Student";
            this.Load += new System.EventHandler(this.Student_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.studDGV)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private Bunifu.Framework.UI.BunifuMaterialTextbox studentid;
        private Bunifu.Framework.UI.BunifuMaterialTextbox studentname;
        private Bunifu.Framework.UI.BunifuMaterialTextbox student_fname;
        private Bunifu.Framework.UI.BunifuMaterialTextbox studentaddress;
        private Bunifu.Framework.UI.BunifuMaterialTextbox student_phone;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox stud_room;
        private System.Windows.Forms.ComboBox stud_status;
        private System.Windows.Forms.DataGridView studDGV;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private Bunifu.Framework.UI.BunifuMaterialTextbox student_email;
        private Bunifu.Framework.UI.BunifuMaterialTextbox student_clg;
    }
}