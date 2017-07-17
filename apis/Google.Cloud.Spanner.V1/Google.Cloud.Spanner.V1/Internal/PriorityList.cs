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
using System.Linq;

namespace Google.Cloud.Spanner.V1.Internal
{
    /// <summary>
    /// A simple sorted list that sorts based on the result of CompareTo,
    /// but also allows duplicate entries based on CompareTo.
    /// </summary>
    /// <remarks>This is not intended for general purpose use; it is designed for use with Spanner clients.</remarks>
    public class PriorityList<T> where T : IPriorityListItem<T>
    {
        private readonly List<T> _innerList = new List<T>();

        /// <summary>
        /// The number of elements in the list.
        /// </summary>
        public int Count
        {
            get
            {
                lock (_innerList)
                {
                    return _innerList.Count;
                }
            }
        }

        /// <summary>
        /// Returns a snapshot of the list.
        /// </summary>
        /// <returns>A snapshot of the list.</returns>
        public IEnumerable<T> GetSnapshot()
        {
            lock (_innerList)
            {
                return _innerList.ToArray();
            }
        }

        /// <summary>
        /// Adds an item to the list.
        /// </summary>
        /// <param name="item">The item to add to the list.</param>
        public void Add(T item)
        {
            lock (_innerList)
            {
                //just in case the priority of the item is out of sync, we'll
                //do a full scan to remove the old version.
                Remove(item);

                //find the insertion point using a slightly faster method.
                var index = _innerList.BinarySearch(item);
                if (index < 0)
                {
                    index = ~index;
                }

                //if priority changes during this call, it will be blocked from
                //processing until after Add has completed.
                item.PriorityChanged += Item_PriorityChanged;
                _innerList.Insert(index, item);
            }
        }

        /// <summary>
        /// Removes an item from the list.
        /// </summary>
        /// <param name="item">The item to remove.</param>
        public void Remove(T item)
        {
            lock (_innerList)
            {
                int index = 0;
                //TODO: figure out a better way than a linear search here.
                //Since this structure will mostly be used ~200 items or less,
                //it will not be a major issue, but it would be nice to address it.
                for (; index < _innerList.Count; index++)
                {
                    if (ReferenceEquals(_innerList[index], item))
                    {
                        break;
                    }
                }
                if (index < _innerList.Count)
                {
                    _innerList.RemoveAt(index);
                    item.PriorityChanged -= Item_PriorityChanged;
                }
            }
        }

        /// <summary>
        /// Removes the last (in terms of priority) element from the list.
        /// </summary>
        public void RemoveLast()
        {
            lock (_innerList)
            {
                if (_innerList.Count > 0)
                {
                    var item = _innerList[_innerList.Count - 1];
                    item.PriorityChanged -= Item_PriorityChanged;
                    _innerList.RemoveAt(_innerList.Count - 1);
                }
            }
        }

        private void Item_PriorityChanged(object sender, EventArgs e)
        {
            lock (_innerList)
            {
                T item = (T) sender;
                lock (_innerList)
                {
                    //Re-Add the item sorted.
                    Remove(item);
                    Add(item);
                }
            }
        }

        /// <summary>
        /// Returns the item with the top priority in the list, without removing it.
        /// </summary>
        /// <returns>The top item.</returns>
        public T GetTop()
        {
            lock (_innerList)
            {
                return _innerList.FirstOrDefault();
            }
        }

        /// <summary>
        /// Attempts to find an item in the list that matches the given predicate.
        /// </summary>
        /// <param name="testPredicate">The predicate to match on.</param>
        /// <param name="result">The out parameter where the result will be stored.</param>
        /// <returns>true if the item was found; false otherwise.</returns>
        public bool TryFindLinear(Predicate<T> testPredicate, out T result)
        {
            lock (_innerList)
            {
                foreach (var item in _innerList)
                {
                    if (testPredicate(item))
                    {
                        result = item;
                        return true;
                    }
                }
                result = default(T);
                return false;
            }
        }
    }
}
