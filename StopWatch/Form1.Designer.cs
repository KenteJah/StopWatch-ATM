namespace StopWatch
{
    partial class StopWatch
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
            components = new System.ComponentModel.Container();
            watchLabel = new Label();
            startButton = new Button();
            stopButton = new Button();
            resetButton = new Button();
            formTimer = new System.Windows.Forms.Timer(components);
            SuspendLayout();
            // 
            // watchLabel
            // 
            watchLabel.Font = new Font("Segoe UI", 72F, FontStyle.Regular, GraphicsUnit.Point);
            watchLabel.ForeColor = SystemColors.ControlLightLight;
            watchLabel.Location = new Point(12, 69);
            watchLabel.Name = "watchLabel";
            watchLabel.Size = new Size(806, 151);
            watchLabel.TabIndex = 0;
            watchLabel.Text = "00:00.00";
            watchLabel.TextAlign = ContentAlignment.TopCenter;
            // 
            // startButton
            // 
            startButton.BackColor = Color.FromArgb(64, 64, 64);
            startButton.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            startButton.ForeColor = SystemColors.ControlLightLight;
            startButton.Location = new Point(12, 373);
            startButton.Name = "startButton";
            startButton.Size = new Size(215, 86);
            startButton.TabIndex = 1;
            startButton.Text = "Start";
            startButton.UseVisualStyleBackColor = false;
            startButton.Click += startButton_Click;
            // 
            // stopButton
            // 
            stopButton.BackColor = Color.FromArgb(64, 64, 64);
            stopButton.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            stopButton.ForeColor = SystemColors.ControlLightLight;
            stopButton.Location = new Point(307, 373);
            stopButton.Name = "stopButton";
            stopButton.Size = new Size(215, 86);
            stopButton.TabIndex = 2;
            stopButton.Text = "Stop";
            stopButton.UseVisualStyleBackColor = false;
            stopButton.Click += stopButton_Click;
            // 
            // resetButton
            // 
            resetButton.BackColor = Color.FromArgb(64, 64, 64);
            resetButton.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            resetButton.ForeColor = SystemColors.ControlLightLight;
            resetButton.Location = new Point(603, 373);
            resetButton.Name = "resetButton";
            resetButton.Size = new Size(215, 86);
            resetButton.TabIndex = 3;
            resetButton.Text = "Reset";
            resetButton.UseVisualStyleBackColor = false;
            resetButton.Click += resetButton_Click;
            // 
            // formTimer
            // 
            formTimer.Interval = 10;
            formTimer.Tick += formTimer_Tick;
            // 
            // StopWatch
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Desktop;
            ClientSize = new Size(830, 471);
            Controls.Add(resetButton);
            Controls.Add(stopButton);
            Controls.Add(startButton);
            Controls.Add(watchLabel);
            Name = "StopWatch";
            Text = "StopWatch";
            Load += StopWatch_Load;
            ResumeLayout(false);
        }

        #endregion

        private Label watchLabel;
        private Button startButton;
        private Button stopButton;
        private Button resetButton;
        private System.Windows.Forms.Timer formTimer;
    }
}