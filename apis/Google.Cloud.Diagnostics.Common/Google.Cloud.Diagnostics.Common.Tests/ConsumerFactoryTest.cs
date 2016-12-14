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
            BufferOptions options = BufferOptions.NoBuffer();
            IConsumer<int> consumer = ConsumerFactory<int>.GetConsumer(new IntConsumer(), null, options);
            Assert.IsType<IntConsumer>(consumer);
        }

        [Fact]
        public void GetConsumer_Sized()
        {
            BufferOptions options = BufferOptions.SizedBuffer();
            IConsumer<int> consumer = ConsumerFactory<int>.GetConsumer(new IntConsumer(), IntSizer.Instance, options);
            Assert.IsType<SizedBufferingConsumer<int>>(consumer);
        }

        [Fact]
        public void GetConsumer_Timed()
        {
            BufferOptions options = BufferOptions.TimedBuffer();
            IConsumer<int> consumer = ConsumerFactory<int>.GetConsumer(new IntConsumer(), null, options);
            Assert.IsType<TimedBufferingConsumer<int>>(consumer);
        }

        [Fact]
        public void GetConsumer_InvalidOptions()
        {
            BufferOptions options = new BufferOptions((BufferType)5);
            Assert.Throws<ArgumentException>(
                () => ConsumerFactory<int>.GetConsumer(new IntConsumer(), null, options));
        }


        [Fact]
        public void GetConsumer_InvalidOptions_Null()
        {
            Assert.Throws<ArgumentNullException>(
                () => ConsumerFactory<int>.GetConsumer(new IntConsumer(), null, null));
        }

        [Fact]
        public void GetConsumer_InvalidConsumer_Null()
        {
            Assert.Throws<ArgumentNullException>(
                () => ConsumerFactory<int>.GetConsumer(null, null, BufferOptions.TimedBuffer()));
        }

        [Fact]
        public void GetConsumer_InvalidSizer_Null()
        {
            Assert.Throws<ArgumentNullException>(
                () => ConsumerFactory<int>.GetConsumer(new IntConsumer(), null, BufferOptions.SizedBuffer()));
        }
    }
}
