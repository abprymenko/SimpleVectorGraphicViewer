namespace SimpleVectorGraphicViewer.Contracts.Managers.PresentationHandlers
{
    public interface IViewModelsState<T> where T : IDisposable
    {
        /// <summary>
        /// Stores information about the context state.
        /// </summary>
        T? State { get; set; }
        /// <summary>
        ///  Occurs when a <see cref="State"/> changes.
        /// </summary>
        event Action<T>? StateChanged;
        /// <summary>
        /// Changes the context to a new state.
        /// </summary>
        /// <param name="name">Context name.</param>
        void Handle(string name);
    }
}