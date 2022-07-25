using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace EmployeePayrollADO.Net
{
    public class SalaryOfEmployee
    {
        const string ConnectionString = @"Data Source=.;Initial Catalog=Employee_Payroll;Integrated Security=True";
        SqlConnection sql = new SqlConnection(ConnectionString);
        public double FindSumOfsalaryOfMale()
        {
            EmployeeData employeeData = new EmployeeData();
            var query = @"SELECT SUM (Salary) FROM Employee_Payroll Where Gender = 'M'";
            SqlCommand command = new SqlCommand(query, sql);
            sql.Open();
            SqlDataReader reader = command.ExecuteReader();
            try
            {
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        employeeData.Salary = reader.GetDouble(0);
                        Console.WriteLine("Sum of salary for men Employee: " + employeeData.Salary);
                    }
                }
                reader.Close();
                this.sql.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return employeeData.Salary;
        }
        public double SumOfSalaryOfFemaleEmp()
        {
            EmployeeData employee = new EmployeeData();
            var queryFemale = @"SELECT SUM (Salary) FROM Employee_Payroll Where Gender = 'F'";
            SqlCommand command1 = new SqlCommand(queryFemale, sql);
            this.sql.Open();
            SqlDataReader read = command1.ExecuteReader();
            try
            {
                if (read.HasRows)
                {
                    while (read.Read())
                    {
                        employee.Salary = read.GetDouble(0);
                        Console.WriteLine("Sum of salary for Female Employee: " + employee.Salary);
                    }
                }
                read.Close();
                this.sql.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return employee.Salary;
        }
        public double FindAvgOfsalaryOfMale()
        {
            EmployeeData employeeData = new EmployeeData();
            var query = @"SELECT AVG (Salary) FROM Employee_Payroll Where Gender = 'M'";
            SqlCommand command = new SqlCommand(query, sql);
            sql.Open();
            SqlDataReader reader = command.ExecuteReader();
            try
            {
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        employeeData.Salary = reader.GetDouble(0);
                        Console.WriteLine("Average salary for male Employee: " + employeeData.Salary);
                    }
                }
                reader.Close();
                this.sql.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return employeeData.Salary;
        }
        public double AvgOfSalaryOfFemaleEmp()
        {
            EmployeeData employee = new EmployeeData();
            var queryFemale = @"SELECT AVG (Salary) FROM Employee_Payroll Where Gender = 'F'";
            SqlCommand command = new SqlCommand(queryFemale, sql);
            this.sql.Open();
            SqlDataReader read = command.ExecuteReader();
            try
            {
                if (read.HasRows)
                {
                    while (read.Read())
                    {
                        employee.Salary = read.GetDouble(0);
                        Console.WriteLine("Average salary for Female Employee: " + employee.Salary);
                    }
                }
                read.Close();
                this.sql.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return employee.Salary;
        }
        public double FindMinOfsalaryOfMale()
        {
            EmployeeData employeeData = new EmployeeData();
            var query = @"SELECT MIN (Salary) FROM Employee_Payroll Where Gender = 'M'";
            SqlCommand command = new SqlCommand(query, sql);
            sql.Open();
            SqlDataReader reader = command.ExecuteReader();
            try
            {
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        employeeData.Salary = reader.GetDouble(0);
                        Console.WriteLine("Minimum salary for male Employee: " + employeeData.Salary);
                    }
                }
                reader.Close();
                this.sql.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return employeeData.Salary;
        }
        public double MinSalaryOfFemaleEmp()
        {
            EmployeeData employee = new EmployeeData();
            var queryFemale = @"SELECT MIN (Salary) FROM Employee_Payroll Where Gender = 'F'";
            SqlCommand command = new SqlCommand(queryFemale, sql);
            this.sql.Open();
            SqlDataReader read = command.ExecuteReader();
            try
            {
                if (read.HasRows)
                {
                    while (read.Read())
                    {
                        employee.Salary = read.GetDouble(0);
                        Console.WriteLine("Minimum salary for Female Employee: " + employee.Salary);
                    }
                }
                read.Close();
                this.sql.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return employee.Salary;
        }
        public double FindMaxsalaryOfMale()
        {
            EmployeeData employeeData = new EmployeeData();
            var query = @"SELECT MAX (Salary) FROM Employee_Payroll Where Gender = 'M'";
            SqlCommand command = new SqlCommand(query, sql);
            sql.Open();
            SqlDataReader reader = command.ExecuteReader();
            try
            {
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        employeeData.Salary = reader.GetDouble(0);
                        Console.WriteLine("Maximum salary for male Employee: " + employeeData.Salary);
                    }
                }
                reader.Close();
                this.sql.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return employeeData.Salary;
        }
        public double MaxSalaryOfFemaleEmp()
        {
            EmployeeData employee = new EmployeeData();
            var queryFemale = @"SELECT MAX (Salary) FROM Employee_Payroll Where Gender = 'F'";
            SqlCommand command = new SqlCommand(queryFemale, sql);
            try
            {
            this.sql.Open();
            SqlDataReader read = command.ExecuteReader();
                if (read.HasRows)
                {
                    while (read.Read())
                    {
                        employee.Salary = read.GetDouble(0);
                        Console.WriteLine("Maximum salary for Female Employee: " + employee.Salary);
                    }
                }
                read.Close();
                this.sql.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return employee.Salary;
        }
        public void CountOfMaleEmployee()
        {
            EmployeeData employeeData = new EmployeeData();
            var query = @"SELECT COUNT (Id) FROM Employee_Payroll Where Gender = 'M'";
            SqlCommand command = new SqlCommand(query, sql);
            sql.Open();
            try
            {
                int count = (int)command.ExecuteScalar();
                Console.WriteLine("Number of Male employee: " + count);
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            sql.Close();
        }
        public void CountOfFemaleEmp()
        {
            EmployeeData employee = new EmployeeData();
            var queryFemale = @"SELECT COUNT (Id) FROM Employee_Payroll Where Gender = 'F'";
            SqlCommand command = new SqlCommand(queryFemale, sql);
            this.sql.Open();
            try
            {
                int count = (int)command.ExecuteScalar();
                Console.WriteLine("Number of Female employee: " + count);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            sql.Close();
        }
    }
}
