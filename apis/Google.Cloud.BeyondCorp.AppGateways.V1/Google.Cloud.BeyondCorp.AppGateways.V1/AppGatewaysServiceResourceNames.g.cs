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
using gagr = Google.Api.Gax.ResourceNames;
using gax = Google.Api.Gax;
using gcbav = Google.Cloud.BeyondCorp.AppGateways.V1;
using sys = System;

namespace Google.Cloud.BeyondCorp.AppGateways.V1
{
    /// <summary>Resource name for the <c>AppGateway</c> resource.</summary>
    public sealed partial class AppGatewayName : gax::IResourceName, sys::IEquatable<AppGatewayName>
    {
        /// <summary>The possible contents of <see cref="AppGatewayName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern <c>projects/{project}/locations/{location}/appGateways/{app_gateway}</c>.
            /// </summary>
            ProjectLocationAppGateway = 1,
        }

        private static gax::PathTemplate s_projectLocationAppGateway = new gax::PathTemplate("projects/{project}/locations/{location}/appGateways/{app_gateway}");

        /// <summary>Creates a <see cref="AppGatewayName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="AppGatewayName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static AppGatewayName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new AppGatewayName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="AppGatewayName"/> with the pattern
        /// <c>projects/{project}/locations/{location}/appGateways/{app_gateway}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="appGatewayId">The <c>AppGateway</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="AppGatewayName"/> constructed from the provided ids.</returns>
        public static AppGatewayName FromProjectLocationAppGateway(string projectId, string locationId, string appGatewayId) =>
            new AppGatewayName(ResourceNameType.ProjectLocationAppGateway, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), appGatewayId: gax::GaxPreconditions.CheckNotNullOrEmpty(appGatewayId, nameof(appGatewayId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="AppGatewayName"/> with pattern
        /// <c>projects/{project}/locations/{location}/appGateways/{app_gateway}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="appGatewayId">The <c>AppGateway</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="AppGatewayName"/> with pattern
        /// <c>projects/{project}/locations/{location}/appGateways/{app_gateway}</c>.
        /// </returns>
        public static string Format(string projectId, string locationId, string appGatewayId) =>
            FormatProjectLocationAppGateway(projectId, locationId, appGatewayId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="AppGatewayName"/> with pattern
        /// <c>projects/{project}/locations/{location}/appGateways/{app_gateway}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="appGatewayId">The <c>AppGateway</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="AppGatewayName"/> with pattern
        /// <c>projects/{project}/locations/{location}/appGateways/{app_gateway}</c>.
        /// </returns>
        public static string FormatProjectLocationAppGateway(string projectId, string locationId, string appGatewayId) =>
            s_projectLocationAppGateway.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(appGatewayId, nameof(appGatewayId)));

        /// <summary>Parses the given resource name string into a new <see cref="AppGatewayName"/> instance.</summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>projects/{project}/locations/{location}/appGateways/{app_gateway}</c></description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="appGatewayName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="AppGatewayName"/> if successful.</returns>
        public static AppGatewayName Parse(string appGatewayName) => Parse(appGatewayName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="AppGatewayName"/> instance; optionally allowing
        /// an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>projects/{project}/locations/{location}/appGateways/{app_gateway}</c></description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="appGatewayName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="AppGatewayName"/> if successful.</returns>
        public static AppGatewayName Parse(string appGatewayName, bool allowUnparsed) =>
            TryParse(appGatewayName, allowUnparsed, out AppGatewayName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="AppGatewayName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>projects/{project}/locations/{location}/appGateways/{app_gateway}</c></description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="appGatewayName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="AppGatewayName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string appGatewayName, out AppGatewayName result) =>
            TryParse(appGatewayName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="AppGatewayName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>projects/{project}/locations/{location}/appGateways/{app_gateway}</c></description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="appGatewayName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="AppGatewayName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string appGatewayName, bool allowUnparsed, out AppGatewayName result)
        {
            gax::GaxPreconditions.CheckNotNull(appGatewayName, nameof(appGatewayName));
            gax::TemplatedResourceName resourceName;
            if (s_projectLocationAppGateway.TryParseName(appGatewayName, out resourceName))
            {
                result = FromProjectLocationAppGateway(resourceName[0], resourceName[1], resourceName[2]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(appGatewayName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private AppGatewayName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string appGatewayId = null, string locationId = null, string projectId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            AppGatewayId = appGatewayId;
            LocationId = locationId;
            ProjectId = projectId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="AppGatewayName"/> class from the component parts of pattern
        /// <c>projects/{project}/locations/{location}/appGateways/{app_gateway}</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="appGatewayId">The <c>AppGateway</c> ID. Must not be <c>null</c> or empty.</param>
        public AppGatewayName(string projectId, string locationId, string appGatewayId) : this(ResourceNameType.ProjectLocationAppGateway, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), appGatewayId: gax::GaxPreconditions.CheckNotNullOrEmpty(appGatewayId, nameof(appGatewayId)))
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
        /// The <c>AppGateway</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string AppGatewayId { get; }

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
                case ResourceNameType.ProjectLocationAppGateway: return s_projectLocationAppGateway.Expand(ProjectId, LocationId, AppGatewayId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as AppGatewayName);

        /// <inheritdoc/>
        public bool Equals(AppGatewayName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(AppGatewayName a, AppGatewayName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(AppGatewayName a, AppGatewayName b) => !(a == b);
    }

    public partial class ListAppGatewaysRequest
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

    public partial class GetAppGatewayRequest
    {
        /// <summary>
        /// <see cref="gcbav::AppGatewayName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcbav::AppGatewayName AppGatewayName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcbav::AppGatewayName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class CreateAppGatewayRequest
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

    public partial class DeleteAppGatewayRequest
    {
        /// <summary>
        /// <see cref="gcbav::AppGatewayName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcbav::AppGatewayName AppGatewayName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcbav::AppGatewayName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class AppGateway
    {
        /// <summary>
        /// <see cref="gcbav::AppGatewayName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcbav::AppGatewayName AppGatewayName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcbav::AppGatewayName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }
}
