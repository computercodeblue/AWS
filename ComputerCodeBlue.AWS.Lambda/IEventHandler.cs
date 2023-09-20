using Amazon.Lambda.Core;

namespace ComputerCodeBlue.AWS.Lambda
{
    /// <summary>
    /// An interface that describes an handler for events with inputs of type <typeparamref name="TInput"/>.
    /// </summary>
    /// <typeparam name="TInput">The type of the incoming request.</typeparam>
    public interface IEventHandler<in TInput>
    {
        /// <summary>
        /// The method used to handle the incoming event.
        /// </summary>
        /// <param name="input">The incoming request.</param>
        /// <param name="context">A representation of the execution context.</param>
        Task HandleAsync(TInput? input, ILambdaContext context);
    }
}
