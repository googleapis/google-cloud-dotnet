// Copyright 2022 Google Inc. All Rights Reserved.
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
using Google.Apis.Http;
using Google.Apis.Storage.v1;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;

namespace Google.Cloud.Storage.V1
{
    /// <summary>
    /// Handler for exponential backoff for request messages which permit retries.
    /// This is similar to BackoffHandler in Google.Apis.Http, but that doesn't give us enough flexibility.
    /// This handler does not enforce a maximum number of retries; that's configured via <see cref="ConfigurableMessageHandler.NumTries"/>.
    /// </summary>
    internal sealed class RetryHandler : IHttpUnsuccessfulResponseHandler
    {
        // For testing
        internal const string InvocationIdHeaderPart = "gccl-invocation-id";
        internal const string AttemptCountHeaderPart = "gccl-attempt-count";

        private readonly RetryOptions _retryOptions;

        private RetryHandler(RetryOptions retryOptions) => _retryOptions = retryOptions;

        /// <summary>
        /// It marks the request as retriable with the retry options as provided.
        /// In case null retry options or Never is passed, retry will not happen in case of failure.
        /// </summary>
        internal static void MarkAsRetriable<TResponse>(StorageBaseServiceRequest<TResponse> request, RetryOptions options)
        {
            GaxPreconditions.CheckNotNull(options, nameof(options));

            if (options.Predicate == RetryPredicate.Never || options == RetryOptions.Never)
            {
                return;
            }
            RetryHandler retryHandler = new RetryHandler(options);

            // Note: we can't use ModifyRequest, as the x-goog-api-client header is added later by ConfigurableMessageHandler.
            // Additionally, that's only called once, and we may want to record the attempt number as well.
            request.AddExecuteInterceptor(InvocationIdInterceptor.Instance);
            request.AddUnsuccessfulResponseHandler(retryHandler);
        }

        public async Task<bool> HandleResponseAsync(HandleUnsuccessfulResponseArgs args)
        {
            var retry = args.SupportsRetry && _retryOptions.Predicate.ShouldRetry((int) args.Response.StatusCode);
            if (!retry)
            {
                return false;
            }

            TimeSpan delay = _retryOptions.Timing.GetDelay(args.CurrentFailedTry);
            await Task.Delay(delay, args.CancellationToken).ConfigureAwait(false);

            return true;
        }

        /// <summary>
        /// Interceptor which adds a random invocation ID within the x-goog-api-client header,
        /// along with an attempt count.
        /// </summary>
        private sealed class InvocationIdInterceptor : IHttpExecuteInterceptor
        {
            internal static InvocationIdInterceptor Instance { get; } = new InvocationIdInterceptor();

            private const string InvocationIdPrefix = InvocationIdHeaderPart + "/";
            private const string AttemptCountPrefix = AttemptCountHeaderPart + "/";

            private InvocationIdInterceptor()
            {
            }

            public Task InterceptAsync(HttpRequestMessage request, CancellationToken cancellationToken)
            {
                // If we don't have the header already, or if there isn't a single value,
                // that's an odd situation: don't add one with just the invocation ID.
                if (!request.Headers.TryGetValues(VersionHeaderBuilder.HeaderName, out var values) || values.Count() != 1)
                {
                    return Task.CompletedTask;
                }
                string value = values.Single();
                List<string> parts = value.Split(' ').ToList();

                bool gotInvocationId = false;
                bool gotAttemptCount = false;
                for (int i = 0; i < parts.Count; i++)
                {
                    if (parts[i].StartsWith(InvocationIdPrefix, StringComparison.Ordinal))
                    {
                        gotInvocationId = true;
                    }
                    else if (parts[i].StartsWith(AttemptCountPrefix, StringComparison.Ordinal))
                    {
                        gotAttemptCount = true;
                        string countText = parts[i].Substring(AttemptCountPrefix.Length);
                        if (int.TryParse(countText, NumberStyles.None, CultureInfo.InvariantCulture, out int count))
                        {
                            count++;
                            parts[i] = AttemptCountPrefix + count.ToString(CultureInfo.InvariantCulture);
                        }
                    }
                }
                if (!gotInvocationId)
                {
                    parts.Add(InvocationIdPrefix + Guid.NewGuid());
                }
                if (!gotAttemptCount)
                {
                    // TODO: Check this: should we add it on the first request,
                    // or only subsequent requests? Design doc is unclear.
                    parts.Add(AttemptCountPrefix + "1");
                }

                request.Headers.Remove(VersionHeaderBuilder.HeaderName);
                request.Headers.Add(VersionHeaderBuilder.HeaderName, string.Join(" ", parts));


                return Task.CompletedTask;
            }
        }
    }
}
