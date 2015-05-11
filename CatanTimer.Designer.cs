namespace CatanTimer
{
    partial class CatanTimer
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
            this.Timer = new System.Windows.Forms.Timer(this.components);
            this.TimerLabel = new System.Windows.Forms.Label();
            this.TimerPanel = new System.Windows.Forms.Panel();
            this.TimerButtonsPanel = new System.Windows.Forms.Panel();
            this.PlayPauseButton = new System.Windows.Forms.Button();
            this.ThirtySecondsButton = new System.Windows.Forms.Button();
            this.NextTurnButton = new System.Windows.Forms.Button();
            this.TimerPanel.SuspendLayout();
            this.TimerButtonsPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // Timer
            // 
            this.Timer.Interval = 10;
            this.Timer.Tick += new System.EventHandler(this.Timer_Tick);
            // 
            // TimerLabel
            // 
            this.TimerLabel.AutoSize = true;
            this.TimerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 200F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TimerLabel.ForeColor = System.Drawing.Color.Red;
            this.TimerLabel.Location = new System.Drawing.Point(150, 10);
            this.TimerLabel.Name = "TimerLabel";
            this.TimerLabel.Size = new System.Drawing.Size(793, 302);
            this.TimerLabel.TabIndex = 0;
            this.TimerLabel.Text = "00:00";
            // 
            // TimerPanel
            // 
            this.TimerPanel.Controls.Add(this.TimerButtonsPanel);
            this.TimerPanel.Controls.Add(this.TimerLabel);
            this.TimerPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.TimerPanel.Location = new System.Drawing.Point(0, 0);
            this.TimerPanel.Name = "TimerPanel";
            this.TimerPanel.Size = new System.Drawing.Size(1114, 374);
            this.TimerPanel.TabIndex = 3;
            this.TimerPanel.Resize += new System.EventHandler(this.TimerPanel_Resize);
            // 
            // TimerButtonsPanel
            // 
            this.TimerButtonsPanel.Controls.Add(this.PlayPauseButton);
            this.TimerButtonsPanel.Controls.Add(this.ThirtySecondsButton);
            this.TimerButtonsPanel.Controls.Add(this.NextTurnButton);
            this.TimerButtonsPanel.Location = new System.Drawing.Point(201, 274);
            this.TimerButtonsPanel.Name = "TimerButtonsPanel";
            this.TimerButtonsPanel.Size = new System.Drawing.Size(672, 100);
            this.TimerButtonsPanel.TabIndex = 4;
            // 
            // PlayPauseButton
            // 
            this.PlayPauseButton.AutoSize = true;
            this.PlayPauseButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.PlayPauseButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PlayPauseButton.Location = new System.Drawing.Point(23, 23);
            this.PlayPauseButton.Name = "PlayPauseButton";
            this.PlayPauseButton.Size = new System.Drawing.Size(162, 50);
            this.PlayPauseButton.TabIndex = 4;
            this.PlayPauseButton.Text = "Play/Pause";
            this.PlayPauseButton.UseVisualStyleBackColor = true;
            this.PlayPauseButton.Click += new System.EventHandler(this.PlayPauseButton_Click);
            // 
            // ThirtySecondsButton
            // 
            this.ThirtySecondsButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ThirtySecondsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ThirtySecondsButton.Location = new System.Drawing.Point(550, 23);
            this.ThirtySecondsButton.Name = "ThirtySecondsButton";
            this.ThirtySecondsButton.Size = new System.Drawing.Size(100, 50);
            this.ThirtySecondsButton.TabIndex = 2;
            this.ThirtySecondsButton.Text = "30s";
            this.ThirtySecondsButton.UseVisualStyleBackColor = true;
            this.ThirtySecondsButton.Click += new System.EventHandler(this.ThirtySecondsButton_Click);
            // 
            // NextTurnButton
            // 
            this.NextTurnButton.AutoSize = true;
            this.NextTurnButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.NextTurnButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NextTurnButton.Location = new System.Drawing.Point(278, 23);
            this.NextTurnButton.Name = "NextTurnButton";
            this.NextTurnButton.Size = new System.Drawing.Size(145, 50);
            this.NextTurnButton.TabIndex = 3;
            this.NextTurnButton.Text = "Next Turn";
            this.NextTurnButton.UseVisualStyleBackColor = true;
            this.NextTurnButton.Click += new System.EventHandler(this.NextTurnButton_Click);
            // 
            // CatanTimer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1114, 534);
            this.Controls.Add(this.TimerPanel);
            this.KeyPreview = true;
            this.Name = "CatanTimer";
            this.Text = "CatanTimer";
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.CatanTimer_KeyUp);
            this.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.CatanTimer_PreviewKeyDown);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.CatanTimer_KeyDown);
            this.TimerPanel.ResumeLayout(false);
            this.TimerPanel.PerformLayout();
            this.TimerButtonsPanel.ResumeLayout(false);
            this.TimerButtonsPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer Timer;
        private System.Windows.Forms.Label TimerLabel;
        private System.Windows.Forms.Panel TimerPanel;
        private System.Windows.Forms.Button ThirtySecondsButton;
        private System.Windows.Forms.Button NextTurnButton;
        private System.Windows.Forms.Panel TimerButtonsPanel;
        private System.Windows.Forms.Button PlayPauseButton;
    }
}