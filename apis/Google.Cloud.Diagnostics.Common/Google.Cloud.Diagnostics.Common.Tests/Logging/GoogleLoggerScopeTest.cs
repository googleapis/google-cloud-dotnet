// Copyright 2021 Google LLC
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

using Google.Cloud.Logging.V2;
using Google.Protobuf.WellKnownTypes;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Xunit;

namespace Google.Cloud.Diagnostics.Common.Tests
{
    public class GoogleLoggerScopeTest
    {
        private LogEntry GetEmptyLogEntry() => new LogEntry { JsonPayload = new Struct() };

        private void AssertScope(string scopeValue)
        {
            var logEntry = GetEmptyLogEntry();
            GoogleLoggerScope.Current.ApplyTo(logEntry);
            Assert.Equal(scopeValue, logEntry.JsonPayload.Fields["scope"].StringValue);
        }

        private void AssertEmptyScope()
        {
            var logEntry = GetEmptyLogEntry();
            GoogleLoggerScope.Current.ApplyTo(logEntry);
            Assert.DoesNotContain(logEntry.JsonPayload.Fields.Keys, key => key == "scope");
        }

        private void AssertParentScopes(params Struct[] values)
        {
            var logEntry = GetEmptyLogEntry();
            GoogleLoggerScope.Current.ApplyTo(logEntry);
            Assert.Collection(
                logEntry.JsonPayload.Fields["parent_scopes"].ListValue.Values.Select(v => v.StructValue),
                values.Select<Struct, Action<Struct>>(expected => actual => Assert.Equal(expected, actual)).ToArray());
        }

        private void AssertEmptyParentScopes()
        {
            var logEntry = GetEmptyLogEntry();
            GoogleLoggerScope.Current.ApplyTo(logEntry);
            Assert.DoesNotContain(logEntry.JsonPayload.Fields.Keys, key => key == "parent_scopes");
        }

        private void AssertLabels(params KeyValuePair<string, string>[] labels)
        {
            var logEntry = GetEmptyLogEntry();
            GoogleLoggerScope.Current.ApplyTo(logEntry);
            Assert.Collection(
                logEntry.Labels,
                labels.Select<KeyValuePair<string, string>, Action<KeyValuePair<string, string>>>(expected => actual =>
                {
                    Assert.Equal(expected.Key, actual.Key);
                    Assert.Equal(expected.Value, actual.Value);
                }).ToArray());
        }

        [Fact]
        public void Current_Unset()
        {
            Assert.Null(GoogleLoggerScope.Current);
        }

        [Fact]
        public void Scope()
        {
            Assert.Null(GoogleLoggerScope.Current);
            using (GoogleLoggerScope.BeginScope("message"))
            {
                AssertScope("message");
            }
            Assert.Null(GoogleLoggerScope.Current);
        }

        [Fact]
        public void MultipleScopes_Nested()
        {
            Assert.Null(GoogleLoggerScope.Current);
            using (GoogleLoggerScope.BeginScope("grandparent"))
            {
                AssertScope("grandparent");

                using (GoogleLoggerScope.BeginScope("parent"))
                {
                    AssertScope("grandparent => parent");

                    using (GoogleLoggerScope.BeginScope("child"))
                    {
                        AssertScope("grandparent => parent => child");
                    }

                    AssertScope("grandparent => parent");
                }

                AssertScope("grandparent");

                using (GoogleLoggerScope.BeginScope("other_parent"))
                {
                    AssertScope("grandparent => other_parent");
                }

                AssertScope("grandparent");
            }
            Assert.Null(GoogleLoggerScope.Current);
        }

        [Fact]
        public void MultipleScopes_Nested_KeyValuePairs()
        {
            Assert.Null(GoogleLoggerScope.Current);
            using (GoogleLoggerScope.BeginScope(new DummyKeyValuePairs { { "grandfather", "Joey" }, { "grandmother", "Janey" } }))
            {
                AssertScope("['grandfather'='Joey']['grandmother'='Janey']");
                AssertParentScopes(
                    new Struct { Fields = { { "grandfather", Value.ForString("Joey") }, { "grandmother", Value.ForString("Janey") } } });

                using (GoogleLoggerScope.BeginScope(new DummyKeyValuePairs { { "father", "Joe" }, { "mother", "Jane" } }))
                {
                    AssertScope("['grandfather'='Joey']['grandmother'='Janey'] => ['father'='Joe']['mother'='Jane']");
                    AssertParentScopes(
                        new Struct { Fields = { { "father", Value.ForString("Joe") }, { "mother", Value.ForString("Jane") } } },
                        new Struct { Fields = { { "grandfather", Value.ForString("Joey") }, { "grandmother", Value.ForString("Janey") } } });
                }

                AssertScope("['grandfather'='Joey']['grandmother'='Janey']");
                AssertParentScopes(
                    new Struct { Fields = { { "grandfather", Value.ForString("Joey") }, { "grandmother", Value.ForString("Janey") } } });
            }
            Assert.Null(GoogleLoggerScope.Current);
        }

        [Fact]
        public void MultipleScopes_Nested_Labels()
        {
            Assert.Null(GoogleLoggerScope.Current);
            using (GoogleLoggerScope.BeginScope(new LabellingScopeState(
                new KeyValuePair<string, string>("grandfather", "Joey"),
                new KeyValuePair<string, string>("grandmother", "Janey"))))
            {
                // This is the labelling scope, we add its information on labels only.
                AssertEmptyScope();
                AssertEmptyParentScopes();
                AssertLabels(
                    new KeyValuePair<string, string>("grandfather", "Joey"),
                    new KeyValuePair<string, string>("grandmother", "Janey"));

                using (GoogleLoggerScope.BeginScope(new LabellingScopeState(
                    new KeyValuePair<string, string>("father", "Joe"),
                    new KeyValuePair<string, string>("mother", "Jane"))))
                {
                    AssertEmptyScope();
                    AssertEmptyParentScopes();
                    AssertLabels(
                        new KeyValuePair<string, string>("grandfather", "Joey"),
                        new KeyValuePair<string, string>("grandmother", "Janey"),
                        new KeyValuePair<string, string>("father", "Joe"),
                        new KeyValuePair<string, string>("mother", "Jane"));
                }

                AssertEmptyScope();
                AssertEmptyParentScopes();
                AssertLabels(
                    new KeyValuePair<string, string>("grandfather", "Joey"),
                    new KeyValuePair<string, string>("grandmother", "Janey"));
            }
            Assert.Null(GoogleLoggerScope.Current);
        }

        [Fact]
        public void MultipleScopes_Nested_Mixed()
        {
            Assert.Null(GoogleLoggerScope.Current);
            using (GoogleLoggerScope.BeginScope(new DummyKeyValuePairs { { "father", "Joe" }, { "mother", "Jane" } }))
            {
                AssertScope("['father'='Joe']['mother'='Jane']");
                AssertParentScopes(
                    new Struct { Fields = { { "father", Value.ForString("Joe") }, { "mother", Value.ForString("Jane") } } });

                using (GoogleLoggerScope.BeginScope("myself"))
                {
                    AssertScope("['father'='Joe']['mother'='Jane'] => myself");
                    // "myself" is not added to parent_scopes because it is not of the form key=>value.
                    AssertParentScopes(
                        new Struct { Fields = { { "father", Value.ForString("Joe") }, { "mother", Value.ForString("Jane") } } });
                    using (GoogleLoggerScope.BeginScope(new LabellingScopeState(
                        new KeyValuePair<string, string>("job_title", "hairdresser"))))
                    {
                        AssertScope("['father'='Joe']['mother'='Jane'] => myself");
                        // "myself" is not added to parent_scopes because it is not of the form key=>value.
                        AssertParentScopes(
                            new Struct { Fields = { { "father", Value.ForString("Joe") }, { "mother", Value.ForString("Jane") } } });
                        AssertLabels(new KeyValuePair<string, string>("job_title", "hairdresser"));
                    }
                }

                AssertScope("['father'='Joe']['mother'='Jane']");
                AssertParentScopes(
                    new Struct { Fields = { { "father", Value.ForString("Joe") }, { "mother", Value.ForString("Jane") } } });
            }
            Assert.Null(GoogleLoggerScope.Current);
        }

        [Fact]
        public async Task MultipleScopes_Threads_Running_During_Scope()
        {
            string rootScope = "root";
            Func<string, string, string, Task> func = async (grandparent, parent, child) =>
            {
                AssertScope(rootScope);

                using (GoogleLoggerScope.BeginScope(grandparent))
                {
                    AssertScope($"{rootScope} => {grandparent}");
                    await Task.Yield();

                    using (GoogleLoggerScope.BeginScope(parent))
                    {
                        AssertScope($"{rootScope} => {grandparent} => {parent}");
                        await Task.Yield();

                        using (GoogleLoggerScope.BeginScope(child))
                        {
                            AssertScope($"{rootScope} => {grandparent} => {parent} => {child}");
                            await Task.Yield();
                        }

                        await Task.Yield();
                        AssertScope($"{rootScope} => {grandparent} => {parent}");
                    }

                    await Task.Yield();
                    AssertScope($"{rootScope} => {grandparent}");
                }

                AssertScope(rootScope);
            };

            using (GoogleLoggerScope.BeginScope(rootScope))
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

                using (GoogleLoggerScope.BeginScope(parent))
                {
                    AssertScope(parent);
                    await Task.Yield();

                    using (GoogleLoggerScope.BeginScope(child))
                    {
                        AssertScope($"{parent} => {child}");
                        await Task.Yield();
                    }

                    await Task.Yield();
                    AssertScope(parent);
                }

                await Task.Yield();
                Assert.Null(GoogleLoggerScope.Current);
            };

            var t1 = Task.Run(() => op("parent-one", "child-one").Wait());
            var t2 = Task.Run(() => op("parent-two", "child-two").Wait());

            using (GoogleLoggerScope.BeginScope("root"))
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

                AssertScope(rootScope);

                using (GoogleLoggerScope.BeginScope(parent))
                {
                    AssertScope($"{rootScope} => {parent}");
                    await Task.Yield();

                    using (GoogleLoggerScope.BeginScope(child))
                    {
                        AssertScope($"{rootScope} => {parent} => {child}");
                        await Task.Yield();
                    }

                    await Task.Yield();
                    AssertScope($"{rootScope} => {parent}");
                }

                await Task.Yield();
                AssertScope(rootScope);
            };

            Task t1;
            Task t2;
            using (GoogleLoggerScope.BeginScope(rootScope))
            {
                t1 = Task.Run(() => op("parent-one", "child-one").Wait());
                t2 = Task.Run(() => op("parent-two", "child-two").Wait());
            }

            childThreadsReleased.Set();
            await Task.WhenAll(t1, t2);
        }

        private class DummyKeyValuePairs : IEnumerable<KeyValuePair<string, object>>
        {
            private IList<KeyValuePair<string, object>> _pairs = new List<KeyValuePair<string, object>>();

            public void Add(string key, object value) => _pairs.Add(new KeyValuePair<string, object>(key, value));

            public IEnumerator<KeyValuePair<string, object>> GetEnumerator() => _pairs.GetEnumerator();

            IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();

            public override string ToString()
            {
                StringBuilder builder = new StringBuilder();
                foreach (var pair in _pairs)
                {
                    builder.Append($"['{pair.Key}'='{pair.Value}']");
                }
                return builder.ToString();
            }
        }
    }
}
