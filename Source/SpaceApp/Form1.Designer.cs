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
            this.background = new System.Windows.Forms.PictureBox();
            this.yesPark = new System.Windows.Forms.Label();
            this.noPark = new System.Windows.Forms.Label();
            this.listbox = new System.Windows.Forms.ListBox();
            this.fillInNameLabel = new System.Windows.Forms.Label();
            this.searchButton = new System.Windows.Forms.Button();
            this.textInput = new System.Windows.Forms.TextBox();
            this.welcomeLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.background)).BeginInit();
            this.background.SuspendLayout();
            this.SuspendLayout();
            // 
            // background
            // 
            this.background.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.background.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.background.Controls.Add(this.yesPark);
            this.background.Controls.Add(this.noPark);
            this.background.Controls.Add(this.listbox);
            this.background.Controls.Add(this.fillInNameLabel);
            this.background.Controls.Add(this.searchButton);
            this.background.Controls.Add(this.textInput);
            this.background.Image = ((System.Drawing.Image)(resources.GetObject("background.Image")));
            this.background.Location = new System.Drawing.Point(-13, -12);
            this.background.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.background.Name = "background";
            this.background.Size = new System.Drawing.Size(730, 620);
            this.background.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.background.TabIndex = 8;
            this.background.TabStop = false;
            // 
            // yesPark
            // 
            this.yesPark.AutoSize = true;
            this.yesPark.BackColor = System.Drawing.Color.Green;
            this.yesPark.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.yesPark.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.yesPark.Location = new System.Drawing.Point(243, 188);
            this.yesPark.Name = "yesPark";
            this.yesPark.Size = new System.Drawing.Size(142, 25);
            this.yesPark.TabIndex = 7;
            this.yesPark.Text = "allowed to park";
            this.yesPark.Visible = false;
            // 
            // noPark
            // 
            this.noPark.AutoSize = true;
            this.noPark.BackColor = System.Drawing.Color.Red;
            this.noPark.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.noPark.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.noPark.Location = new System.Drawing.Point(222, 188);
            this.noPark.Name = "noPark";
            this.noPark.Size = new System.Drawing.Size(252, 25);
            this.noPark.TabIndex = 6;
            this.noPark.Text = "NOT ALLOWED TO PARK";
            this.noPark.Visible = false;
            // 
            // listbox
            // 
            this.listbox.BackColor = System.Drawing.SystemColors.WindowText;
            this.listbox.ForeColor = System.Drawing.Color.Gold;
            this.listbox.FormattingEnabled = true;
            this.listbox.ItemHeight = 20;
            this.listbox.Location = new System.Drawing.Point(138, 237);
            this.listbox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.listbox.Name = "listbox";
            this.listbox.Size = new System.Drawing.Size(432, 204);
            this.listbox.TabIndex = 4;
            this.listbox.SelectedIndexChanged += new System.EventHandler(this.listbox_SelectedIndexChanged);
            // 
            // fillInNameLabel
            // 
            this.fillInNameLabel.AutoSize = true;
            this.fillInNameLabel.BackColor = System.Drawing.Color.Transparent;
            this.fillInNameLabel.ForeColor = System.Drawing.Color.Gold;
            this.fillInNameLabel.Location = new System.Drawing.Point(138, 119);
            this.fillInNameLabel.Name = "fillInNameLabel";
            this.fillInNameLabel.Size = new System.Drawing.Size(187, 20);
            this.fillInNameLabel.TabIndex = 3;
            this.fillInNameLabel.Text = "Please fill in your full name";
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(483, 143);
            this.searchButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(87, 27);
            this.searchButton.TabIndex = 1;
            this.searchButton.Text = "SEARCH";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.button1_Click_1Async);
            // 
            // textInput
            // 
            this.textInput.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.textInput.Location = new System.Drawing.Point(138, 143);
            this.textInput.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textInput.Name = "textInput";
            this.textInput.Size = new System.Drawing.Size(338, 27);
            this.textInput.TabIndex = 0;
            // 
            // welcomeLabel
            // 
            this.welcomeLabel.AutoSize = true;
            this.welcomeLabel.BackColor = System.Drawing.Color.Transparent;
            this.welcomeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 24.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.welcomeLabel.ForeColor = System.Drawing.Color.Gold;
            this.welcomeLabel.Location = new System.Drawing.Point(47, 39);
            this.welcomeLabel.Name = "welcomeLabel";
            this.welcomeLabel.Size = new System.Drawing.Size(660, 48);
            this.welcomeLabel.TabIndex = 2;
            this.welcomeLabel.Text = "WELCOME TO SPACE PARKING";
            this.welcomeLabel.Click += new System.EventHandler(this.label1_ClickAsync);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(702, 560);
            this.Controls.Add(this.welcomeLabel);
            this.Controls.Add(this.background);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Space Parking";
            ((System.ComponentModel.ISupportInitialize)(this.background)).EndInit();
            this.background.ResumeLayout(false);
            this.background.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox background;
        public System.Windows.Forms.Label yesPark;
        public System.Windows.Forms.Label noPark;
        public System.Windows.Forms.ListBox listbox;
        private System.Windows.Forms.Label fillInNameLabel;
        private System.Windows.Forms.Label welcomeLabel;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.TextBox textInput;
    }
}

