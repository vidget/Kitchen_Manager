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
    public partial class AccountStartUp : Form
    {
        public AccountStartUp()
        {
            InitializeComponent();
        }

        private void passwordBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.passwordBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.kitchenDataSet);

        }

        private void AccountStartUp_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'kitchenDataSet.Password' table. You can move, or remove it, as needed.
            this.passwordTableAdapter.Fill(this.kitchenDataSet.Password);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.passwordBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.kitchenDataSet);

        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {

        }

        private void buttonCreateAdmin_Click(object sender, EventArgs e)
        {

                try
                {

                   this.passwordTableAdapter.AddAdmin(1,usernameTextBox.Text,passwordTextBox.Text,1);

                    //this.productTableAdapter.InsertProduct(textBox1.Text, textBox2.Text, qty, price);
                    MessageBox.Show("New Admin Added");
                    this.Close();
                    
                }
                catch (Exception)
                {
                    MessageBox.Show("Record Exists");
                }

            


        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.passwordTableAdapter.Delete(1, usernameTextBox.Text, passwordTextBox.Text, 1);
            this.Close();
        }
    }
}
