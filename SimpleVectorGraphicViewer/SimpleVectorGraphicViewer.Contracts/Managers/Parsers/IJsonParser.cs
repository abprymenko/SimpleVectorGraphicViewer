namespace SimpleVectorGraphicViewer.Contracts.Managers.Parsers
{
    #region Usings
    using SimpleVectorGraphicViewer.Contracts.Core.BO.Models;
    #endregion

    #region IJsonParser
    /// <summary>
    /// Interface of JsonParser.
    /// </summary>
    public interface IJsonParser
    {
        /// <summary>
        /// Parses the JSON data from a string. This method is intended for parsing JSON data.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="json"></param>
        /// <param name="typeName"></param>
        /// <returns></returns>
        IEnumerable<T>? ParseJson<T>(string json, string? typeName = nameof(IFigure)) where T : IFigure;
    }
    #endregion
}