using Microsoft.VisualStudio.TestTools.UnitTesting;
using TDDWORK;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//ITAY BEN YAIR 209198704
//TAL MAIMON 211702808
namespace TDDWORK.Tests
{
    [TestClass()]
    public class lblNameTests
    {
        [TestMethod()]
        public void CalTaxTest()
        {
            var T = new TDDWORK.lblName();

            double sal = 3000;
            double result = 300;
            double temp = T.CalTax(sal);
            Assert.AreEqual(result, temp);


            sal = 6450;
            result = 645;
            temp = T.CalTax(sal);
            Assert.AreEqual(result, temp);

          
            sal = 9240;
            result = 1293;
            temp = (int)T.CalTax(sal);
            Assert.AreEqual(result, temp);
            

            sal = 8000;
            result = 1120;
            temp = T.CalTax(sal);
            Assert.AreEqual(result, temp);


            sal = 14840;
            result = 2968;
            temp = T.CalTax(sal);
            Assert.AreEqual(result, temp);


            sal = 15000;
            result = 4650;
            temp = T.CalTax(sal);
            Assert.AreEqual(result, temp);


            sal = 40000;
            result = 14000;
            temp = T.CalTax(sal);
            Assert.AreEqual(result, temp);


            sal = 50000;
            result = 23500;
            temp = T.CalTax(sal);
            Assert.AreEqual(result, temp);


        }

        [TestMethod()]
        public void SortTest()
        {
            var T = new TDDWORK.lblName();
            ListView L1 = new ListView();
            ListView L2 = new ListView();
            Random rnd = new Random();

            string[] Names = {  "אושר", "מעיין", "אורי", "אורי", "מירה", "איתי",  "יואב", "איילון", "גיא", "יותם", "עומרי", "יותם", "ניצן",  "צליל", "עמית", "אריאל", "נדב", "יעל ", "נועם", "תהל", "יואב", "נופר", "רן" };
            string[] FamilyName = { "בן יאיר",  "חורי", "דודזון", "רייק", "גולצמן", "מלכי", "מלמד",  "ברגיג", "ישראלי", "גיסמר", "בטאן", "כץ", "אהרון", "טביב", "טובול", "לביא", "חורי", "ירקוני", "אשכנזי" };
            string[] Pnum = { "050", "054", "052", "053", "055" };
            int flag = 0;
           
            // enter 20 random employee
            for (int i = 0; i < 20; i++)
            {
                int nameIndex = rnd.Next(Names.Length);
                int familyIndex = rnd.Next(FamilyName.Length);
                int PnumIndex = rnd.Next(Pnum.Length);

                string randomName1 = Names[nameIndex];
                string randomFname = FamilyName[familyIndex];
                string randomPnum = Pnum[PnumIndex];

                int randSalary = rnd.Next(2000, 60000);
                int randID = rnd.Next(200000000, 350000000);
                int randomPnum2 = rnd.Next(1000000, 9999999);

                string[] toConstructor = { randomName1 + " " + randomFname, randID.ToString(), randSalary.ToString() };
                string[] toConstructor2 = { randomPnum + randomPnum2.ToString(), " ", " " };

                ListViewItem listView1 = new ListViewItem(toConstructor);
                ListViewItem listView2 = new ListViewItem(toConstructor2);

                L1.Items.Add(listView1);
                L2.Items.Add(listView2);    
                
            }


            T.Sort( L1, L2);
            
            //check that sort function return somthing 
            Assert.AreNotEqual(L1.Items.Count, 0);

            //check all the objects exist after the sort
            Assert.AreEqual(L1.Items.Count,20);


            //check if the array is sorted
            for(int i = 0; i < 19; i++){
                double t1 = (double)Convert.ToInt32(L1.Items[i].SubItems[2].Text);
                double t2 = (double)Convert.ToInt32(L1.Items[i+1].SubItems[2].Text);

                if (t1 > t2)
                    flag = 1;

                Assert.AreEqual(flag,0);
                Assert.AreNotEqual(flag, 1);

            }

        }

    }
}