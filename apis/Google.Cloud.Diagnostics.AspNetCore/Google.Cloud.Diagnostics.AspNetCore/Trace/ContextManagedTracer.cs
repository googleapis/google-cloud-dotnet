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

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading.Tasks;
using Google.Cloud.Diagnostics.Common;
using Microsoft.AspNetCore.Http;
using Google.Api.Gax;

namespace Google.Cloud.Diagnostics.AspNetCore
{
    internal sealed class ContextManagedTracer : IManagedTracer
    {
        private readonly IHttpContextAccessor _accessor;

        internal ContextManagedTracer(IHttpContextAccessor accessor)
        {
            _accessor = GaxPreconditions.CheckNotNull(accessor, nameof(accessor));
        }

        /// <inheritdoc />
        public IDisposable StartSpan(string name, StartSpanOptions options = null) =>
            ContextTracerManager.GetCurrentTracer(_accessor).StartSpan(name, options);

        /// <inheritdoc />
        public void RunInSpan(Action action, string name, StartSpanOptions options = null) =>
            ContextTracerManager.GetCurrentTracer(_accessor).RunInSpan(action, name, options);

        /// <inheritdoc />
        public T RunInSpan<T>(Func<T> func, string name, StartSpanOptions options = null) =>
            ContextTracerManager.GetCurrentTracer(_accessor).RunInSpan(func, name, options);

        /// <inheritdoc />
        public Task<T> RunInSpanAsync<T>(Func<Task<T>> func, string name, StartSpanOptions options = null) =>
            ContextTracerManager.GetCurrentTracer(_accessor).RunInSpan(func, name, options);

        /// <inheritdoc />
        public void EndSpan() =>
            ContextTracerManager.GetCurrentTracer(_accessor).EndSpan();

        /// <inheritdoc />
        public void AnnotateSpan(Dictionary<string, string> labels) =>
            ContextTracerManager.GetCurrentTracer(_accessor).AnnotateSpan(labels);

        /// <inheritdoc />
        public void SetStackTrace(StackTrace stackTrace) =>
            ContextTracerManager.GetCurrentTracer(_accessor).SetStackTrace(stackTrace);

        /// <inheritdoc />
        public string GetCurrentTraceId() =>
            ContextTracerManager.GetCurrentTracer(_accessor).GetCurrentTraceId();

        /// <inheritdoc />
        public ulong? GetCurrentSpanId() =>
            ContextTracerManager.GetCurrentTracer(_accessor).GetCurrentSpanId();
    }
}
