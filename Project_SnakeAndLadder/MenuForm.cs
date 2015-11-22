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
        private MainForm form;
        public MenuForm()
        {
            InitializeComponent();
            form = new MainForm(2);
        }

        private void labelPlay_Click(object sender, EventArgs e)
        {
            labelHuman.Show();
            labelComp.Show();
        }

        private void labelExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void labelHuman_Click(object sender, EventArgs e)
        {
            form = new MainForm(1);
            this.Owner = form;
            this.Hide();
            form.Show();
        }

        private void labelComp_Click(object sender, EventArgs e)
        {
            form = new MainForm(2);
            this.Owner = form;
            this.Hide();
            form.Show();
        }        

        private void labelHuman_MouseLeave(object sender, EventArgs e)
        {
            labelHuman.Image = new Bitmap(Properties.Resources.vs_playerButton_beforeClicked);
        }

        private void labelHuman_MouseMove(object sender, MouseEventArgs e)
        {
            labelHuman.Image = new Bitmap(Properties.Resources.vs_playerButton);
        }

        private void labelComp_MouseLeave(object sender, EventArgs e)
        {
            labelComp.Image = new Bitmap(Properties.Resources.vs_computerButton_beforeClicked);
        }

        private void labelComp_MouseMove(object sender, MouseEventArgs e)
        {
            labelComp.Image = new Bitmap(Properties.Resources.vs_computerButton);
        }
    }
}
