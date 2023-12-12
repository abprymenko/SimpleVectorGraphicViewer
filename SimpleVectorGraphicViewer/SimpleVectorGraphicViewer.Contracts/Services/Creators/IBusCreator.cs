namespace SimpleVectorGraphicViewer.Contracts.Services.Creators
{
    #region Usings
    using MassTransit;
    using SimpleVectorGraphicViewer.Contracts.Core.BO.Settings;
    #endregion
    public interface IBusCreator
    {
        IBusControl CreateBusControl(IEnumerable<IBusQueueSetting> settings);
    }
}