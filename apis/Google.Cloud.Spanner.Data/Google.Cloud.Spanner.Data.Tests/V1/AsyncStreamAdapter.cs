// Copyright 2019 Google LLC
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

using Grpc.Core;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Google.Cloud.Spanner.V1.Tests
{
    // TODO: Move this to GAX?
    /// <summary>
    /// Adapter to wrap an IAsyncEnumerator{T} into the gRPC IAsyncStreamReader{T} type.
    /// </summary>
    internal sealed class AsyncStreamAdapter<T> : IAsyncStreamReader<T>
    {
        private readonly IAsyncEnumerator<T> _enumerator;

        internal AsyncStreamAdapter(IAsyncEnumerator<T> enumerator)
        {
            _enumerator = enumerator;
        }

        public T Current => _enumerator.Current;
        public void Dispose() => _enumerator.Dispose();
        public Task<bool> MoveNext(CancellationToken cancellationToken) => _enumerator.MoveNext(cancellationToken);
    }
}
