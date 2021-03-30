
namespace SpaceApp
{
    partial class ParkingTimerForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ParkingTimerForm));
            this.background = new System.Windows.Forms.PictureBox();
            this.listbox = new System.Windows.Forms.ListBox();
            this.timePicker = new System.Windows.Forms.DateTimePicker();
            this.currentTime = new System.Windows.Forms.Label();
            this.currentTimeLabel = new System.Windows.Forms.Label();
            this.currentTimeTimer = new System.Windows.Forms.Timer(this.components);
            this.parkButton = new System.Windows.Forms.Button();
            this.dbButton = new System.Windows.Forms.Button();
            this.nameLabel = new System.Windows.Forms.Label();
            this.shipLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.background)).BeginInit();
            this.SuspendLayout();
            // 
            // background
            // 
            this.background.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.background.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.background.Image = ((System.Drawing.Image)(resources.GetObject("background.Image")));
            this.background.Location = new System.Drawing.Point(-12, -22);
            this.background.Name = "background";
            this.background.Size = new System.Drawing.Size(639, 465);
            this.background.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.background.TabIndex = 9;
            this.background.TabStop = false;
            // 
            // listbox
            // 
            this.listbox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listbox.BackColor = System.Drawing.SystemColors.WindowText;
            this.listbox.ForeColor = System.Drawing.Color.Gold;
            this.listbox.FormattingEnabled = true;
            this.listbox.ItemHeight = 15;
            this.listbox.Location = new System.Drawing.Point(61, 224);
            this.listbox.Name = "listbox";
            this.listbox.Size = new System.Drawing.Size(490, 169);
            this.listbox.TabIndex = 4;
            // 
            // timePicker
            // 
            this.timePicker.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.timePicker.CalendarForeColor = System.Drawing.SystemColors.HotTrack;
            this.timePicker.CalendarMonthBackground = System.Drawing.SystemColors.InactiveBorder;
            this.timePicker.CustomFormat = "HH:mm";
            this.timePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.timePicker.Location = new System.Drawing.Point(61, 179);
            this.timePicker.Name = "timePicker";
            this.timePicker.ShowUpDown = true;
            this.timePicker.Size = new System.Drawing.Size(61, 23);
            this.timePicker.TabIndex = 12;
            this.timePicker.Value = new System.DateTime(2021, 3, 29, 15, 46, 0, 0);
            // 
            // currentTime
            // 
            this.currentTime.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.currentTime.AutoSize = true;
            this.currentTime.BackColor = System.Drawing.Color.Black;
            this.currentTime.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.currentTime.ForeColor = System.Drawing.Color.Gold;
            this.currentTime.Location = new System.Drawing.Point(392, 173);
            this.currentTime.Name = "currentTime";
            this.currentTime.Size = new System.Drawing.Size(25, 30);
            this.currentTime.TabIndex = 13;
            this.currentTime.Text = "0";
            // 
            // currentTimeLabel
            // 
            this.currentTimeLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.currentTimeLabel.AutoSize = true;
            this.currentTimeLabel.BackColor = System.Drawing.Color.Black;
            this.currentTimeLabel.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.currentTimeLabel.ForeColor = System.Drawing.Color.Gold;
            this.currentTimeLabel.Location = new System.Drawing.Point(240, 171);
            this.currentTimeLabel.Name = "currentTimeLabel";
            this.currentTimeLabel.Size = new System.Drawing.Size(136, 30);
            this.currentTimeLabel.TabIndex = 14;
            this.currentTimeLabel.Text = "current time:";
            // 
            // currentTimeTimer
            // 
            this.currentTimeTimer.Enabled = true;
            this.currentTimeTimer.Interval = 200;
            this.currentTimeTimer.Tick += new System.EventHandler(this.currentTimeChange);
            // 
            // parkButton
            // 
            this.parkButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.parkButton.BackColor = System.Drawing.Color.Black;
            this.parkButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.parkButton.FlatAppearance.BorderColor = System.Drawing.Color.Gold;
            this.parkButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LimeGreen;
            this.parkButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGreen;
            this.parkButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.parkButton.ForeColor = System.Drawing.Color.Gold;
            this.parkButton.Location = new System.Drawing.Point(152, 178);
            this.parkButton.Name = "parkButton";
            this.parkButton.Size = new System.Drawing.Size(57, 24);
            this.parkButton.TabIndex = 15;
            this.parkButton.Text = "Park";
            this.parkButton.UseVisualStyleBackColor = false;
            this.parkButton.Click += new System.EventHandler(this.timeIsPicked);
            // 
            // dbButton
            // 
            this.dbButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.dbButton.BackColor = System.Drawing.Color.Black;
            this.dbButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dbButton.FlatAppearance.BorderColor = System.Drawing.Color.Gold;
            this.dbButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LimeGreen;
            this.dbButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGreen;
            this.dbButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dbButton.ForeColor = System.Drawing.Color.Gold;
            this.dbButton.Location = new System.Drawing.Point(494, 178);
            this.dbButton.Name = "dbButton";
            this.dbButton.Size = new System.Drawing.Size(57, 24);
            this.dbButton.TabIndex = 16;
            this.dbButton.Text = "History";
            this.dbButton.UseVisualStyleBackColor = false;
            this.dbButton.Click += new System.EventHandler(this.dbButton_Click);
            // 
            // nameLabel
            // 
            this.nameLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.nameLabel.AutoSize = true;
            this.nameLabel.BackColor = System.Drawing.Color.Black;
            this.nameLabel.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.nameLabel.ForeColor = System.Drawing.Color.Gold;
            this.nameLabel.Location = new System.Drawing.Point(61, 113);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(72, 30);
            this.nameLabel.TabIndex = 17;
            this.nameLabel.Text = "name:";
            // 
            // shipLabel
            // 
            this.shipLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.shipLabel.AutoSize = true;
            this.shipLabel.BackColor = System.Drawing.Color.Black;
            this.shipLabel.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.shipLabel.ForeColor = System.Drawing.Color.Gold;
            this.shipLabel.Location = new System.Drawing.Point(321, 113);
            this.shipLabel.Name = "shipLabel";
            this.shipLabel.Size = new System.Drawing.Size(92, 30);
            this.shipLabel.TabIndex = 18;
            this.shipLabel.Text = "starship:";
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
            this.label1.TabIndex = 19;
            this.label1.Text = "< Go back";
            this.label1.Click += new System.EventHandler(this.GoBack);
            // 
            // ParkingTimerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(614, 420);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.shipLabel);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.dbButton);
            this.Controls.Add(this.listbox);
            this.Controls.Add(this.parkButton);
            this.Controls.Add(this.currentTimeLabel);
            this.Controls.Add(this.currentTime);
            this.Controls.Add(this.timePicker);
            this.Controls.Add(this.background);
            this.Name = "ParkingTimerForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ParkingTimerForm";
            ((System.ComponentModel.ISupportInitialize)(this.background)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox background;
        public System.Windows.Forms.ListBox listbox;
        private System.Windows.Forms.DateTimePicker timePicker;
        private System.Windows.Forms.Label currentTime;
        private System.Windows.Forms.Label currentTimeLabel;
        private System.Windows.Forms.Timer currentTimeTimer;
        private System.Windows.Forms.Button parkButton;
        private System.Windows.Forms.Button dbButton;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label shipLabel;
        private System.Windows.Forms.Label label1;
    }
}