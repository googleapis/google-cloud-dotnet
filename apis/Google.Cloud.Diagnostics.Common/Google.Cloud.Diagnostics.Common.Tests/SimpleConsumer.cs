// Copyright 2023 Google LLC
//
// Licensed under the Apache License, Version 2.0 (the "License").
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at 
//
// https://www.apache.org/licenses/LICENSE-2.0 
//
// Unless required by applicable law or agreed to in writing, software 
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and 
// limitations under the License.

using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Google.Cloud.Diagnostics.Common.Tests;

public class SimpleConsumer<T> : IConsumer<T>
{
    public bool Disposed { get; set; }

    public List<T> Items { get; } = new List<T>();

    /// <summary>
    /// Number of times Receive or ReceiveAsync has been called.
    /// </summary>
    public int ReceiveCount { get; private set; }

    public void Dispose() => Disposed = true;

    public virtual void Receive(IEnumerable<T> items)
    {
        Items.AddRange(items);
        ReceiveCount++;
    }

    public virtual Task ReceiveAsync(IEnumerable<T> items, CancellationToken cancellationToken = default)
    {
        Receive(items);
        return Task.CompletedTask;
    }
}
