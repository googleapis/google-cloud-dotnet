using System;
using System.Collections.Concurrent;
using System.Threading.Tasks;
using Google.Api.Gax.Grpc;
using Google.Apis.Auth.OAuth2;
using Google.Cloud.Spanner.V1;
using Google.Cloud.Spanner.V1.Logging;
using Grpc.Auth;
using Grpc.Core;

namespace Google.Cloud.Spanner.Data
{
    internal static class ClientPool
    {
        private static readonly ConcurrentDictionary<ClientPoolKey, ClientPoolEntry> s_clientEntryPool =
            new ConcurrentDictionary<ClientPoolKey, ClientPoolEntry>();

        public static async Task<SpannerClient> AcquireClientAsync(ITokenAccess credentials = null,
            ServiceEndpoint endpoint = null)
        {
            var key = new ClientPoolKey(credentials, endpoint ?? SpannerClient.DefaultEndpoint);
            var poolEntry = s_clientEntryPool.GetOrAdd(key, k => new ClientPoolEntry(key));
            var result = await poolEntry.AcquireClientFromEntryAsync().ConfigureAwait(false);
            Logger.LogPerformanceCounter("SpannerClient.Count", () => s_clientEntryPool.Count);
            return result;
        }

        /// <summary>
        /// Callers should be careful not to call AcquireClient while CloseAll is still running.
        /// It is possible to obtain a stale client.
        /// </summary>
        /// <returns></returns>
        public static async Task CloseAllAsync()
        {
            Logger.Debug(() => "Shutting down all gRPC channels.");
            await SpannerClient.ShutdownDefaultChannelsAsync().ConfigureAwait(false);
            s_clientEntryPool.Clear();
        }

        private struct ClientPoolKey : IEquatable<ClientPoolKey>
        {
            public ITokenAccess Credential { get; }
            public ServiceEndpoint Endpoint { get; }

            public ClientPoolKey(ITokenAccess tokenAccess, ServiceEndpoint serviceEndpoint) : this()
            {
                Credential = tokenAccess;
                Endpoint = serviceEndpoint;
            }

            public bool Equals(ClientPoolKey other)
            {
                return Equals(Credential, other.Credential) && Equals(Endpoint, other.Endpoint);
            }

            public override bool Equals(object obj)
            {
                if (ReferenceEquals(null, obj)) return false;
                return obj is ClientPoolKey && Equals((ClientPoolKey) obj);
            }

            public override int GetHashCode()
            {
                unchecked
                {
                    return ((Credential != null ? Credential.GetHashCode() : 0) * 397) ^ (Endpoint != null ? Endpoint.GetHashCode() : 0);
                }
            }
        }

        private class ClientPoolEntry
        {
            private readonly ClientPoolKey _key;
            private SpannerClient _client;
            private volatile Task<SpannerClient> _creationTask;
            private readonly object _sync = new object();

            public ClientPoolEntry(ClientPoolKey key)
            {
                _key = key;
            }

            public async Task<SpannerClient> AcquireClientFromEntryAsync()
            {
                if (_client == null)
                {
                    Logger.Debug(() => "Creating a new SpannerClient.");
                    var endpoint = _key.Endpoint ?? SpannerClient.DefaultEndpoint;
                    if (_key.Credential != null)
                    {
                        lock (_sync) {
                            if (_client == null) {
                                var channel = new Channel(endpoint.Host,
                                    endpoint.Port,
                                    _key.Credential.ToChannelCredentials());
                                _client = SpannerClient.Create(channel);
                            }
                        }
                    }
                    else
                    {
                        lock (_sync) {
                            if (_creationTask == null || _creationTask.IsFaulted) {
                                _creationTask = SpannerClient.CreateAsync(endpoint);
                            }
                        }
                        // await needs to be done outside of the monitor.
                        _client = await _creationTask.ConfigureAwait(false);
                    }
                }

                return _client;
            }
        }
    }
}