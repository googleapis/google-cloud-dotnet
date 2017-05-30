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
using System.Threading;
using Xunit;

namespace Google.Cloud.Logging.Log4Net.Tests
{
    public class LruCacheTest
    {
        [Fact]
        public void TestWithCapacity1()
        {
            var lru = new LruCache<int, object>(1);
            Assert.Equal(0, lru.Count);
            var one = new object();
            var two = new object();
            Assert.Same(one, lru.GetOrAdd(1, () => one));
            Assert.Equal(1, lru.Count);
            Assert.Same(one, lru.GetOrAdd(1, () => null));
            Assert.Equal(1, lru.Count);
            Assert.Same(two, lru.GetOrAdd(2, () => two));
            Assert.Equal(1, lru.Count);
            Assert.Same(two, lru.GetOrAdd(2, () => null));
            Assert.Equal(1, lru.Count);
        }

        [Fact]
        public void TestWithCapacity100()
        {
            var lru = new LruCache<int, string>(100);
            var values = new string[50];
            // Add 50 known value, check they are returned
            for (int i = 0; i < 50; i++)
            {
                values[i] = $"value:{i}";
                Assert.Same(values[i], lru.GetOrAdd(i, () => values[i]));
            }
            Assert.Equal(50, lru.Count);
            // Check original 50 values still there
            for (int i = 0; i < 50; i++)
            {
                Assert.Same(values[i], lru.GetOrAdd(i, () => null));
            }
            Assert.Equal(50, lru.Count);
            // Add 50 more values
            for (int i = 50; i < 100; i++)
            {
                Assert.Null(lru.GetOrAdd(i, () => null));
            }
            Assert.Equal(100, lru.Count);
            // Check original 50 values still there
            for (int i = 0; i < 50; i++)
            {
                Assert.Same(values[i], lru.GetOrAdd(i, () => null));
            }
            Assert.Equal(100, lru.Count);
            // Add 50 more values
            for (int i = 100; i < 125; i++)
            {
                Assert.Null(lru.GetOrAdd(i, () => null));
            }
            Assert.Equal(100, lru.Count);
            // Check original 50 are still there
            for (int i = 0; i < 50; i++)
            {
                Assert.Same(values[i], lru.GetOrAdd(i, () => null));
            }
            Assert.Equal(100, lru.Count);
            // Add 75 more values, to wipe out 25 of the original 50
            for (int i = 125; i < 200; i++)
            {
                Assert.Null(lru.GetOrAdd(i, () => null));
            }
            Assert.Equal(100, lru.Count);
            // check 25-49 are still there, and 0-24 are gone
            for (int i = 25; i < 50; i++)
            {
                Assert.Same(values[i], lru.GetOrAdd(i, () => null));
            }
            for (int i = 0; i < 25; i++)
            {
                Assert.Equal("gone", lru.GetOrAdd(i, () => "gone"));
            }
            Assert.Equal(100, lru.Count);
        }

        [Fact]
        public void MultithreadedUse()
        {
            const int threadCount = 10;
            const int lruCapacity = 1000;
            const int perThread = 50000;
            var lru = new LruCache<int, object>(lruCapacity);
            bool failure = false;
            Thread[] threads = new Thread[threadCount];
            for (int i = 0; i < threadCount; i++)
            {
                int initial = i * perThread;
                threads[i] = new Thread(() =>
                {
                    for (int j = 0; j < perThread; j++)
                    {
                        var obj0 = new object();
                        var obj1 = lru.GetOrAdd(initial + j, () => obj0);
                        if (!ReferenceEquals(obj0, obj1))
                        {
                            failure = true;
                        }
                    }
                });
                threads[i].Start();
            }
            for (int i = 0; i < threadCount; i++)
            {
                Assert.True(threads[i].Join((int)TimeSpan.FromSeconds(60).TotalMilliseconds));
            }
            Assert.False(failure);
            Assert.Equal(lruCapacity, lru.Count);
        }
    }
}
