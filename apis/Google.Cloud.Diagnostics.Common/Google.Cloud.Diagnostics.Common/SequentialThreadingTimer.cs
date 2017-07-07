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

using System;
using System.Threading;
using System.Threading.Tasks;

namespace Google.Cloud.Diagnostics.Common
{
    /// <summary>
    /// A simple <see cref="ISequentialThreadingTimer"/>.
    /// </summary>
    internal class SequentialThreadingTimer : ISequentialThreadingTimer
    {
        private readonly CancellationTokenSource _source = new CancellationTokenSource();

        /// <inheritdoc />
        public void Initialize(Action callback, TimeSpan waitTime)
        {
            Task.Run(async () =>
            {
                while (!_source.Token.IsCancellationRequested)
                {
                    await Task.Delay(waitTime).ConfigureAwait(false);
                    callback();
                }
            });
        }

        /// <inheritdoc />
        public void Dispose() => _source.Cancel();
    }
}
