// Copyright 2024 Google LLC
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
using gcmv = Google.Cloud.Monitoring.V3;
using sys = System;

namespace Google.Cloud.Monitoring.V3
{
    /// <summary>Resource name for the <c>Snooze</c> resource.</summary>
    public sealed partial class SnoozeName : gax::IResourceName, sys::IEquatable<SnoozeName>
    {
        /// <summary>The possible contents of <see cref="SnoozeName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>A resource name with pattern <c>projects/{project}/snoozes/{snooze}</c>.</summary>
            ProjectSnooze = 1,
        }

        private static gax::PathTemplate s_projectSnooze = new gax::PathTemplate("projects/{project}/snoozes/{snooze}");

        /// <summary>Creates a <see cref="SnoozeName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="SnoozeName"/> containing the provided <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static SnoozeName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new SnoozeName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="SnoozeName"/> with the pattern <c>projects/{project}/snoozes/{snooze}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="snoozeId">The <c>Snooze</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="SnoozeName"/> constructed from the provided ids.</returns>
        public static SnoozeName FromProjectSnooze(string projectId, string snoozeId) =>
            new SnoozeName(ResourceNameType.ProjectSnooze, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), snoozeId: gax::GaxPreconditions.CheckNotNullOrEmpty(snoozeId, nameof(snoozeId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="SnoozeName"/> with pattern
        /// <c>projects/{project}/snoozes/{snooze}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="snoozeId">The <c>Snooze</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="SnoozeName"/> with pattern
        /// <c>projects/{project}/snoozes/{snooze}</c>.
        /// </returns>
        public static string Format(string projectId, string snoozeId) => FormatProjectSnooze(projectId, snoozeId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="SnoozeName"/> with pattern
        /// <c>projects/{project}/snoozes/{snooze}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="snoozeId">The <c>Snooze</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="SnoozeName"/> with pattern
        /// <c>projects/{project}/snoozes/{snooze}</c>.
        /// </returns>
        public static string FormatProjectSnooze(string projectId, string snoozeId) =>
            s_projectSnooze.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(snoozeId, nameof(snoozeId)));

        /// <summary>Parses the given resource name string into a new <see cref="SnoozeName"/> instance.</summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/snoozes/{snooze}</c></description></item>
        /// </list>
        /// </remarks>
        /// <param name="snoozeName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="SnoozeName"/> if successful.</returns>
        public static SnoozeName Parse(string snoozeName) => Parse(snoozeName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="SnoozeName"/> instance; optionally allowing an
        /// unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/snoozes/{snooze}</c></description></item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="snoozeName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="SnoozeName"/> if successful.</returns>
        public static SnoozeName Parse(string snoozeName, bool allowUnparsed) =>
            TryParse(snoozeName, allowUnparsed, out SnoozeName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="SnoozeName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/snoozes/{snooze}</c></description></item>
        /// </list>
        /// </remarks>
        /// <param name="snoozeName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="SnoozeName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string snoozeName, out SnoozeName result) => TryParse(snoozeName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="SnoozeName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/snoozes/{snooze}</c></description></item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="snoozeName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="SnoozeName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string snoozeName, bool allowUnparsed, out SnoozeName result)
        {
            gax::GaxPreconditions.CheckNotNull(snoozeName, nameof(snoozeName));
            gax::TemplatedResourceName resourceName;
            if (s_projectSnooze.TryParseName(snoozeName, out resourceName))
            {
                result = FromProjectSnooze(resourceName[0], resourceName[1]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(snoozeName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private SnoozeName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string projectId = null, string snoozeId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            ProjectId = projectId;
            SnoozeId = snoozeId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="SnoozeName"/> class from the component parts of pattern
        /// <c>projects/{project}/snoozes/{snooze}</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="snoozeId">The <c>Snooze</c> ID. Must not be <c>null</c> or empty.</param>
        public SnoozeName(string projectId, string snoozeId) : this(ResourceNameType.ProjectSnooze, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), snoozeId: gax::GaxPreconditions.CheckNotNullOrEmpty(snoozeId, nameof(snoozeId)))
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
        /// The <c>Project</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string ProjectId { get; }

        /// <summary>
        /// The <c>Snooze</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string SnoozeId { get; }

        /// <summary>Whether this instance contains a resource name with a known pattern.</summary>
        public bool IsKnownPattern => Type != ResourceNameType.Unparsed;

        /// <summary>The string representation of the resource name.</summary>
        /// <returns>The string representation of the resource name.</returns>
        public override string ToString()
        {
            switch (Type)
            {
                case ResourceNameType.Unparsed: return UnparsedResource.ToString();
                case ResourceNameType.ProjectSnooze: return s_projectSnooze.Expand(ProjectId, SnoozeId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as SnoozeName);

        /// <inheritdoc/>
        public bool Equals(SnoozeName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(SnoozeName a, SnoozeName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(SnoozeName a, SnoozeName b) => !(a == b);
    }

    public partial class Snooze
    {
        /// <summary>
        /// <see cref="gcmv::SnoozeName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcmv::SnoozeName SnoozeName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcmv::SnoozeName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }

        public partial class Types
        {
            public partial class Criteria
            {
                /// <summary>
                /// <see cref="AlertPolicyName"/>-typed view over the <see cref="Policies"/> resource name property.
                /// </summary>
                public gax::ResourceNameList<AlertPolicyName> PoliciesAsAlertPolicyNames
                {
                    get => new gax::ResourceNameList<AlertPolicyName>(Policies, s => string.IsNullOrEmpty(s) ? null : AlertPolicyName.Parse(s, allowUnparsed: true));
                }

                /// <summary>
                /// <see cref="gax::IResourceName"/>-typed view over the <see cref="Policies"/> resource name property.
                /// </summary>
                public gax::ResourceNameList<gax::IResourceName> PoliciesAsResourceNames
                {
                    get => new gax::ResourceNameList<gax::IResourceName>(Policies, s =>
                    {
                        if (string.IsNullOrEmpty(s))
                        {
                            return null;
                        }
                        if (AlertPolicyName.TryParse(s, out AlertPolicyName alertPolicy))
                        {
                            return alertPolicy;
                        }
                        return gax::UnparsedResourceName.Parse(s);
                    });
                }
            }
        }
    }
}
