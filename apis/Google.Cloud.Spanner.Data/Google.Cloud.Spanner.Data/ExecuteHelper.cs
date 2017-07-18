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
using System.Diagnostics;
using System.Threading;
using System.Threading.Tasks;
using Google.Cloud.Spanner.V1.Internal.Logging;

namespace Google.Cloud.Spanner.Data
{
    internal static class ExecuteHelper
    {
        internal static void WithErrorTranslationAndProfiling(Action t, string name)
        {
            SpannerException translatedException;
            try
            {
                Stopwatch sw = null;
                if (Logger.LogPerformanceTraces)
                {
                    sw = Stopwatch.StartNew();
                }

                t();
                if (sw != null)
                {
                    Logger.LogPerformanceCounterFn($"{name}.Duration", x => sw.ElapsedMilliseconds);
                }
            }
            catch (Exception e) when ((translatedException = SpannerException.TryTranslateRpcException(e)) != null)
            {
                throw translatedException;
            }
        }

        internal static Task WithErrorTranslationAndProfiling(Func<Task> t, string name)
        {
            return WithErrorTranslationAndProfiling(
                async () =>
                {
                    await t().ConfigureAwait(false);
                    return 0;
                }, name);
        }

        internal static async Task<T> WithErrorTranslationAndProfiling<T>(Func<Task<T>> t, string name)
        {
            SpannerException translatedException;

            try
            {
                Stopwatch sw = null;
                if (Logger.LogPerformanceTraces)
                {
                    sw = Stopwatch.StartNew();
                }

                var result = await t().ConfigureAwait(false);
                if (sw != null)
                {
                    Logger.LogPerformanceCounterFn($"{name}.Duration", x => sw.ElapsedMilliseconds);
                }

                return result;
            }
            catch (Exception e) when ((translatedException = SpannerException.TryTranslateRpcException(e)) != null)
            {
                throw translatedException;
            }
        }

        internal static async Task<T> WithTimeout<T>(this Task<T> task, TimeSpan timeout, string timeoutMessage)
        {
            if (task != await Task.WhenAny(task, Task.Delay(timeout, CancellationToken.None)).ConfigureAwait(false))
            {
                throw new TimeoutException(timeoutMessage);
            }

            return await task.ConfigureAwait(false);
        }
    }
}
