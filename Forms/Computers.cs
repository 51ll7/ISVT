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
    public partial class Computers : Form
    {
        public Computers()
        {
            InitializeComponent();
        }

        private void computersBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.computersBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataSet1);

        }

        private void Computers_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataSet1.Computers". При необходимости она может быть перемещена или удалена.
            this.computersTableAdapter.Fill(this.dataSet1.Computers);

        }
    }
}
