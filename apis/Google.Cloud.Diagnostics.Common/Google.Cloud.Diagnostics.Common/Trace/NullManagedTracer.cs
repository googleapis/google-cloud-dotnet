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
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading.Tasks;

namespace Google.Cloud.Diagnostics.Common
{
    /// <summary>
    /// A managed tracer that does not trace.
    /// </summary>
    public sealed class NullManagedTracer : IManagedTracer
    {
        /// <summary>
        /// A disposable class that does nothing when disposed.
        /// </summary>
        internal class Span : ISpan
        {
            private bool _disposed;

            /// <summary>
            /// Does nothing.
            /// </summary>
            public void AnnotateSpan(Dictionary<string, string> labels) { }

            /// <summary>
            /// Will cause <see cref="Disposed"/> to return 'true'.
            /// </summary>
            public void Dispose() => _disposed = true;

            /// <summary>
            /// Does nothing.
            /// </summary>
            public void SetStackTrace(StackTrace stackTrace) {}

            /// <summary>
            /// Always returns 0.
            /// </summary>
            public ulong SpanId() => 0;

            /// <summary>
            /// Returns true if <see cref="Dispose"/> has been called.
            /// </summary>
            public bool Disposed() => _disposed;
        }

        /// <summary>
        /// Instance of <see cref="NullManagedTracer"/>
        /// </summary>
        public static readonly NullManagedTracer Instance = new NullManagedTracer();

        /// <summary>
        /// Does nothing.
        /// </summary>
        /// <returns>Returns an <see cref="IDisposable"/> that does nothing when disposed.</returns>
        public ISpan StartSpan(string name, StartSpanOptions options = null) => new Span();

        /// <summary>
        /// Calls <paramref name="action"/>.
        /// </summary>
        public void RunInSpan(Action action, string name, StartSpanOptions options = null) => action();

        /// <summary>
        /// Calls <paramref name="func"/> and returns the result.
        /// </summary>
        public T RunInSpan<T>(Func<T> func, string name, StartSpanOptions options = null) => func();

        /// <summary>
        /// Calls <paramref name="func"/> asynchronously and returns the result.
        /// </summary>
        public Task<T> RunInSpanAsync<T>(Func<Task<T>> func, string name, StartSpanOptions options = null) => Task.Run(func);

        /// <summary>
        /// Does nothing.
        /// </summary>
        public void AnnotateSpan(Dictionary<string, string> labels) { }

        /// <summary>
        /// Does nothing.
        /// </summary>
        public void SetStackTrace(StackTrace stackTrace) { }

        /// <summary>
        /// Always returns null.
        /// </summary>
        public string GetCurrentTraceId() => null;

        /// <summary>
        /// Always returns null.
        /// </summary>
        public ulong? GetCurrentSpanId() => null;
    }
}