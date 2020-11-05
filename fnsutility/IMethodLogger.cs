namespace FnsUtility
{
    /// <summary>
    /// Logging interface for recording requests and responses
    /// in the ClaimSubmissionLog table
    /// </summary>
    public interface IMethodLogger
    {
        /// <summary>
        /// Logs the web method request.
        /// </summary>
        /// <param name="request">The request as text.</param>
        /// <param name="rquId">The rquid.</param>
        /// <param name="instance">The database instance.</param>
        void LogRequest(string request, string rquId, string instance);

        /// <summary>
        /// Logs the response.
        /// </summary>
        /// <param name="response">The response as text.</param>
        /// <param name="rquId">The rquid.</param>
        /// <param name="instance">The database instance.</param>
        void LogResponse(string response, string rquId, string instance);

    }
}
