namespace BensAlarmClock
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.timeDisplayLabel = new System.Windows.Forms.Label();
            this.inputTimeTextBox = new System.Windows.Forms.TextBox();
            this.stopAlarmButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.clockTimer = new System.Windows.Forms.Timer(this.components);
            this.alarmOnCheckBox = new System.Windows.Forms.CheckBox();
            this.messageLabel = new System.Windows.Forms.Label();
            this.alarmTimer = new System.Windows.Forms.Timer(this.components);
            this.clockTimer2 = new System.Windows.Forms.Timer(this.components);
            this.clockImage = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // timeDisplayLabel
            // 
            this.timeDisplayLabel.AutoSize = true;
            this.timeDisplayLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timeDisplayLabel.Location = new System.Drawing.Point(47, 27);
            this.timeDisplayLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.timeDisplayLabel.Name = "timeDisplayLabel";
            this.timeDisplayLabel.Size = new System.Drawing.Size(379, 69);
            this.timeDisplayLabel.TabIndex = 0;
            this.timeDisplayLabel.Text = "00:00:00 AM";
            // 
            // inputTimeTextBox
            // 
            this.inputTimeTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputTimeTextBox.Location = new System.Drawing.Point(79, 193);
            this.inputTimeTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.inputTimeTextBox.Name = "inputTimeTextBox";
            this.inputTimeTextBox.Size = new System.Drawing.Size(125, 37);
            this.inputTimeTextBox.TabIndex = 1;
            this.inputTimeTextBox.Text = "12:00:00";
            this.inputTimeTextBox.TextChanged += new System.EventHandler(this.inputTimeTextBox_TextChanged);
            // 
            // stopAlarmButton
            // 
            this.stopAlarmButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stopAlarmButton.Location = new System.Drawing.Point(475, 15);
            this.stopAlarmButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.stopAlarmButton.Name = "stopAlarmButton";
            this.stopAlarmButton.Size = new System.Drawing.Size(272, 146);
            this.stopAlarmButton.TabIndex = 5;
            this.stopAlarmButton.Text = "Stop Alarm";
            this.stopAlarmButton.UseVisualStyleBackColor = true;
            this.stopAlarmButton.Click += new System.EventHandler(this.stopAlarmButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(71, 405);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(638, 42);
            this.label1.TabIndex = 9;
            this.label1.Text = "Enter a Time and turn the alarm on!";
            // 
            // clockTimer
            // 
            this.clockTimer.Enabled = true;
            this.clockTimer.Interval = 1000;
            this.clockTimer.Tick += new System.EventHandler(this.Form1_Load);
            // 
            // alarmOnCheckBox
            // 
            this.alarmOnCheckBox.AutoSize = true;
            this.alarmOnCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.alarmOnCheckBox.Location = new System.Drawing.Point(79, 239);
            this.alarmOnCheckBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.alarmOnCheckBox.Name = "alarmOnCheckBox";
            this.alarmOnCheckBox.Size = new System.Drawing.Size(135, 33);
            this.alarmOnCheckBox.TabIndex = 10;
            this.alarmOnCheckBox.Text = "Alarm On";
            this.alarmOnCheckBox.UseVisualStyleBackColor = true;
            // 
            // messageLabel
            // 
            this.messageLabel.AutoSize = true;
            this.messageLabel.Location = new System.Drawing.Point(91, 361);
            this.messageLabel.Name = "messageLabel";
            this.messageLabel.Size = new System.Drawing.Size(0, 17);
            this.messageLabel.TabIndex = 13;
            // 
            // alarmTimer
            // 
            this.alarmTimer.Tick += new System.EventHandler(this.alarmTimer_Tick);
            // 
            // clockTimer2
            // 
            this.clockTimer2.Enabled = true;
            this.clockTimer2.Interval = 1000;
            this.clockTimer2.Tick += new System.EventHandler(this.clockTimer2_Tick);
            // 
            // clockImage
            // 
            this.clockImage.AutoSize = true;
            this.clockImage.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("clockImage.BackgroundImage")));
            this.clockImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.clockImage.Location = new System.Drawing.Point(475, 169);
            this.clockImage.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.clockImage.Name = "clockImage";
            this.clockImage.Size = new System.Drawing.Size(272, 208);
            this.clockImage.TabIndex = 14;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(763, 534);
            this.Controls.Add(this.clockImage);
            this.Controls.Add(this.messageLabel);
            this.Controls.Add(this.alarmOnCheckBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.stopAlarmButton);
            this.Controls.Add(this.inputTimeTextBox);
            this.Controls.Add(this.timeDisplayLabel);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Bens Alarm Clock";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label timeDisplayLabel;
        private System.Windows.Forms.TextBox inputTimeTextBox;
        private System.Windows.Forms.Button stopAlarmButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer clockTimer;
        private System.Windows.Forms.CheckBox alarmOnCheckBox;
        private System.Windows.Forms.Label messageLabel;
        private System.Windows.Forms.Timer alarmTimer;
        private System.Windows.Forms.Timer clockTimer2;
        private System.Windows.Forms.Panel clockImage;
    }
}

