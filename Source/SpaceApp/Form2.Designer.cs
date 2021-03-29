﻿
namespace SpaceApp
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.showButton = new System.Windows.Forms.Button();
            this.selectLabel = new System.Windows.Forms.Label();
            this.listBox = new System.Windows.Forms.ListBox();
            this.allButton = new System.Windows.Forms.Button();
            this.background = new System.Windows.Forms.PictureBox();
            this.ParkButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.background)).BeginInit();
            this.SuspendLayout();
            // 
            // showButton
            // 
            this.showButton.BackColor = System.Drawing.Color.Yellow;
            this.showButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.showButton.Location = new System.Drawing.Point(166, 112);
            this.showButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.showButton.Name = "showButton";
            this.showButton.Size = new System.Drawing.Size(171, 32);
            this.showButton.TabIndex = 1;
            this.showButton.Text = "SHOW MY STARSHIPS";
            this.showButton.UseVisualStyleBackColor = false;
            this.showButton.Click += new System.EventHandler(this.button1_Click_1Async);
            // 
            // selectLabel
            // 
            this.selectLabel.AutoSize = true;
            this.selectLabel.BackColor = System.Drawing.Color.Transparent;
            this.selectLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 24.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.selectLabel.ForeColor = System.Drawing.Color.Gold;
            this.selectLabel.Location = new System.Drawing.Point(31, 49);
            this.selectLabel.Name = "selectLabel";
            this.selectLabel.Size = new System.Drawing.Size(599, 48);
            this.selectLabel.TabIndex = 2;
            this.selectLabel.Text = "SELECT STARSHIP TO PARK";
            // 
            // listBox
            // 
            this.listBox.BackColor = System.Drawing.SystemColors.WindowText;
            this.listBox.ForeColor = System.Drawing.Color.Gold;
            this.listBox.FormattingEnabled = true;
            this.listBox.ItemHeight = 20;
            this.listBox.Location = new System.Drawing.Point(166, 152);
            this.listBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.listBox.Name = "listBox";
            this.listBox.Size = new System.Drawing.Size(358, 244);
            this.listBox.TabIndex = 4;
            this.listBox.Click += new System.EventHandler(this.ShipIsSelected);
            this.listBox.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // allButton
            // 
            this.allButton.BackColor = System.Drawing.Color.Yellow;
            this.allButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.allButton.Location = new System.Drawing.Point(359, 112);
            this.allButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.allButton.Name = "allButton";
            this.allButton.Size = new System.Drawing.Size(166, 31);
            this.allButton.TabIndex = 5;
            this.allButton.Text = "SHOW ALL STARSHIPS";
            this.allButton.UseVisualStyleBackColor = false;
            this.allButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // background
            // 
            this.background.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.background.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.background.Image = ((System.Drawing.Image)(resources.GetObject("background.Image")));
            this.background.Location = new System.Drawing.Point(-13, -12);
            this.background.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.background.Name = "background";
            this.background.Size = new System.Drawing.Size(730, 520);
            this.background.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.background.TabIndex = 8;
            this.background.TabStop = false;
            this.background.Click += new System.EventHandler(this.background_Click);
            // 
            // ParkButton
            // 
            this.ParkButton.BackColor = System.Drawing.Color.DarkGray;
            this.ParkButton.Enabled = false;
            this.ParkButton.FlatAppearance.BorderSize = 0;
            this.ParkButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ParkButton.Location = new System.Drawing.Point(458, 403);
            this.ParkButton.Name = "ParkButton";
            this.ParkButton.Size = new System.Drawing.Size(67, 32);
            this.ParkButton.TabIndex = 9;
            this.ParkButton.Text = "PARK";
            this.ParkButton.UseVisualStyleBackColor = false;
            this.ParkButton.Click += new System.EventHandler(this.ParkButton_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(702, 491);
            this.Controls.Add(this.ParkButton);
            this.Controls.Add(this.allButton);
            this.Controls.Add(this.listBox);
            this.Controls.Add(this.selectLabel);
            this.Controls.Add(this.showButton);
            this.Controls.Add(this.background);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form2";
            this.Text = "Select a starship";
            ((System.ComponentModel.ISupportInitialize)(this.background)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button showButton;
        private System.Windows.Forms.Label selectLabel;
        public System.Windows.Forms.ListBox listBox;
        private System.Windows.Forms.Button allButton;
        private System.Windows.Forms.PictureBox background;
        private System.Windows.Forms.Button ParkButton;
    }
}

