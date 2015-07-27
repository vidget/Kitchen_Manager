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
    public partial class Ingredients : Form
    {
        public Ingredients()
        {
            InitializeComponent();
        }

        private void ingredientsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.ingredientsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.kitchenDataSet);

        }

        private void Ingredients_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'kitchenDataSet.Ingredients' table. You can move, or remove it, as needed.
            this.ingredientsTableAdapter.Fill(this.kitchenDataSet.Ingredients);

        }
    }
}
