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

namespace Google.Cloud.Diagnostics.Common
{
    /// <summary>
    /// A trace span.
    /// </summary>
    /// <remarks>
    /// <para>
    /// The functions here, aside from <see cref="IDisposable.Dispose"/>, do not need to be used in most cases. 
    /// They need to be used when updating the current span in a disjoint thread. For example:
    /// </para>
    /// <code>
    /// public void DoSomething(IManagedTracer tracer)
    /// {
    ///     var tcs = new TaskCompletionSource&lt;bool&gt;();
    ///     ISpan span = null;
    ///     Thread t = new Thread(() => 
    ///     {
    ///         span = tracer.StartSpan(nameof(DoSomething));
    ///         tcs.SetResult(true);
    ///     });
    ///     Thread t2 = new Thread(() =>
    ///     {
    ///         tcs.Task.Wait();
    ///         span.AnnotateSpan(new Dictionary&lt;string, string&gt; { { "new", "label"} });
    ///         span.Dispose();
    ///     });
    ///     
    ///     t.Start();
    ///     t2.Start();
    /// }
    /// </code>
    /// <para>
    /// NOTE: While it is possible to end a span in another thread any new spans after this may be in
    /// a poor state.
    /// </para>
    /// </remarks>
    public interface ISpan : IDisposable
    {
        /// <summary>
        /// True if the span has been disposed and ended.
        /// </summary>
        bool Disposed();

        /// <summary>
        /// Annotates the current span with the given labels. 
        /// </summary>
        void AnnotateSpan(Dictionary<string, string> labels);

        /// <summary>
        /// Adds the given StackTrace to the current span.
        /// </summary>
        void SetStackTrace(StackTrace stackTrace);

        /// <summary>
        /// Gets span's id.
        /// </summary>
        ulong SpanId();
    }
}
