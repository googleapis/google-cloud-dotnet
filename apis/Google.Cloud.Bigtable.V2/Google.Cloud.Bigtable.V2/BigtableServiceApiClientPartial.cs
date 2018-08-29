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

        // TODO: Validate range, make sure this default makes sense
        /// <summary>
        /// 
        /// </summary>
        public int MaxChannels { get; set; } = 20;

        // TODO: Validate range, make sure this default makes sense
        /// <summary>
        /// 
        /// </summary>
        public int PreferredMaxStreamsPerChannel { get; set; } = 4;

        partial void OnCopy(BigtableServiceApiSettings existing)
        {
            MutateRowsRetrySettings = existing.MutateRowsRetrySettings;
            ReadRowsRetrySettings = existing.ReadRowsRetrySettings;
            MaxChannels = existing.MaxChannels;
            PreferredMaxStreamsPerChannel = existing.PreferredMaxStreamsPerChannel;
        }
    }

    /// <summary>
    /// 
    /// </summary>
    public static class BigtableServiceApiSettingsExtensions
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="settings"></param>
        /// <returns></returns>
        public static IEnumerable<ChannelOption> CreateChannelOptions(this BigtableServiceApiSettings settings)
        {
            var effectiveSettings = settings ?? BigtableServiceApiSettings.GetDefault();
            var apiConfig = new ApiConfig
            {
                ChannelPool = new ChannelPoolConfig
                {
                    MaxSize = (uint)effectiveSettings.MaxChannels,
                    MaxConcurrentStreamsLowWatermark = (uint)effectiveSettings.PreferredMaxStreamsPerChannel
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

    // TODO: Move changes into Google.Api.Gax.Grpc.ChannelPool if approved.
    /// <summary>
    /// A pool of channels for the same service, but with potentially different endpoints. Each endpoint
    /// has a single channel. All channels created by this pool use default application credentials.
    /// This class is thread-safe.
    /// </summary>
    public sealed class ChannelPool
    {
        #region NewStuff

        private readonly Dictionary<GcpCallInvokerKey, GcpCallInvoker> _gcpCallInvokers = new Dictionary<GcpCallInvokerKey, GcpCallInvoker>();

        private class ChannelOptionComparer : IEqualityComparer<ChannelOption>
        {
            public static readonly ChannelOptionComparer Instance = new ChannelOptionComparer();

            private ChannelOptionComparer() { }

            public bool Equals(ChannelOption x, ChannelOption y)
            {
                if (x == null && y == null)
                {
                    return true;
                }

                if (x == null || y == null)
                {
                    return false;
                }

                if (x.Type != y.Type || x.Name != y.Name)
                {
                    return false;
                }

                switch (x.Type)
                {
                    case ChannelOption.OptionType.Integer:
                        return x.IntValue == y.IntValue;

                    case ChannelOption.OptionType.String:
                        return y.StringValue == y.StringValue;

                    default:
                        throw new ArgumentException("Unexpected channel option type: " + x.Type);
                }
            }

            public int GetHashCode(ChannelOption obj)
            {
                return
                    obj == null ? 0 :
                    obj.Type == ChannelOption.OptionType.Integer ?
                        EqualityHelpers.CombineHashCodes(obj.IntValue, obj.Name.GetHashCode(), (int)obj.Type) :
                    obj.Type == ChannelOption.OptionType.String ?
                        EqualityHelpers.CombineHashCodes(obj.StringValue.GetHashCode(), obj.Name.GetHashCode(), (int)obj.Type) :
                    throw new ArgumentException("Unexpected channel option type: " + obj.Type);
            }
        }

        private struct GcpCallInvokerKey : IEquatable<GcpCallInvokerKey>
        {
            public readonly ServiceEndpoint Endpoint;
            public readonly List<ChannelOption> Options;

            public GcpCallInvokerKey(ServiceEndpoint endpoint, List<ChannelOption> options)
            {
                Endpoint = endpoint;
                Options = options;
            }

            public override int GetHashCode() =>
                EqualityHelpers.CombineHashCodes(
                    Endpoint.GetHashCode(),
                    EqualityHelpers.GetListHashCode(Options, ChannelOptionComparer.Instance));

            public override bool Equals(object obj) => obj is GcpCallInvokerKey other && Equals(other);

            public bool Equals(GcpCallInvokerKey other) =>
                Endpoint.Equals(other.Endpoint) && Options.SequenceEqual(other.Options, ChannelOptionComparer.Instance);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="endpoint"></param>
        /// <param name="options"></param>
        /// <returns></returns>
        public GcpCallInvoker GetGcpCallInvoker(ServiceEndpoint endpoint, IEnumerable<ChannelOption> options)
        {
            GaxPreconditions.CheckNotNull(endpoint, nameof(endpoint));
            var credentials = _lazyScopedDefaultChannelCredentials.Value.ResultWithUnwrappedExceptions();
            return GetGcpCallInvoker(endpoint, options, credentials);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="endpoint"></param>
        /// <param name="options"></param>
        /// <returns></returns>
        public async Task<GcpCallInvoker> GetGcpCallInvokerAsync(ServiceEndpoint endpoint, IEnumerable<ChannelOption> options)
        {
            GaxPreconditions.CheckNotNull(endpoint, nameof(endpoint));
            var credentials = await _lazyScopedDefaultChannelCredentials.Value.ConfigureAwait(false);
            return GetGcpCallInvoker(endpoint, options, credentials);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="endpoint"></param>
        /// <param name="options"></param>
        /// <param name="credentials"></param>
        /// <returns></returns>
        private GcpCallInvoker GetGcpCallInvoker(ServiceEndpoint endpoint, IEnumerable<ChannelOption> options, ChannelCredentials credentials)
        {
            var optionsList = options?.ToList() ?? new List<ChannelOption>();
            // "After a duration of this time the client/server pings its peer to see if the
            // transport is still alive. Int valued, milliseconds."
            // Required for any channel using a streaming RPC, to ensure an idle stream doesn't
            // allow the TCP connection to be silently dropped by any intermediary network devices.
            // 60 second keepalive time is reasonable. This will only add minimal network traffic,
            // and only if the channel is idle for more than 60 seconds.
            optionsList.Add(new ChannelOption("grpc.keepalive_time_ms", 60_000));

            var key = new GcpCallInvokerKey(endpoint, optionsList);

            lock (_lock)
            {
                if (!_gcpCallInvokers.TryGetValue(key, out GcpCallInvoker callInvoker))
                {
                    callInvoker = new GcpCallInvoker(endpoint.ToString(), credentials, options);
                    _gcpCallInvokers[key] = callInvoker;
                }
                return callInvoker;
            }
        }

        #endregion // NewStuff

        private readonly IEnumerable<string> _scopes;

        /// <summary>
        /// Lazily-created task to retrieve the default application channel credentials. Once completed, this
        /// task can be used whenever channel credentials are required. The returned task always runs in the
        /// thread pool, so its result can be used synchronously from synchronous methods without risk of deadlock.
        /// The same channel credentials are used by all pools. The field is initialized in the constructor, as it uses
        /// _scopes, and you can't refer to an instance field within an instance field initializer.
        /// </summary>
        private readonly Lazy<Task<ChannelCredentials>> _lazyScopedDefaultChannelCredentials;

        // TODO: See if we could use ConcurrentDictionary instead of locking. I suspect the issue would be making an atomic
        // "clear and fetch values" for shutdown.
        private readonly Dictionary<ServiceEndpoint, Channel> _channels = new Dictionary<ServiceEndpoint, Channel>();
        private readonly object _lock = new object();

        /// <summary>
        /// Creates a channel pool which will apply the specified scopes to the default application credentials
        /// if they require any.
        /// </summary>
        /// <param name="scopes">The scopes to apply. Must not be null, and must not contain null references. May be empty.</param>
        public ChannelPool(IEnumerable<string> scopes)
        {
            // Always take a copy of the provided scopes, then check the copy doesn't contain any nulls.
            _scopes = GaxPreconditions.CheckNotNull(scopes, nameof(scopes)).ToList();
            GaxPreconditions.CheckArgument(!_scopes.Any(x => x == null), nameof(scopes), "Scopes must not contain any null references");
            // In theory, we don't actually need to store the scopes as field in this class. We could capture a local variable here.
            // However, it won't be any more efficient, and having the scopes easily available when debugging could be handy.
            _lazyScopedDefaultChannelCredentials = new Lazy<Task<ChannelCredentials>>(() => Task.Run(CreateChannelCredentialsUncached));
        }

        private async Task<ChannelCredentials> CreateChannelCredentialsUncached()
        {
            var appDefaultCredentials = await GoogleCredential.GetApplicationDefaultAsync().ConfigureAwait(false);
            if (appDefaultCredentials.IsCreateScopedRequired)
            {
                appDefaultCredentials = appDefaultCredentials.CreateScoped(_scopes);
            }
            return appDefaultCredentials.ToChannelCredentials();
        }

        /// <summary>
        /// Shuts down all the currently-allocated channels asynchronously. This does not prevent the channel
        /// pool from being used later on, but the currently-allocated channels will not be reused.
        /// </summary>
        /// <returns></returns>
        public Task ShutdownChannelsAsync()
        {
            //List<Channel> channelsToShutdown;
            //lock (_lock)
            //{
            //    channelsToShutdown = _channels.Values.ToList();
            //    _channels.Clear();
            //}
            //var shutdownTasks = channelsToShutdown.Select(c => c.ShutdownAsync());
            //return Task.WhenAll(shutdownTasks);
            #region NewStuff

            List<Channel> channelsToShutdown;
            List<GcpCallInvoker> gcpCallInvokersToShutdown;
            lock (_lock)
            {
                channelsToShutdown = _channels.Values.ToList();
                _channels.Clear();

                gcpCallInvokersToShutdown = _gcpCallInvokers.Values.ToList();
                _gcpCallInvokers.Clear();
            }
            var shutdownTasks = channelsToShutdown.Select(c => c.ShutdownAsync()).Concat(gcpCallInvokersToShutdown.Select(c => c.ShutdownAsync()));
            return Task.WhenAll(shutdownTasks);

            #endregion // NewStuff
        }

        /// <summary>
        /// Returns a channel from this pool, creating a new one if there is no channel
        /// already associated with <paramref name="endpoint"/>.
        /// </summary>
        /// <param name="endpoint">The endpoint to connect to. Must not be null.</param>
        /// <returns>A channel for the specified endpoint.</returns>
        public Channel GetChannel(ServiceEndpoint endpoint)
        {
            GaxPreconditions.CheckNotNull(endpoint, nameof(endpoint));
            var credentials = _lazyScopedDefaultChannelCredentials.Value.ResultWithUnwrappedExceptions();
            return GetChannel(endpoint, credentials);
        }

        /// <summary>
        /// Asynchronously returns a channel from this pool, creating a new one if there is no channel
        /// already associated with <paramref name="endpoint"/>.
        /// </summary>
        /// <param name="endpoint">The endpoint to connect to. Must not be null.</param>
        /// <returns>A task representing the asynchronous operation. The value of the completed
        /// task will be channel for the specified endpoint.</returns>
        public async Task<Channel> GetChannelAsync(ServiceEndpoint endpoint)
        {
            GaxPreconditions.CheckNotNull(endpoint, nameof(endpoint));
            var credentials = await _lazyScopedDefaultChannelCredentials.Value.ConfigureAwait(false);
            return GetChannel(endpoint, credentials);
        }

        private Channel GetChannel(ServiceEndpoint endpoint, ChannelCredentials credentials)
        {
            lock (_lock)
            {
                Channel channel;
                if (!_channels.TryGetValue(endpoint, out channel))
                {
                    var options = new[]
                    {
                        // "After a duration of this time the client/server pings its peer to see if the
                        // transport is still alive. Int valued, milliseconds."
                        // Required for any channel using a streaming RPC, to ensure an idle stream doesn't
                        // allow the TCP connection to be silently dropped by any intermediary network devices.
                        // 60 second keepalive time is reasonable. This will only add minimal network traffic,
                        // and only if the channel is idle for more than 60 seconds.
                        new ChannelOption("grpc.keepalive_time_ms", 60_000)
                    };
                    channel = new Channel(endpoint.Host, endpoint.Port, credentials, options);
                    _channels[endpoint] = channel;
                }
                return channel;
            }
        }
    }

    // TODO: These are copied from Firestore utilities. Perhaps they can go in some common area.
    internal static class EqualityHelpers
    {
        private const int HashInitialValue = 3581;

        /// <summary>
        /// Checks if two lists are equal, in an ordering-sensitive manner.
        /// </summary>
        internal static bool ListsEqual<T>(IReadOnlyList<T> left, IReadOnlyList<T> right)
            where T : IEquatable<T>
        {
            if (ReferenceEquals(left, right))
            {
                return true;
            }
            if (ReferenceEquals(left, null) || ReferenceEquals(right, null))
            {
                return false;
            }
            if (left.Count != right.Count)
            {
                return false;
            }
            for (int i = 0; i < left.Count; i++)
            {
                if (!left[i].Equals(right[i]))
                {
                    return false;
                }
            }
            return true;
        }

        /// <summary>
        /// Computes an ordering-sensitive hash code for a list.
        /// </summary>
        internal static int GetListHashCode<T>(IReadOnlyList<T> list, IEqualityComparer<T> comparer)
        {            
            if (list == null)
            {
                return 0;
            }
            unchecked
            {
                int hash = HashInitialValue;
                int count = list.Count;
                for (int i = 0; i < count; i++)
                {
                    hash = (hash << 5) + hash + comparer.GetHashCode(list[i]);
                }
                return hash;
            }
        }

        // Hash code convenience methods using DJB2 constants.
        // Alternatives would be generic methods that call GetHashCode directly.
        // Only necessary overloads are present; more can be added.
        internal static int CombineHashCodes(int hash1, int hash2)
        {
            unchecked
            {
                int hash = HashInitialValue;
                hash = (hash << 5) + hash + hash1;
                hash = (hash << 5) + hash + hash2;
                return hash;
            }
        }

        internal static int CombineHashCodes(int hash1, int hash2, int hash3)
        {
            unchecked
            {
                int hash = HashInitialValue;
                hash = (hash << 5) + hash + hash1;
                hash = (hash << 5) + hash + hash2;
                hash = (hash << 5) + hash + hash3;
                return hash;
            }
        }

        internal static int CombineHashCodes(int hash1, int hash2, int hash3, int hash4)
        {
            unchecked
            {
                int hash = HashInitialValue;
                hash = (hash << 5) + hash + hash1;
                hash = (hash << 5) + hash + hash2;
                hash = (hash << 5) + hash + hash3;
                hash = (hash << 5) + hash + hash4;
                return hash;
            }
        }

        internal static int CombineHashCodes(int hash1, int hash2, int hash3, int hash4, int hash5, int hash6, int hash7, int hash8)
        {
            unchecked
            {
                int hash = HashInitialValue;
                hash = (hash << 5) + hash + hash1;
                hash = (hash << 5) + hash + hash2;
                hash = (hash << 5) + hash + hash3;
                hash = (hash << 5) + hash + hash4;
                hash = (hash << 5) + hash + hash5;
                hash = (hash << 5) + hash + hash6;
                hash = (hash << 5) + hash + hash7;
                hash = (hash << 5) + hash + hash8;
                return hash;
            }
        }
    }
}
