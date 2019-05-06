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
    public partial class Form3 : Form
    {

        DataGridView tableView;  // Used to store DataGridView from the main menu form

        public Form3(DataGridView tableView)
        {
            InitializeComponent();
            this.tableView = tableView;
        }

        private void FilterButton_Click(object sender, EventArgs e)
        {
            // Getting the location selected
            string location = provinceFilterOptions.Text.Substring(0, 2);

            // Making rows visible or invisible depending on whether they should be filtered
            for(int i = 0; i < tableView.RowCount - 1; i++)
            {
                if(tableView.Rows[i].Cells[3].Value.ToString() == location)
                {
                    tableView.Rows[i].Selected = true;
                    tableView.Rows[i].Visible = true;
                } else
                {
                    CurrencyManager currencyManager1 = (CurrencyManager)BindingContext[tableView.DataSource];
                    currencyManager1.SuspendBinding();
                    tableView.Rows[i].Selected = false;
                    tableView.Rows[i].Visible = false;
                    currencyManager1.ResumeBinding();
                }
            }
        }
    }
}
