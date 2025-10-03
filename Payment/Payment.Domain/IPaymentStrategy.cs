namespace Payment.Domain
{
    /// <summary>
    /// Interfaz para estrategias de pago.
    /// </summary>
    public interface IPaymentStrategy
    {
        /// <summary>
        /// Realiza el pago según la estrategia definida.
        /// </summary>
        /// <param name="amount">Monto a pagar.</param>
        /// <returns>True si el pago fue exitoso.</returns>
        bool Pay(double amount);
    }
}