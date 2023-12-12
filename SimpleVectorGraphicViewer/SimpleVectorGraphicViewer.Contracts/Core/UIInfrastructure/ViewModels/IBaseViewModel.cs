namespace SimpleVectorGraphicViewer.Contracts.Core.UIInfrastructure.ViewModels
{
    public interface IBaseViewModel : IDisposable
    {
        /// <summary>
        /// Gets or sets the error message associated with an operation or state.
        /// </summary>
        string? ErrorMessage { get; set; }
        /// <summary>
        /// Gets or sets the scale factor for the Canvas, ranging from 0 to 100.
        /// </summary>
        double Scale { get; set; }
        /// <summary>
        /// Stores current view model.
        /// </summary>
        IBaseViewModel? CurrentViewModel { get; }
    }
}