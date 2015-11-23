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
    public partial class MenuForm : Form
    {
        private RulesSelectionForm form;
        public MenuForm()
        {
            InitializeComponent();
            form = new RulesSelectionForm();
            this.Owner = form;
        }

        private void labelPlay_Click(object sender, EventArgs e)
        {
            this.Hide();
            form.Show();
        }

        private void labelExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        
    }
}
