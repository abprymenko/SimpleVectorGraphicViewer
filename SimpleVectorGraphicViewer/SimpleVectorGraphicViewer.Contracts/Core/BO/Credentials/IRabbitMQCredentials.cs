namespace SimpleVectorGraphicViewer.Contracts.Core.BO.Credentials
{
    public interface IRabbitMQCredentials
    {
        string? UserName { get; }
        string? Password { get; }
        string? UriString { get; }
        string? InstanceId { get; }
        string? Host { get; }
        int? Port { get; }
        string? VHost { get; }
        string? Permissions { get; }
    }
}