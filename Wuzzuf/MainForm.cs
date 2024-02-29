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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();


            ToolStripMenuItem form1MenuItem = new ToolStripMenuItem("Login");
            form1MenuItem.Click += (sender, e) => ShowForm(new Login());
            form1MenuItem.Font = new Font(form1MenuItem.Font.FontFamily, 15);  

            ToolStripMenuItem form2MenuItem = new ToolStripMenuItem("Register");
            form2MenuItem.Click += (sender, e) => ShowForm(new Register());
            form2MenuItem.Font = new Font(form2MenuItem.Font.FontFamily, 15);  

            ToolStripMenuItem form3MenuItem = new ToolStripMenuItem("Search");
            form3MenuItem.Click += (sender, e) => ShowForm(new Search());
            form3MenuItem.Font = new Font(form3MenuItem.Font.FontFamily, 15);  

            ToolStripMenuItem form4MenuItem = new ToolStripMenuItem("Posted Jobs");
            form4MenuItem.Click += (sender, e) => ShowForm(new SelectPostJobs());
            form4MenuItem.Font = new Font(form4MenuItem.Font.FontFamily, 15); 

            ToolStripMenuItem form5MenuItem = new ToolStripMenuItem("Search For Candidates");
            form5MenuItem.Click += (sender, e) => ShowForm(new SearchForCandidates());
            form5MenuItem.Font = new Font(form5MenuItem.Font.FontFamily, 15);

            ToolStripMenuItem form6MenuItem = new ToolStripMenuItem("Update Employee Info");
            form6MenuItem.Click += (sender, e) => ShowForm(new UpdateEmployeeInfo());
            form6MenuItem.Font = new Font(form6MenuItem.Font.FontFamily, 15);

            ToolStripMenuItem form7MenuItem = new ToolStripMenuItem("View Saved Jobs");
            form7MenuItem.Click += (sender, e) => ShowForm(new ViewSavedJobs());
            form7MenuItem.Font = new Font(form7MenuItem.Font.FontFamily, 15);

            ToolStripMenuItem form8MenuItem = new ToolStripMenuItem("Add Vacancies");
            form8MenuItem.Click += (sender, e) => ShowForm(new AddVacancies());
            form8MenuItem.Font = new Font(form8MenuItem.Font.FontFamily, 15);

            ToolStripMenuItem form9MenuItem = new ToolStripMenuItem("Jobs Report");
            form9MenuItem.Click += (sender, e) => ShowForm(new JobReport());
            form9MenuItem.Font = new Font(form9MenuItem.Font.FontFamily, 15);

            ToolStripMenuItem form10MenuItem = new ToolStripMenuItem("Employer's Posted Jobs Report");
            form10MenuItem.Click += (sender, e) => ShowForm(new SearchForEmployer());
            form10MenuItem.Font = new Font(form10MenuItem.Font.FontFamily, 15);

            ToolStripMenuItem form11MenuItem = new ToolStripMenuItem("Insert Rows");
            form11MenuItem.Click += (sender, e) => ShowForm(new insert_rows());
            form11MenuItem.Font = new Font(form11MenuItem.Font.FontFamily, 15);  


            MenuStrip menuStrip = new MenuStrip();
            menuStrip.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.VerticalStackWithOverflow;
            menuStrip.Items.Add(form1MenuItem);
            menuStrip.Items.Add(form2MenuItem);
            menuStrip.Items.Add(form3MenuItem);
            menuStrip.Items.Add(form4MenuItem);
            menuStrip.Items.Add(form5MenuItem);
            menuStrip.Items.Add(form6MenuItem);
            menuStrip.Items.Add(form7MenuItem);
            menuStrip.Items.Add(form8MenuItem);
            menuStrip.Items.Add(form9MenuItem);
            menuStrip.Items.Add(form10MenuItem);
            menuStrip.Items.Add(form11MenuItem);

            Text = "Main Form";
            Controls.Add(menuStrip);
            MainMenuStrip = menuStrip;
        }
        private void ShowForm(Form form)
        {
            form.ShowDialog();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }
    }
}
