namespace Project_SnakeAndLadder
{
    partial class MenuForm
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
            this.labelPlay = new System.Windows.Forms.Label();
            this.labelExit = new System.Windows.Forms.Label();
            this.judulPictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.judulPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // labelPlay
            // 
            this.labelPlay.Image = global::Project_SnakeAndLadder.Properties.Resources.playButton;
            this.labelPlay.Location = new System.Drawing.Point(150, 198);
            this.labelPlay.Name = "labelPlay";
            this.labelPlay.Size = new System.Drawing.Size(150, 38);
            this.labelPlay.TabIndex = 0;
            this.labelPlay.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelPlay.Click += new System.EventHandler(this.labelPlay_Click);
            // 
            // labelExit
            // 
            this.labelExit.Image = global::Project_SnakeAndLadder.Properties.Resources.exitButton;
            this.labelExit.Location = new System.Drawing.Point(150, 298);
            this.labelExit.Name = "labelExit";
            this.labelExit.Size = new System.Drawing.Size(150, 38);
            this.labelExit.TabIndex = 3;
            this.labelExit.Click += new System.EventHandler(this.labelExit_Click);
            // 
            // judulPictureBox
            // 
            this.judulPictureBox.BackgroundImage = global::Project_SnakeAndLadder.Properties.Resources.menuTitle_UlarTangga;
            this.judulPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.judulPictureBox.Location = new System.Drawing.Point(54, 12);
            this.judulPictureBox.Name = "judulPictureBox";
            this.judulPictureBox.Size = new System.Drawing.Size(324, 146);
            this.judulPictureBox.TabIndex = 4;
            this.judulPictureBox.TabStop = false;
            // 
            // MenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Project_SnakeAndLadder.Properties.Resources.wallpaper;
            this.ClientSize = new System.Drawing.Size(434, 411);
            this.Controls.Add(this.judulPictureBox);
            this.Controls.Add(this.labelExit);
            this.Controls.Add(this.labelPlay);
            this.Name = "MenuForm";
            this.Text = "Menu";
            ((System.ComponentModel.ISupportInitialize)(this.judulPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labelPlay;
        private System.Windows.Forms.Label labelExit;
        private System.Windows.Forms.PictureBox judulPictureBox;
    }
}