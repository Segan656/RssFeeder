using System;
using System.Windows.Forms;


namespace RSSFeeder
{
    public partial class Form1 : Form
    {
        private Feeder _feeder;
        private ConfigManager _configs;
        public Form1()
        {
            InitializeComponent();
           
            _configs = new ConfigManager();
            FillSource();
        }

        private void btnUrl_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(sourceCB.Text))
            {
                _feeder = new Feeder(sourceCB.Text);
                newsPanel.Controls.Clear();
                   
                 updateTimer.Interval = _configs.UpdateInterval * 1000;
                 intervalTb.Text = _configs.UpdateInterval.ToString();
                 updateTimer.Start();
                 updateTimer.Tick += UpdateTimer_Tick;
                 FillNewsPanel();
            }
        }
        
        void FillNewsPanel()
        {
            ProgressManager progress = new ProgressManager();
            ProgressBar progressBarForm = new ProgressBar();
            progressBarForm.Show();
            progress.WorkCompleted += progressBarForm._progressManager_WorkCompleted;
            progress.ProgressChanged += progressBarForm._progressBar_ProgressChanged;
            btnURL.Enabled = false;
            progress.Work();
            foreach (Item item in _feeder.Items)
            {
                newsPanel.Controls.Add(item.LinkName);
                newsPanel.Controls.Add(item.Description);
                newsPanel.Controls.Add(item.PubDate);
            }
                
        }
        void UpdateTimer_Tick(object sender, EventArgs e)
        {
            _feeder.UpdateFeed();
            FillNewsPanel();
        }
       
        private void FillSource()
        {

            foreach (string sourceString in _configs.SourceStrings)
            {
                sourceCB.Items.Add(sourceString);
                sourceCB.Text = sourceString;
            }
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            if (Feeder.IsFeed(tbURL.Text))
            {
                _configs.AddSource(tbURL.Text);
                sourceCB.Items.Add(tbURL.Text);
                MessageBox.Show("Адрес добавлен");
                tbURL.Text = "";
            }
            else
                MessageBox.Show("Введите корректный адрес");
        }

        private void timerBtn_Click(object sender, EventArgs e)
        {
            int oldInterval = _configs.UpdateInterval;
            int interval;
            if (int.TryParse(intervalTb.Text, out interval) && interval > 0)
            {
                _configs.SetUpdateInterval(interval);
                updateTimer.Interval = interval * 1000;
                MessageBox.Show("Интервал обновления ленты изменен");
            }
            else
            {
                MessageBox.Show("Введите корректное значение");
                intervalTb.Text = oldInterval.ToString();
            }
                

        }
    }
}
