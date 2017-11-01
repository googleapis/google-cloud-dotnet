// Copyright 2017 Google Inc. All rights reserved.
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

using Google.Api.Gax;
using Google.Protobuf;
using System.Collections.Generic;
using System.Linq;

namespace Google.Cloud.Bigtable.V2
{
    internal static class Utilities
    {
        public static ByteString Concat(this ByteString left, ByteString right)
        {
            if ((right?.Length).GetValueOrDefault(0) == 0)
            {
                return left;
            }

            if ((left?.Length).GetValueOrDefault(0) == 0)
            {
                return right;
            }

            var buffer = new byte[left.Length + right.Length];
            left.CopyTo(buffer, 0);
            right.CopyTo(buffer, left.Length);
            return ByteString.CopyFrom(buffer);
        }

        public static IEnumerable<T> ValidateCollection<T>(
            IEnumerable<T> items,
            string paramName,
            bool canBeEmpty = false)
            where T : class
        {
            if (canBeEmpty && items == null)
            {
                return Enumerable.Empty<T>();
            }

            GaxPreconditions.CheckNotNull(items, paramName);
            var result = items.Select(mutation =>
            {
                GaxPreconditions.CheckArgument(mutation != null, paramName, "Entries must not be null");
                return mutation;
            });
            return result;
        }
    }
}
