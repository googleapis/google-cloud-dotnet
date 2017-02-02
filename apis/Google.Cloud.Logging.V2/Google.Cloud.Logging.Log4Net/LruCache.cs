using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

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
