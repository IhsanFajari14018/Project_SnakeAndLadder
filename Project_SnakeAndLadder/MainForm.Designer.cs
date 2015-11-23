namespace Project_SnakeAndLadder
{
    partial class MainForm
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
            this.buttonKocok = new System.Windows.Forms.Button();
            this.labelDice = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonKocok
            // 
            this.buttonKocok.Location = new System.Drawing.Point(507, 12);
            this.buttonKocok.Name = "buttonKocok";
            this.buttonKocok.Size = new System.Drawing.Size(75, 23);
            this.buttonKocok.TabIndex = 0;
            this.buttonKocok.Text = "Kocok dadu";
            this.buttonKocok.UseVisualStyleBackColor = true;
            this.buttonKocok.Click += new System.EventHandler(this.buttonKocok_Click);
            // 
            // labelDice
            // 
            this.labelDice.AutoSize = true;
            this.labelDice.Location = new System.Drawing.Point(519, 45);
            this.labelDice.Name = "labelDice";
            this.labelDice.Size = new System.Drawing.Size(52, 26);
            this.labelDice.TabIndex = 1;
            this.labelDice.Text = "Keluaran:\r\n0";
            this.labelDice.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(594, 511);
            this.Controls.Add(this.labelDice);
            this.Controls.Add(this.buttonKocok);
            this.Name = "MainForm";
            this.Text = "Snakes and Ladders";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonKocok;
        private System.Windows.Forms.Label labelDice;
    }
}

