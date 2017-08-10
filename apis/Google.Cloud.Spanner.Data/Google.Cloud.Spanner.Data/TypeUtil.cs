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

using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Google.Cloud.Spanner.Data
{
    internal static class TypeUtil
    {
        public static bool DictionaryEquals(IDictionary d1, IDictionary d2)
        {
            if (d1 == null && d2 == null)
            {
                return true;
            }

            if (d1 == null || d2 == null)
            {
                return false;
            }

            return d1.Count == d2.Count
                && d1.Keys.Cast<object>().All(key => d2.Contains(key) && Equals(d2[key], d1[key]));
        }

        public static bool DictionaryEquals<TK, TV>(IDictionary<TK, TV> d1, IDictionary<TK, TV> d2)
        {
            if (d1 == null && d2 == null)
            {
                return true;
            }

            if (d1 == null || d2 == null)
            {
                return false;
            }

            return d1.Count == d2.Count
                && d1.Keys.All(key => d2.ContainsKey(key) && Equals(d2[key], d1[key]));
        }
    }
}
