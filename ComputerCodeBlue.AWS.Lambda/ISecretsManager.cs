namespace ComputerCodeBlue.AWS.Lambda
{
    /// <summary>
    /// An interface that describes methods for retrieving secreats of type <typeparamref name="TOutput"/>.
    /// </summary>
    /// <typeparam name="TOutput">The type of the secret.</typeparam>
    public interface ISecretsManager<TOutput>
    {
        /// <summary>
        /// The method used to handle the incoming event.
        /// </summary>
        /// <param name="secretName">The name of the secret to retrieve.</param>
        /// <param name="region">The AWS region for the secret.</param>
        Task<TOutput?> GetSecretAsync(string secretName, string region);
    }
}
