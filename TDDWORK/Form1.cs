using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//ITAY BEN YAIR 209198704
//TAL MAIMON 211702808
namespace TDDWORK
{
    public partial class lblName : Form
    {
        public lblName()
        {
            InitializeComponent();

        }
        private void button1_Click(object sender, EventArgs e)
        {

        }
        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {

        }
        private void panelMenu_Paint(object sender, PaintEventArgs e)
        {

        }
        private void ListEmployee_Click(object sender, EventArgs e)
        {

        }
        private void lblName_Load(object sender, EventArgs e)
        {

        }
        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void label2_Click(object sender, EventArgs e)
        {

        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void label2_Click_1(object sender, EventArgs e)
        {

        }
        private void listView1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }


        //get details from the user and add employee 
        private void AddEmploye_Click(object sender, EventArgs e)
        {
            //check that user enter all the details
            if (string.IsNullOrEmpty(textBox_address.Text) || string.IsNullOrEmpty(textBox_phone.Text) || string.IsNullOrEmpty(textBox_family.Text) || string.IsNullOrEmpty(textBox_email.Text) || string.IsNullOrEmpty(textBox_name.Text) || string.IsNullOrEmpty(textBox_id.Text) || string.IsNullOrEmpty(textBox_salary.Text))
            {
                MessageBox.Show("אנא מלא את כל נתוני העובד כנדרש");
                clear_textBoxes();
                return;
            }

            if ( textBox_salary.Text.All(char.IsDigit)  && textBox_id.Text.All(char.IsDigit) && textBox_id.Text.Length == 9 && textBox_phone.Text.All(char.IsDigit) && textBox_name.Text.All(Char.IsLetter) && textBox_family.Text.All(Char.IsLetter))
            {
                //check if all the text box is full
                
                string[] toConstructor = { textBox_name.Text + " " + textBox_family.Text, textBox_id.Text, textBox_salary.Text };
                string[] toConstructor2 = {textBox_phone.Text ,textBox_email.Text ,textBox_address.Text};  
                ListViewItem employee = new ListViewItem(toConstructor);
                ListViewItem details_employee = new ListViewItem(toConstructor2); // to save the email,phone and the adrress of the  employees
                
                employee.SubItems.Add(textBox_name.Text);

                listView1.Items.Add(employee);
                listView2.Items.Add(details_employee);  

            }
            else MessageBox.Show("נתוני העבוד שהזנת לא תקינים. אנא נסה שנית");

            
            clear_textBoxes();
            
        }


        public double CalTax(double salary)
        {
            // 2 arrays for the salarys and the percents
            int[] sal = {0,6451,9241,14841,20621,42911 };
            double[] percents = { 0.1 ,0.14,0.2,0.31,0.35,0.47};
            double temp = 1;


            for (int i = 0; i < sal.Length -1; i++)
            {
                if (salary >= sal[i] && salary <= sal[i+1])
                    temp = percents[i];

                if (salary > sal[i+1])
                    temp = percents[i+1];

            }
            return salary * temp;

        }


        //calulate the tax acording to salary
        private void TaxCal_Click(object sender, EventArgs e){
            try
            {
                int choise = listView1.SelectedIndices[0];
                string salaryText = listView1.Items[choise].SubItems[2].Text;
                double sal = (double)Convert.ToInt32(salaryText);
                salaryText = Convert.ToString(CalTax(sal));
                textBox1.Text = salaryText;
            }
            catch (Exception)
            {
                MessageBox.Show("אנא בחר עובד לפני לחיצה על כפתור חישוב המס");
            }  
        }


        // clear all the text boxes after the enter
        private void clear_textBoxes()
        {
            textBox_name.Clear();
            textBox_family.Clear();
            textBox_address.Clear();
            textBox_id.Clear();
            textBox_salary.Clear();
            textBox_phone.Clear();
            textBox_email.Clear();
        }

      
        // sort according to salary that exist in listview1
        public void Sort(ListView listView1, ListView listView2)
        {
            DateTime startSort, endSort;
            startSort = DateTime.Now;

            // bublue sort
            /*
             for (int i = 0; i < listView1.Items.Count; i++)
             {
                 for (int j = 0; j < listView1.Items.Count -1; j++)
                 {
                     int salTemp2 = Convert.ToInt32(listView1.Items[j].SubItems[2].Text);
                     int salTemp1 = Convert.ToInt32(listView1.Items[j+1].SubItems[2].Text);

                     if (salTemp1 < salTemp2)
                     {
                        swap(j,j+1);


                     }
                 }
             }
           */

            
            QuickSort(listView1, listView2, 0, listView1.Items.Count -1);

            //print the difference between the end sort to start sort
            endSort = DateTime.Now;
            Double temp = ((TimeSpan)(endSort - startSort)).TotalMilliseconds  / 1000;
            MessageBox.Show("זמן המיון  :  " + temp.ToString() + "  שניות  ");

        }

        private void SortBySalary_Click(object sender, EventArgs e)
        {
            Sort(listView1,listView2);
        }

        private void QuickSort(ListView listView1, ListView listView2, int start, int end)
        {
            if (start < end)
            {

                double pi = Partition(listView1, listView2,start, end);
                QuickSort(listView1, listView2, start,(int)pi -1);
                QuickSort(listView1, listView2,(int)pi + 1, end);
                
            }
        }

        private void swap(ListView listView1, ListView listView2, int index1,int index2)
        {
          
            if(index1 != index2)
            {
                ListViewItem item1 = listView1.Items[index1];
                ListViewItem item2 = listView1.Items[index2];
                ListViewItem item3 = listView2.Items[index1];
                ListViewItem item4 = listView2.Items[index2];

               
                listView1.Items.Remove(item1);
                listView1.Items.Remove(item2);
                listView2.Items.Remove(item3);
                listView2.Items.Remove(item4);

                listView1.Items.Insert(index1, item2);
                listView1.Items.Insert(index2, item1);
                listView2.Items.Insert(index1, item4);
                listView2.Items.Insert(index2, item3);

            }
            
        }

        private double Partition(ListView listView1, ListView listView2, int start , int end)
        {
           
            double pivot = (double)Convert.ToInt32(listView1.Items[end].SubItems[2].Text);
            int i = start -1 ;
            
            for (int  j = start ; j < end ; j++)
            {

                double temp = (double)Convert.ToInt32(listView1.Items[j].SubItems[2].Text);
                  
                if (temp < pivot)
                {
                    i++;
                    swap(listView1, listView2,i, j);
           
                }


            }

            swap(listView1, listView2, i+1,end);   

            return i+1;

        }

        private void Add10Employee_Click(object sender, EventArgs e)
        {
            string[] Names = {  "עוז", "ניר", "נועם", "אדר", "גלעד", "דניאל", "מיכאל", "הראל", "רועי ", "רותם", "איתמר", "כפיר", "עומרי", "תומר", "איתמר", "דניאל", "הגר", "הילה", "אורי", "דן", "דין", "עדן", "יפתח", "אלון", "עידו", "עידו", "ינאי", "כפיר", "אורי", "יואב", "שלו", "מיכאל", "מתן", "איתן", "דניאל", "אור ", "עומר", "יאיר", "יונתן", "שהם", "איתי", "שחף", "רועי", "רני", "יונתן", "אושר", "מעיין", "אורי", "אורי", "מירה", "איתי", "רון", "אורי", "ראם", "עידן", "איתן", "שי", "ינאי", "אורי", "לירון", "עמית", "שגיא", "יובל", "אביב", "שגיא", "איתמר", "נבו", "יהונתן", "יואב", "איילון", "גיא", "יותם", "עומרי", "יותם", "ניצן", "ניר", "רון", "ניב", "יעל", "אלמגור", "גיא", "עמית", "עדן ", "צליל", "עמית", "אריאל", "נדב", "יעל ", "נועם", "תהל", "יואב", "נופר", "רן" };
            string[] FamilyName = {  "בן יאיר", "קויפמן", "לרמן", "ליבוביץ'", "נוריאל", "גלפר", "כנפו", "חן", "שקד", "פלדמן", "גולצמן", "חדד", "קוסטי", "פנחס", "מור", "להב", "שולמן", "בר", "נצר", "גברא", "ברדה", "להב", "ארובס מזור", "דגן", "אורן", "שר", "צור", "זך", "שמרון", "מיתר", "פולק", "רומי", "אברהמי", "זהבי", "קדם", "גלזר", "פלדמן", "אוקנין", "ווייס", "בר", "גבע", "ארז", "גרוסמן", "דביר", "אלישע", "ילון", "פז", "עזר חזני", "פרוטופופוב", "קורן", "כהן", "שמש", "בבאי", "דודזון", "בן שמואל", "רביד", "איידלמן", "להב", "ואלך", "בייזר", "טובי", "לייבו", "רייק", "גולצמן", "מלכי", "מלמד", "לוי", "ברדה", "חיים", "אסייג", "אמיר", "סלמי", "פרץ", "מעוז", "גנון", "כיהלי", "הנדלר", "פרקש", "בן ציון", "יושינסקי", "אייזנברג", "ברגיג", "ישראלי", "גיסמר", "בטאן", "כץ", "אהרון", "טביב", "טובול", "לביא", "חורי", "ירקוני", "אשכנזי" };
            Random rnd = new Random();
            string[] Pnum = { "050", "054", "052", "053", "055" };

            for (int i = 0; i < 10000; i++)
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
                string[] toConstructor2 = { randomPnum + randomPnum2.ToString() ," ", " "};
                ListViewItem employee = new ListViewItem(toConstructor);
                ListViewItem details_employee = new ListViewItem(toConstructor2); 

                listView1.Items.Add(employee);
                listView2.Items.Add(details_employee);

            }

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }

}
