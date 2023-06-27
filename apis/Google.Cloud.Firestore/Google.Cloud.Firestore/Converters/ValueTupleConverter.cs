// Copyright 2019, Google LLC
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
using System.Reflection;
using System.Runtime.CompilerServices;
using BclType = System.Type;

namespace Google.Cloud.Firestore.Converters
{
    internal sealed class ValueTupleConverter : MapConverterBase
    {
        private static readonly BclType[] s_genericTupleTypes =
        {
            typeof(ValueTuple<,>),
            typeof(ValueTuple<,,>),
            typeof(ValueTuple<,,,>),
            typeof(ValueTuple<,,,,>),
            typeof(ValueTuple<,,,,,>),
            typeof(ValueTuple<,,,,,,>),
        };

        private static readonly BclType[] s_accessorTypesByArity =
        {
            null,
            typeof(TupleAccessor<>),
            typeof(TupleAccessor<,>),
            typeof(TupleAccessor<,,>),
            typeof(TupleAccessor<,,,>),
            typeof(TupleAccessor<,,,,>),
            typeof(TupleAccessor<,,,,,>),
            typeof(TupleAccessor<,,,,,,>),
        };
        private readonly IList<string> _names;
        private readonly BclType[] _elementTypes;
        private readonly BclType _accessorType;

        private ValueTupleConverter(BclType tupleType, IList<string> names)
            : base(tupleType)
        {
            _names = names;
            _elementTypes = tupleType.GetGenericArguments();
            _accessorType = s_accessorTypesByArity[_elementTypes.Length].MakeGenericType(_elementTypes);
        }

        /// <summary>
        /// Creates a converter for the given property if it is a suitable property for a value tuple conversion.
        /// </summary>
        internal static ValueTupleConverter MaybeCreateConverter(PropertyInfo property)
        {
            var attribute = property.GetCustomAttribute<TupleElementNamesAttribute>(true);
            if (attribute == null)
            {
                return null;
            }
            var names = attribute.TransformNames;
            if (names.Any(string.IsNullOrEmpty))
            {
                return null;
            }
            var propertyType = property.PropertyType;
            // If the property is actually nullable, we unwrap that and proceed with the non-nullable form.
            // Everything just works simply.
            var nonNullableType = Nullable.GetUnderlyingType(propertyType) ?? propertyType;
            if (!nonNullableType.IsConstructedGenericType)
            {
                return null;
            }
            var genericTypeDefinition = nonNullableType.GetGenericTypeDefinition();
            if (!s_genericTupleTypes.Contains(genericTypeDefinition))
            {
                return null;
            }
            return new ValueTupleConverter(nonNullableType, names);
        }

        public override object DeserializeMap(IDeserializationContext context, IDictionary<string, Value> values)
        {
            // TODO: What if the keys in the map don't match our names, or there are spare/missing ones?
            var accessor = CreateAccessor(Activator.CreateInstance(TargetType));
            for (int i = 0; i < _names.Count; i++)
            {
                if (values.TryGetValue(_names[i], out var value))
                {
                    accessor[i] = ValueDeserializer.Deserialize(context, value, _elementTypes[i]);
                }
            }
            return accessor.Value;
        }

        public override void SerializeMap(SerializationContext context, object value, IDictionary<string, Value> map)
        {
            var accessor = CreateAccessor(value);
            for (int i = 0; i < _names.Count; i++)
            {
                map[_names[i]] = ValueSerializer.Serialize(context, accessor[i]);
            }
        }

        private ITupleAccessor CreateAccessor(object obj)
        {
            ITupleAccessor accessor = (ITupleAccessor) Activator.CreateInstance(_accessorType);
            accessor.Value = obj;
            return accessor;
        }

        private interface ITupleAccessor
        {
            object this[int index] { get; set; }
            object Value { get; set; }            
        }

        // Tuple accessor implementations. These all look the same, 
        private sealed class TupleAccessor<T1> : ITupleAccessor
        {
            private ValueTuple<T1> _tuple;

            public object Value
            {
                get => _tuple;
                set => _tuple = (ValueTuple<T1>) value;
            }

            public object this[int index]
            {
                get
                {
                    switch (index)
                    {
                        case 0: return _tuple.Item1;
                        default: throw new IndexOutOfRangeException();
                    }
                }
                set
                {
                    switch (index)
                    {
                        case 0:
                            _tuple.Item1 = (T1) value;
                            return;
                        default: throw new IndexOutOfRangeException();
                    }
                }
            }
        }

        private sealed class TupleAccessor<T1, T2> : ITupleAccessor
        {
            private ValueTuple<T1, T2> _tuple;

            public object Value
            {
                get => _tuple;
                set => _tuple = (ValueTuple<T1, T2>) value;
            }

            public object this[int index]
            {
                get
                {
                    switch (index)
                    {
                        case 0: return _tuple.Item1;
                        case 1: return _tuple.Item2;
                        default: throw new IndexOutOfRangeException();
                    }
                }
                set
                {
                    switch (index)
                    {
                        case 0:
                            _tuple.Item1 = (T1) value;
                            return;
                        case 1:
                            _tuple.Item2 = (T2) value;
                            return;
                        default: throw new IndexOutOfRangeException();
                    }
                }
            }
        }

        private sealed class TupleAccessor<T1, T2, T3> : ITupleAccessor
        {
            private ValueTuple<T1, T2, T3> _tuple;

            public object Value
            {
                get => _tuple;
                set => _tuple = (ValueTuple<T1, T2, T3>) value;
            }

            public object this[int index]
            {
                get
                {
                    switch (index)
                    {
                        case 0: return _tuple.Item1;
                        case 1: return _tuple.Item2;
                        case 2: return _tuple.Item3;
                        default: throw new IndexOutOfRangeException();
                    }
                }
                set
                {
                    switch (index)
                    {
                        case 0:
                            _tuple.Item1 = (T1) value;
                            return;
                        case 1:
                            _tuple.Item2 = (T2) value;
                            return;
                        case 2:
                            _tuple.Item3 = (T3) value;
                            return;
                        default: throw new IndexOutOfRangeException();
                    }
                }
            }
        }

        private sealed class TupleAccessor<T1, T2, T3, T4> : ITupleAccessor
        {
            private ValueTuple<T1, T2, T3, T4> _tuple;

            public object Value
            {
                get => _tuple;
                set => _tuple = (ValueTuple<T1, T2, T3, T4>) value;
            }

            public object this[int index]
            {
                get
                {
                    switch (index)
                    {
                        case 0: return _tuple.Item1;
                        case 1: return _tuple.Item2;
                        case 2: return _tuple.Item3;
                        case 3: return _tuple.Item4;
                        default: throw new IndexOutOfRangeException();
                    }
                }
                set
                {
                    switch (index)
                    {
                        case 0:
                            _tuple.Item1 = (T1) value;
                            return;
                        case 1:
                            _tuple.Item2 = (T2) value;
                            return;
                        case 2:
                            _tuple.Item3 = (T3) value;
                            return;
                        case 3:
                            _tuple.Item4 = (T4) value;
                            return;
                        default: throw new IndexOutOfRangeException();
                    }
                }
            }
        }
        
        private sealed class TupleAccessor<T1, T2, T3, T4, T5> : ITupleAccessor
        {
            private ValueTuple<T1, T2, T3, T4, T5> _tuple;

            public object Value
            {
                get => _tuple;
                set => _tuple = (ValueTuple<T1, T2, T3, T4, T5>) value;
            }

            public object this[int index]
            {
                get
                {
                    switch (index)
                    {
                        case 0: return _tuple.Item1;
                        case 1: return _tuple.Item2;
                        case 2: return _tuple.Item3;
                        case 3: return _tuple.Item4;
                        case 4: return _tuple.Item5;
                        default: throw new IndexOutOfRangeException();
                    }
                }
                set
                {
                    switch (index)
                    {
                        case 0:
                            _tuple.Item1 = (T1) value;
                            return;
                        case 1:
                            _tuple.Item2 = (T2) value;
                            return;
                        case 2:
                            _tuple.Item3 = (T3) value;
                            return;
                        case 3:
                            _tuple.Item4 = (T4) value;
                            return;
                        case 4:
                            _tuple.Item5 = (T5) value;
                            return;
                        default: throw new IndexOutOfRangeException();
                    }
                }
            }
        }

        private sealed class TupleAccessor<T1, T2, T3, T4, T5, T6> : ITupleAccessor
        {
            private ValueTuple<T1, T2, T3, T4, T5, T6> _tuple;

            public object Value
            {
                get => _tuple;
                set => _tuple = (ValueTuple<T1, T2, T3, T4, T5, T6>) value;
            }

            public object this[int index]
            {
                get
                {
                    switch (index)
                    {
                        case 0: return _tuple.Item1;
                        case 1: return _tuple.Item2;
                        case 2: return _tuple.Item3;
                        case 3: return _tuple.Item4;
                        case 4: return _tuple.Item5;
                        case 5: return _tuple.Item6;
                        default: throw new IndexOutOfRangeException();
                    }
                }
                set
                {
                    switch (index)
                    {
                        case 0:
                            _tuple.Item1 = (T1) value;
                            return;
                        case 1:
                            _tuple.Item2 = (T2) value;
                            return;
                        case 2:
                            _tuple.Item3 = (T3) value;
                            return;
                        case 3:
                            _tuple.Item4 = (T4) value;
                            return;
                        case 4:
                            _tuple.Item5 = (T5) value;
                            return;
                        case 5:
                            _tuple.Item6 = (T6) value;
                            return;
                        default: throw new IndexOutOfRangeException();
                    }
                }
            }
        }


        private sealed class TupleAccessor<T1, T2, T3, T4, T5, T6, T7> : ITupleAccessor
        {
            private ValueTuple<T1, T2, T3, T4, T5, T6, T7> _tuple;

            public object Value
            {
                get => _tuple;
                set => _tuple = (ValueTuple<T1, T2, T3, T4, T5, T6, T7>) value;
            }

            public object this[int index]
            {
                get
                {
                    switch (index)
                    {
                        case 0: return _tuple.Item1;
                        case 1: return _tuple.Item2;
                        case 2: return _tuple.Item3;
                        case 3: return _tuple.Item4;
                        case 4: return _tuple.Item5;
                        case 5: return _tuple.Item6;
                        case 6: return _tuple.Item7;
                        default: throw new IndexOutOfRangeException();
                    }
                }
                set
                {
                    switch (index)
                    {
                        case 0:
                            _tuple.Item1 = (T1) value;
                            return;
                        case 1:
                            _tuple.Item2 = (T2) value;
                            return;
                        case 2:
                            _tuple.Item3 = (T3) value;
                            return;
                        case 3:
                            _tuple.Item4 = (T4) value;
                            return;
                        case 4:
                            _tuple.Item5 = (T5) value;
                            return;
                        case 5:
                            _tuple.Item6 = (T6) value;
                            return;
                        case 6:
                            _tuple.Item7 = (T7) value;
                            return;
                        default: throw new IndexOutOfRangeException();
                    }
                }
            }
        }
    }
}
