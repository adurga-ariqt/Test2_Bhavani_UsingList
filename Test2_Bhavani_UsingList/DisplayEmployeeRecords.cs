using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test2_Bhavani_UsingList
{
    public  class DisplayEmployeeRecords: EmployeeRecords
    {
        public void SwitchCaseMethod()
        {


            int n;

            Console.WriteLine(" if you want to  enter the employee details " + Environment.NewLine + "Select any list  item ...." + Environment.NewLine + "1.Add" + Environment.NewLine + "2.Remove" + Environment.NewLine + "3.Insert" + Environment.NewLine + "4.RemoveAt" + Environment.NewLine + "5.Show All Records" + Environment.NewLine + "6.Search Employee" + Environment.NewLine + "7.Record Count" + Environment.NewLine + "8.Clear Console" + Environment.NewLine +" 9.Clear List" + Environment.NewLine +" 10.Stop The Program");
            n = Convert.ToInt32(Console.ReadLine());
            switch (n)
            {
                case 1:
                    AddingEmployeeInformation();
                    break;
                case 2:
                    RemoveOneEmployeeInformation();
                    break;
                case 3:
                    InstertEmployeeRecord();
                    break;
                case 4:
                    RemoveAtEmployeeRecord();
                    break;
                case 5:
                    ShowAllRecords();
                    break;
                case 6:
                    SearchEmployee();
                    break;
                case 7:
                    RecordCount();
                    break;
                case 8:
                    ClearConsole();

                    break;
                case 9:
                    ClearList();
                    break;
                case 10:
                    StopThePrograme();
                    break;


                default:
                    Console.WriteLine("none of the list ");
                    break;

            }


        }
    }
}
