using NUnit.Framework;
using BankClassWithCoreforTesting;


namespace TestProject1BankUnitTest
{
    public class Tests
    {
        Bank Destination;
        Bank Source;

        [SetUp]
        public void Setup()
        {
            Source = new Bank();
            Source.Deposit(500.00F);
            Destination = new Bank();
            Destination.Deposit(200.00F);
        }

        [Test]
        public void Test1()
        {
            Assert.Pass();
        }
    }
}