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

using Microsoft.Extensions.Logging;
using System;
using System.Diagnostics;
using System.Threading.Tasks;

namespace Google.Cloud.Spanner.Data
{
    internal static class ExecuteHelper
    {
        internal static void WithErrorTranslationAndProfiling(Action t, string name, ILogger logger)
        {
            SpannerException translatedException;
            try
            {
                Stopwatch sw = null;
                if (logger.IsEnabled(LogLevel.Trace))
                {
                    sw = Stopwatch.StartNew();
                }

                t();
                if (sw != null)
                {
                    logger.LogTrace("Operation '{name}' took {time}ms", name, sw.ElapsedMilliseconds);
                }
            }
            catch (Exception e) when ((translatedException = SpannerException.TryTranslateRpcException(e)) != null)
            {
                throw translatedException;
            }
        }

        internal static Task WithErrorTranslationAndProfiling(Func<Task> t, string name, ILogger logger)
        {
            return WithErrorTranslationAndProfiling(
                async () =>
                {
                    await t().ConfigureAwait(false);
                    return 0;
                }, name, logger);
        }

        internal static async Task<T> WithErrorTranslationAndProfiling<T>(Func<Task<T>> t, string name, ILogger logger)
        {
            SpannerException translatedException;

            try
            {
                Stopwatch sw = null;
                if (logger.IsEnabled(LogLevel.Trace))
                {
                    sw = Stopwatch.StartNew();
                }

                var result = await t().ConfigureAwait(false);
                if (sw != null)
                {
                    logger.LogTrace("Operation '{name}' took {time}ms", name, sw.ElapsedMilliseconds);
                }

                return result;
            }
            catch (Exception e) when ((translatedException = SpannerException.TryTranslateRpcException(e)) != null)
            {
                throw translatedException;
            }
        }
    }
}
