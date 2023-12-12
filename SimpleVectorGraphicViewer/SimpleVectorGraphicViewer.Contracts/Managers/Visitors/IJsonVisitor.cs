namespace SimpleVectorGraphicViewer.Contracts.Managers.Visitors
{
    #region Usings
    using SimpleVectorGraphicViewer.Contracts.Core.BO;
    using SimpleVectorGraphicViewer.Contracts.Core.BO.Models;
    #endregion

    #region IJsonVisitor
    /// <summary>
    /// Interface of JsonVisitor.
    /// </summary>
    public interface IJsonVisitor
    {
        /// <summary>
        /// Visits <see cref="ICircle"/> objects or elements containing JSON data.
        /// </summary>
        /// <param name="circle"></param>
        /// <param name="json"></param>
        /// <param name="type"></param>
        /// <returns><see cref="IFigureBuilder"/></returns>
        IEnumerable<IFigureBuilder>? VisitJson(ICircle circle, string json, string? type);
        /// <summary>
        /// Visits <see cref="ILine"/> objects or elements containing JSON data.
        /// </summary>
        /// <param name="circle"></param>
        /// <param name="json"></param>
        /// <param name="type"></param>
        /// <returns><see cref="IFigureBuilder"/></returns>
        IEnumerable<IFigureBuilder>? VisitJson(ILine line, string json, string? type);
        /// <summary>
        /// Visits <see cref="ITriangle"/> objects or elements containing JSON data.
        /// </summary>
        /// <param name="circle"></param>
        /// <param name="json"></param>
        /// <param name="type"></param>
        /// <returns><see cref="IFigureBuilder"/></returns>
        IEnumerable<IFigureBuilder>? VisitJson(ITriangle triangle, string json, string? type);
    }
    #endregion
}