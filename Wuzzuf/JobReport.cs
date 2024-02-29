using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Wuzzuf
{
    public partial class JobReport : Form
    {
        
        jobsReport cr;

        public JobReport()
        {
            InitializeComponent();
        }

        private void JobReport_Load(object sender, EventArgs e)
        {
            cr = new jobsReport();
        }

        private void generateButton_Click(object sender, EventArgs e)
        {
            cr.SetParameterValue(0, dateTimePicker.Value);
            jobsCrystalReportViewer.ReportSource = cr;
        }
    }
}
