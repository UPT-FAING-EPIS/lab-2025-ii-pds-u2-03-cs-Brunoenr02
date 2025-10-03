namespace Payment.Domain
{
    /// <summary>
    /// Estrategia de pago en efectivo.
    /// </summary>
    public class CashPaymentStrategy : IPaymentStrategy
    {
        /// <summary>
        /// Realiza el pago en efectivo.
        /// </summary>
        /// <param name="amount">Monto a pagar.</param>
        /// <returns>True si el pago fue exitoso.</returns>
        public bool Pay(double amount)
        {
            Console.WriteLine("Customer pays Rs " + amount + " By Cash");
            return true;
        }
    }
}