namespace ATM.Domain
{
    /// <summary>
    /// Comando para realizar un depósito en una cuenta.
    /// </summary>
    public class DepositCommand : ICommand
    {
        Account _account;
        decimal _amount;
        /// <summary>
        /// Inicializa el comando de depósito con la cuenta y el monto.
        /// </summary>
        /// <param name="account">Cuenta destino.</param>
        /// <param name="amount">Monto a depositar.</param>
        public DepositCommand(Account account, decimal amount)
        {
            _account = account;
            _amount = amount;
        }
        /// <summary>
        /// Ejecuta el depósito en la cuenta.
        /// </summary>
        public void Execute()
        {
            _account.Deposit(_amount);
        }        
    }
}