namespace LawnCare2
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
            this.Customer = new System.Windows.Forms.Button();
            this.ServicesBtn = new System.Windows.Forms.Button();
            this.SubscriptionBtn = new System.Windows.Forms.Button();
            this.EmployeeBtn = new System.Windows.Forms.Button();
            this.SuppliersBtn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Customer
            // 
            this.Customer.Location = new System.Drawing.Point(333, 72);
            this.Customer.Name = "Customer";
            this.Customer.Size = new System.Drawing.Size(196, 42);
            this.Customer.TabIndex = 0;
            this.Customer.Text = "Customers";
            this.Customer.UseVisualStyleBackColor = true;
            this.Customer.Click += new System.EventHandler(this.Customer_Click);
            // 
            // ServicesBtn
            // 
            this.ServicesBtn.Location = new System.Drawing.Point(333, 226);
            this.ServicesBtn.Name = "ServicesBtn";
            this.ServicesBtn.Size = new System.Drawing.Size(196, 42);
            this.ServicesBtn.TabIndex = 1;
            this.ServicesBtn.Text = "Services";
            this.ServicesBtn.UseVisualStyleBackColor = true;
            this.ServicesBtn.Click += new System.EventHandler(this.ServicesBtn_Click);
            // 
            // SubscriptionBtn
            // 
            this.SubscriptionBtn.Location = new System.Drawing.Point(333, 305);
            this.SubscriptionBtn.Name = "SubscriptionBtn";
            this.SubscriptionBtn.Size = new System.Drawing.Size(196, 42);
            this.SubscriptionBtn.TabIndex = 2;
            this.SubscriptionBtn.Text = "Subscriptions";
            this.SubscriptionBtn.UseVisualStyleBackColor = true;
            this.SubscriptionBtn.Click += new System.EventHandler(this.SubscriptionBtn_Click);
            // 
            // EmployeeBtn
            // 
            this.EmployeeBtn.Location = new System.Drawing.Point(333, 142);
            this.EmployeeBtn.Name = "EmployeeBtn";
            this.EmployeeBtn.Size = new System.Drawing.Size(196, 42);
            this.EmployeeBtn.TabIndex = 3;
            this.EmployeeBtn.Text = "Employee";
            this.EmployeeBtn.UseVisualStyleBackColor = true;
            this.EmployeeBtn.Click += new System.EventHandler(this.EmployeeBtn_Click);
            // 
            // SuppliersBtn
            // 
            this.SuppliersBtn.Location = new System.Drawing.Point(333, 389);
            this.SuppliersBtn.Name = "SuppliersBtn";
            this.SuppliersBtn.Size = new System.Drawing.Size(196, 42);
            this.SuppliersBtn.TabIndex = 4;
            this.SuppliersBtn.Text = "Suppliers";
            this.SuppliersBtn.UseVisualStyleBackColor = true;
            this.SuppliersBtn.Click += new System.EventHandler(this.SuppliersBtn_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Red;
            this.button1.Location = new System.Drawing.Point(333, 467);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(196, 42);
            this.button1.TabIndex = 5;
            this.button1.Text = "QUIT APPLICATION";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(269, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(344, 42);
            this.label1.TabIndex = 6;
            this.label1.Text = "Cleveland lawn care business ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(800, 519);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.SuppliersBtn);
            this.Controls.Add(this.EmployeeBtn);
            this.Controls.Add(this.SubscriptionBtn);
            this.Controls.Add(this.ServicesBtn);
            this.Controls.Add(this.Customer);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Label label1;

        private System.Windows.Forms.Button button1;

        private System.Windows.Forms.Button ServicesBtn;
        private System.Windows.Forms.Button SubscriptionBtn;
        private System.Windows.Forms.Button EmployeeBtn;
        private System.Windows.Forms.Button SuppliersBtn;

        private System.Windows.Forms.Button Customer;

        #endregion
    }
}