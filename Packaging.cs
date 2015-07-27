using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kitchen_Manager
{
    public partial class Packaging : Form
    {
        public Packaging()
        {
            InitializeComponent();
        }

        private void packagingBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.packagingBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.kitchenDataSet);

        }

        private void Packaging_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'kitchenDataSet.Packaging' table. You can move, or remove it, as needed.
            this.packagingTableAdapter.Fill(this.kitchenDataSet.Packaging);

        }
    }
}
