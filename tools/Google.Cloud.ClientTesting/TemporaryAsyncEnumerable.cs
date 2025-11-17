// Copyright 2025 Google LLC
//
// Licensed under the Apache License, Version 2.0 (the "License"):
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

using System.Collections.Generic;
using System.Threading.Tasks;

namespace System.Linq;

/// <summary>
/// Temporarily allow snippets that were using System.Linq.Async to break that dependency.
/// New snippets will be generated with await foreach, with the change in
/// https://github.com/googleapis/gapic-generator-csharp/pull/928, but this
/// allows us to remove the dependency before updating the generator.
/// Once the generator is updated, we can (and should) remove this file.
/// See https://github.com/googleapis/google-cloud-dotnet/issues/15037 for more details.
/// </summary>
public static class AsyncEnumerable
{
    public static async Task ForEachAsync<T>(this IAsyncEnumerable<T> source, Action<T> action)
    {
        await foreach (var item in source)
        {
            action(item);
        }
    }
}
