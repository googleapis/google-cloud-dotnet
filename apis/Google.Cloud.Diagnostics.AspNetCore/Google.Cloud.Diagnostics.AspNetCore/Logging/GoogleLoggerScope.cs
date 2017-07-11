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

using Google.Api.Gax;
using System;
using System.Threading;

namespace Google.Cloud.Diagnostics.AspNetCore
{
    /// <summary>Scope for the <see cref="GoogleLogger"/>.</summary>
    internal class GoogleLoggerScope : IDisposable
    {
        private static AsyncLocal<GoogleLoggerScope> _current = new AsyncLocal<GoogleLoggerScope>();

        /// <summary>
        /// The current scope, can be null.
        /// </summary>
        public static GoogleLoggerScope Current
        {
            get
            {
                return _current.Value;
            }
            set
            {
                _current.Value = value;
            }
        }

        /// <summary>The state associated with the this scope.</summary>
        public object State { get; }

        /// <summary>The parent scope, can be null.</summary>
        public GoogleLoggerScope Parent { get; }

        public GoogleLoggerScope(object state)
        {
            State = GaxPreconditions.CheckNotNull(state, nameof(state));
            Parent = Current;
            Current = this;
        }

        /// <summary>Disposes of the current scope.</summary>
        public void Dispose() => Current = Current?.Parent;

        /// <summary>
        /// Gets the scope (and parents') as a string. It is in the format:
        /// "grandparent => parent => child => " where the scope
        /// value is "child", its parent is "parent" and its grandparent is "grandparent".
        /// </summary>
        public override string ToString() => $"{Parent}{State} => ";
    }
}
