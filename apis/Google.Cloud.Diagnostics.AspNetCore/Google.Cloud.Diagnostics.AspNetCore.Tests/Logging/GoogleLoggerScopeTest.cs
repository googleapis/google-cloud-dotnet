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
using System.Threading.Tasks;
using Xunit;

namespace Google.Cloud.Diagnostics.AspNetCore.Tests
{
    public class GoogleLoggerScopeTest
    {
        [Fact]
        public void Current_Unset()
        {
            Assert.Null(GoogleLoggerScope.Current);
        }

        [Fact]
        public void Scope()
        {
            Assert.Null(GoogleLoggerScope.Current);
            using (new GoogleLoggerScope("message"))
            {
                Assert.Equal("message => ", GoogleLoggerScope.Current.ToString());
            }
            Assert.Null(GoogleLoggerScope.Current);
        }

        [Fact]
        public void MultipleScopes_Nested()
        {
            Assert.Null(GoogleLoggerScope.Current);
            using (new GoogleLoggerScope("grandparent"))
            {
                Assert.Equal("grandparent => ", GoogleLoggerScope.Current.ToString());
                using (new GoogleLoggerScope("parent"))
                {
                    Assert.Equal("grandparent => parent => ", GoogleLoggerScope.Current.ToString());
                    using (new GoogleLoggerScope("child"))
                    {
                        Assert.Equal("grandparent => parent => child => ", GoogleLoggerScope.Current.ToString());
                    }
                }
                Assert.Equal("grandparent => ", GoogleLoggerScope.Current.ToString());
                using (new GoogleLoggerScope("other_parent"))
                {
                    Assert.Equal("grandparent => other_parent => ", GoogleLoggerScope.Current.ToString());
                }
                Assert.Equal("grandparent => ", GoogleLoggerScope.Current.ToString());
            }
            Assert.Null(GoogleLoggerScope.Current);
        }

        [Fact]
        public async Task MultipleScopes_Threads_Running_During_Scope()
        {
            string rootScope = "root";
            Func<string, string, string, Task> func = async (grandparent, parent, child) =>
            {
                Assert.Equal($"{rootScope} => ", GoogleLoggerScope.Current.ToString());
                using (new GoogleLoggerScope(grandparent))
                {
                    Assert.Equal($"{rootScope} => {grandparent} => ", GoogleLoggerScope.Current.ToString());
                    await Task.Yield();
                    using (new GoogleLoggerScope(parent))
                    {
                        Assert.Equal($"{rootScope} => {grandparent} => {parent} => ", GoogleLoggerScope.Current.ToString());
                        await Task.Yield();
                        using (new GoogleLoggerScope(child))
                        {
                            Assert.Equal($"{rootScope} => {grandparent} => {parent} => {child} => ", GoogleLoggerScope.Current.ToString());
                            await Task.Yield();
                        }
                        await Task.Yield();
                        Assert.Equal($"{rootScope} => {grandparent} => {parent} => ", GoogleLoggerScope.Current.ToString());
                    }
                    await Task.Yield();
                    Assert.Equal($"{rootScope} => {grandparent} => ", GoogleLoggerScope.Current.ToString());
                }
                Assert.Equal($"{rootScope} => ", GoogleLoggerScope.Current.ToString());
            };

            using (new GoogleLoggerScope(rootScope))
            {
                await Task.WhenAll(
                        Task.Run(() => func("grandparent-one", "parent-one", "child-one")),
                        Task.Run(() => func("grandparent-two", "parent-two", "child-two")),
                        Task.Run(() => func("grandparent-three", "parent-three", "child-three")),
                        Task.Run(() => func("grandparent-four", "parent-four", "child-four")),
                        Task.Run(() => func("grandparent-five", "parent-five", "child-five")));
            }
        }

        [Fact]
        public async Task MultipleScopes_Threads_Started_Before_Scope()
        {
            var childThreadsReleased = new ManualResetEventSlim(initialState: false);

            Func<string, string, Task> op = async (parent, child) =>
            {
                childThreadsReleased.Wait();

                Assert.Null(GoogleLoggerScope.Current);
                using (new GoogleLoggerScope(parent))
                {
                    Assert.Equal($"{parent} => ", GoogleLoggerScope.Current.ToString());
                    await Task.Yield();
                    using (new GoogleLoggerScope(child))
                    {
                        Assert.Equal($"{parent} => {child} => ", GoogleLoggerScope.Current.ToString());
                        await Task.Yield();
                    }
                    await Task.Yield();
                    Assert.Equal($"{parent} => ", GoogleLoggerScope.Current.ToString());
                }
                await Task.Yield();
                Assert.Null(GoogleLoggerScope.Current);
            };

            var t1 = Task.Run(() => op("parent-one", "child-one").Wait());
            var t2 = Task.Run(() => op("parent-two", "child-two").Wait());

            using (new GoogleLoggerScope("root"))
            {
                childThreadsReleased.Set();
                await Task.WhenAll(t1, t2);
            }
        }

        [Fact]
        public async Task MultipleScopes_Threads_Started_During_Scope()
        {
            string rootScope = "root";
            var childThreadsReleased = new ManualResetEventSlim(initialState: false);

            Func<string, string, Task> op = async (parent, child) =>
            {
                childThreadsReleased.Wait();

                Assert.Equal($"{rootScope} => ", GoogleLoggerScope.Current.ToString());
                using (new GoogleLoggerScope(parent))
                {
                    Assert.Equal($"{rootScope} => {parent} => ", GoogleLoggerScope.Current.ToString());
                    await Task.Yield();
                    using (new GoogleLoggerScope(child))
                    {
                        Assert.Equal($"{rootScope} => {parent} => {child} => ", GoogleLoggerScope.Current.ToString());
                        await Task.Yield();
                    }
                    await Task.Yield();
                    Assert.Equal($"{rootScope} => {parent} => ", GoogleLoggerScope.Current.ToString());
                }
                await Task.Yield();
                Assert.Equal($"{rootScope} => ", GoogleLoggerScope.Current.ToString());
            };

            Task t1;
            Task t2;
            using (new GoogleLoggerScope(rootScope))
            {
                t1 = Task.Run(() => op("parent-one", "child-one").Wait());
                t2 = Task.Run(() => op("parent-two", "child-two").Wait());
            }

            childThreadsReleased.Set();
            await Task.WhenAll(t1, t2);
        }
    }
}
