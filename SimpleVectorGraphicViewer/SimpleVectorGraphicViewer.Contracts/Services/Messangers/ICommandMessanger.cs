namespace SimpleVectorGraphicViewer.Contracts.Services.Messangers
{
    #region Usings
    using SimpleVectorGraphicViewer.Contracts.Core.BO.Messages.Commands;
    #endregion
    public interface ICommandMessanger
    {
        Task SendAsync<T>(T command) where T : class, IMessageCommand;
    }
}