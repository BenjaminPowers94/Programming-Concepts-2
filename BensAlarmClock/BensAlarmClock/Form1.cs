using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BensAlarmClock
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        DateTime alarmDateTime;
        System.Media.SoundPlayer player;

        private void Form1_Load(object sender, EventArgs e)
        {
            //timeDisplayLabel.Text = "";
            timeDisplayLabel.Text = DateTime.Now.ToString("hh:mm:ss");
             player = new System.Media.SoundPlayer();
        }

        private void inputTimeTextBox_TextChanged(object sender, EventArgs e)
        {
            
            if (DateTime.TryParse(inputTimeTextBox.Text, out alarmDateTime))
            {
                alarmOnCheckBox.Checked = true;
                messageLabel.Text = "";

            }
            else
            {
                alarmOnCheckBox.Checked = false;
                messageLabel.Text = "Invalid input";
                messageLabel.ForeColor = Color.Red;

            }
        }

        private int clockVib = 0;
        private bool isPlaying = false;
        private void alarmTimer_Tick(object sender, EventArgs e)
        {
            if (alarmOnCheckBox.Checked)
            {
                player.SoundLocation = @"c:\windows\media\Windows Logoff Sound.wav";
                if(!isPlaying)
                {
                    player.PlayLooping();
                    isPlaying = true;
                }

                clockVib = (clockVib + 1) % 2;
                clockImage.Location = new Point(356 + clockVib*5, 137 + clockVib*5);
            }
            else
            {
                alarmTimer.Enabled = false;
                player.Stop();
                isPlaying = false;
            }



        }

        private void clockTimer2_Tick(object sender, EventArgs e)
        {
            if (alarmOnCheckBox.Checked &&
                DateTime.Now.ToString("hh:mm:ss") == alarmDateTime.ToString("hh:mm:ss"))
                alarmTimer.Enabled = true;
        }

        private void stopAlarmButton_Click(object sender, EventArgs e)
        {
            alarmTimer.Enabled = false;
            player.Stop();
            isPlaying = false;
        }

    }
}
