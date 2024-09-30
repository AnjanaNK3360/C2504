using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment1
{
    public partial class MainPageForm : Form
    {
        public MainPageForm()
        {
            InitializeComponent();
        }
        private Peacock frmpeacock = new Peacock();
        private Duck frmduck = new Duck();
        private Crow frmcrow = new Crow();  
        private void mnuPeacock_Click(object sender, EventArgs e)
        {
            frmpeacock.MdiParent = this;
            frmpeacock.Show();
            frmpeacock.Activate();
        }

        private void mnuDuck_Click(object sender, EventArgs e)
        {
            frmduck.MdiParent = this;
            frmduck.Show();
            frmduck.Activate();
        }

        private void mnuCrow_Click(object sender, EventArgs e)
        {
            frmcrow.MdiParent = this;
            frmcrow.Show();
            frmcrow.Activate();
        }
    }
}
