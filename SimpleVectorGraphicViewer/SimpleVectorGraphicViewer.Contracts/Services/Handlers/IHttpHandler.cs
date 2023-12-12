namespace SimpleVectorGraphicViewer.Contracts.Services.Handlers
{
    #region Usings
    using System.Net;
    #endregion

    #region IHttpHandler
    /// <summary>
    /// Interface for handling HTTP requests in the application.
    /// </summary>
    public interface IHttpHandler
    {
        /// <summary>
        /// Sends an HTTP request with the specified method, URL, headers, and (optional) JSON content.
        /// </summary>
        /// <param name="method">HTTP method of the request (GET, POST, PUT, DELETE, etc.).</param>
        /// <param name="url">URL to which the request will be sent.</param>
        /// <param name="headers">HTTP request headers as a dictionary (key-value pairs).</param>
        /// <param name="jsonContent">JSON content of the request (optional).</param>
        /// <returns><see cref="HttpStatusCode"/> representing the status code of the server's response.</returns>
        Task<HttpStatusCode> SendRequest(HttpMethod method,
                                         string url,
                                         Dictionary<string, string> headers,
                                         string? jsonContent = null);
    }
    #endregion
}