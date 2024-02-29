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
using Oracle.DataAccess.Types;

namespace Wuzzuf
{
    public partial class Search : Form
    {
        string ordb = "Data source=orcl;User Id=wuzzuf;Password=123";
        OracleConnection conn;
        public Search()
        {
            InitializeComponent();
        }

        private void Search_Load(object sender, EventArgs e)
        {
            conn = new OracleConnection(ordb);
            conn.Open();
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "get_jobs";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("JOB_TITLE", jobTitleTextBox.Text);
            cmd.Parameters.Add("jobs", OracleDbType.RefCursor, ParameterDirection.Output);

            OracleDataReader dr = cmd.ExecuteReader();

            DataTable data_table = new DataTable();
            data_table.Columns.Add("ID");
            data_table.Columns.Add("Description");
            data_table.Columns.Add("Title");
            data_table.Columns.Add("Release Date");
            jobsDataGridView.AllowUserToAddRows = false; 

            while (dr.Read())
            {
                data_table.Rows.Add(dr[0], dr[1], dr[2], dr[3]);
                jobsDataGridView.DataSource = data_table;
            }
        }

        private void Search_FormClosing(object sender, FormClosingEventArgs e)
        {
            conn.Dispose();
        }
    }
}
