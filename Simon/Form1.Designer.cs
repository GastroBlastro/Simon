namespace Simon
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.greenButton = new System.Windows.Forms.Button();
            this.blueButton = new System.Windows.Forms.Button();
            this.yellowButton = new System.Windows.Forms.Button();
            this.redButton = new System.Windows.Forms.Button();
            this.newGameButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.historyLabel = new System.Windows.Forms.Label();
            this.screenLabel = new System.Windows.Forms.Label();
            this.lightBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.lightBox)).BeginInit();
            this.SuspendLayout();
            // 
            // greenButton
            // 
            this.greenButton.BackColor = System.Drawing.Color.Green;
            this.greenButton.Enabled = false;
            this.greenButton.Location = new System.Drawing.Point(12, 12);
            this.greenButton.Name = "greenButton";
            this.greenButton.Size = new System.Drawing.Size(196, 194);
            this.greenButton.TabIndex = 0;
            this.greenButton.UseVisualStyleBackColor = false;
            this.greenButton.Click += new System.EventHandler(this.greenButtonMethod);
            // 
            // blueButton
            // 
            this.blueButton.BackColor = System.Drawing.Color.Blue;
            this.blueButton.Enabled = false;
            this.blueButton.Location = new System.Drawing.Point(229, 234);
            this.blueButton.Name = "blueButton";
            this.blueButton.Size = new System.Drawing.Size(197, 202);
            this.blueButton.TabIndex = 1;
            this.blueButton.UseVisualStyleBackColor = false;
            this.blueButton.Click += new System.EventHandler(this.blueButtonMethod);
            // 
            // yellowButton
            // 
            this.yellowButton.BackColor = System.Drawing.Color.Gold;
            this.yellowButton.Enabled = false;
            this.yellowButton.Location = new System.Drawing.Point(12, 234);
            this.yellowButton.Name = "yellowButton";
            this.yellowButton.Size = new System.Drawing.Size(196, 202);
            this.yellowButton.TabIndex = 2;
            this.yellowButton.UseVisualStyleBackColor = false;
            this.yellowButton.Click += new System.EventHandler(this.yellowButtonMethod);
            // 
            // redButton
            // 
            this.redButton.BackColor = System.Drawing.Color.Red;
            this.redButton.Enabled = false;
            this.redButton.Location = new System.Drawing.Point(229, 12);
            this.redButton.Name = "redButton";
            this.redButton.Size = new System.Drawing.Size(197, 194);
            this.redButton.TabIndex = 3;
            this.redButton.UseVisualStyleBackColor = false;
            this.redButton.Click += new System.EventHandler(this.redButtonMethod);
            // 
            // newGameButton
            // 
            this.newGameButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.newGameButton.ForeColor = System.Drawing.Color.White;
            this.newGameButton.Location = new System.Drawing.Point(32, 454);
            this.newGameButton.Name = "newGameButton";
            this.newGameButton.Size = new System.Drawing.Size(108, 30);
            this.newGameButton.TabIndex = 4;
            this.newGameButton.Text = "New Game";
            this.newGameButton.UseVisualStyleBackColor = true;
            this.newGameButton.Click += new System.EventHandler(this.newGameButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitButton.ForeColor = System.Drawing.Color.White;
            this.exitButton.Location = new System.Drawing.Point(299, 454);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(108, 30);
            this.exitButton.TabIndex = 5;
            this.exitButton.Text = "Exit Game";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // historyLabel
            // 
            this.historyLabel.AutoSize = true;
            this.historyLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.historyLabel.Location = new System.Drawing.Point(391, 485);
            this.historyLabel.Name = "historyLabel";
            this.historyLabel.Size = new System.Drawing.Size(0, 13);
            this.historyLabel.TabIndex = 7;
            // 
            // screenLabel
            // 
            this.screenLabel.Font = new System.Drawing.Font("Quartz MS", 18.75F, System.Drawing.FontStyle.Bold);
            this.screenLabel.Image = global::Simon.Properties.Resources.screen;
            this.screenLabel.Location = new System.Drawing.Point(229, 450);
            this.screenLabel.Name = "screenLabel";
            this.screenLabel.Size = new System.Drawing.Size(48, 45);
            this.screenLabel.TabIndex = 8;
            this.screenLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lightBox
            // 
            this.lightBox.Image = ((System.Drawing.Image)(resources.GetObject("lightBox.Image")));
            this.lightBox.Location = new System.Drawing.Point(162, 450);
            this.lightBox.Name = "lightBox";
            this.lightBox.Size = new System.Drawing.Size(46, 45);
            this.lightBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.lightBox.TabIndex = 6;
            this.lightBox.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(438, 507);
            this.Controls.Add(this.screenLabel);
            this.Controls.Add(this.historyLabel);
            this.Controls.Add(this.lightBox);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.newGameButton);
            this.Controls.Add(this.redButton);
            this.Controls.Add(this.yellowButton);
            this.Controls.Add(this.blueButton);
            this.Controls.Add(this.greenButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.lightBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button greenButton;
        private System.Windows.Forms.Button blueButton;
        private System.Windows.Forms.Button yellowButton;
        private System.Windows.Forms.Button redButton;
        private System.Windows.Forms.Button newGameButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.PictureBox lightBox;
        private System.Windows.Forms.Label historyLabel;
        private System.Windows.Forms.Label screenLabel;
    }
}

