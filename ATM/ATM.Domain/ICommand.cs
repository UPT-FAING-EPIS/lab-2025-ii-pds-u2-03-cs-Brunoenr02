namespace ATM.Domain
{
    /// <summary>
    /// Interfaz para comandos ejecutables en el patrón Command.
    /// </summary>
    public interface ICommand
    {
        /// <summary>
        /// Ejecuta la acción definida por el comando.
        /// </summary>
        void Execute();
    }
}