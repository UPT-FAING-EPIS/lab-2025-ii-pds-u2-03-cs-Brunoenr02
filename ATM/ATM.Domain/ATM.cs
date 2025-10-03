namespace ATM.Domain
{
    /// <summary>
    /// Representa un cajero automático que ejecuta comandos sobre cuentas.
    /// </summary>
    public class ATM
    {
        ICommand _command;
        /// <summary>
        /// Inicializa una nueva instancia de ATM con un comando específico.
        /// </summary>
        /// <param name="command">Comando a ejecutar.</param>
        public ATM(ICommand command)
        {
            _command = command;
        }
        /// <summary>
        /// Ejecuta la acción definida por el comando.
        /// </summary>
        public void Action()
        {
            _command.Execute();
        }
    }
}