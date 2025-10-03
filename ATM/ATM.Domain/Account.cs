using System;
namespace ATM.Domain
{
    /// <summary>
    /// Representa una cuenta bancaria con operaciones de depósito y retiro.
    /// </summary>
    public class Account
    {
        public const decimal MAX_INPUT_AMOUNT = 10000;
    /// <summary>
    /// Número de cuenta único.
    /// </summary>
    public int AccountNumber { get; set; }
    /// <summary>
    /// Saldo actual de la cuenta.
    /// </summary>
    public decimal AccountBalance { get; set; }

        /// <summary>
        /// Retira una cantidad del saldo de la cuenta.
        /// </summary>
        /// <param name="amount">Cantidad a retirar.</param>
        /// <exception cref="ArgumentException">Si la cantidad es mayor al saldo disponible.</exception>
        public void Withdraw(decimal amount)
        {
            if (amount > AccountBalance) 
                throw new ArgumentException("The input amount is greater than balance.");
            AccountBalance -= amount;            
        }
        /// <summary>
        /// Deposita una cantidad al saldo de la cuenta.
        /// </summary>
        /// <param name="amount">Cantidad a depositar.</param>
        /// <exception cref="ArgumentException">Si la cantidad excede el máximo permitido.</exception>
        public void Deposit(decimal amount)
        {
            if (amount > MAX_INPUT_AMOUNT) 
                throw new ArgumentException("The input amount is greater than maximum allowed.");
            AccountBalance += amount;            
        }
    }
}