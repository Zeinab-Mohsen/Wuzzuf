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
    public partial class Register : Form
    {
        string ordb = "Data source=orcl;User Id =wuzzuf;Password=123";
        OracleConnection conn;

        public Register()
        {
            InitializeComponent();
        }

        private void Register_Load(object sender, EventArgs e)
        {
            conn = new OracleConnection(ordb);
            conn.Open();
        }

        private void registerButton_Click(object sender, EventArgs e)
        {
            string maxEmployerID = "";
            string maxEmployeeID = "";
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;

            if (employerRadioButton.Checked == true)
            {
                cmd.CommandText = "select max(EMPLOYER_ID) from employer";
                cmd.CommandType = CommandType.Text;

                OracleDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    maxEmployerID = dr[0].ToString();
                }
                int number = int.Parse(maxEmployerID);
                number += 1;


                cmd.CommandText = "insert into employer values(:EMPLOYER_ID,:EMPLOYER_EMAIL,:FNAME,:LNAME,:EMPLOYER_PASSWORD)";
                cmd.Parameters.Add("EMPLOYER_ID", number);
                cmd.Parameters.Add("EMPLOYER_EMAIL", emailNameTextBox.Text);
                cmd.Parameters.Add("FNAME", firstNameTextBox.Text);
                cmd.Parameters.Add("LNAME", lastNameTextBox.Text);
                cmd.Parameters.Add("EMPLOYER_PASSWORD", passwordTextBox.Text);

                int r = cmd.ExecuteNonQuery();

                if (r != -1)
                {
                    MessageBox.Show("Register is succussful");
                }
            }
            else if (employeeRadioButton.Checked == true)
            {
                cmd.CommandText = "select max(EMPLOYEE_ID) from employee";
                cmd.CommandType = CommandType.Text;

                OracleDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    maxEmployeeID = dr[0].ToString();
                }
                int number_one = int.Parse(maxEmployeeID);
                number_one += 1;


                cmd.CommandText = "insert into employee values(:EMPLOYEE_ID,:EMPLOYEE_EMAIL,:EMPLOYEE_TITLE, :FNAME,:LNAME,:EMPLOYEE_PASSWORD, :EMPLOYEE_CV)";
                cmd.Parameters.Add("EMPLOYEE_ID", number_one);
                cmd.Parameters.Add("EMPLOYEE_EMAIL", emailNameTextBox.Text);
                cmd.Parameters.Add("EMPLOYEE_TITLE", titleTextBox.Text);
                cmd.Parameters.Add("FNAME", firstNameTextBox.Text);
                cmd.Parameters.Add("LNAME", lastNameTextBox.Text);
                cmd.Parameters.Add("EMPLOYEE_PASSWORD", passwordTextBox.Text);
                cmd.Parameters.Add("EMPLOYEE_CV", CVTextBox.Text);

                int r = cmd.ExecuteNonQuery();

                if (r != -1)
                {
                    MessageBox.Show("Register is succussful");
                }
            }
        }

        private void employeeRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            CVTextBox.Enabled = true;
            CVTextBox.Visible = true;
            CVLabel.Enabled = true;
            CVLabel.Visible = true;

            titleLabel.Visible = true;
            titleLabel.Enabled = true;
            titleTextBox.Visible = true;
            titleTextBox.Enabled = true;
        }

        private void employerRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            CVTextBox.Enabled = false;
            CVTextBox.Visible = false; 
            CVLabel.Enabled = false;
            CVLabel.Visible = false;

            titleLabel.Visible = false;
            titleLabel.Enabled = false;
            titleTextBox.Visible = false;
            titleTextBox.Enabled = false;
        }

        private void Register_FormClosing(object sender, FormClosingEventArgs e)
        {
            conn.Dispose();
        }
    }
}
