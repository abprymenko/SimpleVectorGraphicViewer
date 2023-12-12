namespace SimpleVectorGraphicViewer.Contracts.Core.BO
{
    #region Usings
    using SimpleVectorGraphicViewer.Contracts.Managers.Visitors;
    #endregion

    #region IDeserializingProcess
    /// <summary>
    /// Interface of DeserializingProcess.
    /// </summary>
    public interface IExecuteDeserialize
    {
        /// <summary>
        /// Deserializes the JSON data and performs the necessary operations.
        /// </summary>
        /// <param name="visitor"><see cref="IJsonVisitor"/></param>
        /// <param name="json">The JSON data to be parsed.</param>
        /// <param name="type">The type of figure.</param>
        /// <returns></returns>
        IEnumerable<IFigureBuilder>? ExecuteDeserialize(IJsonVisitor visitor, string json, string? type);
    }
    #endregion
}