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

using System;
using System.Threading;

namespace Google.Cloud.Spanner.V1;

public partial class SpannerClientImpl
{
    /// <summary>
    /// The process ID. Can be set only once and before any Spanner request has been executed.
    /// </summary>
    /// <exception cref="InvalidOperationException">The process ID has already been set.</exception>
    internal static ulong ProcessId
    {
        set
        {
            if (!ProcessIdSource.TrySetProcessId(value))
            {
                throw new InvalidOperationException("The Process ID was already set and cannot be overwritten now.");
            }
        }
    }

    private static class ProcessIdSource
    {
        private static string s_explicitvalue;
        private static readonly Lazy<string> ProcessIdCache = new Lazy<string>(ProcessIdUncached, LazyThreadSafetyMode.ExecutionAndPublication);

        internal static string Value => ProcessIdCache.Value;

        internal static bool TrySetProcessId(ulong id) =>
            Interlocked.CompareExchange(ref s_explicitvalue, id.ToString(), null) == null;

        private static string ProcessIdUncached()
        {
            // ProcessId had not been explicitly set, we need to generate one.
            // And it's perfectly fine that we left it set to zero,
            // that's enough to make it fail if someone tries to change it,
            // and we won't use that value anymore.
            if (TrySetProcessId(0))
            {
                var random = new Random();
                var buffer = new byte[sizeof(ulong)];
                random.NextBytes(buffer);
                return BitConverter.ToUInt64(buffer, 0).ToString();
            }
            return s_explicitvalue;
        }
    }
}
