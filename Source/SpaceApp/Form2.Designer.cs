
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
            ((System.ComponentModel.ISupportInitialize)(this.background)).BeginInit();
            this.SuspendLayout();
            // 
            // showButton
            // 
            this.showButton.BackColor = System.Drawing.Color.Yellow;
            this.showButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.showButton.Location = new System.Drawing.Point(145, 84);
            this.showButton.Name = "showButton";
            this.showButton.Size = new System.Drawing.Size(150, 24);
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
            this.selectLabel.Location = new System.Drawing.Point(27, 37);
            this.selectLabel.Name = "selectLabel";
            this.selectLabel.Size = new System.Drawing.Size(472, 38);
            this.selectLabel.TabIndex = 2;
            this.selectLabel.Text = "SELECT STARSHIP TO PARK";
            // 
            // listBox
            // 
            this.listBox.BackColor = System.Drawing.SystemColors.WindowText;
            this.listBox.ForeColor = System.Drawing.Color.Gold;
            this.listBox.FormattingEnabled = true;
            this.listBox.ItemHeight = 15;
            this.listBox.Location = new System.Drawing.Point(145, 127);
            this.listBox.Name = "listBox";
            this.listBox.Size = new System.Drawing.Size(314, 184);
            this.listBox.TabIndex = 4;
            this.listBox.Click += new System.EventHandler(this.ShipIsSelected);
            // 
            // allButton
            // 
            this.allButton.BackColor = System.Drawing.Color.Yellow;
            this.allButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.allButton.Location = new System.Drawing.Point(314, 84);
            this.allButton.Name = "allButton";
            this.allButton.Size = new System.Drawing.Size(145, 23);
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
            this.background.Location = new System.Drawing.Point(-11, -9);
            this.background.Name = "background";
            this.background.Size = new System.Drawing.Size(639, 390);
            this.background.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.background.TabIndex = 8;
            this.background.TabStop = false;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(614, 368);
            this.Controls.Add(this.allButton);
            this.Controls.Add(this.listBox);
            this.Controls.Add(this.selectLabel);
            this.Controls.Add(this.showButton);
            this.Controls.Add(this.background);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
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
    }
}

