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
    public partial class AddVacancies : Form
    {
        string ordb = "Data source=orcl;User Id=wuzzuf;Password=123";
        OracleConnection conn;
        public AddVacancies()
        {
            InitializeComponent();
        }

        private void AddVacancies_Load(object sender, EventArgs e)
        {
            conn = new OracleConnection(ordb);
            conn.Open();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            string maxJobID = "";
            DateTime currentDateTime = DateTime.Now;
            string formattedDateTime = DateTime.Now.ToString("dd-MMM-yy").ToUpper();

            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;

            cmd.CommandText = "select max(JOB_ID) from JOBS";
            cmd.CommandType = CommandType.Text;


            OracleDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                maxJobID = dr[0].ToString();
            }
            int number = int.Parse(maxJobID);
            number += 1;

            int r = 0;

            cmd.CommandText = "INSERT INTO JOBS VALUES(:JOB_ID,:JOB_DESCRIBTION,:JOB_TITLE,:RELEASE_DATE)";

            cmd.Parameters.Add("JOB_ID", number);
            cmd.Parameters.Add("JOB_DESCRIBTION", description1TextBox.Text);
            cmd.Parameters.Add("JOB_TITLE", title1TextBox.Text);
            cmd.Parameters.Add("RELEASE_DATE", formattedDateTime);

            r = cmd.ExecuteNonQuery();

            if (r != -1)
            {
                MessageBox.Show("Added 1 succussfuly");
                r = 0;
            }
            number += 1;



            cmd.Parameters.Clear();

            cmd.Parameters.Add("JOB_ID", number);
            cmd.Parameters.Add("JOB_DESCRIBTION", description2TextBox.Text);
            cmd.Parameters.Add("JOB_TITLE", title2TextBox.Text);
            cmd.Parameters.Add("RELEASE_DATE", formattedDateTime);

            r = cmd.ExecuteNonQuery();

            if (r != -1)
            {
                MessageBox.Show("Added 2 succussfuly");
                r = 0;
            }
            number += 1;


            cmd.Parameters.Clear();

            cmd.Parameters.Add("JOB_ID", number);
            cmd.Parameters.Add("JOB_DESCRIBTION", description3TextBox.Text);
            cmd.Parameters.Add("JOB_TITLE", title3TextBox.Text);
            cmd.Parameters.Add("RELEASE_DATE", formattedDateTime);

            r = cmd.ExecuteNonQuery();

            if (r != -1)
            {
                MessageBox.Show("Added 3 succussfuly");
                r = 0;
            }
            number += 1;

            description1TextBox.Clear();
            description2TextBox.Clear();
            description3TextBox.Clear();
            title1TextBox.Clear();
            title2TextBox.Clear();
            title3TextBox.Clear();
        }
    }
}
