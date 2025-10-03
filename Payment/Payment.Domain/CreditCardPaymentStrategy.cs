namespace Payment.Domain
{
    /// <summary>
    /// Estrategia de pago con tarjeta de crédito.
    /// </summary>
    public class CreditCardPaymentStrategy : IPaymentStrategy
    {
        /// <summary>
        /// Realiza el pago con tarjeta de crédito.
        /// </summary>
        /// <param name="amount">Monto a pagar.</param>
        /// <returns>True si el pago fue exitoso.</returns>
        public bool Pay(double amount)
        {
            Console.WriteLine("Customer pays Rs " + amount + " using Credit Card");
            return true;
        }
    }
}