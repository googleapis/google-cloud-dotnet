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
// limitations under the License.

using Google.Protobuf.Collections;
using System.Collections;
using System.Collections.Generic;

namespace Google.Cloud.Vision.V1
{
    /// <summary>
    /// Wrapper for RepeatedField{T} until that implements IReadOnlyList{T}.
    /// When https://github.com/google/protobuf/issues/2041 is fixed, we can remove this class.
    /// </summary>
    /// <typeparam name="T">The element type.</typeparam>
    internal sealed class RepeatedFieldWrapper<T> : IReadOnlyList<T>
    {
        private readonly RepeatedField<T> _field;

        internal RepeatedFieldWrapper(RepeatedField<T> field)
        {
            _field = field;
        }

        public T this[int index] => _field[index];
        public int Count => _field.Count;
        public IEnumerator<T> GetEnumerator() => _field.GetEnumerator();
        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }
}
