// Copyright 2018 Google LLC
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

using Xunit;

namespace Google.Cloud.Spanner.Data.CommonTesting
{
    /// <summary>
    /// Common assertions for Spanner tests.
    /// </summary>
    public static class SpannerAssert
    {
        /// <summary>
        /// Asserts that the given exception was due to a timeout. Sometimes gRPC
        /// will return an exception with a status code of Unavailable when it's really
        /// a timeout. This appears to depend on which combination of tests is being run,
        /// so may well be around how the underlying gRPC channels are being used. We test
        /// in a slightly looser way than might be expected to work around this.
        /// </summary>
        public static void IsTimeout(SpannerException exception)
        {
            // TODO: Investigate the cause of this further.
            var code = exception.ErrorCode;
            Assert.True(code == ErrorCode.DeadlineExceeded || code == ErrorCode.Unavailable,
                $"Expected code of DeadlineExceeded or Unavailable; was {code}");
            Assert.False(exception.IsTransientSpannerFault());
        }
    }
}
