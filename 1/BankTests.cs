using System;
using Bank;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BankTests
{
    [TestClass]
    public class AccountTests
    {
        [TestMethod]
        public void Debit_WithValidAmount()
        {
            // Arrange
            double startingBalance = 100.00;
            double debitAmount = 50.00;
            double expected = 50.00;
            Account account = new Account("Mr. Bryan Walton", startingBalance);

            // Act
            account.Debit(debitAmount);

            // Assert
            double actual = account.Balance;
            Assert.AreEqual(expected, actual, 0.001, "Account not debited correctly");
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void Debit_WhenAmountIsLessThanZero()
        {
            // Arrange
            double startingBalance = 100.00;
            double debitAmount = -100.00;
            Account account = new Account("Mr. Bryan Walton", startingBalance);

            // Act
            account.Debit(debitAmount);

            // Assert is handled by ExpectedException
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void Debit_WhenAmountIsMoreThanBalance()
        {
            // Arrange
            double startingBalance = 100.00;
            double debitAmount = 150.00;
            Account account = new Account("Mr. Bryan Walton", startingBalance);

            // Act
            account.Debit(debitAmount);

            // Assert is handled by ExpectedException
        }

        [TestMethod]
        public void Credit_WithValidAmount()
        {
            // Arrange
            double startingBalance = 100.00;
            double creditAmount = 50.00;
            double expected = 150.00;
            Account account = new Account("Mr. Bryan Walton", startingBalance);

            // Act
            account.Credit(creditAmount);

            // Assert
            double actual = account.Balance;
            Assert.AreEqual(expected, actual, 0.001, "Account not credited correctly");
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void Credit_WhenAmountIsLessThanZero()
        {
            // Arrange
            double startingBalance = 100.00;
            double creditAmount = -50.00;
            Account account = new Account("Mr. Bryan Walton", startingBalance);

            // Act
            account.Credit(creditAmount);

            // Assert is handled by ExpectedException
        }

        // Additional tests can be added here for other scenarios
    }
}
