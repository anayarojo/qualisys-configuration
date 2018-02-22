using Microsoft.VisualStudio.TestTools.UnitTesting;
using QualisysConfig;
using System;
using System.Configuration;

namespace QualisysConfigTests
{
    [TestClass]
    public class QsConfigTests
    {
        [TestMethod]
        [ExpectedException(typeof(ConfigurationErrorsException))]
        public void KeyNotFound()
        {
            QsConfig.GetValue<string>("NotFoundKey");
        }

        [TestMethod]
        public void StringValue()
        {
            // Arrange
            string lStrExpectedValue = "string";

            // Act
            var lUnkResult = QsConfig.GetValue<string>("string");

            // Assert
            Assert.AreEqual(lUnkResult, lStrExpectedValue);

        }

        [TestMethod]
        public void CharValue()
        {
            // Arrange
            char lChrExpectedValue = 'c';

            // Act
            var lUnkResult = QsConfig.GetValue<char>("char");

            // Assert
            Assert.AreEqual(lUnkResult, lChrExpectedValue);
        }

        [TestMethod]
        public void IntValue()
        {
            // Arrange
            int lIntExpectedValue = 1;

            // Act
            var lUnkResult = QsConfig.GetValue<int>("int");

            // Assert
            Assert.AreEqual(lUnkResult, lIntExpectedValue);
        }

        [TestMethod]
        public void LongValue()
        {
            // Arrange
            long lLonExpectedValue = 123456789;

            // Act
            var lUnkResult = QsConfig.GetValue<long>("long");

            // Assert
            Assert.AreEqual(lUnkResult, lLonExpectedValue);
        }

        [TestMethod]
        public void FloatValue()
        {
            // Arrange
            float lFltExpectedValue = 1.5f;

            // Act
            var lUnkResult = QsConfig.GetValue<float>("float");

            // Assert
            Assert.AreEqual(lUnkResult, lFltExpectedValue);
        }

        [TestMethod]
        public void DoubleValue()
        {
            // Arrange
            double lDblExpectedValue = 1.5;

            // Act
            var lUnkResult = QsConfig.GetValue<double>("double");

            // Assert
            Assert.AreEqual(lUnkResult, lDblExpectedValue);
        }

        [TestMethod]
        public void DecimalValue()
        {
            // Arrange
            decimal lDmlExpectedValue = 1.5m;

            // Act
            var lUnkResult = QsConfig.GetValue<decimal>("decimal");

            // Assert
            Assert.AreEqual(lUnkResult, lDmlExpectedValue);
        }

        [TestMethod]
        public void DateValue()
        {
            // Arrange
            DateTime lDtmExpectedValue = new DateTime(2017, 12, 13);

            // Act
            var lUnkResult = QsConfig.GetValue<DateTime>("date");

            // Assert
            Assert.AreEqual(lUnkResult, lDtmExpectedValue);
        }

        [TestMethod]
        public void BooleanValue()
        {
            // Arrange
            bool lBolExpectedValue = true;

            // Act
            var lUnkResult = QsConfig.GetValue<bool>("bool");

            // Assert
            Assert.AreEqual(lUnkResult, lBolExpectedValue);
        }

        [TestMethod]
        public void EnumValue()
        {
            // Arrange
            TestEnum lEnmExpectedValue = TestEnum.ENUM_A;

            // Act
            var lUnkResult = QsConfig.GetValue<TestEnum>("enum");

            // Assert
            Assert.AreEqual(lUnkResult, lEnmExpectedValue);
        }

        [TestMethod]
        public void ConnectionString()
        {
            // Act
            var lUnkResult = QsConfig.GetConnectionString("Connection");
        }

        [TestMethod]
        [ExpectedException(typeof(NullReferenceException))]
        public void NullConnectionString()
        {
            // Act
            var lUnkResult = QsConfig.GetConnectionString("NullConnection");
        }
    }
}
