using System;
using System.Windows.Forms;

namespace LawnCare2
{
    public partial class Customer : Form
    {
        public Customer()
        {
            InitializeComponent();
        }

        private void SaveRec_Click(object sender, EventArgs e)
        {
            string query = "INSERT INTO Customer(`Customer First Name`,`Customer Last Name`, `Cust_PhoneNumber`, `Cust_Email`, `Cust_Address`, `Cust_City`, `Cust_ZipCode`) VALUES ('"+textBox1.Text+"','"+textBox6.Text+"','"+textBox5.Text+"','"+textBox4.Text+"','"+textBox3.Text+"','"+textBox2.Text+"','"+textBox7.Text+"')";
            CommonFunctions.Insert(query);
            CommonFunctions.LoadDataGrid(AllData, "Customer");
        }

        private void Customer_Load(object sender, EventArgs e)
        {
            textBox9.Text = "Customer Id";
            
            CommonFunctions.LoadDataGrid(AllData, "Customer");
           
        }

        private void NewRec_Click(object sender, EventArgs e)
        {
            TextBox[] textBoxes = { textBox1, textBox2, textBox3, textBox4, textBox5, textBox6, textBox6, textBox7};
            CommonFunctions.ResetTextBoxt(textBoxes);
        }

        private void Back_Click(object sender, EventArgs e)
        {
            new Form1().Show();
            this.Hide();
        }

        private void Export_Click(object sender, EventArgs e)
        {
            CommonFunctions.ExportToCsv(AllData, "Customers");
        }

        private void EditRec_Click(object sender, EventArgs e)
        {
            string query =  "UPDATE Customer SET `Customer First Name`='"+textBox1.Text+"',`Customer Last Name`='"+textBox6.Text+"', `Cust_PhoneNumber`='"+textBox5.Text+"', `Cust_Email`='"+textBox4.Text+"', `Cust_Address`='"+textBox3.Text+"', `Cust_City`='"+textBox2.Text+"', `Cust_ZipCode`='"+textBox7.Text+"' WHERE `Cust_PhoneNumber`='"+textBox5.Text+"' ";
            CommonFunctions.Insert(query);
            CommonFunctions.LoadDataGrid(AllData, "Customer");
        }

        private void SearchBtn_Click(object sender, EventArgs e)
        {
            
            string query = "SELECT * FROM Customer WHERE `Customer Id`="+textBox8.Text+"";
            CommonFunctions.Search(AllData, query );
        }

        private void ResetToDefault_Click(object sender, EventArgs e)
        {
            textBox8.Clear();
            CommonFunctions.LoadDataGrid(AllData, "Customer");
        }

        private void AllData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (AllData.Columns[e.ColumnIndex].Name == "Delete")
            {
                DataGridViewRow row = AllData.Rows[AllData.CurrentRow.Index] ;
                string query = "DELETE FROM Customer WHERE `Customer Id`="+Int32.Parse(row.Cells[1].Value.ToString());
                CommonFunctions.Delete(AllData, query);
                CommonFunctions.LoadDataGrid(AllData, "Customer");
            }
        }
    }
}