using DevOpsToday.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DevOpsToday.MSTesting.Tests
{
    [TestClass]
    public class ErrorViewModelTests
    {
        [TestMethod]
        public void Test_ShowRequestIDMethod()
        {
            var sut=new ErrorViewModel(){RequestId="fred"};
            Assert.IsTrue(sut.ShowRequestId);
        }
    }
}