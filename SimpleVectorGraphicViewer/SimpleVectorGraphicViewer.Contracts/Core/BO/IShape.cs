namespace SimpleVectorGraphicViewer.Contracts.Core.BO
{
    #region IShape
    /// <summary>
    /// Interface of Shape.
    /// </summary>
    public interface IShape
    {
        /// <summary>
        /// Gets or sets a value indicating whether the figure is filled with color.
        /// </summary>
        bool Filled { get; set; }
    }
    #endregion
}