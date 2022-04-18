using System;
using System.Drawing;
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
            generalToolStripMenuItem_Click(sender, e);
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

        // Дополнительный методы //
        private void selectSortMode(int sortIndex)
        {
            Forms.View formView = new Forms.View();
            formView.toolStripComboBox1.SelectedIndex = sortIndex;
            formView.Show();
        }
        // Дополнительный метод //

        private void помещенияToolStripMenuItem_Click(object sender, EventArgs e)
        {
            selectSortMode(0);
        }

        private void вычислительнаяТехникаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            selectSortMode(2);
        }

        private void компонентыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            selectSortMode(4);
        }

        private void вычислительнаяТехникаToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            selectSortMode(1);
        }


        private void компонентыToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            selectSortMode(3);
        }
    }

    //Код убирающий полоску под toolStrip1
    public class MySR : ToolStripSystemRenderer
    {
        public MySR() { }

        protected override void OnRenderToolStripBorder(ToolStripRenderEventArgs e)
        {
            //base.OnRenderToolStripBorder(e);
        }
    }
}
