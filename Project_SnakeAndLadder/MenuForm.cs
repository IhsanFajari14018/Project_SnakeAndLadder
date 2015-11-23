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
    /// Kelas ini merepresentasikan tampilan menu
    /// </summary>
    public partial class MenuForm : Form
    {
        private RulesSelectionForm form;

        /// <summary>
        /// Konstraktor
        /// </summary>
        public MenuForm()
        {
            InitializeComponent();
            form = new RulesSelectionForm();
            this.Owner = form;
        }

        /// <summary>
        /// Method bila label play diklik
        /// </summary>
        /// <param name="sender">objek sender</param>
        /// <param name="e">event args</param>
        private void labelPlay_Click(object sender, EventArgs e)
        {
            this.Hide();
            form.Show();
        }

        /// <summary>
        /// Method bila label exit diklik
        /// </summary>
        /// <param name="sender">objek sender</param>
        /// <param name="e">event args</param>
        private void labelExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        
    }
}
