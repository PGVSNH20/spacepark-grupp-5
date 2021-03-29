
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
            this.SelectShip = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.shipLabel = new System.Windows.Forms.Label();
            this.shipLabelSelected = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.background)).BeginInit();
            this.SuspendLayout();
            // 
            // showButton
            // 
            this.showButton.BackColor = System.Drawing.Color.Black;
            this.showButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.showButton.FlatAppearance.BorderColor = System.Drawing.Color.Gold;
            this.showButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LimeGreen;
            this.showButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGreen;
            this.showButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.showButton.ForeColor = System.Drawing.Color.Gold;
            this.showButton.Location = new System.Drawing.Point(95, 310);
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
            this.selectLabel.Location = new System.Drawing.Point(56, 55);
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
            this.listBox.Location = new System.Drawing.Point(95, 126);
            this.listBox.Name = "listBox";
            this.listBox.Size = new System.Drawing.Size(314, 169);
            this.listBox.TabIndex = 4;
            this.listBox.Click += new System.EventHandler(this.ShipIsSelected);
            // 
            // allButton
            // 
            this.allButton.BackColor = System.Drawing.Color.Black;
            this.allButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.allButton.FlatAppearance.BorderColor = System.Drawing.Color.Gold;
            this.allButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LimeGreen;
            this.allButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGreen;
            this.allButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.allButton.ForeColor = System.Drawing.Color.Gold;
            this.allButton.Location = new System.Drawing.Point(264, 310);
            this.allButton.Name = "allButton";
            this.allButton.Size = new System.Drawing.Size(145, 24);
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
            // SelectShip
            // 
            this.SelectShip.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.SelectShip.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SelectShip.Enabled = false;
            this.SelectShip.FlatAppearance.BorderColor = System.Drawing.Color.Gold;
            this.SelectShip.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SelectShip.ForeColor = System.Drawing.Color.Black;
            this.SelectShip.Location = new System.Drawing.Point(469, 237);
            this.SelectShip.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SelectShip.Name = "SelectShip";
            this.SelectShip.Size = new System.Drawing.Size(59, 22);
            this.SelectShip.TabIndex = 9;
            this.SelectShip.Text = "SELECT";
            this.SelectShip.UseVisualStyleBackColor = false;
            this.SelectShip.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Black;
            this.label1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Gold;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 21);
            this.label1.TabIndex = 20;
            this.label1.Text = "< Go back";
            this.label1.Click += new System.EventHandler(this.GoBack);
            // 
            // shipLabel
            // 
            this.shipLabel.AutoSize = true;
            this.shipLabel.BackColor = System.Drawing.Color.Black;
            this.shipLabel.ForeColor = System.Drawing.Color.Gold;
            this.shipLabel.Location = new System.Drawing.Point(449, 168);
            this.shipLabel.Name = "shipLabel";
            this.shipLabel.Size = new System.Drawing.Size(79, 15);
            this.shipLabel.TabIndex = 21;
            this.shipLabel.Text = "Selected ship:";
            // 
            // shipLabelSelected
            // 
            this.shipLabelSelected.AutoSize = true;
            this.shipLabelSelected.BackColor = System.Drawing.Color.Black;
            this.shipLabelSelected.ForeColor = System.Drawing.Color.Gold;
            this.shipLabelSelected.Location = new System.Drawing.Point(449, 194);
            this.shipLabelSelected.Name = "shipLabelSelected";
            this.shipLabelSelected.Size = new System.Drawing.Size(0, 15);
            this.shipLabelSelected.TabIndex = 22;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(614, 368);
            this.Controls.Add(this.shipLabelSelected);
            this.Controls.Add(this.shipLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SelectShip);
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
        private System.Windows.Forms.Button SelectShip;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label shipLabel;
        private System.Windows.Forms.Label shipLabelSelected;
    }
}

