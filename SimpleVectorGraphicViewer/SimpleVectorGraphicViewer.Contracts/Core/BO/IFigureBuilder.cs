namespace SimpleVectorGraphicViewer.Contracts.Core.BO
{
    #region Usings
    using SimpleVectorGraphicViewer.Contracts.Core.UIInfrastructure.ViewModels;
    using SimpleVectorGraphicViewer.Contracts.Core.UIInfrastructure.Visitors;
    #endregion

    #region IFigureBuilder
    /// <summary>
    /// Interface of figure behavior.
    /// </summary>
    public interface IFigureBuilder
    {
        /// <summary>
        /// Creates a figure to display.
        /// </summary>
        /// <param name="visitor"><see cref="IDrawVisitor"/></param>
        /// <param name="viewModel"><see cref="IGraphicViewModel"/></param>
        void BuildFigure(IDrawVisitor visitor, IGraphicViewModel viewModel);
    }
    #endregion
}