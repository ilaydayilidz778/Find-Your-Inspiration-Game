﻿namespace WFAEsiniBulOyunu
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
            pnlKartlar = new Panel();
            SuspendLayout();
            // 
            // pnlKartlar
            // 
            pnlKartlar.Location = new Point(18, 13);
            pnlKartlar.Margin = new Padding(2, 2, 2, 2);
            pnlKartlar.Name = "pnlKartlar";
            pnlKartlar.Size = new Size(420, 360);
            pnlKartlar.TabIndex = 0;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(460, 392);
            Controls.Add(pnlKartlar);
            Margin = new Padding(2, 2, 2, 2);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Eşini Bul Oyunu";
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlKartlar;
    }
}