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
using Grpc.Core.Interceptors;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace Google.Cloud.Spanner.V1;

/// <summary>
/// A <see cref="Interceptor"/> that wraps all calls, adding the Spanner request ID to any exceptions thrown while
/// using the <see cref="SpannerClient"/>.
/// </summary>
internal sealed class RequestIdCallInterceptor : Interceptor
{
    /// <inheritdoc/>
    public override TResponse BlockingUnaryCall<TRequest, TResponse>(
        TRequest request,
        ClientInterceptorContext<TRequest, TResponse> context,
        BlockingUnaryCallContinuation<TRequest, TResponse> continuation)
    {
        var requestId = GetRequestIdFromOptions(context.Options);
        return WrapExceptions(() => continuation(request, context), context.Options);
    }

    /// <inheritdoc/>
    public override AsyncUnaryCall<TResponse> AsyncUnaryCall<TRequest, TResponse>(
        TRequest request,
        ClientInterceptorContext<TRequest, TResponse> context,
        AsyncUnaryCallContinuation<TRequest, TResponse> continuation)
    {
        var call = continuation(request, context);
        var requestId = GetRequestIdFromOptions(context.Options);

        return new AsyncUnaryCall<TResponse>(
            WrapExceptionAsync(call.ResponseAsync, context.Options),
            call.ResponseHeadersAsync,
            call.GetStatus,
            call.GetTrailers,
            call.Dispose);
    }

    /// <inheritdoc/>
    public override AsyncClientStreamingCall<TRequest, TResponse> AsyncClientStreamingCall<TRequest, TResponse>(
        ClientInterceptorContext<TRequest, TResponse> context,
        AsyncClientStreamingCallContinuation<TRequest, TResponse> continuation)
    {
        var call = continuation(context);

        return new AsyncClientStreamingCall<TRequest, TResponse>(
            call.RequestStream,
            WrapExceptionAsync(call.ResponseAsync, context.Options),
            call.ResponseHeadersAsync,
            call.GetStatus,
            call.GetTrailers,
            call.Dispose);
    }

    /// <inheritdoc/>
    public override AsyncServerStreamingCall<TResponse> AsyncServerStreamingCall<TRequest, TResponse>(
        TRequest request,
        ClientInterceptorContext<TRequest, TResponse> context,
        AsyncServerStreamingCallContinuation<TRequest, TResponse> continuation)
    {
        var call = continuation(request, context);
        var responseStream = new SpannerRequestIdStreamReader<TResponse>(call.ResponseStream, context.Options);

        return new AsyncServerStreamingCall<TResponse>(
            responseStream,
            call.ResponseHeadersAsync,
            call.GetStatus,
            call.GetTrailers,
            call.Dispose);
    }

    /// <inheritdoc/>
    public override AsyncDuplexStreamingCall<TRequest, TResponse> AsyncDuplexStreamingCall<TRequest, TResponse>(
        ClientInterceptorContext<TRequest, TResponse> context,
        AsyncDuplexStreamingCallContinuation<TRequest, TResponse> continuation)
    {
        var call = continuation(context);
        var requestId = GetRequestIdFromOptions(context.Options);
        var responseStream = new SpannerRequestIdStreamReader<TResponse>(call.ResponseStream, context.Options);

        return new AsyncDuplexStreamingCall<TRequest, TResponse>(
            call.RequestStream,
            responseStream,
            call.ResponseHeadersAsync,
            call.GetStatus,
            call.GetTrailers,
            call.Dispose);
    }

    /// <summary>
    /// Gets the request ID from the call options.
    /// </summary>
    private static string GetRequestIdFromOptions(CallOptions options)
    {
        if (options.Headers is Metadata headers)
        {
            return headers.GetValue(RequestId.HeaderKey);
        }
        return null;
    }

    /// <summary>
    /// Handles the response, adding the request ID to any exceptions thrown.
    /// </summary>
    private static T WrapExceptions<T>(Func<T> action, CallOptions options)
    {
        try
        {
            return action();
        }
        catch (Exception e)
        {
            var requestId = GetRequestIdFromOptions(options);
            if (requestId != null)
            {
                e.Data[RequestId.HeaderKey] = requestId;
            }
            throw;
        }
    }

    /// <summary>
    /// Handles the response asynchronously, adding the request ID to any exceptions thrown.
    /// </summary>
    private static async Task<T> WrapExceptionAsync<T>(Task<T> task, CallOptions options)
    {
        try
        {
            return await task.ConfigureAwait(false);
        }
        catch (Exception e)
        {
            var requestId = GetRequestIdFromOptions(options);
            if (requestId != null)
            {
                e.Data[RequestId.HeaderKey] = requestId;
            }
            throw;
        }
    }

    /// <summary>
    /// A stream reader that wraps the original stream reader and adds the request ID to any exceptions thrown.
    /// </summary>
    private class SpannerRequestIdStreamReader<T> : IAsyncStreamReader<T>
    {
        private readonly IAsyncStreamReader<T> _originalReader;
        private readonly CallOptions _options;

        public SpannerRequestIdStreamReader(IAsyncStreamReader<T> originalReader, CallOptions options)
        {
            _originalReader = originalReader;
            _options = options;
        }

        public T Current => _originalReader.Current;

        public Task<bool> MoveNext(CancellationToken cancellationToken) =>
            WrapExceptionAsync(_originalReader.MoveNext(cancellationToken), _options);
    }
}
