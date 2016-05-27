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
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Google.Apis.PageStreaming
{
    public sealed class PagedEnumerable<TRequest, TResponse, TResource> : IPagedEnumerable<TResponse, TResource>
        where TRequest : class, IClientServiceRequest<TResponse>
        where TResponse : class
    {
        private readonly Func<TRequest> _requestProvider;
        private readonly IPageManager<TRequest, TResponse, TResource> _pageManager;

        public PagedEnumerable(Func<TRequest> requestProvider,
            IPageManager<TRequest, TResponse, TResource> pageManager)
        {
            _requestProvider = Preconditions.CheckNotNull(requestProvider, nameof(requestProvider));
            _pageManager = Preconditions.CheckNotNull(pageManager, nameof(pageManager));
        }

        public IPagedEnumerator<TResponse> GetEnumerator() => new PagedEnumerator(_requestProvider(), _pageManager);

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
        IEnumerator<TResponse> IEnumerable<TResponse>.GetEnumerator() => GetEnumerator();

        /// <inheritdoc />
        public IEnumerable<TResource> Flatten() => this.SelectMany(page => _pageManager.GetResourcesEmptyIfNull(page));

        /// <inheritdoc />
        public IEnumerable<FixedSizePage<TResource>> WithFixedPageSize(int pageSize)
        {
            Preconditions.CheckArgument(pageSize > 0, nameof(pageSize), "Must be greater than 0");
            using (var enumerator = GetEnumerator())
            {
                bool done = false;
                while (!done)
                {
                    var items = new List<TResource>(pageSize);
                    while (items.Count < pageSize)
                    {
                        int requestCount = pageSize - items.Count;
                        done = !enumerator.MoveNext(requestCount);
                        if (done)
                        {
                            break;
                        }
                        var resources = _pageManager.GetResourcesEmptyIfNull(enumerator.Current);
                        items.AddRange(resources);
                        if (items.Count > pageSize)
                        {
                            throw new NotSupportedException("Invalid server response: " +
                                $"requested {requestCount} items, received {resources.Count()} items");
                        }
                    }
                    if (items.Count != 0)
                    {
                        yield return new FixedSizePage<TResource>(items, _pageManager.GetNextPageToken(enumerator.Current));
                    }
                }
            }
        }

        private class PagedEnumerator : IPagedEnumerator<TResponse>
        {
            private readonly TRequest _request; // This is mutated during iteration
            private readonly IPageManager<TRequest, TResponse, TResource> _pageManager;
            private bool _finished;

            public PagedEnumerator(TRequest request, IPageManager<TRequest, TResponse, TResource> pageManager)
            {
                _request = request;
                _pageManager = pageManager;
            }

            public TResponse Current { get; private set; }

            object IEnumerator.Current => Current;

            public bool MoveNext()
            {
                if (_finished)
                {
                    return false;
                }
                Current = _request.Execute();
                var nextPageToken = _pageManager.GetNextPageToken(Current);
                if (nextPageToken == null)
                {
                    _finished = true;
                }
                // Prepare the next request...
                _pageManager.SetPageToken(_request, nextPageToken);
                return true;
            }

            public bool MoveNext(int pageSize)
            {
                _pageManager.SetPageSize(_request, pageSize);
                return MoveNext();
            }

            public void Reset()
            {
                throw new NotImplementedException();
            }

            public void Dispose() { }
        }
    }
}
