using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace RSSFeeder
{
    public partial class ProgressBar : Form
    {
        public ProgressBar()
        {
            InitializeComponent();
        }

        public void _progressManager_WorkCompleted(bool canceled)
        {
            string message = canceled ? "процесс отменен" : "процесс успешно завершен";
            MessageBox.Show(message);

        }

        public void _progressBar_ProgressChanged(int progress)
        {
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }
    }
}
