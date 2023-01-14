namespace AngryBirdsWinFormsApp
{
    partial class AngryBirdsForm
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
            this.birdFlyTimer = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.killCountLabel = new System.Windows.Forms.Label();
            this.startButton = new System.Windows.Forms.Button();
            this.birdsCountLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // birdFlyTimer
            // 
            this.birdFlyTimer.Interval = 10;
            this.birdFlyTimer.Tick += new System.EventHandler(this.birdFlyTimer_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Сбитых свиней: ";
            // 
            // killCountLabel
            // 
            this.killCountLabel.AutoSize = true;
            this.killCountLabel.Location = new System.Drawing.Point(139, 9);
            this.killCountLabel.Name = "killCountLabel";
            this.killCountLabel.Size = new System.Drawing.Size(17, 20);
            this.killCountLabel.TabIndex = 1;
            this.killCountLabel.Text = "0";
            // 
            // startButton
            // 
            this.startButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.startButton.Location = new System.Drawing.Point(1096, 12);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(124, 47);
            this.startButton.TabIndex = 2;
            this.startButton.Text = "Начать";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // birdsCountLabel
            // 
            this.birdsCountLabel.AutoSize = true;
            this.birdsCountLabel.Location = new System.Drawing.Point(139, 39);
            this.birdsCountLabel.Name = "birdsCountLabel";
            this.birdsCountLabel.Size = new System.Drawing.Size(17, 20);
            this.birdsCountLabel.TabIndex = 4;
            this.birdsCountLabel.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Осталось птиц: ";
            // 
            // AngryBirdsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1232, 573);
            this.Controls.Add(this.birdsCountLabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.killCountLabel);
            this.Controls.Add(this.label1);
            this.Name = "AngryBirdsForm";
            this.Text = "Angry Birds";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.AngryBirdsForm_Load);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.AngryBirdsForm_MouseClick);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        

        #endregion

        private System.Windows.Forms.Timer birdFlyTimer;
        private Label label1;
        private Label killCountLabel;
        private Button startButton;
        private Label birdsCountLabel;
        private Label label3;
    }
}