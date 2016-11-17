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
// limitations under the License.using Microsoft.VisualStudio.TestTools.UnitTesting;

using System;
using System.Linq;
using Xunit;

namespace Google.Devtools.AspNet.Tests.CloudTrace
{
    public class TraceIdFactoryTest
    {
        private class FakeRandom : Random
        {
            private byte[] _bytes;
            public FakeRandom(byte[] bytes)
            {
                _bytes = bytes;
            }

            public override void NextBytes(byte[] bytes)
            {
                if (_bytes.Length != bytes.Length)
                {
                    throw new ArgumentException("byte arrays must be same lenght");
                }
                for (int i = 0; i < bytes.Length; i++)
                {
                    bytes[i] = _bytes[i];
                }
            }
        }

        [Fact]
        public void NextId() {
            byte[] bytes = Enumerable.Repeat(byte.MinValue, 16).ToArray();
            bytes[0] = 222;
            bytes[1] = 173;
            bytes[2] = 190;
            bytes[3] = 239;
            Random fakeRandom = new FakeRandom(bytes);
            TraceIdFactory factory = TraceIdFactory.Create(fakeRandom);
            Assert.Equal("deadbeef".PadRight(32, '0'), factory.NextId());
        }

        [Fact]
        public void NextId_Min()
        {
            byte[] bytes = Enumerable.Repeat(byte.MinValue, 16).ToArray();
            Random fakeRandom = new FakeRandom(bytes);
            TraceIdFactory factory = TraceIdFactory.Create(fakeRandom);
            Assert.Equal(new string('0', 32), factory.NextId());
        }

        [Fact]
        public void NextId_Max()
        {
            byte[] bytes = Enumerable.Repeat(byte.MaxValue, 16).ToArray();
            Random fakeRandom = new FakeRandom(bytes);
            TraceIdFactory factory = TraceIdFactory.Create(fakeRandom);
            Assert.Equal(new string('f', 32), factory.NextId());
        }
    }
}
