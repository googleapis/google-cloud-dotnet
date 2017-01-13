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

using System.Diagnostics;

namespace Google.Cloud.Diagnostics.Common
{
    /// <summary>
    /// A <see cref="ITimer"/> based on a <see cref="Stopwatch"/>.
    /// </summary>
    internal sealed class StopwatchTimer : ITimer
    {
        private readonly Stopwatch _stopwatch;

        /// <summary>
        /// Creates a new <see cref="StopwatchTimer"/>.
        /// </summary>
        /// <param name="stopwatch">Optional stop watch to use.</param>
        public static StopwatchTimer Create(Stopwatch stopwatch = null)
        {
            return new StopwatchTimer(stopwatch);
        }

        private StopwatchTimer(Stopwatch stopwatch = null)
        {
            _stopwatch = stopwatch ?? new Stopwatch();
        }

        /// <inheritdoc />
        public void Start()
        {
            _stopwatch.Start();
        }

        /// <inheritdoc />
        public long GetElapsedMilliseconds()
        {
            return _stopwatch.ElapsedMilliseconds;
        }
    }
}