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

using Google.Api.Gax;
using Google.Cloud.Diagnostics.Common;
using System.Web;

namespace Google.Cloud.Diagnostics.AspNet
{
    /// <summary>
    /// A factory to generate trace options based on the trace header.
    /// </summary>
    internal sealed class TraceHeaderTraceOptionsFactory : ITraceOptionsFactory
    {
        private TraceHeaderTraceOptionsFactory() { }

        public static TraceHeaderTraceOptionsFactory Create() => new TraceHeaderTraceOptionsFactory();

        /// <summary>
        /// Create a new <see cref="TraceHeaderTraceOptionsFactory"/>.
        /// </summary>
        public TraceOptions CreateOptions() => 
            CreateOptions(TraceHeaderContextUtils.CreateContext(HttpContext.Current.Request));

        /// <summary>
        /// Create a new <see cref="TraceHeaderTraceOptionsFactory"/> from a <see cref="TraceHeaderContext"/>
        /// </summary>
        public TraceOptions CreateOptions(TraceHeaderContext context)
        {
            GaxPreconditions.CheckNotNull(context, nameof(context));
            return TraceOptions.Create(context.ShouldTrace);
        }
    }
}