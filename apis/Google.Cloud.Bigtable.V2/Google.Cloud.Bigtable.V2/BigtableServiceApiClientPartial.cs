// Copyright 2018 Google LLC
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

using Google.Api.Gax;
using Google.Api.Gax.Grpc;
using Google.Apis.Auth.OAuth2;
using Grpc.Auth;
using Grpc.Core;
using Grpc.Gcp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Google.Cloud.Bigtable.V2
{
    public partial class BigtableServiceApiSettings
    {
        /// <summary>
        /// <see cref="RetrySettings"/> for calls to <c>BigtableClient.MutateRows</c> and
        /// <c>BigtableClient.MutateRowsAsync</c> when some of the mutations fail for certain reasons.
        /// </summary>
        /// <remarks>
        /// The default <c>BigtableClient.MutateRows</c> and <c>BigtableClient.MutateRowsAsync</c>
        /// <see cref="RetrySettings"/> are:
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds</description></item>
        /// <item><description>Initial timeout: 20000 milliseconds</description></item>
        /// <item><description>Timeout multiplier: 1.0</description></item>
        /// <item><description>Timeout maximum delay: 20000 milliseconds</description></item>
        /// </list>
        /// Retry will be attempted on the following response status codes on individual mutations:
        /// <list>
        /// <item><description><see cref="StatusCode.DeadlineExceeded"/></description></item>
        /// <item><description><see cref="StatusCode.Unavailable"/></description></item>
        /// </list>
        /// Default RPC expiration is 600000 milliseconds.
        /// </remarks>
        /// <seealso cref="MutateRowsSettings"/>
        public RetrySettings MutateRowsRetrySettings { get; set; } =
            new RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: Expiration.FromTimeout(TimeSpan.FromMilliseconds(600000)),
                retryFilter: IdempotentRetryFilter
            );

        /// <summary>
        /// <see cref="RetrySettings"/> for calls to <c>BigtableClient.ReadRows</c> when the stream
        /// of results ends prematurely.
        /// </summary>
        /// <remarks>
        /// The default <c>BigtableClient.ReadRows</c> <see cref="RetrySettings"/> are:
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds</description></item>
        /// <item><description>Initial timeout: 20000 milliseconds</description></item>
        /// <item><description>Timeout multiplier: 1.0</description></item>
        /// <item><description>Timeout maximum delay: 20000 milliseconds</description></item>
        /// </list>
        /// Retry will be attempted on the following response status codes on individual mutations:
        /// <list>
        /// <item><description><see cref="StatusCode.DeadlineExceeded"/></description></item>
        /// <item><description><see cref="StatusCode.Unavailable"/></description></item>
        /// </list>
        /// Default RPC expiration is 600000 milliseconds.
        /// </remarks>
        /// <seealso cref="ReadRowsSettings"/>
        public RetrySettings ReadRowsRetrySettings { get; set; } =
            new RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: Expiration.FromTimeout(TimeSpan.FromMilliseconds(600000)),
                retryFilter: IdempotentRetryFilter
            );

        /// <summary>
        /// The maximum number of channels than will be open concurrently to the Bigtable endpoint.
        /// </summary>
        /// <remarks>
        /// <para>
        /// Note that channels are managed and shared amongst <see cref="BigtableClient"/> instances using the same
        /// endpoint and channel options and which use the default credentials. So this property will have no bearing
        /// across clients using different options. To create a custom grouping of channels to be managed, create a
        /// <see cref="GcpCallInvoker"/> manually and use the
        /// <see cref="BigtableClient.Create(CallInvoker, BigtableServiceApiSettings, string)">BigtableClient.Create</see>
        /// overload taking a <see cref="CallInvoker"/> to create clients from it.
        /// </para>
        /// </remarks>
        public uint MaxChannels { get; set; } = 16;

        /// <summary>
        /// The number of streams open concurrently in a channel which will trigger a new channel to be opened, as
        /// long as fewer than <see cref="MaxChannels"/> are currently open.
        /// </summary>
        /// <remarks>
        /// <para>
        /// Note that channels are managed and shared amongst <see cref="BigtableClient"/> instances using the same
        /// endpoint and channel options and which use the default credentials. So this property will have no bearing
        /// across clients using different options. To create a custom grouping of channels to be managed, create a
        /// <see cref="GcpCallInvoker"/> manually and use the
        /// <see cref="BigtableClient.Create(CallInvoker, BigtableServiceApiSettings, string)">BigtableClient.Create</see>
        /// overload taking a <see cref="CallInvoker"/> to create clients from it.
        /// </para>
        /// </remarks>
        public uint PreferredMaxStreamsPerChannel { get; set; } = 5;

        partial void OnCopy(BigtableServiceApiSettings existing)
        {
            MutateRowsRetrySettings = existing.MutateRowsRetrySettings;
            ReadRowsRetrySettings = existing.ReadRowsRetrySettings;
            MaxChannels = existing.MaxChannels;
            PreferredMaxStreamsPerChannel = existing.PreferredMaxStreamsPerChannel;
        }
    }

    /// <summary>
    /// Extensions for use on <see cref="BigtableServiceApiSettings"/>.
    /// </summary>
    public static class BigtableServiceApiSettingsExtensions
    {
        /// <summary>
        /// Creates a collection of <see cref="ChannelOption"/> instances which can be used to create a <see cref="Channel"/>
        /// or <see cref="GcpCallInvoker"/> pre-configured based on the specified settings (or the default settings if they
        /// are null).
        /// </summary>
        /// <remarks>
        /// <para>
        /// Note that if the options returned are used to create a <see cref="Channel"/>, the <see cref="BigtableServiceApiSettings.MaxChannels"/>
        /// and <see cref="BigtableServiceApiSettings.PreferredMaxStreamsPerChannel"/> settings values will be ignored.
        /// </para>
        /// </remarks>
        /// <param name="settings">
        /// The settings with which to create channel options. May be null, in which case the default settings will be used.
        /// </param>
        /// <returns>A collection of <see cref="ChannelOption"/> instances.</returns>
        public static IEnumerable<ChannelOption> CreateChannelOptions(this BigtableServiceApiSettings settings)
        {
            // TODO: Use a cached collection of channel options if settings is null.
            var effectiveSettings = settings ?? BigtableServiceApiSettings.GetDefault();
            var apiConfig = new ApiConfig
            {
                ChannelPool = new ChannelPoolConfig
                {
                    MaxSize = effectiveSettings.MaxChannels,
                    MaxConcurrentStreamsLowWatermark = effectiveSettings.PreferredMaxStreamsPerChannel
                }
            };

            return new[]
            {
                // Set channel send/recv message size to unlimited.
                new ChannelOption(ChannelOptions.MaxSendMessageLength, -1),
                new ChannelOption(ChannelOptions.MaxReceiveMessageLength, -1),

                // TODO: Figure out if there's a good way to test this
                new ChannelOption(ChannelOptions.PrimaryUserAgentString, BigtableClient.UserAgent),

                new ChannelOption(GcpCallInvoker.ApiConfigChannelArg, apiConfig.ToString())
            };
        }
    }

    public partial class BigtableServiceApiClient
    {
        public partial class SampleRowKeysStream
        {
            /// <summary>
            /// Gets all responses from the stream.
            /// </summary>
            /// <returns>The collection of all row key samples.</returns>
            public IList<SampleRowKeysResponse> ToList() =>
                Task.Run(() => ToListAsync()).ResultWithUnwrappedExceptions();

            /// <summary>
            /// Gets all responses from the stream asynchronously.
            /// </summary>
            /// <param name="cancellationToken">The token to monitor for cancellation requests.</param>
            /// <returns>The collection of all row key samples.</returns>
            public async Task<IList<SampleRowKeysResponse>> ToListAsync(
                CancellationToken cancellationToken = default)
            {
                var responses = new List<SampleRowKeysResponse>();
                while (await ResponseStream.MoveNext(cancellationToken).ConfigureAwait(false))
                {
                    responses.Add(ResponseStream.Current);
                }
                return responses;
            }
        }
    }
    
    public partial class BigtableServiceApiClientImpl
    {
        partial void Modify_MutateRowRequest(ref MutateRowRequest request, ref CallSettings settings) =>
            GaxPreconditions.CheckState(
                request.IsIdempotent(), 
                "Non-idempotent MutateRow requests are not allowed. Specify a version with all SetCell mutations.");

        partial void Modify_MutateRowsRequest(ref MutateRowsRequest request, ref CallSettings settings) =>
            GaxPreconditions.CheckState(
                request.IsIdempotent(),
                "Non-idempotent MutateRows requests are not allowed. Specify a version with all SetCell mutations.");
    }
}
