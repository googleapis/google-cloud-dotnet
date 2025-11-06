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
using System.Collections.Generic;

namespace Google.Cloud.Spanner.V1.Tests.Common;

/// <summary>
/// Base class for test CallInvokers that simulate failures, providing metadata capture capabilities.
/// Shared by AsyncFailureCallInvoker and SyncFailureCallInvoker for verifying request headers in tests.
/// </summary>
public abstract class FailureCallInvokerBase : CallInvoker
{
    private int _invocationCount = 0;
    private readonly int _numberOfFailuresToSimulate;
    private readonly StatusCode _statusCodeToThrow;
    private readonly string _exceptionMessage;

    /// <summary>
    /// Creates a new instance of <see cref="FailureCallInvokerBase"/>.
    /// </summary>
    /// <param name="numberOfFailuresToSimulate">The number of times to simulate a failure before succeeding.</param>
    /// <param name="statusCodeToThrow">The gRPC status code to use in the thrown exception.</param>
    /// <param name="exceptionMessage">The message to use in the thrown exception.</param>
    protected FailureCallInvokerBase(int numberOfFailuresToSimulate, StatusCode statusCodeToThrow, string exceptionMessage)
    {
        _numberOfFailuresToSimulate = numberOfFailuresToSimulate;
        _statusCodeToThrow = statusCodeToThrow;
        _exceptionMessage = exceptionMessage;
    }

    /// <summary>
    /// The list of metadata headers captured from each method invocation.
    /// </summary>
    public List<Metadata> CapturedMetadata { get; } = new List<Metadata>();

    /// <summary>
    /// Records the metadata from a call.
    /// </summary>
    /// <param name="headers">The metadata headers to record.</param>
    protected void RecordMetadata(Metadata headers)
    {
        CapturedMetadata.Add(headers);
    }

    /// <summary>
    /// Determines whether the current invocation should fail based on the configured failure count.
    /// </summary>
    /// <returns>True if the call should fail; otherwise, false.</returns>
    protected bool ShouldFail()
    {
        _invocationCount++;
        return _invocationCount <= _numberOfFailuresToSimulate;
    }

    /// <summary>
    /// Creates the RpcException to be thrown or returned.
    /// </summary>
    /// <returns>The configured RpcException.</returns>
    protected RpcException CreateRpcException()
    {
        return new RpcException(new Status(_statusCodeToThrow, _exceptionMessage));
    }

    /// <summary>
    /// Checks whether the current invocation should fail, and throws an exception if so.
    /// </summary>
    protected void MaybeThrowException()
    {
        if (ShouldFail())
        {
            throw CreateRpcException();
        }
    }


    /// <inheritdoc/>
    public override AsyncClientStreamingCall<TRequest, TResponse> AsyncClientStreamingCall<TRequest, TResponse>(Method<TRequest, TResponse> method, string host, CallOptions options) =>
        throw new NotImplementedException(); // SpannerClient does not support client streaming calls

    /// <inheritdoc/>
    public override AsyncDuplexStreamingCall<TRequest, TResponse> AsyncDuplexStreamingCall<TRequest, TResponse>(Method<TRequest, TResponse> method, string host, CallOptions options) =>
        throw new NotImplementedException(); // SpannerClient does not support duplex streaming calls
}
