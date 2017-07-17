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
using System.Collections.Concurrent;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Google.Api.Gax;
using Google.Api.Gax.Grpc;
using Google.Apis.Auth.OAuth2;
using Google.Cloud.Spanner.V1;
using Google.Cloud.Spanner.V1.Internal;
using Google.Cloud.Spanner.V1.Internal.Logging;
using Grpc.Auth;
using Grpc.Core;

namespace Google.Cloud.Spanner.Data
{

    internal class ClientPool
    {
        public static ClientPool Default { get; } = new ClientPool();

        private readonly ConcurrentDictionary<ClientCredentialKey, CredentialClientPool> _clientPoolByCredential =
            new ConcurrentDictionary<ClientCredentialKey, CredentialClientPool>();
        private readonly ISpannerClientFactory _clientFactory;

        // ReSharper disable once MemberCanBePrivate.Global
        internal ClientPool(ISpannerClientFactory clientFactory = null)
        {
            _clientFactory = clientFactory ?? SpannerClientFactory.Default;
        }

        public async Task<SpannerClient> AcquireClientAsync(
            ITokenAccess credentials = null,
            ServiceEndpoint endpoint = null)
        {
            var key = new ClientCredentialKey(credentials, endpoint);
            var poolEntry = _clientPoolByCredential.GetOrAdd(key, k => new CredentialClientPool(k));
            var result = await poolEntry.AcquireClientAsync(_clientFactory).ConfigureAwait(false);
            Logger.LogPerformanceCounter("SpannerClient.TotalCount", () => _clientPoolByCredential.Count);
            return result;
        }

        //ReSharper disable once UnusedMember.Global
        //Returns the total of all reference counts.
        //For test purposes only.
        // poolContents will be filled with the current contents of the pool and may not be null.
        internal int GetPoolInfo(StringBuilder poolContents)
        {
            GaxPreconditions.CheckNotNull(poolContents, nameof(poolContents));
            int referenceCountTotal = 0;
            poolContents.AppendLine("ClientPool.Contents:");
            int i = 0;
            foreach (var kvp in _clientPoolByCredential)
            {
                poolContents.AppendLine($"s_clientPoolByCredential({i}) Key:${kvp.Key}");
                referenceCountTotal += kvp.Value.DumpCredentialPoolContents(poolContents);
                i++;
            }
            return referenceCountTotal;
        }

        public void ReleaseClient(SpannerClient spannerClient,
            ITokenAccess credentials = null,
            ServiceEndpoint endpoint = null)
        {
            if (spannerClient != null)
            {
                var key = new ClientCredentialKey(credentials, endpoint);
                CredentialClientPool poolEntry;
                if (_clientPoolByCredential.TryGetValue(key, out poolEntry))
                {
                    poolEntry.ReleaseClient(spannerClient);
                }
                else
                {
                    Logger.Error(() => "An attempt was made to release an unrecognized spanner client to the pool.");
                }
            }
        }

        private struct ClientCredentialKey : IEquatable<ClientCredentialKey>
        {
            public ITokenAccess Credential { get; }
            public ServiceEndpoint Endpoint { get; }

            public ClientCredentialKey(ITokenAccess tokenAccess, ServiceEndpoint serviceEndpoint) : this()
            {
                Credential = tokenAccess;
                Endpoint = serviceEndpoint ?? SpannerClient.DefaultEndpoint;
            }

            public bool Equals(ClientCredentialKey other) => Equals(Credential, other.Credential) &&
                Equals(Endpoint, other.Endpoint);

            public override bool Equals(object obj) => obj is ClientCredentialKey other && Equals(other);

            /// <inheritdoc />
            public override int GetHashCode()
            {
                unchecked
                {
                    return ((Credential?.GetHashCode() ?? 0) * 397) ^
                        (Endpoint?.GetHashCode() ?? 0);
                }
            }

            /// <inheritdoc />
            public override string ToString()
            {
                return $"Credential:{Credential?.ToString() ?? "null"} EndPoint:{Endpoint}";
            }
        }

        private class CredentialClientPool
        {
            private readonly ClientCredentialKey _key;
            private readonly PriorityList<SpannerClientCreator> _clientPriorityList =
                new PriorityList<SpannerClientCreator>();
            private readonly object _sync = new object();


            public CredentialClientPool(ClientCredentialKey key) => _key = key;

            //Returns the total sum of reference counts.
            internal int DumpCredentialPoolContents(StringBuilder stringBuilder)
            {
                lock (_sync)
                {
                    int referenceCountTotal = 0;
                    int i = 0;
                    foreach (var item in _clientPriorityList.GetSnapshot())
                    {
                        stringBuilder.AppendLine($"  {i}:{item}");
                        referenceCountTotal += item.RefCount;
                        i++;
                    }
                    return referenceCountTotal;
                }
            }

            public Task<SpannerClient> AcquireClientAsync(ISpannerClientFactory clientFactory)
            {
                Task<SpannerClient> result;

                lock (_sync)
                {
                    var snapshotMaximumChannels = SpannerOptions.Instance.MaximumGrpcChannels;
                    //first ensure that the pool is of the correct size.
                    while (_clientPriorityList.Count > snapshotMaximumChannels)
                    {
                        _clientPriorityList.RemoveLast();
                    }
                    while (_clientPriorityList.Count < snapshotMaximumChannels)
                    {
                        var newEntry = new SpannerClientCreator(_key);
                        _clientPriorityList.Add(newEntry);
                    }

                    //now grab the first item in the sorted list, increment refcnt, re-sort and return.
                    //The re-sorting will happen as a consequence of AcquireClientAsync changing its
                    //state and firing an event the prioritylist listens to.
                    result = _clientPriorityList.GetTop().AcquireClientAsync(clientFactory);
                }
                return result;
            }

            public void ReleaseClient(SpannerClient client)
            {
                lock (_sync)
                {
                    //find the entry and release refcnt and re-sort
                    SpannerClientCreator match;
                    if (_clientPriorityList.TryFindLinear(x => x.MatchesClient(client), out match)) {
                        match.Release();
                    }
                }
            }
        }

        private class SpannerClientCreator : IPriorityListItem<SpannerClientCreator>
        {
            private Lazy<Task<SpannerClient>> _creationTask;
            private int _refCount = 0;
            private readonly ClientCredentialKey _parentKey;
            // ReSharper disable once InconsistentNaming

            public SpannerClientCreator(ClientCredentialKey parentKey)
            {
                _parentKey = parentKey;
            }

            internal int RefCount => _refCount;

            public bool MatchesClient(SpannerClient client) => _creationTask != null
                && _creationTask.IsValueCreated
                && !_creationTask.Value.IsFaulted
                && ReferenceEquals(_creationTask.Value.ResultWithUnwrappedExceptions(), client);

            public async Task<SpannerClient> AcquireClientAsync(ISpannerClientFactory clientFactory)
            {
                if (_creationTask == null || _creationTask.Value.IsFaulted)
                {
                    //retry an already failed task.
                    _creationTask = new Lazy<Task<SpannerClient>>(
                        () => clientFactory.CreateClientAsync(_parentKey.Endpoint, _parentKey.Credential));
                }

                var spannerClient = await _creationTask.Value.ConfigureAwait(false);
                Interlocked.Increment(ref _refCount);
                OnPriorityChanged();

                return spannerClient;
            }

            public void Release()
            {
                Interlocked.Decrement(ref _refCount);
                OnPriorityChanged();
            }

            /// <inheritdoc />
            public int CompareTo(SpannerClientCreator other)
            {
                if (ReferenceEquals(this, other))
                {
                    return 0;
                }
                if (ReferenceEquals(null, other))
                {
                    return 1;
                }
                int refCountComparison = RefCount.CompareTo(other.RefCount);
                if (refCountComparison != 0)
                {
                    return refCountComparison;
                }
                // This has a chance of returning 0 even if the object is not the same instance.
                // That is fine and is handled by the PriorityHeap.

                // Note: SpannerClients if created sequentially should only use a single channel.
                // This is to faciliate good session pool hits (which is per channel).  If we always
                // round robin'd clients, then we would get hard cache misses until we populated all
                // of the caches per channel.
                // We accomplish this by having a specified sort order based on hash if there is
                // a tie based on refcnt.
                return GetHashCode().CompareTo(other.GetHashCode());
            }

            /// <inheritdoc />
            public override string ToString()
            {
                return $"RefCount:{RefCount}. ParentHashCode{GetHashCode()}";
            }
            private void OnPriorityChanged()
            {
                PriorityChanged?.Invoke(this, EventArgs.Empty);
            }

            /// <inheritdoc />
            public event EventHandler<EventArgs> PriorityChanged;
        }
    }
}
