namespace WonderlandReservation
{
    partial class StartScreen
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StartScreen));
            this.startButton = new System.Windows.Forms.PictureBox();
            this.exitButton = new System.Windows.Forms.PictureBox();
            this.wonderlandLogo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.startButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.exitButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wonderlandLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // startButton
            // 
            this.startButton.BackColor = System.Drawing.Color.Transparent;
            this.startButton.Image = global::WonderlandReservation.Properties.Resources.enterButton;
            this.startButton.Location = new System.Drawing.Point(152, 323);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(269, 110);
            this.startButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.startButton.TabIndex = 6;
            this.startButton.TabStop = false;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.BackColor = System.Drawing.Color.Transparent;
            this.exitButton.Image = ((System.Drawing.Image)(resources.GetObject("exitButton.Image")));
            this.exitButton.Location = new System.Drawing.Point(376, 323);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(249, 110);
            this.exitButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.exitButton.TabIndex = 5;
            this.exitButton.TabStop = false;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click_1);
            // 
            // wonderlandLogo
            // 
            this.wonderlandLogo.BackColor = System.Drawing.Color.Transparent;
            this.wonderlandLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.wonderlandLogo.Image = global::WonderlandReservation.Properties.Resources.wonderland_logo;
            this.wonderlandLogo.Location = new System.Drawing.Point(165, 31);
            this.wonderlandLogo.Name = "wonderlandLogo";
            this.wonderlandLogo.Size = new System.Drawing.Size(433, 170);
            this.wonderlandLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.wonderlandLogo.TabIndex = 0;
            this.wonderlandLogo.TabStop = false;
            // 
            // StartScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleTurquoise;
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.wonderlandLogo);
            this.Name = "StartScreen";
            this.Size = new System.Drawing.Size(790, 680);
            ((System.ComponentModel.ISupportInitialize)(this.startButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.exitButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wonderlandLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox wonderlandLogo;
        private System.Windows.Forms.PictureBox exitButton;
        private System.Windows.Forms.PictureBox startButton;
    }
}
