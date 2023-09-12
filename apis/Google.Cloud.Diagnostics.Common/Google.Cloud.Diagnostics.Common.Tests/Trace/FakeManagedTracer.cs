// Copyright 2023 Google LLC
//
// Licensed under the Apache License, Version 2.0 (the "License").
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
// https://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.

using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Google.Cloud.Diagnostics.Common.Tests.Trace;

/// <summary>
/// Implementation of IManagedTracer which just knows a trace ID and optional span ID.
/// </summary>
internal class FakeManagedTracer : IManagedTracer
{
    private readonly string _traceId;
    private readonly ulong? _spanId;

    public FakeManagedTracer(string traceId, ulong? spanId = null)
    {
        _traceId = traceId;
        _spanId = spanId;
    }

    public string GetCurrentTraceId() => _traceId;
    public ulong? GetCurrentSpanId() => _spanId;

    public void AnnotateSpan(Dictionary<string, string> labels) => throw new NotImplementedException();
    public void RunInSpan(Action action, string name, StartSpanOptions options = null) => throw new NotImplementedException();
    public T RunInSpan<T>(Func<T> func, string name, StartSpanOptions options = null) => throw new NotImplementedException();
    public Task<T> RunInSpanAsync<T>(Func<Task<T>> func, string name, StartSpanOptions options = null) => throw new NotImplementedException();
    public void SetStackTrace(System.Diagnostics.StackTrace stackTrace) => throw new NotImplementedException();
    public ISpan StartSpan(string name, StartSpanOptions options = null) => throw new NotImplementedException();
}
