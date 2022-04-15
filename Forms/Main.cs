using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ISVT
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void generalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            General formGeneral = new General();
            formGeneral.Show();
        }

        private void computersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Computers formComputers = new Computers();
            formComputers.Show();
        }

        private void componentsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ComponentsT formComponentsT = new ComponentsT();
            formComponentsT.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            generalToolStripMenuItem_Click(sender,e);
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            computersToolStripMenuItem_Click(sender, e);
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            componentsToolStripMenuItem_Click(sender, e);
        }

        private void pictureBox_MouseLeave(object sender, EventArgs e)
        {
            ((PictureBox)sender).Size = new Size(((PictureBox)sender).Size.Width - 10, ((PictureBox)sender).Size.Height - 10);
        }

        private void pictureBox_MouseEnter(object sender, EventArgs e)
        {
            ((PictureBox)sender).Size = new Size(((PictureBox)sender).Size.Width + 10, ((PictureBox)sender).Size.Height + 10);
        }
    }
}
