// Copyright 2020 Google LLC
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

using Google.Api.Gax;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace Google.Cloud.Storage.V1
{
    public sealed partial class UrlSigner
    {
        /// <summary>
        /// Represents a matching condition that is used to include
        /// <see cref="IPostPolicyElement"/> in a <see cref="PostPolicy"/>.
        /// </summary>
        internal interface IPostPolicyCondition
        {
            /// <summary>
            /// Writes this condition to the given <see cref="JsonWriter"/>.
            /// </summary>
            void WriteTo(JsonWriter json);
        }

        internal interface IExactMatch : IPostPolicyCondition
        {
            /// <summary>
            /// The element name / value pair that this condition defines.
            /// </summary>
            KeyValuePair<string, object> Field { get; }
        }

        /// <summary>
        /// Represents the exact match condition for <see cref="IPostPolicyElement"/>
        /// included in a <see cref="PostPolicy"/>.
        /// </summary>
        /// <typeparam name="TElement">The type of the element this condition acts upon.</typeparam>
        /// <typeparam name="TValue">The type of the values allowed by <see cref="IPostPolicyElement"/>.</typeparam>
        internal sealed class ExactMatch<TElement, TValue> : IExactMatch
            where TElement : class, ISupportsExact<TValue>
        {
            internal ExactMatch(TElement element, TValue value)
            {
                Element = GaxPreconditions.CheckNotNull(element, nameof(element));
                Value = value;
            }

            /// <summary>
            /// The element this condition applies to.
            /// </summary>
            public TElement Element { get; }

            /// <inheritdoc/>
            public KeyValuePair<string, object> Field => 
                new KeyValuePair<string, object>(Element.ElementName, Element.ToPostPolicyValue(Value));

            /// <summary>
            /// The exact value to match.
            /// </summary>
            public TValue Value { get; }

            /// <inheritdoc/>
            void IPostPolicyCondition.WriteTo(JsonWriter json)
            {
                var field = Field;

                json.WriteStartObject();
                json.WritePropertyName(field.Key);
                json.WriteValue(field.Value);
                json.WriteEndObject();
            }
        }

        /// <summary>
        /// Represents the starts with condition for <see cref="IPostPolicyElement"/>
        /// included in a <see cref="PostPolicy"/>.
        /// <typeparam name="TElement">The type of the element this condition acts upon.</typeparam>
        /// </summary>
        internal sealed class StartsWith<TElement> : IPostPolicyCondition
            where TElement : class, ISupportsStartsWith
        {
            internal StartsWith(TElement element, string prefix)
            {
                Element = GaxPreconditions.CheckNotNull(element, nameof(element));
                Prefix = GaxPreconditions.CheckNotNull(prefix, nameof(prefix));
            }

            /// <summary>
            /// The element this condition applies to.
            /// </summary>
            public TElement Element { get; }

            /// <summary>
            /// The prefix to match against.
            /// </summary>
            public string Prefix { get; }

            /// <inheritdoc/>
            void IPostPolicyCondition.WriteTo(JsonWriter json)
            {
                json.WriteStartArray();
                json.WriteValue("starts-with");
                json.WriteValue("$"+Element.ElementName);
                json.WriteValue(Prefix);
                json.WriteEndArray();
            }
        }

        /// <summary>
        /// Represents the range condition for <see cref="IPostPolicyElement"/>
        /// included in a <see cref="PostPolicy"/>.
        /// </summary>
        /// <typeparam name="TElement">The type of the element this condition acts upon.</typeparam>
        /// <typeparam name="TValue">
        /// The type of the values allowed by <see cref="IPostPolicyElement"/>.</typeparam>
        internal sealed class InRange<TElement, TValue> : IPostPolicyCondition
            where TElement : class, ISupportsRange<TValue>
            where TValue : IComparable
        {
            internal InRange(TElement element, TValue min, TValue max)
            {
                Element = GaxPreconditions.CheckNotNull(element, nameof(element));
                Min = min;
                Max = max;
            }

            /// <summary>
            /// The element this condition applies to.
            /// </summary>
            public TElement Element { get; }

            /// <summary>
            /// The min range value.
            /// </summary>
            public TValue Min { get; }

            /// <summary>
            /// The max range value.
            /// </summary>
            public TValue Max { get; }

            void IPostPolicyCondition.WriteTo(JsonWriter json)
            {
                json.WriteStartArrayAsync();
                json.WriteValueAsync($"{Element.ElementName}-range");
                json.WriteValueAsync(Element.ToPostPolicyValue(Min));
                json.WriteValueAsync(Element.ToPostPolicyValue(Max));
                json.WriteEndArrayAsync();
            }
        }
    }
}
