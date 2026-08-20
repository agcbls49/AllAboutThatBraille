using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace AllAboutThatBraille
{
    public partial class LearnForm : Form
    {
        // track the page being shown
        private int currentPage = 1;

        public LearnForm()
        {
            InitializeComponent();
            previousBtn.FlatAppearance.BorderSize = 0;
            nextBtn.FlatAppearance.BorderSize = 0;

            // function for updating the page visible to the user
            UpdatePageVisible();
        }

        private void UpdatePageVisible() 
        {
            panelPage1.Visible = (currentPage == 1);
            panelPage2.Visible = (currentPage == 2);

            previousBtn.Enabled = true;

            // disable next button if on the last page
            nextBtn.Enabled = (currentPage < 2);
        }


        private void previousBtn_Click(object sender, EventArgs e)
        {
            // decrement the page count if page being shown is not the first page
            if (currentPage > 1)
            {
                currentPage--;
                UpdatePageVisible();
            }
            else
            {
                // show the main menu if previous button gets clicked only if user is on page 1
                MainForm mainForm = new MainForm();
                mainForm.Show();
                this.Close();
            }
        }

        private void nextBtn_Click(object sender, EventArgs e)
        {
            // incerement the page count if page being shown is not the last page yet
            if (currentPage < 2)
            {
                currentPage++;
                UpdatePageVisible();
            }
        }
    }
}
