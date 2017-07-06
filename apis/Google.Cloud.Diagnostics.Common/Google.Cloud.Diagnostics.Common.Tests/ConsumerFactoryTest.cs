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
using static Google.Cloud.Diagnostics.Common.Tests.Utils;

namespace Google.Cloud.Diagnostics.Common.Tests
{
    public class ConsumerFactoryTest
    {
        [Fact]
        public void GetConsumer_None()
        {
            BufferOptions bufferOptions = BufferOptions.NoBuffer();
            RetryOptions retryOptions = RetryOptions.NoRetry();
            IConsumer<int> consumer = ConsumerFactory<int>.GetConsumer(new IntConsumer(), ConstantSizer<int>.GetSize, bufferOptions, retryOptions);
            Assert.IsType<RpcRetryConsumer<int>>(consumer);
            var retryConsumer = (RpcRetryConsumer<int>)consumer;
            Assert.IsType<IntConsumer>(retryConsumer._consumer);
        }

        [Fact]
        public void GetConsumer_Sized()
        {
            BufferOptions bufferOptions = BufferOptions.SizedBuffer();
            RetryOptions retryOptions = RetryOptions.NoRetry();
            IConsumer<int> consumer = ConsumerFactory<int>.GetConsumer(new IntConsumer(), ConstantSizer<int>.GetSize, bufferOptions, retryOptions);
            Assert.IsType<SizedBufferingConsumer<int>>(consumer);
        }

        [Fact]
        public void GetConsumer_Timed()
        {
            BufferOptions bufferOptions = BufferOptions.TimedBuffer();
            RetryOptions retryOptions = RetryOptions.NoRetry();
            IConsumer<int> consumer = ConsumerFactory<int>.GetConsumer(new IntConsumer(), ConstantSizer<int>.GetSize, bufferOptions, retryOptions);
            Assert.IsType<TimedBufferingConsumer<int>>(consumer);
        }

        [Fact]
        public void GetConsumer_InvalidOptions()
        {
            BufferOptions bufferOptions = new BufferOptions((BufferType)5);
            RetryOptions retryOptions = RetryOptions.NoRetry();
            Assert.Throws<ArgumentException>(
                () => ConsumerFactory<int>.GetConsumer(new IntConsumer(), ConstantSizer<int>.GetSize, bufferOptions, retryOptions));
        }


        [Fact]
        public void GetConsumer_InvalidOptions_Null()
        {
            Assert.Throws<ArgumentNullException>(
                () => ConsumerFactory<int>.GetConsumer(new IntConsumer(), ConstantSizer<int>.GetSize, null, RetryOptions.NoRetry()));
        }

        [Fact]
        public void GetConsumer_InvalidConsumer_Null()
        {
            Assert.Throws<ArgumentNullException>(
                () => ConsumerFactory<int>.GetConsumer(null, ConstantSizer<int>.GetSize, BufferOptions.TimedBuffer(), RetryOptions.NoRetry()));
        }

        [Fact]
        public void GetConsumer_InvalidSizer_Null()
        {
            Assert.Throws<ArgumentNullException>(
                () => ConsumerFactory<int>.GetConsumer(new IntConsumer(), null, BufferOptions.SizedBuffer(), RetryOptions.NoRetry()));
        }
    }
}
