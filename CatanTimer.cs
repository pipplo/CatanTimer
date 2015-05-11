using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Media;
using System.Reflection;
using System.Text;
using System.Windows.Forms;

namespace CatanTimer
{
    public partial class CatanTimer : Form
    {
        // This value will be set when a button is clicked and will set our target value for the timer.  This is in  milliseconds
        public int MillisecondsLeft = 0;
        public const int SIXTY_SECONDS = 60000;
        public const int THIRTY_SECONDS = 30000;
        public const int MILLISECONDS_PER_SECOND = 1000;

        public SoundPlayer Player;
        public CatanTimer()
        {
            InitializeComponent();

            Player = new SoundPlayer(Properties.Resources.clarinet);
        }

        // Override IsInputKey method to identify the Special keys
        protected override  bool ProcessTabKey(bool forward)
        {
            forward = true;

            return forward;
        }

        private void UpdateTimerLabelText()
        {
            float time = (float)MillisecondsLeft / MILLISECONDS_PER_SECOND;

            if (time == 0)
            {
                TimerLabel.Text = "Done!";
            }
            else
            {
                TimerLabel.Text = time.ToString("F2") + "s";
            }
        }

        private void PlayTimerSound()
        {
            //Stream stream = Assembly.GetExecutingAssembly().GetManifestResourceStream("CatanTimer.clarinet.wav");
            Player.Play();
        }

        #region Click_Actions
        private void ThirtySecondsButton_Click(object sender, EventArgs e)
        {
            MillisecondsLeft = THIRTY_SECONDS;
            Timer.Enabled = true;
        }

        private void NextTurnButton_Click(object sender, EventArgs e)
        {
            MillisecondsLeft = SIXTY_SECONDS;
            Timer.Enabled = true;
        }

        private void PlayPauseButton_Click(object sender, EventArgs e)
        {
            if (MillisecondsLeft > 0)
            {
                Timer.Enabled = !Timer.Enabled;
            }
        }
        #endregion

        private void Timer_Tick(object sender, EventArgs e)
        {
            // Decrement Timer
            MillisecondsLeft -= Timer.Interval;

            if (MillisecondsLeft <= 0)
            {
                MillisecondsLeft = 0;
                PlayTimerSound();
                Timer.Enabled = false;
            }
            UpdateTimerLabelText();
        }
        private void TimerPanel_Resize(object sender, EventArgs e)
        {
            // We need to do two things:
            // 1. Center the timer label (left - right)
            // 2. Center the Buttons panel (left - right)
            Point location;

            location = TimerLabel.Location;
            location.X = (TimerPanel.Width / 2 ) - (TimerLabel.Width / 2);
            TimerLabel.Location = location;

            location = TimerButtonsPanel.Location;
            location.X = (TimerPanel.Width / 2) - (TimerButtonsPanel.Width / 2);
            TimerButtonsPanel.Location = location;

        }

        private void CatanTimer_KeyUp(object sender, KeyEventArgs e)
        {

        }

        private void CatanTimer_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                PlayPauseButton_Click(sender, e);
                e.Handled = true;
            }
            else if (e.KeyCode == Keys.Tab)
            {
                ThirtySecondsButton_Click(sender, e);
                e.Handled = true;
            }
            else if (e.KeyCode == Keys.Enter)
            {
                NextTurnButton_Click(sender, e);
                e.Handled = true;
            }
        }

        private void CatanTimer_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyCode == Keys.Tab)
            {
                e.IsInputKey = true;
            }

        }
    }
}
