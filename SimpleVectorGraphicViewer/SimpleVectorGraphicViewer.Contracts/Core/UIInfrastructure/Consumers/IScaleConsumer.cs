namespace SimpleVectorGraphicViewer.Contracts.Core.UIInfrastructure.Consumers
{
    #region Usings
    using MassTransit;
    using SimpleVectorGraphicViewer.Contracts.Core.BO.Messages.Commands;
    #endregion

    #region IScaleConsumer
    public interface IScaleConsumer : IConsumer<IScaleCommand>, IConsumer<IZoomCommand>
    {
    }
    #endregion
}