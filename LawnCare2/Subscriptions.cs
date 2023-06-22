using System;
using System.Windows.Forms;

namespace LawnCare2
{
    public partial class Subscriptions : Form
    {
        public Subscriptions()
        {
            InitializeComponent();
        }

        private void NewRec_Click(object sender, EventArgs e)
        {
            TextBox[] textBoxes = { textBox1, textBox3, textBox2, textBox5, textBox6, textBox6, textBox7, textBox8, textBox11, textBox10};
            CommonFunctions.ResetTextBoxt(textBoxes);
        }

        private void Back_Click(object sender, EventArgs e)
        {
            new Form1().Show();
            this.Hide();
        }

        private void SaveRec_Click(object sender, EventArgs e)
        {
            string query = "INSERT INTO Subscription(`Subscription ID`, `Tax`, `Subscription Validity`,`Subscription plan`, `Payment date`, `Payment amount`, `Total payment`, `Customer id`, `Customer First Name`, `Customer Last Name`)" +
                           " VALUES ('"+textBox1.Text+"','"+textBox6.Text+"','"+textBox5.Text+"','"+comboBox1.Text+"','"+textBox3.Text+"','"+textBox2.Text+"','"+textBox7.Text+"','"+comboBox2.Text+"','"+textBox10.Text+"','"+textBox11.Text+"'  )";
            CommonFunctions.Insert(query);
            CommonFunctions.LoadDataGrid(AllData, "Subscription");

        }

        private void Subscriptions_Load(object sender, EventArgs e)
        {
            textBox9.Text = "Subscription ID";
            if (CommonFunctions.GlobalRoles.role == "supplier")
            {
                groupBox1.Visible = false;
            }
            CommonFunctions.LoadDataGrid(AllData, "Subscription");
            CommonFunctions.LoadComboBox(comboBox2, "Customer");
            comboBox2.DisplayMember = "Customer Id";
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBox10.Text = CommonFunctions.DataReader("Customer", Convert.ToInt32(comboBox2.Text), "firstname");
            textBox11.Text = CommonFunctions.DataReader("Customer", Convert.ToInt32(comboBox2.Text), "lastname");
        }

        private void Export_Click(object sender, EventArgs e)
        {
            CommonFunctions.ExportToCsv(AllData, "Subscriptions");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new Form1().Show();
            this.Hide();
        }

        private void EditRec_Click(object sender, EventArgs e)
        {
            string query = "UPDATE Subscription SET `Subscription ID`='" + textBox1.Text + "', `Tax`='" +
                           textBox6.Text + "', `Subscription Validity`='" + textBox5.Text + "',`Subscription plan`='" +
                           comboBox1.Text + "', `Payment date`='" + textBox3.Text + "', `Payment amount`='" +
                           textBox2.Text + "', `Total payment`='" + textBox7.Text + "', `Customer id`='" +
                           comboBox2.Text + "', `Customer First Name`='" + textBox10.Text +
                           "', `Customer Last Name`='" + textBox11.Text + "' WHERE `Subscription ID`='" +
                           textBox1.Text + "'";
            CommonFunctions.Insert(query);
            CommonFunctions.LoadDataGrid(AllData, "Subscription");
        }

        private void SearchBtn_Click(object sender, EventArgs e)
        {
            string query = "SELECT * FROM Subscription WHERE `Subscription ID`='"+textBox8.Text+"'";
            CommonFunctions.Search(AllData, query);
        }

        private void ResetToDefault_Click(object sender, EventArgs e)
        {
            TextBox[] textBoxes = {  textBox8 };
            CommonFunctions.ResetTextBoxt(textBoxes);
            CommonFunctions.LoadDataGrid(AllData, "Subscription");
        }

        private void AllData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (AllData.Columns[e.ColumnIndex].Name == "Delete")
            {
                DataGridViewRow row = AllData.Rows[AllData.CurrentRow.Index] ;
                string query = "DELETE FROM Subscription WHERE `ID`="+Int32.Parse(row.Cells[1].Value.ToString());
                CommonFunctions.Delete(AllData, query);
                CommonFunctions.LoadDataGrid(AllData, "Subscription");
            }
        }
    }
}