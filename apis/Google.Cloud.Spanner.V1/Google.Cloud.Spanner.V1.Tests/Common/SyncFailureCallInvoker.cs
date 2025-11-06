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
using System.Threading.Tasks;

namespace Google.Cloud.Spanner.V1.Tests.Common;

/// <summary>
/// CallInvoker that throws an RpcException synchronously upon method invocation.
/// Simulates immediate failures like client-side validation or connection errors.
/// Used by SpannerClient tests to verify synchronous error handling.
/// </summary>
internal class SyncFailureCallInvoker : FailureCallInvokerBase
{
    /// <summary>
    /// Creates a new instance of <see cref="SyncFailureCallInvoker"/>.
    /// </summary>
    /// <param name="numberOfFailuresToSimulate">The number of times to simulate a failure before succeeding.</param>
    /// <param name="statusCodeToThrow">The gRPC status code to use in the thrown exception.</param>
    /// <param name="exceptionMessage">The message to use in the thrown exception.</param>
    public SyncFailureCallInvoker(int numberOfFailuresToSimulate = int.MaxValue, StatusCode statusCodeToThrow = StatusCode.Internal, string exceptionMessage = "Test exception")
        : base(numberOfFailuresToSimulate, statusCodeToThrow, exceptionMessage)
    {
    }

    /// <inheritdoc/>
    public override TResponse BlockingUnaryCall<TRequest, TResponse>(Method<TRequest, TResponse> method, string host, CallOptions options, TRequest request)
    {
        RecordMetadata(options.Headers);
        MaybeThrowException();
        return (TResponse)Activator.CreateInstance(typeof(TResponse));
    }

    /// <inheritdoc/>
    public override AsyncUnaryCall<TResponse> AsyncUnaryCall<TRequest, TResponse>(Method<TRequest, TResponse> method, string host, CallOptions options, TRequest request)
    {
        RecordMetadata(options.Headers);
        MaybeThrowException();
        return new AsyncUnaryCall<TResponse>(
            Task.FromResult((TResponse)Activator.CreateInstance(typeof(TResponse))),
            Task.FromResult(new Metadata()),
            () => Status.DefaultSuccess,
            () => new Metadata(),
            () => { });
    }

    /// <inheritdoc/>
    public override AsyncServerStreamingCall<TResponse> AsyncServerStreamingCall<TRequest, TResponse>(Method<TRequest, TResponse> method, string host, CallOptions options, TRequest request)
    {
        RecordMetadata(options.Headers);
        MaybeThrowException();
        return new AsyncServerStreamingCall<TResponse>(
            new EmptyAsyncStreamReader<TResponse>(),
            Task.FromResult(new Metadata()),
            () => Status.DefaultSuccess,
            () => new Metadata(),
            () => { });
    }
}
