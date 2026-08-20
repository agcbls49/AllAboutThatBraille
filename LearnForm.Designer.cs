namespace AllAboutThatBraille
{
    partial class LearnForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LearnForm));
            panelPage1 = new Panel();
            panelPage2 = new Panel();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            previousBtn = new Button();
            nextBtn = new Button();
            panelPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panelPage1
            // 
            panelPage1.Controls.Add(panelPage2);
            panelPage1.Controls.Add(label2);
            panelPage1.Controls.Add(pictureBox1);
            panelPage1.Controls.Add(label1);
            panelPage1.Location = new Point(98, 23);
            panelPage1.Name = "panelPage1";
            panelPage1.Size = new Size(968, 716);
            panelPage1.TabIndex = 0;
            // 
            // panelPage2
            // 
            panelPage2.Location = new Point(0, 0);
            panelPage2.Name = "panelPage2";
            panelPage2.Size = new Size(968, 716);
            panelPage2.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(637, 403);
            label2.Name = "label2";
            label2.Size = new Size(304, 124);
            label2.TabIndex = 2;
            label2.Text = "This braille spells out A \r\n(left side) and G (right side). \r\nThe intials of the creator of \r\nthis app.";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(236, 309);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(379, 379);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(15, 14);
            label1.Name = "label1";
            label1.Size = new Size(942, 279);
            label1.TabIndex = 0;
            label1.Text = resources.GetString("label1.Text");
            // 
            // previousBtn
            // 
            previousBtn.BackColor = SystemColors.ActiveBorder;
            previousBtn.FlatStyle = FlatStyle.Flat;
            previousBtn.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            previousBtn.Location = new Point(98, 755);
            previousBtn.Name = "previousBtn";
            previousBtn.Size = new Size(163, 63);
            previousBtn.TabIndex = 1;
            previousBtn.Text = "Previous";
            previousBtn.UseVisualStyleBackColor = false;
            previousBtn.Click += previousBtn_Click;
            // 
            // nextBtn
            // 
            nextBtn.BackColor = SystemColors.ActiveBorder;
            nextBtn.FlatStyle = FlatStyle.Flat;
            nextBtn.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            nextBtn.Location = new Point(903, 755);
            nextBtn.Name = "nextBtn";
            nextBtn.Size = new Size(163, 63);
            nextBtn.TabIndex = 2;
            nextBtn.Text = "Next";
            nextBtn.UseVisualStyleBackColor = false;
            nextBtn.Click += nextBtn_Click;
            // 
            // LearnForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Pink;
            ClientSize = new Size(1185, 836);
            Controls.Add(nextBtn);
            Controls.Add(previousBtn);
            Controls.Add(panelPage1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "LearnForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "LearnForm";
            panelPage1.ResumeLayout(false);
            panelPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelPage1;
        private Label label1;
        private Label label2;
        private PictureBox pictureBox1;
        private Button previousBtn;
        private Button nextBtn;
        private Panel panelPage2;
    }
}