using System;
using System.Windows.Forms;

namespace ISVT.Forms
{
    public partial class View : Form
    {
        public View()
        {
            InitializeComponent();
        }

        // Дополнительный метод
        private void TableLoader()
        {
            generalTableAdapter.Fill(dataSet1.General);
            computersTableAdapter.Fill(dataSet1.Computers);
            componentsTableAdapter.Fill(dataSet1.Components);
            generalDataGridView.Visible = false;
            generalToComputersDataGridView.Visible = false;
            computersDataGridView.Visible = false;
            computersToComponentsDataGridView.Visible = false;
            componentsDataGridView.Visible = false;
            toolStripTextBox1.Text = String.Empty;

            switch (toolStripComboBox1.SelectedIndex)
            {
                case 0:
                    generalDataGridView.Visible = true;
                    generalDataGridView.Dock = DockStyle.Fill;
                    break;
                case 1:
                    generalDataGridView.Visible = true;
                    generalToComputersDataGridView.Visible = true;
                    generalDataGridView.Dock = DockStyle.Left;
                    generalToComputersDataGridView.Dock = DockStyle.Fill;
                    break;
                case 2:
                    computersDataGridView.Visible = true;
                    computersDataGridView.Dock = DockStyle.Fill;
                    break;
                case 3:
                    computersDataGridView.Visible = true;
                    computersToComponentsDataGridView.Visible = true;
                    computersDataGridView.Dock = DockStyle.Fill;
                    computersToComponentsDataGridView.Dock = DockStyle.Right;
                    break;
                case 4:
                    componentsDataGridView.Visible = true;
                    componentsDataGridView.Dock = DockStyle.Fill;
                    break;
            }
        }
        // Дополнительный метод

        private void View_Load(object sender, EventArgs e)
        {
            TableLoader();
        }

        private void toolStripComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            TableLoader();
        }

        private void toolStripTextBox1_TextChanged(object sender, EventArgs e)
        {
            if (toolStripComboBox1.SelectedIndex <= 1)
                generalBindingSource.Position = generalBindingSource.Find("Room", toolStripTextBox1.Text);
            else if (toolStripComboBox1.SelectedIndex >= 2 && toolStripComboBox1.SelectedIndex <= 3)
                computersBindingSource.Position = computersBindingSource.Find("Description", toolStripTextBox1.Text);
            else if (toolStripComboBox1.SelectedIndex == 4)
                componentsBindingSource.Position = componentsBindingSource.Find("Description", toolStripTextBox1.Text);
        }
    }
}
