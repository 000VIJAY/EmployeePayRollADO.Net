using EmployeePayrollADO.Net;
namespace EmployeePayrollTest
{
    [TestClass]
    public class PayrollTest
    {
        [TestMethod]
        public void UpdateTest()
        {
            Repos repo = new Repos();
            var result = repo.UpdateDataOfEmployee();
            Assert.AreEqual(400000 ,result);
        }
        [TestMethod]
        public void RetrieveDataByNameTest()
        {
            Repos repo = new Repos();
            var result = repo.RetrieveDataByName();
            Assert.AreEqual("Vijay Kumar ", result);
        }
        [TestMethod]
        public void RetrieveDatabetweenDateTest()
        {
            Repos repo = new Repos();
            var result = repo.RetrieveDataBetweenDateOfJoin();
            Assert.AreEqual("Terissa", result);
        }
        [TestMethod]
        public void FindSumOfsalaryOfMale()
        {
            SalaryOfEmployee repo = new SalaryOfEmployee();
            var result = repo.FindSumOfsalaryOfMale();
            Assert.AreEqual(900000, result);
        }
        [TestMethod]
        public void FindSumOfsalaryOfFemale()
        {
            SalaryOfEmployee repo = new SalaryOfEmployee();
            var result = repo.SumOfSalaryOfFemaleEmp();
            Assert.AreEqual(8300000, result);
        }
        [TestMethod]
        public void FindAvgOfsalaryOfMale()
        {
            SalaryOfEmployee repo = new SalaryOfEmployee();
            var result = repo.FindAvgOfsalaryOfMale();
            Assert.AreEqual(300000, result);
        }
        [TestMethod]
        public void FindAvgOfsalaryOfFemale()
        {
            SalaryOfEmployee repo = new SalaryOfEmployee();
            var result = repo.AvgOfSalaryOfFemaleEmp();
            Assert.AreEqual(2766666.6666666665, result);
        }
        [TestMethod]
        public void FindMinsalaryOfMale()
        {
            SalaryOfEmployee repo = new SalaryOfEmployee();
            var result = repo.FindMinOfsalaryOfMale();
            Assert.AreEqual(300000, result);
        }
        [TestMethod]
        public void FindMinsalaryOfFemale()
        {
            SalaryOfEmployee repo = new SalaryOfEmployee();
            var result = repo.MinSalaryOfFemaleEmp();
            Assert.AreEqual(300000, result);
        }
        [TestMethod]
        public void FindMaxsalaryOfMale()
        {
            SalaryOfEmployee repo = new SalaryOfEmployee();
            var result = repo.FindMaxsalaryOfMale();
            Assert.AreEqual(300000, result);
        }
        [TestMethod]
        public void FindMaxsalaryOfFemale()
        {
            SalaryOfEmployee repo = new SalaryOfEmployee();
            var result = repo.MaxSalaryOfFemaleEmp();
            Assert.AreEqual(4000000, result);
        }
    }
}