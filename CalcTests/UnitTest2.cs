using CalcClassBr;
using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using AnalaizerClassLibrary;

namespace CalcTests
{

    [TestClass]

    public class SubCalcTests
    {
        public TestContext TestContext { get; set; }
        [DataSource("System.Data.SqlClient", "Server = DESKTOP-NHBNNPL\\SQLEXPRESS;Integrated Security = True;Database = CalculatorData", "CalcTest", DataAccessMethod.Sequential)]

        [TestMethod]
        public void SubTest()
        {
            // Arrange
            long a = Convert.ToInt64(TestContext.DataRow["a"]);
            long b = Convert.ToInt64(TestContext.DataRow["b"]);
            long expectedResult = Convert.ToInt64(TestContext.DataRow["r"]);
            try
            {
                // Act
                long actualResult = CalcClass.Sub(a, b);

                // Assert
                Assert.AreEqual(expectedResult, actualResult);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Test failed with exception: {ex.Message}");
            }

        }
    }
}

