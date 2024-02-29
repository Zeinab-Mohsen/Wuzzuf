using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.DataAccess.Client;

namespace Wuzzuf
{
    public partial class SearchForCandidates : Form
    {
        public SearchForCandidates()
        {
            InitializeComponent();
        }

        private void SearchForCandidates_Load(object sender, EventArgs e)
        {
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            string constr = "Data source=orcl;User Id=wuzzuf;Password=123";
            string cmd = "select FNAME,LNAME,EMPLOYEE_EMAIL,EMPLOYEE_CV from employee where EMPLOYEE_TITLE = :title";
            OracleDataAdapter adapter = new OracleDataAdapter(cmd, constr);
            adapter.SelectCommand.Parameters.Add("title", candidatesTextBox.Text);
            DataSet ds = new DataSet();
            adapter.Fill(ds);
            candidatesDataGridView.DataSource = ds.Tables[0];
            candidatesDataGridView.AllowUserToAddRows = false; 

        }
    }
}
