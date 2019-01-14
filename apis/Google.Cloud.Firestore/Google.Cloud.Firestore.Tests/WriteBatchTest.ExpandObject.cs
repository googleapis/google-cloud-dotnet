// Copyright 2017, Google Inc. All rights reserved.
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

using Google.Cloud.Firestore.V1;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Xunit;
using static Google.Cloud.Firestore.Tests.ProtoHelpers;

namespace Google.Cloud.Firestore.Tests
{
    // Just tests for WriteBatch.ExpandObject
    public partial class WriteBatchTest
    {
        [Fact]
        public void ExpandObject_DisjointKeys()
        {
            var input = new OrderPreservingDictionary<FieldPath, Value>
            {
                { new FieldPath("a"), CreateValue(10) },
                { new FieldPath("b"), CreateValue(20) },
                { new FieldPath("c", "d"), CreateValue(30) }
            };
            var expected = new Dictionary<string, Value>
            {
                { "a", CreateValue(10) },
                { "b", CreateValue(20) },
                { "c", CreateMap("d", CreateValue(30)) }
            };
            AssertExpandObjectValid(input, expected);
        }

        [Fact]
        public void ExpandObject_DottedFieldPath()
        {
            var input = new OrderPreservingDictionary<FieldPath, Value>
            {
                // These two field paths are unrelated
                { new FieldPath("a.b"), CreateValue(10) },
                { new FieldPath("a", "b"), CreateValue(20) },
            };
            var expected = new Dictionary<string, Value>
            {
                { "a.b", CreateValue(10) },
                { "a", CreateMap("b", CreateValue(20)) },
            };
            AssertExpandObjectValid(input, expected);
        }

        [Fact]
        public void ExpandObject_IntermediateMapMerging()
        {
            var input = new OrderPreservingDictionary<FieldPath, Value>
            {
                { new FieldPath("a", "b", "c"), CreateValue(10) },
                { new FieldPath("a", "b", "d"), CreateValue(20) }
            };
            var expected = new Dictionary<string, Value>
            {
                { "a", CreateMap("b", CreateMap(("c", CreateValue(10)), ("d", CreateValue(20)))) }
            };
            AssertExpandObjectValid(input, expected);
        }

        /// <summary>
        /// Asserts that we get the right output even after reversing the order of input.
        /// </summary>
        private void AssertExpandObjectValid(OrderPreservingDictionary<FieldPath, Value> input, Dictionary<string, Value> expected)
        {
            var actual = WriteBatch.ExpandObject(input);
            Assert.Equal(expected, actual);
            actual = WriteBatch.ExpandObject(input.InReverseOrder());
            Assert.Equal(expected, actual);
        }

        /// <summary>
        /// Asserts that expanding the given input fails in both the original order and reverse order.
        /// </summary>
        private void AssertExpandObjectInvalid(OrderPreservingDictionary<FieldPath, Value> input)
        {
            Assert.Throws<InvalidOperationException>(() => WriteBatch.ExpandObject(input));
            Assert.Throws<InvalidOperationException>(() => WriteBatch.ExpandObject(input.InReverseOrder()));
        }

        /// <summary>
        /// Dictionary that preserves insertion order. Far from production ready, but it allows us to test more robustly here.
        /// </summary>
        private class OrderPreservingDictionary<TKey, TValue> : IDictionary<TKey, TValue>
        {
            private readonly Dictionary<TKey, TValue> _dictionary = new Dictionary<TKey, TValue>();
            private readonly List<TKey> _keysInOrder = new List<TKey>();

            public OrderPreservingDictionary<TKey, TValue> InReverseOrder()
            {
                var ret = new OrderPreservingDictionary<TKey, TValue>();
                foreach (var item in this.Reverse())
                {
                    ret.Add(item);
                }
                return ret;
            }

            public TValue this[TKey key]
            {
                get => _dictionary[key];
                set
                {
                    if (!_keysInOrder.Contains(key))
                    {
                        _keysInOrder.Add(key);
                    }
                    _dictionary[key] = value;
                }
            }

            public ICollection<TKey> Keys => _keysInOrder;

            public ICollection<TValue> Values => Keys.Select(key => this[key]).ToList();

            public int Count => _dictionary.Count;

            public bool IsReadOnly => false;

            public void Add(TKey key, TValue value)
            {
                _dictionary.Add(key, value);
                _keysInOrder.Add(key);
            }

            public void Add(KeyValuePair<TKey, TValue> item) => Add(item.Key, item.Value);

            public void Clear()
            {
                _dictionary.Clear();
                _keysInOrder.Clear();
            }

            public bool Contains(KeyValuePair<TKey, TValue> item) => _dictionary.Contains(item);

            public bool ContainsKey(TKey key) => _dictionary.ContainsKey(key);

            void ICollection<KeyValuePair<TKey, TValue>>.CopyTo(KeyValuePair<TKey, TValue>[] array, int arrayIndex) =>
                ((ICollection<KeyValuePair<TKey, TValue>>) _dictionary).CopyTo(array, arrayIndex);

            public IEnumerator<KeyValuePair<TKey, TValue>> GetEnumerator() =>
                _keysInOrder.Select(key => new KeyValuePair<TKey, TValue>(key, this[key])).GetEnumerator();

            public bool Remove(TKey key)
            {
                bool ret = _dictionary.Remove(key);
                if (ret)
                {
                    _keysInOrder.Remove(key);
                }
                return ret;
            }

            bool ICollection<KeyValuePair<TKey, TValue>>.Remove(KeyValuePair<TKey, TValue> item)
            {
                bool ret = ((ICollection<KeyValuePair<TKey, TValue>>) _dictionary).Remove(item);
                if (ret)
                {
                    _keysInOrder.Remove(item.Key);
                }
                return ret;
            }

            public bool TryGetValue(TKey key, out TValue value) => _dictionary.TryGetValue(key, out value);

            IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
        }
    }
}
