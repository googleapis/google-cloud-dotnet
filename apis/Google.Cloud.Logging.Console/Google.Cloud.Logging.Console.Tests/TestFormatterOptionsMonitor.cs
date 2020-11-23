// Copyright 2020 Google LLC
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
//     https://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.

using Microsoft.Extensions.Options;
using System;

namespace Google.Cloud.Logging.Console.Tests
{
    internal class TestFormatterOptionsMonitor<TOptions> : IOptionsMonitor<TOptions> where TOptions : GoogleCloudConsoleFormatterOptions
    {
        private TOptions _options;
        private event Action<TOptions, string> _onChange;
        public TestFormatterOptionsMonitor(TOptions options)
        {
            _options = options;
        }

        public TOptions Get(string name) => _options;

        public IDisposable OnChange(Action<TOptions, string> listener)
        {
            _onChange += listener;
            return null;
        }

        public TOptions CurrentValue => _options;

        public void Set(TOptions options)
        {
            _options = options;
            _onChange?.Invoke(options, "");
        }
    }
}
