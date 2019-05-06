using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            // TODO: This line of code loads data into the 'peopleDatabaseDataSet.InfoTable' table. You can move, or remove it, as needed.
            this.infoTableTableAdapter.Fill(this.peopleDatabaseDataSet.InfoTable);

        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Show();
        }

        private void RefreshButton_Click(object sender, EventArgs e)
        {
            this.infoTableTableAdapter.Fill(this.peopleDatabaseDataSet.InfoTable);
        }
    }
}
