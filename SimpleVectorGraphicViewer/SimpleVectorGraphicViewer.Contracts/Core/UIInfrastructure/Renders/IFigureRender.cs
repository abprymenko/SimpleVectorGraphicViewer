namespace SimpleVectorGraphicViewer.Contracts.Core.UIInfrastructure.Renders
{
    #region Usings
    using SimpleVectorGraphicViewer.Contracts.Core.UIInfrastructure.ViewModels;
    #endregion

    #region IFigureRender
    /// <summary>
    /// Interface of FigureRender.
    /// </summary>
    public interface IFigureRender
    {
        /// <summary>
        /// Adds a figure to the list for later rendering on a Canvas.
        /// </summary>
        /// <param name="viewModel"></param>
        void AddFigure(IGraphicViewModel viewModel);
    }
    #endregion
}