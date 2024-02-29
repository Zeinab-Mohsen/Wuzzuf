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
    public partial class insert_rows : Form
    {
        string ordb = "Data source=orcl;User Id =wuzzuf;Password=123";
        OracleConnection conn;

        public insert_rows()
        {
            InitializeComponent();
        }

        private void insert_rows_Load(object sender, EventArgs e)
        {

            conn = new OracleConnection(ordb);
            conn.Open();
        }

        private void loadInformationButton_Click(object sender, EventArgs e)
        {
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;

            cmd.CommandText = "SELECT j.JOB_ID, j.JOB_TITLE, j.JOB_DESCRIBTION, j.RELEASE_DATE FROM POST_JOBS pj JOIN EMPLOYER e ON pj.EMPLOYER_EID = e.EMPLOYER_ID JOIN JOBS j ON pj.JOB_EID = j.JOB_ID WHERE e.EMPLOYER_EMAIL = :email and e.EMPLOYER_PASSWORD = :pass";
            cmd.Parameters.Add("email", OracleDbType.Varchar2).Value = emailTextBox.Text.Trim();
            cmd.Parameters.Add("pass", OracleDbType.Varchar2).Value = passwordTextBox.Text.Trim();

            OracleDataReader dr = cmd.ExecuteReader();

            DataTable data_table = new DataTable();
            data_table.Columns.Add("JOB_ID");
            data_table.Columns.Add("JOB_TITLE");
            data_table.Columns.Add("JOB_DESCRIBTION");

            while (dr.Read())
            {
                data_table.Rows.Add(dr[0], dr[1], dr[2]);
            }

            infoDataGridView.DataSource = data_table;

            dr.Close();
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            // Get the employer ID for the logged in user
            OracleCommand employerCmd = new OracleCommand();
            employerCmd.Connection = conn;
            employerCmd.CommandText = "SELECT EMPLOYER_ID FROM EMPLOYER WHERE EMPLOYER_EMAIL = :email AND EMPLOYER_PASSWORD = :pass";
            employerCmd.Parameters.Add("email", OracleDbType.Varchar2).Value = emailTextBox.Text.Trim();
            employerCmd.Parameters.Add("pass", OracleDbType.Varchar2).Value = passwordTextBox.Text.Trim();

            int employerID = Convert.ToInt32(employerCmd.ExecuteScalar());

            foreach (DataGridViewRow row in infoDataGridView.Rows)
            {
                if (row.IsNewRow) continue; // skip the new row template

                int jobID = Convert.ToInt32(row.Cells["JOB_ID"].Value);

                OracleCommand checkCmd = new OracleCommand();
                checkCmd.Connection = conn;
                checkCmd.CommandText = "SELECT COUNT(*) FROM jobs WHERE JOB_ID = :jobid";
                checkCmd.Parameters.Add("jobid", OracleDbType.Int32).Value = jobID;

                int count = Convert.ToInt32(checkCmd.ExecuteScalar());

                if (count > 0) continue; // job already exists, skip to the next row

                OracleCommand insertCmd = new OracleCommand();
                insertCmd.Connection = conn;
                insertCmd.CommandText = "INSERT INTO jobs (JOB_ID, JOB_TITLE, JOB_DESCRIBTION, RELEASE_DATE) " +
                                         "VALUES (:jobid, :jobtitle, :jobdescription, :releasedate)";
                insertCmd.Parameters.Add("jobid", OracleDbType.Int32).Value = jobID;
                insertCmd.Parameters.Add("jobtitle", OracleDbType.Varchar2).Value = row.Cells["JOB_TITLE"].Value;
                insertCmd.Parameters.Add("jobdescription", OracleDbType.Varchar2).Value = row.Cells["JOB_DESCRIBTION"].Value;
                insertCmd.Parameters.Add("releasedate", OracleDbType.Date).Value = DateTime.Now; // set release date to current date

                insertCmd.ExecuteNonQuery();
                int post_jop = GetNewJobID();
                // Add the job to the POST_JOBS table for the logged in employer
                OracleCommand postCmd = new OracleCommand();
                postCmd.Connection = conn;
                postCmd.CommandText = "INSERT INTO POST_JOBS (POST_JOB_ID,EMPLOYER_EID, JOB_EID) " +
                                       "VALUES (:POSTJOBID,:employerid, :jobid)";


                postCmd.Parameters.Add("POST_JOBS", OracleDbType.Int32).Value = post_jop;

                postCmd.Parameters.Add("employerid", OracleDbType.Int32).Value = employerID;
                postCmd.Parameters.Add("jobid", OracleDbType.Int32).Value = jobID;

                postCmd.ExecuteNonQuery();
            }
        }

        private int GetNewJobID()
        {
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "SELECT MAX(POST_JOB_ID) FROM POST_JOBS";

            object result = cmd.ExecuteScalar();
            int maxID = Convert.IsDBNull(result) ? 0 : Convert.ToInt32(result);

            return maxID + 1;
        }

      
    }
}
