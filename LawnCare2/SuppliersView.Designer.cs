using System.ComponentModel;

namespace LawnCare2
{
    partial class SuppliersView
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
            this.button1 = new System.Windows.Forms.Button();
            this.Export = new System.Windows.Forms.Button();
            this.AllData = new System.Windows.Forms.DataGridView();
            this.ResetToDefault = new System.Windows.Forms.Button();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.Column = new System.Windows.Forms.Label();
            this.SearchBtn = new System.Windows.Forms.Button();
            this.textBox12 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.AllData)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(866, 737);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(111, 59);
            this.button1.TabIndex = 34;
            this.button1.Text = "Back";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Export
            // 
            this.Export.Location = new System.Drawing.Point(1024, 737);
            this.Export.Name = "Export";
            this.Export.Size = new System.Drawing.Size(111, 59);
            this.Export.TabIndex = 33;
            this.Export.Text = "Export";
            this.Export.UseVisualStyleBackColor = true;
            this.Export.Click += new System.EventHandler(this.Export_Click);
            // 
            // AllData
            // 
            this.AllData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AllData.Location = new System.Drawing.Point(3, 40);
            this.AllData.Name = "AllData";
            this.AllData.RowTemplate.Height = 24;
            this.AllData.Size = new System.Drawing.Size(1133, 691);
            this.AllData.TabIndex = 32;
            // 
            // ResetToDefault
            // 
            this.ResetToDefault.Location = new System.Drawing.Point(1058, 6);
            this.ResetToDefault.Name = "ResetToDefault";
            this.ResetToDefault.Size = new System.Drawing.Size(82, 22);
            this.ResetToDefault.TabIndex = 40;
            this.ResetToDefault.Text = "Reset";
            this.ResetToDefault.UseVisualStyleBackColor = true;
            this.ResetToDefault.Click += new System.EventHandler(this.ResetToDefault_Click);
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(575, 4);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(375, 22);
            this.textBox8.TabIndex = 39;
            // 
            // Column
            // 
            this.Column.Location = new System.Drawing.Point(499, 4);
            this.Column.Name = "Column";
            this.Column.Size = new System.Drawing.Size(70, 33);
            this.Column.TabIndex = 38;
            this.Column.Text = "Column";
            // 
            // SearchBtn
            // 
            this.SearchBtn.Location = new System.Drawing.Point(970, 6);
            this.SearchBtn.Name = "SearchBtn";
            this.SearchBtn.Size = new System.Drawing.Size(82, 22);
            this.SearchBtn.TabIndex = 37;
            this.SearchBtn.Text = "Search";
            this.SearchBtn.UseVisualStyleBackColor = true;
            this.SearchBtn.Click += new System.EventHandler(this.SearchBtn_Click);
            // 
            // textBox12
            // 
            this.textBox12.Location = new System.Drawing.Point(81, 6);
            this.textBox12.Name = "textBox12";
            this.textBox12.Size = new System.Drawing.Size(412, 22);
            this.textBox12.TabIndex = 36;
            // 
            // label9
            // 
            this.label9.Location = new System.Drawing.Point(5, 6);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(70, 33);
            this.label9.TabIndex = 35;
            this.label9.Text = "Search";
            // 
            // SuppliersView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(1140, 799);
            this.Controls.Add(this.ResetToDefault);
            this.Controls.Add(this.textBox8);
            this.Controls.Add(this.Column);
            this.Controls.Add(this.SearchBtn);
            this.Controls.Add(this.textBox12);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Export);
            this.Controls.Add(this.AllData);
            this.Name = "SuppliersView";
            this.Text = "SuppliersView";
            this.Load += new System.EventHandler(this.SuppliersView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.AllData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Button ResetToDefault;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.Label Column;
        private System.Windows.Forms.Button SearchBtn;
        private System.Windows.Forms.TextBox textBox12;
        private System.Windows.Forms.Label label9;

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button Export;
        private System.Windows.Forms.DataGridView AllData;

        #endregion
    }
}