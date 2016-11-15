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

namespace Google.Devtools.AspNet
{
    /// <summary>
    /// A factory to create random span ids.
    /// </summary>
    public sealed class SpanIdFactory
    {
        private readonly Random _random;

        private SpanIdFactory(Random random = null)
        {
            _random = random ?? new Random();
        }

        /// <summary>
        /// Create a new <see cref="SpanIdFactory"/>.
        /// </summary>
        /// <param name="random">Optional, a random number generator, if none supplied the system default will be used.</param>
        public static SpanIdFactory Create(Random random = null)
        {
            return new SpanIdFactory(random);
        }

        /// <summary>
        /// Gets a random span id.
        /// </summary>
        public ulong NextId()
        {
            return (ulong)(_random.NextDouble() * Int64.MaxValue);
        }
    }
}