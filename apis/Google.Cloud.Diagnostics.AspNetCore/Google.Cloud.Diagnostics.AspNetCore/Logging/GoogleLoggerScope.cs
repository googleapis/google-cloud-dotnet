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
    internal class GoogleLoggerScope : IDisposable
    {
        private static AsyncLocal<GoogleLoggerScope> _current = new AsyncLocal<GoogleLoggerScope>();
        public static GoogleLoggerScope Current {
            get
            {
                return _current.Value;
            }
            set
            {
                _current.Value = value;
            }
        }

        public object State { get; }
        public GoogleLoggerScope Parent { get; }

        public GoogleLoggerScope(object state)
        {
            State = GaxPreconditions.CheckNotNull(state, nameof(state));
            Parent = Current;
            Current = this;
        }

        public void Dispose() => Current = Current?.Parent;
    }
}
