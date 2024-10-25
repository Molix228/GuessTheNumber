namespace GuessTheNumber
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
            LabelText = new Label();
            textBox1 = new TextBox();
            label1 = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // LabelText
            // 
            LabelText.AutoSize = true;
            LabelText.Font = new Font("Segoe UI", 14F);
            LabelText.Location = new Point(52, 250);
            LabelText.Name = "LabelText";
            LabelText.Size = new Size(409, 51);
            LabelText.TabIndex = 0;
            LabelText.Text = "Enter the number here:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(518, 261);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(161, 39);
            textBox1.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F);
            label1.ForeColor = Color.IndianRed;
            label1.Location = new Point(127, 110);
            label1.Name = "label1";
            label1.Size = new Size(528, 51);
            label1.TabIndex = 2;
            label1.Text = "Guess a number from 1 to 100";
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ActiveCaption;
            button1.Font = new Font("Times New Roman", 10F);
            button1.ForeColor = Color.Black;
            button1.Location = new Point(518, 321);
            button1.Name = "button1";
            button1.Size = new Size(161, 46);
            button1.TabIndex = 3;
            button1.Text = "Guess";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(795, 601);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Controls.Add(LabelText);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label LabelText;
        private TextBox textBox1;
        private Label label1;
        private Button button1;
    }
}
