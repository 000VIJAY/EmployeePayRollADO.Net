using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace EmployeePayrollADO.Net
{
    public class Repos
    {
        const string ConnectionString = @"Data Source=.;Initial Catalog=Employee_Payroll;Integrated Security=True";
        SqlConnection sql = new SqlConnection(ConnectionString);
        public string GetAllEmployee()
        {
            try
            {
                EmployeeData employeeModel = new EmployeeData();
                using (this.sql)
                {
                    string query = @"SELECT Id , name ,Salary , Start , Gender ,PhoneNumber,Address ,Department ,BasicPay , Deductions ,TaxablePay , IncomeTax ,NetPay  FROM Employee_Payroll;";
                    SqlCommand cmd = new SqlCommand(query, sql);
                    this.sql.Open();
                    SqlDataReader reader = cmd.ExecuteReader();
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            employeeModel.Id = reader.GetInt32(0);
                            employeeModel.name = reader.GetString(1);
                            employeeModel.Salary = reader.GetDouble(2);
                            employeeModel.StartDateDate = reader.GetDateTime(3);
                            employeeModel.Gender = Convert.ToChar(reader.GetString(4));
                            employeeModel.PhoneNumber = Convert.ToDouble(reader.GetInt64(5));
                            employeeModel.Address = reader.GetString(6);
                            employeeModel.Department = reader.GetString(7);
                            employeeModel.BasicPay = Convert.ToDouble(reader.GetInt64(8));
                            employeeModel.Deduction = Convert.ToDouble(reader.GetInt64(9));
                            employeeModel.TaxablePay = Convert.ToDouble(reader.GetInt64(10));
                            employeeModel.IncomeTax = Convert.ToDouble(reader.GetInt64(11));
                            employeeModel.NetPay = Convert.ToDouble(reader.GetInt64(12));
                            Console.WriteLine(" Id: " + employeeModel.Id + " Name: " + employeeModel.name + " Salary: " + employeeModel.Salary + " Start Date: " + employeeModel.StartDateDate + " Gender: " + employeeModel.Gender + " PhNumber: " + employeeModel.PhoneNumber
                                                      + " Address: " + employeeModel.Address + " Department: " + employeeModel.Department + " Basic Pay: " + employeeModel.BasicPay
                                                      + " Deductios: " + employeeModel.Deduction + "Taxable Pay: " + employeeModel.TaxablePay + " Income Tax: " + employeeModel.IncomeTax + " Net Pay: " + employeeModel.NetPay);
                        }
                    }
                    else
                    {
                        Console.WriteLine("Data not found");
                    }
                    reader.Close();
                    this.sql.Close();
                }
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
            return null;
        }
        public int UpdateDataOfEmployee()
        {
            EmployeeData employee = new EmployeeData();
            var query = @"UPDATE Employee_Payroll Set Salary = 4000000 where name = 'Terissa'";
            SqlCommand command = new SqlCommand(query, sql);
            command.CommandType = CommandType.Text;
            this.sql.Open();
            try
            {
                command.Parameters.Add("Salary", SqlDbType.BigInt).Value = 4000000;
                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            sql.Close();
            return 400000;
        }
        public string RetrieveDataByName()
        {
            EmployeeData employee = new EmployeeData();
            var query = @"SELECT * FROM Employee_Payroll where name = 'Vijay Kumar'";
            SqlCommand command = new SqlCommand(query ,sql);
          
            this.sql.Open();
            SqlDataReader reader = command.ExecuteReader();
            try
            {
                if(reader.HasRows)
                {
                    while (reader.Read())
                    {
                        employee.Id = reader.GetInt32(0);
                        employee.name = reader.GetString(1);
                        employee.Salary = reader.GetDouble(2);
                        employee.StartDateDate = reader.GetDateTime(3);
                        employee.Gender = Convert.ToChar(reader.GetString(4));
                        employee.PhoneNumber = Convert.ToDouble(reader.GetInt64(5));
                        employee.Address = reader.GetString(6);
                        employee.Department = reader.GetString(7);
                        employee.BasicPay = Convert.ToDouble(reader.GetInt64(8));
                        employee.Deduction = Convert.ToDouble(reader.GetInt64(9));
                        employee.TaxablePay = Convert.ToDouble(reader.GetInt64(10));
                        employee.IncomeTax = Convert.ToDouble(reader.GetInt64(11));
                        employee.NetPay = Convert.ToDouble(reader.GetInt64(12));
                        Console.WriteLine(" Id: " + employee.Id + " Name: " + employee.name + " Salary: " + employee.Salary + " Start Date: " + employee.StartDateDate + " Gender: " + employee.Gender + " PhNumber: " + employee.PhoneNumber
                                                  + " Address: " + employee.Address + " Department: " + employee.Department + " Basic Pay: " + employee.BasicPay
                                                  + " Deductios: " + employee.Deduction + "Taxable Pay: " + employee.TaxablePay + " Income Tax: " + employee.IncomeTax + " Net Pay: " + employee.NetPay);
                    }
                }
                
                else
                {
                    Console.WriteLine("data not found");
                }
                reader.Close();
                this.sql.Close();
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
            return employee.name;
        }
    }
    
    
}
