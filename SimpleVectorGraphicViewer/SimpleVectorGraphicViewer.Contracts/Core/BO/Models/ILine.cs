namespace SimpleVectorGraphicViewer.Contracts.Core.BO.Models
{
    #region ILine
    /// <summary>
    /// Interface of Line.
    /// </summary>
    public interface ILine : IFigure, ICouplePoints, IFigureBuilder, IExecuteDeserialize
    {
    }
    #endregion
}