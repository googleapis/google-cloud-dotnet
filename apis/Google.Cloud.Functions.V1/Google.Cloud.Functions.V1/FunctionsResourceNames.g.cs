// Copyright 2021 Google LLC
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
using gagr = Google.Api.Gax.ResourceNames;
using gcfv = Google.Cloud.Functions.V1;
using sys = System;

namespace Google.Cloud.Functions.V1
{
    /// <summary>Resource name for the <c>CloudFunction</c> resource.</summary>
    public sealed partial class CloudFunctionName : gax::IResourceName, sys::IEquatable<CloudFunctionName>
    {
        /// <summary>The possible contents of <see cref="CloudFunctionName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern <c>projects/{project}/locations/{location}/functions/{function}</c>.
            /// </summary>
            ProjectLocationFunction = 1,
        }

        private static gax::PathTemplate s_projectLocationFunction = new gax::PathTemplate("projects/{project}/locations/{location}/functions/{function}");

        /// <summary>Creates a <see cref="CloudFunctionName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="CloudFunctionName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static CloudFunctionName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new CloudFunctionName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="CloudFunctionName"/> with the pattern
        /// <c>projects/{project}/locations/{location}/functions/{function}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="functionId">The <c>Function</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="CloudFunctionName"/> constructed from the provided ids.</returns>
        public static CloudFunctionName FromProjectLocationFunction(string projectId, string locationId, string functionId) =>
            new CloudFunctionName(ResourceNameType.ProjectLocationFunction, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), functionId: gax::GaxPreconditions.CheckNotNullOrEmpty(functionId, nameof(functionId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="CloudFunctionName"/> with pattern
        /// <c>projects/{project}/locations/{location}/functions/{function}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="functionId">The <c>Function</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="CloudFunctionName"/> with pattern
        /// <c>projects/{project}/locations/{location}/functions/{function}</c>.
        /// </returns>
        public static string Format(string projectId, string locationId, string functionId) =>
            FormatProjectLocationFunction(projectId, locationId, functionId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="CloudFunctionName"/> with pattern
        /// <c>projects/{project}/locations/{location}/functions/{function}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="functionId">The <c>Function</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="CloudFunctionName"/> with pattern
        /// <c>projects/{project}/locations/{location}/functions/{function}</c>.
        /// </returns>
        public static string FormatProjectLocationFunction(string projectId, string locationId, string functionId) =>
            s_projectLocationFunction.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(functionId, nameof(functionId)));

        /// <summary>
        /// Parses the given resource name string into a new <see cref="CloudFunctionName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/locations/{location}/functions/{function}</c></description></item>
        /// </list>
        /// </remarks>
        /// <param name="cloudFunctionName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="CloudFunctionName"/> if successful.</returns>
        public static CloudFunctionName Parse(string cloudFunctionName) => Parse(cloudFunctionName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="CloudFunctionName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/locations/{location}/functions/{function}</c></description></item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="cloudFunctionName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="CloudFunctionName"/> if successful.</returns>
        public static CloudFunctionName Parse(string cloudFunctionName, bool allowUnparsed) =>
            TryParse(cloudFunctionName, allowUnparsed, out CloudFunctionName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="CloudFunctionName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/locations/{location}/functions/{function}</c></description></item>
        /// </list>
        /// </remarks>
        /// <param name="cloudFunctionName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="CloudFunctionName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string cloudFunctionName, out CloudFunctionName result) =>
            TryParse(cloudFunctionName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="CloudFunctionName"/> instance;
        /// optionally allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/locations/{location}/functions/{function}</c></description></item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="cloudFunctionName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="CloudFunctionName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string cloudFunctionName, bool allowUnparsed, out CloudFunctionName result)
        {
            gax::GaxPreconditions.CheckNotNull(cloudFunctionName, nameof(cloudFunctionName));
            gax::TemplatedResourceName resourceName;
            if (s_projectLocationFunction.TryParseName(cloudFunctionName, out resourceName))
            {
                result = FromProjectLocationFunction(resourceName[0], resourceName[1], resourceName[2]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(cloudFunctionName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private CloudFunctionName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string functionId = null, string locationId = null, string projectId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            FunctionId = functionId;
            LocationId = locationId;
            ProjectId = projectId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="CloudFunctionName"/> class from the component parts of pattern
        /// <c>projects/{project}/locations/{location}/functions/{function}</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="functionId">The <c>Function</c> ID. Must not be <c>null</c> or empty.</param>
        public CloudFunctionName(string projectId, string locationId, string functionId) : this(ResourceNameType.ProjectLocationFunction, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), functionId: gax::GaxPreconditions.CheckNotNullOrEmpty(functionId, nameof(functionId)))
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
        /// The <c>Function</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string FunctionId { get; }

        /// <summary>
        /// The <c>Location</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string LocationId { get; }

        /// <summary>
        /// The <c>Project</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string ProjectId { get; }

        /// <summary>Whether this instance contains a resource name with a known pattern.</summary>
        public bool IsKnownPattern => Type != ResourceNameType.Unparsed;

        /// <summary>The string representation of the resource name.</summary>
        /// <returns>The string representation of the resource name.</returns>
        public override string ToString()
        {
            switch (Type)
            {
                case ResourceNameType.Unparsed: return UnparsedResource.ToString();
                case ResourceNameType.ProjectLocationFunction: return s_projectLocationFunction.Expand(ProjectId, LocationId, FunctionId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as CloudFunctionName);

        /// <inheritdoc/>
        public bool Equals(CloudFunctionName other) => ToString() == other?.ToString();

        /// <inheritdoc/>
        public static bool operator ==(CloudFunctionName a, CloudFunctionName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <inheritdoc/>
        public static bool operator !=(CloudFunctionName a, CloudFunctionName b) => !(a == b);
    }

    public partial class CloudFunction
    {
        /// <summary>
        /// <see cref="gcfv::CloudFunctionName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcfv::CloudFunctionName CloudFunctionName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcfv::CloudFunctionName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class CreateFunctionRequest
    {
        /// <summary>
        /// <see cref="gagr::LocationName"/>-typed view over the <see cref="Location"/> resource name property.
        /// </summary>
        public gagr::LocationName LocationAsLocationName
        {
            get => string.IsNullOrEmpty(Location) ? null : gagr::LocationName.Parse(Location, allowUnparsed: true);
            set => Location = value?.ToString() ?? "";
        }
    }

    public partial class GetFunctionRequest
    {
        /// <summary>
        /// <see cref="gcfv::CloudFunctionName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcfv::CloudFunctionName CloudFunctionName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcfv::CloudFunctionName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class ListFunctionsRequest
    {
        /// <summary>
        /// <see cref="gagr::LocationName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public gagr::LocationName ParentAsLocationName
        {
            get => string.IsNullOrEmpty(Parent) ? null : gagr::LocationName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class DeleteFunctionRequest
    {
        /// <summary>
        /// <see cref="gcfv::CloudFunctionName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcfv::CloudFunctionName CloudFunctionName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcfv::CloudFunctionName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class CallFunctionRequest
    {
        /// <summary>
        /// <see cref="gcfv::CloudFunctionName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcfv::CloudFunctionName CloudFunctionName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcfv::CloudFunctionName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }
}
