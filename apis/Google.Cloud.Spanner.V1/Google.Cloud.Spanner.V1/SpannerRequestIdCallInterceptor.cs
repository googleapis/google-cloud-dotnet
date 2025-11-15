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
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Google.Cloud.Spanner.V1;

/// <summary>
/// A <see cref="Interceptor"/> that wraps all calls, adding the Spanner request ID to any exceptions thrown.
/// The SpannerClient acquires one of these interceptors on build and pipes all outgoing RPCs through it.
/// In the event of an error being returned, the interceptor will catch the resulting exception and automatically
/// populate the request ID into the base Exception.Data collection using the passed CallOption value for the x-goog-spanner-request-id.
/// </summary>
internal sealed class SpannerRequestIdCallInterceptor : Interceptor
{
    /// <summary>
    /// Intercepts a blocking unary call, adding the Spanner request ID to any exceptions thrown.
    /// </summary>
    public override TResponse BlockingUnaryCall<TRequest, TResponse>(
        TRequest request,
        ClientInterceptorContext<TRequest, TResponse> context,
        BlockingUnaryCallContinuation<TRequest, TResponse> continuation)
    {
        var requestId = GetRequestIdFromOptions(context.Options);
        return HandleResponse(() => continuation(request, context), requestId);
    }

    /// <summary>
    /// Intercepts an asynchronous unary call, adding the Spanner request ID to any exceptions thrown.
    /// </summary>
    public override AsyncUnaryCall<TResponse> AsyncUnaryCall<TRequest, TResponse>(
        TRequest request,
        ClientInterceptorContext<TRequest, TResponse> context,
        AsyncUnaryCallContinuation<TRequest, TResponse> continuation)
    {
        var call = continuation(request, context);
        var requestId = GetRequestIdFromOptions(context.Options);

        return new AsyncUnaryCall<TResponse>(
            HandleResponseAsync(call.ResponseAsync, requestId),
            call.ResponseHeadersAsync,
            call.GetStatus,
            call.GetTrailers,
            call.Dispose);
    }

    /// <summary>
    /// Intercepts an asynchronous client streaming call, adding the Spanner request ID to any exceptions thrown.
    /// </summary>
    public override AsyncClientStreamingCall<TRequest, TResponse> AsyncClientStreamingCall<TRequest, TResponse>(
        ClientInterceptorContext<TRequest, TResponse> context,
        AsyncClientStreamingCallContinuation<TRequest, TResponse> continuation)
    {
        var call = continuation(context);
        var requestId = GetRequestIdFromOptions(context.Options);

        return new AsyncClientStreamingCall<TRequest, TResponse>(
            call.RequestStream,
            HandleResponseAsync(call.ResponseAsync, requestId),
            call.ResponseHeadersAsync,
            call.GetStatus,
            call.GetTrailers,
            call.Dispose);
    }

    /// <summary>
    /// Intercepts an asynchronous server streaming call, adding the Spanner request ID to any exceptions thrown.
    /// </summary>
    public override AsyncServerStreamingCall<TResponse> AsyncServerStreamingCall<TRequest, TResponse>(
        TRequest request,
        ClientInterceptorContext<TRequest, TResponse> context,
        AsyncServerStreamingCallContinuation<TRequest, TResponse> continuation)
    {
        var call = continuation(request, context);
        var requestId = GetRequestIdFromOptions(context.Options);
        var responseStream = new SpannerRequestIdStreamReader<TResponse>(call.ResponseStream, requestId);

        return new AsyncServerStreamingCall<TResponse>(
            responseStream,
            call.ResponseHeadersAsync,
            call.GetStatus,
            call.GetTrailers,
            call.Dispose);
    }

    /// <summary>
    /// Intercepts an asynchronous duplex streaming call, adding the Spanner request ID to any exceptions thrown.
    /// </summary>
    public override AsyncDuplexStreamingCall<TRequest, TResponse> AsyncDuplexStreamingCall<TRequest, TResponse>(
        ClientInterceptorContext<TRequest, TResponse> context,
        AsyncDuplexStreamingCallContinuation<TRequest, TResponse> continuation)
    {
        var call = continuation(context);
        var requestId = GetRequestIdFromOptions(context.Options);
        var responseStream = new SpannerRequestIdStreamReader<TResponse>(call.ResponseStream, requestId);

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
            // Headers can contain multiple entries with the same key.
            // We are only interested in the last one.
            return headers.LastOrDefault(x => x.Key == SpannerRequestId.HeaderKey)?.Value;
        }
        return null;
    }

    /// <summary>
    /// Handles the response, adding the request ID to any exceptions thrown.
    /// </summary>
    private static T HandleResponse<T>(Func<T> action, string requestId)
    {
        try
        {
            return action();
        }
        catch (Exception e)
        {
            if (requestId != null)
            {
                e.Data[SpannerRequestId.HeaderKey] = requestId;
            }
            throw;
        }
    }

    /// <summary>
    /// Handles the response asynchronously, adding the request ID to any exceptions thrown.
    /// </summary>
    private static async Task<T> HandleResponseAsync<T>(Task<T> task, string requestId)
    {
        try
        {
            return await task.ConfigureAwait(false);
        }
        catch (Exception e)
        {
            if (requestId != null)
            {
                e.Data[SpannerRequestId.HeaderKey] = requestId;
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
        private readonly string _requestId;

        public SpannerRequestIdStreamReader(IAsyncStreamReader<T> originalReader, string requestId)
        {
            _originalReader = originalReader;
            _requestId = requestId;
        }

        public T Current => _originalReader.Current;

        public Task<bool> MoveNext(CancellationToken cancellationToken) =>
            HandleResponseAsync(_originalReader.MoveNext(cancellationToken), _requestId);
    }
}
