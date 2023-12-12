namespace SimpleVectorGraphicViewer.Contracts.Core.BO.Settings
{
    public interface IBusQueueSetting
    {
        string QueueName { get; }
        bool IsEnabled { get; }
        Type[] Consumers { get; }
        ushort ThreadsCount { get; }
        int? SecondRateLimit { get; }
    }
}