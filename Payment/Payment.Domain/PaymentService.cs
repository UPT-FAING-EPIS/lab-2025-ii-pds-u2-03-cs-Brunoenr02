namespace Payment.Domain
{
    /// <summary>
    /// Servicio que procesa pagos utilizando diferentes estrategias.
    /// </summary>
    public class PaymentService
    {
        /// <summary>
        /// Procesa el pago según el tipo de pago seleccionado.
        /// </summary>
        /// <param name="SelectedPaymentType">Tipo de pago seleccionado.</param>
        /// <param name="Amount">Monto a pagar.</param>
        /// <returns>True si el pago fue exitoso.</returns>
        /// <exception cref="ArgumentException">Si el tipo de pago es inválido.</exception>
        public bool ProcessPayment(int SelectedPaymentType, double Amount)
        {
            PaymentContext context = new PaymentContext();
            if (SelectedPaymentType == (int)PaymentType.CreditCard)
            {
                context.SetPaymentStrategy(new CreditCardPaymentStrategy());
            }
            else if (SelectedPaymentType == (int)PaymentType.DebitCard)
            {
                context.SetPaymentStrategy(new DebitCardPaymentStrategy());
            }
            else if (SelectedPaymentType == (int)PaymentType.Cash)
            {
                context.SetPaymentStrategy(new CashPaymentStrategy());
            }
            else
            {
                throw new ArgumentException("You Select an Invalid Payment Option");
            }
            return context.Pay(Amount);
        }
    }
    /// <summary>
    /// Tipos de pago disponibles.
    /// </summary>
    public enum PaymentType
    {
        /// <summary>
        /// Pago con tarjeta de crédito.
        /// </summary>
        CreditCard = 1,
        /// <summary>
        /// Pago con tarjeta de débito.
        /// </summary>
        DebitCard = 2,
        /// <summary>
        /// Pago en efectivo.
        /// </summary>
        Cash = 3,
    }
}