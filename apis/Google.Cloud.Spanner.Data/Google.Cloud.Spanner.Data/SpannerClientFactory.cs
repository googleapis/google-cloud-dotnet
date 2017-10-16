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

        private static async Task<ChannelCredentials> CreateDefaultChannelCredentialsAsync()
        {
            var appDefaultCredentials = await GoogleCredential.GetApplicationDefaultAsync().ConfigureAwait(false);
            if (appDefaultCredentials.IsCreateScopedRequired)
            {
                appDefaultCredentials = appDefaultCredentials.CreateScoped(SpannerClient.DefaultScopes);
            }
            return appDefaultCredentials.ToChannelCredentials();
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

            if (credentials == null)
            {
                credentials = await CreateDefaultChannelCredentialsAsync().ConfigureAwait(false);
            }

            var channel = new Channel(
                endpoint.Host,
                endpoint.Port,
                credentials);
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
