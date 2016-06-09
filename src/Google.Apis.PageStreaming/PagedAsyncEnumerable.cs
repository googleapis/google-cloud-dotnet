// Copyright 2016 Google Inc. All Rights Reserved.
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

using Google.Apis.Requests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Google.Apis.PageStreaming
{
    public sealed class PagedAsyncEnumerable<TRequest, TResponse, TResource> : IPagedAsyncEnumerable<TResponse, TResource>
        where TRequest : class, IClientServiceRequest<TResponse>
        where TResponse : class
    {
        private readonly Func<TRequest> _requestProvider;
        private readonly IPageManager<TRequest, TResponse, TResource> _pageManager;

        public PagedAsyncEnumerable(Func<TRequest> requestProvider,
            IPageManager<TRequest, TResponse, TResource> pageManager)
        {
            _requestProvider = Preconditions.CheckNotNull(requestProvider, nameof(requestProvider));
            _pageManager = Preconditions.CheckNotNull(pageManager, nameof(pageManager));
        }

        public IPagedAsyncEnumerator<TResponse> GetEnumerator() => new PagedAsyncEnumerator(_requestProvider(), _pageManager);

        IAsyncEnumerator<TResponse> IAsyncEnumerable<TResponse>.GetEnumerator() => GetEnumerator();

        /// <inheritdoc />
        public IAsyncEnumerable<TResource> Flatten() => this.SelectMany(page => _pageManager.GetResourcesEmptyIfNull(page).ToAsyncEnumerable());

        /// <inheritdoc />
        public IAsyncEnumerable<FixedSizePage<TResource>> WithFixedPageSize(int pageSize) =>
            new FixedPageSizeAsyncEnumerable(this, _pageManager, pageSize);

        private class PagedAsyncEnumerator : IPagedAsyncEnumerator<TResponse>
        {
            private readonly TRequest _request; // This is mutated during iteration
            private readonly IPageManager<TRequest, TResponse, TResource> _pageManager;
            private bool _finished;

            public PagedAsyncEnumerator(TRequest request, IPageManager<TRequest, TResponse, TResource> pageManager)
            {
                _request = request;
                _pageManager = pageManager;
            }

            public TResponse Current { get; private set; }

            public async Task<bool> MoveNext(CancellationToken cancellationToken)
            {
                cancellationToken.ThrowIfCancellationRequested();
                if (_finished)
                {
                    return false;
                }
                Current = await _request.ExecuteAsync(cancellationToken);
                var nextPageToken = _pageManager.GetNextPageToken(Current);
                if (nextPageToken == null)
                {
                    _finished = true;
                }
                // Prepare the next request...
                _pageManager.SetPageToken(_request, nextPageToken);
                return true;
            }

            public Task<bool> MoveNext(int pageSize, CancellationToken cancellationToken)
            {
                _pageManager.SetPageSize(_request, pageSize);
                return MoveNext(cancellationToken);
            }

            public void Dispose() { }
        }

        private class FixedPageSizeAsyncEnumerable : IAsyncEnumerable<FixedSizePage<TResource>>
        {
            private readonly IPagedAsyncEnumerable<TResponse, TResource> _source;
            private readonly int _pageSize;
            private readonly IPageManager<TRequest, TResponse, TResource> _pageManager;

            internal FixedPageSizeAsyncEnumerable(
                IPagedAsyncEnumerable<TResponse, TResource> source,
                IPageManager<TRequest, TResponse, TResource> pageManager,
                int pageSize)
            {
                _source = source;
                _pageManager = pageManager;
                _pageSize = pageSize;
            }

            public IAsyncEnumerator<FixedSizePage<TResource>> GetEnumerator() =>
                new Enumerator(_source.GetEnumerator(), _pageManager, _pageSize);

            private class Enumerator : IAsyncEnumerator<FixedSizePage<TResource>>
            {
                private readonly IPagedAsyncEnumerator<TResponse> _enumerator;
                private readonly int _pageSize;
                private readonly IPageManager<TRequest, TResponse, TResource> _pageManager;

                internal Enumerator(
                    IPagedAsyncEnumerator<TResponse> enumerator,
                    IPageManager<TRequest, TResponse, TResource> pageManager,
                    int pageSize)
                {
                    _enumerator = enumerator;
                    _pageManager = pageManager;
                    _pageSize = pageSize;
                }

                public FixedSizePage<TResource> Current { get; private set; }

                public async Task<bool> MoveNext(CancellationToken cancellationToken)
                {
                    var items = new List<TResource>(_pageSize);
                    while (items.Count < _pageSize)
                    {
                        cancellationToken.ThrowIfCancellationRequested();
                        int requestCount = _pageSize - items.Count;
                        var done = !(await _enumerator.MoveNext(requestCount, cancellationToken).ConfigureAwait(false));
                        if (done)
                        {
                            break;
                        }
                        var resources = _pageManager.GetResourcesEmptyIfNull(_enumerator.Current);
                        items.AddRange(resources);
                        if (items.Count > _pageSize)
                        {
                            // TODO: B  etter exception type?
                            throw new NotSupportedException("Invalid server response: " +
                                $"requested {requestCount} items, received {resources.Count()} items");
                        }
                    }
                    if (items.Count != 0)
                    {
                        Current = new FixedSizePage<TResource>(items, _pageManager.GetNextPageToken(_enumerator.Current));
                        return true;
                    }
                    Current = null;
                    return false;
                }

                public void Dispose()
                {
                    _enumerator.Dispose();
                }
            }
        }

    }
}