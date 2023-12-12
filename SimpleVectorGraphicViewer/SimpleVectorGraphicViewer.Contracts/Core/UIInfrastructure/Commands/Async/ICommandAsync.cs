namespace SimpleVectorGraphicViewer.Contracts.Core.UIInfrastructure.Commands.Async
{
    #region Usings
    using System.Windows.Input;
    #endregion

    #region IAsyncCommand
    /// <summary>
    /// Interface of AsyncCommand
    /// </summary>
    public interface ICommandAsync : ICommand
    {
        /// <summary>
        /// Gets a value indicating whether the command is currently executing an operation.
        /// </summary>
        bool IsExecuting { get; set; }
        /// <summary>
        /// Asynchronously executes an operation and returns a task representing the operation.
        /// </summary>
        /// <param name="parameter"></param>
        /// <returns>A task representing the asynchronous operation.</returns>
        Task ExecuteAsync(object? parameter);
        /// <summary>
        /// Raises the event that indicates a change in the ability to execute the command.
        /// </summary>
        void OnCanExecuteChanged();
    }
    #endregion
}