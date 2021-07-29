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

using System.Threading;
using System.Threading.Tasks;

// This class uses TaskHelper.ConfigureAwait, rather than directly calling .ConfigureAwait().
// When running in a non-test environment this indirectly calls .ConfigureAwait(false).
// Disable the ConfigureAwaitChecker warning:
#pragma warning disable CAC001
#pragma warning disable CAC002

namespace Google.Cloud.PubSub.V1.Tasks
{
    /// <summary>
    /// Auto-reset async event. Releases all waiting threads on Set().
    /// </summary>
    internal class AsyncAutoResetEvent
    {
        public AsyncAutoResetEvent(TaskHelper taskHelper) => _taskHelper = taskHelper;

        private readonly object _lock = new object();
        private readonly TaskHelper _taskHelper;
        private TaskCompletionSource<int> _tcs = new TaskCompletionSource<int>();

        public async Task WaitAsync(CancellationToken cancellationToken)
        {
            TaskCompletionSource<int> tcs;
            lock (_lock)
            {
                tcs = _tcs;
            }
            using (cancellationToken.Register(() => tcs.TrySetCanceled()))
            {
                try
                {
                    await _taskHelper.ConfigureAwait(tcs.Task);
                }
                finally
                {
                    lock (_lock)
                    {
                        // If multiple threads waiting,
                        // ensure _tcs is only updated by the first thread in this lock
                        if (ReferenceEquals(tcs, _tcs))
                        {
                            _tcs = new TaskCompletionSource<int>();
                        }
                    }
                }
            }
        }

        public void Set()
        {
            TaskCompletionSource<int> tcs;
            lock (_lock)
            {
                tcs = _tcs;
            }
            // Must no call TrySetResult() in lock, as it may execute
            // continuations synchronously in the TrySetResult() call.
            tcs.TrySetResult(0);
        }
    }
}
