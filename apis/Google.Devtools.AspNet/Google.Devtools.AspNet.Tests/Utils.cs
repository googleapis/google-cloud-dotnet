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

using System.Threading;
using Xunit;

namespace Google.Devtools.AspNet.Tests
{
    public static class Utils
    {
        /// <summary>Two seconds.</summary>
        public const int TimeoutMilliseconds = 2000;

        /// <summary>
        /// Waits for <see cref="EventWaitHandle.Set"/> to be called.  If it is not called an 
        /// <see cref="Assert"/> will fail. 
        /// </summary>
        /// <param name="reset">The manual reset event.</param>
        /// <param name="errorMessage">The error message to pass along if <see cref="EventWaitHandle.Set"/> 
        ///     is not called</param>
        /// <param name="timeout">Optional, the amount of time to wait for <see cref="EventWaitHandle.Set"/> to
        ///     be called.  Defaults to <see cref="TimeoutMilliseconds"/></param>
        public static void WaitForSet(ManualResetEvent reset, string errorMessage, int timeout = TimeoutMilliseconds)
        {
            Assert.True(reset.WaitOne(TimeoutMilliseconds), errorMessage);
        }

        /// <summary>
        /// Ensures <see cref="EventWaitHandle.Set"/> is not called.  If it is called an 
        /// <see cref="Assert"/> will fail. 
        /// </summary>
        /// <param name="reset">The manual reset event.</param>
        /// <param name="errorMessage">The error message to pass along if <see cref="EventWaitHandle.Set"/> 
        ///     is called</param>
        /// <param name="timeout">Optional, the amount of time to wait before assuming 
        ///     <see cref="EventWaitHandle.Set"/> wasn't called.  Defaults to <see cref="TimeoutMilliseconds"/></param>
        public static void EnsureNoSet(ManualResetEvent reset, string errorMessage, int timeout = TimeoutMilliseconds)
        {
            Assert.False(reset.WaitOne(TimeoutMilliseconds), errorMessage);
        }
    }
}
