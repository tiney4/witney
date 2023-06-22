using System.ComponentModel;

namespace LawnCare2
{
    partial class Employee
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

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
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.Back = new System.Windows.Forms.Button();
            this.EditRec = new System.Windows.Forms.Button();
            this.SaveRec = new System.Windows.Forms.Button();
            this.NewRec = new System.Windows.Forms.Button();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.AllData = new System.Windows.Forms.DataGridView();
            this.Export = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.ResetToDefault = new System.Windows.Forms.Button();
            this.textBox11 = new System.Windows.Forms.TextBox();
            this.Column = new System.Windows.Forms.Label();
            this.SearchBtn = new System.Windows.Forms.Button();
            this.textBox12 = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.Delete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AllData)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(391, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(163, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBox10);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.textBox9);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.Back);
            this.groupBox1.Controls.Add(this.EditRec);
            this.groupBox1.Controls.Add(this.SaveRec);
            this.groupBox1.Controls.Add(this.NewRec);
            this.groupBox1.Controls.Add(this.textBox7);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.textBox6);
            this.groupBox1.Controls.Add(this.textBox5);
            this.groupBox1.Controls.Add(this.textBox4);
            this.groupBox1.Controls.Add(this.textBox3);
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(13, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1133, 296);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Employees";
            // 
            // textBox10
            // 
            this.textBox10.Location = new System.Drawing.Point(612, 172);
            this.textBox10.Name = "textBox10";
            this.textBox10.Size = new System.Drawing.Size(341, 22);
            this.textBox10.TabIndex = 23;
            // 
            // label12
            // 
            this.label12.Location = new System.Drawing.Point(536, 175);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(70, 33);
            this.label12.TabIndex = 22;
            this.label12.Text = "Salary";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] { "male", "female" });
            this.comboBox1.Location = new System.Drawing.Point(612, 142);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(336, 24);
            this.comboBox1.TabIndex = 21;
            // 
            // label11
            // 
            this.label11.Location = new System.Drawing.Point(532, 143);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(70, 33);
            this.label11.TabIndex = 20;
            this.label11.Text = "Gender";
            // 
            // textBox9
            // 
            this.textBox9.Location = new System.Drawing.Point(608, 110);
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(341, 22);
            this.textBox9.TabIndex = 19;
            // 
            // label10
            // 
            this.label10.Location = new System.Drawing.Point(532, 113);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(70, 33);
            this.label10.TabIndex = 18;
            this.label10.Text = "Age";
            // 
            // Back
            // 
            this.Back.Location = new System.Drawing.Point(821, 231);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(111, 59);
            this.Back.TabIndex = 16;
            this.Back.Text = "Cancel";
            this.Back.UseVisualStyleBackColor = true;
            this.Back.Click += new System.EventHandler(this.Back_Click);
            // 
            // EditRec
            // 
            this.EditRec.Location = new System.Drawing.Point(686, 231);
            this.EditRec.Name = "EditRec";
            this.EditRec.Size = new System.Drawing.Size(111, 59);
            this.EditRec.TabIndex = 17;
            this.EditRec.Text = "Update";
            this.EditRec.UseVisualStyleBackColor = true;
            this.EditRec.Click += new System.EventHandler(this.EditRec_Click);
            // 
            // SaveRec
            // 
            this.SaveRec.Location = new System.Drawing.Point(990, 231);
            this.SaveRec.Name = "SaveRec";
            this.SaveRec.Size = new System.Drawing.Size(111, 59);
            this.SaveRec.TabIndex = 15;
            this.SaveRec.Text = "Save";
            this.SaveRec.UseVisualStyleBackColor = true;
            this.SaveRec.Click += new System.EventHandler(this.SaveRec_Click);
            // 
            // NewRec
            // 
            this.NewRec.Location = new System.Drawing.Point(546, 231);
            this.NewRec.Name = "NewRec";
            this.NewRec.Size = new System.Drawing.Size(111, 59);
            this.NewRec.TabIndex = 14;
            this.NewRec.Text = "New";
            this.NewRec.UseVisualStyleBackColor = true;
            this.NewRec.Click += new System.EventHandler(this.NewRec_Click);
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(608, 77);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(341, 22);
            this.textBox7.TabIndex = 13;
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(532, 80);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(70, 33);
            this.label8.TabIndex = 12;
            this.label8.Text = "Zip Code";
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(113, 77);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(379, 22);
            this.textBox6.TabIndex = 11;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(113, 110);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(379, 22);
            this.textBox5.TabIndex = 10;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(113, 143);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(379, 22);
            this.textBox4.TabIndex = 9;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(113, 177);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(379, 94);
            this.textBox3.TabIndex = 8;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(608, 38);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(341, 22);
            this.textBox2.TabIndex = 7;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(113, 44);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(379, 22);
            this.textBox1.TabIndex = 6;
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(23, 80);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(84, 33);
            this.label7.TabIndex = 5;
            this.label7.Text = "Last Name";
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(6, 113);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(111, 33);
            this.label6.TabIndex = 4;
            this.label6.Text = "Phone Number";
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(23, 146);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 33);
            this.label5.TabIndex = 3;
            this.label5.Text = "Email";
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(23, 179);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 33);
            this.label4.TabIndex = 2;
            this.label4.Text = "Address";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(532, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 33);
            this.label3.TabIndex = 1;
            this.label3.Text = "City";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(23, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 33);
            this.label2.TabIndex = 0;
            this.label2.Text = "First Name";
            // 
            // AllData
            // 
            this.AllData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AllData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { this.Delete });
            this.AllData.Location = new System.Drawing.Point(13, 351);
            this.AllData.Name = "AllData";
            this.AllData.RowTemplate.Height = 24;
            this.AllData.Size = new System.Drawing.Size(1133, 322);
            this.AllData.TabIndex = 2;
            this.AllData.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.CellClick);
            this.AllData.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.AllData_CellContentClick);
            // 
            // Export
            // 
            this.Export.Location = new System.Drawing.Point(1014, 679);
            this.Export.Name = "Export";
            this.Export.Size = new System.Drawing.Size(111, 59);
            this.Export.TabIndex = 24;
            this.Export.Text = "Export";
            this.Export.UseVisualStyleBackColor = true;
            this.Export.Click += new System.EventHandler(this.Export_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(804, 679);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(111, 59);
            this.button1.TabIndex = 25;
            this.button1.Text = "Back";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ResetToDefault
            // 
            this.ResetToDefault.Location = new System.Drawing.Point(1065, 315);
            this.ResetToDefault.Name = "ResetToDefault";
            this.ResetToDefault.Size = new System.Drawing.Size(82, 22);
            this.ResetToDefault.TabIndex = 31;
            this.ResetToDefault.Text = "Reset";
            this.ResetToDefault.UseVisualStyleBackColor = true;
            this.ResetToDefault.Click += new System.EventHandler(this.ResetToDefault_Click);
            // 
            // textBox11
            // 
            this.textBox11.Location = new System.Drawing.Point(582, 313);
            this.textBox11.Name = "textBox11";
            this.textBox11.Size = new System.Drawing.Size(375, 22);
            this.textBox11.TabIndex = 30;
            // 
            // Column
            // 
            this.Column.Location = new System.Drawing.Point(506, 313);
            this.Column.Name = "Column";
            this.Column.Size = new System.Drawing.Size(70, 33);
            this.Column.TabIndex = 29;
            this.Column.Text = "Column";
            // 
            // SearchBtn
            // 
            this.SearchBtn.Location = new System.Drawing.Point(977, 315);
            this.SearchBtn.Name = "SearchBtn";
            this.SearchBtn.Size = new System.Drawing.Size(82, 22);
            this.SearchBtn.TabIndex = 28;
            this.SearchBtn.Text = "Search";
            this.SearchBtn.UseVisualStyleBackColor = true;
            this.SearchBtn.Click += new System.EventHandler(this.SearchBtn_Click);
            // 
            // textBox12
            // 
            this.textBox12.Location = new System.Drawing.Point(88, 315);
            this.textBox12.Name = "textBox12";
            this.textBox12.Size = new System.Drawing.Size(412, 22);
            this.textBox12.TabIndex = 27;
            // 
            // label13
            // 
            this.label13.Location = new System.Drawing.Point(12, 315);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(70, 33);
            this.label13.TabIndex = 26;
            this.label13.Text = "Search";
            // 
            // Delete
            // 
            this.Delete.HeaderText = "Delete";
            this.Delete.Name = "Delete";
            this.Delete.Text = "Delete";
            this.Delete.ToolTipText = "Delete";
            this.Delete.UseColumnTextForButtonValue = true;
            // 
            // Employee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(1151, 746);
            this.Controls.Add(this.ResetToDefault);
            this.Controls.Add(this.textBox11);
            this.Controls.Add(this.Column);
            this.Controls.Add(this.SearchBtn);
            this.Controls.Add(this.textBox12);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Export);
            this.Controls.Add(this.AllData);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "Employee";
            this.Text = "Employee";
            this.Load += new System.EventHandler(this.Employee_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AllData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.DataGridViewButtonColumn Delete;

        private System.Windows.Forms.Button ResetToDefault;
        private System.Windows.Forms.TextBox textBox11;
        private System.Windows.Forms.Label Column;
        private System.Windows.Forms.Button SearchBtn;
        private System.Windows.Forms.TextBox textBox12;
        private System.Windows.Forms.Label label13;

        private System.Windows.Forms.Button button1;

        private System.Windows.Forms.Button Export;

        private System.Windows.Forms.TextBox textBox10;
        private System.Windows.Forms.Label label12;

        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox comboBox1;

        private System.Windows.Forms.Button NewRec;

        private System.Windows.Forms.DataGridView AllData;

        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button SaveRec;
        private System.Windows.Forms.Button Back;
        private System.Windows.Forms.Button EditRec;
        private System.Windows.Forms.Button button4;

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox6;

        #endregion
    }
}