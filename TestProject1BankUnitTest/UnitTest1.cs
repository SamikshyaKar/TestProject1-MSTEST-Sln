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
            // arrange 

            Source = new Bank();
            Source.Deposit(500.00F);
            Destination = new Bank();
            Destination.Deposit(200.00F);
        }

        [Test]
        [Category("Pass")]
        public void Test1Transferfunds()
        {
            //act
            Source.TransferFunds(100.00F, Destination, Source);


            //assert
            Assert.Pass();
            Assert.AreEqual(400.00F, Source.balance);
            Assert.AreEqual(300.00F, Destination.balance);


        }

        [Test]
        [Category("Fail")]
        public void Test2Transferfunds()
        {
            //act
            Source.TransferFunds(100.00F, Destination, Source);


            //assert
            Assert.Pass();
            Assert.AreEqual(300.00F, Source.balance);
            Assert.AreEqual(200.00F, Destination.balance);


        }

        [Test]
        [Category("Pass")]
        [TestCase(200,0,100)]
        [TestCase(500,0,200)]
        [TestCase(800,0,600)]
        [TestCase(900,0,400)]

        public void TransferMinFunds(int a, int b, int c)
        {
            //arrange
            Bank banksource = new Bank();
            banksource.Deposit(a);
            Bank bankdestination = new Bank();
            bankdestination.Deposit(b);
            //act
            bankdestination= banksource.TransferMinFunds(bankdestination, c, banksource);

            // assert

            Assert.AreEqual(c, bankdestination.balance);

            



        }
    }
}