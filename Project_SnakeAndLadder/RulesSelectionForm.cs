using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_SnakeAndLadder
{
    /// <summary>
    /// Kelas ini diturunkan dari kelas Form
    /// Kelas ini merepresentasikan form yang berisi aturan main
    /// </summary>
    public partial class RulesSelectionForm : Form
    {
        private MainForm form;

        /// <summary>
        /// Konstraktor
        /// </summary>
        public RulesSelectionForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Method bila label human diklik
        /// </summary>
        /// <param name="sender">object sender</param>
        /// <param name="e">event args</param>
        private void labelHuman_Click(object sender, EventArgs e)
        {
            form = new MainForm(1);
            this.Owner = form;
            this.Hide();
            form.Show();
        }

        /// <summary>
        /// Method bila mouse dilepaskan dari label human
        /// </summary>
        /// <param name="sender">object sender</param>
        /// <param name="e">event args</param>
        private void labelHuman_MouseLeave(object sender, EventArgs e)
        {
            labelHuman.Image = new Bitmap(Properties.Resources.vs_playerButton);
        }

        /// <summary>
        /// Method bila mouse berpindah dari label human
        /// </summary>
        /// <param name="sender">object sender</param>
        /// <param name="e">event args</param>
        private void labelHuman_MouseMove(object sender, MouseEventArgs e)
        {
            labelHuman.Image = new Bitmap(Properties.Resources.vs_playerButton_beforeClicked);
        }

        /// <summary>
        /// Method bila label comp diklik
        /// </summary>
        /// <param name="sender">object sender</param>
        /// <param name="e">event args</param>
        private void labelComp_Click(object sender, EventArgs e)
        {
            form = new MainForm(2);
            this.Owner = form;
            this.Hide();
            form.Show();
        }

        /// <summary>
        /// Method bila mouse dilepaskan dari label comp
        /// </summary>
        /// <param name="sender">object sender</param>
        /// <param name="e">event args</param>
        private void labelComp_MouseLeave(object sender, EventArgs e)
        {
            labelComp.Image = new Bitmap(Properties.Resources.vs_computerButton);
        }

        /// <summary>
        /// Method bila mouse berpindah dari label comp
        /// </summary>
        /// <param name="sender">object sender</param>
        /// <param name="e">event args</param>
        private void labelComp_MouseMove(object sender, MouseEventArgs e)
        {
            labelComp.Image = new Bitmap(Properties.Resources.vs_computerButton_beforeClicked);
        }
    }
}
