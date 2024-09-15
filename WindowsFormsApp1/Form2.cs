using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // Call either method to populate the DataGridView at runtime
            AddValuesToDataGridView();
            // OR
            // BindDataToDataGridView();
        }

        // Method 1: Manually adding values to the DataGridView
        private void AddValuesToDataGridView()
        {
            // Set the column count and add column headers
            dataGridView1.ColumnCount = 3;
            dataGridView1.Columns[0].Name = "ID";
            dataGridView1.Columns[1].Name = "Name";
            dataGridView1.Columns[2].Name = "Age";

            // Add rows with values
            string[] row1 = new string[] { "1", "John Doe", "29" };
            string[] row2 = new string[] { "2", "Jane Smith", "34" };

            dataGridView1.Rows.Add(row1);
            dataGridView1.Rows.Add(row2);
        }

        // Method 2: Binding DataGridView to a DataTable
        private void BindDataToDataGridView()
        {
            // Create a new DataTable
            DataTable dt = new DataTable();

            // Add columns to the DataTable
            dt.Columns.Add("ID");
            dt.Columns.Add("Name");
            dt.Columns.Add("Age");

            // Add rows to the DataTable
            dt.Rows.Add("1", "John Doe", "29");
            dt.Rows.Add("2", "Jane Smith", "34");

            // Bind the DataTable to the DataGridView
            dataGridView1.DataSource = dt;
        }
    }
}
