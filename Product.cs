using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kitchen_Manager
{
    class Product
    {
            private int  lot;
            private int build;
            private string productName;
            private string notes;

            private bool  checkIngred1;
            private string ingred1;
            private decimal ingred1Qty;
            private string ingred1Unit;
            private decimal ingred1Price;
            private decimal ingred1Total;

            private bool  checkIngred2;
            private string ingred2;
            private decimal ingred2Qty;
            private string ingred2Unit;
            private decimal ingred2Price;
            private decimal ingred2Total;

            private bool  checkIngred3;
            private string ingred3;
            private decimal ingred3Qty;
            private string ingred3Unit;
            private decimal ingred3Price;
            private decimal ingred3Total;

            private bool  checkIngred4;
            private string ingred4;
            private decimal ingred4Qty;
            private string ingred4Unit;
            private decimal ingred4Price;
            private decimal ingred4Total;

            private bool  checkIngred5;
            private string ingred5;
            private decimal ingred5Qty;
            private string ingred5Unit;
            private decimal ingred5Price;
            private decimal ingred5Total;

            private bool  checkIngred6;
            private string ingred6;
            private decimal ingred6Qty;
            private string ingred6Unit;
            private decimal ingred6Price;
            private decimal ingred6Total;

            private bool  checkIngred7;
            private string ingred7;
            private decimal ingred7Qty;
            private string ingred7Unit;
            private decimal ingred7Price;
            private decimal ingred7Total;

            private bool  checkIngred8;
            private string ingred8;
            private decimal ingred8Qty;
            private string ingred8Unit;
            private decimal ingred8Price;
            private decimal ingred8Total;

            private bool checkIngred9;
            private string ingred9;
            private decimal ingred9Qty;
            private string ingred9Unit;
            private decimal ingred9Price;
            private decimal ingred9Total;

           private bool checkIngred10;
            private string ingred10;
            private decimal ingred10Qty;
            private string ingred10Unit;
            private decimal ingred10Price;
            private decimal ingred10Total;


            private decimal ingredTotalCost;

            private bool checkPack1;
            private string typePack1;
            private decimal qtyPack1;
            private decimal pricePack1;
            private decimal totalPack1;
            private decimal valuePack1;

            private bool checkPack2;
            private string typePack2;
            private decimal qtyPack2;
            private decimal pricePack2;
            private decimal totalPack2;
            private decimal valuePack2;

            private bool checkPack3;
            private string typePack3;
            private decimal qtyPack3;
            private decimal pricePack3;
            private decimal totalPack3;
            private decimal valuePack3;

            private bool checkPack4;
            private string typePack4;
            private decimal qtyPack4;
            private decimal pricePack4;
            private decimal totalPack4;
            private decimal valuePack4;

            private bool checkPack5;
            private string typePack5;
            private decimal qtyPack5;
            private decimal pricePack5;
            private decimal totalPack5;
            private decimal valuePack5;

            private decimal packCostTotal;
            private decimal packValueTotal;

            private bool checkStaff1;
            private string staff1;
            private decimal hoursStaff1;
            private decimal rateStaff1;
            private decimal totalStaff1;

            private bool checkStaff2;
            private string staff2;
            private decimal hoursStaff2;
            private decimal rateStaff2;
            private decimal totalStaff2;

            private bool checkStaff3;
            private string staff3;
            private decimal hoursStaff3;
            private decimal rateStaff3;
            private decimal totalStaff3;

            private bool checkStaff4;
            private string staff4;
            private decimal hoursStaff4;
            private decimal rateStaff4;
            private decimal totalStaff4;

            private bool checkStaff5;
            private string staff5;
            private decimal hoursStaff5;
            private decimal rateStaff5;
            private decimal totalStaff5;

            private decimal staffCostTotal; 

            private string kitchenLocation;
            private decimal kitchenHours;
            private decimal kitchenRate;

            private decimal kitchenTotal;
           
            public Product()
            {
                lot = 0;
                build = 0;
                productName = "";
                notes = "";

                checkIngred1 = false;
                ingred1 = "";
                ingred1Qty = 0;
                ingred1Unit = "";
                ingred1Price = 0;
                ingred1Total = 0;

                checkIngred2 = false;
                ingred2 = "";
                ingred2Qty = 0;
                ingred2Unit = "";
                ingred2Total = 0;

                checkIngred3 = false;
                ingred3 = "";
                ingred3Qty = 0;
                ingred3Unit = "";
                ingred3Price = 0;
                ingred3Total = 0;

                checkIngred4 = false;
                ingred4 = "";
                ingred4Qty = 0;
                ingred4Unit = "";
                ingred4Price = 0;
                ingred4Total = 0;

                checkIngred5 = false;
                ingred5 = "";
                ingred5Qty = 0;
                ingred5Unit = "";
                ingred5Price = 0;
                ingred5Total = 0;

                checkIngred6 = false;
                ingred6 = "";
                ingred6Qty = 0;
                ingred6Unit = "";
                ingred6Price = 0;
                ingred6Total = 0;

                checkIngred7 = false;
                ingred7 = "";
                ingred7Qty = 0;
                ingred7Unit = "";
                ingred7Total = 0;

                checkIngred8 = false;
                ingred8 = "";
                ingred8Qty = 0;
                ingred8Unit = "";
                ingred8Price = 0;
                ingred8Total = 0;

                checkIngred9 = false;
                ingred9 = "";
                ingred9Qty = 0;
                ingred9Unit = "";
                ingred9Price = 0;
                ingred9Total = 0;

                checkIngred10 = false;
                ingred10 = "";
                ingred10Qty = 0;
                ingred10Unit = "";
                ingred10Price = 0;
                ingred10Total = 0;

                ingredTotalCost=0;

                checkPack1 = false;
                typePack1 ="";
                qtyPack1 = 0;
                pricePack1 = 0;
                totalPack1 = 0;
                valuePack1 = 0;

                checkPack2 = false;
                typePack2 = "";
                qtyPack2 = 0;
                pricePack2 = 0;
                totalPack2 = 0;
                valuePack2 = 0;

                checkPack3 = false;
                typePack3 = "";
                qtyPack3 = 0;
                pricePack3 = 0;
                totalPack3 = 0;
                valuePack3 = 0;

                checkPack4 = false;
                typePack4 = "";
                qtyPack4 = 0;
                pricePack4 = 0;
                totalPack4 = 0;
                valuePack4 = 0;

                checkPack5 = false;
                typePack5 = "";
                qtyPack5 = 0;
                pricePack5 = 0;
                totalPack5 = 0;
                valuePack5 = 0;

                packCostTotal =0;
                packValueTotal = 0;

                checkStaff1 = false;
                staff1="";
                hoursStaff1=0;
                rateStaff1=0;
                totalStaff1=0;

                checkStaff2 = false;
                staff2 = "";
                hoursStaff2 = 0;
                rateStaff2 = 0;
                totalStaff2 = 0;

                checkStaff3 = false;
                staff3 = "";
                hoursStaff3 = 0;
                rateStaff3 = 0;
                totalStaff3 = 0;

                checkStaff4 = false;
                staff4 = "";
                hoursStaff4 = 0;
                rateStaff4 = 0;
                totalStaff4 = 0;

                checkStaff5 = false;
                staff5 = "";
                hoursStaff5 = 0;
                rateStaff5 = 0;
                totalStaff5 = 0;

                kitchenLocation ="";
                kitchenHours=0;
                kitchenRate=0;
                kitchenTotal=0;

            }

            public int Lot
            {
                get { return lot; }
                set { lot = value; }
            }

            public int Build
            {
                get { return build; }
                set { build = value; }
            }

            public string ProductName
            {
                get { return productName; }
                set { productName = value; }
            }
            public string Notes
            {
                get { return notes; }
                set { notes = value; }
            }

            public bool CheckIngred1
            {
                get { return checkIngred1; }
                set { checkIngred1 = value; }
            }

            public string Ingred1
            {
                get { return ingred1; }
                set { ingred1 = value; }
            }

            public decimal Ingred1Qty
            { 
                get { return ingred1Qty; }
                set { ingred1Qty = value; }
            }

            public string Ingred1Unit
            {
                get { return ingred1Unit; }
                set { ingred1Unit = value; }
            }

            public decimal Ingred1Price
            {
                get { return ingred1Price; }
                set { ingred1Price = value; }
            }

            public decimal Ingred1Total
            { 
                get { return ingred1Total; }
                set { ingred1Total = value; }
            }

            public bool CheckIngred2
            {
                get { return checkIngred2; }
                set { checkIngred2 = value; }
            }

            public string Ingred2
            {
                get { return ingred2; }
                set { ingred2 = value; }
            }

            public decimal Ingred2Qty
            {
                get { return ingred2Qty; }
                set { ingred2Qty = value; }
            }

            public string Ingred2Unit
            {
                get { return ingred2Unit; }
                set { ingred2Unit = value; }
            }

            public decimal Ingred2Price
            {
                get { return ingred2Price; }
                set { ingred2Price = value; }
            }

            public decimal Ingred2Total
            {
                get { return ingred2Total; }
                set { ingred2Total = value; }
            }

            public bool CheckIngred3
            {
                get { return checkIngred3; }
                set { checkIngred3 = value; }
            }

            public string Ingred3
            {
                get { return ingred3; }
                set { ingred3 = value; }
            }

            public decimal Ingred3Qty
            {
                get { return ingred3Qty; }
                set { ingred3Qty = value; }
            }

            public string Ingred3Unit
            {
                get { return ingred3Unit; }
                set { ingred3Unit = value; }
            }

            public decimal Ingred3Price
            {
                get { return ingred3Price; }
                set { ingred3Price = value; }
            }

            public decimal Ingred3Total
            {
                get { return ingred3Total; }
                set { ingred3Total = value; }
            }

            public bool CheckIngred4
            {
                get { return checkIngred4; }
                set { checkIngred4 = value; }
            }

            public string Ingred4
            {
                get { return ingred4; }
                set { ingred4 = value; }
            }

            public decimal Ingred4Qty
            {
                get { return ingred4Qty; }
                set { ingred4Qty = value; }
            }

            public string Ingred4Unit
            {
                get { return ingred4Unit; }
                set { ingred4Unit = value; }
            }

            public decimal Ingred4Price
            {
                get { return ingred4Price; }
                set { ingred4Price = value; }
            }

            public decimal Ingred4Total
            {
                get { return ingred4Total; }
                set { ingred4Total = value; }
            }

            public bool CheckIngred5
            {
                get { return checkIngred5; }
                set { checkIngred5 = value; }
            }

            public string Ingred5
            {
                get { return ingred5; }
                set { ingred5 = value; }
            }

            public decimal Ingred5Qty
            {
                get { return ingred5Qty; }
                set { ingred5Qty = value; }
            }

            public string Ingred5Unit
            {
                get { return ingred5Unit; }
                set { ingred5Unit = value; }
            }

            public decimal Ingred5Price
            {
                get { return ingred5Price; }
                set { ingred5Price = value; }
            }

            public decimal Ingred5Total
            {
                get { return ingred5Total; }
                set { ingred5Total = value; }
            }

            public bool CheckIngred6
            {
                get { return checkIngred6; }
                set { checkIngred6 = value; }
            }

            public string Ingred6
            {
                get { return ingred6; }
                set { ingred6 = value; }
            }

            public decimal Ingred6Qty
            {
                get { return ingred6Qty; }
                set { ingred6Qty = value; }
            }

            public string Ingred6Unit
            {
                get { return ingred6Unit; }
                set { ingred6Unit = value; }
            }

            public decimal Ingred6Price
            {
                get { return ingred6Price; }
                set { ingred6Price = value; }
            }

            public decimal Ingred6Total
            {
                get { return ingred6Total; }
                set { ingred6Total = value; }
            }

            public bool CheckIngred7
            {
                get { return checkIngred7; }
                set { checkIngred7 = value; }
            }

            public string Ingred7
            {
                get { return ingred7; }
                set { ingred7 = value; }
            }

            public decimal Ingred7Qty
            {
                get { return ingred7Qty; }
                set { ingred7Qty = value; }
            }

            public string Ingred7Unit
            {
                get { return ingred7Unit; }
                set { ingred7Unit = value; }
            }

            public decimal Ingred7Price
            {
                get { return ingred7Price; }
                set { ingred7Price = value; }
            }

            public decimal Ingred7Total
            {
                get { return ingred7Total; }
                set { ingred7Total = value; }
            }

            public bool CheckIngred8
            {
                get { return checkIngred8; }
                set { checkIngred8 = value; }
            }

            public string Ingred8
            {
                get { return ingred8; }
                set { ingred8 = value; }
            }

            public decimal Ingred8Qty
            {
                get { return ingred8Qty; }
                set { ingred8Qty = value; }
            }

            public string Ingred8Unit
            {
                get { return ingred8Unit; }
                set { ingred8Unit = value; }
            }

            public decimal Ingred8Price
            {
                get { return ingred8Price; }
                set { ingred8Price = value; }
            }

            public decimal Ingred8Total
            {
                get { return ingred8Total; }
                set { ingred8Total = value; }
            }

            public bool CheckIngred9
            {
                get { return checkIngred9; }
                set { checkIngred9 = value; }
            }

            public string Ingred9
            {
                get { return ingred9; }
                set { ingred9 = value; }
            }

            public decimal Ingred9Qty
            {
                get { return ingred9Qty; }
                set { ingred9Qty = value; }
            }

            public string Ingred9Unit
            {
                get { return ingred9Unit; }
                set { ingred9Unit = value; }
            }

            public decimal Ingred9Price
            {
                get { return ingred9Price; }
                set { ingred9Price = value; }
            }

            public decimal Ingred9Total
            {
                get { return ingred9Total; }
                set { ingred9Total = value; }
            }

            public bool CheckIngred10
            {
                get { return checkIngred10; }
                set { checkIngred10 = value; }
            }

            public string Ingred10
            {
                get { return ingred10; }
                set { ingred10 = value; }
            }

            public decimal Ingred10Qty
            {
                get { return ingred10Qty; }
                set { ingred10Qty = value; }
            }

            public string Ingred10Unit
            {
                get { return ingred10Unit; }
                set { ingred10Unit = value; }
            }

            public decimal Ingred10Price
            {
                get { return ingred10Price; }
                set { ingred10Price = value; }
            }

            public decimal Ingred10Total
            {
                get { return ingred10Total; }
                set { ingred7Total = value; }
            }

            public decimal IngredTotalCost
            {
                get { return  ingredTotalCost; }
                set {  ingredTotalCost = value; }
            }

            public bool CheckPack1
            {
                get { return checkPack1; }
                set { checkPack1 = value; }
            }
            
            public string TypePack1
            {
                get { return typePack1; }
                set { typePack1 = value; }
            }

            public decimal QtyPack1
            {
                get { return  qtyPack1; }
                set {  qtyPack1 = value; }
            }

            public decimal PricePack1
            {
                get { return  pricePack1; }
                set {  pricePack1 = value; }
            }

            public decimal TotalPack1
            {
                get { return  totalPack1; }
                set {  totalPack1 = value; }
            }
                
            public decimal ValuePack1
            {
                get { return  valuePack1; }
                set {  valuePack1 = value; }
            }

            public bool CheckPack2
            {
                get { return checkPack2; }
                set { checkPack2 = value; }
            }

            public string TypePack2
            {
                get { return typePack2; }
                set { typePack2 = value; }
            }

            public decimal QtyPack2
            {
                get { return qtyPack2; }
                set { qtyPack2 = value; }
            }

            public decimal PricePack2
            {
                get { return pricePack2; }
                set { pricePack2 = value; }
            }

            public decimal TotalPack2
            {
                get { return totalPack2; }
                set { totalPack2 = value; }
            }

            public decimal ValuePack2
            {
                get { return valuePack2; }
                set { valuePack2 = value; }
            }

            public bool CheckPack3
            {
                get { return checkPack3; }
                set { checkPack3 = value; }
            }

            public string TypePack3
            {
                get { return typePack3; }
                set { typePack3 = value; }
            }

            public decimal QtyPack3
            {
                get { return qtyPack3; }
                set { qtyPack3 = value; }
            }

            public decimal PricePack3
            {
                get { return pricePack3; }
                set { pricePack3 = value; }
            }

            public decimal TotalPack3
            {
                get { return totalPack3; }
                set { totalPack3 = value; }
            }

            public decimal ValuePack3
            {
                get { return valuePack1; }
                set { valuePack3 = value; }
            }

            public bool CheckPack4
            {
                get { return checkPack4; }
                set { checkPack4 = value; }
            }

            public string TypePack4
            {
                get { return typePack4; }
                set { typePack4 = value; }
            }

            public decimal QtyPack4
            {
                get { return qtyPack4; }
                set { qtyPack4 = value; }
            }

            public decimal PricePack4
            {
                get { return pricePack4; }
                set { pricePack4 = value; }
            }

            public decimal TotalPack4
            {
                get { return totalPack4; }
                set { totalPack4 = value; }
            }

            public decimal ValuePack4
            {
                get { return valuePack4; }
                set { valuePack4 = value; }
            }

            public bool CheckPack5
            {
                get { return checkPack5; }
                set { checkPack5 = value; }
            }

            public string TypePack5
            {
                get { return typePack5; }
                set { typePack5 = value; }
            }

            public decimal QtyPack5
            {
                get { return qtyPack5; }
                set { qtyPack5 = value; }
            }

            public decimal PricePack5
            {
                get { return pricePack5; }
                set { pricePack5 = value; }
            }

            public decimal TotalPack5
            {
                get { return totalPack5; }
                set { totalPack5 = value; }
            }

            public decimal ValuePack5
            {
                get { return valuePack5; }
                set { valuePack5 = value; }
            }

            public decimal PackCostTotal
            {
                get { return packCostTotal; }
                set { packCostTotal = value; }
            }


            public decimal PackValueTotal
            {
                get { return packValueTotal; }
                set { packValueTotal = value; }
            }




            public bool CheckStaff1
            {
                get { return checkStaff1; }
                set { checkStaff1 = value; }
            }

            public string Staff1
            {
                get { return staff1; }
                set { staff1 = value; }
            }
      
            public decimal HoursStaff1
            {
                get { return hoursStaff1; }
                set { hoursStaff1 = value; }
            } 

            public decimal RateStaff1
            {
                get { return rateStaff1; }
                set { rateStaff1 = value; }
            } 

            public decimal TotalStaff1
            {
                get { return totalStaff1; }
                set { totalStaff1 = value; }
            }

            public bool CheckStaff2
            {
                get { return checkStaff2; }
                set { checkStaff2 = value; }
            }

            public string Staff2
            {
                get { return staff2; }
                set { staff2 = value; }
            }

            public decimal HoursStaff2
            {
                get { return hoursStaff2; }
                set { hoursStaff2 = value; }
            }

            public decimal RateStaff2
            {
                get { return rateStaff2; }
                set { rateStaff2 = value; }
            }

            public decimal TotalStaff2
            {
                get { return totalStaff2; }
                set { totalStaff2 = value; }
            }


            public bool CheckStaff3
            {
                get { return checkStaff3; }
                set { checkStaff3 = value; }
            }

            public string Staff3
            {
                get { return staff3; }
                set { staff3 = value; }
            }

            public decimal HoursStaff3
            {
                get { return hoursStaff3; }
                set { hoursStaff3 = value; }
            }

            public decimal RateStaff3
            {
                get { return rateStaff3; }
                set { rateStaff3 = value; }
            }

            public decimal TotalStaff3
            {
                get { return totalStaff3; }
                set { totalStaff3 = value; }
            }



            public bool CheckStaff4
            {
                get { return checkStaff4; }
                set { checkStaff4 = value; }
            }

            public string Staff4
            {
                get { return staff4; }
                set { staff4 = value; }
            }

            public decimal HoursStaff4
            {
                get { return hoursStaff4; }
                set { hoursStaff4 = value; }
            }

            public decimal RateStaff4
            {
                get { return rateStaff4; }
                set { rateStaff4 = value; }
            }

            public decimal TotalStaff4
            {
                get { return totalStaff4; }
                set { totalStaff4 = value; }
            }


            public bool CheckStaff5
            {
                get { return checkStaff5; }
                set { checkStaff5 = value; }
            }

            public string Staff5
            {
                get { return staff5; }
                set { staff5 = value; }
            }

            public decimal HoursStaff5
            {
                get { return hoursStaff5; }
                set { hoursStaff5 = value; }
            }

            public decimal RateStaff5
            {
                get { return rateStaff5; }
                set { rateStaff5 = value; }
            }

            public decimal TotalStaff5
            {
                get { return totalStaff5; }
                set { totalStaff5 = value; }
            }



            public decimal StaffCostTotal 
            {
                get { return staffCostTotal; }
                set { staffCostTotal = value; }
            }




            public string KitchenLocation
            {
                get { return kitchenLocation; }
                set { kitchenLocation = value; }
            }

            public decimal KitchenHours
            {
                get { return kitchenHours; }
                set { kitchenHours = value; }
            }

            public decimal KitchenRate
            {
                get { return kitchenRate; }
                set { kitchenRate = value; }
            }

                           
            public decimal KitchenTotal
            {
                get { return kitchenTotal; }
                set { kitchenTotal = value; }
            }
             
                  
      
    }
}
