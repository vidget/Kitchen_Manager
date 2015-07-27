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
    public partial class Order : Form
    {


        public Order()
        {
            InitializeComponent();
        }

        void FillCombo()
        {


        }



        void TotalIngred()
        {

            decimal tempTotal;
            tempTotal = Convert.ToDecimal(labelIngred1Total.Text) + Convert.ToDecimal(labelIngred2Total.Text) + Convert.ToDecimal(labelIngred3Total.Text) + Convert.ToDecimal(labelIngred4Total.Text) + Convert.ToDecimal(labelIngred5Total.Text) +
               Convert.ToDecimal(labelIngred6Total.Text) + Convert.ToDecimal(labelIngred7Total.Text) + Convert.ToDecimal(labelIngred8Total.Text) + Convert.ToDecimal(labelIngred9Total.Text) + Convert.ToDecimal(labelIngred10Total.Text);

            labelIngredSubTotal.Text = tempTotal.ToString("f");

        }


        void TotalPackage()
        {

            decimal tempTotal;
            tempTotal = Convert.ToDecimal(labelPackTotal1.Text) + Convert.ToDecimal(labelPackTotal2.Text) + Convert.ToDecimal(labelPackTotal3.Text) + Convert.ToDecimal(labelPackTotal4.Text) + Convert.ToDecimal(labelPackTotal5.Text);

            decimal tempValueTotal;
            tempValueTotal = Convert.ToDecimal(labelPackValue1.Text) + Convert.ToDecimal(labelPackValue2.Text) + Convert.ToDecimal(labelPackValue3.Text) + Convert.ToDecimal(labelPackValue4.Text) + Convert.ToDecimal(labelPackValue5.Text);

            labelPackSubTotal.Text = tempTotal.ToString("f");
            labelPackValueTotal.Text = tempValueTotal.ToString("f");


        }

        void TotalStaff()
        {

            decimal tempTotal;
            tempTotal = Convert.ToDecimal(labelTotalStaff1.Text) + Convert.ToDecimal(labelTotalStaff2.Text) + Convert.ToDecimal(labelTotalStaff3.Text) + Convert.ToDecimal(labelTotalStaff4.Text) + Convert.ToDecimal(labelTotalStaff5.Text);
            labelStaffSubTotal.Text = tempTotal.ToString("f");
            labelLotStaffCostTotal.Text = tempTotal.ToString("f");



        }

        void CalculateLotTotal()
        {

            if (this.productLotTableAdapter.GetLotIngredCost(Convert.ToInt16(textBoxLotNumber.Text)) == null)
            {
                labelLotIngredCost.Text = "0.00";
            }
            else
            {
                labelLotIngredCost.Text = Convert.ToString(this.productLotTableAdapter.GetLotIngredCost(Convert.ToInt16(textBoxLotNumber.Text)));
            }


            if (this.productLotTableAdapter.GetLotPackCost(Convert.ToInt16(textBoxLotNumber.Text)) == null)
            {
                labelLotPackCostTotal.Text = "0.00";
            }
            else
            {
                labelLotPackCostTotal.Text = Convert.ToString(this.productLotTableAdapter.GetLotPackCost(Convert.ToInt16(textBoxLotNumber.Text)));
            }


            if (this.productLotTableAdapter.GetLotValue(Convert.ToInt16(textBoxLotNumber.Text)) == null)
            {
                labelLotValue.Text = "0.00";
            }
            else
            {
                labelLotValue.Text = Convert.ToString(this.productLotTableAdapter.GetLotValue(Convert.ToInt16(textBoxLotNumber.Text)));
            }

                labelLotCostSubTotal.Text = Convert.ToString(Convert.ToDecimal(labelLotIngredCost.Text) + Convert.ToDecimal(labelLotPackCostTotal.Text) + Convert.ToDecimal(labelLotStaffCostTotal.Text) + Convert.ToDecimal(labelLotKitchenCost.Text));

                labelLotGrandTotal.Text = Convert.ToString(Convert.ToDecimal(labelLotValue.Text) - Convert.ToDecimal(labelLotCostSubTotal.Text));


        }

        void ClearAllProduct()
        {

            textBoxProductName.Text = "";
            labelBuildNum.Text = "0";
            textBoxProductNotes.Text = "";

            checkBoxIngred1.Checked = false;
            checkBoxIngred2.Checked = false;
            checkBoxIngred3.Checked = false;
            checkBoxIngred4.Checked = false;
            checkBoxIngred5.Checked = false;

            checkBoxIngred6.Checked = false;
            checkBoxIngred7.Checked = false;
            checkBoxIngred8.Checked = false;
            checkBoxIngred9.Checked = false;
            checkBoxIngred10.Checked = false;

            checkBoxPack1.Checked = false;
            checkBoxPack2.Checked = false;
            checkBoxPack3.Checked = false;
            checkBoxPack4.Checked = false;
            checkBoxPack5.Checked = false;
        }




        void LoadInfo(int build)
        {


            int lot = Convert.ToInt16(textBoxLotNumber.Text);

            textBoxProductName.Text = Convert.ToString(this.productLotTableAdapter.GetProductName(build, lot));

            labelBuildNum.Text = Convert.ToString(build);
            textBoxProductNotes.Text = Convert.ToString(this.productLotTableAdapter.GetNotes(build, lot));



            //sets the FORM items from the values in the KITCHEN database, based on the build number/row selected in the lot DatagridView         

            checkBoxIngred1.Checked = Convert.ToBoolean(this.productLotTableAdapter.GetCheckIngred1(build, lot));
            comboBoxIngred1.Text = Convert.ToString(this.productLotTableAdapter.GetIngred1(build, lot));




            //empties the text box if the quantity=0, so a 0.00 doesn't appear

            if (Convert.ToDecimal(this.productLotTableAdapter.GetIngred1Qty(build, lot)) == 0)
            {
                textBoxIngred1Qty.Text = "";
            }
            else
            {
                textBoxIngred1Qty.Text = Convert.ToString(this.productLotTableAdapter.GetIngred1Qty(build, lot));
            }


            labelIngred1Units.Text = Convert.ToString(this.productLotTableAdapter.GetIngred1Unit(build, lot));
            labelIngred1Price.Text = Convert.ToString(this.productLotTableAdapter.GetIngred1Price(build, lot));
            labelIngred1Total.Text = Convert.ToString(this.productLotTableAdapter.GetIngred1Total(build, lot));

            checkBoxIngred2.Checked = Convert.ToBoolean(this.productLotTableAdapter.GetCheckIngred2(build, lot));
            comboBoxIngred2.Text = Convert.ToString(this.productLotTableAdapter.GetIngred2(build, lot));


            if (Convert.ToDecimal(this.productLotTableAdapter.GetIngred2Qty(build, lot)) == 0)
            {
                textBoxIngred2Qty.Text = "";
            }
            else
            {
                textBoxIngred2Qty.Text = Convert.ToString(this.productLotTableAdapter.GetIngred2Qty(build, lot));
            }


            labelIngred2Units.Text = Convert.ToString(this.productLotTableAdapter.GetIngred2Unit(build, lot));
            labelIngred2Price.Text = Convert.ToString(this.productLotTableAdapter.GetIngred2Price(build, lot));
            labelIngred2Total.Text = Convert.ToString(this.productLotTableAdapter.GetIngred2Total(build, lot));

            checkBoxIngred3.Checked = Convert.ToBoolean(this.productLotTableAdapter.GetCheckIngred3(build, lot));
            comboBoxIngred3.Text = Convert.ToString(this.productLotTableAdapter.GetIngred3(build, lot));


            if (Convert.ToDecimal(this.productLotTableAdapter.GetIngred3Qty(build, lot)) == 0)
            {
                textBoxIngred3Qty.Text = "";
            }
            else
            {
                textBoxIngred3Qty.Text = Convert.ToString(this.productLotTableAdapter.GetIngred3Qty(build, lot));
            }



            labelIngred3Units.Text = Convert.ToString(this.productLotTableAdapter.GetIngred3Unit(build, lot));
            labelIngred3Price.Text = Convert.ToString(this.productLotTableAdapter.GetIngred3Price(build, lot));
            labelIngred3Total.Text = Convert.ToString(this.productLotTableAdapter.GetIngred3Total(build, lot));

            checkBoxIngred4.Checked = Convert.ToBoolean(this.productLotTableAdapter.GetCheckIngred4(build, lot));
            comboBoxIngred4.Text = Convert.ToString(this.productLotTableAdapter.GetIngred4(build, lot));




            if (Convert.ToDecimal(this.productLotTableAdapter.GetIngred4Qty(build, lot)) == 0)
            {
                textBoxIngred4Qty.Text = "";
            }
            else
            {
                textBoxIngred4Qty.Text = Convert.ToString(this.productLotTableAdapter.GetIngred4Qty(build, lot));
            }






            labelIngred4Units.Text = Convert.ToString(this.productLotTableAdapter.GetIngred4Unit(build, lot));
            labelIngred4Price.Text = Convert.ToString(this.productLotTableAdapter.GetIngred4Price(build, lot));
            labelIngred4Total.Text = Convert.ToString(this.productLotTableAdapter.GetIngred4Total(build, lot));

            checkBoxIngred5.Checked = Convert.ToBoolean(this.productLotTableAdapter.GetCheckIngred5(build, lot));
            comboBoxIngred5.Text = Convert.ToString(this.productLotTableAdapter.GetIngred5(build, lot));



            if (Convert.ToDecimal(this.productLotTableAdapter.GetIngred5Qty(build, lot)) == 0)
            {
                textBoxIngred5Qty.Text = "";
            }
            else
            {
                textBoxIngred5Qty.Text = Convert.ToString(this.productLotTableAdapter.GetIngred5Qty(build, lot));
            }









            labelIngred5Units.Text = Convert.ToString(this.productLotTableAdapter.GetIngred5Unit(build, lot));
            labelIngred5Price.Text = Convert.ToString(this.productLotTableAdapter.GetIngred5Price(build, lot));
            labelIngred5Total.Text = Convert.ToString(this.productLotTableAdapter.GetIngred5Total(build, lot));

            checkBoxIngred6.Checked = Convert.ToBoolean(this.productLotTableAdapter.GetCheckIngred6(build, lot));
            comboBoxIngred6.Text = Convert.ToString(this.productLotTableAdapter.GetIngred6(build, lot));


            if (Convert.ToDecimal(this.productLotTableAdapter.GetIngred6Qty(build, lot)) == 0)
            {
                textBoxIngred6Qty.Text = "";
            }
            else
            {
                textBoxIngred6Qty.Text = Convert.ToString(this.productLotTableAdapter.GetIngred6Qty(build, lot));
            }







            labelIngred6Units.Text = Convert.ToString(this.productLotTableAdapter.GetIngred6Unit(build, lot));
            labelIngred6Price.Text = Convert.ToString(this.productLotTableAdapter.GetIngred6Price(build, lot));
            labelIngred6Total.Text = Convert.ToString(this.productLotTableAdapter.GetIngred6Total(build, lot));

            checkBoxIngred7.Checked = Convert.ToBoolean(this.productLotTableAdapter.GetCheckIngred7(build, lot));
            comboBoxIngred7.Text = Convert.ToString(this.productLotTableAdapter.GetIngred7(build, lot));



            if (Convert.ToDecimal(this.productLotTableAdapter.GetIngred7Qty(build, lot)) == 0)
            {
                textBoxIngred7Qty.Text = "";
            }
            else
            {
                textBoxIngred7Qty.Text = Convert.ToString(this.productLotTableAdapter.GetIngred7Qty(build, lot));
            }






            labelIngred7Units.Text = Convert.ToString(this.productLotTableAdapter.GetIngred7Unit(build, lot));
            labelIngred7Price.Text = Convert.ToString(this.productLotTableAdapter.GetIngred7Price(build, lot));
            labelIngred7Total.Text = Convert.ToString(this.productLotTableAdapter.GetIngred7Total(build, lot));

            checkBoxIngred8.Checked = Convert.ToBoolean(this.productLotTableAdapter.GetCheckIngred8(build, lot));
            comboBoxIngred8.Text = Convert.ToString(this.productLotTableAdapter.GetIngred8(build, lot));

            if (Convert.ToDecimal(this.productLotTableAdapter.GetIngred8Qty(build, lot)) == 0)
            {
                textBoxIngred8Qty.Text = "";
            }
            else
            {
                textBoxIngred8Qty.Text = Convert.ToString(this.productLotTableAdapter.GetIngred8Qty(build, lot));
            }






            labelIngred8Units.Text = Convert.ToString(this.productLotTableAdapter.GetIngred8Unit(build, lot));
            labelIngred8Price.Text = Convert.ToString(this.productLotTableAdapter.GetIngred8Price(build, lot));
            labelIngred8Total.Text = Convert.ToString(this.productLotTableAdapter.GetIngred8Total(build, lot));

            checkBoxIngred9.Checked = Convert.ToBoolean(this.productLotTableAdapter.GetCheckIngred9(build, lot));
            comboBoxIngred9.Text = Convert.ToString(this.productLotTableAdapter.GetIngred9(build, lot));


            if (Convert.ToDecimal(this.productLotTableAdapter.GetIngred9Qty(build, lot)) == 0)
            {
                textBoxIngred9Qty.Text = "";
            }
            else
            {
                textBoxIngred9Qty.Text = Convert.ToString(this.productLotTableAdapter.GetIngred9Qty(build, lot));
            }


            labelIngred9Units.Text = Convert.ToString(this.productLotTableAdapter.GetIngred9Unit(build, lot));
            labelIngred9Price.Text = Convert.ToString(this.productLotTableAdapter.GetIngred9Price(build, lot));
            labelIngred9Total.Text = Convert.ToString(this.productLotTableAdapter.GetIngred9Total(build, lot));



            checkBoxIngred10.Checked = Convert.ToBoolean(this.productLotTableAdapter.GetCheckIngred10(build, lot));
            comboBoxIngred10.Text = Convert.ToString(this.productLotTableAdapter.GetIngred10(build, lot));


            if (Convert.ToDecimal(this.productLotTableAdapter.GetIngred10Qty(build, lot)) == 0)
            {
                textBoxIngred10Qty.Text = "";
            }
            else
            {
                textBoxIngred10Qty.Text = Convert.ToString(this.productLotTableAdapter.GetIngred10Qty(build, lot));
            }


            labelIngred10Units.Text = Convert.ToString(this.productLotTableAdapter.GetIngred10Unit(build, lot));
            labelIngred10Price.Text = Convert.ToString(this.productLotTableAdapter.GetIngred10Price(build, lot));
            labelIngred10Total.Text = Convert.ToString(this.productLotTableAdapter.GetIngred10Total(build, lot));



            //Pack Information

            checkBoxPack1.Checked = Convert.ToBoolean(this.productLotTableAdapter.GetCheckPack1(build, lot));
            comboBoxPack1.Text = Convert.ToString(this.productLotTableAdapter.GetTypePack1(build, lot));

            if (Convert.ToDecimal(this.productLotTableAdapter.GetQtyPack1(build, lot)) == 0)
            {
                textBoxQtyPack1.Text = "";
            }
            else
            {
                textBoxQtyPack1.Text = Convert.ToString(this.productLotTableAdapter.GetQtyPack1(build, lot));
            }
            labelPackPrice1.Text = Convert.ToString(this.productLotTableAdapter.GetPricePack1(build, lot));
            labelPackValue1.Text = Convert.ToString(this.productLotTableAdapter.GetValuePack1(build, lot));



            checkBoxPack2.Checked = Convert.ToBoolean(this.productLotTableAdapter.GetCheckPack2(build, lot));
            comboBoxPack2.Text = Convert.ToString(this.productLotTableAdapter.GetTypePack2(build, lot));

            if (Convert.ToDecimal(this.productLotTableAdapter.GetQtyPack2(build, lot)) == 0)
            {
                textBoxQtyPack2.Text = "";
            }
            else
            {
                textBoxQtyPack2.Text = Convert.ToString(this.productLotTableAdapter.GetQtyPack2(build, lot));
            }
            labelPackPrice2.Text = Convert.ToString(this.productLotTableAdapter.GetPricePack2(build, lot));
            labelPackTotal2.Text = Convert.ToString(this.productLotTableAdapter.GetTotalPack2(build, lot));
            labelPackValue2.Text = Convert.ToString(this.productLotTableAdapter.GetValuePack2(build, lot));


            checkBoxPack3.Checked = Convert.ToBoolean(this.productLotTableAdapter.GetCheckPack3(build, lot));
            comboBoxPack3.Text = Convert.ToString(this.productLotTableAdapter.GetTypePack3(build, lot));


            if (Convert.ToDecimal(this.productLotTableAdapter.GetQtyPack3(build, lot)) == 0)
            {
                textBoxQtyPack3.Text = "";
            }
            else
            {
                textBoxQtyPack3.Text = Convert.ToString(this.productLotTableAdapter.GetQtyPack3(build, lot));
            }
            labelPackPrice3.Text = Convert.ToString(this.productLotTableAdapter.GetPricePack3(build, lot));
            labelPackTotal3.Text = Convert.ToString(this.productLotTableAdapter.GetTotalPack3(build, lot));
            labelPackValue3.Text = Convert.ToString(this.productLotTableAdapter.GetValuePack3(build, lot));

            checkBoxPack4.Checked = Convert.ToBoolean(this.productLotTableAdapter.GetCheckPack4(build, lot));
            comboBoxPack4.Text = Convert.ToString(this.productLotTableAdapter.GetTypePack4(build, lot));

            if (Convert.ToDecimal(this.productLotTableAdapter.GetQtyPack4(build, lot)) == 0)
            {
                textBoxQtyPack4.Text = "";
            }
            else
            {
                textBoxQtyPack4.Text = Convert.ToString(this.productLotTableAdapter.GetQtyPack4(build, lot));
            }
            labelPackPrice4.Text = Convert.ToString(this.productLotTableAdapter.GetPricePack4(build, lot));
            labelPackTotal4.Text = Convert.ToString(this.productLotTableAdapter.GetTotalPack4(build, lot));
            labelPackValue4.Text = Convert.ToString(this.productLotTableAdapter.GetValuePack4(build, lot));


            checkBoxPack5.Checked = Convert.ToBoolean(this.productLotTableAdapter.GetCheckPack5(build, lot));
            comboBoxPack5.Text = Convert.ToString(this.productLotTableAdapter.GetTypePack5(build, lot));

            if (Convert.ToDecimal(this.productLotTableAdapter.GetQtyPack5(build, lot)) == 0)
            {
                textBoxQtyPack5.Text = "";
            }
            else
            {
                textBoxQtyPack5.Text = Convert.ToString(this.productLotTableAdapter.GetQtyPack5(build, lot));
            }
            labelPackPrice5.Text = Convert.ToString(this.productLotTableAdapter.GetPricePack5(build, lot));
            labelPackTotal5.Text = Convert.ToString(this.productLotTableAdapter.GetTotalPack5(build, lot));
            labelPackValue5.Text = Convert.ToString(this.productLotTableAdapter.GetValuePack5(build, lot));


            checkBoxStaff1.Checked = Convert.ToBoolean(this.productLotTableAdapter.GetCheckStaff1(build, lot));
            comboBoxStaff1.Text = Convert.ToString(this.productLotTableAdapter.GetStaff1(build, lot));

            if (Convert.ToDecimal(this.productLotTableAdapter.GetHoursStaff1(build, lot)) == 0)
            {
                textBoxHoursStaff1.Text = "";
            }
            else
            {
                textBoxHoursStaff1.Text = Convert.ToString(this.productLotTableAdapter.GetHoursStaff1(build, lot));
            }

            labelRateStaff1.Text = Convert.ToString(this.productLotTableAdapter.GetRateStaff1(build, lot));
            labelTotalStaff1.Text = Convert.ToString(this.productLotTableAdapter.GetRateStaff1(build, lot));


            checkBoxStaff2.Checked = Convert.ToBoolean(this.productLotTableAdapter.GetCheckStaff2(build, lot));
            comboBoxStaff2.Text = Convert.ToString(this.productLotTableAdapter.GetStaff2(build, lot));

            if (Convert.ToDecimal(this.productLotTableAdapter.GetHoursStaff2(build, lot)) == 0)
            {
                textBoxHoursStaff2.Text = "";
            }
            else
            {
                textBoxHoursStaff2.Text = Convert.ToString(this.productLotTableAdapter.GetHoursStaff2(build, lot));
            }

            labelRateStaff2.Text = Convert.ToString(this.productLotTableAdapter.GetRateStaff2(build, lot));
            labelTotalStaff2.Text = Convert.ToString(this.productLotTableAdapter.GetRateStaff2(build, lot));


            checkBoxStaff3.Checked = Convert.ToBoolean(this.productLotTableAdapter.GetCheckStaff3(build, lot));
            comboBoxStaff3.Text = Convert.ToString(this.productLotTableAdapter.GetStaff3(build, lot));

            if (Convert.ToDecimal(this.productLotTableAdapter.GetHoursStaff3(build, lot)) == 0)
            {
                textBoxHoursStaff3.Text = "";
            }
            else
            {
                textBoxHoursStaff3.Text = Convert.ToString(this.productLotTableAdapter.GetHoursStaff3(build, lot));
            }

            labelRateStaff3.Text = Convert.ToString(this.productLotTableAdapter.GetRateStaff3(build, lot));
            labelTotalStaff3.Text = Convert.ToString(this.productLotTableAdapter.GetRateStaff3(build, lot));


            checkBoxStaff4.Checked = Convert.ToBoolean(this.productLotTableAdapter.GetCheckStaff4(build, lot));
            comboBoxStaff4.Text = Convert.ToString(this.productLotTableAdapter.GetStaff4(build, lot));

            if (Convert.ToDecimal(this.productLotTableAdapter.GetHoursStaff4(build, lot)) == 0)
            {
                textBoxHoursStaff4.Text = "";
            }
            else
            {
                textBoxHoursStaff4.Text = Convert.ToString(this.productLotTableAdapter.GetHoursStaff4(build, lot));
            }

            labelRateStaff4.Text = Convert.ToString(this.productLotTableAdapter.GetRateStaff4(build, lot));
            labelTotalStaff4.Text = Convert.ToString(this.productLotTableAdapter.GetRateStaff4(build, lot));


            checkBoxStaff5.Checked = Convert.ToBoolean(this.productLotTableAdapter.GetCheckStaff5(build, lot));
            comboBoxStaff5.Text = Convert.ToString(this.productLotTableAdapter.GetStaff5(build, lot));

            if (Convert.ToDecimal(this.productLotTableAdapter.GetHoursStaff5(build, lot)) == 0)
            {
                textBoxHoursStaff5.Text = "";
            }
            else
            {
                textBoxHoursStaff5.Text = Convert.ToString(this.productLotTableAdapter.GetHoursStaff5(build, lot));
            }

            labelRateStaff5.Text = Convert.ToString(this.productLotTableAdapter.GetRateStaff5(build, lot));
            labelTotalStaff5.Text = Convert.ToString(this.productLotTableAdapter.GetRateStaff5(build, lot));




            textBoxKitchenLocation.Text = Convert.ToString(this.productLotTableAdapter.GetKitchenLocation(build, lot));
            textBoxKitchenHours.Text = Convert.ToString(this.productLotTableAdapter.GetKitchenHours(build, lot));
            textBoxKitchenRate.Text = Convert.ToString(this.productLotTableAdapter.GetKitchenRate(build, lot));
            labelKitchenTotal.Text = Convert.ToString(this.productLotTableAdapter.GetKitchenTotal(build, lot));






        }



        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {

        }

        private void ingredientsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void addRemoveIngredientsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //When clicked it sends a variable to the password form so it knows where to send the user once the pasword is entered correctly. Using one Password Form instead of three seperate
            int linkFrom = 1;
            Password formSentry = new Password();
            formSentry.sendLinkInfo(linkFrom);
            formSentry.ShowDialog();
        }

        private void Order_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'kitchenDataSet.ProductLot' table. You can move, or remove it, as needed.
            //this.productLotTableAdapter.Fill(this.kitchenDataSet.ProductLot);
            // TODO: This line of code loads data into the 'kitchenDataSet.Lot' table. You can move, or remove it, as needed.
            //  this.lotTableAdapter.Fill(this.kitchenDataSet.Lot);


            // TODO: This line of code loads data into the 'kitchenDataSet.Staff' table. You can move, or remove it, as needed.
            this.staffTableAdapter.Fill(this.kitchenDataSet.Staff);
            // TODO: This line of code loads data into the 'kitchenDataSet.Packaging' table. You can move, or remove it, as needed.
            this.packagingTableAdapter.Fill(this.kitchenDataSet.Packaging);

            //This line reads the passwordTableAdapter to see if there is an Admin account and sets the variable to checkFirstRun
            int checkFirstRun = Convert.ToInt32(this.passwordTableAdapter.CheckFirstTime());


            //Laucnhes the create Admin account which stores a user name and password that is used later to access specific parts of the program
            if (checkFirstRun == 0)
            {
                AccountStartUp myAccountStartUp = new AccountStartUp();
                myAccountStartUp.ShowDialog();
            }
            else
            {
                // TODO: This line of code loads data into the 'kitchenDataSet.Ingredients' table. You can move, or remove it, as needed.
                this.ingredientsTableAdapter.Fill(this.kitchenDataSet.Ingredients);
                // TODO: This line of code loads data into the 'kitchenDataSet.Ingredients' table. You can move, or remove it, as needed.
                this.ingredientsTableAdapter.Fill(this.kitchenDataSet.Ingredients);
            }
        }

        private void checkBoxIngred1_CheckedChanged(object sender, EventArgs e)
        {
            //removes any selected items setting it to -1 and then clears the combobox before adding any new values.
            comboBoxIngred1.SelectedIndex = -1;
            comboBoxIngred1.Items.Clear();
            textBoxIngred1Qty.Text = "";

            labelIngred1Units.Text = "";
            labelIngred1Price.Text = "0.00";
            labelIngred1Total.Text = "0.00";
            TotalIngred();



            //The method runs when there is a change in the checkbox...below are the if statements based on checked or unchecked.
            if (checkBoxIngred1.Checked)
            {
                //counts the number of recoreds in the ingredient table
                int totalIngredList = Convert.ToInt32(this.ingredientsTableAdapter.Count());

                //temporary string to hold the name of the ingredient and add it to the combobox
                string ingredTemp;

                //loads the name of the item in the combox box looping based on the number of ingredients in the database.
                for (int i = 0; i < totalIngredList; i++)
                {
                    ingredTemp = Convert.ToString(this.ingredientsTableAdapter.RetrieveRecord(i + 1));
                    comboBoxIngred1.Items.Add(ingredTemp);
                }

            }
            else if (!checkBoxIngred1.Checked)
            {
                //clears the checkbox and sets the prompt "Click Checkbox"
                comboBoxIngred1.SelectedIndex = -1;
                comboBoxIngred1.Items.Clear();
                comboBoxIngred1.Items.Add("Click Checkbox");
                textBoxIngred1Qty.Text = "";

                labelIngred1Units.Text = "";
                labelIngred1Price.Text = "0.00";
            }
        }

        private void ingredientsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.ingredientsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.kitchenDataSet);

        }

        private void ingredientsBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.ingredientsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.kitchenDataSet);

        }

        private void comboBoxIngred1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // code to load the UNITS
            textBoxIngred1Qty.Text = "";

            labelIngred1Units.Text = "";
            labelIngred1Total.Text = "0.00";

            string tempUnits;

            tempUnits = Convert.ToString(this.ingredientsTableAdapter.GetUnits(comboBoxIngred1.Text));
            labelIngred1Units.Text = tempUnits;

            // code to load the PRICE

            decimal tempPrice;




            tempPrice = Convert.ToDecimal(this.ingredientsTableAdapter.GetPrice(comboBoxIngred1.Text));
            labelIngred1Price.Text = tempPrice.ToString("f");


        }



        private void textBoxIngred1Qty_TextChanged(object sender, EventArgs e)
        {


            //restrict user to use only interger

            //uses a try and catch to prevent any bad data from being automatically calculated. Program won't try to recalculate if a letter is put in instead of a number. 
            try
            {
                decimal tempTotal;
                tempTotal = Convert.ToDecimal(labelIngred1Price.Text) * Convert.ToDecimal(textBoxIngred1Qty.Text);
                labelIngred1Total.Text = tempTotal.ToString("f");
                TotalIngred();
            }
            catch
            {

                labelIngred1Total.Text = "0.00";
                TotalIngred();
            }

        }

        private void checkBoxIngred2_CheckedChanged(object sender, EventArgs e)
        {
            //removes any selected items setting it to -1 and then clears the combobox before adding any new values.
            comboBoxIngred2.SelectedIndex = -1;
            comboBoxIngred2.Items.Clear();
            textBoxIngred2Qty.Text = "";

            labelIngred2Units.Text = "";
            labelIngred2Price.Text = "0.00";
            labelIngred2Total.Text = "0.00";
            TotalIngred();

            //counts the number of ingredients in the database


            //The method runs when there is a change in the checkbox...below are the if statements based on checked or unchecked.
            if (checkBoxIngred2.Checked)
            {
                //counts the number of recoreds in the ingredient table
                int totalIngredList = Convert.ToInt32(this.ingredientsTableAdapter.Count());

                //temporary string to hold the name of the ingredient and add it to the combobox
                string ingredTemp;

                //loads the name of the item in the combox box looping based on the number of ingredients in the database.
                for (int i = 0; i < totalIngredList; i++)
                {
                    ingredTemp = Convert.ToString(this.ingredientsTableAdapter.RetrieveRecord(i + 1));
                    comboBoxIngred2.Items.Add(ingredTemp);
                }

            }
            else if (!checkBoxIngred2.Checked)
            {
                //clears the checkbox and sets the prompt "Click Checkbox"
                comboBoxIngred2.SelectedIndex = -1;
                comboBoxIngred2.Items.Clear();
                comboBoxIngred2.Items.Add("Click Checkbox");
                textBoxIngred2Qty.Text = "";

                labelIngred2Units.Text = "";
                labelIngred2Price.Text = "0.00";



            }
        }

        private void comboBoxIngred2_SelectedIndexChanged(object sender, EventArgs e)
        {
            // code to load the UNITS
            textBoxIngred2Qty.Text = "";

            labelIngred2Units.Text = "";
            labelIngred2Total.Text = "0.00";

            string tempUnits;

            tempUnits = Convert.ToString(this.ingredientsTableAdapter.GetUnits(comboBoxIngred2.Text));
            labelIngred2Units.Text = tempUnits;

            // code to load the PRICE

            decimal tempPrice;

            tempPrice = Convert.ToDecimal(this.ingredientsTableAdapter.GetPrice(comboBoxIngred2.Text));

            labelIngred2Price.Text = tempPrice.ToString("f");
        }

        private void textBoxIngred2Qty_TextChanged(object sender, EventArgs e)
        {

            try
            {
                decimal tempTotal;
                tempTotal = Convert.ToDecimal(textBoxIngred2Qty.Text) * Convert.ToDecimal(labelIngred2Price.Text);
                labelIngred2Total.Text = tempTotal.ToString("f");
                TotalIngred();
            }
            catch
            {
                labelIngred2Total.Text = "0.00";
                TotalIngred();
            }

        }

        private void checkBoxIngred3_CheckedChanged(object sender, EventArgs e)
        {
            //removes any selected items setting it to -1 and then clears the combobox before adding any new values.
            comboBoxIngred3.SelectedIndex = -1;
            comboBoxIngred3.Items.Clear();
            textBoxIngred3Qty.Text = "";

            labelIngred3Units.Text = "";
            labelIngred3Price.Text = "0.00";
            labelIngred3Total.Text = "0.00";
            TotalIngred();

            //counts the number of ingredients in the database


            //The method runs when there is a change in the checkbox...below are the if statements based on checked or unchecked.
            if (checkBoxIngred3.Checked)
            {
                //counts the number of recoreds in the ingredient table
                int totalIngredList = Convert.ToInt32(this.ingredientsTableAdapter.Count());

                //temporary string to hold the name of the ingredient and add it to the combobox
                string ingredTemp;

                //loads the name of the item in the combox box looping based on the number of ingredients in the database.
                for (int i = 0; i < totalIngredList; i++)
                {
                    ingredTemp = Convert.ToString(this.ingredientsTableAdapter.RetrieveRecord(i + 1));
                    comboBoxIngred3.Items.Add(ingredTemp);
                }

            }
            else if (!checkBoxIngred3.Checked)
            {
                //clears the checkbox and sets the prompt "Click Checkbox"
                comboBoxIngred3.SelectedIndex = -1;
                comboBoxIngred3.Items.Clear();
                comboBoxIngred3.Items.Add("Click Checkbox");
                textBoxIngred3Qty.Text = "";

                labelIngred3Units.Text = "";
                labelIngred3Price.Text = "0.00";



            }
        }

        private void comboBoxIngred3_SelectedIndexChanged(object sender, EventArgs e)
        {
            // code to load the UNITS
            textBoxIngred3Qty.Text = "";

            labelIngred3Units.Text = "";
            labelIngred3Total.Text = "0.00";

            string tempUnits;

            tempUnits = Convert.ToString(this.ingredientsTableAdapter.GetUnits(comboBoxIngred3.Text));
            labelIngred3Units.Text = tempUnits;

            // code to load the PRICE

            decimal tempPrice;

            tempPrice = Convert.ToDecimal(this.ingredientsTableAdapter.GetPrice(comboBoxIngred3.Text));

            labelIngred3Price.Text = tempPrice.ToString("f");
        }

        private void textBoxIngred3Qty_TextChanged(object sender, EventArgs e)
        {

            try
            {
                decimal tempTotal;
                tempTotal = Convert.ToInt16(textBoxIngred3Qty.Text) * Convert.ToDecimal(labelIngred3Price.Text);
                labelIngred3Total.Text = Convert.ToString(tempTotal);
                TotalIngred();
            }
            catch
            {
                labelIngred3Total.Text = "0.00";
                TotalIngred();
            }
        }

        private void checkBoxIngred4_CheckedChanged(object sender, EventArgs e)
        {
            //removes any selected items setting it to -1 and then clears the combobox before adding any new values.
            comboBoxIngred4.SelectedIndex = -1;
            comboBoxIngred4.Items.Clear();
            textBoxIngred4Qty.Text = "";

            labelIngred4Units.Text = "";
            labelIngred4Price.Text = "0.00";
            labelIngred4Total.Text = "0.00";
            TotalIngred();

            //counts the number of ingredients in the database


            //The method runs when there is a change in the checkbox...below are the if statements based on checked or unchecked.
            if (checkBoxIngred4.Checked)
            {
                //counts the number of recoreds in the ingredient table
                int totalIngredList = Convert.ToInt32(this.ingredientsTableAdapter.Count());

                //temporary string to hold the name of the ingredient and add it to the combobox
                string ingredTemp;

                //loads the name of the item in the combox box looping based on the number of ingredients in the database.
                for (int i = 0; i < totalIngredList; i++)
                {
                    ingredTemp = Convert.ToString(this.ingredientsTableAdapter.RetrieveRecord(i + 1));
                    comboBoxIngred4.Items.Add(ingredTemp);
                }

            }
            else if (!checkBoxIngred4.Checked)
            {
                //clears the checkbox and sets the prompt "Click Checkbox"
                comboBoxIngred4.SelectedIndex = -1;
                comboBoxIngred4.Items.Clear();
                comboBoxIngred4.Items.Add("Click Checkbox");
                textBoxIngred4Qty.Text = "";

                labelIngred4Units.Text = "";
                labelIngred4Price.Text = "0.00";



            }
        }

        private void comboBoxIngred4_SelectedIndexChanged(object sender, EventArgs e)
        {
            // code to load the UNITS
            textBoxIngred4Qty.Text = "";

            labelIngred4Units.Text = "";
            labelIngred4Total.Text = "0.00";

            string tempUnits;

            tempUnits = Convert.ToString(this.ingredientsTableAdapter.GetUnits(comboBoxIngred4.Text));
            labelIngred4Units.Text = tempUnits;

            // code to load the PRICE

            decimal tempPrice;

            tempPrice = Convert.ToDecimal(this.ingredientsTableAdapter.GetPrice(comboBoxIngred4.Text));

            labelIngred4Price.Text = tempPrice.ToString("f");
        }

        private void textBoxIngred4Qty_TextChanged(object sender, EventArgs e)
        {
            try
            {
                decimal tempTotal;
                tempTotal = Convert.ToInt16(textBoxIngred4Qty.Text) * Convert.ToDecimal(labelIngred4Price.Text);
                labelIngred4Total.Text = tempTotal.ToString("f");
                TotalIngred();
            }
            catch
            {
                labelIngred4Total.Text = "0.00";
                TotalIngred();
            }
        }

        private void checkBoxIngred5_CheckedChanged(object sender, EventArgs e)
        {
            //removes any selected items setting it to -1 and then clears the combobox before adding any new values.
            comboBoxIngred5.SelectedIndex = -1;
            comboBoxIngred5.Items.Clear();
            textBoxIngred5Qty.Text = "";

            labelIngred5Units.Text = "";
            labelIngred5Price.Text = "0.00";
            labelIngred5Total.Text = "0.00";
            TotalIngred();

            //counts the number of ingredients in the database


            //The method runs when there is a change in the checkbox...below are the if statements based on checked or unchecked.
            if (checkBoxIngred5.Checked)
            {
                //counts the number of recoreds in the ingredient table
                int totalIngredList = Convert.ToInt32(this.ingredientsTableAdapter.Count());

                //temporary string to hold the name of the ingredient and add it to the combobox
                string ingredTemp;

                //loads the name of the item in the combox box looping based on the number of ingredients in the database.
                for (int i = 0; i < totalIngredList; i++)
                {
                    ingredTemp = Convert.ToString(this.ingredientsTableAdapter.RetrieveRecord(i + 1));
                    comboBoxIngred5.Items.Add(ingredTemp);
                }

            }
            else if (!checkBoxIngred5.Checked)
            {
                //clears the checkbox and sets the prompt "Click Checkbox"
                comboBoxIngred5.SelectedIndex = -1;
                comboBoxIngred5.Items.Clear();
                comboBoxIngred5.Items.Add("Click Checkbox");
                textBoxIngred5Qty.Text = "";

                labelIngred5Units.Text = "";
                labelIngred5Price.Text = "0.00";



            }
        }

        private void comboBoxIngred5_SelectedIndexChanged(object sender, EventArgs e)
        {
            // code to load the UNITS
            textBoxIngred5Qty.Text = "";

            labelIngred5Units.Text = "";
            labelIngred5Total.Text = "0.00";

            string tempUnits;

            tempUnits = Convert.ToString(this.ingredientsTableAdapter.GetUnits(comboBoxIngred5.Text));
            labelIngred5Units.Text = tempUnits;

            // code to load the PRICE

            decimal tempPrice;

            tempPrice = Convert.ToDecimal(this.ingredientsTableAdapter.GetPrice(comboBoxIngred5.Text));

            labelIngred5Price.Text = tempPrice.ToString("f");
        }

        private void textBoxIngred5Qty_TextChanged(object sender, EventArgs e)
        {
            try
            {
                decimal tempTotal;
                tempTotal = Convert.ToInt16(textBoxIngred5Qty.Text) * Convert.ToDecimal(labelIngred5Price.Text);
                labelIngred5Total.Text = tempTotal.ToString("f");
                TotalIngred();
            }
            catch
            {
                labelIngred5Total.Text = "0.00";
                TotalIngred();
            }
        }

        private void checkBoxIngred6_CheckedChanged(object sender, EventArgs e)
        {
            //removes any selected items setting it to -1 and then clears the combobox before adding any new values.
            comboBoxIngred6.SelectedIndex = -1;
            comboBoxIngred6.Items.Clear();
            textBoxIngred6Qty.Text = "";

            labelIngred6Units.Text = "";
            labelIngred6Price.Text = "0.00";
            labelIngred6Total.Text = "0.00";
            TotalIngred();

            //counts the number of ingredients in the database


            //The method runs when there is a change in the checkbox...below are the if statements based on checked or unchecked.
            if (checkBoxIngred6.Checked)
            {
                //counts the number of recoreds in the ingredient table
                int totalIngredList = Convert.ToInt32(this.ingredientsTableAdapter.Count());

                //temporary string to hold the name of the ingredient and add it to the combobox
                string ingredTemp;

                //loads the name of the item in the combox box looping based on the number of ingredients in the database.
                for (int i = 0; i < totalIngredList; i++)
                {
                    ingredTemp = Convert.ToString(this.ingredientsTableAdapter.RetrieveRecord(i + 1));
                    comboBoxIngred6.Items.Add(ingredTemp);
                }

            }
            else if (!checkBoxIngred6.Checked)
            {
                //clears the checkbox and sets the prompt "Click Checkbox"
                comboBoxIngred6.SelectedIndex = -1;
                comboBoxIngred6.Items.Clear();
                comboBoxIngred6.Items.Add("Click Checkbox");
                textBoxIngred6Qty.Text = "";

                labelIngred6Units.Text = "";
                labelIngred6Price.Text = "0.00";



            }
        }

        private void comboBoxIngred6_SelectedIndexChanged(object sender, EventArgs e)
        {
            // code to load the UNITS
            textBoxIngred6Qty.Text = "";

            labelIngred6Units.Text = "";
            labelIngred6Total.Text = "0.00";

            string tempUnits;

            tempUnits = Convert.ToString(this.ingredientsTableAdapter.GetUnits(comboBoxIngred6.Text));
            labelIngred6Units.Text = tempUnits;

            // code to load the PRICE

            decimal tempPrice;

            tempPrice = Convert.ToDecimal(this.ingredientsTableAdapter.GetPrice(comboBoxIngred6.Text));

            labelIngred6Price.Text = tempPrice.ToString("f");
        }

        private void textBoxIngred6Qty_TextChanged(object sender, EventArgs e)
        {
            try
            {
                decimal tempTotal;
                tempTotal = Convert.ToDecimal(textBoxIngred6Qty.Text) * Convert.ToDecimal(labelIngred6Price.Text);
                labelIngred6Total.Text = tempTotal.ToString("f");
                TotalIngred();
            }
            catch
            {
                labelIngred3Total.Text = "0.00";
                TotalIngred();
            }
        }

        private void checkBoxIngred7_CheckedChanged(object sender, EventArgs e)
        {
            //removes any selected items setting it to -1 and then clears the combobox before adding any new values.
            comboBoxIngred7.SelectedIndex = -1;
            comboBoxIngred7.Items.Clear();
            textBoxIngred7Qty.Text = "";

            labelIngred7Units.Text = "";
            labelIngred7Price.Text = "0.00";
            labelIngred7Total.Text = "0.00";
            TotalIngred();
            //counts the number of ingredients in the database


            //The method runs when there is a change in the checkbox...below are the if statements based on checked or unchecked.
            if (checkBoxIngred7.Checked)
            {
                //counts the number of recoreds in the ingredient table
                int totalIngredList = Convert.ToInt32(this.ingredientsTableAdapter.Count());

                //temporary string to hold the name of the ingredient and add it to the combobox
                string ingredTemp;

                //loads the name of the item in the combox box looping based on the number of ingredients in the database.
                for (int i = 0; i < totalIngredList; i++)
                {
                    ingredTemp = Convert.ToString(this.ingredientsTableAdapter.RetrieveRecord(i + 1));
                    comboBoxIngred7.Items.Add(ingredTemp);
                }

            }
            else if (!checkBoxIngred7.Checked)
            {
                //clears the checkbox and sets the prompt "Click Checkbox"
                comboBoxIngred7.SelectedIndex = -1;
                comboBoxIngred7.Items.Clear();
                comboBoxIngred7.Items.Add("Click Checkbox");
                textBoxIngred7Qty.Text = "";

                labelIngred7Units.Text = "";
                labelIngred7Price.Text = "0.00";



            }
        }

        private void checkBoxIngred8_CheckedChanged(object sender, EventArgs e)
        {
            //removes any selected items setting it to -1 and then clears the combobox before adding any new values.
            comboBoxIngred8.SelectedIndex = -1;
            comboBoxIngred8.Items.Clear();
            textBoxIngred8Qty.Text = "";

            labelIngred8Units.Text = "";
            labelIngred8Price.Text = "0.00";
            labelIngred8Total.Text = "0.00";
            TotalIngred();

            //counts the number of ingredients in the database


            //The method runs when there is a change in the checkbox...below are the if statements based on checked or unchecked.
            if (checkBoxIngred8.Checked)
            {
                //counts the number of recoreds in the ingredient table
                int totalIngredList = Convert.ToInt32(this.ingredientsTableAdapter.Count());

                //temporary string to hold the name of the ingredient and add it to the combobox
                string ingredTemp;

                //loads the name of the item in the combox box looping based on the number of ingredients in the database.
                for (int i = 0; i < totalIngredList; i++)
                {
                    ingredTemp = Convert.ToString(this.ingredientsTableAdapter.RetrieveRecord(i + 1));
                    comboBoxIngred8.Items.Add(ingredTemp);
                }

            }
            else if (!checkBoxIngred8.Checked)
            {
                //clears the checkbox and sets the prompt "Click Checkbox"
                comboBoxIngred8.SelectedIndex = -1;
                comboBoxIngred8.Items.Clear();
                comboBoxIngred8.Items.Add("Click Checkbox");
                textBoxIngred8Qty.Text = "";

                labelIngred8Units.Text = "";
                labelIngred8Price.Text = "0.00";



            }
        }

        private void checkBoxIngred9_CheckedChanged(object sender, EventArgs e)
        {
            //removes any selected items setting it to -1 and then clears the combobox before adding any new values.
            comboBoxIngred9.SelectedIndex = -1;
            comboBoxIngred9.Items.Clear();
            textBoxIngred9Qty.Text = "";

            labelIngred9Units.Text = "";
            labelIngred9Price.Text = "0.00";
            labelIngred9Total.Text = "0.00";
            TotalIngred();

            //counts the number of ingredients in the database


            //The method runs when there is a change in the checkbox...below are the if statements based on checked or unchecked.
            if (checkBoxIngred9.Checked)
            {
                //counts the number of recoreds in the ingredient table
                int totalIngredList = Convert.ToInt32(this.ingredientsTableAdapter.Count());

                //temporary string to hold the name of the ingredient and add it to the combobox
                string ingredTemp;

                //loads the name of the item in the combox box looping based on the number of ingredients in the database.
                for (int i = 0; i < totalIngredList; i++)
                {
                    ingredTemp = Convert.ToString(this.ingredientsTableAdapter.RetrieveRecord(i + 1));
                    comboBoxIngred9.Items.Add(ingredTemp);
                }

            }
            else if (!checkBoxIngred9.Checked)
            {
                //clears the checkbox and sets the prompt "Click Checkbox"
                comboBoxIngred9.SelectedIndex = -1;
                comboBoxIngred9.Items.Clear();
                comboBoxIngred9.Items.Add("Click Checkbox");
                textBoxIngred9Qty.Text = "";

                labelIngred9Units.Text = "";
                labelIngred9Price.Text = "0.00";



            }
        }

        private void checkBoxIngred10_CheckedChanged(object sender, EventArgs e)
        {
            //removes any selected items setting it to -1 and then clears the combobox before adding any new values.
            comboBoxIngred10.SelectedIndex = -1;
            comboBoxIngred10.Items.Clear();
            textBoxIngred10Qty.Text = "";

            labelIngred10Units.Text = "";
            labelIngred10Price.Text = "0.00";
            labelIngred10Total.Text = "0.00";
            TotalIngred();

            //counts the number of ingredients in the database


            //The method runs when there is a change in the checkbox...below are the if statements based on checked or unchecked.
            if (checkBoxIngred10.Checked)
            {
                //counts the number of recoreds in the ingredient table
                int totalIngredList = Convert.ToInt32(this.ingredientsTableAdapter.Count());

                //temporary string to hold the name of the ingredient and add it to the combobox
                string ingredTemp;

                //loads the name of the item in the combox box looping based on the number of ingredients in the database.
                for (int i = 0; i < totalIngredList; i++)
                {
                    ingredTemp = Convert.ToString(this.ingredientsTableAdapter.RetrieveRecord(i + 1));
                    comboBoxIngred10.Items.Add(ingredTemp);
                }

            }
            else if (!checkBoxIngred10.Checked)
            {
                //clears the checkbox and sets the prompt "Click Checkbox"
                comboBoxIngred10.SelectedIndex = -1;
                comboBoxIngred10.Items.Clear();
                comboBoxIngred10.Items.Add("Click Checkbox");
                textBoxIngred10Qty.Text = "";

                labelIngred10Units.Text = "";
                labelIngred10Price.Text = "0.00";



            }
        }

        private void comboBoxIngred7_SelectedIndexChanged(object sender, EventArgs e)
        {
            // code to load the UNITS
            textBoxIngred7Qty.Text = "";

            labelIngred7Units.Text = "";
            labelIngred7Total.Text = "0.00";

            string tempUnits;

            tempUnits = Convert.ToString(this.ingredientsTableAdapter.GetUnits(comboBoxIngred7.Text));
            labelIngred7Units.Text = tempUnits;

            // code to load the PRICE

            decimal tempPrice;

            tempPrice = Convert.ToDecimal(this.ingredientsTableAdapter.GetPrice(comboBoxIngred7.Text));

            labelIngred7Price.Text = tempPrice.ToString("f");
        }

        private void comboBoxIngred8_SelectedIndexChanged(object sender, EventArgs e)
        {
            // code to load the UNITS
            textBoxIngred8Qty.Text = "";

            labelIngred8Units.Text = "";
            labelIngred8Total.Text = "0.00";

            string tempUnits;

            tempUnits = Convert.ToString(this.ingredientsTableAdapter.GetUnits(comboBoxIngred8.Text));
            labelIngred8Units.Text = tempUnits;

            // code to load the PRICE

            decimal tempPrice;

            tempPrice = Convert.ToDecimal(this.ingredientsTableAdapter.GetPrice(comboBoxIngred8.Text));

            labelIngred8Price.Text = tempPrice.ToString("f");
        }

        private void comboBoxIngred9_SelectedIndexChanged(object sender, EventArgs e)
        {
            // code to load the UNITS
            textBoxIngred9Qty.Text = "";

            labelIngred9Units.Text = "";
            labelIngred9Total.Text = "0.00";

            string tempUnits;

            tempUnits = Convert.ToString(this.ingredientsTableAdapter.GetUnits(comboBoxIngred9.Text));
            labelIngred9Units.Text = tempUnits;

            // code to load the PRICE

            decimal tempPrice;

            tempPrice = Convert.ToDecimal(this.ingredientsTableAdapter.GetPrice(comboBoxIngred9.Text));

            labelIngred9Price.Text = tempPrice.ToString("f");
        }

        private void comboBoxIngred10_SelectedIndexChanged(object sender, EventArgs e)
        {
            // code to load the UNITS
            textBoxIngred10Qty.Text = "";

            labelIngred10Units.Text = "";
            labelIngred10Total.Text = "0.00";

            string tempUnits;

            tempUnits = Convert.ToString(this.ingredientsTableAdapter.GetUnits(comboBoxIngred10.Text));
            labelIngred10Units.Text = tempUnits;

            // code to load the PRICE

            decimal tempPrice;

            tempPrice = Convert.ToDecimal(this.ingredientsTableAdapter.GetPrice(comboBoxIngred10.Text));

            labelIngred10Price.Text = Convert.ToString(tempPrice);
        }

        private void textBoxIngred7Qty_TextChanged(object sender, EventArgs e)
        {
            try
            {
                decimal tempTotal;
                tempTotal = Convert.ToDecimal(textBoxIngred7Qty.Text) * Convert.ToDecimal(labelIngred7Price.Text);
                labelIngred7Total.Text = tempTotal.ToString("f");
                TotalIngred();
            }
            catch
            {
                labelIngred7Total.Text = "0.00";
                TotalIngred();
            }
        }

        private void textBoxIngred8Qty_TextChanged(object sender, EventArgs e)
        {
            try
            {
                decimal tempTotal;
                tempTotal = Convert.ToDecimal(textBoxIngred8Qty.Text) * Convert.ToDecimal(labelIngred8Price.Text);
                labelIngred8Total.Text = Convert.ToString(tempTotal);
                TotalIngred();
            }
            catch
            {
                labelIngred8Total.Text = "0.00";
                TotalIngred();
            }
        }

        private void textBoxIngred9Qty_TextChanged(object sender, EventArgs e)
        {
            try
            {
                decimal tempTotal;
                tempTotal = Convert.ToDecimal(textBoxIngred9Qty.Text) * Convert.ToDecimal(labelIngred9Price.Text);
                labelIngred9Total.Text = Convert.ToString(tempTotal);
                TotalIngred();
            }
            catch
            {
                labelIngred9Total.Text = "0.00";
                TotalIngred();
            }
        }

        private void textBoxIngred10Qty_TextChanged(object sender, EventArgs e)
        {
            try
            {
                decimal tempTotal;
                tempTotal = Convert.ToDecimal(textBoxIngred10Qty.Text) * Convert.ToDecimal(labelIngred10Price.Text);
                labelIngred10Total.Text = Convert.ToString(tempTotal);
                TotalIngred();
            }
            catch
            {
                labelIngred10Total.Text = "0.00";
                TotalIngred();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            checkBoxIngred1.Checked = false;
            checkBoxIngred2.Checked = false;
            checkBoxIngred3.Checked = false;
            checkBoxIngred4.Checked = false;
            checkBoxIngred5.Checked = false;

            checkBoxIngred6.Checked = false;
            checkBoxIngred7.Checked = false;
            checkBoxIngred8.Checked = false;
            checkBoxIngred9.Checked = false;
            checkBoxIngred10.Checked = false;

        }

        private void addRemovePackagingToolStripMenuItem_Click(object sender, EventArgs e)
        {

            int linkFrom = 2;
            Password formSentry = new Password();
            formSentry.sendLinkInfo(linkFrom);
            formSentry.ShowDialog();







        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void passwordResetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AccountStartUp resetPassword = new AccountStartUp();
            resetPassword.ShowDialog();
        }

        private void checkBoxPack1_CheckedChanged(object sender, EventArgs e)
        {
            //removes any selected items setting it to -1 and then clears the combobox before adding any new values.
            comboBoxPack1.SelectedIndex = -1;
            comboBoxPack1.Items.Clear();
            textBoxQtyPack1.Text = "";
            labelPackPrice1.Text = "0.00";
            labelPackTotal1.Text = "0.00";
            labelPackValue1.Text = "0.00";
            TotalPackage();
            //TotalIngred();
            if (checkBoxPack1.Checked)
            {
                //counts the number of recoreds in the packaging table
                int totalPackList = Convert.ToInt32(this.packagingTableAdapter.Count());

                //temporary string to hold the name of the ingredient and add it to the combobox
                string packTemp;

                //loads the name of the item in the combox box looping based on the number of ingredients in the database.
                for (int i = 0; i < totalPackList; i++)
                {
                    packTemp = Convert.ToString(this.packagingTableAdapter.RetrieveRecord(i + 1));
                    comboBoxPack1.Items.Add(packTemp);
                }
            }
            else if (!checkBoxPack1.Checked)
            {
                //clears the combobox and sets the prompt "Click Checkbox"
                comboBoxPack1.SelectedIndex = -1;
                comboBoxPack1.Items.Clear();
                comboBoxPack1.Items.Add("Click Checkbox");
                textBoxQtyPack1.Text = "";

                labelPackPrice1.Text = "0.00";
            }

        }



        private void textBoxQtyPack1_TextChanged(object sender, EventArgs e)
        {

            try
            {
                decimal tempTotal;
                tempTotal = Convert.ToDecimal(textBoxQtyPack1.Text) * Convert.ToDecimal(labelPackPrice1.Text);

                decimal tempValueTotal = 0;
                tempValueTotal = Convert.ToDecimal(textBoxQtyPack1.Text) * Convert.ToDecimal(this.packagingTableAdapter.GetRetailPricePack(comboBoxPack1.Text));

                labelPackValue1.Text = tempValueTotal.ToString("f");
                labelPackTotal1.Text = tempTotal.ToString("f");
                TotalPackage();
            }
            catch
            {

            }
        }




        private void checkBoxPack2_CheckedChanged(object sender, EventArgs e)
        {
            //removes any selected items setting it to -1 and then clears the combobox before adding any new values.
            comboBoxPack2.SelectedIndex = -1;
            comboBoxPack2.Items.Clear();
            textBoxQtyPack2.Text = "";
            labelPackPrice2.Text = "0.00";
            labelPackTotal2.Text = "0.00";
            labelPackValue2.Text = "0.00";
            TotalPackage();
            //TotalIngred();
            if (checkBoxPack2.Checked)
            {
                //counts the number of recoreds in the packaging table
                int totalPackList = Convert.ToInt32(this.packagingTableAdapter.Count());

                //temporary string to hold the name of the ingredient and add it to the combobox
                string packTemp;

                //loads the name of the item in the combox box looping based on the number of ingredients in the database.
                for (int i = 0; i < totalPackList; i++)
                {
                    packTemp = Convert.ToString(this.packagingTableAdapter.RetrieveRecord(i + 1));
                    comboBoxPack2.Items.Add(packTemp);
                }
            }
            else if (!checkBoxPack2.Checked)
            {
                //clears the combobox and sets the prompt "Click Checkbox"
                comboBoxPack2.SelectedIndex = -1;
                comboBoxPack2.Items.Clear();
                comboBoxPack2.Items.Add("Click Checkbox");
                textBoxQtyPack2.Text = "";

                labelPackPrice2.Text = "0.00";
                labelPackValue2.Text = "0.00";
            }
        }

        private void checkBoxPack3_CheckedChanged(object sender, EventArgs e)
        {
            //removes any selected items setting it to -1 and then clears the combobox before adding any new values.
            comboBoxPack3.SelectedIndex = -1;
            comboBoxPack3.Items.Clear();
            textBoxQtyPack3.Text = "";
            labelPackPrice3.Text = "0.00";
            labelPackTotal3.Text = "0.00";
            TotalPackage();

            if (checkBoxPack3.Checked)
            {
                //counts the number of recoreds in the packaging table
                int totalPackList = Convert.ToInt32(this.packagingTableAdapter.Count());

                //temporary string to hold the name of the ingredient and add it to the combobox
                string packTemp;

                //loads the name of the item in the combox box looping based on the number of ingredients in the database.
                for (int i = 0; i < totalPackList; i++)
                {
                    packTemp = Convert.ToString(this.packagingTableAdapter.RetrieveRecord(i + 1));
                    comboBoxPack3.Items.Add(packTemp);
                }
            }
            else if (!checkBoxPack3.Checked)
            {
                //clears the combobox and sets the prompt "Click Checkbox"
                comboBoxPack3.SelectedIndex = -1;
                comboBoxPack3.Items.Clear();
                comboBoxPack3.Items.Add("Click Checkbox");
                textBoxQtyPack3.Text = "";

                labelPackPrice3.Text = "0.00";
                labelPackValue3.Text = "0.00";
            }
        }

        private void checkBoxPack4_CheckedChanged(object sender, EventArgs e)
        {
            //removes any selected items setting it to -1 and then clears the combobox before adding any new values.
            comboBoxPack4.SelectedIndex = -1;
            comboBoxPack4.Items.Clear();
            textBoxQtyPack4.Text = "";
            labelPackPrice4.Text = "0.00";
            labelPackTotal4.Text = "0.00";
            labelPackValue4.Text = "0.00";
            TotalPackage();
            //TotalIngred();
            if (checkBoxPack4.Checked)
            {
                //counts the number of recoreds in the packaging table
                int totalPackList = Convert.ToInt32(this.packagingTableAdapter.Count());

                //temporary string to hold the name of the ingredient and add it to the combobox
                string packTemp;

                //loads the name of the item in the combox box looping based on the number of ingredients in the database.
                for (int i = 0; i < totalPackList; i++)
                {
                    packTemp = Convert.ToString(this.packagingTableAdapter.RetrieveRecord(i + 1));
                    comboBoxPack4.Items.Add(packTemp);
                }
            }
            else if (!checkBoxPack4.Checked)
            {
                //clears the combobox and sets the prompt "Click Checkbox"
                comboBoxPack4.SelectedIndex = -1;
                comboBoxPack4.Items.Clear();
                comboBoxPack4.Items.Add("Click Checkbox");
                textBoxQtyPack4.Text = "";

                labelPackPrice4.Text = "0.00";
                labelPackValue4.Text = "0.00";
            }
        }

        private void checkBoxPack5_CheckedChanged(object sender, EventArgs e)
        {
            //removes any selected items setting it to -1 and then clears the combobox before adding any new values.
            comboBoxPack5.SelectedIndex = -1;
            comboBoxPack5.Items.Clear();
            textBoxQtyPack5.Text = "";
            labelPackPrice5.Text = "0.00";
            labelPackTotal5.Text = "0.00";
            labelPackValue5.Text = "0.00";
            TotalPackage();
            //TotalIngred();
            if (checkBoxPack5.Checked)
            {
                //counts the number of recoreds in the packaging table
                int totalPackList = Convert.ToInt32(this.packagingTableAdapter.Count());

                //temporary string to hold the name of the ingredient and add it to the combobox
                string packTemp;

                //loads the name of the item in the combox box looping based on the number of ingredients in the database.
                for (int i = 0; i < totalPackList; i++)
                {
                    packTemp = Convert.ToString(this.packagingTableAdapter.RetrieveRecord(i + 1));
                    comboBoxPack5.Items.Add(packTemp);
                }
            }
            else if (!checkBoxPack1.Checked)
            {
                //clears the combobox and sets the prompt "Click Checkbox"
                comboBoxPack5.SelectedIndex = -1;
                comboBoxPack5.Items.Clear();
                comboBoxPack5.Items.Add("Click Checkbox");
                textBoxQtyPack5.Text = "";

                labelPackPrice5.Text = "0.00";
                labelPackValue5.Text = "0.00";
            }
        }

        private void comboBoxPack1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //clears the boxes before setting
            textBoxQtyPack1.Text = "";
            labelPackPrice1.Text = "0.00";

            //finds the price of the item selected in the combo box and fills the price label
            decimal tempPrice;
            tempPrice = Convert.ToDecimal(this.packagingTableAdapter.GetPrice(comboBoxPack1.Text));
            labelPackPrice1.Text = tempPrice.ToString("f");
        }

        private void comboBoxPack2_SelectedIndexChanged(object sender, EventArgs e)
        {
            //clears the boxes before setting
            textBoxQtyPack2.Text = "";
            labelPackPrice2.Text = "0.00";

            //finds the price of the item selected in the combo box and fills the price label
            decimal tempPrice;
            tempPrice = Convert.ToDecimal(this.packagingTableAdapter.GetPrice(comboBoxPack2.Text));
            labelPackPrice2.Text = tempPrice.ToString("f");
        }

        private void comboBoxPack3_SelectedIndexChanged(object sender, EventArgs e)
        {
            //clears the boxes before setting
            textBoxQtyPack3.Text = "";
            labelPackPrice3.Text = "0.00";

            //finds the price of the item selected in the combo box and fills the price label
            decimal tempPrice;
            tempPrice = Convert.ToDecimal(this.packagingTableAdapter.GetPrice(comboBoxPack3.Text));
            labelPackPrice3.Text = tempPrice.ToString("f");
        }

        private void comboBoxPack4_SelectedIndexChanged(object sender, EventArgs e)
        {
            //clears the boxes before setting
            textBoxQtyPack4.Text = "";
            labelPackPrice4.Text = "0.00";

            //finds the price of the item selected in the combo box and fills the price label
            decimal tempPrice;
            tempPrice = Convert.ToDecimal(this.packagingTableAdapter.GetPrice(comboBoxPack4.Text));
            labelPackPrice4.Text = tempPrice.ToString("f");
        }

        private void comboBoxPack5_SelectedIndexChanged(object sender, EventArgs e)
        {
            //clears the boxes before setting
            textBoxQtyPack5.Text = "";
            labelPackPrice5.Text = "0.00";

            //finds the price of the item selected in the combo box and fills the price label
            decimal tempPrice;
            tempPrice = Convert.ToDecimal(this.packagingTableAdapter.GetPrice(comboBoxPack5.Text));
            labelPackPrice5.Text = tempPrice.ToString("f");
        }

        private void textBoxQtyPack2_TextChanged(object sender, EventArgs e)
        {

            try
            {
                decimal tempTotal;
                tempTotal = Convert.ToDecimal(textBoxQtyPack2.Text) * Convert.ToDecimal(labelPackPrice2.Text);

                decimal tempValueTotal = 0;
                tempValueTotal = Convert.ToDecimal(textBoxQtyPack2.Text) * Convert.ToDecimal(this.packagingTableAdapter.GetRetailPricePack(comboBoxPack2.Text));

                labelPackValue2.Text = tempValueTotal.ToString("f");
                labelPackTotal2.Text = tempTotal.ToString("f");
                TotalPackage();
            }
            catch
            {

            }
        }

        private void textBoxQtyPack3_TextChanged(object sender, EventArgs e)
        {

            try
            {
                decimal tempTotal;
                tempTotal = Convert.ToDecimal(textBoxQtyPack3.Text) * Convert.ToDecimal(labelPackPrice3.Text);

                decimal tempValueTotal = 0;
                tempValueTotal = Convert.ToDecimal(textBoxQtyPack3.Text) * Convert.ToDecimal(this.packagingTableAdapter.GetRetailPricePack(comboBoxPack3.Text));

                labelPackValue3.Text = tempValueTotal.ToString("f");
                labelPackTotal3.Text = tempTotal.ToString("f");
                TotalPackage();
            }
            catch
            {

            }
        }

        private void textBoxQtyPack4_TextChanged(object sender, EventArgs e)
        {

            try
            {
                decimal tempTotal;
                tempTotal = Convert.ToDecimal(textBoxQtyPack4.Text) * Convert.ToDecimal(labelPackPrice4.Text);

                decimal tempValueTotal = 0;
                tempValueTotal = Convert.ToDecimal(textBoxQtyPack4.Text) * Convert.ToDecimal(this.packagingTableAdapter.GetRetailPricePack(comboBoxPack4.Text));

                labelPackValue4.Text = tempValueTotal.ToString("f");
                labelPackTotal4.Text = tempTotal.ToString("f");
                TotalPackage();
            }
            catch
            {

            }
        }

        private void textBoxQtyPack5_TextChanged(object sender, EventArgs e)
        {

            try
            {
                decimal tempTotal;
                tempTotal = Convert.ToDecimal(textBoxQtyPack5.Text) * Convert.ToDecimal(labelPackPrice5.Text);

                decimal tempValueTotal = 0;
                tempValueTotal = Convert.ToDecimal(textBoxQtyPack5.Text) * Convert.ToDecimal(this.packagingTableAdapter.GetRetailPricePack(comboBoxPack5.Text));

                labelPackValue5.Text = tempValueTotal.ToString("f");
                labelPackTotal5.Text = tempTotal.ToString("f");
                TotalPackage();
            }
            catch
            {

            }
        }

        private void buttonPackClear_Click(object sender, EventArgs e)
        {
            checkBoxPack1.Checked = false;
            checkBoxPack2.Checked = false;
            checkBoxPack3.Checked = false;
            checkBoxPack4.Checked = false;
            checkBoxPack5.Checked = false;
        }

        private void buttonStaffClear_Click(object sender, EventArgs e)
        {
            checkBoxStaff1.Checked = false;
            checkBoxStaff2.Checked = false;
            checkBoxStaff3.Checked = false;
            checkBoxStaff4.Checked = false;
            checkBoxStaff5.Checked = false;
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //When clicked it sends a variable to the password form so it knows where to send the user once the pasword is entered correctly. Using one Password Form instead of three seperate
            int linkFrom = 3;
            Password formSentry = new Password();
            formSentry.sendLinkInfo(linkFrom);
            formSentry.ShowDialog();

        }

        private void checkBoxStaff1_CheckedChanged(object sender, EventArgs e)
        {

            comboBoxStaff1.SelectedIndex = -1;
            comboBoxStaff1.Items.Clear();
            textBoxHoursStaff1.Text = "";
            labelRateStaff1.Text = "0.00";
            TotalStaff();


            if (checkBoxStaff1.Checked)
            {
                //counts the number of recoreds in the STAFF table
                int totalStaffList = Convert.ToInt32(this.staffTableAdapter.Count());

                //temporary string to hold the name of the STAFF members and add it to the combobox
                string staffTemp;

                //loads the name of the item in the combox box looping based on the number of STAFF in the database.
                for (int i = 0; i < totalStaffList; i++)
                {
                    staffTemp = Convert.ToString(this.staffTableAdapter.GetStaffName(i + 1));
                    comboBoxStaff1.Items.Add(staffTemp);
                }
            }
            else if (!checkBoxStaff1.Checked)
            {
                //clears the combobox and sets the prompt "Click Checkbox" in the Combo Box
                comboBoxStaff1.SelectedIndex = -1;
                comboBoxStaff1.Items.Clear();
                comboBoxStaff1.Items.Add("Click Checkbox");
                textBoxHoursStaff1.Text = "";
                labelRateStaff1.Text = "0.00";
            }

        }

        private void textBoxHoursStaff1_TextChanged(object sender, EventArgs e)
        {

            //uses a try and catch to prevent any bad data from being automatically calculated. Program won't try to recalculate if a letter or symbol is put in instead of a number. 
            try
            {
                decimal tempTotal;
                tempTotal = Convert.ToDecimal(labelRateStaff1.Text) * Convert.ToDecimal(textBoxHoursStaff1.Text);
                labelTotalStaff1.Text = tempTotal.ToString("f");
                TotalStaff();
                CalculateLotTotal();
            }
            catch
            {
                labelTotalStaff1.Text = "0.00";
                TotalStaff();
                // CalculateLotTotal();
            }
        }

        private void comboBoxStaff1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Clears boxes before adding data

            textBoxHoursStaff1.Text = "";
            labelRateStaff1.Text = "0.00";

            // code to load the RATE

            decimal tempRate;
            tempRate = Convert.ToDecimal(this.staffTableAdapter.GetRate(comboBoxStaff1.Text));
            labelRateStaff1.Text = tempRate.ToString("f");
            TotalStaff();
            //CalculateLotTotal();
        }

        private void checkBoxStaff2_CheckedChanged(object sender, EventArgs e)
        {
            comboBoxStaff2.SelectedIndex = -1;
            comboBoxStaff2.Items.Clear();
            textBoxHoursStaff2.Text = "";
            labelRateStaff2.Text = "0.00";
            TotalStaff();


            if (checkBoxStaff2.Checked)
            {
                //counts the number of recoreds in the STAFF table
                int totalStaffList = Convert.ToInt32(this.staffTableAdapter.Count());

                //temporary string to hold the name of the STAFF members and add it to the combobox
                string staffTemp;

                //loads the name of the item in the combox box looping based on the number of ingredients in the database.
                for (int i = 0; i < totalStaffList; i++)
                {
                    staffTemp = Convert.ToString(this.staffTableAdapter.GetStaffName(i + 1));
                    comboBoxStaff2.Items.Add(staffTemp);
                }
            }
            else if (!checkBoxStaff2.Checked)
            {
                //clears the combobox and sets the prompt "Click Checkbox" in the Combo Box
                comboBoxStaff2.SelectedIndex = -1;
                comboBoxStaff2.Items.Clear();
                comboBoxStaff2.Items.Add("Click Checkbox");
                textBoxHoursStaff2.Text = "";

                labelRateStaff2.Text = "0.00";
            }
        }

        private void checkBoxStaff3_CheckedChanged(object sender, EventArgs e)
        {
            comboBoxStaff3.SelectedIndex = -1;
            comboBoxStaff3.Items.Clear();
            textBoxHoursStaff3.Text = "";
            labelRateStaff3.Text = "0.00";
            TotalStaff();


            if (checkBoxStaff3.Checked)
            {
                //counts the number of recoreds in the STAFF table
                int totalStaffList = Convert.ToInt32(this.staffTableAdapter.Count());

                //temporary string to hold the name of the STAFF members and add it to the combobox
                string staffTemp;

                //loads the name of the item in the combox box looping based on the number of STAFF in the database.
                for (int i = 0; i < totalStaffList; i++)
                {
                    staffTemp = Convert.ToString(this.staffTableAdapter.GetStaffName(i + 1));
                    comboBoxStaff3.Items.Add(staffTemp);
                }
            }
            else if (!checkBoxStaff3.Checked)
            {
                //clears the combobox and sets the prompt "Click Checkbox" in the Combo Box
                comboBoxStaff3.SelectedIndex = -1;
                comboBoxStaff3.Items.Clear();
                comboBoxStaff3.Items.Add("Click Checkbox");
                textBoxHoursStaff3.Text = "";
                labelRateStaff3.Text = "0.00";
            }
        }

        private void checkBoxStaff4_CheckedChanged(object sender, EventArgs e)
        {
            comboBoxStaff4.SelectedIndex = -1;
            comboBoxStaff4.Items.Clear();
            textBoxHoursStaff4.Text = "";
            labelRateStaff4.Text = "0.00";
            TotalStaff();


            if (checkBoxStaff4.Checked)
            {
                //counts the number of recoreds in the STAFF table
                int totalStaffList = Convert.ToInt32(this.staffTableAdapter.Count());

                //temporary string to hold the name of the STAFF members and add it to the combobox
                string staffTemp;

                //loads the name of the item in the combox box looping based on the number of STAFF in the database.
                for (int i = 0; i < totalStaffList; i++)
                {
                    staffTemp = Convert.ToString(this.staffTableAdapter.GetStaffName(i + 1));
                    comboBoxStaff4.Items.Add(staffTemp);
                }
            }
            else if (!checkBoxStaff4.Checked)
            {
                //clears the combobox and sets the prompt "Click Checkbox" in the Combo Box
                comboBoxStaff4.SelectedIndex = -1;
                comboBoxStaff4.Items.Clear();
                comboBoxStaff4.Items.Add("Click Checkbox");
                textBoxHoursStaff4.Text = "";
                labelRateStaff4.Text = "0.00";
            }
        }

        private void checkBoxStaff5_CheckedChanged(object sender, EventArgs e)
        {
            comboBoxStaff5.SelectedIndex = -1;
            comboBoxStaff5.Items.Clear();
            textBoxHoursStaff5.Text = "";
            labelRateStaff5.Text = "0.00";
            TotalStaff();


            if (checkBoxStaff5.Checked)
            {
                //counts the number of recoreds in the STAFF table
                int totalStaffList = Convert.ToInt32(this.staffTableAdapter.Count());

                //temporary string to hold the name of the STAFF members and add it to the combobox
                string staffTemp;

                //loads the name of the item in the combox box looping based on the number of STAFF in the database.
                for (int i = 0; i < totalStaffList; i++)
                {
                    staffTemp = Convert.ToString(this.staffTableAdapter.GetStaffName(i + 1));
                    comboBoxStaff5.Items.Add(staffTemp);
                }
            }
            else if (!checkBoxStaff5.Checked)
            {
                //clears the combobox and sets the prompt "Click Checkbox" in the Combo Box
                comboBoxStaff5.SelectedIndex = -1;
                comboBoxStaff5.Items.Clear();
                comboBoxStaff5.Items.Add("Click Checkbox");
                textBoxHoursStaff5.Text = "";
                labelRateStaff5.Text = "0.00";
            }
        }

        private void comboBoxStaff2_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Clears boxes before adding data

            textBoxHoursStaff2.Text = "";
            labelRateStaff2.Text = "0.00";

            // code to load the RATE

            decimal tempRate;
            tempRate = Convert.ToDecimal(this.staffTableAdapter.GetRate(comboBoxStaff2.Text));
            labelRateStaff2.Text = tempRate.ToString("f");
            TotalStaff();
            //CalculateLotTotal();
        }


        private void comboBoxStaff3_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Clears boxes before adding data

            textBoxHoursStaff3.Text = "";
            labelRateStaff3.Text = "0.00";

            // code to load the RATE

            decimal tempRate;
            tempRate = Convert.ToDecimal(this.staffTableAdapter.GetRate(comboBoxStaff3.Text));
            labelRateStaff3.Text = tempRate.ToString("f");
            TotalStaff();
            //CalculateLotTotal();
        }

        private void comboBoxStaff4_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Clears boxes before adding data

            textBoxHoursStaff4.Text = "";
            labelRateStaff4.Text = "0.00";

            // code to load the RATE

            decimal tempRate;
            tempRate = Convert.ToDecimal(this.staffTableAdapter.GetRate(comboBoxStaff4.Text));
            labelRateStaff4.Text = tempRate.ToString("f");
            TotalStaff();
            //CalculateLotTotal();
        }

        private void comboBoxStaff5_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Clears boxes before adding data

            textBoxHoursStaff5.Text = "";
            labelRateStaff5.Text = "0.00";

            // code to load the RATE

            decimal tempRate;
            tempRate = Convert.ToDecimal(this.staffTableAdapter.GetRate(comboBoxStaff5.Text));
            labelRateStaff5.Text = tempRate.ToString("f");
            TotalStaff();
            // CalculateLotTotal();
        }

        private void textBoxHoursStaff2_TextChanged(object sender, EventArgs e)
        {
            //uses a try and catch to prevent any bad data from being automatically calculated. Program won't try to recalculate if a letter or symbol is put in instead of a number. 
            try
            {
                decimal tempTotal;
                tempTotal = Convert.ToDecimal(labelRateStaff2.Text) * Convert.ToDecimal(textBoxHoursStaff2.Text);
                labelTotalStaff2.Text = tempTotal.ToString("f");
                TotalStaff();
                CalculateLotTotal();
            }
            catch
            {
                labelTotalStaff2.Text = "0.00";
                TotalStaff();
                // CalculateLotTotal();
            }
        }

        private void textBoxHoursStaff3_TextChanged(object sender, EventArgs e)
        {
            //uses a try and catch to prevent any bad data from being automatically calculated. Program won't try to recalculate if a letter or symbol is put in instead of a number. 
            try
            {
                decimal tempTotal;
                tempTotal = Convert.ToDecimal(labelRateStaff1.Text) * Convert.ToDecimal(textBoxHoursStaff3.Text);
                labelTotalStaff3.Text = tempTotal.ToString("f");
                TotalStaff();
                CalculateLotTotal();
            }
            catch
            {
                labelTotalStaff3.Text = "0.00";
                TotalStaff();
                // CalculateLotTotal();
            }
        }

        private void textBoxHoursStaff4_TextChanged(object sender, EventArgs e)
        {
            //uses a try and catch to prevent any bad data from being automatically calculated. Program won't try to recalculate if a letter or symbol is put in instead of a number. 
            try
            {
                decimal tempTotal;
                tempTotal = Convert.ToDecimal(labelRateStaff4.Text) * Convert.ToDecimal(textBoxHoursStaff4.Text);
                labelTotalStaff4.Text = tempTotal.ToString("f");
                TotalStaff();
                CalculateLotTotal();
            }
            catch
            {
                labelTotalStaff4.Text = "0.00";
                TotalStaff();
                // CalculateLotTotal();
            }
        }

        private void textBoxHoursStaff5_TextChanged(object sender, EventArgs e)
        {
            //uses a try and catch to prevent any bad data from being automatically calculated. Program won't try to recalculate if a letter or symbol is put in instead of a number. 
            try
            {
                decimal tempTotal;
                tempTotal = Convert.ToDecimal(labelRateStaff5.Text) * Convert.ToDecimal(textBoxHoursStaff5.Text);
                labelTotalStaff5.Text = tempTotal.ToString("f");
                TotalStaff();
                CalculateLotTotal();
            }
            catch
            {
                labelTotalStaff5.Text = "0.00";
                TotalStaff();
                // CalculateLotTotal();
            }
        }

        private void buttonAddProduct_Click(object sender, EventArgs e)
        {
            buttonAddProduct.Visible = false;
            //count the number of records first to find next ID

            int recordCount = 0;
            recordCount = Convert.ToInt16(this.productLotTableAdapter.Count());
            int id = recordCount + 1;

            Product product = new Product();


            int lot;


            if (!int.TryParse(textBoxLotNumber.Text, out lot))
            {
                MessageBox.Show("Enter a valid Lot#");
            }
            else
            {
                product.Lot = lot;
                product.Build = Convert.ToInt16(labelBuildNum.Text);
                product.ProductName = textBoxProductName.Text;
                product.Notes = textBoxProductNotes.Text;
                product.CheckIngred1 = checkBoxIngred1.Checked;


                if (String.IsNullOrEmpty(comboBoxIngred1.Text))
                {
                    product.Ingred1 = null;
                }
                else
                {
                    product.Ingred1 = comboBoxIngred1.Text;
                }

                if (String.IsNullOrEmpty(textBoxIngred1Qty.Text))
                {
                    product.Ingred1Qty = 0;
                }
                else
                {
                    product.Ingred1Qty = Convert.ToDecimal(textBoxIngred1Qty.Text);


                }

                product.Ingred1Price = Convert.ToDecimal(labelIngred1Price.Text);



                if (String.IsNullOrEmpty(labelIngred1Units.Text))
                {
                    product.Ingred1Unit = null;
                }
                else
                {
                    product.Ingred1Unit = labelIngred1Units.Text;
                }


                product.Ingred1Total = Convert.ToDecimal(labelIngred1Total.Text);




                product.CheckIngred2 = checkBoxIngred2.Checked;

                if (String.IsNullOrEmpty(comboBoxIngred2.Text))
                {
                    product.Ingred2 = null;
                }
                else
                {
                    product.Ingred2 = comboBoxIngred2.Text;
                }

                if (String.IsNullOrEmpty(textBoxIngred2Qty.Text))
                {
                    product.Ingred2Qty = 0;
                }
                else
                {
                    product.Ingred2Qty = Convert.ToDecimal(textBoxIngred2Qty.Text);
                }

                product.Ingred2Price = Convert.ToDecimal(labelIngred2Price.Text);


                if (String.IsNullOrEmpty(labelIngred2Units.Text))
                {
                    product.Ingred2Unit = null;
                }
                else
                {
                    product.Ingred2Unit = labelIngred2Units.Text;
                }

                product.Ingred2Total = Convert.ToDecimal(labelIngred2Total.Text);


                product.CheckIngred3 = checkBoxIngred3.Checked;

                if (String.IsNullOrEmpty(comboBoxIngred3.Text))
                {
                    product.Ingred3 = null;
                }
                else
                {
                    product.Ingred3 = comboBoxIngred3.Text;
                }

                if (String.IsNullOrEmpty(textBoxIngred3Qty.Text))
                {
                    product.Ingred3Qty = 0;
                }
                else
                {
                    product.Ingred3Qty = Convert.ToDecimal(textBoxIngred3Qty.Text);
                }

                product.Ingred3Price = Convert.ToDecimal(labelIngred3Price.Text);


                if (String.IsNullOrEmpty(labelIngred3Units.Text))
                {
                    product.Ingred3Unit = null;
                }
                else
                {
                    product.Ingred3Unit = labelIngred3Units.Text;
                }

                product.Ingred3Total = Convert.ToDecimal(labelIngred3Total.Text);






                product.CheckIngred4 = checkBoxIngred4.Checked;

                if (String.IsNullOrEmpty(comboBoxIngred4.Text))
                {
                    product.Ingred4 = null;
                }
                else
                {
                    product.Ingred4 = comboBoxIngred2.Text;
                }

                if (String.IsNullOrEmpty(textBoxIngred4Qty.Text))
                {
                    product.Ingred4Qty = 0;
                }
                else
                {
                    product.Ingred4Qty = Convert.ToDecimal(textBoxIngred4Qty.Text);
                }

                product.Ingred4Price = Convert.ToDecimal(labelIngred4Price.Text);


                if (String.IsNullOrEmpty(labelIngred4Units.Text))
                {
                    product.Ingred4Unit = null;
                }
                else
                {
                    product.Ingred4Unit = labelIngred4Units.Text;
                }

                product.Ingred4Total = Convert.ToDecimal(labelIngred4Total.Text);





                product.CheckIngred5 = checkBoxIngred5.Checked;

                if (String.IsNullOrEmpty(comboBoxIngred5.Text))
                {
                    product.Ingred5 = null;
                }
                else
                {
                    product.Ingred5 = comboBoxIngred5.Text;
                }

                if (String.IsNullOrEmpty(textBoxIngred5Qty.Text))
                {
                    product.Ingred5Qty = 0;
                }
                else
                {
                    product.Ingred5Qty = Convert.ToDecimal(textBoxIngred5Qty.Text);
                }

                product.Ingred5Price = Convert.ToDecimal(labelIngred5Price.Text);


                if (String.IsNullOrEmpty(labelIngred5Units.Text))
                {
                    product.Ingred5Unit = null;
                }
                else
                {
                    product.Ingred5Unit = labelIngred5Units.Text;
                }

                product.Ingred5Total = Convert.ToDecimal(labelIngred5Total.Text);



                product.CheckIngred6 = checkBoxIngred6.Checked;

                if (String.IsNullOrEmpty(comboBoxIngred6.Text))
                {
                    product.Ingred6 = null;
                }
                else
                {
                    product.Ingred6 = comboBoxIngred6.Text;
                }

                if (String.IsNullOrEmpty(textBoxIngred6Qty.Text))
                {
                    product.Ingred6Qty = 0;
                }
                else
                {
                    product.Ingred6Qty = Convert.ToDecimal(textBoxIngred6Qty.Text);
                }

                product.Ingred6Price = Convert.ToDecimal(labelIngred6Price.Text);


                if (String.IsNullOrEmpty(labelIngred6Units.Text))
                {
                    product.Ingred6Unit = null;
                }
                else
                {
                    product.Ingred6Unit = labelIngred6Units.Text;
                }

                product.Ingred6Total = Convert.ToDecimal(labelIngred6Total.Text);


                product.CheckIngred7 = checkBoxIngred7.Checked;

                if (String.IsNullOrEmpty(comboBoxIngred7.Text))
                {
                    product.Ingred7 = null;
                }
                else
                {
                    product.Ingred7 = comboBoxIngred7.Text;
                }

                if (String.IsNullOrEmpty(textBoxIngred7Qty.Text))
                {
                    product.Ingred7Qty = 0;
                }
                else
                {
                    product.Ingred7Qty = Convert.ToDecimal(textBoxIngred7Qty.Text);
                }

                product.Ingred7Price = Convert.ToDecimal(labelIngred7Price.Text);


                if (String.IsNullOrEmpty(labelIngred7Units.Text))
                {
                    product.Ingred7Unit = null;
                }
                else
                {
                    product.Ingred7Unit = labelIngred7Units.Text;
                }

                product.Ingred7Total = Convert.ToDecimal(labelIngred7Total.Text);


                product.CheckIngred8 = checkBoxIngred8.Checked;

                if (String.IsNullOrEmpty(comboBoxIngred8.Text))
                {
                    product.Ingred8 = null;
                }
                else
                {
                    product.Ingred8 = comboBoxIngred8.Text;
                }

                if (String.IsNullOrEmpty(textBoxIngred8Qty.Text))
                {
                    product.Ingred8Qty = 0;
                }
                else
                {
                    product.Ingred8Qty = Convert.ToDecimal(textBoxIngred8Qty.Text);
                }

                product.Ingred8Price = Convert.ToDecimal(labelIngred8Price.Text);


                if (String.IsNullOrEmpty(labelIngred8Units.Text))
                {
                    product.Ingred8Unit = null;
                }
                else
                {
                    product.Ingred8Unit = labelIngred8Units.Text;
                }

                product.Ingred8Total = Convert.ToDecimal(labelIngred8Total.Text);


                product.CheckIngred9 = checkBoxIngred9.Checked;

                if (String.IsNullOrEmpty(comboBoxIngred9.Text))
                {
                    product.Ingred9 = null;
                }
                else
                {
                    product.Ingred9 = comboBoxIngred9.Text;
                }

                if (String.IsNullOrEmpty(textBoxIngred9Qty.Text))
                {
                    product.Ingred9Qty = 0;
                }
                else
                {
                    product.Ingred9Qty = Convert.ToDecimal(textBoxIngred9Qty.Text);
                }

                product.Ingred9Price = Convert.ToDecimal(labelIngred9Price.Text);


                if (String.IsNullOrEmpty(labelIngred9Units.Text))
                {
                    product.Ingred9Unit = null;
                }
                else
                {
                    product.Ingred9Unit = labelIngred9Units.Text;
                }

                product.Ingred9Total = Convert.ToDecimal(labelIngred9Total.Text);



                product.CheckIngred10 = checkBoxIngred10.Checked;

                if (String.IsNullOrEmpty(comboBoxIngred10.Text))
                {
                    product.Ingred10 = null;
                }
                else
                {
                    product.Ingred10 = comboBoxIngred10.Text;
                }

                if (String.IsNullOrEmpty(textBoxIngred10Qty.Text))
                {
                    product.Ingred10Qty = 0;
                }
                else
                {
                    product.Ingred10Qty = Convert.ToDecimal(textBoxIngred10Qty.Text);
                }

                product.Ingred10Price = Convert.ToDecimal(labelIngred10Price.Text);


                if (String.IsNullOrEmpty(labelIngred10Units.Text))
                {
                    product.Ingred10Unit = null;
                }
                else
                {
                    product.Ingred10Unit = labelIngred10Units.Text;
                }

                product.Ingred10Total = Convert.ToDecimal(labelIngred10Total.Text);



                product.IngredTotalCost = Convert.ToDecimal(labelIngredSubTotal.Text);

                //Packaging Section Starts Here


                product.CheckPack1 = checkBoxPack1.Checked;

                if (String.IsNullOrEmpty(comboBoxPack1.Text))
                {
                    product.TypePack1 = null;
                }
                else
                {
                    product.TypePack1 = comboBoxPack1.Text;
                }

                if (String.IsNullOrEmpty(textBoxQtyPack1.Text))
                {
                    product.QtyPack1 = 0;
                }
                else
                {
                    product.QtyPack1 = Convert.ToDecimal(textBoxQtyPack1.Text);
                }

                if (String.IsNullOrEmpty(labelPackPrice1.Text))
                {
                    product.PricePack1 = 0;
                }
                else
                {
                    product.PricePack1 = Convert.ToDecimal(labelPackPrice1.Text);
                }

                if (String.IsNullOrEmpty(labelPackTotal1.Text))
                {
                    product.TotalPack1 = 0;
                }
                else
                {
                    product.TotalPack1 = Convert.ToDecimal(labelPackTotal1.Text);
                }

                if (String.IsNullOrEmpty(labelPackValue1.Text))
                {
                    product.ValuePack1 = 0;
                }
                else
                {
                    product.ValuePack1 = Convert.ToDecimal(labelPackValue1.Text);
                }






                product.CheckPack2 = checkBoxPack2.Checked;

                if (String.IsNullOrEmpty(comboBoxPack2.Text))
                {
                    product.TypePack2 = null;
                }
                else
                {
                    product.TypePack2 = comboBoxPack2.Text;
                }

                if (String.IsNullOrEmpty(textBoxQtyPack2.Text))
                {
                    product.QtyPack2 = 0;
                }
                else
                {
                    product.QtyPack2 = Convert.ToDecimal(textBoxQtyPack2.Text);
                }

                if (String.IsNullOrEmpty(labelPackPrice2.Text))
                {
                    product.PricePack2 = 0;
                }
                else
                {
                    product.PricePack2 = Convert.ToDecimal(labelPackPrice2.Text);
                }

                if (String.IsNullOrEmpty(labelPackTotal2.Text))
                {
                    product.TotalPack2 = 0;
                }
                else
                {
                    product.TotalPack2 = Convert.ToDecimal(labelPackTotal2.Text);
                }

                if (String.IsNullOrEmpty(labelPackValue2.Text))
                {
                    product.ValuePack2 = 0;
                }
                else
                {
                    product.ValuePack2 = Convert.ToDecimal(labelPackValue2.Text);
                }




                product.CheckPack3 = checkBoxPack3.Checked;

                if (String.IsNullOrEmpty(comboBoxPack3.Text))
                {
                    product.TypePack3 = null;
                }
                else
                {
                    product.TypePack3 = comboBoxPack3.Text;
                }

                if (String.IsNullOrEmpty(textBoxQtyPack3.Text))
                {
                    product.QtyPack3 = 0;
                }
                else
                {
                    product.QtyPack3 = Convert.ToDecimal(textBoxQtyPack3.Text);
                }

                if (String.IsNullOrEmpty(labelPackPrice3.Text))
                {
                    product.PricePack3 = 0;
                }
                else
                {
                    product.PricePack3 = Convert.ToDecimal(labelPackPrice3.Text);
                }

                if (String.IsNullOrEmpty(labelPackTotal3.Text))
                {
                    product.TotalPack3 = 0;
                }
                else
                {
                    product.TotalPack3 = Convert.ToDecimal(labelPackTotal3.Text);
                }

                if (String.IsNullOrEmpty(labelPackValue3.Text))
                {
                    product.ValuePack3 = 0;
                }
                else
                {
                    product.ValuePack3 = Convert.ToDecimal(labelPackValue3.Text);
                }






                product.CheckPack4 = checkBoxPack4.Checked;

                if (String.IsNullOrEmpty(comboBoxPack4.Text))
                {
                    product.TypePack4 = null;
                }
                else
                {
                    product.TypePack4 = comboBoxPack4.Text;
                }

                if (String.IsNullOrEmpty(textBoxQtyPack4.Text))
                {
                    product.QtyPack4 = 0;
                }
                else
                {
                    product.QtyPack4 = Convert.ToDecimal(textBoxQtyPack4.Text);
                }

                if (String.IsNullOrEmpty(labelPackPrice4.Text))
                {
                    product.PricePack4 = 0;
                }
                else
                {
                    product.PricePack4 = Convert.ToDecimal(labelPackPrice4.Text);
                }

                if (String.IsNullOrEmpty(labelPackTotal4.Text))
                {
                    product.TotalPack4 = 0;
                }
                else
                {
                    product.TotalPack4 = Convert.ToDecimal(labelPackTotal4.Text);
                }

                if (String.IsNullOrEmpty(labelPackValue4.Text))
                {
                    product.ValuePack4 = 0;
                }
                else
                {
                    product.ValuePack4 = Convert.ToDecimal(labelPackValue4.Text);
                }





                product.CheckPack5 = checkBoxPack5.Checked;

                if (String.IsNullOrEmpty(comboBoxPack5.Text))
                {
                    product.TypePack5 = null;
                }
                else
                {
                    product.TypePack5 = comboBoxPack5.Text;
                }

                if (String.IsNullOrEmpty(textBoxQtyPack5.Text))
                {
                    product.QtyPack5 = 0;
                }
                else
                {
                    product.QtyPack5 = Convert.ToDecimal(textBoxQtyPack5.Text);
                }

                if (String.IsNullOrEmpty(labelPackPrice5.Text))
                {
                    product.PricePack5 = 0;
                }
                else
                {
                    product.PricePack5 = Convert.ToDecimal(labelPackPrice5.Text);
                }

                if (String.IsNullOrEmpty(labelPackTotal5.Text))
                {
                    product.TotalPack5 = 0;
                }
                else
                {
                    product.TotalPack5 = Convert.ToDecimal(labelPackTotal5.Text);
                }

                if (String.IsNullOrEmpty(labelPackValue5.Text))
                {
                    product.ValuePack5 = 0;
                }
                else
                {
                    product.ValuePack5 = Convert.ToDecimal(labelPackValue5.Text);
                }



                product.PackCostTotal = Convert.ToDecimal(labelPackSubTotal.Text);


                product.PackValueTotal = Convert.ToDecimal(labelPackValueTotal.Text);


                product.CheckStaff1 = checkBoxStaff1.Checked;

                if (String.IsNullOrEmpty(comboBoxStaff1.Text))
                {
                    product.Staff1 = null;
                }
                else
                {
                    product.Staff1 = comboBoxStaff1.Text;
                }

                if (String.IsNullOrEmpty(textBoxHoursStaff1.Text))
                {
                    product.HoursStaff1 = 0;
                }
                else
                {
                    product.HoursStaff1 = Convert.ToDecimal(textBoxHoursStaff1.Text);
                }

                if (String.IsNullOrEmpty(labelRateStaff1.Text))
                {
                    product.RateStaff1 = 0;
                }
                else
                {
                    product.RateStaff1 = Convert.ToDecimal(labelRateStaff1.Text);
                }


                if (String.IsNullOrEmpty(labelTotalStaff1.Text))
                {
                    product.TotalStaff1 = 0;
                }
                else
                {
                    product.TotalStaff1 = Convert.ToDecimal(labelTotalStaff1.Text);
                }


                product.CheckStaff2 = checkBoxStaff2.Checked;

                if (String.IsNullOrEmpty(comboBoxStaff2.Text))
                {
                    product.Staff2 = null;
                }
                else
                {
                    product.Staff2 = comboBoxStaff2.Text;
                }

                if (String.IsNullOrEmpty(textBoxHoursStaff2.Text))
                {
                    product.HoursStaff2 = 0;
                }
                else
                {
                    product.HoursStaff2 = Convert.ToDecimal(textBoxHoursStaff2.Text);
                }

                if (String.IsNullOrEmpty(labelRateStaff2.Text))
                {
                    product.RateStaff2 = 0;
                }
                else
                {
                    product.RateStaff2 = Convert.ToDecimal(labelRateStaff2.Text);
                }


                if (String.IsNullOrEmpty(labelTotalStaff2.Text))
                {
                    product.TotalStaff2 = 0;
                }
                else
                {
                    product.TotalStaff2 = Convert.ToDecimal(labelTotalStaff2.Text);
                }




                product.CheckStaff3 = checkBoxStaff3.Checked;

                if (String.IsNullOrEmpty(comboBoxStaff3.Text))
                {
                    product.Staff3 = null;
                }
                else
                {
                    product.Staff3 = comboBoxStaff3.Text;
                }

                if (String.IsNullOrEmpty(textBoxHoursStaff3.Text))
                {
                    product.HoursStaff3 = 0;
                }
                else
                {
                    product.HoursStaff3 = Convert.ToDecimal(textBoxHoursStaff3.Text);
                }

                if (String.IsNullOrEmpty(labelRateStaff2.Text))
                {
                    product.RateStaff3 = 0;
                }
                else
                {
                    product.RateStaff3 = Convert.ToDecimal(labelRateStaff3.Text);
                }


                if (String.IsNullOrEmpty(labelTotalStaff3.Text))
                {
                    product.TotalStaff3 = 0;
                }
                else
                {
                    product.TotalStaff3 = Convert.ToDecimal(labelTotalStaff3.Text);
                }




                product.CheckStaff4 = checkBoxStaff4.Checked;

                if (String.IsNullOrEmpty(comboBoxStaff4.Text))
                {
                    product.Staff4 = null;
                }
                else
                {
                    product.Staff4 = comboBoxStaff4.Text;
                }

                if (String.IsNullOrEmpty(textBoxHoursStaff4.Text))
                {
                    product.HoursStaff4 = 0;
                }
                else
                {
                    product.HoursStaff4 = Convert.ToDecimal(textBoxHoursStaff4.Text);
                }

                if (String.IsNullOrEmpty(labelRateStaff4.Text))
                {
                    product.RateStaff4 = 0;
                }
                else
                {
                    product.RateStaff4 = Convert.ToDecimal(labelRateStaff4.Text);
                }


                if (String.IsNullOrEmpty(labelTotalStaff4.Text))
                {
                    product.TotalStaff4 = 0;
                }
                else
                {
                    product.TotalStaff4 = Convert.ToDecimal(labelTotalStaff4.Text);
                }



                product.CheckStaff5 = checkBoxStaff5.Checked;

                if (String.IsNullOrEmpty(comboBoxStaff5.Text))
                {
                    product.Staff5 = null;
                }
                else
                {
                    product.Staff5 = comboBoxStaff5.Text;
                }

                if (String.IsNullOrEmpty(textBoxHoursStaff5.Text))
                {
                    product.HoursStaff5 = 0;
                }
                else
                {
                    product.HoursStaff5 = Convert.ToDecimal(textBoxHoursStaff5.Text);
                }

                if (String.IsNullOrEmpty(labelRateStaff5.Text))
                {
                    product.RateStaff5 = 0;
                }
                else
                {
                    product.RateStaff5 = Convert.ToDecimal(labelRateStaff5.Text);
                }


                if (String.IsNullOrEmpty(labelTotalStaff5.Text))
                {
                    product.TotalStaff5 = 0;
                }
                else
                {
                    product.TotalStaff5 = Convert.ToDecimal(labelTotalStaff5.Text);
                }



                product.StaffCostTotal = Convert.ToDecimal(labelPackSubTotal.Text);


                if (String.IsNullOrEmpty(textBoxKitchenLocation.Text))
                {
                    product.KitchenLocation = "";
                }
                else
                {
                    product.KitchenLocation = textBoxKitchenLocation.Text;
                }

                if (String.IsNullOrEmpty(textBoxKitchenHours.Text))
                {
                    product.KitchenHours = 0;
                }
                else
                {
                    product.KitchenHours = Convert.ToDecimal(textBoxKitchenHours.Text);
                }


                if (String.IsNullOrEmpty(textBoxKitchenRate.Text))
                {
                    product.KitchenRate = 0;
                }
                else
                {
                    product.KitchenRate = Convert.ToDecimal(textBoxKitchenRate.Text);
                }

                if (String.IsNullOrEmpty(labelKitchenTotal.Text))
                {
                    product.KitchenTotal = 0;
                }
                else
                {
                    product.KitchenTotal = Convert.ToDecimal(labelKitchenTotal.Text);
                }



                try
                {

                    this.productLotTableAdapter.Add

                 (

                        id, product.Lot, product.Build, product.ProductName, product.Notes,
                        product.CheckIngred1, product.Ingred1, product.Ingred1Qty, product.Ingred1Unit, product.Ingred1Price, product.Ingred1Total,
                        product.CheckIngred2, product.Ingred2, product.Ingred2Qty, product.Ingred2Unit, product.Ingred2Price, product.Ingred2Total,
                        product.CheckIngred3, product.Ingred3, product.Ingred3Qty, product.Ingred3Unit, product.Ingred3Price, product.Ingred3Total,
                        product.CheckIngred4, product.Ingred4, product.Ingred4Qty, product.Ingred4Unit, product.Ingred4Price, product.Ingred4Total,
                        product.CheckIngred5, product.Ingred5, product.Ingred5Qty, product.Ingred5Unit, product.Ingred5Price, product.Ingred5Total,
                        product.CheckIngred10, product.CheckIngred6, product.CheckIngred7, product.CheckIngred8, product.CheckIngred9, product.Ingred10,
                        product.Ingred10Price, product.Ingred10Qty, product.Ingred10Total, product.Ingred10Unit,
                        product.Ingred6, product.Ingred6Price, product.Ingred6Qty, product.Ingred6Total, product.Ingred6Unit,
                        product.Ingred7, product.Ingred7Price, product.Ingred7Qty, product.Ingred7Total, product.Ingred7Unit,
                        product.Ingred8, product.Ingred8Price, product.Ingred8Qty, product.Ingred8Total, product.Ingred8Unit,
                        product.Ingred9, product.Ingred9Price, product.Ingred9Qty, product.Ingred9Total, product.Ingred9Unit,
                        product.CheckPack1, product.CheckPack2, product.CheckPack3, product.CheckPack4, product.CheckPack5,
                        product.CheckStaff1, product.CheckStaff2, product.CheckStaff3, product.CheckStaff4, product.CheckStaff5,
                        product.HoursStaff1, product.HoursStaff2, product.HoursStaff3, product.HoursStaff4, product.HoursStaff5,
                        product.IngredTotalCost, product.KitchenHours, product.KitchenLocation, product.KitchenRate, product.KitchenTotal,
                        product.PackCostTotal, product.PricePack1, product.PricePack2, product.PricePack3, product.PricePack4, product.PricePack5,
                        product.QtyPack1, product.QtyPack2, product.QtyPack3, product.QtyPack4, product.QtyPack5,
                        product.RateStaff1, product.RateStaff2, product.RateStaff3, product.RateStaff4, product.RateStaff5,
                        product.Staff1, product.Staff2, product.Staff3, product.Staff4, product.Staff5,
                        product.StaffCostTotal, product.TotalPack1, product.TotalPack2, product.TotalPack3, product.TotalPack4, product.TotalPack5,
                        product.TotalStaff1, product.TotalStaff2, product.TotalStaff3, product.TotalStaff4, product.TotalStaff5,
                        product.TypePack1, product.TypePack2, product.TypePack3, product.TypePack4, product.TypePack5,
                        product.ValuePack1, product.ValuePack2, product.ValuePack3, product.ValuePack4, product.ValuePack5, product.PackValueTotal


                 );



                    MessageBox.Show("New Record Added");





                    this.productLotTableAdapter.FillByLot(this.kitchenDataSet.ProductLot, Convert.ToInt16(textBoxLotNumber.Text));

                    //Clear All products after Add
                    labelBuildNum.Text = "0";

                    ClearAllProduct();





                    TotalIngred();
                    TotalPackage();


                    //recalculate the lottextbox


                    CalculateLotTotal();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(" " + ex);
                }

            }



        }




        private void textBoxLotNumber_TextChanged(object sender, EventArgs e)
        {
            ClearAllProduct();
            buttonAddProduct.Visible = false;

            labelLotIngredCost.Text = "0.00";
            labelLotPackCostTotal.Text = "0.00";
            labelLotStaffCostTotal.Text = "0.00";



            labelLotCostSubTotal.Text = "0.00";
            labelLotGrandTotal.Text = "0.00";
            //CalculateLotTotal();
            try
            {
                this.productLotTableAdapter.FillByLot(this.kitchenDataSet.ProductLot, Convert.ToInt16(textBoxLotNumber.Text));


                CalculateLotTotal();

                TotalStaff();

            }
            catch
            {

            }





        }




        private void productLotDataGridView_RowClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            //ClearAllProduct();
            //gets the slected row and send it to the load boxes method
            buttonAddProduct.Visible = false;
            int selectedRow = 0;
            selectedRow = this.productLotDataGridView.CurrentCell.RowIndex;
            LoadInfo(selectedRow + 1);
        }

        private void ClearProducts(object sender, EventArgs e)
        {
            ClearAllProduct();
        }



        private void label87_Click(object sender, EventArgs e)
        {

        }

        private void label88_Click(object sender, EventArgs e)
        {

        }

        private void label89_Click(object sender, EventArgs e)
        {

        }

        private void label90_Click(object sender, EventArgs e)
        {

        }

        private void textBoxLotNumber_KeyUp(object sender, KeyEventArgs e)
        {
            CalculateLotTotal();
            labelBuildNum.Text = "0";
        }

        private void textBoxHoursStaff1_KeyUp(object sender, KeyEventArgs e)
        {
            CalculateLotTotal();
        }

        private void textBoxHoursStaff2_KeyDown(object sender, KeyEventArgs e)
        {
            CalculateLotTotal();
        }

        private void textBoxHoursStaff3_KeyUp(object sender, KeyEventArgs e)
        {
            CalculateLotTotal();
        }

        private void textBoxHoursStaff4_KeyUp(object sender, KeyEventArgs e)
        {
            CalculateLotTotal();
        }

        private void textBoxHoursStaff5_KeyUp(object sender, KeyEventArgs e)
        {
            CalculateLotTotal();
        }

        private void buttonNewProduct_Click(object sender, EventArgs e)
        {
            ClearAllProduct();

            int buildset = 0;
            int lot = 0;

            if (!int.TryParse(textBoxLotNumber.Text, out lot))
            {
                MessageBox.Show("Enter a valid Lot#");
            }
            else
            {
                lot = Convert.ToInt16(textBoxLotNumber.Text);
                buildset = Convert.ToInt16(this.productLotTableAdapter.GetBuildCount(lot));

                labelBuildNum.Text = Convert.ToString(buildset + 1);
                buttonAddProduct.Visible = true;

            }





        }

        private void textBoxProductName_TextChanged(object sender, EventArgs e)
        {
            int buildset = 0;
            int lot = 0;

            if (!int.TryParse(textBoxLotNumber.Text, out lot))
            {
                MessageBox.Show("Enter a valid Lot#");
                textBoxProductName.Text = "";
            }
            else
            {
                lot = Convert.ToInt16(textBoxLotNumber.Text);
                buildset = Convert.ToInt16(this.productLotTableAdapter.GetBuildCount(lot));

                labelBuildNum.Text = Convert.ToString(buildset + 1);
                //buttonAddProduct.Visible = true;

            }
        }

        private void textBoxKitchenHours_TextChanged(object sender, EventArgs e)
        {



            if (textBoxKitchenHours.Text == "")
            {
                textBoxKitchenRate.Text = "0.00";
            }
            else
            {

            }


            if (textBoxKitchenRate.Text == "")
            {
                textBoxKitchenRate.Text = "0.00";
            }
            else
            {

            }

            decimal tempTotal;


            tempTotal = Convert.ToDecimal(textBoxKitchenHours.Text) * Convert.ToDecimal(textBoxKitchenRate.Text);


            labelKitchenTotal.Text = Convert.ToString(tempTotal);








        }

        private void textBoxKitchenRate_TextChanged(object sender, EventArgs e)
        {




            if (textBoxKitchenHours.Text == "")
            {
                textBoxKitchenHours.Text = "0.00";
            }
            else
            {

            }

            decimal tempTotal;


            tempTotal = Convert.ToDecimal(textBoxKitchenHours.Text) * Convert.ToDecimal(textBoxKitchenRate.Text);


            labelKitchenTotal.Text = Convert.ToString(tempTotal);
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
