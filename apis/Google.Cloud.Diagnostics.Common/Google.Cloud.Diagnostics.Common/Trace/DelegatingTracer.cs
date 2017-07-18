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
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading.Tasks;

namespace Google.Cloud.Diagnostics.Common
{
    /// <summary>
    /// An <see cref="IManagedTracer"/> that delegates all calls to another <see cref="IManagedTracer"/>
    /// that is retrieved from the given function on each method call.
    /// </summary>
    internal class DelegatingTracer : IManagedTracer
    {
        private readonly Func<IManagedTracer> _managedTracerGetter;

        internal DelegatingTracer(Func<IManagedTracer> managedTracerGetter)
        {
            _managedTracerGetter = GaxPreconditions.CheckNotNull(managedTracerGetter, nameof(managedTracerGetter));
        }

        /// <inheritdoc />
        public ISpan StartSpan(string name, StartSpanOptions options = null) =>
           _managedTracerGetter().StartSpan(name, options);

        /// <inheritdoc />
        public void RunInSpan(Action action, string name, StartSpanOptions options = null) =>
            _managedTracerGetter().RunInSpan(action, name, options);

        /// <inheritdoc />
        public T RunInSpan<T>(Func<T> func, string name, StartSpanOptions options = null) =>
            _managedTracerGetter().RunInSpan(func, name, options);

        /// <inheritdoc />
        public Task<T> RunInSpanAsync<T>(Func<Task<T>> func, string name, StartSpanOptions options = null) =>
            _managedTracerGetter().RunInSpan(func, name, options);

        /// <inheritdoc />
        public void AnnotateSpan(Dictionary<string, string> labels) => _managedTracerGetter().AnnotateSpan(labels);

        /// <inheritdoc />
        public void SetStackTrace(StackTrace stackTrace) => _managedTracerGetter().SetStackTrace(stackTrace);

        /// <inheritdoc />
        public string GetCurrentTraceId() => _managedTracerGetter().GetCurrentTraceId();

        /// <inheritdoc />
        public ulong? GetCurrentSpanId() =>  _managedTracerGetter().GetCurrentSpanId();
    }
}
