﻿namespace crossy_road
{
    partial class Form3
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
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.NavajoWhite;
            button1.Font = new Font("Cascadia Code", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Location = new Point(642, 399);
            button1.Name = "button1";
            button1.Size = new Size(161, 78);
            button1.TabIndex = 2;
            button1.Text = "EXIT";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.bg_fine1;
            ClientSize = new Size(1475, 838);
            Controls.Add(button1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form3";
            Text = "Form3";
            Load += Form3_Load;
            ResumeLayout(false);
        }

        #endregion
        private Button button1;
    }
}