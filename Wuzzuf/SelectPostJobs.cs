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
    public partial class SelectPostJobs : Form
    {
        string ordb = "Data source=orcl;User Id=wuzzuf;Password=123";
        OracleConnection conn;

        public SelectPostJobs()
        {
            InitializeComponent();
        }

        private void SlectPostJobs_Load(object sender, EventArgs e)
        {
            conn = new OracleConnection(ordb);
            conn.Open();

            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "select JOB_EID from post_jobs";
            cmd.CommandType = CommandType.Text;

            OracleDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                jobIDComboBox.Items.Add(dr[0]);
            }
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "get_post_jobs";
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add("jobID", int.Parse(jobIDComboBox.SelectedItem.ToString()));
            cmd.Parameters.Add("postJobsID", OracleDbType.Int32, ParameterDirection.Output);
            cmd.Parameters.Add("employerID", OracleDbType.Int32, ParameterDirection.Output);

            cmd.ExecuteNonQuery();

            jobPostIDTextBox.Text = cmd.Parameters["postJobsID"].Value.ToString();
            employerIDTextBox.Text = cmd.Parameters["employerID"].Value.ToString();
        }

        private void SlectPostJobs_FormClosing(object sender, FormClosingEventArgs e)
        {
            conn.Dispose();
        }
    }
}
