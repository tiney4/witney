using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LawnCare2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Customer_Click(object sender, EventArgs e)
        {
           
                new Customer().Show();
                this.Hide();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var role = CommonFunctions.GlobalRoles.role;
            Customer.Anchor = AnchorStyles.Top;
            EmployeeBtn.Anchor = AnchorStyles.Top;
            ServicesBtn.Anchor = AnchorStyles.Top;
            SubscriptionBtn.Anchor = AnchorStyles.Top;
            SuppliersBtn.Anchor = AnchorStyles.Top;
            label1.Anchor = AnchorStyles.Top;
            button1.Anchor = AnchorStyles.Top;
            if (CommonFunctions.GlobalRoles.role == "supplier")
            {
                Customer.Visible = false;
                EmployeeBtn.Visible = false;
                SubscriptionBtn.Visible = false;

            }else if (CommonFunctions.GlobalRoles.role == "employee")
            {
                EmployeeBtn.Visible = false;
            }
        }

        private void EmployeeBtn_Click(object sender, EventArgs e)
        {
            new Employee().Show();
            this.Hide();
        }

        private void ServicesBtn_Click(object sender, EventArgs e)
        {
            if (CommonFunctions.GlobalRoles.role != "supplier")
            {
                new Services().Show();
                this.Hide();
            }
            else
            {
                new ServicesViewSuppliers().Show();
                this.Hide();
            }
        }

        private void SubscriptionBtn_Click(object sender, EventArgs e)
        {
            if (CommonFunctions.GlobalRoles.role == "supplier")
            {
                SubscriptionBtn.Visible = false;
                
            }
            else
            {
                SubscriptionBtn.Visible = true;
                new Subscriptions().Show();
                this.Hide();
            }
            
        }

        private void SuppliersBtn_Click(object sender, EventArgs e)
        {
            if (CommonFunctions.GlobalRoles.role == "supplier")
            {
                new SuppliersView().Show();
                this.Hide();
            }
            else
            {
                new Suppliers().Show();
                this.Hide();
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}