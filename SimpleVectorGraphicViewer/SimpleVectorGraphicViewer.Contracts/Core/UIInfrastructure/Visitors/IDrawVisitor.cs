namespace SimpleVectorGraphicViewer.Contracts.Core.UIInfrastructure.Visitors
{
    #region Usings
    using SimpleVectorGraphicViewer.Contracts.Core.BO.Models;
    using SimpleVectorGraphicViewer.Contracts.Core.UIInfrastructure.ViewModels;
    #endregion

    #region IDrawVisitor
    /// <summary>
    /// Interface of DrawVisitor.
    /// </summary>
    public interface IDrawVisitor
    {
        /// <summary>
        /// Draws <see cref="ILine"/> as part of a visitor pattern.
        /// </summary>
        /// <param name="line"></param>
        /// <param name="viewModel"></param>
        void DrawFigure(ILine line, IGraphicViewModel viewModel);
        /// <summary>
        /// Draws <see cref="ICircle"/> as part of a visitor pattern.
        /// </summary>
        /// <param name="line"></param>
        /// <param name="viewModel"></param>
        void DrawFigure(ICircle circle, IGraphicViewModel viewModel);
        /// <summary>
        /// Draws <see cref="ITriangle"/> as part of a visitor pattern.
        /// </summary>
        /// <param name="line"></param>
        /// <param name="viewModel"></param>
        void DrawFigure(ITriangle triangle, IGraphicViewModel viewModel);
    }
    #endregion
}