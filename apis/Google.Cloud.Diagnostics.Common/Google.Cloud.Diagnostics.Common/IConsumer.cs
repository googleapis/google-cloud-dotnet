// Copyright 2016 Google Inc. All Rights Reserved.
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

using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Google.Cloud.Diagnostics.Common
{
    /// <summary>
    /// A consumer.
    /// </summary>
    internal interface IConsumer<T> : IDisposable
    {
        /// <summary>
        /// Accepts an enumerable of items.
        /// </summary>
        /// <param name="items">The items to receive. Cannot be null.</param>
        void Receive(IEnumerable<T> items);

        /// <summary>
        /// Accepts an enumerable of items asynchronously.
        /// </summary>
        /// <param name="items">The items to receive. Cannot be null.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests.</param>
        /// <returns>A task representing the asynchronous operation.</returns>
        Task ReceiveAsync(IEnumerable<T> items, CancellationToken cancellationToken = default(CancellationToken));
    }
}