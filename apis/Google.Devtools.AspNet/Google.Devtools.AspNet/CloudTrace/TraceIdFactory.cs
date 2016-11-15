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

using Org.BouncyCastle.Math;
using System;

namespace Google.Devtools.AspNet
{
    /// <summary>
    /// A factory to create random trace ids.
    /// </summary>
    public sealed class TraceIdFactory
    {
        private readonly Random _random;

        private TraceIdFactory(Random random = null)
        {
            _random = random ?? new Random();
        }

        /// <summary>
        /// Create a new <see cref="TraceIdFactory"/>.
        /// </summary>
        /// <param name="random">Optional, a random number generator, if none supplied the system default will be used.</param>
        public static TraceIdFactory Create(Random random = null)
        {
            return new TraceIdFactory(random);
        }

        /// <summary>
        /// Gets a random trace id.
        /// </summary>
        public string NextId()
        {
            byte[] bytes = new byte[128 / 8];
            _random.NextBytes(bytes);
            BigInteger idInt = new BigInteger(bytes);
            return idInt.ToString(16).PadLeft(32, '0');
        }
    }

}
