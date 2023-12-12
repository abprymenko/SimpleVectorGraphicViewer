namespace SimpleVectorGraphicViewer.Contracts.Core.UIInfrastructure.ViewModels
{
    #region Usings
    using SimpleVectorGraphicViewer.Contracts.Core.UIInfrastructure.Commands.Async;
    #endregion

    #region Interface of MainWindowViewModel
    public interface IMainWindowViewModel : IBaseViewModel
    {
        /// <summary>
        /// Reduces the size of figures.
        /// </summary>
        IZoomOutCommandAsync ZoomOutCommandAsync { get; }
        /// <summary>
        /// Increases the size of figures.
        /// </summary>
        IZoomInCommandAsync ZoomInCommandAsync { get; }
        /// <summary>
        /// Downloads a JSON file from the local environment.
        /// </summary>
        ILoadJsonCommandAsync LoadJsonCommandAsync { get; }
        /// <summary>
        /// Changes the size of figures.
        /// </summary>
        ISetScaleCommandAsync SetScaleCommandAsync { get; }
        /// <summary>
        /// Removes the queue in Rabbit MQ broker messanger.
        /// </summary>
        IDeleteQueueCommandAsync DeleteQueueCommandAsync { get; }
    }
    #endregion
}