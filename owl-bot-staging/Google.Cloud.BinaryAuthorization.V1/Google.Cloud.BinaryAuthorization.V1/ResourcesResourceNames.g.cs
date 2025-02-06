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
using gcbv = Google.Cloud.BinaryAuthorization.V1;
using sys = System;

namespace Google.Cloud.BinaryAuthorization.V1
{
    /// <summary>Resource name for the <c>Policy</c> resource.</summary>
    public sealed partial class PolicyName : gax::IResourceName, sys::IEquatable<PolicyName>
    {
        /// <summary>The possible contents of <see cref="PolicyName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>A resource name with pattern <c>projects/{project}/policy</c>.</summary>
            Project = 1,

            /// <summary>A resource name with pattern <c>locations/{location}/policy</c>.</summary>
            Location = 2,
        }

        private static gax::PathTemplate s_project = new gax::PathTemplate("projects/{project}/policy");

        private static gax::PathTemplate s_location = new gax::PathTemplate("locations/{location}/policy");

        /// <summary>Creates a <see cref="PolicyName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="PolicyName"/> containing the provided <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static PolicyName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new PolicyName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>Creates a <see cref="PolicyName"/> with the pattern <c>projects/{project}/policy</c>.</summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="PolicyName"/> constructed from the provided ids.</returns>
        public static PolicyName FromProject(string projectId) =>
            new PolicyName(ResourceNameType.Project, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)));

        /// <summary>Creates a <see cref="PolicyName"/> with the pattern <c>locations/{location}/policy</c>.</summary>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="PolicyName"/> constructed from the provided ids.</returns>
        public static PolicyName FromLocation(string locationId) =>
            new PolicyName(ResourceNameType.Location, locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="PolicyName"/> with pattern
        /// <c>projects/{project}/policy</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="PolicyName"/> with pattern <c>projects/{project}/policy</c>.
        /// </returns>
        public static string Format(string projectId) => FormatProject(projectId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="PolicyName"/> with pattern
        /// <c>projects/{project}/policy</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="PolicyName"/> with pattern <c>projects/{project}/policy</c>.
        /// </returns>
        public static string FormatProject(string projectId) =>
            s_project.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="PolicyName"/> with pattern
        /// <c>locations/{location}/policy</c>.
        /// </summary>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="PolicyName"/> with pattern <c>locations/{location}/policy</c>.
        /// </returns>
        public static string FormatLocation(string locationId) =>
            s_location.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)));

        /// <summary>Parses the given resource name string into a new <see cref="PolicyName"/> instance.</summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/policy</c></description></item>
        /// <item><description><c>locations/{location}/policy</c></description></item>
        /// </list>
        /// </remarks>
        /// <param name="policyName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="PolicyName"/> if successful.</returns>
        public static PolicyName Parse(string policyName) => Parse(policyName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="PolicyName"/> instance; optionally allowing an
        /// unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/policy</c></description></item>
        /// <item><description><c>locations/{location}/policy</c></description></item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="policyName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="PolicyName"/> if successful.</returns>
        public static PolicyName Parse(string policyName, bool allowUnparsed) =>
            TryParse(policyName, allowUnparsed, out PolicyName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="PolicyName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/policy</c></description></item>
        /// <item><description><c>locations/{location}/policy</c></description></item>
        /// </list>
        /// </remarks>
        /// <param name="policyName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="PolicyName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string policyName, out PolicyName result) => TryParse(policyName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="PolicyName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/policy</c></description></item>
        /// <item><description><c>locations/{location}/policy</c></description></item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="policyName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="PolicyName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string policyName, bool allowUnparsed, out PolicyName result)
        {
            gax::GaxPreconditions.CheckNotNull(policyName, nameof(policyName));
            gax::TemplatedResourceName resourceName;
            if (s_project.TryParseName(policyName, out resourceName))
            {
                result = FromProject(resourceName[0]);
                return true;
            }
            if (s_location.TryParseName(policyName, out resourceName))
            {
                result = FromLocation(resourceName[0]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(policyName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private PolicyName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string locationId = null, string projectId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            LocationId = locationId;
            ProjectId = projectId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="PolicyName"/> class from the component parts of pattern
        /// <c>projects/{project}/policy</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        public PolicyName(string projectId) : this(ResourceNameType.Project, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)))
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
                case ResourceNameType.Location: return s_location.Expand(LocationId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as PolicyName);

        /// <inheritdoc/>
        public bool Equals(PolicyName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(PolicyName a, PolicyName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(PolicyName a, PolicyName b) => !(a == b);
    }

    /// <summary>Resource name for the <c>Attestor</c> resource.</summary>
    public sealed partial class AttestorName : gax::IResourceName, sys::IEquatable<AttestorName>
    {
        /// <summary>The possible contents of <see cref="AttestorName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>A resource name with pattern <c>projects/{project}/attestors/{attestor}</c>.</summary>
            ProjectAttestor = 1,
        }

        private static gax::PathTemplate s_projectAttestor = new gax::PathTemplate("projects/{project}/attestors/{attestor}");

        /// <summary>Creates a <see cref="AttestorName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="AttestorName"/> containing the provided <paramref name="unparsedResourceName"/>
        /// .
        /// </returns>
        public static AttestorName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new AttestorName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="AttestorName"/> with the pattern <c>projects/{project}/attestors/{attestor}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="attestorId">The <c>Attestor</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="AttestorName"/> constructed from the provided ids.</returns>
        public static AttestorName FromProjectAttestor(string projectId, string attestorId) =>
            new AttestorName(ResourceNameType.ProjectAttestor, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), attestorId: gax::GaxPreconditions.CheckNotNullOrEmpty(attestorId, nameof(attestorId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="AttestorName"/> with pattern
        /// <c>projects/{project}/attestors/{attestor}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="attestorId">The <c>Attestor</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="AttestorName"/> with pattern
        /// <c>projects/{project}/attestors/{attestor}</c>.
        /// </returns>
        public static string Format(string projectId, string attestorId) => FormatProjectAttestor(projectId, attestorId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="AttestorName"/> with pattern
        /// <c>projects/{project}/attestors/{attestor}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="attestorId">The <c>Attestor</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="AttestorName"/> with pattern
        /// <c>projects/{project}/attestors/{attestor}</c>.
        /// </returns>
        public static string FormatProjectAttestor(string projectId, string attestorId) =>
            s_projectAttestor.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(attestorId, nameof(attestorId)));

        /// <summary>Parses the given resource name string into a new <see cref="AttestorName"/> instance.</summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/attestors/{attestor}</c></description></item>
        /// </list>
        /// </remarks>
        /// <param name="attestorName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="AttestorName"/> if successful.</returns>
        public static AttestorName Parse(string attestorName) => Parse(attestorName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="AttestorName"/> instance; optionally allowing an
        /// unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/attestors/{attestor}</c></description></item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="attestorName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="AttestorName"/> if successful.</returns>
        public static AttestorName Parse(string attestorName, bool allowUnparsed) =>
            TryParse(attestorName, allowUnparsed, out AttestorName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="AttestorName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/attestors/{attestor}</c></description></item>
        /// </list>
        /// </remarks>
        /// <param name="attestorName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="AttestorName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string attestorName, out AttestorName result) => TryParse(attestorName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="AttestorName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/attestors/{attestor}</c></description></item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="attestorName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="AttestorName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string attestorName, bool allowUnparsed, out AttestorName result)
        {
            gax::GaxPreconditions.CheckNotNull(attestorName, nameof(attestorName));
            gax::TemplatedResourceName resourceName;
            if (s_projectAttestor.TryParseName(attestorName, out resourceName))
            {
                result = FromProjectAttestor(resourceName[0], resourceName[1]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(attestorName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private AttestorName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string attestorId = null, string projectId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            AttestorId = attestorId;
            ProjectId = projectId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="AttestorName"/> class from the component parts of pattern
        /// <c>projects/{project}/attestors/{attestor}</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="attestorId">The <c>Attestor</c> ID. Must not be <c>null</c> or empty.</param>
        public AttestorName(string projectId, string attestorId) : this(ResourceNameType.ProjectAttestor, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), attestorId: gax::GaxPreconditions.CheckNotNullOrEmpty(attestorId, nameof(attestorId)))
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
        /// The <c>Attestor</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string AttestorId { get; }

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
                case ResourceNameType.ProjectAttestor: return s_projectAttestor.Expand(ProjectId, AttestorId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as AttestorName);

        /// <inheritdoc/>
        public bool Equals(AttestorName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(AttestorName a, AttestorName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(AttestorName a, AttestorName b) => !(a == b);
    }

    public partial class Policy
    {
        /// <summary>
        /// <see cref="gcbv::PolicyName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcbv::PolicyName PolicyName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcbv::PolicyName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class Attestor
    {
        /// <summary>
        /// <see cref="gcbv::AttestorName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcbv::AttestorName AttestorName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcbv::AttestorName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }
}
