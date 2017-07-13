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
using Google.Cloud.Spanner.V1.Internal;
using Xunit;

namespace Google.Cloud.Spanner.Data.Tests
{
    public class PriorityListTests
    {
        private void AssertExist(PriorityList<TestItem> priorityList, params TestItem[] testItems)
        {
            foreach (var testItem in testItems)
            {
                Assert.True(priorityList.TryFindLinear(x => ReferenceEquals(x, testItem), out _));
            }
        }

        private void AssertNotExist(PriorityList<TestItem> priorityList, params TestItem[] testItems)
        {
            foreach (var testItem in testItems)
            {
                Assert.False(priorityList.TryFindLinear(x => ReferenceEquals(x, testItem), out _));
            }
        }

        private static void AssertSorted(PriorityList<TestItem> priorityList) => Assert.True(IsSorted(priorityList));

        private static void AssertNotSorted(PriorityList<TestItem> priorityList) =>
            Assert.False(IsSorted(priorityList));

        private static bool IsSorted(PriorityList<TestItem> priorityList)
        {
            var lastPriority = 0;
            foreach (var testItem in priorityList.GetSnapshot())
            {
                if (lastPriority > testItem.Priority)
                {
                    return false;
                }
                lastPriority = testItem.Priority;
            }
            return true;
        }

        private class TestItem : IPriorityListItem<TestItem>
        {
            public int Priority { get; set; }

            public bool HasEventHooks => PriorityChanged != null;

            public TestItem(int priority) => Priority = priority;

            /// <inheritdoc />
            public int CompareTo(TestItem other) => Comparer<int>.Default.Compare(Priority, other.Priority);

            /// <inheritdoc />
            public event EventHandler<EventArgs> PriorityChanged;

            //For test purposes, we do this manually.
            //Normally this is done automatically, but we do it manually
            //to test prioritylist behavior when the item is temporarily
            //in a transition state.
            public void FirePriorityChanged()
            {
                PriorityChanged?.Invoke(this, EventArgs.Empty);
            }
        }

        [Fact]
        public void CanAddMultipleOfSamePriority()
        {
            var priorityList = new PriorityList<TestItem>();
            TestItem item1, item2;
            priorityList.Add(item1 = new TestItem(5));
            priorityList.Add(item2 = new TestItem(5));
            Assert.Equal(2, priorityList.Count);
            AssertExist(priorityList, item1, item2);
        }

        [Fact]
        public void DeleteNonExistentItemNoops()
        {
            var priorityList = new PriorityList<TestItem>();
            priorityList.Add(new TestItem(1));
            priorityList.Add(new TestItem(2));
            priorityList.Remove(new TestItem(1));

            Assert.Equal(2, priorityList.Count);
        }

        [Fact]
        public void DeleteRemovesCorrectItem()
        {
            var priorityList = new PriorityList<TestItem>();
            TestItem toRemove;
            priorityList.Add(toRemove = new TestItem(5));
            priorityList.Add(new TestItem(5));
            priorityList.Remove(toRemove);
            priorityList.Add(new TestItem(5));
            Assert.Equal(2, priorityList.Count);
            AssertNotExist(priorityList, toRemove);
        }

        [Fact]
        public void DeleteRemovesEventHook()
        {
            var priorityList = new PriorityList<TestItem>();
            TestItem toRemove, toKeep;
            priorityList.Add(toRemove = new TestItem(5));
            priorityList.Add(toKeep = new TestItem(5));

            Assert.True(toRemove.HasEventHooks);
            priorityList.Remove(toRemove);
            Assert.False(toRemove.HasEventHooks);
            Assert.True(toKeep.HasEventHooks);
        }

        [Fact]
        public void DeleteRemovesOutOfSyncItem()
        {
            var priorityList = new PriorityList<TestItem>();
            TestItem toRemove;
            priorityList.Add(toRemove = new TestItem(5));
            priorityList.Add(new TestItem(5));
            toRemove.Priority = 4;

            priorityList.Remove(toRemove);
            Assert.Equal(1, priorityList.Count);
            AssertNotExist(priorityList, toRemove);
        }

        [Fact]
        public void DoubleAddNoops()
        {
            var priorityList = new PriorityList<TestItem>();
            TestItem itemToAdd;
            priorityList.Add(itemToAdd = new TestItem(1));
            priorityList.Add(itemToAdd);

            Assert.Equal(1, priorityList.Count);
            priorityList.Remove(itemToAdd);
            //Lets make sure the double add didnt result in additional event hooks.
            Assert.False(itemToAdd.HasEventHooks);
        }

        [Fact]
        public void GetTop()
        {
            var priorityList = new PriorityList<TestItem>();

            priorityList.Add(new TestItem(3));
            priorityList.Add(new TestItem(11));
            priorityList.Add(new TestItem(2));
            priorityList.Add(new TestItem(0));
            priorityList.Add(new TestItem(6));

            AssertSorted(priorityList);

            Assert.Equal(0, priorityList.GetTop().Priority);
        }

        [Fact]
        public void MultipleAddRemovesStaySorted()
        {
            var priorityList = new PriorityList<TestItem>();
            TestItem item1, item2, item3, item4, item5;

            priorityList.Add(item1 = new TestItem(1));
            priorityList.Add(item2 = new TestItem(5));
            priorityList.Add(item3 = new TestItem(3));
            priorityList.Add(item4 = new TestItem(5));
            priorityList.Add(item5 = new TestItem(6));

            AssertExist(priorityList, item1, item2, item3, item4, item5);
            AssertSorted(priorityList);

            priorityList.Remove(item3);
            AssertNotExist(priorityList, item3);
            AssertSorted(priorityList);

            priorityList.Remove(item4);
            AssertNotExist(priorityList, item4);
            AssertExist(priorityList, item2);
            AssertSorted(priorityList);

            priorityList.Add(item4);
            AssertExist(priorityList, item4);
            AssertSorted(priorityList);
            Assert.Equal(4, priorityList.Count);
        }

        [Fact]
        public void PriorityChangeResortsList()
        {
            var priorityList = new PriorityList<TestItem>();
            TestItem changingItem;

            priorityList.Add(new TestItem(3));
            priorityList.Add(new TestItem(11));
            priorityList.Add(changingItem = new TestItem(2));
            priorityList.Add(new TestItem(0));
            priorityList.Add(new TestItem(6));
            AssertSorted(priorityList);
            changingItem.Priority = 20;
            AssertNotSorted(priorityList);
            changingItem.FirePriorityChanged();
            AssertSorted(priorityList);
        }

        [Fact]
        public void RemoveAfterPriorityChange()
        {
            var priorityList = new PriorityList<TestItem>();
            TestItem changingItem, toRemoveItem;

            priorityList.Add(new TestItem(3));
            priorityList.Add(changingItem = new TestItem(2));
            priorityList.Add(toRemoveItem = new TestItem(6));

            changingItem.Priority = 6;
            changingItem.FirePriorityChanged();
            priorityList.Remove(toRemoveItem);

            AssertExist(priorityList, changingItem);
            AssertNotExist(priorityList, toRemoveItem);
            Assert.Equal(2, priorityList.Count);
        }

        [Fact]
        public void RemoveBeforePriorityChange()
        {
            var priorityList = new PriorityList<TestItem>();
            TestItem changingItem;

            priorityList.Add(new TestItem(3));
            priorityList.Add(changingItem = new TestItem(2));
            priorityList.Add(new TestItem(6));

            changingItem.Priority = 6;
            priorityList.Remove(changingItem);
            changingItem.FirePriorityChanged();

            AssertNotExist(priorityList, changingItem);
            Assert.Equal(2, priorityList.Count);
        }

        [Fact]
        public void RemoveLast()
        {
            var priorityList = new PriorityList<TestItem>();
            TestItem itemToRemove;

            priorityList.Add(new TestItem(3));
            priorityList.Add(itemToRemove = new TestItem(11));
            priorityList.Add(new TestItem(2));
            priorityList.Add(new TestItem(0));
            priorityList.Add(new TestItem(6));

            priorityList.RemoveLast();
            AssertSorted(priorityList);
            AssertNotExist(priorityList, itemToRemove);
            Assert.Equal(4, priorityList.Count);
        }
    }
}
