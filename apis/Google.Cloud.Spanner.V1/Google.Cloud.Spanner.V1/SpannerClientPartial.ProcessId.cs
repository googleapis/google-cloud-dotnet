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
    /// The process ID.
    /// </summary>
    /// <exception cref="InvalidOperationException">The process ID has already been set.</exception>
    internal static ulong ProcessId
    {
        set => ProcessIdSource.Set(value);
    }

    private static class ProcessIdSource
    {
        private static string s_value;
        internal static string Value
        {
            get
            {
                // If not set, attempt to set it with a new random value.
                // (It's okay if multiple threads generate a value; only the first one wins).
                if (s_value == null)
                {
                    Interlocked.CompareExchange(ref s_value, GenerateId(), null);
                }
                return s_value;
            }
        }

        internal static void Set(ulong id)
        {
            // Atomically set the value. If it was already set (i.e. returns non-null), throw.
            if (Interlocked.CompareExchange(ref s_value, id.ToString(), null) != null)
            {
                throw new InvalidOperationException("The Process ID was already set and cannot be overwritten now.");
            }
        }

        private static string GenerateId()
        {
            var random = new Random();
            var buffer = new byte[sizeof(ulong)];
            random.NextBytes(buffer);
            return BitConverter.ToUInt64(buffer, 0).ToString();
        }
    }
}
