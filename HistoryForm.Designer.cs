namespace AllAboutThatBraille
{
    partial class HistoryForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HistoryForm));
            label1 = new Label();
            sourceBtn = new Button();
            backtoMainBtn = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(24, 50);
            label1.Name = "label1";
            label1.Size = new Size(741, 248);
            label1.TabIndex = 0;
            label1.Text = resources.GetString("label1.Text");
            // 
            // sourceBtn
            // 
            sourceBtn.BackColor = Color.PaleVioletRed;
            sourceBtn.FlatStyle = FlatStyle.Flat;
            sourceBtn.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            sourceBtn.ForeColor = Color.White;
            sourceBtn.Location = new Point(423, 342);
            sourceBtn.Name = "sourceBtn";
            sourceBtn.Size = new Size(227, 69);
            sourceBtn.TabIndex = 4;
            sourceBtn.Text = "Learn More";
            sourceBtn.UseVisualStyleBackColor = false;
            sourceBtn.Click += sourceBtn_Click;
            // 
            // backtoMainBtn
            // 
            backtoMainBtn.BackColor = SystemColors.ActiveBorder;
            backtoMainBtn.FlatStyle = FlatStyle.Flat;
            backtoMainBtn.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            backtoMainBtn.ForeColor = Color.Black;
            backtoMainBtn.Location = new Point(129, 342);
            backtoMainBtn.Name = "backtoMainBtn";
            backtoMainBtn.Size = new Size(227, 69);
            backtoMainBtn.TabIndex = 5;
            backtoMainBtn.Text = "Back to Main Menu";
            backtoMainBtn.UseVisualStyleBackColor = false;
            backtoMainBtn.Click += backtoMainBtn_Click;
            // 
            // HistoryForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Pink;
            ClientSize = new Size(787, 485);
            Controls.Add(backtoMainBtn);
            Controls.Add(sourceBtn);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "HistoryForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "HistoryForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button sourceBtn;
        private Button backtoMainBtn;
    }
}