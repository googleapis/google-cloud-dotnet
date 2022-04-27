// Copyright 2021 Google LLC
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

using Google.Api.Gax;
using Google.Cloud.Logging.V2;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace Google.Cloud.Diagnostics.Common
{
    internal static class LogEntryExtensions
    {
        internal static LogEntry SetTraceAndSpanIfAny(this LogEntry entry, TraceTarget traceTarget, IServiceProvider serviceProvider)
        {
            GaxPreconditions.CheckNotNull(entry, nameof(entry));

            if (traceTarget is null)
            {
                return entry;
            }

            // If there's currently a Google trace and span use that one.
            // This means that the Google Trace component of the diagnostics library
            // has been initialized.
            // Else attempt to use an external trace context.
            var context = ContextTracerManager.GetCurrentTraceContext() ?? serviceProvider.SafeGetTraceContext();
            if (context is ITraceContext && context.TraceId is string)
            {
                entry.Trace = traceTarget.GetFullTraceName(context.TraceId);
                entry.TraceSampled = context.ShouldTrace ?? false;
                entry.SpanId = SpanIdToHex(context.SpanId);
            }

            return entry;

            static string SpanIdToHex(ulong? spanId) => spanId is null ? null : $"{spanId:x16}";
        }

        private static ITraceContext SafeGetTraceContext(this IServiceProvider serviceProvider)
        {
            try
            {
                return serviceProvider?.GetService<ITraceContext>();
            }
            catch (InvalidOperationException ex) when (ex.Message.Contains("Google.Cloud.Diagnostics.Common.ITraceContext"))
            {
                return null;
            }
        }
    }
}
