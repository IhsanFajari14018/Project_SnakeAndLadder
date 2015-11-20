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
            form = new MainForm();
            this.Owner = form;
            form.Show();
        }
    }
}
