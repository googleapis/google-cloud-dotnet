// Copyright 2017, Google Inc. All rights reserved.
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
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Google.Cloud.Firestore.Data
{
    /// <summary>
    /// Workaround for https://github.com/grpc/grpc/issues/12355
    /// </summary>
    internal static class GrpcWorkaround
    {
        internal static IAsyncEnumerator<T> CreateCancellationWrapper<T>(Func<CancellationToken, IAsyncEnumerator<T>> call, CancellationToken cancellationToken)
        {
            var cts = CancellationTokenSource.CreateLinkedTokenSource(cancellationToken);
            var enumerator = call(cts.Token);
            Func<CancellationToken, Task<bool>> moveNext = async token =>
            {
                using (token.Register(() => cts.Cancel()))
                {
                    return await enumerator.MoveNext(CancellationToken.None).ConfigureAwait(false);
                }
            };
            return AsyncEnumerable.CreateEnumerator(moveNext, () => enumerator.Current, () => enumerator.Dispose());
        }
    }
}
