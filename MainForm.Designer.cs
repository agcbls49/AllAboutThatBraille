namespace AllAboutThatBraille
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            historyBtn = new Button();
            aboutBtn = new Button();
            quizBtn = new Button();
            learnBtn = new Button();
            contextMenuStrip1 = new ContextMenuStrip(components);
            label1 = new Label();
            SuspendLayout();
            // 
            // historyBtn
            // 
            historyBtn.BackColor = SystemColors.ActiveBorder;
            historyBtn.FlatStyle = FlatStyle.Flat;
            historyBtn.Font = new Font("Segoe UI Semibold", 13.8F);
            historyBtn.ForeColor = Color.Black;
            historyBtn.Location = new Point(188, 165);
            historyBtn.Name = "historyBtn";
            historyBtn.Size = new Size(227, 69);
            historyBtn.TabIndex = 0;
            historyBtn.Text = "History of Braille";
            historyBtn.UseVisualStyleBackColor = false;
            historyBtn.Click += historyBtn_Click;
            // 
            // aboutBtn
            // 
            aboutBtn.BackColor = SystemColors.ActiveBorder;
            aboutBtn.FlatStyle = FlatStyle.Flat;
            aboutBtn.Font = new Font("Segoe UI Semibold", 13.8F);
            aboutBtn.ForeColor = Color.Black;
            aboutBtn.Location = new Point(465, 165);
            aboutBtn.Name = "aboutBtn";
            aboutBtn.Size = new Size(227, 69);
            aboutBtn.TabIndex = 2;
            aboutBtn.Text = "About the App";
            aboutBtn.UseVisualStyleBackColor = false;
            aboutBtn.Click += aboutBtn_Click;
            // 
            // quizBtn
            // 
            quizBtn.BackColor = Color.PaleVioletRed;
            quizBtn.FlatStyle = FlatStyle.Flat;
            quizBtn.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            quizBtn.ForeColor = Color.White;
            quizBtn.Location = new Point(465, 301);
            quizBtn.Name = "quizBtn";
            quizBtn.Size = new Size(227, 69);
            quizBtn.TabIndex = 3;
            quizBtn.Text = "Start Quiz";
            quizBtn.UseVisualStyleBackColor = false;
            // 
            // learnBtn
            // 
            learnBtn.BackColor = SystemColors.ActiveBorder;
            learnBtn.FlatStyle = FlatStyle.Flat;
            learnBtn.Font = new Font("Segoe UI Semibold", 13.8F);
            learnBtn.ForeColor = Color.Black;
            learnBtn.Location = new Point(188, 301);
            learnBtn.Name = "learnBtn";
            learnBtn.Size = new Size(227, 69);
            learnBtn.TabIndex = 4;
            learnBtn.Text = "Learn Braille";
            learnBtn.UseVisualStyleBackColor = false;
            learnBtn.Click += learnBtn_Click;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(20, 20);
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(97, 68);
            label1.Name = "label1";
            label1.Size = new Size(669, 41);
            label1.TabIndex = 6;
            label1.Text = "All About That Braille....... or at least....... the basics";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Pink;
            ClientSize = new Size(858, 482);
            Controls.Add(label1);
            Controls.Add(learnBtn);
            Controls.Add(quizBtn);
            Controls.Add(aboutBtn);
            Controls.Add(historyBtn);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "All About That Braille";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button historyBtn;
        private Button aboutBtn;
        private Button quizBtn;
        private Button learnBtn;
        private ContextMenuStrip contextMenuStrip1;
        private Label label1;
    }
}
