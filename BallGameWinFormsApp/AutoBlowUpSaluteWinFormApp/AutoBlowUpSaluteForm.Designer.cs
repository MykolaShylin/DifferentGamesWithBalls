namespace AutoBlowUpSaluteWinFormApp
{
    partial class AutoBlowUpSaluteForm
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
            this.components = new System.ComponentModel.Container();
            this.rocketLauncherTimer = new System.Windows.Forms.Timer(this.components);
            this.LaunchSaluteButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rocketLauncherTimer
            // 
            this.rocketLauncherTimer.Interval = 20;
            this.rocketLauncherTimer.Tick += new System.EventHandler(this.rocketLauncherTimer_Tick);
            // 
            // LaunchSaluteButton
            // 
            this.LaunchSaluteButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LaunchSaluteButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LaunchSaluteButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LaunchSaluteButton.ForeColor = System.Drawing.Color.Red;
            this.LaunchSaluteButton.Location = new System.Drawing.Point(928, 12);
            this.LaunchSaluteButton.Name = "LaunchSaluteButton";
            this.LaunchSaluteButton.Size = new System.Drawing.Size(215, 45);
            this.LaunchSaluteButton.TabIndex = 0;
            this.LaunchSaluteButton.Text = "Зажечь фитиль";
            this.LaunchSaluteButton.UseVisualStyleBackColor = true;
            this.LaunchSaluteButton.Click += new System.EventHandler(this.LaunchSaluteButton_Click);

            // AutoBlowUpSaluteForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(1155, 629);
            this.Controls.Add(this.LaunchSaluteButton);
            this.Name = "AutoBlowUpSaluteForm";
            this.Text = "Автоматический салют";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer rocketLauncherTimer;
        private Button LaunchSaluteButton;
    }
}