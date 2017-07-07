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
using Xunit;

namespace Google.Cloud.Diagnostics.Common.Tests
{
    public class RetryOptionsTest
    {
        [Fact]
        public void NoRetry()
        {
            RetryOptions options = RetryOptions.NoRetry();
            Assert.Equal(RetryType.None, options.RetryType);
            Assert.Equal(ExceptionHandling.Ignore, options.ExceptionHandling);
        }

        [Fact]
        public void Retry()
        {
            int size = 100;
            int retryAttempts = 12;
            TimeSpan retryInterval = TimeSpan.FromSeconds(5);
            RetryOptions options = RetryOptions.Retry(
                bufferSizeBytes: size, retryInterval: retryInterval, retryAttempts: retryAttempts);
            Assert.Equal(RetryType.Retry, options.RetryType);
            Assert.Equal(ExceptionHandling.Ignore, options.ExceptionHandling);
            Assert.Equal(BufferOverflow.IgnoreNewEntries, options.BufferOverflow);
            Assert.Equal(size, options.BufferSizeBytes);
            Assert.Equal(retryAttempts, options.RetryAttempts);
            Assert.Equal(retryInterval, options.RetryInterval);
        }

        [Fact]
        public void Retry_Invalid_Parameters()
        {
            RetryOptions.Retry(bufferSizeBytes: 0);
            Assert.Throws<ArgumentOutOfRangeException>(() => RetryOptions.Retry(bufferSizeBytes: -1));

            RetryOptions.Retry(retryAttempts: 0);
            Assert.Throws<ArgumentOutOfRangeException>(() => RetryOptions.Retry(retryAttempts: -1));

            RetryOptions.Retry(retryInterval: TimeSpan.Zero);
            Assert.Throws<ArgumentException>(() => RetryOptions.Retry(retryInterval: TimeSpan.FromSeconds(-1)));
        }
    }
}