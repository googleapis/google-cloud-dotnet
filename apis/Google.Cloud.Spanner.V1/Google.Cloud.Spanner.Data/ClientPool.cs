using System;
using System.Collections.Concurrent;
using System.Threading;
using System.Threading.Tasks;
using Google.Api.Gax.Grpc;
using Google.Apis.Auth.OAuth2;
using Google.Cloud.Spanner.V1;
using Grpc.Auth;

namespace Google.Cloud.Spanner
{
    internal static class ClientPool
    {
        static readonly ConcurrentDictionary<ClientPoolKey, ClientPoolEntry> s_clientEntryPool =
            new ConcurrentDictionary<ClientPoolKey, ClientPoolEntry>();

        public static Task<SpannerClient> AcquireClientAsync()
        {
            return AcquireClientAsync(null, null);
        }

        public static async Task<SpannerClient> AcquireClientAsync(ITokenAccess credentials, ServiceEndpoint endpoint)
        {
            ClientPoolKey key = new ClientPoolKey {
                Credential = credentials ?? ApplicationDefault.Instance,
                Endpoint = endpoint ?? SpannerClient.DefaultEndpoint
            };
            ClientPoolEntry poolEntry = s_clientEntryPool.GetOrAdd(key, k => new ClientPoolEntry(key));
            return await poolEntry.AcquireClientFromEntryAsync();
        }

        public static int Timeout { get; set; }

        /// <summary>
        /// Callers should be careful not to call AcquireClient while CloseAll is still running.
        /// It is possible to obtain a stale client.
        /// </summary>
        /// <returns></returns>
        public static async Task CloseAllAsync()
        {
            await SpannerClient.ShutdownDefaultChannelsAsync();
            s_clientEntryPool.Clear();
        }

        struct ClientPoolKey
        {
            public ITokenAccess Credential;
            public ServiceEndpoint Endpoint;
        }

        class ClientPoolEntry
        {
            private readonly ClientPoolKey _key;
            private SpannerClient _client;

            public ClientPoolEntry(ClientPoolKey key)
            {
                _key = key;
            }

            public async Task<SpannerClient> AcquireClientFromEntryAsync()
            {
                if (_client == null)
                {
                    if (_key.Credential != null && _key.Credential != ApplicationDefault.Instance)
                    {
                        //TODO use a custom channel with specified credentials instead of the pool.
                        _client = await SpannerClient.CreateAsync(_key.Endpoint ?? SpannerClient.DefaultEndpoint,
                            new SpannerSettings
                            {
                                CallSettings = CallSettings.FromCallCredentials(_key.Credential.ToCallCredentials())
                            });
                    }
                    else
                    {
                        _client = await SpannerClient.CreateAsync(_key.Endpoint ?? SpannerClient.DefaultEndpoint);
                    }
                }

                return _client;
            }
        }

        private class ApplicationDefault : ITokenAccess
        {
            private ApplicationDefault()
            {
            }

            public static ApplicationDefault Instance { get; } = new ApplicationDefault();

            public Task<string> GetAccessTokenForRequestAsync(string authUri = null, CancellationToken cancellationToken = default(CancellationToken))
            {
                throw new NotImplementedException();
            }
        }
    }
}
