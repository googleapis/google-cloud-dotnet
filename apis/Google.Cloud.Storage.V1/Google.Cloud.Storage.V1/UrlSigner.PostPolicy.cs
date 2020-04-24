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
using System.Collections.ObjectModel;
using System.Linq;
using System.Net;

namespace Google.Cloud.Storage.V1
{
    public sealed partial class UrlSigner
    {
        /// <summary>
        /// A standard element that can be added to a <see cref="PostPolicy"/>.
        /// </summary>
        public enum PostPolicyStandardElement
        {
            /// <summary>
            /// The ACL that you want to allow for the objects that will be uploaded.
            /// </summary>
            Acl = 0,

            /// <summary>
            /// The name of the bucket that you want to allow uploads to.
            /// Alternatively, you can include the bucket name when you add 
            /// the <see cref="PostPolicyStandardElement.Key"/> element.
            /// </summary>
            BucketName = 1,

            /// <summary>
            /// The cache control you want to allow for the objects that will be uploaded.
            /// </summary>
            CacheControl = 2,

            /// <summary>
            /// The content disposition you want to allow for the objects that will be uploaded.
            /// </summary>
            ContentDisposition = 3,

            /// <summary>
            /// The content encoding you want to allow for the objects that will be uploaded.
            /// </summary>
            ContentEncoding = 4,

            /// <summary>
            /// The content length you want to allow for the objects that will be uploaded.
            /// </summary>
            ContentLength = 5,

            /// <summary>
            /// The content type you want to allow for the objects that will be uploaded.
            /// </summary>
            ContentType = 6,

            /// <summary>
            /// The date and time you want to allow before objects that will be uploaded
            /// are considered stale by the browser.
            /// The value for this element will be included in the <see cref="PostPolicy"/>
            /// in ISO8601 basic format. When using this element for <see cref="PostPolicy.SetStartsWith(PostPolicyStandardElement, string)"/>
            /// you should specify the part of the ISO8601 basic format representation that you want
            /// values on upload to start with.
            /// </summary>
            ObjectExpiry = 7,

            /// <summary>
            /// The acceptable key name or a prefix for the uploaded objects.
            /// This element should always be present in a post policy.
            /// </summary>
            Key = 8,

            /// <summary>
            /// The allowed URL to which the client is redirected upon successful upload.
            /// </summary>
            SuccessActionRedirect = 9,

            /// <summary>
            /// The status code returned to the client upon successful upload if 
            /// <see cref="SuccessActionRedirect"/> is not specified.
            /// Allowed values are <see cref="HttpStatusCode.OK"/>, <see cref="HttpStatusCode.Created"/>,
            /// <see cref="HttpStatusCode.NoContent"/>.
            /// </summary>
            SuccessActionStatus = 10,
        }

        /// <summary>
        /// A custom element that can be added to a <see cref="PostPolicy"/>.
        /// </summary>
        public enum PostPolicyCustomElement
        {
            /// <summary>
            /// Custom element used for requiering extra Google metadata to be included
            /// in the post request. The element name you provide should start with x-goog-meta-.
            /// </summary>
            GoogleMetadata = 0,

            /// <summary>
            /// Custom element used for requiering extra fields to be included in the post request.
            /// </summary>
            Custom = 1,
        }

        /// <summary>
        /// Represents an unsigned post policy. It needs to be signed with <see cref="UrlSigner.Sign(PostPolicy, Options)"/> 
        /// before it is used to enforced policies when posting objects via form.
        /// </summary>
        public sealed class PostPolicy
        {
            private static readonly IPostPolicyElement[] s_knownElements = new IPostPolicyElement[]
            {
                Acl.Element,
                BucketName.Element,
                CacheControl.Element,
                ContentDisposition.Element,
                ContentEncoding.Element,
                ContentLength.Element,
                ContentType.Element,
                ObjectExpiry.Element,
                Key.Element,
                SuccessActionRedirect.Element,
                SuccessActionStatus.Element
            };

            private static readonly ICustomElementFactory[] s_customElementFactories = new ICustomElementFactory[]
            {
                GoogleMetadataElementFactory.Default,
                CustomElementFactory.Default
            };

            private readonly SortedDictionary<IPostPolicyElement, IPostPolicyCondition> _conditions;

            private PostPolicy()
                :this (new ElementComparer()) 
            { }

            // Only for testing purpuses. Elements in conformance tests are not sorted.
            private PostPolicy(IComparer<IPostPolicyElement> comparer) =>
                _conditions = new SortedDictionary<IPostPolicyElement, IPostPolicyCondition>(comparer);

            internal PostPolicy(PostPolicy other) =>
                _conditions = new SortedDictionary<IPostPolicyElement, IPostPolicyCondition>(
                    GaxPreconditions.CheckNotNull(other, nameof(other))._conditions, other._conditions.Comparer);

            /// <summary>
            /// Creates a new <see cref="PostPolicy"/> instance which sets the
            /// <see cref="PostPolicyStandardElement.BucketName"/> and requires
            /// an exact match for the <see cref="Key"/> element.
            /// </summary>
            /// <param name="bucketName">The exact value for the bucket name.</param>
            /// <param name="exactKeyValue">The value to match against. Must not be null.</param>
            /// <returns>A new <see cref="PostPolicy"/> instance.</returns>
            public static PostPolicy ForBucketAndKey(string bucketName, string exactKeyValue) =>
                ForBucketAndKey(bucketName, exactKeyValue, new ElementComparer());

            // Same as <see cref="FromExactKey(string)"/> but receiving a comparer for testing purposes.
            // Conformance tests are not sorted.
            internal static PostPolicy ForBucketAndKey(string bucketName, string exactKeyValue, IComparer<IPostPolicyElement> comparer)
            {
                var postPolicy = new PostPolicy(comparer);
                postPolicy.SetField(PostPolicyStandardElement.BucketName, bucketName);
                postPolicy.SetField(PostPolicyStandardElement.Key, exactKeyValue);
                return postPolicy;
            }

            /// <summary>
            /// Creates a new <see cref="PostPolicy"/> instance which sets the
            /// <see cref="PostPolicyStandardElement.BucketName"/> and requires
            /// a starts-with match for the <see cref="PostPolicyStandardElement.Key"/> element.
            /// </summary>
            /// <param name="bucketName">The exact value for the bucket name.</param>
            /// <param name="keyPrefix">The value to match against. Must not be null.</param>
            /// <returns>A new <see cref="PostPolicy"/> instance.</returns>
            public static PostPolicy ForBucketAndKeyStartsWith(string bucketName, string keyPrefix)
            {
                var postPolicy = new PostPolicy();
                postPolicy.SetField(PostPolicyStandardElement.BucketName, bucketName);
                postPolicy.SetStartsWith(PostPolicyStandardElement.Key, keyPrefix);
                return postPolicy;
            }

            /// <summary>
            /// Bucket name explicitly enforced by this policy, that is,
            /// if <see cref="SetField{TElement, TValue}(TElement, TValue)"/> has been called
            /// for <see cref="PostPolicyStandardElement.BucketName"/>.
            /// Otherwise, for instance, if the bucket name was specified as part of the
            /// <see cref="PostPolicyStandardElement.Key"/> element, this will return null.
            /// </summary>
            public string Bucket =>
                _conditions.TryGetValue(BucketName.Element, out IPostPolicyCondition condition) &&
                condition is ExactMatch<ISupportsExact<string>, string> exactMatch
                ? exactMatch.Value : null;

            /// <summary>
            /// Collection of fields as defined by this policy.
            /// Post requests enforced by this policy should set, for each
            /// pair in this sequence, the given element to the exact given value.
            /// </summary>
            public IReadOnlyDictionary<string, object> Fields =>
                new ReadOnlyDictionary<string, object>(
                    _conditions
                    .Where(pair => pair.Key != BucketName.Element)
                    .Select(pair => pair.Value)
                    .OfType<IExactMatch>()
                    .ToDictionary(cond => cond.Field.Key, cond => cond.Field.Value));

            /// <summary>
            /// Sets a required field value for <paramref name="element"/>.
            /// If any condition existed on this instance for <paramref name="element"/> it will
            /// be overriden with this required field value.
            /// </summary>
            /// <typeparam name="TValue">The type of the value to set the element to.</typeparam>
            /// <param name="element">The element for which to set a required field value.</param>
            /// <param name="value">The value to set the element to.</param>
            public void SetField<TValue>(PostPolicyStandardElement element, TValue value)
            {
                GaxPreconditions.CheckEnumValue(element, nameof(element));
                ISupportsExact<TValue> supportsExact = s_knownElements[(int)element] as ISupportsExact<TValue> ??
                    throw new ArgumentException($"Element {element} does not support field setting for values of {typeof(TValue).FullName}.");
                SetField(supportsExact, value);
            }

            /// <summary>
            /// Sets a starts-with condition for <paramref name="element"/>.
            /// If any condition existed on this instance for <paramref name="element"/> it will
            /// be overriden with this starts-with condition.
            /// </summary>
            /// <param name="element">The element for which to set an starts-with condition.</param>
            /// <param name="prefix">The prefix to validate against.</param>
            public void SetStartsWith(PostPolicyStandardElement element, string prefix)
            {
                GaxPreconditions.CheckEnumValue(element, nameof(element));
                ISupportsStartsWith supportsStartsWith = s_knownElements[(int)element] as ISupportsStartsWith ??
                    throw new ArgumentException($"Element {element} does not support the starts-with condition.");

                AddOrReplace(supportsStartsWith, new StartsWith<ISupportsStartsWith>(supportsStartsWith, prefix));
            }

            /// <summary>
            /// Sets a range condition for <paramref name="element"/>.
            /// If any condition existed on this instance for <paramref name="element"/> it will
            /// be overriden with this range condition.
            /// </summary>
            /// <typeparam name="TValue">The type of the values defining the range.</typeparam>
            /// <param name="element">The element for which to set a range condition.</param>
            /// <param name="min">The range lower bound.</param>
            /// <param name="max">The range upper bound.</param>
            public void SetRange<TValue>(PostPolicyStandardElement element, TValue min, TValue max)
                where TValue : IComparable
            {
                GaxPreconditions.CheckEnumValue(element, nameof(element));
                ISupportsRange<TValue> supportsRange = s_knownElements[(int)element] as ISupportsRange<TValue> ??
                    throw new ArgumentException($"Element {element} does not support range conditions for values of {typeof(TValue).FullName}.");

                AddOrReplace(supportsRange, new InRange<ISupportsRange<TValue>, TValue>(supportsRange, min, max));
            }

            /// <summary>
            /// Sets a required field value for <paramref name="element"/> of name <paramref name="elementName"/>.
            /// If any condition existed on this instance for <paramref name="element"/> of name <paramref name="elementName"/>
            /// it will be overriden with this required field value.
            /// </summary>
            /// <typeparam name="TValue">The type of the value to set the element to.</typeparam>
            /// <param name="element">The element for which to set a required field value.</param>
            /// <param name="elementName">The custom element name.</param>
            /// <param name="value">The value to set the element to.</param>
            /// <param name="valueToObject">The function to convert <paramref name="value"/> to the
            /// representation which with it should be included in the policy. May be null in which case
            /// <typeparamref name="TValue"/> ToString() will be used.</param>
            public void SetCustomField<TValue>(PostPolicyCustomElement element, string elementName, TValue value, Func<TValue, object> valueToObject = null)
            {
                GaxPreconditions.CheckEnumValue(element, nameof(element));

                ICustomElementFactory factory = s_customElementFactories[(int)element];

                ISupportsExact<TValue> supportsExact = factory.Create(elementName, valueToObject) as ISupportsExact<TValue> ??
                    throw new ArgumentException($"Element {element} does not support field setting for values of {typeof(TValue).FullName}.");

                SetField(supportsExact, value);
            }

            /// <summary>
            /// Sets a starts-with condition for <paramref name="element"/> of name <paramref name="elementName"/>.
            /// If any condition existed on this instance for <paramref name="element"/> of name <paramref name="elementName"/>
            /// it will be overriden with this starts-with condition.
            /// </summary>
            /// <param name="element">The element for which to set an starts-with condition.</param>
            /// <param name="elementName">The custom element name.</param>
            /// <param name="prefix">The prefix to validate against.</param>
            public void SetCustomStartsWith(PostPolicyCustomElement element, string elementName, string prefix)
            {
                GaxPreconditions.CheckEnumValue(element, nameof(element));

                ICustomElementFactory factory = s_customElementFactories[(int)element];

                // For starts-with we don't care about the value type, because we won't use it.
                ISupportsStartsWith supportsStartsWith = factory.Create<object>(elementName, null) as ISupportsStartsWith ??
                    throw new ArgumentException($"Element {element} does not support the starts-with condition.");

                AddOrReplace(supportsStartsWith, new StartsWith<ISupportsStartsWith>(supportsStartsWith, prefix));
            }

            internal void WriteTo(JsonWriter json)
            {
                json.WritePropertyName("conditions");
                json.WriteStartArray();
                foreach (var condition in _conditions.Values)
                {
                    condition.WriteTo(json);
                }
                json.WriteEndArray();
            }

            internal void SetField<TElement, TValue>(TElement element, TValue value)
                where TElement : class, ISupportsExact<TValue> =>
                AddOrReplace(element, new ExactMatch<TElement, TValue>(element, value));

            internal void AddOrReplace(IPostPolicyElement element, IPostPolicyCondition condition) =>
                _conditions[element] = GaxPreconditions.CheckNotNull(condition, nameof(condition));

            private sealed class ElementComparer : IComparer<IPostPolicyElement>
            {
                public int Compare(IPostPolicyElement x, IPostPolicyElement y) =>
                    x.ElementName.CompareTo(y.ElementName);
            }
        }
    }
}
