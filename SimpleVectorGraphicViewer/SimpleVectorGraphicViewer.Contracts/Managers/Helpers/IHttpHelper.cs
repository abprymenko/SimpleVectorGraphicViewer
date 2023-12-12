namespace SimpleVectorGraphicViewer.Contracts.Managers.Helpers
{
    #region Usings
    using System.Net;
    #endregion

    #region IHttpHelper
    /// <summary>
    /// Interface for handling HTTP requests with additional RabbitMQ-related functionality.
    /// </summary>
    public interface IHttpHelper
    {
        /// <summary>
        /// Creates a RabbitMQ virtual host with the specified configurations.
        /// </summary>
        /// <remarks>
        /// This method sends an HTTP PUT request to create a RabbitMQ virtual host based on the provided configurations.
        /// </remarks>
        /// <returns>
        /// The <see cref="HttpStatusCode"/> indicating the success or failure of the request.
        /// </returns>
        Task<HttpStatusCode> CreateRMQVirtualHostAsync();
        /// <summary>
        /// Deletes a RabbitMQ virtual host with the specified configurations.
        /// </summary>
        /// <remarks>
        /// This method sends an HTTP DELETE request to delete a RabbitMQ virtual host based on the provided configurations.
        /// </remarks>
        /// <returns>
        /// The <see cref="HttpStatusCode"/> indicating the success or failure of the request.
        /// </returns>
        Task<HttpStatusCode> DeleteRMQVirtualHostAsync();
        /// <summary>
        /// Sets RabbitMQ virtual host permissions for the specified user.
        /// </summary>
        /// <remarks>
        /// This method sends an HTTP PUT request to RabbitMQ Management API to set permissions for a specific virtual host.
        /// </remarks>
        /// <returns>
        /// The <see cref="HttpStatusCode"/> indicating the success or failure of the request.
        /// </returns>
        Task<HttpStatusCode> SetPermissionsRMQVirtualHostAsync();
        /// <summary>
        /// Generates a Basic Authentication token using the provided username and password.
        /// </summary>
        /// <param name="userName">The username for authentication.</param>
        /// <param name="password">The password for authentication.</param>
        /// <returns>The Basic Authentication token.</returns>
        /// <exception cref="ArgumentNullException"/>
        /// <remarks>
        /// Thrown when either <paramref name="userName"/> or <paramref name="password"/> is null.
        /// </remarks>
        string GetBasicAuthHeader(string? userName, string? password);
    }
    #endregion
}