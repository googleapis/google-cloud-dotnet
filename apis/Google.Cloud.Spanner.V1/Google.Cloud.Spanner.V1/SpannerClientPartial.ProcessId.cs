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

namespace Google.Cloud.Spanner.V1;

public partial class SpannerClientImpl
{
    /// <summary>
    /// The process ID.
    /// </summary>
    /// <exception cref="InvalidOperationException">The process ID has already been set.</exception>
    internal static ulong ProcessId
    {
        set => ProcessIdSource.Value = value;
    }

    private static class ProcessIdSource
    {
        private static ulong s_processId;
        private static bool s_isProcessIdSet = false;
        private static readonly object s_lock = new();

        /// <summary>
        /// A unique ID for the user application process. This value can only be set once.
        /// </summary>
        /// <exception cref="InvalidOperationException">The process ID has already been set.</exception>
        internal static ulong Value
        {
            get => GetProcessId();
            set
            {
                if(!TrySetProcessId(value))
                {
                     throw new InvalidOperationException("ProcessId cannot be changed after it has been set.");
                }
            }
        }

        /// <summary>
        /// Returns the process ID, generating and storing it if it hasn't been set yet.
        /// </summary>
        private static ulong GetProcessId()
        {
            if (!s_isProcessIdSet)
            {
                // If it's not set we default to a rand ulong. This is thread safe. Another process may set this before
                // us, but that's alright.
                TrySetProcessId(GenerateRandomUlong());
            }

            return s_processId;

            static ulong GenerateRandomUlong()
            {
                var random = new Random();
                var buffer = new byte[sizeof(ulong)];
                random.NextBytes(buffer);
                return BitConverter.ToUInt64(buffer, 0);
            }
        }

        private static bool TrySetProcessId(ulong value)
        {
            lock (s_lock)
            {
                if (s_isProcessIdSet)
                {
                    // It was set by another thread while we were waiting for the lock
                    return false;
                }
                s_processId = value;
                s_isProcessIdSet = true;
                return true;
            }
        }
    }
}
