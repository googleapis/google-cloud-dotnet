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

using Grpc.Core;
using System;
using System.Collections.Generic;
using System.Threading;

namespace Google.Cloud.PubSub.V1
{
    internal static class Extensions
    {
        public static void Locked<TLock>(this TLock o, Action action) where TLock : class
        {
            lock (o)
            {
                action();
            }
        }

        public static T Locked<TLock, T>(this TLock o, Func<T> fn) where TLock : class
        {
            lock (o)
            {
                return fn();
            }
        }

        public static void EnqueueAll<T>(this Queue<T> queue, IEnumerable<T> items)
        {
            foreach (var item in items)
            {
                queue.Enqueue(item);
            }
        }

        public static bool Is<T>(this Exception e) where T : Exception =>
            e is T || (e is AggregateException ae && ae.Flatten().InnerException is T);

        public static bool IsCancellation(this Exception e) => e.Is<OperationCanceledException>();
    }
}
