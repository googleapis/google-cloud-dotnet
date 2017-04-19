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
using Google.Api.Gax.Grpc;
using Google.Protobuf;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace Google.LongRunning
{
    /// <summary>
    /// A long-running operation with an associated client, and which knows the expected response type.
    /// </summary>
    /// <remarks>
    /// For simplicity, no methods on this type modify the proto message. Instead, to get up-to-date
    /// information you can use Refresh to obtain a new instance.
    /// </remarks>
    /// <typeparam name="TResponse">The response message type.</typeparam>
    /// <typeparam name="TMetadata">The metata message type.</typeparam>
    public sealed class Operation<TResponse, TMetadata>
        where TResponse : IMessage<TResponse>, new()
        where TMetadata : class, IMessage<TMetadata>, new()
    {
        private static readonly PollSettings s_defaultPollSettings = new PollSettings(Expiration.None, TimeSpan.FromSeconds(10));

        /// <summary>
        /// The protobuf message associated with the long-running operation, containing the name (for
        /// further retrieval) and any error/result already computed. This should not be mutated.
        /// </summary>
        public Operation RpcMessage { get; }

        /// <summary>
        /// The client to use when making RPCs.
        /// </summary>
        public OperationsClient Client { get; }

        private readonly Lazy<OperationFailedException> _lazyException;

        /// <summary>
        /// Constructs a new instance from the given RPC message.
        /// </summary>
        /// <param name="rpcMessage">The RPC message describing the operation. Must not be null.</param>
        /// <param name="client">The client to use for further calls. Must not be null.</param>
        public Operation(Operation rpcMessage, OperationsClient client)
        {
            RpcMessage = GaxPreconditions.CheckNotNull(rpcMessage, nameof(rpcMessage));
            Client = GaxPreconditions.CheckNotNull(client, nameof(rpcMessage));
            _lazyException = new Lazy<OperationFailedException>(
                () => RpcMessage.Error == null ? null : new OperationFailedException(RpcMessage),
                LazyThreadSafetyMode.ExecutionAndPublication);
        }

        /// <summary>
        /// Returns the name of the operation, which can be persisted and used to poll for the latest
        /// results at a later time or in a different program.
        /// </summary>
        /// <remarks>
        /// Only the in-memory representation of the operation (this object) is consulted for its state.
        /// </remarks>
        public string Name => RpcMessage.Name;

        // TODO: Use ResultCase instead? It's slightly odd that we have both Done and ResultCase,
        // but we could at least ignore Done entirely in this code...

        /// <summary>
        /// Whether the operation has completed, where "complete" can include "failed".
        /// </summary>
        /// <remarks>
        /// Only the in-memory representation of the operation (this object) is consulted for its state.
        /// </remarks>
        public bool IsCompleted => RpcMessage.Done;

        /// <summary>
        /// Whether the operation has completed with a failure.
        /// </summary>
        public bool IsFaulted => RpcMessage.ResultCase == Operation.ResultOneofCase.Error;

        /// <summary>
        /// The error associated with the operation, as an <see cref="OperationFailedException"/>, or <c>null</c>
        /// if the operation is not in an error state (either because it completed successfully, or because it
        /// has not yet completed).
        /// </summary>
        /// <remarks>
        /// Only the in-memory representation of the operation (this object) is consulted for its state.
        /// </remarks>
        public OperationFailedException Exception => _lazyException.Value;

        /// <summary>
        /// Retrieves the metadata associated with this operation, or <c>null</c> if there is no
        /// metadata in the underlying response message.
        /// </summary>
        public TMetadata Metadata => RpcMessage.Metadata?.Unpack<TMetadata>();

        /// <summary>
        /// Retrieves the result of the operation, throwing an exception if the operation failed or hasn't completed.
        /// Unlike <see cref="Task{T}.Result"/>, this does not block.
        /// </summary>
        /// <remarks>
        /// Only the in-memory representation of the operation (this object) is consulted for its state.
        /// </remarks>
        /// <exception cref="OperationFailedException">The operation completed with an error.</exception>
        /// <exception cref="InvalidOperationException">The operation has not completed yet.</exception>
        public TResponse Result
        {
            get
            {
                switch (RpcMessage.ResultCase)
                {
                    case Operation.ResultOneofCase.Error:
                        throw Exception;
                    case Operation.ResultOneofCase.Response:
                        return RpcMessage.Response.Unpack<TResponse>();
                    default:
                        throw new InvalidOperationException();
                }
            }
        }

        /// <summary>
        /// Executes the given callback with the metadata in the RPC message
        /// if both the callback and the metadata are non-null.
        /// </summary>
        private void MaybeFireCallback(Action<TMetadata> metadataCallback)
        {
            if (metadataCallback != null && RpcMessage.Metadata != null)
            {
                metadataCallback(Metadata);
            }
        }

        /// <summary>
        /// Polls the operation until it is complete, returning the completed operation.
        /// </summary>
        /// <remarks>
        /// If this object already represents a completed operation, it is returned immediately,
        /// with no further RPCs.
        /// </remarks>
        /// <param name="pollSettings">The settings to use for repeated polling, or null
        /// to use the default poll settings (poll once every 10 seconds, forever).</param>
        /// <param name="callSettings">The call settings to apply on each call, or null for default settings.</param>
        /// <param name="metadataCallback">The callback to invoke whenever a polled result contains metadata, or null
        /// for no callback.</param>
        /// <returns>The completed operation, which can then be checked for errors or a result.</returns>
        public Operation<TResponse, TMetadata> PollUntilCompleted(
            PollSettings pollSettings = null,
            CallSettings callSettings = null,
            Action<TMetadata> metadataCallback = null)
        {
            if (IsCompleted)
            {
                return this;
            }
            callSettings = Client.GetEffectiveCallSettingsForGetOperation(callSettings);

            Func<DateTime?, Operation<TResponse, TMetadata>> pollAction =
                deadline =>
                {
                    var result = PollOnce(callSettings.WithEarlierDeadline(deadline, Client.Clock));
                    result.MaybeFireCallback(metadataCallback);
                    return result;
                };

            return Polling.PollRepeatedly(
                pollAction, o => o.IsCompleted,
                Client.Clock, Client.Scheduler, pollSettings ?? s_defaultPollSettings,
                callSettings?.CancellationToken ?? CancellationToken.None);
        }

        /// <summary>
        /// Asynchronously polls the operation until it is complete, returning the completed operation.
        /// </summary>
        /// <remarks>
        /// If this object already represents a completed operation, it is returned immediately,
        /// with no further RPCs.
        /// </remarks>
        /// <param name="pollSettings">The settings to use for repeated polling, or null
        /// to use the default poll settings (poll once every 10 seconds, forever).</param>
        /// <param name="callSettings">The call settings to apply on each call, or null for default settings.</param>
        /// <param name="metadataCallback">The callback to invoke whenever a polled result contains metadata, or null
        /// for no callback.</param>
        /// <returns>The completed operation, which can then be checked for errors or a result.</returns>
        public Task<Operation<TResponse, TMetadata>> PollUntilCompletedAsync(
            PollSettings pollSettings = null,
            CallSettings callSettings = null,
            Action<TMetadata> metadataCallback = null)
        {
            if (IsCompleted)
            {
                return Task.FromResult(this);
            }
            callSettings = Client.GetEffectiveCallSettingsForGetOperation(callSettings);
            Func<DateTime?, Task<Operation<TResponse, TMetadata>>> pollAction =
                async deadline =>
                {
                    var result = await PollOnceAsync(callSettings.WithEarlierDeadline(deadline, Client.Clock)).ConfigureAwait(false);
                    result.MaybeFireCallback(metadataCallback);
                    return result;
                };
            return Polling.PollRepeatedlyAsync(
                pollAction, o => o.IsCompleted,
                Client.Clock, Client.Scheduler, pollSettings ?? s_defaultPollSettings,
                callSettings?.CancellationToken ?? CancellationToken.None);
        }

        /// <summary>
        /// Returns a new instance reflecting the most recent state of the operation.
        /// </summary>
        /// <param name="callSettings">Any overriding call settings to apply to the RPC.</param>
        /// <returns>The most recent state of the operation, or a reference to the same
        /// object if the operation has already completed.</returns>
        public Operation<TResponse, TMetadata> PollOnce(CallSettings callSettings = null)
            => IsCompleted ? this : PollOnceFromName(Name, Client, callSettings);

        /// <summary>
        /// Asynchronously returns a new instance reflecting the most recent state of the operation.
        /// </summary>
        /// <param name="callSettings">Any overriding call settings to apply to the RPC.</param>
        /// <returns>A task representing the asynchronous poll operation. The result of the task is 
        /// the most recent state of the operation, or a reference to the same
        /// object if the operation has already completed.</returns>
        public Task<Operation<TResponse, TMetadata>> PollOnceAsync(CallSettings callSettings = null) =>
            IsCompleted ? Task.FromResult(this) : PollOnceFromNameAsync(Name, Client, callSettings);

        /// <summary>
        /// Asynchronously returns a new instance reflecting the most recent state of the operation.
        /// </summary>
        /// <param name="cancellationToken">A cancellation token for the poll operation.</param>
        /// <returns>A task representing the asynchronous poll operation. The result of the task is 
        /// the most recent state of the operation, or a reference to the same
        /// object if the operation has already completed.</returns>
        public Task<Operation<TResponse, TMetadata>> PollOnceAsync(CancellationToken cancellationToken) =>
            PollOnceAsync(CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Attempts to cancel the long-running operation.
        /// </summary>
        /// <param name="callSettings">Any overriding call settings to apply to the RPC.</param>
        public void Cancel(CallSettings callSettings = null)
        {
            Client.CancelOperation(Name, callSettings);
        }

        /// <summary>
        /// Asynchronously attempts to cancel the long-running operation.
        /// </summary>
        /// <param name="callSettings">Any overriding call settings to apply to the RPC.</param>
        /// <returns>A task representing the asynchronous cancel operation.</returns>
        public Task CancelAsync(CallSettings callSettings = null) =>
            Client.CancelOperationAsync(Name, callSettings);

        /// <summary>
        /// Asynchronously attempts to cancel the long-running operation.
        /// </summary>
        /// <param name="cancellationToken">A cancellation token for the cancel RPC.
        /// Note that this is not a cancellation token for the long-running operation itself.</param>
        /// <returns>A task representing the asynchronous cancel operation.</returns>
        public Task CancelAsync(CancellationToken cancellationToken) =>
            Client.CancelOperationAsync(Name, cancellationToken);

        /// <summary>
        /// Deletes the long-running operation. This does not cancel it; it
        /// only indicates that the client is no longer interested in the result.
        /// </summary>
        /// <param name="callSettings">Any overriding call settings to apply to the RPC.</param>
        public void Delete(CallSettings callSettings = null)
        {
            Client.DeleteOperation(Name, callSettings);
        }

        /// <summary>
        /// Asynchronously deletes the long-running operation. This does not cancel it; it
        /// only indicates that the client is no longer interested in the result.
        /// </summary>
        /// <param name="callSettings">Any overriding call settings to apply to the RPC.</param>
        /// <returns>A task representing the asynchronous deletion operation.</returns>
        public Task DeleteAsync(CallSettings callSettings = null) =>
            Client.DeleteOperationAsync(Name, callSettings);

        /// <summary>
        /// Asynchronously deletes the long-running operation. This does not cancel it; it
        /// only indicates that the client is no longer interested in the result.
        /// </summary>
        /// <param name="cancellationToken">A cancellation token for the cancel RPC.
        /// Note that this is not a cancellation token for the long-running operation itself.</param>
        /// <returns>A task representing the asynchronous deletion operation.</returns>
        public Task DeleteAsync(CancellationToken cancellationToken) =>
            Client.DeleteOperationAsync(Name, cancellationToken);

        /// <summary>
        /// Creates a new instance reflecting the most recent state of the operation with the specified name.
        /// </summary>
        /// <param name="name">The name of the operation, as returned when it was created. Must not be null.</param>
        /// <param name="client">The client to make the RPC call.</param>
        /// <param name="callSettings">Any overriding call settings to apply to the RPC. May be null, in which case
        /// the default settings are used.</param>
        /// <returns>The current state of the operation identified by <paramref name="name"/>.</returns>
        public static Operation<TResponse, TMetadata> PollOnceFromName(string name, OperationsClient client, CallSettings callSettings = null)
        {
            GaxPreconditions.CheckNotNull(name, nameof(name));
            GaxPreconditions.CheckNotNull(client, nameof(client));
            var operation = client.GetOperation(name, callSettings);
            return new Operation<TResponse, TMetadata>(operation, client);
        }

        /// <summary>
        /// Asynchronously creates a new instance reflecting the most recent state of the operation with the specified name.
        /// </summary>
        /// <param name="name">The name of the operation, as returned when it was created. Must not be null.</param>
        /// <param name="client">The client to make the RPC call.</param>
        /// <param name="callSettings">Any overriding call settings to apply to the RPC. May be null, in which case
        /// the default settings are used.</param>
        /// <returns>A task representing the asynchronous "fetch" operation. The result of the task is
        /// the current state of the operation identified by <paramref name="name"/>.</returns>
        public static async Task<Operation<TResponse, TMetadata>> PollOnceFromNameAsync(string name, OperationsClient client, CallSettings callSettings = null)
        {
            GaxPreconditions.CheckNotNull(name, nameof(name));
            GaxPreconditions.CheckNotNull(client, nameof(client));
            var operation = await client.GetOperationAsync(name, callSettings).ConfigureAwait(false);
            return new Operation<TResponse, TMetadata>(operation, client);
        }

        /// <summary>
        /// Asynchronously creates a new instance reflecting the most recent state of the operation with the specified name.
        /// </summary>
        /// <param name="name">The name of the operation, as returned when it was created. Must not be null.</param>
        /// <param name="client">The client to make the RPC call.</param>
        /// <param name="cancellationToken">A cancellation token for the "fetch" operation.</param>
        /// <returns>A task representing the asynchronous "fetch" operation. The result of the task is
        /// the current state of the operation identified by <paramref name="name"/>.</returns>
        public static Task<Operation<TResponse, TMetadata>> PollOnceFromNameAsync(string name, OperationsClient client, CancellationToken cancellationToken) =>
            PollOnceFromNameAsync(name, client, CallSettings.FromCancellationToken(cancellationToken));
    }
}
