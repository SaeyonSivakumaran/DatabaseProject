using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace DatabaseGUI
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // This line of code loads data into the 'peopleDatabaseDataSet2.InfoTable' table. You can move, or remove it, as needed.
            this.infoTableTableAdapter2.Fill(this.peopleDatabaseDataSet2.InfoTable);
            // Hide the id column in the DataGridView
            mainInfoTableView.Columns[5].Visible = false;
        }

        private void AddButton_Click(object sender, EventArgs e)
        {   
            // Display a pop up form for adding a new person
            Form1 addForm = new Form1();
            addForm.Show();
        }

        private void RefreshButton_Click(object sender, EventArgs e)
        {
            // Refresh the DataGridView containing our database
            this.infoTableTableAdapter2.Fill(this.peopleDatabaseDataSet2.InfoTable);
        }

        private void RemoveButton_Click(object sender, EventArgs e)
        {
            // Getting the selected person's id
            int row = mainInfoTableView.CurrentCell.RowIndex;
            int selectedId = Int32.Parse(mainInfoTableView.Rows[row].Cells[5].Value.ToString());

            // Creating the SQL connection
            string conStr = "Data Source=LAPTOP-L1T7M28M;Initial Catalog=PeopleDatabase;Integrated Security=True";
            SqlConnection connection = new SqlConnection(conStr);
            connection.Open();

            // Creating the SQL Command
            string query = "DELETE FROM InfoTable WHERE id=@selectedId";
            SqlCommand cmd = new SqlCommand(query, connection);
            cmd.Parameters.AddWithValue("@selectedId", selectedId);
            cmd.ExecuteNonQuery();

            //Refresh the data table
            this.infoTableTableAdapter2.Fill(this.peopleDatabaseDataSet2.InfoTable);
        }

    }
}
