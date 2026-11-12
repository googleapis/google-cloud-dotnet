// Copyright 2026 Google LLC
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

using System;

namespace Google.Cloud.BuiltInMetrics.Tests;

/// <summary>
/// Sets an environment variable, and restores the old value on dispose.
/// </summary>
internal sealed class TemporaryEnvironmentVariable : IDisposable
{
    private readonly string _name;
    private readonly string _oldValue;

    internal TemporaryEnvironmentVariable(string name, string value)
    {
        (_name, _oldValue) = (name, Environment.GetEnvironmentVariable(name));
        Environment.SetEnvironmentVariable(name, value);
    }

    public void Dispose() => Environment.SetEnvironmentVariable(_name, _oldValue);
}
