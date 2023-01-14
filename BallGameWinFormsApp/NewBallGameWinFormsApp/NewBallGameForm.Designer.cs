namespace NewBallGameWinFormsApp
{
    partial class NewBallGameForm : Form
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
            this.aLotOfBallsButton = new System.Windows.Forms.Button();
            this.stopMovingButton = new System.Windows.Forms.Button();
            this.countLabel = new System.Windows.Forms.Label();
            this.catchesBallsCountLabel = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // aLotOfBallsButton
            // 
            this.aLotOfBallsButton.Location = new System.Drawing.Point(406, 12);
            this.aLotOfBallsButton.Name = "aLotOfBallsButton";
            this.aLotOfBallsButton.Size = new System.Drawing.Size(162, 43);
            this.aLotOfBallsButton.TabIndex = 6;
            this.aLotOfBallsButton.Text = "Много шариков";
            this.aLotOfBallsButton.UseVisualStyleBackColor = true;
            this.aLotOfBallsButton.Click += new System.EventHandler(this.aLotOfBallsButton_Click);
            // 
            // stopMovingButton
            // 
            this.stopMovingButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.stopMovingButton.Enabled = false;
            this.stopMovingButton.Location = new System.Drawing.Point(574, 12);
            this.stopMovingButton.Name = "stopMovingButton";
            this.stopMovingButton.Size = new System.Drawing.Size(214, 43);
            this.stopMovingButton.TabIndex = 5;
            this.stopMovingButton.Text = "Остановить все шарики";
            this.stopMovingButton.UseVisualStyleBackColor = true;
            this.stopMovingButton.Click += new System.EventHandler(this.stopMovingButton_Click);
            // 
            // countLabel
            // 
            this.countLabel.Location = new System.Drawing.Point(12, 9);
            this.countLabel.Name = "countLabel";
            this.countLabel.Size = new System.Drawing.Size(150, 25);
            this.countLabel.TabIndex = 8;
            this.countLabel.Text = "Шариков поймано:";
            // 
            // catchesBallsCountLabel
            // 
            this.catchesBallsCountLabel.BackColor = System.Drawing.Color.White;
            this.catchesBallsCountLabel.Location = new System.Drawing.Point(168, 9);
            this.catchesBallsCountLabel.Name = "catchesBallsCountLabel";
            this.catchesBallsCountLabel.Size = new System.Drawing.Size(62, 25);
            this.catchesBallsCountLabel.TabIndex = 9;
            this.catchesBallsCountLabel.Text = "0";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // NewBallGameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.catchesBallsCountLabel);
            this.Controls.Add(this.countLabel);
            this.Controls.Add(this.aLotOfBallsButton);
            this.Controls.Add(this.stopMovingButton);
            this.Name = "NewBallGameForm";
            this.Text = "Шарики №2";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.NewBallGameForm_MouseDown);
            this.ResumeLayout(false);

        }

        #endregion
        private Button aLotOfBallsButton;
        private Button stopMovingButton;
        private Label countLabel;
        private Label catchesBallsCountLabel;
        private System.Windows.Forms.Timer timer1;
    }
}