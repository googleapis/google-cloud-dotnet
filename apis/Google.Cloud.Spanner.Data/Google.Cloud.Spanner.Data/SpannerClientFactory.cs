// Copyright 2017 Google Inc. All Rights Reserved.
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

using System;
using System.Collections;
using System.Threading.Tasks;
using Google.Api.Gax.Grpc;
using Google.Apis.Auth.OAuth2;
using Google.Cloud.Spanner.V1;
using Google.Cloud.Spanner.V1.Internal.Logging;
using Grpc.Auth;
using Grpc.Core;

namespace Google.Cloud.Spanner.Data
{
    internal interface ISpannerClientFactory
    {
        Task<SpannerClient> CreateClientAsync(ServiceEndpoint endpoint, ChannelCredentials credentials,
            IDictionary additionalOptions, Logger logger);
    }

    /// <summary>
    /// For mockability and testability of the <see cref="ClientPool"/> class.
    /// </summary>
    internal class SpannerClientFactory : ISpannerClientFactory
    {
        internal static readonly ISpannerClientFactory Default = new SpannerClientFactory();

        private SpannerClientFactory()
        {
        }

        /// <summary>
        /// Helper to create a channel from a host, port and optional credentials.
        /// </summary>
        /// <param name="host">The host to connect to.</param>
        /// <param name="port">The port to connect to.</param>
        /// <param name="credentials">The credentials to use, or null to use application default credentials.</param>
        /// <returns>A task which, when completed, will result in a channel to the specified endpoint.</returns>
        internal static async Task<Channel> CreateChannelAsync(string host, int port, ChannelCredentials credentials)
        {
            if (credentials == null)
            {
                var appDefaultCredentials = await GoogleCredential.GetApplicationDefaultAsync().ConfigureAwait(false);
                if (appDefaultCredentials.IsCreateScopedRequired)
                {
                    appDefaultCredentials = appDefaultCredentials.CreateScoped(SpannerClient.DefaultScopes);
                }
                credentials = appDefaultCredentials.ToChannelCredentials();
            }

            return new Channel(host, port, credentials);
        }

        /// <inheritdoc />
        public async Task<SpannerClient> CreateClientAsync(ServiceEndpoint endpoint, ChannelCredentials credentials,
            IDictionary additionalOptions, Logger logger)
        {
            var allowImmediateTimeout = false;

            if (additionalOptions.Contains(nameof(SpannerSettings.AllowImmediateTimeouts)))
            {
                allowImmediateTimeout = Convert.ToBoolean(additionalOptions[nameof(SpannerSettings.AllowImmediateTimeouts)]);
            }

            var channel = await CreateChannelAsync(endpoint.Host, endpoint.Port, credentials).ConfigureAwait(false);
            logger.LogPerformanceCounterFn("SpannerClient.RawCreateCount", x => x + 1);

            //Pull the timeout from spanner options.
            //The option must be set before OpenAsync is called.
            var idempotentCallSettings = CallSettings.FromCallTiming(
                CallTiming.FromRetry(
                    new RetrySettings(
                        SpannerSettings.GetDefaultRetryBackoff(),
                        SpannerSettings.GetDefaultTimeoutBackoff(),
                        SpannerSettings.ConvertTimeoutToExpiration(SpannerOptions.Instance.Timeout, allowImmediateTimeout),
                        SpannerSettings.IdempotentRetryFilter
                    )));

            return SpannerClient.Create(
                channel, new SpannerSettings
                {
                    CreateSessionSettings = idempotentCallSettings,
                    GetSessionSettings = idempotentCallSettings,
                    DeleteSessionSettings = idempotentCallSettings,
                    ExecuteSqlSettings = idempotentCallSettings,
                    ReadSettings = idempotentCallSettings,
                    BeginTransactionSettings = idempotentCallSettings,
                    CommitSettings = idempotentCallSettings,
                    RollbackSettings = idempotentCallSettings,
                    AllowImmediateTimeouts = allowImmediateTimeout
                });
        }
    }
}
