// Copyright 2025 Google LLC
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

// Generated code. DO NOT EDIT!

#pragma warning disable CS8981
using gax = Google.Api.Gax;
using gcav = Google.Cloud.AIPlatform.V1Beta1;
using sys = System;

namespace Google.Cloud.AIPlatform.V1Beta1
{
    /// <summary>Resource name for the <c>PublisherModel</c> resource.</summary>
    public sealed partial class PublisherModelName : gax::IResourceName, sys::IEquatable<PublisherModelName>
    {
        /// <summary>The possible contents of <see cref="PublisherModelName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>A resource name with pattern <c>publishers/{publisher}/models/{model}</c>.</summary>
            PublisherModel = 1,
        }

        private static gax::PathTemplate s_publisherModel = new gax::PathTemplate("publishers/{publisher}/models/{model}");

        /// <summary>Creates a <see cref="PublisherModelName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="PublisherModelName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static PublisherModelName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new PublisherModelName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="PublisherModelName"/> with the pattern <c>publishers/{publisher}/models/{model}</c>.
        /// </summary>
        /// <param name="publisherId">The <c>Publisher</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="modelId">The <c>Model</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="PublisherModelName"/> constructed from the provided ids.</returns>
        public static PublisherModelName FromPublisherModel(string publisherId, string modelId) =>
            new PublisherModelName(ResourceNameType.PublisherModel, publisherId: gax::GaxPreconditions.CheckNotNullOrEmpty(publisherId, nameof(publisherId)), modelId: gax::GaxPreconditions.CheckNotNullOrEmpty(modelId, nameof(modelId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="PublisherModelName"/> with pattern
        /// <c>publishers/{publisher}/models/{model}</c>.
        /// </summary>
        /// <param name="publisherId">The <c>Publisher</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="modelId">The <c>Model</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="PublisherModelName"/> with pattern
        /// <c>publishers/{publisher}/models/{model}</c>.
        /// </returns>
        public static string Format(string publisherId, string modelId) => FormatPublisherModel(publisherId, modelId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="PublisherModelName"/> with pattern
        /// <c>publishers/{publisher}/models/{model}</c>.
        /// </summary>
        /// <param name="publisherId">The <c>Publisher</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="modelId">The <c>Model</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="PublisherModelName"/> with pattern
        /// <c>publishers/{publisher}/models/{model}</c>.
        /// </returns>
        public static string FormatPublisherModel(string publisherId, string modelId) =>
            s_publisherModel.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(publisherId, nameof(publisherId)), gax::GaxPreconditions.CheckNotNullOrEmpty(modelId, nameof(modelId)));

        /// <summary>
        /// Parses the given resource name string into a new <see cref="PublisherModelName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>publishers/{publisher}/models/{model}</c></description></item>
        /// </list>
        /// </remarks>
        /// <param name="publisherModelName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="PublisherModelName"/> if successful.</returns>
        public static PublisherModelName Parse(string publisherModelName) => Parse(publisherModelName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="PublisherModelName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>publishers/{publisher}/models/{model}</c></description></item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="publisherModelName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="PublisherModelName"/> if successful.</returns>
        public static PublisherModelName Parse(string publisherModelName, bool allowUnparsed) =>
            TryParse(publisherModelName, allowUnparsed, out PublisherModelName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="PublisherModelName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>publishers/{publisher}/models/{model}</c></description></item>
        /// </list>
        /// </remarks>
        /// <param name="publisherModelName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="PublisherModelName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string publisherModelName, out PublisherModelName result) =>
            TryParse(publisherModelName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="PublisherModelName"/> instance;
        /// optionally allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>publishers/{publisher}/models/{model}</c></description></item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="publisherModelName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="PublisherModelName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string publisherModelName, bool allowUnparsed, out PublisherModelName result)
        {
            gax::GaxPreconditions.CheckNotNull(publisherModelName, nameof(publisherModelName));
            gax::TemplatedResourceName resourceName;
            if (s_publisherModel.TryParseName(publisherModelName, out resourceName))
            {
                result = FromPublisherModel(resourceName[0], resourceName[1]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(publisherModelName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private PublisherModelName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string modelId = null, string publisherId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            ModelId = modelId;
            PublisherId = publisherId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="PublisherModelName"/> class from the component parts of pattern
        /// <c>publishers/{publisher}/models/{model}</c>
        /// </summary>
        /// <param name="publisherId">The <c>Publisher</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="modelId">The <c>Model</c> ID. Must not be <c>null</c> or empty.</param>
        public PublisherModelName(string publisherId, string modelId) : this(ResourceNameType.PublisherModel, publisherId: gax::GaxPreconditions.CheckNotNullOrEmpty(publisherId, nameof(publisherId)), modelId: gax::GaxPreconditions.CheckNotNullOrEmpty(modelId, nameof(modelId)))
        {
        }

        /// <summary>The <see cref="ResourceNameType"/> of the contained resource name.</summary>
        public ResourceNameType Type { get; }

        /// <summary>
        /// The contained <see cref="gax::UnparsedResourceName"/>. Only non-<c>null</c> if this instance contains an
        /// unparsed resource name.
        /// </summary>
        public gax::UnparsedResourceName UnparsedResource { get; }

        /// <summary>
        /// The <c>Model</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string ModelId { get; }

        /// <summary>
        /// The <c>Publisher</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string PublisherId { get; }

        /// <summary>Whether this instance contains a resource name with a known pattern.</summary>
        public bool IsKnownPattern => Type != ResourceNameType.Unparsed;

        /// <summary>The string representation of the resource name.</summary>
        /// <returns>The string representation of the resource name.</returns>
        public override string ToString()
        {
            switch (Type)
            {
                case ResourceNameType.Unparsed: return UnparsedResource.ToString();
                case ResourceNameType.PublisherModel: return s_publisherModel.Expand(PublisherId, ModelId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as PublisherModelName);

        /// <inheritdoc/>
        public bool Equals(PublisherModelName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(PublisherModelName a, PublisherModelName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(PublisherModelName a, PublisherModelName b) => !(a == b);
    }

    public partial class PublisherModel
    {
        /// <summary>
        /// <see cref="gcav::PublisherModelName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcav::PublisherModelName PublisherModelName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcav::PublisherModelName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }
}
