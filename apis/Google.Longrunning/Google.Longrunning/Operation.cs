// Copyright 2016 Google Inc. All Rights Reserved.
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
//     http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.

using Google.Api.Gax;
using Google.Protobuf;
using Grpc.Core;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace Google.Longrunning
{
    /// <summary>
    /// A long-running operation with an associated client, and which knows the expected response type.
    /// </summary>
    /// <remarks>
    /// For simplicity, no methods on this type modify the proto message. Instead, to get up-to-date
    /// information you can use Refresh to obtain a new instance.
    /// </remarks>
    /// <typeparam name="T">The response message type.</typeparam>
    public class Operation<T> where T : IMessage<T>, new()
    {
        /// <summary>
        /// The protobuf message associated with the long-running operation, containing the name (for
        /// further retrieval) and any error/result already computed. This should not be mutated.
        /// </summary>
        public Operation Proto { get; }
        public OperationsClient Client { get; }

        public Operation(Operation proto, OperationsClient client)
        {
            Proto = GaxPreconditions.CheckNotNull(proto, nameof(proto));
            Client = GaxPreconditions.CheckNotNull(client, nameof(proto));
        }

        /// <summary>
        /// Returns the name of the operation, which can be persisted and used to poll for the latest
        /// results at a later time or in a different program.
        /// </summary>
        /// <remarks>
        /// Only the in-memory representation of the operation (this object) is consulted for its state.
        /// </remarks>
        public string Name => Proto.Name;

        /// <summary>
        /// Whether the operation has completed, where "complete" can include "failed".
        /// </summary>
        /// <remarks>
        /// Only the in-memory representation of the operation (this object) is consulted for its state.
        /// </remarks>
        public bool IsCompleted => Proto.Done;

        /// <summary>
        /// Whether the operation has completed with a failure.
        /// </summary>
        public bool IsFaulted => Proto.ResultCase == Operation.ResultOneofCase.Error;

        // TODO: An Exception property? Would probably want to use a Lazy<OperationFailedException> to avoid creating
        // a new one each time. Hmm.

        /// <summary>
        /// Retrieves the result of the operation, throwing an exception if the operation failed or hasn't completed.
        /// </summary>
        /// <remarks>
        /// Only the in-memory representation of the operation (this object) is consulted for its state.
        /// </remarks>
        /// <exception cref="OperationFailedException">The operation completed with an error.</exception>
        /// <exception cref="InvalidOperationException">The operation has not completed yet.</exception>
        public T Result
        {
            get
            {
                switch (Proto.ResultCase)
                {
                    case Operation.ResultOneofCase.Error:
                        var error = Proto.Error;
                        // TODO: Construct a new exception type?
                        throw new RpcException(new Status((StatusCode) error.Code, error.Message));
                    case Operation.ResultOneofCase.Response:
                        return Proto.Response.Unpack<T>();
                    default:
                        throw new InvalidOperationException();
                }
            }
        }

        /// <summary>
        /// Polls the operation until it is complete, returning the completed operation.
        /// </summary>
        /// <remarks>
        /// If this object represents a completed operation
        /// </remarks>
        public Operation<T> PollUntilCompleted(PollSettings pollSettings = null)
        {
            var current = this;
            while (!current.IsCompleted) // TODO: Use pollSettings
            {
                Thread.Sleep(1000); // TODO: Use pollSettings
                current = Poll();
            }
            return current;
        }

        public async Task<Operation<T>> PollUntilCompletedAsync(PollSettings pollSettings = null)
        {
            var current = this;
            while (!current.IsCompleted) // TODO: Use pollSettings
            {
                await Task.Delay(1000).ConfigureAwait(false); // TODO: Use pollSettings
                current = await PollAsync().ConfigureAwait(false);
            }
            return current;
        }

        /// <summary>
        /// Returns a new instance reflecting the most recent state of the operation.
        /// </summary>
        public Operation<T> Poll(CallSettings callSettings = null)
        {
            var operation = Client.GetOperation(Name, callSettings);
            return new Operation<T>(operation, Client);
        }

        public async Task<Operation<T>> PollAsync(CallSettings callSettings = null)
        {
            var operation = await Client.GetOperationAsync(Name, callSettings).ConfigureAwait(false);
            return new Operation<T>(operation, Client);
        }

        public async Task<Operation<T>> PollAsync(CancellationToken cancellationToken)
        {
            var operation = await Client.GetOperationAsync(Name, cancellationToken).ConfigureAwait(false);
            return new Operation<T>(operation, Client);
        }

        public void Cancel(CallSettings callSettings = null)
        {
            Client.CancelOperation(Name, callSettings);
        }

        public Task CancelAsync(CallSettings callSettings = null) =>
            Client.CancelOperationAsync(Name, callSettings);

        // Be careful! The cancellation token is for the cancel operation, so you can cancel cancelling...
        public Task CancelAsync(CancellationToken cancellationToken) =>
            Client.CancelOperationAsync(Name, cancellationToken);

        /// <summary>
        /// Returns a new instance reflecting the most recent state of the operation.
        /// </summary>
        public static Operation<T> PollFromName(string name, OperationsClient client, CallSettings callSettings = null)
        {
            // TODO: Call options?
            var operation = client.GetOperation(name, callSettings);
            return new Operation<T>(operation, client);
        }

        public static async Task<Operation<T>> PollFromNameAsync(string name, OperationsClient client, CallSettings callSettings = null)
        {
            var operation = await client.GetOperationAsync(name, callSettings).ConfigureAwait(false);
            return new Operation<T>(operation, client);
        }
    }
}
