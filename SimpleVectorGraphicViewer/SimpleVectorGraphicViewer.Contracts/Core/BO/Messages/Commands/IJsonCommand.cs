namespace SimpleVectorGraphicViewer.Contracts.Core.BO.Messages.Commands
{
    public interface IJsonCommand : IMessageCommand
    {
        string? Json { get; set; }
    }
}