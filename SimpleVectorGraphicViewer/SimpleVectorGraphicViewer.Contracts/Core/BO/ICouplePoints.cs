namespace SimpleVectorGraphicViewer.Contracts.Core.BO
{
    #region ICouplePoints
    /// <summary>
    /// An interface representing a pair of points.
    /// </summary>
    public interface ICouplePoints
    {
        /// <summary>
        /// Point A.
        /// </summary>
        string? A { get; set; }
        /// <summary>
        /// Point B.
        /// </summary>
        string? B { get; set; }
    }
    #endregion
}