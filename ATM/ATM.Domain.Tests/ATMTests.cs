using NUnit.Framework;
namespace ATM.Domain.Tests
{
    /// <summary>
    /// Pruebas unitarias para las operaciones del cajero automático (ATM).
    /// </summary>
    public class ATMTests
    {
        [Test]
        /// <summary>
        /// Verifica que el retiro de una cuenta actualiza correctamente el saldo.
        /// </summary>
        [Test]
        public void GivenAccountAndWithdraw_ThenExecute_ReturnsCorrectAmount()
        {
            var account = new Account() { AccountBalance = 300 };
            decimal amount = 100;
            var withdraw = new WithdrawCommand(account, amount);
            new ATM(withdraw).Action();
            Assert.IsTrue(account.AccountBalance.Equals(200));
        }
        [Test]
        /// <summary>
        /// Verifica que el depósito en una cuenta actualiza correctamente el saldo.
        /// </summary>
        [Test]
        public void GivenAccountAndDeposit_ThenExecute_ReturnsCorrectAmount()
        {
            var account = new Account() { AccountBalance = 200 };
            decimal amount = 100;
            var deposit = new DepositCommand(account, amount);
            new ATM(deposit).Action();
            Assert.IsTrue(account.AccountBalance.Equals(300));
        }
    }
}