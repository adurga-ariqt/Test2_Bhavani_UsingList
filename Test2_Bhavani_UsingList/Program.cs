// See https://aka.ms/new-console-template for more information
using Test2_Bhavani_UsingList;

Console.WriteLine("Hello, World!");
DisplayEmployeeRecords objDisplayEmployeeRecords = new DisplayEmployeeRecords(); 

EmployeeDetails:
objDisplayEmployeeRecords.SwitchCaseMethod();

Console.WriteLine("Do you want to repeat  again if yes enter Y ,if you dont want to enter any letter except y");
string emp = Console.ReadLine();
if (emp.ToLower() == "y")
{
    goto EmployeeDetails;
}
else
    Console.WriteLine("the loop is not repeated");


