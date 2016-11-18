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
    internal sealed class TraceIdFactory
    {
        private TraceIdFactory() {}

        /// <summary>
        /// Create a new <see cref="TraceIdFactory"/>.
        /// </summary>
        public static TraceIdFactory Create(Random random = null)
        {
            return new TraceIdFactory();
        }

        /// <summary>
        /// Gets a random trace id.
        /// </summary>
        public string NextId()
        {
            return Guid.NewGuid().ToString("N");
        }
    }

}
