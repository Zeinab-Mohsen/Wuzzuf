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
    public partial class SearchForEmployer : Form
    {
        ShowEmployersJobs CR;

        public SearchForEmployer()
        {
            InitializeComponent();
        }

        private void SearchForEmployer_Load(object sender, EventArgs e)
        {
            CR = new ShowEmployersJobs();
        }

        private void generateButton_Click(object sender, EventArgs e)
        {
            CR.SetParameterValue(0, fNameTextBox.Text);
            CR.SetParameterValue(1, lNameTextBox.Text);
            crystalReportViewer.ReportSource = CR;
        }
    }
}
