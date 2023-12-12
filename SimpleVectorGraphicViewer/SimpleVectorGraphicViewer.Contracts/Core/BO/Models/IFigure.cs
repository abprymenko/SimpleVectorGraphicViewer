namespace SimpleVectorGraphicViewer.Contracts.Core.BO.Models
{
    #region IFigure
    /// <summary>
    /// Interface of Figure.
    /// </summary>
    public interface IFigure
    {
        /// <summary>
        /// Figure type.
        /// </summary>
        string? Type { get; set; }
        /// <summary>
        /// Figure сolor.
        /// </summary>
        string? Color { get; set; }
    }
    #endregion
}