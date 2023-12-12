namespace SimpleVectorGraphicViewer.Contracts.Managers.Deserializers
{
    #region Usings
    using SimpleVectorGraphicViewer.Contracts.Core.UIInfrastructure.ViewModels;
    #endregion

    #region IJsonDeserializer
    /// <summary>
    /// Interface for classes that implement the JSON data deserialization process.
    /// </summary>
    public interface IJsonDeserializer
    {
        /// <summary>
        /// Method for deserializing JSON data and populating the relevant field of an object that implements IMainWindowViewModel.
        /// </summary>
        /// <param name="viewModel">An object that implements IMainWindowViewModel and contains a field for deserializing JSON data.</param>
        void Deserialize(IGraphicViewModel viewModel);
    }
    #endregion
}