﻿namespace crossy_road
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
            button1 = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.MistyRose;
            button1.Font = new Font("Cascadia Code", 25F);
            button1.Location = new Point(35, 475);
            button1.Name = "button1";
            button1.Size = new Size(164, 81);
            button1.TabIndex = 2;
            button1.Text = "START";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.MistyRose;
            button2.Font = new Font("Cascadia Code", 25F);
            button2.Location = new Point(291, 475);
            button2.Name = "button2";
            button2.Size = new Size(164, 81);
            button2.TabIndex = 3;
            button2.Text = "QUIT";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.street_nugget_500x600;
            ClientSize = new Size(500, 597);
            Controls.Add(button2);
            Controls.Add(button1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form2";
            ResumeLayout(false);
        }

        #endregion
        private Button button1;
        private Button button2;
    }
}