using System;
using System.Windows.Forms;

namespace LawnCare2
{
    public partial class Services : Form
    {
        public Services()
        {
            InitializeComponent();
        }

        private void SaveRec_Click(object sender, EventArgs e)
        {
            string query = "INSERT INTO Services(`Service name`,`Scheduled time`,`Service cost`,`Maintenance cost`,`Customer id`) VALUES ('"+textBox1.Text+"','"+textBox6.Text+"','"+textBox5.Text+"','"+textBox4.Text+"','"+comboBox1.Text+"')";
            CommonFunctions.Insert(query);
            CommonFunctions.LoadDataGrid(AllData, "Services");
        }

        private void Back_Click(object sender, EventArgs e)
        {
            new Form1().Show();
            this.Hide();
        }

        private void Services_Load(object sender, EventArgs e)
        {
            textBox9.Text = "Service ID";
            if (CommonFunctions.GlobalRoles.role == "supplier")
            {
                groupBox1.Visible = false;
            }
            CommonFunctions.LoadDataGrid(AllData, "Services");
            CommonFunctions.LoadComboBox(comboBox1, "Customer");
            comboBox1.DisplayMember = "Customer Id";
        }

        private void NewRec_Click(object sender, EventArgs e)
        {
            TextBox[] textBoxes = { textBox1,  textBox4, textBox5, textBox6, textBox6,  textBox8};
            CommonFunctions.ResetTextBoxt(textBoxes);
        }

        private void Export_Click(object sender, EventArgs e)
        {
            CommonFunctions.ExportToCsv(AllData, "Services");
        }

        private void DataCellClicked(object sender, DataGridViewCellEventArgs e)
        {
            int currentRow = int.Parse(e.RowIndex.ToString());
            int currentColumnIndex = int.Parse(e.ColumnIndex.ToString());
            var test = AllData.Rows[currentRow].Cells[0].Value.ToString();
            
            
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new Form1().Show();
            this.Hide();
        }

        private void EditRec_Click(object sender, EventArgs e)
        {
            string query = "UPDATE Services SET `Service name`='" + textBox1.Text + "',`Scheduled time`='" +
                           textBox6.Text + "',`Service cost`='" + textBox5.Text + "',`Maintenance cost`='" +
                           textBox4.Text + "',`Customer id`='" + comboBox1.Text + "' WHERE `Service name`='" +
                           textBox1.Text + "'";
                           
            CommonFunctions.Insert(query);
            CommonFunctions.LoadDataGrid(AllData, "Services");
            
        }

        private void SearchBtn_Click(object sender, EventArgs e)
        {
            string query = "SELECT * FROM Services WHERE `ID`="+textBox8.Text+"";
            CommonFunctions.Search(AllData, query);
        }

        private void ResetToDefault_Click(object sender, EventArgs e)
        {
            TextBox[] textBoxes = {  textBox8 };
            CommonFunctions.ResetTextBoxt(textBoxes);
            CommonFunctions.LoadDataGrid(AllData, "Services");
        }

        private void AllData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (AllData.Columns[e.ColumnIndex].Name == "Delete")
            {
                DataGridViewRow row = AllData.Rows[AllData.CurrentRow.Index] ;
                string query = "DELETE FROM Services WHERE `ID`="+Int32.Parse(row.Cells[1].Value.ToString());
                CommonFunctions.Delete(AllData, query);
                CommonFunctions.LoadDataGrid(AllData, "Services");
            }
        }
    }
}