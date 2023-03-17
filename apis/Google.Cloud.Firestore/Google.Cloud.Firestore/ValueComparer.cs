// Copyright 2018, Google LLC
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

using Google.Cloud.Firestore.V1;
using System;
using System.Collections.Generic;
using System.Linq;
using static Google.Cloud.Firestore.V1.Value;

namespace Google.Cloud.Firestore
{
    /// <summary>
    /// Comparison for Value protos.
    /// </summary>
    internal sealed class ValueComparer : IComparer<Value>
    {
        // Note: This order is defined by the backend and cannot be changed.
        private enum TypeOrder
        {
            Null, Boolean, Number, Timestamp, String, Blob, Ref, GeoPoint, Array, Object
        }

        internal static ValueComparer Instance { get; } = new ValueComparer();
        private static readonly Dictionary<ValueTypeOneofCase, TypeOrder> s_typeMap = new Dictionary<ValueTypeOneofCase, TypeOrder>
        {
            { ValueTypeOneofCase.NullValue, TypeOrder.Null },
            { ValueTypeOneofCase.BooleanValue, TypeOrder.Boolean },
            { ValueTypeOneofCase.IntegerValue, TypeOrder.Number },
            { ValueTypeOneofCase.DoubleValue, TypeOrder.Number },
            { ValueTypeOneofCase.TimestampValue, TypeOrder.Timestamp },
            { ValueTypeOneofCase.StringValue, TypeOrder.String },
            { ValueTypeOneofCase.BytesValue, TypeOrder.Blob },
            { ValueTypeOneofCase.ReferenceValue, TypeOrder.Ref },
            { ValueTypeOneofCase.GeoPointValue, TypeOrder.GeoPoint},
            { ValueTypeOneofCase.ArrayValue, TypeOrder.Array },
            { ValueTypeOneofCase.MapValue, TypeOrder.Object },

        };

        private TypeOrder GetType(Value value)
        {
            if (!s_typeMap.TryGetValue(value.ValueTypeCase, out var ret))
            {
                throw new ArgumentException($"Could not detect value type for {value}");
            }
            return ret;
        }

        private ValueComparer()
        {
        }

        public int Compare(Value left, Value right)
        {
            TypeOrder leftType = GetType(left);
            TypeOrder rightType = GetType(right);
            if (leftType != rightType)
            {
                return leftType.CompareTo(rightType);
            }
        
            // Values are of the same broad type, although integer/double both count as "number".
            switch (leftType)
            {
                case TypeOrder.Null:
                    return 0; // Nulls are all equal.
                case TypeOrder.Boolean:
                    return left.BooleanValue.CompareTo(right.BooleanValue);
                case TypeOrder.Number:
                    return CompareNumbers(left, right);
                case TypeOrder.Timestamp:
                    return CompareTimestamps(left, right);
                case TypeOrder.String:
                    return CompareStrings(left, right);
                case TypeOrder.Blob:
                    return CompareBlobs(left, right);
                case TypeOrder.Ref:
                    return CompareResourcePaths(left, right);
                case TypeOrder.GeoPoint:
                    return CompareGeoPoints(left, right);
                case TypeOrder.Array:
                    return CompareArrays(left, right);
                case TypeOrder.Object:
                    return CompareObjects(left, right);
                default:
                    throw new InvalidOperationException($"Unknown type {leftType}");
            }
        }

        // Note: this follows the Java ordinal comparison, but the spec says to compare by UTF-8, and to truncate at 1500 bytes.
        private int CompareStrings(Value left, Value right) => StringComparer.Ordinal.Compare(left.StringValue, right.StringValue);

        // Note: this follows the Java comparison, but the spec says we should be truncating at 1500 bytes.
        private int CompareBlobs(Value left, Value right)
        {
            var leftBytes = left.BytesValue;
            var rightBytes = right.BytesValue;
            int size = Math.Min(leftBytes.Length, rightBytes.Length);
            for (int i = 0; i < size; i++)
            {
                if (leftBytes[i] != rightBytes[i])
                {
                    return leftBytes[i].CompareTo(rightBytes[i]);
                }
            }
            return leftBytes.Length.CompareTo(rightBytes.Length);
        }

        private int CompareTimestamps(Value left, Value right)
        {
            var leftTimestamp = left.TimestampValue;
            var rightTimestamp = right.TimestampValue;
            int result = leftTimestamp.Seconds.CompareTo(rightTimestamp.Seconds);
            return result != 0 ? result : leftTimestamp.Nanos.CompareTo(rightTimestamp.Nanos);
        }

        private int CompareGeoPoints(Value left, Value right)
        {
            var leftPoint = left.GeoPointValue;
            var rightPoint = right.GeoPointValue;
            int result = leftPoint.Latitude.CompareTo(rightPoint.Latitude);
            return result != 0 ? result : leftPoint.Longitude.CompareTo(rightPoint.Longitude);
        }

        private int CompareResourcePaths(Value left, Value right) =>
            PathComparer.Instance.Compare(left.ReferenceValue, right.ReferenceValue);

        private int CompareArrays(Value left, Value right)
        {
            var leftArray = left.ArrayValue.Values;
            var rightArray = right.ArrayValue.Values;
            
            int size = Math.Min(leftArray.Count, rightArray.Count);
            for (int i = 0; i < size; i++)
            {
                int result = Compare(leftArray[i], rightArray[i]);
                if (result != 0)
                {
                    return result;
                }
            }
            return leftArray.Count.CompareTo(rightArray.Count);
        }

        private int CompareObjects(Value left, Value right)
        {
            // This requires iterating over the keys in the object in order and doing a
            // deep comparison.
            var leftEntries = left.MapValue.Fields.OrderBy(x => x.Key, StringComparer.Ordinal);
            var rightEntries = right.MapValue.Fields.OrderBy(x => x.Key, StringComparer.Ordinal);

            using (IEnumerator<KeyValuePair<string, Value>> leftIterator = leftEntries.GetEnumerator(),
                rightIterator = rightEntries.GetEnumerator())
            {
                bool leftMoveNext = leftIterator.MoveNext();
                bool rightMoveNext = rightIterator.MoveNext();
                while (leftMoveNext && rightMoveNext)
                {
                    int result = string.Compare(leftIterator.Current.Key, rightIterator.Current.Key);
                    if (result != 0)
                    {
                        return result;
                    }
                    result = Compare(leftIterator.Current.Value, rightIterator.Current.Value);
                    if (result != 0)
                    {
                        return result;
                    }
                    leftMoveNext = leftIterator.MoveNext();
                    rightMoveNext = rightIterator.MoveNext();
                }

                // Only equal if both iterators are exhausted.
                // (false.CompareTo(true) returns a negative value, which is what we want.)
                return leftMoveNext.CompareTo(rightMoveNext);
            }
        }

        private int CompareNumbers(Value left, Value right)
        {
            if (left.ValueTypeCase == ValueTypeOneofCase.DoubleValue)
            {
                if (right.ValueTypeCase == ValueTypeOneofCase.DoubleValue)
                {
                    return CompareDoubles(left.DoubleValue, right.DoubleValue);
                }
                else
                {
                    return CompareDoubles(left.DoubleValue, right.IntegerValue);
                }
            }
            else
            {
                if (right.ValueTypeCase == ValueTypeOneofCase.IntegerValue)
                {
                    return left.IntegerValue.CompareTo(right.IntegerValue);
                }
                else
                {
                    return CompareDoubles(left.IntegerValue, right.DoubleValue);
                }
            }
        }

        private int CompareDoubles(double left, double right)
        {
            // Firestore orders NaNs before all other numbers and treats -0.0, 0.0 and +0.0 as equal.
            if (double.IsNaN(left))
            {
                return double.IsNaN(right) ? 0 : -1;
            }
            if (double.IsNaN(right))
            {
                return 1;
            }
            // double.CompareTo treats positive and negative zero as equal.
            return left.CompareTo(right);
        }
    }
}
