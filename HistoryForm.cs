using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace AllAboutThatBraille
{
    public partial class HistoryForm : Form
    {
        public HistoryForm()
        {
            InitializeComponent();
            backtoMainBtn.FlatAppearance.BorderSize = 0;
            sourceBtn.FlatAppearance.BorderSize = 0;
        }

        private void sourceBtn_Click(object sender, EventArgs e)
        {
            string url = "https://www.britannica.com/topic/Braille-writing-system";

            try
            {
                Process.Start(new ProcessStartInfo
                {
                    FileName = url,
                    UseShellExecute = true
                });
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Could not open link: {ex.Message}");
            }
        }

        private void backtoMainBtn_Click(object sender, EventArgs e)
        {
            this.Hide();

            MainForm mainForm = new MainForm();
            mainForm.ShowDialog();

            this.Close();
        }
    }
}
