using System;
using System.IO;
using System.Linq;
using Google.Protobuf.WellKnownTypes;

namespace Google.Cloud.Spanner.V1
{
    internal static class ValueChunking
    {
        /*
         * It is possible that the last value in values is "chunked", meaning that the rest of the value is sent
         *  in subsequent PartialResultSet(s). This is denoted by the chunked_value field. Two or more chunked
         *  values can be merged to form a complete value as follows:
         *  
         *  bool/number/null: cannot be chunked
         *  string: concatenate the strings
         *  list: concatenate the lists. If the last element in a list is a string, list, or object, merge it
         *   with the first element in the next list by applying these rules recursively.
         *  object: concatenate the (field name, field value) pairs. If a field name is duplicated, then apply
         *   these rules recursively to merge the field values.
         */
        public static void ChunkedMerge(this Value thisValue, Value other)
        {
            switch (thisValue.KindCase)
            {
                case Value.KindOneofCase.StringValue:
                    //simple concat
                    thisValue.StringValue = thisValue.StringValue + other.StringValue;
                    break;
                case Value.KindOneofCase.StructValue:
                    foreach (var fieldValue in other.StructValue.Fields)
                    {
                        Value thisChildField;
                        if (thisValue.StructValue.Fields.TryGetValue(fieldValue.Key, out thisChildField))
                        {
                            //merge duplicated keys
                            thisChildField.ChunkedMerge(fieldValue.Value);
                        }
                        else
                        {
                            thisValue.StructValue.Fields[fieldValue.Key] = fieldValue.Value;
                        }
                    }
                    break;
                case Value.KindOneofCase.ListValue:
                    // As stated above, when merging a ListValue, we examine the last item in the list.
                    // If that item is mergable, we then merge that item with the first item in the other list.
                    var childItemValue = thisValue.ListValue.Values.LastOrDefault();
                    int iterator = 0;
                    if (childItemValue.IsMergable())
                    {
                        childItemValue.ChunkedMerge(other.ListValue.Values.First());
                        iterator++;
                    }
                    for (; iterator < other.ListValue.Values.Count; iterator++)
                    {
                        thisValue.ListValue.Values.Add(other.ListValue.Values[iterator]);
                    }
                    break;
                default:
                    throw new IOException($"The value of type {thisValue.KindCase} cannot be merged as a chunk.");
            }
        }

        public static bool IsMergable(this Value thisValue)
        {
            if (thisValue == null)
            {
                return false;
            }
            switch (thisValue.KindCase)
            {
                case Value.KindOneofCase.StringValue:
                case Value.KindOneofCase.StructValue:
                case Value.KindOneofCase.ListValue:
                    return true;
                default:
                    return false;
            }
        }
    }
}
