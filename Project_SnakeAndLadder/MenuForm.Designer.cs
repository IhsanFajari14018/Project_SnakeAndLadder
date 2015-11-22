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
            this.labelHuman = new System.Windows.Forms.Label();
            this.labelComp = new System.Windows.Forms.Label();
            this.labelExit = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelPlay
            // 
            this.labelPlay.Image = global::Project_SnakeAndLadder.Properties.Resources.playButton;
            this.labelPlay.Location = new System.Drawing.Point(150, 100);
            this.labelPlay.Name = "labelPlay";
            this.labelPlay.Size = new System.Drawing.Size(150, 38);
            this.labelPlay.TabIndex = 0;
            this.labelPlay.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelPlay.Click += new System.EventHandler(this.labelPlay_Click);
            // 
            // labelHuman
            // 
            this.labelHuman.Enabled = false;
            this.labelHuman.Image = global::Project_SnakeAndLadder.Properties.Resources.vs_playerButton_beforeClicked;
            this.labelHuman.Location = new System.Drawing.Point(160, 140);
            this.labelHuman.Name = "labelHuman";
            this.labelHuman.Size = new System.Drawing.Size(130, 26);
            this.labelHuman.TabIndex = 1;
            this.labelHuman.Visible = false;
            this.labelHuman.Click += new System.EventHandler(this.labelHuman_Click);
            this.labelHuman.MouseLeave += new System.EventHandler(this.labelHuman_MouseLeave);
            this.labelHuman.MouseMove += new System.Windows.Forms.MouseEventHandler(this.labelHuman_MouseMove);
            // 
            // labelComp
            // 
            this.labelComp.Enabled = false;
            this.labelComp.Image = global::Project_SnakeAndLadder.Properties.Resources.vs_computerButton_beforeClicked;
            this.labelComp.Location = new System.Drawing.Point(160, 170);
            this.labelComp.Name = "labelComp";
            this.labelComp.Size = new System.Drawing.Size(130, 26);
            this.labelComp.TabIndex = 2;
            this.labelComp.Visible = false;
            this.labelComp.Click += new System.EventHandler(this.labelComp_Click);
            this.labelComp.MouseLeave += new System.EventHandler(this.labelComp_MouseLeave);
            this.labelComp.MouseMove += new System.Windows.Forms.MouseEventHandler(this.labelComp_MouseMove);
            // 
            // labelExit
            // 
            this.labelExit.Image = global::Project_SnakeAndLadder.Properties.Resources.exitButton;
            this.labelExit.Location = new System.Drawing.Point(150, 200);
            this.labelExit.Name = "labelExit";
            this.labelExit.Size = new System.Drawing.Size(150, 38);
            this.labelExit.TabIndex = 3;
            this.labelExit.Click += new System.EventHandler(this.labelExit_Click);
            // 
            // MenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 411);
            this.Controls.Add(this.labelExit);
            this.Controls.Add(this.labelComp);
            this.Controls.Add(this.labelHuman);
            this.Controls.Add(this.labelPlay);
            this.Name = "MenuForm";
            this.Text = "Menu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labelPlay;
        private System.Windows.Forms.Label labelHuman;
        private System.Windows.Forms.Label labelComp;
        private System.Windows.Forms.Label labelExit;
    }
}