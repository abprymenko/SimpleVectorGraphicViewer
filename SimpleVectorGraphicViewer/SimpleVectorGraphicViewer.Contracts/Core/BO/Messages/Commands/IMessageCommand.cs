namespace SimpleVectorGraphicViewer.Contracts.Core.BO.Messages.Commands
{
    #region IMessageCommand
    /// <summary>
    /// Represents a message command interface for specifying the name of the message queue.
    /// </summary>
    public interface IMessageCommand
    {
        /// <summary>
        /// Gets the name of the message queue to which the command should be sent.
        /// </summary>
        string MessageQueueName { get; }
    }
    #endregion
}