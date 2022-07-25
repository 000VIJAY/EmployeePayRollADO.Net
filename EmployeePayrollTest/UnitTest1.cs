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
    }
}