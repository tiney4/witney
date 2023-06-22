using System.ComponentModel;

namespace LawnCare2
{
    partial class Services
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

        private void InitializeComponent()
{
    this.EditRec = new System.Windows.Forms.Button();
    this.Back = new System.Windows.Forms.Button();
    this.SaveRec = new System.Windows.Forms.Button();
    this.NewRec = new System.Windows.Forms.Button();
    this.textBox6 = new System.Windows.Forms.TextBox();
    this.textBox5 = new System.Windows.Forms.TextBox();
    this.textBox4 = new System.Windows.Forms.TextBox();
    this.AllData = new System.Windows.Forms.DataGridView();
    this.Delete = new System.Windows.Forms.DataGridViewButtonColumn();
    this.groupBox1 = new System.Windows.Forms.GroupBox();
    this.comboBox1 = new System.Windows.Forms.ComboBox();
    this.textBox1 = new System.Windows.Forms.TextBox();
    this.label7 = new System.Windows.Forms.Label();
    this.label6 = new System.Windows.Forms.Label();
    this.label5 = new System.Windows.Forms.Label();
    this.label4 = new System.Windows.Forms.Label();
    this.label2 = new System.Windows.Forms.Label();
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
    // EditRec
    // 
    this.EditRec.Location = new System.Drawing.Point(331, 221);
    this.EditRec.Name = "EditRec";
    this.EditRec.Size = new System.Drawing.Size(111, 59);
    this.EditRec.TabIndex = 17;
    this.EditRec.Text = "Update";
    this.EditRec.UseVisualStyleBackColor = true;
    this.EditRec.Click += new System.EventHandler(this.EditRec_Click);
    // 
    // Back
    // 
    this.Back.Location = new System.Drawing.Point(483, 221);
    this.Back.Name = "Back";
    this.Back.Size = new System.Drawing.Size(111, 59);
    this.Back.TabIndex = 16;
    this.Back.Text = "Cancel";
    this.Back.UseVisualStyleBackColor = true;
    this.Back.Click += new System.EventHandler(this.Back_Click);
    // 
    // SaveRec
    // 
    this.SaveRec.Location = new System.Drawing.Point(635, 221);
    this.SaveRec.Name = "SaveRec";
    this.SaveRec.Size = new System.Drawing.Size(111, 59);
    this.SaveRec.TabIndex = 15;
    this.SaveRec.Text = "Save";
    this.SaveRec.UseVisualStyleBackColor = true;
    this.SaveRec.Click += new System.EventHandler(this.SaveRec_Click);
    // 
    // NewRec
    // 
    this.NewRec.Location = new System.Drawing.Point(191, 221);
    this.NewRec.Name = "NewRec";
    this.NewRec.Size = new System.Drawing.Size(111, 59);
    this.NewRec.TabIndex = 14;
    this.NewRec.Text = "New";
    this.NewRec.UseVisualStyleBackColor = true;
    this.NewRec.Click += new System.EventHandler(this.NewRec_Click);
    // 
    // textBox6
    // 
    this.textBox6.Location = new System.Drawing.Point(156, 77);
    this.textBox6.Name = "textBox6";
    this.textBox6.Size = new System.Drawing.Size(660, 22);
    this.textBox6.TabIndex = 11;
    // 
    // textBox5
    // 
    this.textBox5.Location = new System.Drawing.Point(156, 110);
    this.textBox5.Name = "textBox5";
    this.textBox5.Size = new System.Drawing.Size(660, 22);
    this.textBox5.TabIndex = 10;
    // 
    // textBox4
    // 
    this.textBox4.Location = new System.Drawing.Point(156, 143);
    this.textBox4.Name = "textBox4";
    this.textBox4.Size = new System.Drawing.Size(660, 22);
    this.textBox4.TabIndex = 9;
    // 
    // AllData
    // 
    this.AllData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
    this.AllData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { this.Delete });
    this.AllData.Location = new System.Drawing.Point(12, 346);
    this.AllData.Name = "AllData";
    this.AllData.RowTemplate.Height = 24;
    this.AllData.Size = new System.Drawing.Size(1133, 322);
    this.AllData.TabIndex = 18;
    this.AllData.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataCellClicked);
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
    this.groupBox1.Controls.Add(this.comboBox1);
    this.groupBox1.Controls.Add(this.EditRec);
    this.groupBox1.Controls.Add(this.Back);
    this.groupBox1.Controls.Add(this.SaveRec);
    this.groupBox1.Controls.Add(this.NewRec);
    this.groupBox1.Controls.Add(this.textBox6);
    this.groupBox1.Controls.Add(this.textBox5);
    this.groupBox1.Controls.Add(this.textBox4);
    this.groupBox1.Controls.Add(this.textBox1);
    this.groupBox1.Controls.Add(this.label7);
    this.groupBox1.Controls.Add(this.label6);
    this.groupBox1.Controls.Add(this.label5);
    this.groupBox1.Controls.Add(this.label4);
    this.groupBox1.Controls.Add(this.label2);
    this.groupBox1.Location = new System.Drawing.Point(12, 7);
    this.groupBox1.Name = "groupBox1";
    this.groupBox1.Size = new System.Drawing.Size(1133, 296);
    this.groupBox1.TabIndex = 17;
    this.groupBox1.TabStop = false;
    this.groupBox1.Text = "Services";
    // 
    // comboBox1
    // 
    this.comboBox1.FormattingEnabled = true;
    this.comboBox1.Location = new System.Drawing.Point(156, 179);
    this.comboBox1.Name = "comboBox1";
    this.comboBox1.Size = new System.Drawing.Size(660, 24);
    this.comboBox1.TabIndex = 18;
    // 
    // textBox1
    // 
    this.textBox1.Location = new System.Drawing.Point(156, 44);
    this.textBox1.Name = "textBox1";
    this.textBox1.Size = new System.Drawing.Size(660, 22);
    this.textBox1.TabIndex = 6;
    // 
    // label7
    // 
    this.label7.Location = new System.Drawing.Point(23, 80);
    this.label7.Name = "label7";
    this.label7.Size = new System.Drawing.Size(117, 33);
    this.label7.TabIndex = 5;
    this.label7.Text = "Scheduled Time";
    // 
    // label6
    // 
    this.label6.Location = new System.Drawing.Point(23, 113);
    this.label6.Name = "label6";
    this.label6.Size = new System.Drawing.Size(117, 33);
    this.label6.TabIndex = 4;
    this.label6.Text = "Service Cost";
    // 
    // label5
    // 
    this.label5.Location = new System.Drawing.Point(23, 146);
    this.label5.Name = "label5";
    this.label5.Size = new System.Drawing.Size(117, 33);
    this.label5.TabIndex = 3;
    this.label5.Text = "Maintainace Cost";
    // 
    // label4
    // 
    this.label4.Location = new System.Drawing.Point(23, 179);
    this.label4.Name = "label4";
    this.label4.Size = new System.Drawing.Size(93, 33);
    this.label4.TabIndex = 2;
    this.label4.Text = "Customer ID";
    // 
    // label2
    // 
    this.label2.Location = new System.Drawing.Point(23, 47);
    this.label2.Name = "label2";
    this.label2.Size = new System.Drawing.Size(107, 33);
    this.label2.TabIndex = 0;
    this.label2.Text = "Service Name";
    // 
    // Export
    // 
    this.Export.Location = new System.Drawing.Point(999, 674);
    this.Export.Name = "Export";
    this.Export.Size = new System.Drawing.Size(111, 59);
    this.Export.TabIndex = 19;
    this.Export.Text = "Export";
    this.Export.UseVisualStyleBackColor = true;
    this.Export.Click += new System.EventHandler(this.Export_Click);
    // 
    // button1
    // 
    this.button1.Location = new System.Drawing.Point(857, 674);
    this.button1.Name = "button1";
    this.button1.Size = new System.Drawing.Size(111, 59);
    this.button1.TabIndex = 19;
    this.button1.Text = "Back";
    this.button1.UseVisualStyleBackColor = true;
    this.button1.Click += new System.EventHandler(this.button1_Click);
    // 
    // ResetToDefault
    // 
    this.ResetToDefault.Location = new System.Drawing.Point(1065, 310);
    this.ResetToDefault.Name = "ResetToDefault";
    this.ResetToDefault.Size = new System.Drawing.Size(82, 22);
    this.ResetToDefault.TabIndex = 30;
    this.ResetToDefault.Text = "Reset";
    this.ResetToDefault.UseVisualStyleBackColor = true;
    this.ResetToDefault.Click += new System.EventHandler(this.ResetToDefault_Click);
    // 
    // textBox9
    // 
    this.textBox9.Location = new System.Drawing.Point(582, 308);
    this.textBox9.Name = "textBox9";
    this.textBox9.Size = new System.Drawing.Size(375, 22);
    this.textBox9.TabIndex = 29;
    // 
    // Column
    // 
    this.Column.Location = new System.Drawing.Point(506, 308);
    this.Column.Name = "Column";
    this.Column.Size = new System.Drawing.Size(70, 33);
    this.Column.TabIndex = 28;
    this.Column.Text = "Column";
    // 
    // SearchBtn
    // 
    this.SearchBtn.Location = new System.Drawing.Point(977, 310);
    this.SearchBtn.Name = "SearchBtn";
    this.SearchBtn.Size = new System.Drawing.Size(82, 22);
    this.SearchBtn.TabIndex = 27;
    this.SearchBtn.Text = "Search";
    this.SearchBtn.UseVisualStyleBackColor = true;
    this.SearchBtn.Click += new System.EventHandler(this.SearchBtn_Click);
    // 
    // textBox8
    // 
    this.textBox8.Location = new System.Drawing.Point(88, 310);
    this.textBox8.Name = "textBox8";
    this.textBox8.Size = new System.Drawing.Size(412, 22);
    this.textBox8.TabIndex = 26;
    // 
    // label9
    // 
    this.label9.Location = new System.Drawing.Point(12, 310);
    this.label9.Name = "label9";
    this.label9.Size = new System.Drawing.Size(70, 33);
    this.label9.TabIndex = 25;
    this.label9.Text = "Search";
    // 
    // Services
    // 
    this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
    this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
    this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
    this.ClientSize = new System.Drawing.Size(1151, 738);
    this.Controls.Add(this.ResetToDefault);
    this.Controls.Add(this.textBox9);
    this.Controls.Add(this.Column);
    this.Controls.Add(this.SearchBtn);
    this.Controls.Add(this.textBox8);
    this.Controls.Add(this.label9);
    this.Controls.Add(this.button1);
    this.Controls.Add(this.Export);
    this.Controls.Add(this.AllData);
    this.Controls.Add(this.groupBox1);
    this.Name = "Services";
    this.Text = "Services";
    this.Load += new System.EventHandler(this.Services_Load);
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

        private System.Windows.Forms.ComboBox comboBox1;

        private System.Windows.Forms.Button EditRec;
        private System.Windows.Forms.Button Back;
        private System.Windows.Forms.Button SaveRec;
        private System.Windows.Forms.Button NewRec;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.DataGridView AllData;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label9;

        #endregion
    }
}