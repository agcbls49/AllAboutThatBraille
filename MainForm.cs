namespace AllAboutThatBraille
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            historyBtn.FlatAppearance.BorderSize = 0;
            aboutBtn.FlatAppearance.BorderSize = 0;
            learnBtn.FlatAppearance.BorderSize = 0;
            quizBtn.FlatAppearance.BorderSize = 0;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void historyBtn_Click(object sender, EventArgs e)
        {
            this.Hide();

            HistoryForm historyForm = new HistoryForm();
            historyForm.ShowDialog();

            this.Close();
        }

        private void aboutBtn_Click(object sender, EventArgs e)
        {
            this.Hide();

            using(AboutForm aboutForm = new AboutForm())
            {
                aboutForm.ShowDialog();
            }

            this.Show();
        }
    }
}
