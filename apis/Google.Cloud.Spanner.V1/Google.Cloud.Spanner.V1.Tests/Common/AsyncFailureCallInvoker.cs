// Copyright 2025 Google LLC
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
//     https://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.

using Grpc.Core;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace Google.Cloud.Spanner.V1.Tests.Common;

/// <summary>
/// CallInvoker that returns a valid call object which fails with an RpcException when awaited or iterated.
/// Simulates asynchronous failures like server-side errors or network issues.
/// Used by SpannerClient tests to verify error handling behavior.
/// </summary>
public class AsyncFailureCallInvoker : FailureCallInvokerBase
{
    /// <summary>
    /// Creates a new instance of <see cref="AsyncFailureCallInvoker"/>.
    /// </summary>
    /// <param name="numberOfFailuresToSimulate">The number of times to simulate a failure before succeeding.</param>
    /// <param name="statusCodeToThrow">The gRPC status code to use in the thrown exception.</param>
    /// <param name="exceptionMessage">The message to use in the thrown exception.</param>
    public AsyncFailureCallInvoker(int numberOfFailuresToSimulate = int.MaxValue, StatusCode statusCodeToThrow = StatusCode.Internal, string exceptionMessage = "Test exception")
        : base(numberOfFailuresToSimulate, statusCodeToThrow, exceptionMessage)
    {
    }

    /// <inheritdoc/>
    public override AsyncUnaryCall<TResponse> AsyncUnaryCall<TRequest, TResponse>(Method<TRequest, TResponse> method, string host, CallOptions options, TRequest request)
    {
        RecordMetadata(options.Headers);
        if (ShouldFail())
        {
            var exceptionToThrow = CreateRpcException();
            var failedResponse = Task.FromException<TResponse>(exceptionToThrow);
            var failedResponseHeadersAsync = Task.FromException<Metadata>(exceptionToThrow);
            return new AsyncUnaryCall<TResponse>(failedResponse, failedResponseHeadersAsync, () => Status.DefaultSuccess, () => new Metadata(), () => { });
        }

        var response = (TResponse)Activator.CreateInstance(typeof(TResponse));
        return new AsyncUnaryCall<TResponse>(Task.FromResult(response), Task.FromResult(new Metadata()), () => Status.DefaultSuccess, () => new Metadata(), () => { });
    }

    /// <inheritdoc/>
    public override AsyncServerStreamingCall<TResponse> AsyncServerStreamingCall<TRequest, TResponse>(Method<TRequest, TResponse> method, string host, CallOptions options, TRequest request)
    {
        RecordMetadata(options.Headers);
        if (ShouldFail())
        {
            var exceptionToThrow = CreateRpcException();
            var failedResponseStream = new ThrowingStreamReader<TResponse>(exceptionToThrow);
            var failedResponseHeadersAsync = Task.FromException<Metadata>(exceptionToThrow);
            return new AsyncServerStreamingCall<TResponse>(failedResponseStream, failedResponseHeadersAsync, () => Status.DefaultSuccess, () => new Metadata(), () => { });
        }

        return new AsyncServerStreamingCall<TResponse>(new EmptyAsyncStreamReader<TResponse>(), Task.FromResult(new Metadata()), () => Status.DefaultSuccess, () => new Metadata(), () => { });
    }

    /// <inheritdoc/>
    public override TResponse BlockingUnaryCall<TRequest, TResponse>(Method<TRequest, TResponse> method, string host, CallOptions options, TRequest request) =>
        throw new NotImplementedException(); // Not an async method.


    /// <summary>
    /// An async stream reader that throws an exception when moved to the next element.
    /// </summary>
    /// <typeparam name="T">The type of element in the stream.</typeparam>
    private class ThrowingStreamReader<T> : IAsyncStreamReader<T>
    {
        private readonly Exception _exception;

        /// <summary>
        /// Creates a new instance of <see cref="ThrowingStreamReader{T}"/>.
        /// </summary>
        /// <param name="exception">The exception to throw.</param>
        public ThrowingStreamReader(Exception exception) => _exception = exception;

        /// <inheritdoc/>
        public T Current => default;

        /// <inheritdoc/>
        public Task<bool> MoveNext(CancellationToken cancellationToken) => Task.FromException<bool>(_exception);
    }
}
