namespace SimpleVectorGraphicViewer.Contracts.Core.BO.Messages.Commands
{
    public interface IZoomCommand : IMessageCommand
    {
        double Increment { get; set; }
    }
}