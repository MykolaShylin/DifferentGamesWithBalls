namespace ClosedBallsWinFormsApp
{
    partial class ClosedBallsForm : Form
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
            this.aLotOfBallsButton = new System.Windows.Forms.Button();
            this.leftCountBallsLabel = new System.Windows.Forms.Label();
            this.topCountBallsLabel = new System.Windows.Forms.Label();
            this.downCountBallsLabel = new System.Windows.Forms.Label();
            this.rightCountBallsLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // aLotOfBallsButton
            // 
            this.aLotOfBallsButton.Location = new System.Drawing.Point(638, 12);
            this.aLotOfBallsButton.Name = "aLotOfBallsButton";
            this.aLotOfBallsButton.Size = new System.Drawing.Size(150, 28);
            this.aLotOfBallsButton.TabIndex = 6;
            this.aLotOfBallsButton.Text = "Запустить шарики";
            this.aLotOfBallsButton.UseVisualStyleBackColor = true;
            this.aLotOfBallsButton.Click += new System.EventHandler(this.aLotOfBallsButton_Click);
            // 
            // leftCountBallsLabel
            // 
            this.leftCountBallsLabel.AutoSize = true;
            this.leftCountBallsLabel.Location = new System.Drawing.Point(12, 210);
            this.leftCountBallsLabel.Name = "leftCountBallsLabel";
            this.leftCountBallsLabel.Size = new System.Drawing.Size(17, 20);
            this.leftCountBallsLabel.TabIndex = 7;
            this.leftCountBallsLabel.Text = "0";
            // 
            // topCountBallsLabel
            // 
            this.topCountBallsLabel.AutoSize = true;
            this.topCountBallsLabel.Location = new System.Drawing.Point(391, 9);
            this.topCountBallsLabel.Name = "topCountBallsLabel";
            this.topCountBallsLabel.Size = new System.Drawing.Size(17, 20);
            this.topCountBallsLabel.TabIndex = 8;
            this.topCountBallsLabel.Text = "0";
            // 
            // downCountBallsLabel
            // 
            this.downCountBallsLabel.AutoSize = true;
            this.downCountBallsLabel.Location = new System.Drawing.Point(391, 421);
            this.downCountBallsLabel.Name = "downCountBallsLabel";
            this.downCountBallsLabel.Size = new System.Drawing.Size(17, 20);
            this.downCountBallsLabel.TabIndex = 9;
            this.downCountBallsLabel.Text = "0";
            // 
            // rightCountBallsLabel
            // 
            this.rightCountBallsLabel.AutoSize = true;
            this.rightCountBallsLabel.Location = new System.Drawing.Point(771, 210);
            this.rightCountBallsLabel.Name = "rightCountBallsLabel";
            this.rightCountBallsLabel.Size = new System.Drawing.Size(17, 20);
            this.rightCountBallsLabel.TabIndex = 10;
            this.rightCountBallsLabel.Text = "0";
            // 
            // ClosedBallsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.rightCountBallsLabel);
            this.Controls.Add(this.downCountBallsLabel);
            this.Controls.Add(this.topCountBallsLabel);
            this.Controls.Add(this.leftCountBallsLabel);
            this.Controls.Add(this.aLotOfBallsButton);
            this.Name = "ClosedBallsForm";
            this.Text = "Шарики №3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Button aLotOfBallsButton;
        private Label leftCountBallsLabel;
        private Label topCountBallsLabel;
        private Label downCountBallsLabel;
        private Label rightCountBallsLabel;
    }
}