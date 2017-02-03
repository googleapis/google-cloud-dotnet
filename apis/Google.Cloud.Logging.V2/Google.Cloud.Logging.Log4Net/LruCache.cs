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
using System.Collections.Generic;

namespace Google.Cloud.Logging.Log4Net
{
    class LruCache<K, V>
    {
        struct Item
        {
            public Item(LinkedListNode<K> node, V value)
            {
                Node = node;
                Value = value;
            }

            public LinkedListNode<K> Node { get; }
            public V Value { get; }
        }

        public LruCache(int capacity)
        {
            _capacity = capacity;
            _dict = new Dictionary<K, Item>(capacity);
            _order = new LinkedList<K>();
        }

        private readonly object _lock = new object();
        private readonly int _capacity;
        private readonly Dictionary<K, Item> _dict;
        private readonly LinkedList<K> _order;

        public V GetOrAdd(K key, Func<V> valueFn)
        {
            lock (_lock)
            {
                Item item;
                if (_dict.TryGetValue(key, out item))
                {
                    _order.Remove(item.Node);
                }
                else
                {
                    if (_dict.Count >= _capacity)
                    {
                        LinkedListNode<K> last = _order.Last;
                        _order.RemoveLast();
                        _dict.Remove(last.Value);
                    }
                    item = new Item(new LinkedListNode<K>(key), valueFn());
                    _dict.Add(key, item);
                }
                _order.AddFirst(item.Node);
                return item.Value;
            }
        }

        public int Count
        {
            get
            {
                lock(_lock)
                {
                    return _dict.Count;
                }
            }
        }
    }
}
