using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test2_Bhavani_UsingList
{
  
    
        public class EmployeeRecords : Employee
        {
            List<Employee> employeeslist = new List<Employee>();
            Employee objEmployee = new Employee();
            public void AddingEmployeeInformation()
            {

                Employee objEmployee;

                // Console.WriteLine("How Many Employees, Do you want add?");
                // int employeeCount = int.Parse(Console.ReadLine());

                //for (int loopVariable = 1; loopVariable <= employeeCount; loopVariable++)
                // {
                objEmployee = new Employee();

                objEmployee.AddNewEmployee();
                employeeslist.Add(objEmployee);


                // }

                Console.WriteLine("****************** Employees List ******************");
                foreach (Employee abc in employeeslist)
                {
                    abc.ShowEmployee();
                }
            }
            public void SearchEmployee()
            {
                Console.WriteLine("Do you want search for any employee?, please specify Employee ID to search");
                int empID = int.Parse(Console.ReadLine());



                Employee resultEmployee = new Employee();
                bool isRecordFound = false;
                foreach (Employee abc in employeeslist)
                {
                    if (empID == abc.EmployeeID)
                    {
                        resultEmployee = abc;
                        isRecordFound = true;
                        break;
                    }
                }

                if (isRecordFound)
                {
                    resultEmployee.ShowEmployee();
                }
                else
                {
                    Console.WriteLine(" Employee Id is Out of the list");
                }

            }
            public void RemoveOneEmployeeInformation()
            {
                Console.WriteLine("Do you want Remove  any employee?, say 'Y' or 'y' to remove");
                string strRemoveOption = Console.ReadLine();

                if (strRemoveOption.ToLower() == "y")
                {
                    Console.WriteLine("Do you want Remove  any employee?, please specify Employee ID to search");
                    int empIDRemove = int.Parse(Console.ReadLine());



                    foreach (Employee employee in employeeslist)
                    {
                        if (empIDRemove == employee.EmployeeID)
                        {
                            employeeslist.Remove(employee);
                            break;
                        }
                    }
                    foreach (Employee abc in employeeslist)
                    {
                        abc.ShowEmployee();
                    }


                }
            }
            public void InstertEmployeeRecord()
            {
                Console.WriteLine("Do you want Insert  any employee?, say 'Y' or 'y' to Insert");
                string strInsertOption = Console.ReadLine();

                if (strInsertOption.ToLower() == "y")
                {
                    Console.WriteLine("No.of records exists in List is :" + employeeslist.Count());

                    Console.WriteLine("Enter the index of new record where you want to insert?, index like 0,1,2,........");
                    int recordIndex = int.Parse(Console.ReadLine());

                    objEmployee = new Employee();

                    objEmployee.AddNewEmployee();
                    employeeslist.Insert(recordIndex, objEmployee);

                }

                foreach (Employee employee in employeeslist)
                {
                    employee.ShowEmployee();
                }


            }
            public void RemoveAtEmployeeRecord()
            {


                Console.WriteLine("Do you want Insert  any employee?, say 'Y' or 'y' to Insert");
                string strInsertOption = Console.ReadLine();

                if (strInsertOption.ToLower() == "y")
                {
                    Console.WriteLine("Do you want Remove particular index of  any employee?, please specify Employee ID to search");
                    int index = int.Parse(Console.ReadLine());

                    foreach (Employee employee in employeeslist)
                    {

                        employeeslist.RemoveAt(index);
                        break;

                    }
                    foreach (Employee employee in employeeslist)
                    {
                        employee.ShowEmployee();

                    }
                }
            }

            public void ShowAllRecords()
            {
                Console.WriteLine("List of the items are in the below");
                foreach (Employee abc in employeeslist)
                {
                    abc.ShowEmployee();
                }
            }
            public void RecordCount()
            {
                Console.WriteLine("No.of records exists in List is :" + employeeslist.Count());
            }
            public void StopThePrograme()
            {
                Console.WriteLine(" Press enter button to exit");
            }
        public void ClearConsole()
        {
            Console.Clear();
            Console.WriteLine("Clear employee records");
        }
        public void ClearList()
        {
            employeeslist.Clear();
            Console.WriteLine("The list is clear");
        }
        }
    }



