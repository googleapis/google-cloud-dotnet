// Copyright 2017 Google Inc. All Rights Reserved.
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
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Google.Cloud.Diagnostics.Common.Tests;

/// <summary>
/// Consumer which responds to Receive/ReceiveAsync calls with a given number of exceptions,
/// and then succeeds, storing the results as per <see cref="SimpleConsumer{T}"/>.
/// </summary>
public class ThrowingConsumer<T> : SimpleConsumer<T>
{
    public int FailedCalls { get; private set; }
    private int _remainingFailures;

    public ThrowingConsumer(int failures)
    {
        _remainingFailures = failures;
    }

    public override void Receive(IEnumerable<T> items)
    {
        MaybeThrow();
        base.Receive(items);
    }

    public override async Task ReceiveAsync(IEnumerable<T> items, CancellationToken cancellationToken = default)
    {
        MaybeThrow();
        await base.ReceiveAsync(items, cancellationToken);
    }

    private void MaybeThrow()
    {
        if (_remainingFailures > 0)
        {
            FailedCalls++;
            _remainingFailures--;
            throw new RpcException(Status.DefaultCancelled);
        }
    }
}
