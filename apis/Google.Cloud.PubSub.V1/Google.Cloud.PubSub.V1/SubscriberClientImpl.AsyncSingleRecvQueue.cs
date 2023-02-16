// Copyright 2023 Google LLC
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

using Google.Cloud.PubSub.V1.Tasks;
using System.Collections.Generic;
using System.Threading.Tasks;

// This class uses TaskHelper.ConfigureAwait, rather than directly calling .ConfigureAwait().
// When running in a non-test environment this indirectly calls .ConfigureAwait(false).
// Disable the ConfigureAwaitChecker warning:
#pragma warning disable CAC002

namespace Google.Cloud.PubSub.V1;

public sealed partial class SubscriberClientImpl
{
    internal class AsyncSingleRecvQueue<T>
    {
        private readonly TaskHelper _taskHelper;
        private readonly object _lock = new object();
        private readonly Queue<T> _queue = new Queue<T>();
        private TaskCompletionSource<int> _tcs = null;

        internal AsyncSingleRecvQueue(TaskHelper taskHelper) => _taskHelper = taskHelper;

        // Thread-safe.
        internal void Enqueue(T item)
        {
            TaskCompletionSource<int> tcs;
            lock (_lock)
            {
                _queue.Enqueue(item);
                tcs = _tcs;
            }
            if (tcs != null)
            {
                // Don't run in lock, as it may execute continuations synchronously.
                // Use TrySetResult as this can be called multiple times on the same tcs instance
                tcs.TrySetResult(0);
            }
        }

        // Thread-safe to use concurrently with Enqueue(),
        // but this DequeueAsync() method must *not* be called concurrently.
        internal async Task<T> DequeueAsync()
        {
            lock (_lock)
            {
                if (_queue.Count > 0)
                {
                    return _queue.Dequeue();
                }
                _tcs = new TaskCompletionSource<int>();
            }
            await _taskHelper.ConfigureAwait(_tcs.Task);
            lock (_lock)
            {
                _tcs = null;
                return _queue.Dequeue();
            }
        }
    }
}
