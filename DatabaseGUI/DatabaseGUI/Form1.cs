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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            // Gathering data from user input
            string name = nameBox.Text;
            string age = ageBox.Text;
            string sex;
            if (maleRadio.Checked){
                sex = "Male";
            } else{
                sex = "Female";
            }
            string province = provinceOptions.Text.Substring(0, 2);
            string school = schoolBox.Text;

            // Creating SQL Connection
            string conStr = "Data Source=LAPTOP-L1T7M28M;Initial Catalog=PeopleDatabase;Integrated Security=True";
            SqlConnection connection = new SqlConnection(conStr);
            connection.Open();

            // Creating the SQL Command
            string query = "INSERT INTO InfoTable VALUES(@name, @age, @sex, @location, @school)";
            SqlCommand cmd = new SqlCommand(query, connection);
            cmd.Parameters.AddWithValue("@name", name);
            cmd.Parameters.AddWithValue("@age", age);
            cmd.Parameters.AddWithValue("@sex", sex);
            cmd.Parameters.AddWithValue("@location", province);
            cmd.Parameters.AddWithValue("@school", school);

            //Checking if any rows were affected
            int rowsAffected = cmd.ExecuteNonQuery();
            if(rowsAffected > 0){
                MessageBox.Show($"{rowsAffected} rows affected");
                //Reset all input since database insert was successful
                nameBox.Clear();
                ageBox.Value = 0;
                provinceOptions.SelectedIndex = -1;
                schoolBox.Clear();
                this.infoTableTableAdapter.Fill(this.peopleDatabaseDataSet.InfoTable);
            } else{
                MessageBox.Show("No rows affected");
            }
            // Get rid of this window once a person has been added
            this.Hide();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

    }
}
