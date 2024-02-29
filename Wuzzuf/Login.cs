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
    public partial class Login : Form
    {
        string ordb = "Data source=orcl;User Id=wuzzuf;Password=123";
        OracleConnection conn;

        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            conn = new OracleConnection(ordb);
            conn.Open();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;

            if (EmployerRadioButton.Checked == true)
            {
                cmd.CommandText = "select * from employer where EMPLOYER_EMAIL = :email and EMPLOYER_PASSWORD = :password";
                cmd.CommandType = CommandType.Text;

                cmd.Parameters.Add("EMPLOYER_EMAIL", emailTextBox.Text);
                cmd.Parameters.Add("EMPLOYER_PASSWORD", passwordText_box.Text);


                OracleDataReader dr = cmd.ExecuteReader();

                if (dr.Read())
                {
                    MessageBox.Show("Login is succussful");
                }
                else
                {
                    MessageBox.Show("Invalid email or password");
                }
            }
            else if (EmployeeRadioButton.Checked == true)
            {
                cmd.CommandText = "select * from employee where EMPLOYEE_EMAIL = :email and EMPLOYEE_PASSWORD = :password";
                cmd.CommandType = CommandType.Text;

                cmd.Parameters.Add("EMPLOYEE_EMAIL", emailTextBox.Text);
                cmd.Parameters.Add("EMPLOYEE_PASSWORD", passwordText_box.Text);


                OracleDataReader dr = cmd.ExecuteReader();

                if (dr.Read())
                {
                    MessageBox.Show("Login is succussful");
                }
                else
                {
                    MessageBox.Show("Invalid email or password");
                }
            }
            else
            {
                MessageBox.Show("Select either employer or employee");
            }
        }

        private void Login_FormClosing(object sender, FormClosingEventArgs e)
        {
            conn.Dispose();
        }
    }
}
