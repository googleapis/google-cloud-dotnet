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
using System;
using System.Globalization;
using System.Net;

namespace Google.Cloud.Storage.V1
{
    public sealed partial class UrlSigner
    {
        /// <summary>
        /// Represents an element that can be included on a <see cref="PostPolicy"/>.
        /// </summary>
        internal interface IPostPolicyElement
        {
            /// <summary>
            /// The name with which the element is included on a <see cref="PostPolicy"/>.
            /// </summary>
            string ElementName { get; }
        }

        /// <summary>
        /// Represents a <see cref="IPostPolicyElement"/> that supports the exact match condition operation.
        /// </summary>
        internal interface ISupportsExact<TValue> : IPostPolicyElement
        {
            /// <summary>
            /// A way to convert the values of <typeparamref name="TValue"/> to
            /// the representation with which to include them on the <see cref="PostPolicy"/>.
            /// </summary>
            /// <param name="value">The value for which to return the corresponding representation.</param>
            /// <returns>The representation of the given value.</returns>
            object ToPostPolicyValue(TValue value);
        }

        /// <summary>
        /// Represents a <see cref="IPostPolicyElement"/> that supports the range match condition operation.
        /// </summary>
        internal interface ISupportsRange<TValue> : IPostPolicyElement
            where TValue : IComparable
        {
            /// <summary>
            /// A way to convert the values of <typeparamref name="TValue"/> to
            /// the representation with which to include them on the <see cref="PostPolicy"/>.
            /// </summary>
            /// <param name="value">The value for which to return the corresponding representation.</param>
            /// <returns>The representation of the given value.</returns>
            object ToPostPolicyValue(TValue value);
        }

        /// <summary>
        /// Represents a <see cref="IPostPolicyElement"/> that supports the starts with condition operation.
        /// </summary>
        internal interface ISupportsStartsWith : IPostPolicyElement { }

        /// <summary>
        /// The ACL that you want to allow for the objects that will be uploaded.
        /// </summary>
        internal sealed class Acl : ISupportsExact<string>, ISupportsStartsWith
        {
            /// <summary>
            /// The default acl element.
            /// </summary>
            public static Acl Element { get; } = new Acl();

            internal Acl() { }

            /// <inheritdoc/>
            string IPostPolicyElement.ElementName => "acl";

            /// <inheritdoc/>
            object ISupportsExact<string>.ToPostPolicyValue(string value) => value;
        }

        /// <summary>
        /// The name of the bucket that you want to allow uploads to.
        /// Alternatively, you can include the bucket name in the <see cref="Key"/> element.
        /// </summary>
        internal sealed class BucketName : ISupportsExact<string>
        {
            /// <summary>
            /// The default bucket element.
            /// </summary>
            public static BucketName Element { get; } = new BucketName();

            internal BucketName() { }

            /// <inheritdoc/>
            string IPostPolicyElement.ElementName => "bucket";

            /// <inheritdoc/>
            object ISupportsExact<string>.ToPostPolicyValue(string value) => value;
        }

        /// <summary>
        /// The cache control you want to allow for the objects that will be uploaded.
        /// </summary>
        internal sealed class CacheControl : ISupportsExact<string>, ISupportsStartsWith
        {
            /// <summary>
            /// The default cache-control element.
            /// </summary>
            public static CacheControl Element { get; } = new CacheControl();

            internal CacheControl() { }

            /// <inheritdoc/>
            string IPostPolicyElement.ElementName => "cache-control";

            /// <inheritdoc/>
            object ISupportsExact<string>.ToPostPolicyValue(string value) => value;
        }

        /// <summary>
        /// The content disposition you want to allow for the objects that will be uploaded.
        /// </summary>
        internal sealed class ContentDisposition : ISupportsExact<string>, ISupportsStartsWith
        {
            /// <summary>
            /// The default content-disposition element.
            /// </summary>
            public static ContentDisposition Element { get; } = new ContentDisposition();

            internal ContentDisposition() { }

            /// <inheritdoc/>
            string IPostPolicyElement.ElementName => "content-disposition";

            /// <inheritdoc/>
            object ISupportsExact<string>.ToPostPolicyValue(string value) => value;
        }

        /// <summary>
        /// The content encoding you want to allow for the objects that will be uploaded.
        /// </summary>
        internal sealed class ContentEncoding : ISupportsExact<string>, ISupportsStartsWith
        {
            /// <summary>
            /// The default content-encoding element.
            /// </summary>
            public static ContentEncoding Element { get; } = new ContentEncoding();

            internal ContentEncoding() { }

            /// <inheritdoc/>
            string IPostPolicyElement.ElementName => "content-encoding";

            /// <inheritdoc/>
            object ISupportsExact<string>.ToPostPolicyValue(string value) => value;
        }

        /// <summary>
        /// The content length you want to allow for the objects that will be uploaded.
        /// </summary>
        internal sealed class ContentLength : ISupportsRange<long>, ISupportsRange<int>
        {
            /// <summary>
            /// The default content-length element.
            /// </summary>
            public static ContentLength Element { get; } = new ContentLength();

            internal ContentLength() { }

            /// <inheritdoc/>
            string IPostPolicyElement.ElementName => "content-length";

            /// <inheritdoc/>
            object ISupportsRange<long>.ToPostPolicyValue(long value) => value;

            /// <inheritdoc/>
            object ISupportsRange<int>.ToPostPolicyValue(int value) => value;
        }

        /// <summary>
        /// The content type you want to allow for the objects that will be uploaded.
        /// </summary>
        internal sealed class ContentType : ISupportsExact<string>, ISupportsStartsWith
        {
            /// <summary>
            /// The default content-type element.
            /// </summary>
            public static ContentType Element { get; } = new ContentType();

            internal ContentType() { }

            /// <inheritdoc/>
            string IPostPolicyElement.ElementName => "content-type";

            /// <inheritdoc/>
            object ISupportsExact<string>.ToPostPolicyValue(string value) => value;
        }

        /// <summary>
        /// The date and time you want to allow before objects that will be uploaded
        /// are considered stale by the browser.
        /// The value for this element will be included in the <see cref="PostPolicy"/>
        /// in ISO8601 basic format. When using this element as a <see cref="ISupportsStartsWith"/>
        /// you should specify the part of the ISO8601 basic format representation that you want
        /// values on upload to start with.
        /// </summary>
        internal sealed class ObjectExpiry : ISupportsExact<DateTimeOffset>, ISupportsStartsWith
        {
            /// <summary>
            /// The default expires element.
            /// </summary>
            public static ObjectExpiry Element { get; } = new ObjectExpiry();

            internal ObjectExpiry() { }

            /// <inheritdoc/>
            string IPostPolicyElement.ElementName => "expires";

            /// <inheritdoc/>
            object ISupportsExact<DateTimeOffset>.ToPostPolicyValue(DateTimeOffset value) =>
                value.ToUniversalTime().ToString("yyyyMMdd'T'HHmmss'Z'", CultureInfo.InvariantCulture);
        }

        /// <summary>
        /// The acceptable key name or a prefix for the uploaded objects.
        /// This element should always be present in a post policy.
        /// </summary>
        internal sealed class Key : ISupportsExact<string>, ISupportsStartsWith
        {
            /// <summary>
            /// The default key element.
            /// </summary>
            public static Key Element { get; } = new Key();

            internal Key() { }

            /// <inheritdoc/>
            string IPostPolicyElement.ElementName => "key";

            /// <inheritdoc/>
            object ISupportsExact<string>.ToPostPolicyValue(string value) => value;
        }

        /// <summary>
        /// The allowed URL to which the client is redirected upon successful upload.
        /// </summary>
        internal sealed class SuccessActionRedirect : ISupportsExact<Uri>, ISupportsExact<string>, ISupportsStartsWith
        {
            /// <summary>
            /// The default success-action-redirect element.
            /// </summary>
            public static SuccessActionRedirect Element { get; } = new SuccessActionRedirect();

            internal SuccessActionRedirect() { }

            /// <inheritdoc/>
            string IPostPolicyElement.ElementName => "success_action_redirect";

            /// <inheritdoc/>
            object ISupportsExact<Uri>.ToPostPolicyValue(Uri value) => value.ToString();

            /// <inheritdoc/>
            object ISupportsExact<string>.ToPostPolicyValue(string value) => value;
        }

        /// <summary>
        /// The status code returned to the client upon successful upload if 
        /// <see cref="SuccessActionRedirect"/> is not specified.
        /// Allowed values are 200, 201 and 204.
        /// </summary>
        internal sealed class SuccessActionStatus : ISupportsExact<HttpStatusCode>
        {
            /// <summary>
            /// The default success-action-status element.
            /// </summary>
            public static SuccessActionStatus Element { get; } = new SuccessActionStatus();

            internal SuccessActionStatus() { }

            /// <inheritdoc/>
            string IPostPolicyElement.ElementName => "success_action_status";

            /// <inheritdoc/>
            object ISupportsExact<HttpStatusCode>.ToPostPolicyValue(HttpStatusCode value) =>
                ((int)value).ToString();
        }

        /// <summary>
        /// Custom element used for requiering extra Google metadata to be included
        /// in the post request.
        /// </summary>
        /// <typeparam name="TValue">The type for the values of the element.</typeparam>
        internal sealed class GoogleMetadata<TValue> : ISupportsExact<TValue>, ISupportsStartsWith
        {
            private const string s_elementPrefix = "x-goog-meta-";

            private readonly Func<TValue, object> _valueToObjectFunc;
            private readonly string _elementName;

            /// <summary>
            /// Creates a new element with the given name.
            /// </summary>
            /// <param name="name">The name for this element that must start with x-goog-meta-. Must not be null.</param>
            /// <param name="valueToObjectFunc">The function to use to convert <typeparamref name="TValue"/> values
            /// to the representation with which they will be included in a <see cref="PostPolicy"/>.
            /// May be null in which case <typeparamref name="TValue"/> ToString() will be used.</param>
            internal GoogleMetadata(string name, Func<TValue, object> valueToObjectFunc = null)
            {
                _elementName = GaxPreconditions.CheckNotNull(name, nameof(name)).ToLowerInvariant();
                GaxPreconditions.CheckArgument(
                    _elementName.StartsWith(s_elementPrefix, StringComparison.OrdinalIgnoreCase),
                    nameof(name),
                    $"The element name should be prefixed with {s_elementPrefix}.");
                _valueToObjectFunc = valueToObjectFunc ?? (value => value.ToString());
            }

            /// <inheritdoc/>
            string IPostPolicyElement.ElementName => _elementName;

            /// <inheritdoc/>
            object ISupportsExact<TValue>.ToPostPolicyValue(TValue value) =>
                _valueToObjectFunc(value);

            /// <inheritdoc/>
            public override bool Equals(object obj) =>
                obj is GoogleMetadata<TValue> other && _elementName.Equals(other._elementName);

            /// <inheritdoc/>
            public override int GetHashCode() => _elementName.GetHashCode();
        }

        internal sealed class GoogleMetadataElementFactory : ICustomElementFactory
        {
            /// <summary>
            /// The default x-goog-meta- element factory.
            /// </summary>
            public static ICustomElementFactory Default { get; } = new GoogleMetadataElementFactory();

            private GoogleMetadataElementFactory() { }

            public IPostPolicyElement Create<T>(string name, Func<T, object> valueToObject) =>
                new GoogleMetadata<T>(name, valueToObject);
        }

        /// <summary>
        /// Custom element used for requiering extra fields to be included in the post request.
        /// </summary>
        /// <typeparam name="TValue">The type for the values of the element.</typeparam>
        internal sealed class CustomElement<TValue> : ISupportsExact<TValue>
        {
            private readonly Func<TValue, object> _valueToObjectFunc;
            private readonly string _elementName;

            /// <summary>
            /// Creates a new element with the given name.
            /// </summary>
            /// <param name="name">The name for this element. It will be lowercased
            /// to obtain the element name.</param>
            /// <param name="valueToObjectFunc">The function to use to convert <typeparamref name="TValue"/> values
            /// to the representation with which they'll be included in a <see cref="PostPolicy"/>.
            /// May be null in wich case <typeparamref name="TValue"/> ToString() will be used.</param>
            internal CustomElement(string name, Func<TValue, object> valueToObjectFunc = null)
            {
                _elementName = GaxPreconditions.CheckNotNull(name, nameof(name)).ToLowerInvariant();
                _valueToObjectFunc = valueToObjectFunc ?? (value => value.ToString());
            }

            /// <inheritdoc/>
            string IPostPolicyElement.ElementName => _elementName;

            /// <inheritdoc/>
            object ISupportsExact<TValue>.ToPostPolicyValue(TValue value) =>
                _valueToObjectFunc(value);

            /// <inheritdoc/>
            public override bool Equals(object obj) =>
                obj is CustomElement<TValue> other && _elementName.Equals(other._elementName);

            /// <inheritdoc/>
            public override int GetHashCode() => _elementName.GetHashCode();
        }


        internal sealed class CustomElementFactory : ICustomElementFactory
        {
            /// <summary>
            /// The default custom element factory.
            /// </summary>
            public static ICustomElementFactory Default { get; } = new CustomElementFactory();

            private CustomElementFactory() { }

            public IPostPolicyElement Create<T>(string name, Func<T, object> valueToObject) =>
                new CustomElement<T>(name, valueToObject);
        }

        internal sealed class PolicyAlgorithm : ISupportsExact<string>
        {
            /// <summary>
            /// The default x-goog-algorithm element.
            /// </summary>
            public static PolicyAlgorithm Element { get; } = new PolicyAlgorithm();

            internal PolicyAlgorithm() { }

            /// <inheritdoc/>
            string IPostPolicyElement.ElementName => "x-goog-algorithm";

            /// <inheritdoc/>
            object ISupportsExact<string>.ToPostPolicyValue(string value) => value;
        }

        internal sealed class PolicyCredential : ISupportsExact<string>
        {
            /// <summary>
            /// The default x-goog-credential element.
            /// </summary>
            public static PolicyCredential Element { get; } = new PolicyCredential();

            internal PolicyCredential() { }

            /// <inheritdoc/>
            string IPostPolicyElement.ElementName => "x-goog-credential";

            /// <inheritdoc/>
            object ISupportsExact<string>.ToPostPolicyValue(string value) => value;
        }

        internal sealed class PolicyCreationDateTime : ISupportsExact<DateTimeOffset>
        {
            /// <summary>
            /// The default x-goog-date element.
            /// </summary>
            public static PolicyCreationDateTime Element { get; } = new PolicyCreationDateTime();

            internal PolicyCreationDateTime() { }

            /// <inheritdoc/>
            string IPostPolicyElement.ElementName => "x-goog-date";

            /// <inheritdoc/>
            object ISupportsExact<DateTimeOffset>.ToPostPolicyValue(DateTimeOffset value) =>
                value.ToUniversalTime().ToString("yyyyMMdd'T'HHmmss'Z'", CultureInfo.InvariantCulture);
        }

        internal interface ICustomElementFactory
        {
            IPostPolicyElement Create<T>(string name, Func<T, object> valueToObject);
        }
    }
}
