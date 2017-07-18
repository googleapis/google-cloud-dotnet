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

namespace Google.Cloud.Spanner.V1.Internal
{
    /// <summary>
    /// An item in a <see cref="PriorityList{T}"/>.
    /// </summary>
    /// <typeparam name="T">The item type; generally the same as the type implementing the interface.</typeparam>
    public interface IPriorityListItem<in T> : IComparable<T>
    {
        /// <summary>
        /// Raised when the priority of the item has changed.
        /// </summary>
        event EventHandler<EventArgs> PriorityChanged;
    }
}
