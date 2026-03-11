namespace lab22
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }


        private void InitializeComponent()
        {
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            button1 = new Button();
            label1 = new Label();
            label2 = new Label();
            labelRes = new Label();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(428, 71);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(317, 132);
            textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(75, 71);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(317, 132);
            textBox2.TabIndex = 1;
            // 
            // button1
            // 
            button1.Location = new Point(271, 225);
            button1.Name = "button1";
            button1.Size = new Size(269, 63);
            button1.TabIndex = 2;
            button1.Text = "найти повторяющиеся слова";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(180, 38);
            label1.Name = "label1";
            label1.Size = new Size(117, 20);
            label1.TabIndex = 3;
            label1.Text = "предложение 1";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(535, 38);
            label2.Name = "label2";
            label2.Size = new Size(117, 20);
            label2.TabIndex = 4;
            label2.Text = "предложение 2";
            // 
            // labelRes
            // 
            labelRes.AutoSize = true;
            labelRes.Location = new Point(298, 339);
            labelRes.Name = "labelRes";
            labelRes.Size = new Size(231, 20);
            labelRes.TabIndex = 5;
            labelRes.Text = "тут будут повторяющиеся слова";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(839, 450);
            Controls.Add(labelRes);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Name = "Form1";
            Text = "нахождение повторяющихся слов";
            ResumeLayout(false);
            PerformLayout();
        }



        private TextBox textBox1;
        private TextBox textBox2;
        private Button button1;
        private Label label1;
        private Label label2;
        private Label labelRes;
    }
}
