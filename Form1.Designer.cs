namespace TestProj
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            LogTb = new TextBox();
            PassTb = new TextBox();
            LogBtn = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16F);
            label1.Location = new Point(53, 9);
            label1.Name = "label1";
            label1.Size = new Size(109, 37);
            label1.TabIndex = 0;
            label1.Text = "TestProj";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(12, 68);
            label2.Name = "label2";
            label2.Size = new Size(61, 28);
            label2.TabIndex = 1;
            label2.Text = "Login";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(12, 151);
            label3.Name = "label3";
            label3.Size = new Size(93, 28);
            label3.TabIndex = 2;
            label3.Text = "Password";
            // 
            // LogTb
            // 
            LogTb.Font = new Font("Microsoft Sans Serif", 8.25F);
            LogTb.Location = new Point(12, 99);
            LogTb.Margin = new Padding(3, 4, 3, 4);
            LogTb.Name = "LogTb";
            LogTb.Size = new Size(192, 23);
            LogTb.TabIndex = 3;
            // 
            // PassTb
            // 
            PassTb.Font = new Font("Microsoft Sans Serif", 8.25F);
            PassTb.Location = new Point(12, 183);
            PassTb.Margin = new Padding(3, 4, 3, 4);
            PassTb.Name = "PassTb";
            PassTb.PasswordChar = '*';
            PassTb.Size = new Size(192, 23);
            PassTb.TabIndex = 4;
            // 
            // LogBtn
            // 
            LogBtn.Location = new Point(53, 213);
            LogBtn.Name = "LogBtn";
            LogBtn.Size = new Size(119, 50);
            LogBtn.TabIndex = 5;
            LogBtn.Text = "LogIn";
            LogBtn.UseVisualStyleBackColor = true;
            LogBtn.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(223, 271);
            Controls.Add(LogBtn);
            Controls.Add(PassTb);
            Controls.Add(LogTb);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox LogTb;
        private TextBox PassTb;
        private Button LogBtn;
    }
}
