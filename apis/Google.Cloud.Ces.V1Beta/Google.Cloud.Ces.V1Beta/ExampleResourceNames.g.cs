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
using gccv = Google.Cloud.Ces.V1Beta;
using sys = System;

namespace Google.Cloud.Ces.V1Beta
{
    /// <summary>Resource name for the <c>Example</c> resource.</summary>
    public sealed partial class ExampleName : gax::IResourceName, sys::IEquatable<ExampleName>
    {
        /// <summary>The possible contents of <see cref="ExampleName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern <c>projects/{project}/locations/{location}/apps/{app}/examples/{example}</c>
            /// .
            /// </summary>
            ProjectLocationAppExample = 1,
        }

        private static gax::PathTemplate s_projectLocationAppExample = new gax::PathTemplate("projects/{project}/locations/{location}/apps/{app}/examples/{example}");

        /// <summary>Creates a <see cref="ExampleName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="ExampleName"/> containing the provided <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static ExampleName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new ExampleName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="ExampleName"/> with the pattern
        /// <c>projects/{project}/locations/{location}/apps/{app}/examples/{example}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="appId">The <c>App</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="exampleId">The <c>Example</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="ExampleName"/> constructed from the provided ids.</returns>
        public static ExampleName FromProjectLocationAppExample(string projectId, string locationId, string appId, string exampleId) =>
            new ExampleName(ResourceNameType.ProjectLocationAppExample, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), appId: gax::GaxPreconditions.CheckNotNullOrEmpty(appId, nameof(appId)), exampleId: gax::GaxPreconditions.CheckNotNullOrEmpty(exampleId, nameof(exampleId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="ExampleName"/> with pattern
        /// <c>projects/{project}/locations/{location}/apps/{app}/examples/{example}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="appId">The <c>App</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="exampleId">The <c>Example</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="ExampleName"/> with pattern
        /// <c>projects/{project}/locations/{location}/apps/{app}/examples/{example}</c>.
        /// </returns>
        public static string Format(string projectId, string locationId, string appId, string exampleId) =>
            FormatProjectLocationAppExample(projectId, locationId, appId, exampleId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="ExampleName"/> with pattern
        /// <c>projects/{project}/locations/{location}/apps/{app}/examples/{example}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="appId">The <c>App</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="exampleId">The <c>Example</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="ExampleName"/> with pattern
        /// <c>projects/{project}/locations/{location}/apps/{app}/examples/{example}</c>.
        /// </returns>
        public static string FormatProjectLocationAppExample(string projectId, string locationId, string appId, string exampleId) =>
            s_projectLocationAppExample.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(appId, nameof(appId)), gax::GaxPreconditions.CheckNotNullOrEmpty(exampleId, nameof(exampleId)));

        /// <summary>Parses the given resource name string into a new <see cref="ExampleName"/> instance.</summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>projects/{project}/locations/{location}/apps/{app}/examples/{example}</c></description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="exampleName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="ExampleName"/> if successful.</returns>
        public static ExampleName Parse(string exampleName) => Parse(exampleName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="ExampleName"/> instance; optionally allowing an
        /// unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>projects/{project}/locations/{location}/apps/{app}/examples/{example}</c></description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="exampleName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="ExampleName"/> if successful.</returns>
        public static ExampleName Parse(string exampleName, bool allowUnparsed) =>
            TryParse(exampleName, allowUnparsed, out ExampleName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="ExampleName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>projects/{project}/locations/{location}/apps/{app}/examples/{example}</c></description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="exampleName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="ExampleName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string exampleName, out ExampleName result) => TryParse(exampleName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="ExampleName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>projects/{project}/locations/{location}/apps/{app}/examples/{example}</c></description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="exampleName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="ExampleName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string exampleName, bool allowUnparsed, out ExampleName result)
        {
            gax::GaxPreconditions.CheckNotNull(exampleName, nameof(exampleName));
            gax::TemplatedResourceName resourceName;
            if (s_projectLocationAppExample.TryParseName(exampleName, out resourceName))
            {
                result = FromProjectLocationAppExample(resourceName[0], resourceName[1], resourceName[2], resourceName[3]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(exampleName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private ExampleName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string appId = null, string exampleId = null, string locationId = null, string projectId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            AppId = appId;
            ExampleId = exampleId;
            LocationId = locationId;
            ProjectId = projectId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="ExampleName"/> class from the component parts of pattern
        /// <c>projects/{project}/locations/{location}/apps/{app}/examples/{example}</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="appId">The <c>App</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="exampleId">The <c>Example</c> ID. Must not be <c>null</c> or empty.</param>
        public ExampleName(string projectId, string locationId, string appId, string exampleId) : this(ResourceNameType.ProjectLocationAppExample, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), appId: gax::GaxPreconditions.CheckNotNullOrEmpty(appId, nameof(appId)), exampleId: gax::GaxPreconditions.CheckNotNullOrEmpty(exampleId, nameof(exampleId)))
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
        /// The <c>Example</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string ExampleId { get; }

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
                case ResourceNameType.ProjectLocationAppExample: return s_projectLocationAppExample.Expand(ProjectId, LocationId, AppId, ExampleId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as ExampleName);

        /// <inheritdoc/>
        public bool Equals(ExampleName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(ExampleName a, ExampleName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(ExampleName a, ExampleName b) => !(a == b);
    }

    public partial class Example
    {
        /// <summary>
        /// <see cref="gccv::ExampleName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gccv::ExampleName ExampleName
        {
            get => string.IsNullOrEmpty(Name) ? null : gccv::ExampleName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }

        /// <summary>
        /// <see cref="AgentName"/>-typed view over the <see cref="EntryAgent"/> resource name property.
        /// </summary>
        public AgentName EntryAgentAsAgentName
        {
            get => string.IsNullOrEmpty(EntryAgent) ? null : AgentName.Parse(EntryAgent, allowUnparsed: true);
            set => EntryAgent = value?.ToString() ?? "";
        }
    }

    public partial class ToolCall
    {
        /// <summary><see cref="ToolName"/>-typed view over the <see cref="Tool"/> resource name property.</summary>
        public ToolName ToolAsToolName
        {
            get => string.IsNullOrEmpty(Tool) ? null : ToolName.Parse(Tool, allowUnparsed: true);
            set => Tool = value?.ToString() ?? "";
        }
    }

    public partial class ToolResponse
    {
        /// <summary><see cref="ToolName"/>-typed view over the <see cref="Tool"/> resource name property.</summary>
        public ToolName ToolAsToolName
        {
            get => string.IsNullOrEmpty(Tool) ? null : ToolName.Parse(Tool, allowUnparsed: true);
            set => Tool = value?.ToString() ?? "";
        }
    }

    public partial class AgentTransfer
    {
        /// <summary>
        /// <see cref="AgentName"/>-typed view over the <see cref="TargetAgent"/> resource name property.
        /// </summary>
        public AgentName TargetAgentAsAgentName
        {
            get => string.IsNullOrEmpty(TargetAgent) ? null : AgentName.Parse(TargetAgent, allowUnparsed: true);
            set => TargetAgent = value?.ToString() ?? "";
        }
    }
}
