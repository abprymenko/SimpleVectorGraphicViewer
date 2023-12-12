namespace SimpleVectorGraphicViewer.Contracts.Core.UIInfrastructure.Consumers
{
    #region Usings
    using MassTransit;
    using SimpleVectorGraphicViewer.Contracts.Core.BO.Messages.Commands;
    #endregion

    #region IJsonConsumer
    public interface IJsonConsumer : IConsumer<IJsonCommand>
    {
    }
    #endregion
}