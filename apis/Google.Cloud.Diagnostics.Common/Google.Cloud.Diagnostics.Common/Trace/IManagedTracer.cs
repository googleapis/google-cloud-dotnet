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
    /// Manages creating spans for a trace as well as adding meta data to them.
    /// </summary>
    public interface IManagedTracer
    {
        /// <summary>
        /// Starts a new span using the most recent (if any) unfinished span as the parent.
        /// </summary>
        /// <param name="name">The name of the span, cannot be null.</param>
        /// <param name="options">The span options to override default values.</param>
        /// <returns>
        /// An <see cref="ISpan"/> that will end the current span when disposed.
        /// </returns>
        ISpan StartSpan(string name, StartSpanOptions options = null);

        /// <summary>
        /// Runs the function in a span and will add a stacktrace from a thrown
        /// exception (the exception will be re-thrown) to the span.
        /// </summary>
        /// <param name="action">The action to run in a span.</param>
        /// <param name="name">The name of the span, cannot be null.</param>
        /// <param name="options">The span options to override default values.</param>
        void RunInSpan(Action action, string name, StartSpanOptions options = null);

        /// <summary>
        /// Runs the function in a span and will add a stacktrace from a thrown
        /// exception (the exception will be re-thrown) to the span.
        /// </summary>
        /// <param name="func">The function to run in a span.</param>
        /// <param name="name">The name of the span, cannot be null.</param>
        /// <param name="options">The span options to override default values.</param>
        /// <returns>The result from the call to <paramref name="func"/></returns>
        T RunInSpan<T>(Func<T> func, string name, StartSpanOptions options = null);

        /// <summary>
        /// Runs the function asynchronously in a span and will add a stacktrace
        /// from a thrown exception (the exception will be re-thrown) to the span.
        /// </summary>
        /// <param name="func">The function to run in a span.</param>
        /// <param name="name">The name of the span, cannot be null.</param>
        /// <param name="options">The span options to override default values.</param>
        /// <returns>The result from the call to <paramref name="func"/></returns>
        Task<T> RunInSpanAsync<T>(Func<Task<T>> func, string name, StartSpanOptions options = null);

        /// <summary>
        /// Annotates the current span with the given labels. 
        /// </summary>
        void AnnotateSpan(Dictionary<string, string> labels);

        /// <summary>
        /// Adds the given StackTrace to the current span.
        /// </summary>
        void SetStackTrace(StackTrace stackTrace);

        /// <summary>
        /// Gets the current trace id or null if none exists.
        /// </summary>
        string GetCurrentTraceId();

        /// <summary>
        /// Gets the current span id or null if none exists.
        /// </summary>
        ulong? GetCurrentSpanId();
    }
}
