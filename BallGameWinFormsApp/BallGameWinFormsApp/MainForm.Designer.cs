namespace BallGameWinFormsApp
{
    partial class MainForm
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
            this.stopMovingButton = new System.Windows.Forms.Button();
            this.aLotOfBallsButton = new System.Windows.Forms.Button();
            this.clearMapButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // stopMovingButton
            // 
            this.stopMovingButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.stopMovingButton.Enabled = false;
            this.stopMovingButton.Location = new System.Drawing.Point(619, 12);
            this.stopMovingButton.Name = "stopMovingButton";
            this.stopMovingButton.Size = new System.Drawing.Size(214, 43);
            this.stopMovingButton.TabIndex = 2;
            this.stopMovingButton.Text = "Остановить все шарики";
            this.stopMovingButton.UseVisualStyleBackColor = true;
            this.stopMovingButton.Click += new System.EventHandler(this.stopMovingButton_Click);
            // 
            // aLotOfBallsButton
            // 
            this.aLotOfBallsButton.Location = new System.Drawing.Point(439, 12);
            this.aLotOfBallsButton.Name = "aLotOfBallsButton";
            this.aLotOfBallsButton.Size = new System.Drawing.Size(162, 43);
            this.aLotOfBallsButton.TabIndex = 3;
            this.aLotOfBallsButton.Text = "Много шариков";
            this.aLotOfBallsButton.UseVisualStyleBackColor = true;
            this.aLotOfBallsButton.Click += new System.EventHandler(this.aLotOfBallsButton_Click);
            // 
            // clearMapButton
            // 
            this.clearMapButton.Enabled = false;
            this.clearMapButton.Location = new System.Drawing.Point(619, 61);
            this.clearMapButton.Name = "clearMapButton";
            this.clearMapButton.Size = new System.Drawing.Size(214, 43);
            this.clearMapButton.TabIndex = 4;
            this.clearMapButton.Text = "Очистить поле";
            this.clearMapButton.UseVisualStyleBackColor = true;
            this.clearMapButton.Click += new System.EventHandler(this.clearMapButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(845, 482);
            this.Controls.Add(this.clearMapButton);
            this.Controls.Add(this.aLotOfBallsButton);
            this.Controls.Add(this.stopMovingButton);
            this.Name = "MainForm";
            this.Text = "Мячики";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MainForm_MouseDown);
            this.ResumeLayout(false);

        }

        #endregion
        private Button stopMovingButton;
        private Button aLotOfBallsButton;
        private Button clearMapButton;
    }
}