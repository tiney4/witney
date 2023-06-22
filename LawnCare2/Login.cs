using System;
using System.Data.OleDb;
using System.Drawing;
using System.Windows.Forms;

namespace LawnCare2
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private OleDbConnection _db = new OleDbConnection(CommonFunctions.ConnectionString);

        


        private void Loginbtn_Click(object sender, EventArgs e)
        {
            try
            {
                string query = "SELECT * FROM Login WHERE email='"+email.Text+"' AND password='"+password.Text+"'";
                _db.Open();
                var cmd = new OleDbCommand(query, _db);
                var dataReader = cmd.ExecuteReader();
            
                if (dataReader.Read())
                {
                    MessageBox.Show("Success", "You have Logged in successfully", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CommonFunctions.GlobalRoles.role = dataReader["role"].ToString();
                    new Form1().Show();
                    this.Hide();
                    dataReader.Close();
                
                }
                else
                {
                    _db.Close();
                    dataReader.Close();
                    MessageBox.Show("Error", "Details do not match", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception exception)
            {
                _db.Close();
                MessageBox.Show(exception.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
        }
    }
}