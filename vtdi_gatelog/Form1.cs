using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace vtdi_gatelog
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnusers_Click(object sender, EventArgs e)
        {

        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            LogInForm logIn = new LogInForm();
            logIn.MdiParent = this;
            logIn.Show();

        }

        private void btnuserManagement_Click(object sender, EventArgs e)
        {

        }

        private void btnscheduling_Click(object sender, EventArgs e)
        {

        }

        private void btngateLogs_Click(object sender, EventArgs e)
        {

        }

        private void btnguestList_Click(object sender, EventArgs e)
        {

        }

        private void btngateInOut_Click(object sender, EventArgs e)
        {

        }

        private void btnreports_Click(object sender, EventArgs e)
        {

        }

        private void btngateReports_Click(object sender, EventArgs e)
        {

        }

        private void btnuserLogs_Click(object sender, EventArgs e)
        {

        }
    }
}
