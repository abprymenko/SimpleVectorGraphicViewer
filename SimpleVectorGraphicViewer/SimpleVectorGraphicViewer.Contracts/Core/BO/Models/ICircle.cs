namespace SimpleVectorGraphicViewer.Contracts.Core.BO.Models
{
    #region ICircle
    /// <summary>
    /// Interface of Circle.
    /// </summary>
    public interface ICircle : IFigure, IShape, IFigureBuilder, IExecuteDeserialize
    {
        /// <summary>
        /// Centre: the point equidistant from all points on the circle.
        /// </summary>
        string? Center { get; set; }
        /// <summary>
        /// The radius of the circle.
        /// </summary>
        double Radius { get; set; }
    }
    #endregion
}