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
using Xunit;

namespace Google.Cloud.Diagnostics.Common.Tests
{
    public class BufferOptionsTest
    {
        [Fact]
        public void NoBuffer()
        {
            BufferOptions options = BufferOptions.NoBuffer();
            Assert.Equal(BufferType.None, options.BufferType);
            Assert.Equal(default(int), options.BufferSizeBytes);
            Assert.Equal(default(TimeSpan), options.BufferWaitTime);
        }

        [Fact]
        public void SizedBuffer()
        {
            int size = 100;
            BufferOptions options = BufferOptions.SizedBuffer(size);
            Assert.Equal(BufferType.Sized, options.BufferType);
            Assert.Equal(size, options.BufferSizeBytes);
            Assert.Equal(default(TimeSpan), options.BufferWaitTime);
        }

        [Fact]
        public void TimedBuffer()
        {
            TimeSpan waitTime = TimeSpan.FromMinutes(1);
            BufferOptions options = BufferOptions.TimedBuffer(waitTime);
            Assert.Equal(BufferType.Timed, options.BufferType);
            Assert.Equal(waitTime, options.BufferWaitTime);
            Assert.Equal(default(int), options.BufferSizeBytes);
        }
    }
}
