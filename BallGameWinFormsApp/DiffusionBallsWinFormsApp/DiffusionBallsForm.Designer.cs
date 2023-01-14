namespace DiffusionBallsWinFormsApp
{
    partial class DiffusionBallsForm
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
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.topPressureLabel = new System.Windows.Forms.Label();
            this.downPressureLabel = new System.Windows.Forms.Label();
            this.leftPressureLabel = new System.Windows.Forms.Label();
            this.rightPressureLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Interval = 20;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // topPressureLabel
            // 
            this.topPressureLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.topPressureLabel.AutoSize = true;
            this.topPressureLabel.Location = new System.Drawing.Point(229, 9);
            this.topPressureLabel.Name = "topPressureLabel";
            this.topPressureLabel.Size = new System.Drawing.Size(49, 20);
            this.topPressureLabel.TabIndex = 0;
            this.topPressureLabel.Text = "0 атм.";
            this.topPressureLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // downPressureLabel
            // 
            this.downPressureLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.downPressureLabel.AutoSize = true;
            this.downPressureLabel.Location = new System.Drawing.Point(229, 617);
            this.downPressureLabel.Name = "downPressureLabel";
            this.downPressureLabel.Size = new System.Drawing.Size(49, 20);
            this.downPressureLabel.TabIndex = 1;
            this.downPressureLabel.Text = "0 атм.";
            // 
            // leftPressureLabel
            // 
            this.leftPressureLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.leftPressureLabel.AutoSize = true;
            this.leftPressureLabel.Location = new System.Drawing.Point(12, 301);
            this.leftPressureLabel.Name = "leftPressureLabel";
            this.leftPressureLabel.Size = new System.Drawing.Size(49, 20);
            this.leftPressureLabel.TabIndex = 2;
            this.leftPressureLabel.Text = "0 атм.";
            this.leftPressureLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // rightPressureLabel
            // 
            this.rightPressureLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rightPressureLabel.AutoSize = true;
            this.rightPressureLabel.Location = new System.Drawing.Point(419, 301);
            this.rightPressureLabel.Name = "rightPressureLabel";
            this.rightPressureLabel.Size = new System.Drawing.Size(49, 20);
            this.rightPressureLabel.TabIndex = 3;
            this.rightPressureLabel.Text = "0 атм.";
            this.rightPressureLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DiffusionBallsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(481, 646);
            this.Controls.Add(this.rightPressureLabel);
            this.Controls.Add(this.leftPressureLabel);
            this.Controls.Add(this.downPressureLabel);
            this.Controls.Add(this.topPressureLabel);
            this.Name = "DiffusionBallsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Диффузия";
            this.Load += new System.EventHandler(this.DiffusionBallsForm_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.DiffusionBallsForm_Paint);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.DiffusionBallsForm_MouseDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private Label topPressureLabel;
        private Label downPressureLabel;
        private Label leftPressureLabel;
        private Label rightPressureLabel;
    }
}