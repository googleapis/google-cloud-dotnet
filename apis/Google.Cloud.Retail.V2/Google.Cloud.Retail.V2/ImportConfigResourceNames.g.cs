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

// Generated code. DO NOT EDIT!

using gax = Google.Api.Gax;
using gcrv = Google.Cloud.Retail.V2;
using sys = System;

namespace Google.Cloud.Retail.V2
{
    /// <summary>Resource name for the <c>Operation</c> resource.</summary>
    public sealed partial class OperationName : gax::IResourceName, sys::IEquatable<OperationName>
    {
        /// <summary>The possible contents of <see cref="OperationName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>A resource name with pattern <c>operations/{operation}</c>.</summary>
            Operation = 1,
        }

        private static gax::PathTemplate s_operation = new gax::PathTemplate("operations/{operation}");

        /// <summary>Creates a <see cref="OperationName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="OperationName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static OperationName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new OperationName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>Creates a <see cref="OperationName"/> with the pattern <c>operations/{operation}</c>.</summary>
        /// <param name="operationId">The <c>Operation</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="OperationName"/> constructed from the provided ids.</returns>
        public static OperationName FromOperation(string operationId) =>
            new OperationName(ResourceNameType.Operation, operationId: gax::GaxPreconditions.CheckNotNullOrEmpty(operationId, nameof(operationId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="OperationName"/> with pattern
        /// <c>operations/{operation}</c>.
        /// </summary>
        /// <param name="operationId">The <c>Operation</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="OperationName"/> with pattern <c>operations/{operation}</c>.
        /// </returns>
        public static string Format(string operationId) => FormatOperation(operationId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="OperationName"/> with pattern
        /// <c>operations/{operation}</c>.
        /// </summary>
        /// <param name="operationId">The <c>Operation</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="OperationName"/> with pattern <c>operations/{operation}</c>.
        /// </returns>
        public static string FormatOperation(string operationId) =>
            s_operation.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(operationId, nameof(operationId)));

        /// <summary>Parses the given resource name string into a new <see cref="OperationName"/> instance.</summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet"><item><description><c>operations/{operation}</c></description></item></list>
        /// </remarks>
        /// <param name="operationName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="OperationName"/> if successful.</returns>
        public static OperationName Parse(string operationName) => Parse(operationName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="OperationName"/> instance; optionally allowing
        /// an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet"><item><description><c>operations/{operation}</c></description></item></list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="operationName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="OperationName"/> if successful.</returns>
        public static OperationName Parse(string operationName, bool allowUnparsed) =>
            TryParse(operationName, allowUnparsed, out OperationName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="OperationName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet"><item><description><c>operations/{operation}</c></description></item></list>
        /// </remarks>
        /// <param name="operationName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="OperationName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string operationName, out OperationName result) => TryParse(operationName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="OperationName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet"><item><description><c>operations/{operation}</c></description></item></list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="operationName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="OperationName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string operationName, bool allowUnparsed, out OperationName result)
        {
            gax::GaxPreconditions.CheckNotNull(operationName, nameof(operationName));
            gax::TemplatedResourceName resourceName;
            if (s_operation.TryParseName(operationName, out resourceName))
            {
                result = FromOperation(resourceName[0]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(operationName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private OperationName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string operationId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            OperationId = operationId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="OperationName"/> class from the component parts of pattern
        /// <c>operations/{operation}</c>
        /// </summary>
        /// <param name="operationId">The <c>Operation</c> ID. Must not be <c>null</c> or empty.</param>
        public OperationName(string operationId) : this(ResourceNameType.Operation, operationId: gax::GaxPreconditions.CheckNotNullOrEmpty(operationId, nameof(operationId)))
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
        /// The <c>Operation</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string OperationId { get; }

        /// <summary>Whether this instance contains a resource name with a known pattern.</summary>
        public bool IsKnownPattern => Type != ResourceNameType.Unparsed;

        /// <summary>The string representation of the resource name.</summary>
        /// <returns>The string representation of the resource name.</returns>
        public override string ToString()
        {
            switch (Type)
            {
                case ResourceNameType.Unparsed: return UnparsedResource.ToString();
                case ResourceNameType.Operation: return s_operation.Expand(OperationId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as OperationName);

        /// <inheritdoc/>
        public bool Equals(OperationName other) => ToString() == other?.ToString();

        /// <inheritdoc/>
        public static bool operator ==(OperationName a, OperationName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <inheritdoc/>
        public static bool operator !=(OperationName a, OperationName b) => !(a == b);
    }

    public partial class ImportMetadata
    {
        /// <summary>
        /// <see cref="gcrv::OperationName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcrv::OperationName OperationName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcrv::OperationName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }
}
