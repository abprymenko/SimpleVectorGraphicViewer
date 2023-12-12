namespace SimpleVectorGraphicViewer.Contracts.UI.Views
{
    #region IMainWindow
    /// <summary>
    /// Interface of MainWindow.
    /// </summary>
    public interface IMainWindow : IDisposable
    {
        /// <summary>
        /// Shows the main window for the application.
        /// </summary>
        /// <returns></returns>
        bool? ShowDialog();
    }
    #endregion
}