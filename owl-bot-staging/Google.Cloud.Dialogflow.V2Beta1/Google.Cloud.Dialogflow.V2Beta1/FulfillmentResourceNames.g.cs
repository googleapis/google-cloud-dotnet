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
using gcdv = Google.Cloud.Dialogflow.V2Beta1;
using sys = System;

namespace Google.Cloud.Dialogflow.V2Beta1
{
    /// <summary>Resource name for the <c>Fulfillment</c> resource.</summary>
    public sealed partial class FulfillmentName : gax::IResourceName, sys::IEquatable<FulfillmentName>
    {
        /// <summary>The possible contents of <see cref="FulfillmentName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>A resource name with pattern <c>projects/{project}/agent/fulfillment</c>.</summary>
            Project = 1,

            /// <summary>
            /// A resource name with pattern <c>projects/{project}/locations/{location}/agent/fulfillment</c>.
            /// </summary>
            ProjectLocation = 2,
        }

        private static gax::PathTemplate s_project = new gax::PathTemplate("projects/{project}/agent/fulfillment");

        private static gax::PathTemplate s_projectLocation = new gax::PathTemplate("projects/{project}/locations/{location}/agent/fulfillment");

        /// <summary>Creates a <see cref="FulfillmentName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="FulfillmentName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static FulfillmentName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new FulfillmentName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="FulfillmentName"/> with the pattern <c>projects/{project}/agent/fulfillment</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="FulfillmentName"/> constructed from the provided ids.</returns>
        public static FulfillmentName FromProject(string projectId) =>
            new FulfillmentName(ResourceNameType.Project, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)));

        /// <summary>
        /// Creates a <see cref="FulfillmentName"/> with the pattern
        /// <c>projects/{project}/locations/{location}/agent/fulfillment</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="FulfillmentName"/> constructed from the provided ids.</returns>
        public static FulfillmentName FromProjectLocation(string projectId, string locationId) =>
            new FulfillmentName(ResourceNameType.ProjectLocation, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="FulfillmentName"/> with pattern
        /// <c>projects/{project}/agent/fulfillment</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="FulfillmentName"/> with pattern
        /// <c>projects/{project}/agent/fulfillment</c>.
        /// </returns>
        public static string Format(string projectId) => FormatProject(projectId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="FulfillmentName"/> with pattern
        /// <c>projects/{project}/agent/fulfillment</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="FulfillmentName"/> with pattern
        /// <c>projects/{project}/agent/fulfillment</c>.
        /// </returns>
        public static string FormatProject(string projectId) =>
            s_project.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="FulfillmentName"/> with pattern
        /// <c>projects/{project}/locations/{location}/agent/fulfillment</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="FulfillmentName"/> with pattern
        /// <c>projects/{project}/locations/{location}/agent/fulfillment</c>.
        /// </returns>
        public static string FormatProjectLocation(string projectId, string locationId) =>
            s_projectLocation.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)));

        /// <summary>Parses the given resource name string into a new <see cref="FulfillmentName"/> instance.</summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/agent/fulfillment</c></description></item>
        /// <item><description><c>projects/{project}/locations/{location}/agent/fulfillment</c></description></item>
        /// </list>
        /// </remarks>
        /// <param name="fulfillmentName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="FulfillmentName"/> if successful.</returns>
        public static FulfillmentName Parse(string fulfillmentName) => Parse(fulfillmentName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="FulfillmentName"/> instance; optionally allowing
        /// an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/agent/fulfillment</c></description></item>
        /// <item><description><c>projects/{project}/locations/{location}/agent/fulfillment</c></description></item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="fulfillmentName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="FulfillmentName"/> if successful.</returns>
        public static FulfillmentName Parse(string fulfillmentName, bool allowUnparsed) =>
            TryParse(fulfillmentName, allowUnparsed, out FulfillmentName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="FulfillmentName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/agent/fulfillment</c></description></item>
        /// <item><description><c>projects/{project}/locations/{location}/agent/fulfillment</c></description></item>
        /// </list>
        /// </remarks>
        /// <param name="fulfillmentName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="FulfillmentName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string fulfillmentName, out FulfillmentName result) =>
            TryParse(fulfillmentName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="FulfillmentName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/agent/fulfillment</c></description></item>
        /// <item><description><c>projects/{project}/locations/{location}/agent/fulfillment</c></description></item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="fulfillmentName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="FulfillmentName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string fulfillmentName, bool allowUnparsed, out FulfillmentName result)
        {
            gax::GaxPreconditions.CheckNotNull(fulfillmentName, nameof(fulfillmentName));
            gax::TemplatedResourceName resourceName;
            if (s_project.TryParseName(fulfillmentName, out resourceName))
            {
                result = FromProject(resourceName[0]);
                return true;
            }
            if (s_projectLocation.TryParseName(fulfillmentName, out resourceName))
            {
                result = FromProjectLocation(resourceName[0], resourceName[1]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(fulfillmentName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private FulfillmentName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string locationId = null, string projectId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            LocationId = locationId;
            ProjectId = projectId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="FulfillmentName"/> class from the component parts of pattern
        /// <c>projects/{project}/agent/fulfillment</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        public FulfillmentName(string projectId) : this(ResourceNameType.Project, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)))
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
        /// The <c>Location</c> ID. May be <c>null</c>, depending on which resource name is contained by this instance.
        /// </summary>
        public string LocationId { get; }

        /// <summary>
        /// The <c>Project</c> ID. May be <c>null</c>, depending on which resource name is contained by this instance.
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
                case ResourceNameType.Project: return s_project.Expand(ProjectId);
                case ResourceNameType.ProjectLocation: return s_projectLocation.Expand(ProjectId, LocationId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as FulfillmentName);

        /// <inheritdoc/>
        public bool Equals(FulfillmentName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(FulfillmentName a, FulfillmentName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(FulfillmentName a, FulfillmentName b) => !(a == b);
    }

    public partial class Fulfillment
    {
        /// <summary>
        /// <see cref="gcdv::FulfillmentName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcdv::FulfillmentName FulfillmentName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcdv::FulfillmentName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class GetFulfillmentRequest
    {
        /// <summary>
        /// <see cref="gcdv::FulfillmentName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcdv::FulfillmentName FulfillmentName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcdv::FulfillmentName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }
}
