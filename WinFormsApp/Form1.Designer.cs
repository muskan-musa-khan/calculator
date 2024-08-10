namespace WinFormsApp
{
    partial class Form1
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
            Title = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            calcBtn = new Button();
            label2 = new Label();
            Results = new Label();
            SuspendLayout();
            // 
            // Title
            // 
            Title.Dock = DockStyle.Top;
            Title.Font = new Font("Calibri", 20F, FontStyle.Bold);
            Title.Location = new Point(0, 0);
            Title.Name = "Title";
            Title.Size = new Size(879, 54);
            Title.TabIndex = 0;
            Title.Text = "Calculator";
            Title.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(354, 84);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "Enter Number 1";
            textBox1.Size = new Size(170, 23);
            textBox1.TabIndex = 1;
            textBox1.TextAlign = HorizontalAlignment.Center;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(354, 143);
            textBox2.Name = "textBox2";
            textBox2.PlaceholderText = "Enter Number 2";
            textBox2.Size = new Size(170, 23);
            textBox2.TabIndex = 2;
            textBox2.TextAlign = HorizontalAlignment.Center;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(354, 211);
            textBox3.Name = "textBox3";
            textBox3.PlaceholderText = "(+ , - , * , /)";
            textBox3.Size = new Size(170, 23);
            textBox3.TabIndex = 3;
            textBox3.TextAlign = HorizontalAlignment.Center;
            // 
            // calcBtn
            // 
            calcBtn.Location = new Point(354, 285);
            calcBtn.Name = "calcBtn";
            calcBtn.Size = new Size(170, 33);
            calcBtn.TabIndex = 4;
            calcBtn.Text = "Calculate";
            calcBtn.UseVisualStyleBackColor = true;
            calcBtn.Click += calcBtn_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(422, 364);
            label2.Name = "label2";
            label2.Size = new Size(0, 15);
            label2.TabIndex = 6;
            // 
            // Results
            // 
            Results.Location = new Point(354, 364);
            Results.Name = "Results";
            Results.Size = new Size(170, 64);
            Results.TabIndex = 7;
            Results.Text = "0";
            Results.TextAlign = ContentAlignment.MiddleCenter;
            Results.Visible = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ClientSize = new Size(879, 636);
            Controls.Add(Results);
            Controls.Add(label2);
            Controls.Add(calcBtn);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(Title);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Calculator";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Title;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private Button calcBtn;
        private Label label2;
        private Label Results;
    }
}
