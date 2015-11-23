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
            this.labelDice1 = new System.Windows.Forms.Label();
            this.labelDice2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
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
            // labelDice1
            // 
            this.labelDice1.AutoSize = true;
            this.labelDice1.Location = new System.Drawing.Point(519, 45);
            this.labelDice1.Name = "labelDice1";
            this.labelDice1.Size = new System.Drawing.Size(55, 26);
            this.labelDice1.TabIndex = 1;
            this.labelDice1.Text = "Keluaran :\r\n0";
            this.labelDice1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelDice2
            // 
            this.labelDice2.AutoSize = true;
            this.labelDice2.Location = new System.Drawing.Point(519, 101);
            this.labelDice2.Name = "labelDice2";
            this.labelDice2.Size = new System.Drawing.Size(55, 26);
            this.labelDice2.TabIndex = 2;
            this.labelDice2.Text = "Keluaran :\r\n0";
            this.labelDice2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(504, 351);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 143);
            this.label1.TabIndex = 3;
            this.label1.Text = "PETUNJUK :\r\n\r\nPLAYER 1\r\nmenggunakan \r\ntombol \r\n\"Kocok dadu\"\r\n\r\nPLAYER 2\r\nmengguna" +
    "kan \r\ntombol \r\n\"R\" keyboard\r\n";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(594, 511);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelDice2);
            this.Controls.Add(this.labelDice1);
            this.Controls.Add(this.buttonKocok);
            this.Name = "MainForm";
            this.Text = "Snakes and Ladders";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MainForm_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonKocok;
        private System.Windows.Forms.Label labelDice1;
        private System.Windows.Forms.Label labelDice2;
        private System.Windows.Forms.Label label1;
    }
}

