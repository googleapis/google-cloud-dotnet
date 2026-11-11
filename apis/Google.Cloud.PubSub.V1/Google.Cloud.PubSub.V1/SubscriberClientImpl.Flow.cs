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
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

// This class uses TaskHelper.ConfigureAwait, rather than directly calling .ConfigureAwait().
// When running in a non-test environment this indirectly calls .ConfigureAwait(false).
// Disable the ConfigureAwaitChecker warning:
#pragma warning disable CAC001
#pragma warning disable CAC002

namespace Google.Cloud.PubSub.V1;

public sealed partial class SubscriberClientImpl
{
    /// <summary>
    /// Implements flow control for received messages.
    /// Processes received messages so long as the current outstanding message-count and byte-count are below limits.
    /// </summary>
    private class Flow
    {
        private readonly struct FnInfo
        {
            internal Func<Task> Fn { get; }
            internal long ByteCount { get; }

            internal FnInfo(Func<Task> fn, long byteCount)
            {
                Fn = fn;
                ByteCount = byteCount;
            }
        }

        // Guards _byteCount, _elementCount, _keyedTaskQs, and _waiters.
        private readonly object _lock = new object();
        private readonly Action<Task> _registerTaskFn;
        private readonly TaskHelper _taskHelper;
        // Waiters blocked while flow-control limits are reached; added and drained under _lock, signaled outside _lock.
        private readonly List<TaskCompletionSource<int>> _waiters = new List<TaskCompletionSource<int>>();
        // Tracking of messages with ordering-keys.
        private readonly Dictionary<string, Queue<FnInfo>> _keyedTaskQs = new Dictionary<string, Queue<FnInfo>>();

        private long _byteCount;
        private long _elementCount;

        internal long MaxOutstandingByteCount { get; }
        internal long MaxOutstandingElementCount { get; }

        internal Flow(long maxOutstandingByteCount, long maxOutstandingElementCount, Action<Task> registerTaskFn, TaskHelper taskHelper)
        {
            MaxOutstandingByteCount = maxOutstandingByteCount;
            MaxOutstandingElementCount = maxOutstandingElementCount;
            _registerTaskFn = registerTaskFn;
            _taskHelper = taskHelper;
        }

        /// <summary>
        /// Is flow-control currently within limits. Pre-condition: must be locked.
        /// </summary>
        private bool IsFlowOk() => _byteCount < MaxOutstandingByteCount && _elementCount < MaxOutstandingElementCount;

        /// <summary>
        /// Call <paramref name="fn"/> when allowed to do so by the flow-control limits.
        /// This will alter the current byte-count (by <paramref name="byteCount"/>) and
        /// element-count (by 1), and only call <paramref name="fn"/> once flow-control is
        /// within the limits.
        /// The returned Task will complete once <paramref name="fn"/> has been scheduled
        /// for execution on a Task; note this does not wait until <paramref name="fn"/>
        /// has completed.
        /// </summary>
        /// <param name="byteCount">The number of bytes in the element associated with <paramref name="fn"/>.</param>
        /// <param name="orderingKey">The ordering key for this message. Empty string if no ordering key.</param>
        /// <param name="cancellationToken">Token cancelled when message handling is stopped.</param>
        /// <param name="fn">The function to execute.</param>
        /// <returns>A Task that completes once <paramref name="fn"/> has been scheduled for execution.</returns>
        internal async Task Process(long byteCount, string orderingKey, CancellationToken cancellationToken, Func<Task> fn)
        {
            while (true)
            {
                cancellationToken.ThrowIfCancellationRequested();
                TaskCompletionSource<int> waiterTcs;
                lock (_lock)
                {
                    if (IsFlowOk())
                    {
                        // Flow is OK, so stop waiting.
                        // Add to stats for this element.
                        _byteCount += byteCount;
                        _elementCount += 1;
                        // If there's no ordering-key then the user callback function can always immediately be executed
                        // because there's no ordering constraint to meet.
                        // If there is an ordering-key then the user callback function must be executed sequentially per
                        // ordering-key.
                        if (orderingKey.Length > 0)
                        {
                            // Ordering-key is set on this message.
                            if (_keyedTaskQs.TryGetValue(orderingKey, out var taskQ))
                            {
                                // This ordering-key is already inflight; add to queue.
                                if (taskQ == null)
                                {
                                    taskQ = new Queue<FnInfo>();
                                    _keyedTaskQs[orderingKey] = taskQ;
                                }
                                taskQ.Enqueue(new FnInfo(fn, byteCount));
                                // Return immediately, the enqueued task will be executed by previous task with same key.
                                return;
                            }
                            // Mark this ordering-key inflight, and allow user code for this first message to be executed.
                            // Set the queue to null to save allocation.
                            // It'll be created on-demand if more than one message with the same key are queued.
                            _keyedTaskQs.Add(orderingKey, null);
                        }
                        break;
                    }
                    // Register waiter under _lock so a concurrent completion cannot be missed before awaiting.
                    waiterTcs = new TaskCompletionSource<int>();
                    _waiters.Add(waiterTcs);
                }
                // Flow not OK, wait until a previous fn completes or handler operations are cancelled.
                using (cancellationToken.Register(() =>
                {
                    lock (_lock)
                    {
                        _waiters.Remove(waiterTcs);
                    }
                    waiterTcs.TrySetCanceled(cancellationToken);
                }))
                {
                    await _taskHelper.ConfigureAwait(waiterTcs.Task);
                }
            }
            // Execute the user code for this message.
            ExecuteFunction(orderingKey, byteCount, fn);
        }

        private void ExecuteFunction(string orderingKey, long byteCount, Func<Task> fn)
        {
            // Execute fn, and schedule the following code to execute once it has completed.
            // Register the function, so we can be sure it's completed during shutdown.
            Task task = _taskHelper.Run(async () => await _taskHelper.ConfigureAwaitWithFinally(fn, () =>
            {
                TaskCompletionSource<int>[] waitersToSignal = null;
                FnInfo nextFn = default;
                lock (_lock)
                {
                    if (orderingKey.Length > 0)
                    {
                        var taskQ = _keyedTaskQs[orderingKey];
                        if (taskQ != null && taskQ.Count > 0)
                        {
                            // More fn(s) to execute with this same ordering-key; execute the next fn.
                            nextFn = taskQ.Dequeue();
                        }
                        else
                        {
                            // All fns executed for this ordering-key; remove the key.
                            _keyedTaskQs.Remove(orderingKey);
                        }
                    }
                    _byteCount -= byteCount;
                    _elementCount -= 1;
                    if (IsFlowOk() && _waiters.Count > 0)
                    {
                        waitersToSignal = _waiters.ToArray();
                        _waiters.Clear();
                    }
                }
                if (nextFn.Fn != null)
                {
                    // Execute user code for the next message of this ordering-key;
                    // this is not a recursive call, as this code is within a `Task.Run` :)
                    ExecuteFunction(orderingKey, nextFn.ByteCount, nextFn.Fn);
                }
                if (waitersToSignal != null)
                {
                    foreach (var waiter in waitersToSignal)
                    {
                        waiter.TrySetResult(0);
                    }
                }
            }));
            _registerTaskFn(task);
        }
    }
}
