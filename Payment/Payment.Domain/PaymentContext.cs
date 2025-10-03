namespace Payment.Domain
{
    /// <summary>
    /// Contexto que gestiona la estrategia de pago seleccionada.
    /// </summary>
    public class PaymentContext
    {
        // The Context has a reference to the Strategy object.
        // The Context does not know the concrete class of a strategy. 
        // It should work with all strategies via the Strategy interface.
        private IPaymentStrategy PaymentStrategy;
        /// <summary>
        /// Establece la estrategia de pago a utilizar.
        /// </summary>
        /// <param name="strategy">Estrategia de pago.</param>
        public void SetPaymentStrategy(IPaymentStrategy strategy)
        {
            PaymentStrategy = strategy;
        }
        // The Context delegates the work to the Strategy object instead of
        // implementing multiple versions of the algorithm on its own.
        /// <summary>
        /// Realiza el pago utilizando la estrategia seleccionada.
        /// </summary>
        /// <param name="amount">Monto a pagar.</param>
        /// <returns>True si el pago fue exitoso.</returns>
        public bool Pay(double amount)
        {
            return PaymentStrategy.Pay(amount);
        }
    }
}