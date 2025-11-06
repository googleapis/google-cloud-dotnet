// Copyright 2025 Google LLC
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
using System.Threading.Tasks;

namespace Google.Cloud.Spanner.V1.Tests.Common;

/// <summary>
/// IAsyncStreamReader{T} implementation that immediately signals the end of the stream.
/// Used as a placeholder in test CallInvokers where no data is expected.
/// </summary>
/// <typeparam name="T">The message type.</typeparam>
public class EmptyAsyncStreamReader<T> : IAsyncStreamReader<T>
{
    /// <inheritdoc/>
    public T Current => default;

    /// <inheritdoc/>
    public Task<bool> MoveNext(System.Threading.CancellationToken cancellationToken)
    {
        return Task.FromResult(false);
    }
}
