using System;
using NUnit.Framework;
using Payment.Domain;
namespace Payment.Domain.Tests
{
    /// <summary>
    /// Pruebas unitarias para el servicio de pagos.
    /// </summary>
    public class PaymentTests
    {
        [TestCase(1, 1000)]
        [TestCase(2, 2000)]
        [TestCase(3, 3000)]
        /// <summary>
        /// Verifica que el pago con tipos válidos retorna éxito.
        /// </summary>
        /// <param name="paymentType">Tipo de pago.</param>
        /// <param name="amount">Monto a pagar.</param>
        [TestCase(1, 1000)]
        [TestCase(2, 2000)]
        [TestCase(3, 3000)]
        public void GivenAValidPaymentTypeAndAmount_WhenProcessPayment_ResultIsSuccesful(int paymentType, double amount)
        {
            bool PaymentResult = new PaymentService().ProcessPayment(paymentType, amount);
            Assert.IsTrue(PaymentResult);
        }
        [TestCase(4, 4000)]
        /// <summary>
        /// Verifica que el pago con tipo inválido lanza una excepción.
        /// </summary>
        /// <param name="paymentType">Tipo de pago inválido.</param>
        /// <param name="amount">Monto a pagar.</param>
        [TestCase(4, 4000)]
        public void GivenAnUnknownPaymentTypeAndAmount_WhenProcessPayment_ResultIsError(int paymentType, double amount)
        {
            var ex = Assert.Throws<ArgumentException>(
                () => new PaymentService().ProcessPayment(paymentType, amount));
            Assert.That(ex.Message, Is.EqualTo("You Select an Invalid Payment Option"));
        }   
    }
}