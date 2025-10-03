using NUnit.Framework;
using Comportamiento.Domain;

namespace Comportamiento.Domain.Tests
{
    public class ObserverTests
    {
        [Test]
        public void Observer_Receives_Notification()
        {
            var subject = new ConcreteSubject();
            var observer = new ConcreteObserver();
            subject.Attach(observer);
            subject.Notify("Mensaje de prueba");
            Assert.AreEqual("Mensaje de prueba", observer.ObserverState);
        }

        [Test]
        public void Observer_Detach_DoesNotReceiveNotification()
        {
            var subject = new ConcreteSubject();
            var observer = new ConcreteObserver();
            subject.Attach(observer);
            subject.Notify("Primera notificación");
            subject.Detach(observer);
            subject.Notify("Segunda notificación");
            Assert.AreEqual("Primera notificación", observer.ObserverState);
        }
    }
}