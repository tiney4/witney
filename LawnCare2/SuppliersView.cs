using System;
using System.Windows.Forms;

namespace LawnCare2
{
    public partial class SuppliersView : Form
    {
        public SuppliersView()
        {
            InitializeComponent();
        }

        private void SuppliersView_Load(object sender, EventArgs e)
        {
            textBox8.Text = "Supplier ID";
            CommonFunctions.LoadDataGrid(AllData, "Supplier");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new Form1().Show();
            this.Hide();
        }

        private void Export_Click(object sender, EventArgs e)
        {
            CommonFunctions.ExportToCsv(AllData, "Suppliers");
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
    }
}