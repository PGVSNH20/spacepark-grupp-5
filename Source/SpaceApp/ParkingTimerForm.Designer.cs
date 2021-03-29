
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
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.timerButton = new System.Windows.Forms.Button();
            this.timerLabel = new System.Windows.Forms.Label();
            this.timePicker = new System.Windows.Forms.DateTimePicker();
            this.currentTime = new System.Windows.Forms.Label();
            this.currentTimeLabel = new System.Windows.Forms.Label();
            this.currentTimeTimer = new System.Windows.Forms.Timer(this.components);
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
            this.background.Controls.Add(this.listbox);
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
            this.listbox.BackColor = System.Drawing.SystemColors.WindowText;
            this.listbox.ForeColor = System.Drawing.Color.Gold;
            this.listbox.FormattingEnabled = true;
            this.listbox.ItemHeight = 15;
            this.listbox.Location = new System.Drawing.Point(145, 172);
            this.listbox.Name = "listbox";
            this.listbox.Size = new System.Drawing.Size(314, 184);
            this.listbox.TabIndex = 4;
            // 
            // timer
            // 
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timerButton
            // 
            this.timerButton.BackColor = System.Drawing.Color.Yellow;
            this.timerButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.timerButton.Location = new System.Drawing.Point(133, 105);
            this.timerButton.Name = "timerButton";
            this.timerButton.Size = new System.Drawing.Size(57, 24);
            this.timerButton.TabIndex = 10;
            this.timerButton.Text = "Start";
            this.timerButton.UseVisualStyleBackColor = false;
            this.timerButton.Click += new System.EventHandler(this.timerButton_Click);
            // 
            // timerLabel
            // 
            this.timerLabel.AutoSize = true;
            this.timerLabel.BackColor = System.Drawing.Color.Black;
            this.timerLabel.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.timerLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.timerLabel.Location = new System.Drawing.Point(196, 90);
            this.timerLabel.Name = "timerLabel";
            this.timerLabel.Size = new System.Drawing.Size(34, 41);
            this.timerLabel.TabIndex = 11;
            this.timerLabel.Text = "0";
            this.timerLabel.Visible = false;
            // 
            // timePicker
            // 
            this.timePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.timePicker.Location = new System.Drawing.Point(247, 104);
            this.timePicker.Name = "timePicker";
            this.timePicker.Size = new System.Drawing.Size(85, 23);
            this.timePicker.TabIndex = 12;
            this.timePicker.ValueChanged += new System.EventHandler(this.timeIsPicked);
            // 
            // currentTime
            // 
            this.currentTime.AutoSize = true;
            this.currentTime.BackColor = System.Drawing.Color.Black;
            this.currentTime.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.currentTime.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.currentTime.Location = new System.Drawing.Point(275, 31);
            this.currentTime.Name = "currentTime";
            this.currentTime.Size = new System.Drawing.Size(25, 30);
            this.currentTime.TabIndex = 13;
            this.currentTime.Text = "0";
            // 
            // currentTimeLabel
            // 
            this.currentTimeLabel.AutoSize = true;
            this.currentTimeLabel.BackColor = System.Drawing.Color.Black;
            this.currentTimeLabel.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.currentTimeLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.currentTimeLabel.Location = new System.Drawing.Point(133, 31);
            this.currentTimeLabel.Name = "currentTimeLabel";
            this.currentTimeLabel.Size = new System.Drawing.Size(136, 30);
            this.currentTimeLabel.TabIndex = 14;
            this.currentTimeLabel.Text = "current time:";
            // 
            // currentTimeTimer
            // 
            this.currentTimeTimer.Interval = 10;
            this.currentTimeTimer.Tick += new System.EventHandler(this.currentTimeChange);
            // 
            // ParkingTimerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(614, 420);
            this.Controls.Add(this.currentTimeLabel);
            this.Controls.Add(this.currentTime);
            this.Controls.Add(this.timePicker);
            this.Controls.Add(this.timerLabel);
            this.Controls.Add(this.timerButton);
            this.Controls.Add(this.background);
            this.Name = "ParkingTimerForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ParkingTimerForm";
            ((System.ComponentModel.ISupportInitialize)(this.background)).EndInit();
            this.background.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox background;
        public System.Windows.Forms.ListBox listbox;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Button timerButton;
        private System.Windows.Forms.Label timerLabel;
        private System.Windows.Forms.DateTimePicker timePicker;
        private System.Windows.Forms.Label currentTime;
        private System.Windows.Forms.Label currentTimeLabel;
        private System.Windows.Forms.Timer currentTimeTimer;
    }
}