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

using System;
using System.Collections.Generic;

namespace Google.Cloud.PubSub.V1;

public sealed partial class SubscriberClientImpl
{
    // Internal for testing.
    /// <summary>
    /// A queue that allows data to be requeued at the front of the queue.
    /// Requeued items are queued after previously requeued items, but before queued items.
    /// </summary>
    internal class RequeueableQueue<T>
    {
        private readonly Queue<T> _q = new Queue<T>();
        private readonly LinkedList<Queue<T>> _qs = new LinkedList<Queue<T>>();
        private int _requeueCount = 0;

        internal int Count => _q.Count + _requeueCount;

        internal void Enqueue(T item) => _q.Enqueue(item);

        internal void Enqueue(IEnumerable<T> items)
        {
            foreach (var item in items)
            {
                _q.Enqueue(item);
            }
        }

        internal void Requeue(IEnumerable<T> items)
        {
            var q = new Queue<T>(items);
            _qs.AddLast(q);
            _requeueCount += q.Count;
        }

        /// <summary>
        /// Dequeue up to maxCount items.
        /// Any items that are not included in the return value due to <c>includeFn</c> are discarded.
        /// </summary>
        /// <param name="maxCount">Maximum count of items to dequeue.</param>
        /// <param name="includeFn">If not null, must return <c>true</c> for the item to be included.</param>
        /// <returns></returns>
        internal List<T> Dequeue(int maxCount, Predicate<T> includeFn)
        {
            List<T> result = new List<T>();
            Queue<T> q = _qs.First?.Value;
            if (q != null)
            {
                while (result.Count < maxCount)
                {
                    if (q.Count > 0)
                    {
                        var item = q.Dequeue();
                        _requeueCount -= 1;
                        if (includeFn == null || includeFn(item))
                        {
                            result.Add(item);
                        }
                    }
                    else
                    {
                        _qs.RemoveFirst();
                        q = _qs.First?.Value;
                        if (q == null)
                        {
                            break;
                        }
                    }
                }
            }
            while (result.Count < maxCount && _q.Count > 0)
            {
                var item = _q.Dequeue();
                if (includeFn == null || includeFn(item))
                {
                    result.Add(item);
                }
            }
            return result;
        }

        internal bool TryPeek(out T value)
        {
            var qsNode = _qs.First;
            while (qsNode != null)
            {
                if (qsNode.Value.Count > 0)
                {
                    value = qsNode.Value.Peek();
                    return true;
                }
                qsNode = qsNode.Next;
            }
            if (_q.Count > 0)
            {
                value = _q.Peek();
                return true;
            }
            value = default(T);
            return false;
        }
    }
}
