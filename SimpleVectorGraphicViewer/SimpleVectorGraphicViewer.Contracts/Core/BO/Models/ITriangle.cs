namespace SimpleVectorGraphicViewer.Contracts.Core.BO.Models
{
    #region ITriangle
    /// <summary>
    /// Interface of Triangle.
    /// </summary>
    public interface ITriangle : IFigure, ICouplePoints, IShape, IFigureBuilder, IExecuteDeserialize
    {
        /// <summary>
        /// Point C.
        /// </summary>
        string? C { get; set; }
    }
    #endregion
}
