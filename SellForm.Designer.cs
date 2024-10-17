namespace DrugWarsCS
{
    partial class SellForm
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
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            label1 = new Label();
            label3 = new Label();
            label2 = new Label();
            textBox1 = new TextBox();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            SuspendLayout();
            // 
            // button4
            // 
            button4.BackColor = Color.SaddleBrown;
            button4.Location = new Point(342, 182);
            button4.Name = "button4";
            button4.Size = new Size(94, 29);
            button4.TabIndex = 9;
            button4.Text = "Heroin";
            button4.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            button3.BackColor = Color.LightBlue;
            button3.Location = new Point(242, 182);
            button3.Name = "button3";
            button3.Size = new Size(94, 29);
            button3.TabIndex = 8;
            button3.Text = "Meth";
            button3.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.BackColor = Color.White;
            button2.Location = new Point(142, 182);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 7;
            button2.Text = "Coke";
            button2.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            button1.BackColor = Color.DarkGreen;
            button1.Location = new Point(42, 182);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 6;
            button1.Text = "Weed";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(142, 57);
            label1.Name = "label1";
            label1.Size = new Size(195, 20);
            label1.TabIndex = 5;
            label1.Text = "What would you like to sell?";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(365, 9);
            label3.Name = "label3";
            label3.Size = new Size(101, 20);
            label3.TabIndex = 12;
            label3.Text = "player_money";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(101, 102);
            label2.Name = "label2";
            label2.Size = new Size(65, 20);
            label2.TabIndex = 11;
            label2.Text = "Amount:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(172, 99);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 27);
            textBox1.TabIndex = 10;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(65, 159);
            label7.Name = "label7";
            label7.Size = new Size(77, 20);
            label7.TabIndex = 16;
            label7.Text = "w_amount";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(163, 159);
            label6.Name = "label6";
            label6.Size = new Size(75, 20);
            label6.TabIndex = 15;
            label6.Text = "C_amount";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(265, 159);
            label5.Name = "label5";
            label5.Size = new Size(79, 20);
            label5.TabIndex = 14;
            label5.Text = "m_amount";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(365, 159);
            label4.Name = "label4";
            label4.Size = new Size(77, 20);
            label4.TabIndex = 13;
            label4.Text = "H_amount";
            // 
            // SellForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(478, 223);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(textBox1);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label1);
            Name = "SellForm";
            Text = "Sell";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button4;
        private Button button3;
        private Button button2;
        private Button button1;
        private Label label1;
        private Label label3;
        public Label label2;
        private TextBox textBox1;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
    }
}