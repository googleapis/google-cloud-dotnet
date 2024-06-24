// Copyright 2018, Google LLC
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
using System.Threading.Tasks;

namespace Google.Cloud.Firestore
{
    /// <summary>
    /// An ongoing "listen" or "watch" operation on either document or query snapshots.
    /// This is returned from <c>Listen</c> methods.
    /// </summary>
    public sealed class FirestoreChangeListener
    {
        private readonly WatchStream _stream;
        private int _stopped;

        /// <summary>
        /// A task that will complete when the listen operation finishes.
        /// </summary>
        /// <remarks>
        /// If a cancellation token provided by the caller (either when starting to listen or
        /// when calling <see cref="StopAsync"/>) is canceled, the task will finish in a state of <see cref="TaskStatus.Canceled"/>.
        /// The task will finish in a state of <see cref="TaskStatus.Faulted"/> if any other kind of exception was thrown, including
        /// any non-retriable RPC exceptions. The task will finish in a state of <see cref="TaskStatus.RanToCompletion"/> if
        /// the listener stopped gracefully.
        /// </remarks>
        public Task ListenerTask { get; }

        internal FirestoreChangeListener(WatchStream stream, Task task)
        {
            _stream = stream;
            ListenerTask = task;
        }

        internal static FirestoreChangeListener Start(WatchStream stream)
        {
            var task = stream.StartAsync();
            return new FirestoreChangeListener(stream, task);
        }

        /// <summary>
        /// Requests that the client stops listening for changes. If a callback is in progress,
        /// that will be allowed to complete, but cancelling <paramref name="cancellationToken"/> will
        /// cancel the token passed to the callback, allowing for prompt cancellation if required.
        /// </summary>
        /// <remarks>This method must only be called once per listener.</remarks>
        /// <param name="cancellationToken">A cancellation token to cancel a callback if one is in progress.</param>
        /// <returns>The task to indicate listener completion. This returns the same as <see cref="ListenerTask"/>.</returns>
        public Task StopAsync(CancellationToken cancellationToken = default)
        {
            if (Interlocked.Exchange(ref _stopped, 1) != 0)
            {
                throw new InvalidOperationException($"{nameof(StopAsync)} can only be called once");
            }
            _stream.Stop(cancellationToken);
            return ListenerTask;
        }
    }
}
