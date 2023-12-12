namespace SimpleVectorGraphicViewer.Contracts.Core.BO.Messages.Commands
{
    public interface IScaleCommand : IMessageCommand
    {
        double Scale { get; set; }
    }
}