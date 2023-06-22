using System;
using System.Windows.Forms;

namespace LawnCare2
{
    public partial class Employee : Form
    {
        public Employee()
        {
            InitializeComponent();
        }

        private void Employee_Load(object sender, EventArgs e)
        {
            textBox11.Text = "Employee ID";
            if (CommonFunctions.GlobalRoles.role == "employee")
            {
                groupBox1.Visible = false;
            }
            CommonFunctions.LoadDataGrid(AllData, "Employees");
        }

        private void SaveRec_Click(object sender, EventArgs e)
        {
            string query = "INSERT INTO Employees(`Employee First Name`,`Employee Last Name`, `Employee phone number`, `Employee Zip code`, `Email`, `Age`, `Gender`, `Address`, `City`,`salaries`)" +
                           " VALUES ('"+textBox1.Text+"','"+textBox6.Text+"','"+textBox5.Text+"','"+textBox7.Text+"','"+textBox4.Text+"','"+textBox9.Text+"','"+comboBox1.Text+"','"+textBox3.Text+"','"+textBox2.Text+"', '"+textBox10.Text+"')";
            CommonFunctions.Insert(query);
            CommonFunctions.LoadDataGrid(AllData, "Employees");
        }

        private void Back_Click(object sender, EventArgs e)
        {
            new Form1().Show();
            this.Hide();
        }

        private void NewRec_Click(object sender, EventArgs e)
        {
            TextBox[] textBoxes = { textBox1, textBox2, textBox3, textBox4, textBox5, textBox6, textBox6, textBox7,  textBox9};
            CommonFunctions.ResetTextBoxt(textBoxes);
        }

        private void Export_Click(object sender, EventArgs e)
        {
            CommonFunctions.ExportToCsv(AllData, "Employees");
        }

        private void CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new Form1().Show();
            this.Hide();
        }

        private void EditRec_Click(object sender, EventArgs e)
        {
            string query = "UPDATE Employees SET `Employee First Name`='" + textBox1.Text + "',`Employee Last Name`='" +
                           textBox6.Text + "', `Employee phone number`='" + textBox5.Text + "', `Employee Zip code`='" +
                           textBox7.Text + "', `Email`='" + textBox4.Text + "', `Age`='" + textBox9.Text +
                           "', `Gender`='" + comboBox1.Text + "', `Address`='" + textBox3.Text + "', `City`='" +
                           textBox2.Text + "',`salaries`'" + textBox10.Text + "' WHERE `Employee phone number`='" +
                           textBox5.Text + "' ";
            CommonFunctions.Insert(query);
            CommonFunctions.LoadDataGrid(AllData, "Employees");
        }

        private void SearchBtn_Click(object sender, EventArgs e)
        {
            string query = "SELECT * FROM Employees WHERE `ID`="+textBox12.Text+"";
            CommonFunctions.Search(AllData, query);
        }

        private void ResetToDefault_Click(object sender, EventArgs e)
        {
            TextBox[] textBoxes = {  textBox12 };
            CommonFunctions.ResetTextBoxt(textBoxes);
            CommonFunctions.LoadDataGrid(AllData, "Employees");
            
        }

        private void AllData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (AllData.Columns[e.ColumnIndex].Name == "Delete")
            {
                DataGridViewRow row = AllData.Rows[AllData.CurrentRow.Index] ;
                string query = "DELETE FROM Employees WHERE `ID`="+Int32.Parse(row.Cells[1].Value.ToString());
                CommonFunctions.Delete(AllData, query);
                CommonFunctions.LoadDataGrid(AllData, "Employees");
            }
        }
    }
}