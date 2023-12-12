namespace SimpleVectorGraphicViewer.Contracts.Core.UIInfrastructure.ViewModels
{
    #region Usings
    using SimpleVectorGraphicViewer.Contracts.Core.BO;
    #endregion

    #region IGraphicViewModel
    /// <summary>
    /// Interface of GraphicViewModel.
    /// </summary>
    public interface IGraphicViewModel : IBaseViewModel
    {
        /// <summary>
        /// Handles the size change event for the Canvas, updating its layout or content as needed.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void OnCanvasSizeChanged(object sender, EventArgs e);
        /// <summary>
        /// Gets or sets a collection of UI elements that are part of the Canvas's content.
        /// </summary>
        IEnumerable<IFigureBuilder>? UIElements { get; set; }
        /// <summary>
        /// Gets or sets the Canvas element containing UI elements, intended for sharing with other parts of the project.
        /// </summary>
        object? Canvas { get; set; }
        /// <summary>
        /// Json data.
        /// </summary>
        string? Json { get; set; }
        double CanvasWidth {  get; set; }
        double CanvasHeight {  get; set; }
        object ViewPort {  get; set; }
    }
    #endregion
}