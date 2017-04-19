using Google.Protobuf;
using Grpc.Core;
using System;
using System.Threading;
using System.Threading.Tasks;

// This will be in a common library (possibly GAX), not API-specific.
namespace Google.Longrunning
{
    /// <summary>
    /// A long-running operation with an associated client, and which knows the expected response type.
    /// </summary>
    /// <remarks>
    /// For simplicity, no methods on this type modify the proto message. Instead, to get up-to-date
    /// information you can use Refresh to obtain a new instance.
    /// </remarks>
    /// <typeparam name="T"></typeparam>
    public class Operation<T> where T : IMessage<T>, new()
    {
        /// <summary>
        /// The protobuf message associated with the long-running operation, containing the name (for
        /// further retrieval) and any error/result already computed. This should not be mutated.
        /// </summary>
        public Operation Proto { get; }
        public OperationsClient Client { get; }

        public string Name => Proto.Name;
        public bool Done => Proto.Done;

        public T Result
        {
            get
            {
                switch (Proto.ResultCase)
                {
                    case Operation.ResultOneofCase.Error:
                        var error = Proto.Error;
                        // TODO: Check this conversion.
                        throw new RpcException(new Status((StatusCode) error.Code, error.Message));
                    case Operation.ResultOneofCase.Response:
                        return Proto.Response.Unpack<T>();
                    default:
                        throw new InvalidOperationException();
                }
            }
        }

        /// <summary>
        /// Polls the operation until it is complete, returning the body of the result
        /// or throwing an exception representing any error.
        /// </summary>
        public T Poll(PollSettings pollSettings = null)
        {
            var current = this;
            while (!current.Done) // TODO: Use pollSettings
            {
                Thread.Sleep(1000); // TODO: Use pollSettings
                current = Refresh();
            }
            return current.Result;
        }

        public async Task<T> PollAsync(PollSettings pollSettings = null)
        {
            var current = this;
            while (!current.Done) // TODO: Use pollSettings
            {
                Thread.Sleep(1000); // TODO: Use pollSettings
                current = await RefreshAsync();
            }
            return current.Result;
        }

        /// <summary>
        /// Returns a new instance reflecting the most recent state of the operation.
        /// </summary>
        public Operation<T> Refresh()
        {
            var operation = Client.GetOperation(Name);
            return new Operation<T>(operation, Client);
        }

        public async Task<Operation<T>> RefreshAsync()
        {
            var operation = await Client.GetOperationAsync(Name);
            return new Operation<T>(operation, Client);
        }

        public Operation(Operation proto, OperationsClient client)
        {
            Proto = proto;
            Client = client;
        }
    }
}
