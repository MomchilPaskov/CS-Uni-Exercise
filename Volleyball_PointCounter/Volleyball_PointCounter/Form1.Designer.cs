namespace Volleyball_PointCounter
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
            button2 = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            button3 = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.None;
            button1.Font = new Font("Segoe UI", 19F);
            button1.Location = new Point(37, 362);
            button1.Name = "button1";
            button1.Size = new Size(231, 172);
            button1.TabIndex = 0;
            button1.Text = "Team 1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.None;
            button2.Font = new Font("Segoe UI", 19F);
            button2.Location = new Point(600, 362);
            button2.Name = "button2";
            button2.Size = new Size(231, 172);
            button2.TabIndex = 1;
            button2.Text = "Team 2";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 35F);
            label1.Location = new Point(331, 179);
            label1.Name = "label1";
            label1.Size = new Size(65, 78);
            label1.TabIndex = 2;
            label1.Text = "0";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 35F);
            label2.Location = new Point(464, 179);
            label2.Name = "label2";
            label2.Size = new Size(65, 78);
            label2.TabIndex = 3;
            label2.Text = "0";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 35F);
            label3.Location = new Point(412, 179);
            label3.Name = "label3";
            label3.Size = new Size(46, 78);
            label3.TabIndex = 4;
            label3.Text = ":";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.None;
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 37F);
            label4.Location = new Point(122, 74);
            label4.Name = "label4";
            label4.Size = new Size(68, 84);
            label4.TabIndex = 5;
            label4.Text = "0";
            label4.Click += label4_Click;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.None;
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 37F);
            label5.Location = new Point(686, 74);
            label5.Name = "label5";
            label5.Size = new Size(68, 84);
            label5.TabIndex = 6;
            label5.Text = "0";
            label5.Click += label5_Click;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.None;
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 24F);
            label6.Location = new Point(46, 33);
            label6.Name = "label6";
            label6.Size = new Size(221, 54);
            label6.TabIndex = 7;
            label6.Text = "Team1 Sets";
            label6.Click += label6_Click;
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.None;
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 24F);
            label7.Location = new Point(599, 33);
            label7.Name = "label7";
            label7.Size = new Size(221, 54);
            label7.TabIndex = 8;
            label7.Text = "Team2 Sets";
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.None;
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 29F);
            label8.Location = new Point(348, 113);
            label8.Name = "label8";
            label8.Size = new Size(149, 66);
            label8.TabIndex = 9;
            label8.Text = "Score";
            // 
            // button3
            // 
            button3.Font = new Font("Segoe UI", 12F);
            button3.Location = new Point(386, 408);
            button3.Name = "button3";
            button3.Size = new Size(94, 91);
            button3.TabIndex = 10;
            button3.Text = "Settings";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click_1;
            // 
            // Form1
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(871, 567);
            Controls.Add(button3);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button2);
            Controls.Add(button1);
            MaximizeBox = false;
            Name = "Form1";
            SizeGripStyle = SizeGripStyle.Hide;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Volleyball Scorer";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Button button3;
    }
}
