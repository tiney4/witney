using System;
using System.Windows.Forms;

namespace LawnCare2
{
    public partial class ServicesViewSuppliers : Form
    {
        public ServicesViewSuppliers()
        {
            InitializeComponent();
        }

        private void ServicesViewSuppliers_Load(object sender, EventArgs e)
        {
            textBox9.Text = "Service ID";
            CommonFunctions.LoadDataGrid(AllData, "Services");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new Form1().Show();
            this.Hide();
        }

        private void Export_Click(object sender, EventArgs e)
        {
            CommonFunctions.ExportToCsv(AllData, "Services");
        }

        private void SearchBtn_Click(object sender, EventArgs e)
        {
            string query = "SELECT * FROM Services WHERE `ID`="+textBox8.Text+"";
            CommonFunctions.Search(AllData, query);
        }

        private void ResetToDefault_Click(object sender, EventArgs e)
        {
            TextBox[] textBoxes = { textBox9, textBox8 };
            CommonFunctions.ResetTextBoxt(textBoxes);
            CommonFunctions.LoadDataGrid(AllData, "Services");
        }
    }
}