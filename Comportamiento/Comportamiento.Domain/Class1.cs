using System.Collections.Generic;

namespace Comportamiento.Domain
{
	/// <summary>
	/// Interfaz para los observadores.
	/// </summary>
	public interface IObserver
	{
		void Update(string message);
	}

	/// <summary>
	/// Interfaz para el sujeto observado.
	/// </summary>
	public interface ISubject
	{
		void Attach(IObserver observer);
		void Detach(IObserver observer);
		void Notify(string message);
	}

	/// <summary>
	/// Implementación concreta del sujeto observado.
	/// </summary>
	public class ConcreteSubject : ISubject
	{
		private readonly List<IObserver> observers = new();

		public void Attach(IObserver observer)
		{
			observers.Add(observer);
		}

		public void Detach(IObserver observer)
		{
			observers.Remove(observer);
		}

		public void Notify(string message)
		{
			foreach (var observer in observers)
			{
				observer.Update(message);
			}
		}
	}

	/// <summary>
	/// Implementación concreta de un observador.
	/// </summary>
	public class ConcreteObserver : IObserver
	{
		public string ObserverState { get; private set; }

		public void Update(string message)
		{
			ObserverState = message;
		}
	}
}
