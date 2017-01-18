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

namespace Google.Cloud.Diagnostics.Common
{
    /// <summary>
    /// A factory to create random span ids.
    /// </summary>
    internal sealed class SpanIdFactory
    {
        /// <summary>A mutex to the instance of <see cref="Random"/>.</summary>
        private static object _randomMutex = new object();

        private static readonly Random _random = new Random();

        private SpanIdFactory() {}

        /// <summary>
        /// Create a new <see cref="SpanIdFactory"/>.
        /// </summary>
        public static SpanIdFactory Create() => new SpanIdFactory();

        /// <summary>
        /// Gets a random span id.
        /// </summary>
        public ulong NextId()
        {
            lock (_randomMutex)
            {
                return (ulong)(_random.NextDouble() * Int64.MaxValue);
            }
        }
    }
}