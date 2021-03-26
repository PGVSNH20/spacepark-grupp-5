﻿
using System.Drawing;

namespace SpaceApp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.noPark = new System.Windows.Forms.Label();
            this.yesPark = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.textBox1.Location = new System.Drawing.Point(121, 107);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(296, 23);
            this.textBox1.TabIndex = 0;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(423, 107);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(76, 24);
            this.button1.TabIndex = 1;
            this.button1.Text = "SEARCH";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1Async);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("SF Distant Galaxy", 24.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Gold;
            this.label1.Location = new System.Drawing.Point(27, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(560, 34);
            this.label1.TabIndex = 2;
            this.label1.Text = "WELCOME TO SPACE PARKING";
            this.label1.Click += new System.EventHandler(this.label1_ClickAsync);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.Color.Gold;
            this.label2.Location = new System.Drawing.Point(121, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(149, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Please fill in your full name";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // listBox1
            // 
            this.listBox1.BackColor = System.Drawing.SystemColors.WindowText;
            this.listBox1.ForeColor = System.Drawing.Color.Gold;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 15;
            this.listBox1.Location = new System.Drawing.Point(145, 172);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(314, 184);
            this.listBox1.TabIndex = 4;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // noPark
            // 
            this.noPark.AutoSize = true;
            this.noPark.BackColor = System.Drawing.Color.Red;
            this.noPark.Font = new System.Drawing.Font("hooge 05_53", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.noPark.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.noPark.Location = new System.Drawing.Point(194, 141);
            this.noPark.Name = "noPark";
            this.noPark.Size = new System.Drawing.Size(219, 20);
            this.noPark.TabIndex = 6;
            this.noPark.Text = "NOT ALLOWED TO PARK";
            this.noPark.Visible = false;
            // 
            // yesPark
            // 
            this.yesPark.AutoSize = true;
            this.yesPark.BackColor = System.Drawing.Color.Green;
            this.yesPark.Font = new System.Drawing.Font("hooge 05_53", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.yesPark.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.yesPark.Location = new System.Drawing.Point(213, 141);
            this.yesPark.Name = "yesPark";
            this.yesPark.Size = new System.Drawing.Size(177, 20);
            this.yesPark.TabIndex = 7;
            this.yesPark.Text = "allowed to park";
            this.yesPark.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-11, -9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(639, 465);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(614, 420);
            this.Controls.Add(this.yesPark);
            this.Controls.Add(this.noPark);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.pictureBox1);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.ListBox listBox1;
        public System.Windows.Forms.Label noPark;
        private System.Windows.Forms.PictureBox pictureBox1;
        public System.Windows.Forms.Label yesPark;
    }
}

