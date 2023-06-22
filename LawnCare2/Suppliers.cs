using System;
using System.Drawing;
using System.Windows.Forms;

namespace LawnCare2
{
    public partial class Suppliers : Form
    {
        public Suppliers()
        {
            InitializeComponent();
        }

        private void Suppliers_Load(object sender, EventArgs e)
        {
            textBox8.Text = "Supplier ID";
            if (CommonFunctions.GlobalRoles.role == "supplier")
            {
                groupBox1.Visible = false;

            }
            CommonFunctions.LoadDataGrid(AllData, "Supplier");
        }

        private void SaveRec_Click(object sender, EventArgs e)
        {
            string query = "INSERT INTO Supplier(`Supplier First Name`, `Supplier Last Name`, `Supplier Phone Number`, `Supplier Email`, `Supplier Address`, `Supplier city`, `Supplier Zipcode`, `Equipment Supplied`, `Supplier id`, `Cost Of Equipment`)" +
                           "VALUES ('"+textBox1.Text+"','"+textBox6.Text+"','"+textBox5.Text+"','"+textBox4.Text+"','"+textBox3.Text+"','"+textBox2.Text+"','"+textBox7.Text+"','"+textBox9.Text+"','"+textBox10.Text+"', '"+textBox11.Text+"')";
            CommonFunctions.Insert(query);
            CommonFunctions.LoadDataGrid(AllData, "Supplier");
        }

        private void Back_Click(object sender, EventArgs e)
        {
            new Form1().Show();
            this.Hide();
        }

        private void NewRec_Click(object sender, EventArgs e)
        {
            TextBox[] textBoxes = { textBox1, textBox2, textBox3, textBox4, textBox5, textBox6, textBox6, textBox7, textBox8, textBox9, textBox10};
            CommonFunctions.ResetTextBoxt(textBoxes);
        }

        private void Export_Click(object sender, EventArgs e)
        {
            CommonFunctions.ExportToCsv(AllData, "Suppliers");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new Form1().Show();
            this.Hide();
        }

        private void EditRec_Click(object sender, EventArgs e)
        {
            string query = "UPDATE Supplier SET `Supplier First Name`='" + textBox1.Text + "', `Supplier Last Name`='" +
                           textBox6.Text + "', `Supplier Phone Number`='" + textBox5.Text + "', `Supplier Email`='" +
                           textBox4.Text + "', `Supplier Address`='" + textBox3.Text + "', `Supplier city`='" +
                           textBox2.Text + "', `Supplier Zipcode`='" + textBox7.Text + "', `Equipment Supplied`='" +
                           textBox9.Text + "', `Supplier id`='" + textBox10.Text + "', `Cost Of Equipment`='" +
                           textBox11.Text + "' WHERE `Supplier id`='" + textBox10.Text + "' ";
            CommonFunctions.Insert(query);
            CommonFunctions.LoadDataGrid(AllData, "Supplier");
        }

        private void SearchBtn_Click(object sender, EventArgs e)
        {
            string query = "SELECT * FROM Supplier WHERE `ID`="+textBox12.Text+"";
            CommonFunctions.Search(AllData, query);
        }

        private void ResetToDefault_Click(object sender, EventArgs e)
        {
            TextBox[] textBoxes = { textBox12 };
            CommonFunctions.ResetTextBoxt(textBoxes);
            CommonFunctions.LoadDataGrid(AllData, "Supplier");
        }

        private void AllData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (AllData.Columns[e.ColumnIndex].Name == "Delete")
            {
                DataGridViewRow row = AllData.Rows[AllData.CurrentRow.Index] ;
                string query = "DELETE FROM Supplier WHERE `ID`="+Int32.Parse(row.Cells[1].Value.ToString());
                CommonFunctions.Delete(AllData, query);
                CommonFunctions.LoadDataGrid(AllData, "Supplier");
            }
        }
    }
}