using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using LabSheet9;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestDeposit()
        {
            //ARRANGE
            BankAccount acc1 = new BankAccount();
            decimal expectedBalance = 200m;

            //ACT
            acc1.Desposit(200m);

            //ASSERT
            Assert.AreEqual(expectedBalance, acc1.Balance);

        }
    



    [TestMethod]
    public void TestMultiDeposit()
    {
        //ARRANGE
        BankAccount acc1 = new BankAccount();
        decimal expectedBalance = 200m;

        //ACT
        acc1.Desposit(100m);
        acc1.Desposit(60m);
        acc1.Desposit(40m);

            //ASSERT
            Assert.AreEqual(expectedBalance, acc1.Balance);

    }



        [TestMethod]
        public void TestNewAccountHasZeroBalance()
        {
            //ARRANGE
            BankAccount acc1 = new BankAccount();
            decimal expectedBalance = 0m;

            //ACT


            //ASSERT
            Assert.AreEqual(expectedBalance, acc1.Balance);

        }



        [TestMethod]
        public void TestWithdrawSufficientFunds()
        {
            //ARRANGE
            BankAccount acc1 = new BankAccount();
            acc1.Desposit(200m);
            decimal expectedBalance = 100m;

            //ACT
            acc1.Withdraw(100m);

            //ASSERT
            Assert.AreEqual(expectedBalance, acc1.Balance);

        }


        [TestMethod]
        public void TestWithdraw_InSufficientFunds()
        {
            //ARRANGE
            BankAccount acc1 = new BankAccount();
            acc1.Desposit(100m);
            decimal expectedBalance = 100m;

            //ACT
            acc1.Withdraw(200m);

            //ASSERT
            Assert.AreEqual(expectedBalance, acc1.Balance);

        }


        [TestMethod]
        public void TestWithdraw_SufficientFunds_Overdraft()
        {
            //ARRANGE
            BankAccount acc1 = new BankAccount();
            acc1.OverdraftLimit = 200m;
            decimal expectedBalance = -100m;

            //ACT
            acc1.Withdraw(100m);

            //ASSERT
            Assert.AreEqual(expectedBalance, acc1.Balance);

        }



        [TestMethod]
        public void TestWithdraw_InSufficientFunds_Overdraft()
        {
            //ARRANGE
            BankAccount acc1 = new BankAccount();
            acc1.OverdraftLimit = 200m;
            decimal expectedBalance = 0m;

            //ACT
            acc1.Withdraw(300m);

            //ASSERT
            Assert.AreEqual(expectedBalance, acc1.Balance);

        }
    }
}
