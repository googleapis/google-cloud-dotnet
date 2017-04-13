using System;
using System.Collections.Concurrent;
using System.Threading;
using System.Threading.Tasks;
using Google.Api.Gax.Grpc;
using Google.Apis.Auth.OAuth2;
using Grpc.Auth;

namespace Google.Cloud.Spanner.V1
{
    internal static class ClientPool
    {
        static readonly ConcurrentDictionary<ITokenAccess, ClientEntry> ClientEntryPool =
                new ConcurrentDictionary<ITokenAccess, ClientEntry>();

        public static async Task<SpannerClient> AcquireClientAsync(ITokenAccess credentials)
        {
            ClientEntry entry = ClientEntryPool.GetOrAdd(credentials ?? ApplicationDefault.Instance, key => new ClientEntry(key));
            return await entry.AcquireClientFromEntryAsync();
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
            ClientEntryPool.Clear();
        }

        public class ClientEntry
        {
            private readonly ITokenAccess _credential;
            private SpannerClient _client;

            public ClientEntry(ITokenAccess credential)
            {
                _credential = credential;
            }

            public async Task<SpannerClient> AcquireClientFromEntryAsync()
            {
                if (_client == null)
                {
                    if (_credential != null && _credential != ApplicationDefault.Instance)
                    {
                        _client = await SpannerClient.CreateAsync(SpannerClient.DefaultEndpoint,
                            new SpannerSettings
                            {
                                CallSettings = CallSettings.FromCallCredentials(_credential.ToCallCredentials())
                            });
                    }
                    else
                    {
                        _client = await SpannerClient.CreateAsync(SpannerClient.DefaultEndpoint);
                    }
                }

                return _client;
            }
        }

        private class ApplicationDefault : ITokenAccess
        {
            public static readonly ApplicationDefault Instance = new ApplicationDefault();
            private ApplicationDefault()
            {
            }

            public Task<string> GetAccessTokenForRequestAsync(string authUri = null, CancellationToken cancellationToken = default(CancellationToken))
            {
                throw new NotImplementedException();
            }
        }
    }
}
