namespace ATM.Domain
{
    /// <summary>
    /// Comando para realizar un retiro en una cuenta.
    /// </summary>
    public class WithdrawCommand : ICommand
    {
        Account _account;
        decimal _amount;
        /// <summary>
        /// Inicializa el comando de retiro con la cuenta y el monto.
        /// </summary>
        /// <param name="account">Cuenta origen.</param>
        /// <param name="amount">Monto a retirar.</param>
        public WithdrawCommand(Account account, decimal amount)
        {
            _account = account;
            _amount = amount;
        }
        /// <summary>
        /// Ejecuta el retiro en la cuenta.
        /// </summary>
        public void Execute()
        {
            _account.Withdraw(_amount);
        }
    }
}