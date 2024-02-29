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
    public partial class ViewSavedJobs : Form
    {
        string ordb = "Data source=orcl;User Id=wuzzuf;Password=123";
        OracleConnection conn;
        public ViewSavedJobs()
        {
            InitializeComponent();
        }

        private void Browse_Load(object sender, EventArgs e)
        {
            conn = new OracleConnection(ordb);
            conn.Open();
        }


        private void searchButton_Click(object sender, EventArgs e)
        {
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = @"SELECT JOBS.JOB_ID, JOBS.JOB_TITLE, JOBS.JOB_DESCRIBTION, JOBS.RELEASE_DATE  
                                FROM SAVE_JOBS
                                JOIN EMPLOYEE ON SAVE_JOBS.EMPLOYEE_EID = EMPLOYEE.EMPLOYEE_ID
                                JOIN JOBS ON SAVE_JOBS.JOB_EID = JOBS.JOB_ID
                                WHERE EMPLOYEE.EMPLOYEE_EMAIL = :email AND EMPLOYEE.EMPLOYEE_PASSWORD = :password";
           
            cmd.CommandType = CommandType.Text;

            cmd.Parameters.Add("email", emailTextBox.Text);
            cmd.Parameters.Add("password", passwordTextBox.Text);


            OracleDataReader dr = cmd.ExecuteReader();

            DataTable data_table = new DataTable();
            data_table.Columns.Add("Job ID");
            data_table.Columns.Add("Description");
            data_table.Columns.Add("Title");
            data_table.Columns.Add("Release Date");
            infoDataGridView.AllowUserToAddRows = false;

            while (dr.Read())
            {
                data_table.Rows.Add(dr[0], dr[1], dr[2], dr[3]);
                infoDataGridView.DataSource = data_table;
            }
        }

        private void Browse_FormClosing(object sender, FormClosingEventArgs e)
        {
            conn.Dispose();
        }
    }
}
