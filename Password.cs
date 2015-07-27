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
    public partial class Password : Form
    {

        int linkSentFrom = 0;

        public void sendLinkInfo(int link)
        {

            linkSentFrom = link;
        }


        public Password()
        {
            InitializeComponent();
        }

        private void buttonPasswordSubmit_Click(object sender, EventArgs e)
        {


            //Checks to make sure password and username are correct


            if (textBoxPassword.Text == Convert.ToString(this.passwordTableAdapter.GetAdminPassword()) && textBoxUserName.Text==Convert.ToString(this.passwordTableAdapter.GetAdminName()))
            {
                this.Close();

            //Determines where the original link came from and send it to the appropriate new FORM 1=Ingredients 2=Packaging

                if (linkSentFrom == 1)
                {
                    Ingredients myIngredients = new Ingredients();
                    myIngredients.ShowDialog();
                }
                else if (linkSentFrom == 2)
                {
                    Packaging myPackageForm = new Packaging();
                    myPackageForm.ShowDialog();

                }
                else if (linkSentFrom == 3)
                {
                    Staffing myStaffingForm = new Staffing();
                    myStaffingForm.ShowDialog();

                }


            }
            else
            {
                MessageBox.Show("Username or Password incorrect");
                textBoxPassword.Text = "";
                textBoxUserName.Text = "";

            }


        }

        private void passwordBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.passwordBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.kitchenDataSet);

        }

        private void Password_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'kitchenDataSet.Password' table. You can move, or remove it, as needed.
            this.passwordTableAdapter.Fill(this.kitchenDataSet.Password);

        }
    }
}
