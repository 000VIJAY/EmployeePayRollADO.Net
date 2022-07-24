
using EmployeePayrollADO.Net;
Repos repos = new Repos();
string my = repos.GetAllEmployee();
Console.WriteLine(my);