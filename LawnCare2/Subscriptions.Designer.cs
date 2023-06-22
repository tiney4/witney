using System.ComponentModel;

namespace LawnCare2
{
    partial class Subscriptions
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
            this.AllData = new System.Windows.Forms.DataGridView();
            this.Delete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.textBox11 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.EditRec = new System.Windows.Forms.Button();
            this.Back = new System.Windows.Forms.Button();
            this.SaveRec = new System.Windows.Forms.Button();
            this.NewRec = new System.Windows.Forms.Button();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.Export = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.ResetToDefault = new System.Windows.Forms.Button();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.Column = new System.Windows.Forms.Label();
            this.SearchBtn = new System.Windows.Forms.Button();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.AllData)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // AllData
            // 
            this.AllData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AllData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { this.Delete });
            this.AllData.Location = new System.Drawing.Point(9, 358);
            this.AllData.Name = "AllData";
            this.AllData.RowTemplate.Height = 24;
            this.AllData.Size = new System.Drawing.Size(1133, 364);
            this.AllData.TabIndex = 22;
            this.AllData.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.AllData_CellContentClick);
            // 
            // Delete
            // 
            this.Delete.HeaderText = "Delete";
            this.Delete.Name = "Delete";
            this.Delete.Text = "Delete";
            this.Delete.ToolTipText = "Delete";
            this.Delete.UseColumnTextForButtonValue = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.comboBox2);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.textBox11);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.textBox10);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.EditRec);
            this.groupBox1.Controls.Add(this.Back);
            this.groupBox1.Controls.Add(this.SaveRec);
            this.groupBox1.Controls.Add(this.NewRec);
            this.groupBox1.Controls.Add(this.textBox7);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.textBox6);
            this.groupBox1.Controls.Add(this.textBox5);
            this.groupBox1.Controls.Add(this.textBox3);
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Location = new System.Drawing.Point(14, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1133, 296);
            this.groupBox1.TabIndex = 25;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Suppliers";
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(653, 36);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(377, 24);
            this.comboBox2.TabIndex = 25;
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] { "standard", "premium", "enterprise" });
            this.comboBox1.Location = new System.Drawing.Point(136, 138);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(377, 24);
            this.comboBox1.TabIndex = 24;
            // 
            // textBox11
            // 
            this.textBox11.Location = new System.Drawing.Point(653, 124);
            this.textBox11.Name = "textBox11";
            this.textBox11.Size = new System.Drawing.Size(377, 22);
            this.textBox11.TabIndex = 23;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(546, 127);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 41);
            this.label1.TabIndex = 22;
            this.label1.Text = "Customer LastName";
            // 
            // textBox10
            // 
            this.textBox10.Location = new System.Drawing.Point(653, 77);
            this.textBox10.Name = "textBox10";
            this.textBox10.Size = new System.Drawing.Size(377, 22);
            this.textBox10.TabIndex = 21;
            // 
            // label10
            // 
            this.label10.Location = new System.Drawing.Point(546, 80);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(101, 41);
            this.label10.TabIndex = 20;
            this.label10.Text = "Customer FirstName";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(546, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 35);
            this.label2.TabIndex = 18;
            this.label2.Text = "Customer ID";
            // 
            // EditRec
            // 
            this.EditRec.Location = new System.Drawing.Point(686, 198);
            this.EditRec.Name = "EditRec";
            this.EditRec.Size = new System.Drawing.Size(111, 59);
            this.EditRec.TabIndex = 17;
            this.EditRec.Text = "Update";
            this.EditRec.UseVisualStyleBackColor = true;
            this.EditRec.Click += new System.EventHandler(this.EditRec_Click);
            // 
            // Back
            // 
            this.Back.Location = new System.Drawing.Point(838, 198);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(111, 59);
            this.Back.TabIndex = 16;
            this.Back.Text = "Cancel";
            this.Back.UseVisualStyleBackColor = true;
            this.Back.Click += new System.EventHandler(this.Back_Click);
            // 
            // SaveRec
            // 
            this.SaveRec.Location = new System.Drawing.Point(990, 198);
            this.SaveRec.Name = "SaveRec";
            this.SaveRec.Size = new System.Drawing.Size(111, 59);
            this.SaveRec.TabIndex = 15;
            this.SaveRec.Text = "Save";
            this.SaveRec.UseVisualStyleBackColor = true;
            this.SaveRec.Click += new System.EventHandler(this.SaveRec_Click);
            // 
            // NewRec
            // 
            this.NewRec.Location = new System.Drawing.Point(546, 198);
            this.NewRec.Name = "NewRec";
            this.NewRec.Size = new System.Drawing.Size(111, 59);
            this.NewRec.TabIndex = 14;
            this.NewRec.Text = "New";
            this.NewRec.UseVisualStyleBackColor = true;
            this.NewRec.Click += new System.EventHandler(this.NewRec_Click);
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(135, 244);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(380, 22);
            this.textBox7.TabIndex = 13;
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(23, 239);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(104, 33);
            this.label8.TabIndex = 12;
            this.label8.Text = "Total Amount";
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(135, 77);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(379, 22);
            this.textBox6.TabIndex = 11;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(135, 107);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(379, 22);
            this.textBox5.TabIndex = 10;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(136, 170);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(379, 22);
            this.textBox3.TabIndex = 8;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(136, 206);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(380, 22);
            this.textBox2.TabIndex = 7;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(135, 44);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(379, 22);
            this.textBox1.TabIndex = 6;
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(23, 77);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(84, 33);
            this.label7.TabIndex = 5;
            this.label7.Text = "Tax";
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(25, 107);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(111, 33);
            this.label6.TabIndex = 4;
            this.label6.Text = "Validity";
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(23, 146);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 33);
            this.label5.TabIndex = 3;
            this.label5.Text = "Plan";
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(23, 179);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 33);
            this.label4.TabIndex = 2;
            this.label4.Text = "Payement Date";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(6, 206);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 33);
            this.label3.TabIndex = 1;
            this.label3.Text = "Payement Amount";
            // 
            // label11
            // 
            this.label11.Location = new System.Drawing.Point(23, 47);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(106, 33);
            this.label11.TabIndex = 0;
            this.label11.Text = "Subscription ID";
            // 
            // Export
            // 
            this.Export.Location = new System.Drawing.Point(1023, 739);
            this.Export.Name = "Export";
            this.Export.Size = new System.Drawing.Size(111, 59);
            this.Export.TabIndex = 26;
            this.Export.Text = "Export";
            this.Export.UseVisualStyleBackColor = true;
            this.Export.Click += new System.EventHandler(this.Export_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(896, 739);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(111, 59);
            this.button1.TabIndex = 26;
            this.button1.Text = "Back";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ResetToDefault
            // 
            this.ResetToDefault.Location = new System.Drawing.Point(1067, 322);
            this.ResetToDefault.Name = "ResetToDefault";
            this.ResetToDefault.Size = new System.Drawing.Size(82, 22);
            this.ResetToDefault.TabIndex = 32;
            this.ResetToDefault.Text = "Reset";
            this.ResetToDefault.UseVisualStyleBackColor = true;
            this.ResetToDefault.Click += new System.EventHandler(this.ResetToDefault_Click);
            // 
            // textBox9
            // 
            this.textBox9.Location = new System.Drawing.Point(584, 320);
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(375, 22);
            this.textBox9.TabIndex = 31;
            // 
            // Column
            // 
            this.Column.Location = new System.Drawing.Point(508, 320);
            this.Column.Name = "Column";
            this.Column.Size = new System.Drawing.Size(70, 33);
            this.Column.TabIndex = 30;
            this.Column.Text = "Column";
            // 
            // SearchBtn
            // 
            this.SearchBtn.Location = new System.Drawing.Point(979, 322);
            this.SearchBtn.Name = "SearchBtn";
            this.SearchBtn.Size = new System.Drawing.Size(82, 22);
            this.SearchBtn.TabIndex = 29;
            this.SearchBtn.Text = "Search";
            this.SearchBtn.UseVisualStyleBackColor = true;
            this.SearchBtn.Click += new System.EventHandler(this.SearchBtn_Click);
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(90, 322);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(412, 22);
            this.textBox8.TabIndex = 28;
            // 
            // label9
            // 
            this.label9.Location = new System.Drawing.Point(14, 322);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(70, 33);
            this.label9.TabIndex = 27;
            this.label9.Text = "Search";
            // 
            // Subscriptions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(1146, 810);
            this.Controls.Add(this.ResetToDefault);
            this.Controls.Add(this.textBox9);
            this.Controls.Add(this.Column);
            this.Controls.Add(this.SearchBtn);
            this.Controls.Add(this.textBox8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Export);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.AllData);
            this.Name = "Subscriptions";
            this.Text = "Subscriptions";
            this.Load += new System.EventHandler(this.Subscriptions_Load);
            ((System.ComponentModel.ISupportInitialize)(this.AllData)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.DataGridViewButtonColumn Delete;

        private System.Windows.Forms.Button ResetToDefault;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.Label Column;
        private System.Windows.Forms.Button SearchBtn;

        private System.Windows.Forms.Button button1;

        private System.Windows.Forms.Button Export;

        private System.Windows.Forms.ComboBox comboBox2;

        private System.Windows.Forms.ComboBox comboBox1;

        private System.Windows.Forms.TextBox textBox11;
        private System.Windows.Forms.Label label1;

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBox10;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button EditRec;
        private System.Windows.Forms.Button Back;
        private System.Windows.Forms.Button SaveRec;
        private System.Windows.Forms.Button NewRec;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label11;

        private System.Windows.Forms.DataGridView AllData;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.Label label9;

        #endregion
    }
}