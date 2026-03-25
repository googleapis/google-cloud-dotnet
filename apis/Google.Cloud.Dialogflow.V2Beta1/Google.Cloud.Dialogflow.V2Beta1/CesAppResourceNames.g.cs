// Copyright 2026 Google LLC
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
using sys = System;

namespace Google.Cloud.Dialogflow.V2Beta1
{
    /// <summary>Resource name for the <c>App</c> resource.</summary>
    public sealed partial class AppName : gax::IResourceName, sys::IEquatable<AppName>
    {
        /// <summary>The possible contents of <see cref="AppName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern <c>projects/{project}/locations/{location}/apps/{app}</c>.
            /// </summary>
            ProjectLocationApp = 1,
        }

        private static gax::PathTemplate s_projectLocationApp = new gax::PathTemplate("projects/{project}/locations/{location}/apps/{app}");

        /// <summary>Creates a <see cref="AppName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="AppName"/> containing the provided <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static AppName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new AppName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="AppName"/> with the pattern <c>projects/{project}/locations/{location}/apps/{app}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="appId">The <c>App</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="AppName"/> constructed from the provided ids.</returns>
        public static AppName FromProjectLocationApp(string projectId, string locationId, string appId) =>
            new AppName(ResourceNameType.ProjectLocationApp, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), appId: gax::GaxPreconditions.CheckNotNullOrEmpty(appId, nameof(appId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="AppName"/> with pattern
        /// <c>projects/{project}/locations/{location}/apps/{app}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="appId">The <c>App</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="AppName"/> with pattern
        /// <c>projects/{project}/locations/{location}/apps/{app}</c>.
        /// </returns>
        public static string Format(string projectId, string locationId, string appId) =>
            FormatProjectLocationApp(projectId, locationId, appId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="AppName"/> with pattern
        /// <c>projects/{project}/locations/{location}/apps/{app}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="appId">The <c>App</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="AppName"/> with pattern
        /// <c>projects/{project}/locations/{location}/apps/{app}</c>.
        /// </returns>
        public static string FormatProjectLocationApp(string projectId, string locationId, string appId) =>
            s_projectLocationApp.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(appId, nameof(appId)));

        /// <summary>Parses the given resource name string into a new <see cref="AppName"/> instance.</summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/locations/{location}/apps/{app}</c></description></item>
        /// </list>
        /// </remarks>
        /// <param name="appName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="AppName"/> if successful.</returns>
        public static AppName Parse(string appName) => Parse(appName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="AppName"/> instance; optionally allowing an
        /// unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/locations/{location}/apps/{app}</c></description></item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="appName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="AppName"/> if successful.</returns>
        public static AppName Parse(string appName, bool allowUnparsed) =>
            TryParse(appName, allowUnparsed, out AppName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>Tries to parse the given resource name string into a new <see cref="AppName"/> instance.</summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/locations/{location}/apps/{app}</c></description></item>
        /// </list>
        /// </remarks>
        /// <param name="appName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="AppName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string appName, out AppName result) => TryParse(appName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="AppName"/> instance; optionally allowing
        /// an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/locations/{location}/apps/{app}</c></description></item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="appName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="AppName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string appName, bool allowUnparsed, out AppName result)
        {
            gax::GaxPreconditions.CheckNotNull(appName, nameof(appName));
            gax::TemplatedResourceName resourceName;
            if (s_projectLocationApp.TryParseName(appName, out resourceName))
            {
                result = FromProjectLocationApp(resourceName[0], resourceName[1], resourceName[2]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(appName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private AppName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string appId = null, string locationId = null, string projectId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            AppId = appId;
            LocationId = locationId;
            ProjectId = projectId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="AppName"/> class from the component parts of pattern
        /// <c>projects/{project}/locations/{location}/apps/{app}</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="appId">The <c>App</c> ID. Must not be <c>null</c> or empty.</param>
        public AppName(string projectId, string locationId, string appId) : this(ResourceNameType.ProjectLocationApp, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), appId: gax::GaxPreconditions.CheckNotNullOrEmpty(appId, nameof(appId)))
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
        /// The <c>App</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string AppId { get; }

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
                case ResourceNameType.ProjectLocationApp: return s_projectLocationApp.Expand(ProjectId, LocationId, AppId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as AppName);

        /// <inheritdoc/>
        public bool Equals(AppName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(AppName a, AppName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(AppName a, AppName b) => !(a == b);
    }

    public partial class CesAppSpec
    {
        /// <summary><see cref="AppName"/>-typed view over the <see cref="CesApp"/> resource name property.</summary>
        public AppName CesAppAsAppName
        {
            get => string.IsNullOrEmpty(CesApp) ? null : AppName.Parse(CesApp, allowUnparsed: true);
            set => CesApp = value?.ToString() ?? "";
        }
    }
}
