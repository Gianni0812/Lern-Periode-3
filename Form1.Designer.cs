namespace Quiz
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
            button1 = new Button();
            label1 = new Label();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ActiveCaption;
            button1.Location = new Point(48, 224);
            button1.Name = "button1";
            button1.Size = new Size(227, 67);
            button1.TabIndex = 0;
            button1.Text = "A) Gold";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(180, 141);
            label1.Name = "label1";
            label1.Size = new Size(419, 25);
            label1.TabIndex = 1;
            label1.Text = "1. Welches Element hat das chemische Symbol „O“?";
            label1.Click += label1_Click;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.ActiveCaption;
            button2.Location = new Point(462, 224);
            button2.Name = "button2";
            button2.Size = new Size(227, 67);
            button2.TabIndex = 2;
            button2.Text = "B) Sauerstoff";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackColor = SystemColors.ActiveCaption;
            button3.Location = new Point(48, 344);
            button3.Name = "button3";
            button3.Size = new Size(227, 67);
            button3.TabIndex = 3;
            button3.Text = "C) Silber";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.BackColor = SystemColors.ActiveCaption;
            button4.Location = new Point(462, 344);
            button4.Name = "button4";
            button4.Size = new Size(227, 67);
            button4.TabIndex = 4;
            button4.Text = "D) Stickstoff";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(label1);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label label1;
        private Button button2;
        private Button button3;
        private Button button4;
    }
}
