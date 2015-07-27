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
    public partial class Staffing : Form
    {
        public Staffing()
        {
            InitializeComponent();
        }

        private void staffBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.staffBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.kitchenDataSet);

        }

        private void Staffing_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'kitchenDataSet.Staff' table. You can move, or remove it, as needed.
            this.staffTableAdapter.Fill(this.kitchenDataSet.Staff);

        }
    }
}
