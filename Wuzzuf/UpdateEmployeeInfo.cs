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
    public partial class UpdateEmployeeInfo : Form
    {
        OracleCommandBuilder builder;
        OracleDataAdapter adapter;
        DataSet ds;
        public UpdateEmployeeInfo()
        {
            InitializeComponent();
        }

        private void UpdateEmployeeInfo_Load(object sender, EventArgs e)
        {
        }

        private void loadInformationButton_Click(object sender, EventArgs e)
        {
            string constr = "Data source=orcl;User Id =wuzzuf;Password=123";
            string cmd = "select * from employee where EMPLOYEE_EMAIL=:Email and EMPLOYEE_PASSWORD=:password";
           
            adapter = new OracleDataAdapter(cmd, constr);
            
            adapter.SelectCommand.Parameters.Add("Email", emailTextBox.Text);
            adapter.SelectCommand.Parameters.Add("password", passwordTextBox.Text);
           
            ds = new DataSet();
            
            adapter.Fill(ds);
            infoDataGridView.DataSource = ds.Tables[0];
            infoDataGridView.Columns["EMPLOYEE_ID"].ReadOnly = true;
            infoDataGridView.AllowUserToAddRows = false; 
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            builder = new OracleCommandBuilder(adapter);
            adapter.Update(ds.Tables[0]);
            MessageBox.Show("Updated successfully");
        }
    }
}
