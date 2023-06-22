using System;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel; 

namespace LawnCare2
{
    public class CommonFunctions
    {
        public static string ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0; Data Source='Lawn Care Database.accdb'";
        private static OleDbConnection _db = new OleDbConnection(ConnectionString);

        public static void Insert(string query)
        {
            try
            {
                _db.Open();
                var cmd = new OleDbCommand(query, _db);
                cmd.ExecuteNonQuery();
                _db.Close();
                MessageBox.Show("Record Inserted SuccessFully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception e)
            {
                _db.Close();
                MessageBox.Show(e.Message, "Error",MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
        }

        public static void LoadDataGrid(DataGridView dataGridView, string table)
        {
            try
            {   
                if (table == "Employees")
                {
                    if (GlobalRoles.role == "employee")
                    {
                        string query = "SELECT `Employee First Name`,`Employee Last Name`, `Employee phone number`, `Employee Zip code`, `Email`, `Age`, `Gender`, `Address`, `City` FROM "+ table;
                        _db.Open();
                        var adapter = new OleDbDataAdapter(query, _db);
                        var dataset = new DataSet();
                        adapter.Fill(dataset);
                        _db.Close();
                        dataGridView.DataSource = dataset.Tables[0];
                    }
                    else
                    {
                        string query = "SELECT * FROM "+ table;
                        _db.Open();
                        var adapter = new OleDbDataAdapter(query, _db);
                        var dataset = new DataSet();
                        adapter.Fill(dataset);
                        _db.Close();
                        dataGridView.DataSource = dataset.Tables[0];
                    }
                }
                else
                {
                    string query = "SELECT * FROM "+ table;
                    _db.Open();
                    var adapter = new OleDbDataAdapter(query, _db);
                    var dataset = new DataSet();
                    adapter.Fill(dataset);
                    _db.Close();
                    dataGridView.DataSource = dataset.Tables[0];
                }


            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }

        public static void LoadComboBox(ComboBox comboBox, string table)
        {
            string query = "SELECT * FROM " + table;
            _db.Open();
            var adapter = new OleDbDataAdapter(query, _db);
            var dataset = new DataSet();
            adapter.Fill(dataset);
            _db.Close();
            comboBox.DataSource = dataset.Tables[0];

        }

        public static void ResetTextBoxt(TextBox[] textBoxes)
        {
            foreach (var textBox in textBoxes)
            {
                textBox.Clear();
            }
        }

        public static string DataReader(string table, int customerID, string WhatToBeReturned)
        {
            string returnMessage = "";
            try
            {
                string query = $"SELECT * FROM Customer WHERE `Customer Id`={customerID}";
                _db.Open();
                var cmd = new OleDbCommand(query, _db);
                var dataReader = cmd.ExecuteReader();
                
            
                if (dataReader.Read())
                {
                    if (WhatToBeReturned == "firstname")
                    {
                        returnMessage = dataReader["Customer First Name"].ToString();
                        _db.Close();
                    }else if (WhatToBeReturned == "lastname")
                    {
                        returnMessage = dataReader["Customer Last Name"].ToString();
                        _db.Close();
                        
                    }
                    
                    
                    dataReader.Close();
                
                }
                else
                {
                    _db.Close();
                    dataReader.Close();
                    MessageBox.Show("Error", "No Such id in the database", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception exception)
            {
                _db.Close();
                MessageBox.Show(exception.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
            return returnMessage;
        }

        public static OleDbDataReader  Reader(string table,string column, string id)
        {
            string query = $"SELECT * FROM {table} WHERE `{column}`={id}";
            _db.Open();
            var cmd = new OleDbCommand(query, _db);
            var dataReader = cmd.ExecuteReader();
            if (dataReader.Read())
            {
                return dataReader;
            }

            return dataReader;
        }
        
        public class GlobalRoles
        {
            public static string role { get; set; }
        }

        public static void ExportToCsv(DataGridView dataGridView, string fileName)
        {
            Excel.Application xlApp ;
            Excel.Workbook xlWorkBook ;
            Excel.Worksheet xlWorkSheet ;
            object misValue = System.Reflection.Missing.Value;

            xlApp = new Excel.Application();
            xlWorkBook = xlApp.Workbooks.Add(misValue);
            xlWorkSheet = (Excel.Worksheet)xlWorkBook.Worksheets.get_Item(1);
            int i = 0;
            int j = 0; 

            for (i = 0; i <= dataGridView.RowCount  - 1; i++)
            {
                for (j = 0; j <= dataGridView.ColumnCount  - 1; j++)
                {
                    DataGridViewCell cell = dataGridView[j, i];
                    xlWorkSheet.Cells[i + 1, j + 1] = cell.Value;
                }
            }

            xlWorkBook.SaveAs(fileName, Excel.XlFileFormat.xlWorkbookNormal, misValue, misValue, misValue, misValue, Excel.XlSaveAsAccessMode.xlExclusive, misValue, misValue, misValue, misValue, misValue);
            MessageBox.Show("Successfully imported and the file is in documents", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            xlWorkBook.Close(true, misValue, misValue);
            xlApp.Quit();

            releaseObject(xlWorkSheet);
            releaseObject(xlWorkBook);
            releaseObject(xlApp);
        }
        private static void releaseObject(object obj)
        {
            try
            {
                System.Runtime.InteropServices.Marshal.ReleaseComObject(obj);
                obj = null;
            }
            catch (Exception ex)
            {
                obj = null;
                MessageBox.Show("Exception Occured while releasing object " + ex.ToString());
            }
            finally
            {
                GC.Collect();
            }
        }

        public static void Search(DataGridView dataGridView, string query)
        {
            try
            {
                
                _db.Open();
                var adapter = new OleDbDataAdapter(query, _db);
                var dataset = new DataSet();
                adapter.Fill(dataset);
                _db.Close();
                dataGridView.DataSource = dataset.Tables[0];
            }
            catch (Exception e)
            {
                _db.Close();
                MessageBox.Show(e.Message);
                throw;
            }
        }

        public static void Delete(DataGridView dataGridView, string query)
        {
            if (MessageBox.Show("Are you sure you want to delete", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                DataGridViewRow row = dataGridView.Rows[dataGridView.CurrentRow.Index] ;
                if (row != null)
                {
                    try
                    {
                        _db.Open();
                        var cmd = new OleDbCommand(query, _db);
                        cmd.ExecuteNonQuery();
                        _db.Close();
                        MessageBox.Show("Record Deleted  SuccessFully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception e)
                    {
                        _db.Close();
                        MessageBox.Show(e.Message, "Error",MessageBoxButtons.OK, MessageBoxIcon.Error);
                        throw;
                    }
                    // MessageBox.Show($"{Int32.Parse(row.Cells[1].Value.ToString())}");
                    // string query = "DELETE FROM Customer WHERE `Customer Id`="+Int32.Parse(row.Cells[1].Value.ToString());
                    // CommonFunctions.Insert(query);
                }

            }
        }


    }
}