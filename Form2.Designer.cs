namespace DrugWarsCS
{
    partial class Form2
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            splitContainer1 = new SplitContainer();
            label11 = new Label();
            label9 = new Label();
            label8 = new Label();
            button2 = new Button();
            label5 = new Label();
            label4 = new Label();
            label12 = new Label();
            label10 = new Label();
            label7 = new Label();
            button3 = new Button();
            label6 = new Label();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ActiveCaptionText;
            label1.ForeColor = Color.FromArgb(0, 192, 192);
            label1.Location = new Point(62, 28);
            label1.Name = "label1";
            label1.Size = new Size(37, 20);
            label1.TabIndex = 0;
            label1.Text = "DAY";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.FromArgb(0, 192, 192);
            label2.Location = new Point(647, 28);
            label2.Name = "label2";
            label2.Size = new Size(54, 20);
            label2.TabIndex = 1;
            label2.Text = "Money";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.FromArgb(0, 192, 192);
            label3.Location = new Point(344, 73);
            label3.Name = "label3";
            label3.Size = new Size(66, 20);
            label3.TabIndex = 2;
            label3.Text = "Location";
            // 
            // splitContainer1
            // 
            splitContainer1.ForeColor = SystemColors.ActiveCaptionText;
            splitContainer1.Location = new Point(2, 93);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(label11);
            splitContainer1.Panel1.Controls.Add(label9);
            splitContainer1.Panel1.Controls.Add(label8);
            splitContainer1.Panel1.Controls.Add(button2);
            splitContainer1.Panel1.Controls.Add(label5);
            splitContainer1.Panel1.Controls.Add(label4);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(label12);
            splitContainer1.Panel2.Controls.Add(label10);
            splitContainer1.Panel2.Controls.Add(label7);
            splitContainer1.Panel2.Controls.Add(button3);
            splitContainer1.Panel2.Controls.Add(label6);
            splitContainer1.Size = new Size(1118, 345);
            splitContainer1.SplitterDistance = 372;
            splitContainer1.TabIndex = 3;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.ForeColor = Color.DarkCyan;
            label11.Location = new Point(10, 109);
            label11.Name = "label11";
            label11.Size = new Size(54, 20);
            label11.TabIndex = 10;
            label11.Text = "Heroin";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.ForeColor = Color.DarkCyan;
            label9.Location = new Point(10, 79);
            label9.Name = "label9";
            label9.Size = new Size(43, 20);
            label9.TabIndex = 9;
            label9.Text = "Meth";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(10, 89);
            label8.Name = "label8";
            label8.Size = new Size(50, 20);
            label8.TabIndex = 8;
            label8.Text = "label8";
            // 
            // button2
            // 
            button2.Location = new Point(275, 316);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 7;
            button2.Text = "Buy";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = Color.DarkCyan;
            label5.Location = new Point(10, 48);
            label5.Name = "label5";
            label5.Size = new Size(42, 20);
            label5.TabIndex = 6;
            label5.Text = "Coke";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = Color.DarkCyan;
            label4.Location = new Point(10, 13);
            label4.Name = "label4";
            label4.Size = new Size(47, 20);
            label4.TabIndex = 5;
            label4.Text = "Weed";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.ForeColor = Color.DarkCyan;
            label12.Location = new Point(320, 109);
            label12.Name = "label12";
            label12.RightToLeft = RightToLeft.Yes;
            label12.Size = new Size(90, 20);
            label12.TabIndex = 4;
            label12.Text = "heroin_price";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.ForeColor = Color.DarkCyan;
            label10.Location = new Point(328, 79);
            label10.Name = "label10";
            label10.Size = new Size(82, 20);
            label10.TabIndex = 3;
            label10.Text = "meth_price";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.ForeColor = Color.DarkCyan;
            label7.Location = new Point(331, 48);
            label7.Name = "label7";
            label7.Size = new Size(79, 20);
            label7.TabIndex = 2;
            label7.Text = "coke_price";
            // 
            // button3
            // 
            button3.Location = new Point(3, 316);
            button3.Name = "button3";
            button3.Size = new Size(94, 29);
            button3.TabIndex = 1;
            button3.Text = "Sell";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.ForeColor = Color.DarkCyan;
            label6.Location = new Point(326, 13);
            label6.Name = "label6";
            label6.Size = new Size(84, 20);
            label6.TabIndex = 0;
            label6.Text = "weed_price";
            // 
            // button1
            // 
            button1.Location = new Point(323, 12);
            button1.Name = "button1";
            button1.Size = new Size(111, 29);
            button1.TabIndex = 4;
            button1.Text = "Advance Day";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(800, 450);
            Controls.Add(splitContainer1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button1);
            Name = "Form2";
            Text = "Form2";
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel1.PerformLayout();
            splitContainer1.Panel2.ResumeLayout(false);
            splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private SplitContainer splitContainer1;
        private Button button1;
        private Label label4;
        private Label label5;
        private Label label6;
        private Button button2;
        private Button button3;
        private Label label8;
        private Label label7;
        private Label label11;
        private Label label9;
        private Label label10;
        private Label label12;
    }
}