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

public partial class SpannerClientBuilder
{
    /// <summary>
    /// A <see cref="Interceptor"/> that wraps all calls, adding the Spanner request ID to any exceptions thrown while
    /// using the <see cref="SpannerClient"/>.
    /// </summary>
    internal sealed class RequestIdOnExceptionInterceptor : Interceptor
    {
        /// <summary>
        /// Provides access to the singleton instance of <see cref="RequestIdOnExceptionInterceptor"/>
        /// </summary>
        internal static RequestIdOnExceptionInterceptor Instance = new();

        private RequestIdOnExceptionInterceptor()
        {
        }

        /// <inheritdoc/>
        public override TResponse BlockingUnaryCall<TRequest, TResponse>(
            TRequest request,
            ClientInterceptorContext<TRequest, TResponse> context,
            BlockingUnaryCallContinuation<TRequest, TResponse> continuation) =>
            WrapException(() => continuation(request, context), context.Options);

        /// <inheritdoc/>
        public override AsyncUnaryCall<TResponse> AsyncUnaryCall<TRequest, TResponse>(
            TRequest request,
            ClientInterceptorContext<TRequest, TResponse> context,
            AsyncUnaryCallContinuation<TRequest, TResponse> continuation)
        {
              var call = WrapException(() => continuation(request, context), context.Options);
              return new AsyncUnaryCall<TResponse>(
                  WrapExceptionAsync(call.ResponseAsync, context.Options),
                  WrapExceptionAsync(call.ResponseHeadersAsync, context.Options),
                  call.GetStatus,
                  call.GetTrailers,
                  call.Dispose);
        }

        /// <inheritdoc/>
        public override AsyncClientStreamingCall<TRequest, TResponse> AsyncClientStreamingCall<TRequest, TResponse>(
            ClientInterceptorContext<TRequest, TResponse> context,
            AsyncClientStreamingCallContinuation<TRequest, TResponse> continuation)
        {
            var call = WrapException(() => continuation(context), context.Options);
            return new AsyncClientStreamingCall<TRequest, TResponse>(
                new SpannerRequestIdStreamWriter<TRequest>(call.RequestStream, context.Options),
                WrapExceptionAsync(call.ResponseAsync, context.Options),
                WrapExceptionAsync(call.ResponseHeadersAsync, context.Options),
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
            var call = WrapException(() => continuation(request, context), context.Options);
            var wrappedResponseStream = new SpannerRequestIdStreamReader<TResponse>(call.ResponseStream, context.Options);

            return new AsyncServerStreamingCall<TResponse>(
                wrappedResponseStream,
                WrapExceptionAsync(call.ResponseHeadersAsync, context.Options),
                call.GetStatus,
                call.GetTrailers,
                call.Dispose);
        }

        /// <inheritdoc/>
        public override AsyncDuplexStreamingCall<TRequest, TResponse> AsyncDuplexStreamingCall<TRequest, TResponse>(
            ClientInterceptorContext<TRequest, TResponse> context,
            AsyncDuplexStreamingCallContinuation<TRequest, TResponse> continuation)
        {
            var call = WrapException(() => continuation(context), context.Options);
            var wrappedResponseStream = new SpannerRequestIdStreamReader<TResponse>(call.ResponseStream, context.Options);
            var wrappedRequestStream = new SpannerRequestIdStreamWriter<TRequest>(call.RequestStream, context.Options);

            return new AsyncDuplexStreamingCall<TRequest, TResponse>(
                wrappedRequestStream,
                wrappedResponseStream,
                WrapExceptionAsync(call.ResponseHeadersAsync, context.Options),
                call.GetStatus,
                call.GetTrailers,
                call.Dispose);
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
                EnrichException(e, options);
                throw;
            }
        }

        /// <summary>
        /// Handles the response asynchronously, adding the request ID to any exceptions thrown.
        /// </summary>
        private static async Task WrapExceptionAsync(Task task, CallOptions options)
        {
            try
            {
                await task.ConfigureAwait(false);
            }
            catch (Exception e)
            {
                EnrichException(e, options);
                throw;
            }
        }

        /// <summary>
        /// Handles the response, adding the request ID to any exceptions thrown.
        /// </summary>
        private static T WrapException<T>(Func<T> action, CallOptions options)
        {
            try
            {
                return action();
            }
            catch (Exception e)
            {
               EnrichException(e, options);
               throw;
            }
        }

        /// <summary>
        /// Enriches an exception with the Spanner Request ID from the provided <see cref="CallOptions"/>.
        /// </summary>
        /// <param name="e">The exception to enrich.</param>
        /// <param name="options">The <see cref="CallOptions"/> containing the request ID.</param>
        /// <returns>The enriched exception (the same instance passed in).</returns>
        private static Exception EnrichException(Exception e, CallOptions options)
        {
            var requestId = GetRequestIdFromOptions(options);
            if (requestId != null)
            {
                e.Data[SpannerClientImpl.RequestIdHeaderKey] = requestId;
            }
            return e;

            static string GetRequestIdFromOptions(CallOptions options)
            {
                if (options.Headers is Metadata headers)
                {
                    return headers.GetValue(SpannerClientImpl.RequestIdHeaderKey);
                }
                return null;
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

        /// <summary>
        /// A stream writer that wraps the original stream writer and adds the request ID to any exceptions thrown.
        /// </summary>
        private class SpannerRequestIdStreamWriter<T> : IClientStreamWriter<T>
        {
            private readonly IClientStreamWriter<T> _originalWriter;
            private readonly CallOptions _options;

            public SpannerRequestIdStreamWriter(IClientStreamWriter<T> originalWriter, CallOptions options)
            {
                _originalWriter = originalWriter;
                _options = options;
            }

            public WriteOptions WriteOptions { get => _originalWriter.WriteOptions; set => _originalWriter.WriteOptions = value; }

            public Task CompleteAsync() => WrapExceptionAsync(_originalWriter.CompleteAsync(), _options);

            public Task WriteAsync(T message) => WrapExceptionAsync(_originalWriter.WriteAsync(message), _options);
        }
    }
}
