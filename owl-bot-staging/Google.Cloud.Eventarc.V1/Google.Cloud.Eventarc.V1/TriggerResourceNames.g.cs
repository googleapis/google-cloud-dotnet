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
using gcev = Google.Cloud.Eventarc.V1;
using sys = System;

namespace Google.Cloud.Eventarc.V1
{
    /// <summary>Resource name for the <c>Trigger</c> resource.</summary>
    public sealed partial class TriggerName : gax::IResourceName, sys::IEquatable<TriggerName>
    {
        /// <summary>The possible contents of <see cref="TriggerName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern <c>projects/{project}/locations/{location}/triggers/{trigger}</c>.
            /// </summary>
            ProjectLocationTrigger = 1,
        }

        private static gax::PathTemplate s_projectLocationTrigger = new gax::PathTemplate("projects/{project}/locations/{location}/triggers/{trigger}");

        /// <summary>Creates a <see cref="TriggerName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="TriggerName"/> containing the provided <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static TriggerName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new TriggerName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="TriggerName"/> with the pattern
        /// <c>projects/{project}/locations/{location}/triggers/{trigger}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="triggerId">The <c>Trigger</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="TriggerName"/> constructed from the provided ids.</returns>
        public static TriggerName FromProjectLocationTrigger(string projectId, string locationId, string triggerId) =>
            new TriggerName(ResourceNameType.ProjectLocationTrigger, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), triggerId: gax::GaxPreconditions.CheckNotNullOrEmpty(triggerId, nameof(triggerId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="TriggerName"/> with pattern
        /// <c>projects/{project}/locations/{location}/triggers/{trigger}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="triggerId">The <c>Trigger</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="TriggerName"/> with pattern
        /// <c>projects/{project}/locations/{location}/triggers/{trigger}</c>.
        /// </returns>
        public static string Format(string projectId, string locationId, string triggerId) =>
            FormatProjectLocationTrigger(projectId, locationId, triggerId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="TriggerName"/> with pattern
        /// <c>projects/{project}/locations/{location}/triggers/{trigger}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="triggerId">The <c>Trigger</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="TriggerName"/> with pattern
        /// <c>projects/{project}/locations/{location}/triggers/{trigger}</c>.
        /// </returns>
        public static string FormatProjectLocationTrigger(string projectId, string locationId, string triggerId) =>
            s_projectLocationTrigger.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(triggerId, nameof(triggerId)));

        /// <summary>Parses the given resource name string into a new <see cref="TriggerName"/> instance.</summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/locations/{location}/triggers/{trigger}</c></description></item>
        /// </list>
        /// </remarks>
        /// <param name="triggerName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="TriggerName"/> if successful.</returns>
        public static TriggerName Parse(string triggerName) => Parse(triggerName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="TriggerName"/> instance; optionally allowing an
        /// unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/locations/{location}/triggers/{trigger}</c></description></item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="triggerName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="TriggerName"/> if successful.</returns>
        public static TriggerName Parse(string triggerName, bool allowUnparsed) =>
            TryParse(triggerName, allowUnparsed, out TriggerName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="TriggerName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/locations/{location}/triggers/{trigger}</c></description></item>
        /// </list>
        /// </remarks>
        /// <param name="triggerName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="TriggerName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string triggerName, out TriggerName result) => TryParse(triggerName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="TriggerName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/locations/{location}/triggers/{trigger}</c></description></item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="triggerName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="TriggerName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string triggerName, bool allowUnparsed, out TriggerName result)
        {
            gax::GaxPreconditions.CheckNotNull(triggerName, nameof(triggerName));
            gax::TemplatedResourceName resourceName;
            if (s_projectLocationTrigger.TryParseName(triggerName, out resourceName))
            {
                result = FromProjectLocationTrigger(resourceName[0], resourceName[1], resourceName[2]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(triggerName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private TriggerName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string locationId = null, string projectId = null, string triggerId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            LocationId = locationId;
            ProjectId = projectId;
            TriggerId = triggerId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="TriggerName"/> class from the component parts of pattern
        /// <c>projects/{project}/locations/{location}/triggers/{trigger}</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="triggerId">The <c>Trigger</c> ID. Must not be <c>null</c> or empty.</param>
        public TriggerName(string projectId, string locationId, string triggerId) : this(ResourceNameType.ProjectLocationTrigger, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), triggerId: gax::GaxPreconditions.CheckNotNullOrEmpty(triggerId, nameof(triggerId)))
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
        /// The <c>Location</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string LocationId { get; }

        /// <summary>
        /// The <c>Project</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string ProjectId { get; }

        /// <summary>
        /// The <c>Trigger</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string TriggerId { get; }

        /// <summary>Whether this instance contains a resource name with a known pattern.</summary>
        public bool IsKnownPattern => Type != ResourceNameType.Unparsed;

        /// <summary>The string representation of the resource name.</summary>
        /// <returns>The string representation of the resource name.</returns>
        public override string ToString()
        {
            switch (Type)
            {
                case ResourceNameType.Unparsed: return UnparsedResource.ToString();
                case ResourceNameType.ProjectLocationTrigger: return s_projectLocationTrigger.Expand(ProjectId, LocationId, TriggerId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as TriggerName);

        /// <inheritdoc/>
        public bool Equals(TriggerName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(TriggerName a, TriggerName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(TriggerName a, TriggerName b) => !(a == b);
    }

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

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(CloudFunctionName a, CloudFunctionName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(CloudFunctionName a, CloudFunctionName b) => !(a == b);
    }

    /// <summary>Resource name for the <c>ServiceAccount</c> resource.</summary>
    public sealed partial class ServiceAccountName : gax::IResourceName, sys::IEquatable<ServiceAccountName>
    {
        /// <summary>The possible contents of <see cref="ServiceAccountName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern <c>projects/{project}/serviceAccounts/{service_account}</c>.
            /// </summary>
            ProjectServiceAccount = 1,
        }

        private static gax::PathTemplate s_projectServiceAccount = new gax::PathTemplate("projects/{project}/serviceAccounts/{service_account}");

        /// <summary>Creates a <see cref="ServiceAccountName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="ServiceAccountName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static ServiceAccountName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new ServiceAccountName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="ServiceAccountName"/> with the pattern
        /// <c>projects/{project}/serviceAccounts/{service_account}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="serviceAccountId">The <c>ServiceAccount</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="ServiceAccountName"/> constructed from the provided ids.</returns>
        public static ServiceAccountName FromProjectServiceAccount(string projectId, string serviceAccountId) =>
            new ServiceAccountName(ResourceNameType.ProjectServiceAccount, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), serviceAccountId: gax::GaxPreconditions.CheckNotNullOrEmpty(serviceAccountId, nameof(serviceAccountId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="ServiceAccountName"/> with pattern
        /// <c>projects/{project}/serviceAccounts/{service_account}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="serviceAccountId">The <c>ServiceAccount</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="ServiceAccountName"/> with pattern
        /// <c>projects/{project}/serviceAccounts/{service_account}</c>.
        /// </returns>
        public static string Format(string projectId, string serviceAccountId) =>
            FormatProjectServiceAccount(projectId, serviceAccountId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="ServiceAccountName"/> with pattern
        /// <c>projects/{project}/serviceAccounts/{service_account}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="serviceAccountId">The <c>ServiceAccount</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="ServiceAccountName"/> with pattern
        /// <c>projects/{project}/serviceAccounts/{service_account}</c>.
        /// </returns>
        public static string FormatProjectServiceAccount(string projectId, string serviceAccountId) =>
            s_projectServiceAccount.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(serviceAccountId, nameof(serviceAccountId)));

        /// <summary>
        /// Parses the given resource name string into a new <see cref="ServiceAccountName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/serviceAccounts/{service_account}</c></description></item>
        /// </list>
        /// </remarks>
        /// <param name="serviceAccountName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="ServiceAccountName"/> if successful.</returns>
        public static ServiceAccountName Parse(string serviceAccountName) => Parse(serviceAccountName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="ServiceAccountName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/serviceAccounts/{service_account}</c></description></item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="serviceAccountName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="ServiceAccountName"/> if successful.</returns>
        public static ServiceAccountName Parse(string serviceAccountName, bool allowUnparsed) =>
            TryParse(serviceAccountName, allowUnparsed, out ServiceAccountName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="ServiceAccountName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/serviceAccounts/{service_account}</c></description></item>
        /// </list>
        /// </remarks>
        /// <param name="serviceAccountName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="ServiceAccountName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string serviceAccountName, out ServiceAccountName result) =>
            TryParse(serviceAccountName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="ServiceAccountName"/> instance;
        /// optionally allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/serviceAccounts/{service_account}</c></description></item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="serviceAccountName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="ServiceAccountName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string serviceAccountName, bool allowUnparsed, out ServiceAccountName result)
        {
            gax::GaxPreconditions.CheckNotNull(serviceAccountName, nameof(serviceAccountName));
            gax::TemplatedResourceName resourceName;
            if (s_projectServiceAccount.TryParseName(serviceAccountName, out resourceName))
            {
                result = FromProjectServiceAccount(resourceName[0], resourceName[1]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(serviceAccountName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private ServiceAccountName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string projectId = null, string serviceAccountId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            ProjectId = projectId;
            ServiceAccountId = serviceAccountId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="ServiceAccountName"/> class from the component parts of pattern
        /// <c>projects/{project}/serviceAccounts/{service_account}</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="serviceAccountId">The <c>ServiceAccount</c> ID. Must not be <c>null</c> or empty.</param>
        public ServiceAccountName(string projectId, string serviceAccountId) : this(ResourceNameType.ProjectServiceAccount, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), serviceAccountId: gax::GaxPreconditions.CheckNotNullOrEmpty(serviceAccountId, nameof(serviceAccountId)))
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
        /// The <c>ServiceAccount</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource
        /// name.
        /// </summary>
        public string ServiceAccountId { get; }

        /// <summary>Whether this instance contains a resource name with a known pattern.</summary>
        public bool IsKnownPattern => Type != ResourceNameType.Unparsed;

        /// <summary>The string representation of the resource name.</summary>
        /// <returns>The string representation of the resource name.</returns>
        public override string ToString()
        {
            switch (Type)
            {
                case ResourceNameType.Unparsed: return UnparsedResource.ToString();
                case ResourceNameType.ProjectServiceAccount: return s_projectServiceAccount.Expand(ProjectId, ServiceAccountId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as ServiceAccountName);

        /// <inheritdoc/>
        public bool Equals(ServiceAccountName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(ServiceAccountName a, ServiceAccountName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(ServiceAccountName a, ServiceAccountName b) => !(a == b);
    }

    /// <summary>Resource name for the <c>Workflow</c> resource.</summary>
    public sealed partial class WorkflowName : gax::IResourceName, sys::IEquatable<WorkflowName>
    {
        /// <summary>The possible contents of <see cref="WorkflowName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern <c>projects/{project}/locations/{location}/workflows/{workflow}</c>.
            /// </summary>
            ProjectLocationWorkflow = 1,
        }

        private static gax::PathTemplate s_projectLocationWorkflow = new gax::PathTemplate("projects/{project}/locations/{location}/workflows/{workflow}");

        /// <summary>Creates a <see cref="WorkflowName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="WorkflowName"/> containing the provided <paramref name="unparsedResourceName"/>
        /// .
        /// </returns>
        public static WorkflowName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new WorkflowName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="WorkflowName"/> with the pattern
        /// <c>projects/{project}/locations/{location}/workflows/{workflow}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="workflowId">The <c>Workflow</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="WorkflowName"/> constructed from the provided ids.</returns>
        public static WorkflowName FromProjectLocationWorkflow(string projectId, string locationId, string workflowId) =>
            new WorkflowName(ResourceNameType.ProjectLocationWorkflow, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), workflowId: gax::GaxPreconditions.CheckNotNullOrEmpty(workflowId, nameof(workflowId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="WorkflowName"/> with pattern
        /// <c>projects/{project}/locations/{location}/workflows/{workflow}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="workflowId">The <c>Workflow</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="WorkflowName"/> with pattern
        /// <c>projects/{project}/locations/{location}/workflows/{workflow}</c>.
        /// </returns>
        public static string Format(string projectId, string locationId, string workflowId) =>
            FormatProjectLocationWorkflow(projectId, locationId, workflowId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="WorkflowName"/> with pattern
        /// <c>projects/{project}/locations/{location}/workflows/{workflow}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="workflowId">The <c>Workflow</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="WorkflowName"/> with pattern
        /// <c>projects/{project}/locations/{location}/workflows/{workflow}</c>.
        /// </returns>
        public static string FormatProjectLocationWorkflow(string projectId, string locationId, string workflowId) =>
            s_projectLocationWorkflow.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(workflowId, nameof(workflowId)));

        /// <summary>Parses the given resource name string into a new <see cref="WorkflowName"/> instance.</summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/locations/{location}/workflows/{workflow}</c></description></item>
        /// </list>
        /// </remarks>
        /// <param name="workflowName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="WorkflowName"/> if successful.</returns>
        public static WorkflowName Parse(string workflowName) => Parse(workflowName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="WorkflowName"/> instance; optionally allowing an
        /// unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/locations/{location}/workflows/{workflow}</c></description></item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="workflowName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="WorkflowName"/> if successful.</returns>
        public static WorkflowName Parse(string workflowName, bool allowUnparsed) =>
            TryParse(workflowName, allowUnparsed, out WorkflowName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="WorkflowName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/locations/{location}/workflows/{workflow}</c></description></item>
        /// </list>
        /// </remarks>
        /// <param name="workflowName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="WorkflowName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string workflowName, out WorkflowName result) => TryParse(workflowName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="WorkflowName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/locations/{location}/workflows/{workflow}</c></description></item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="workflowName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="WorkflowName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string workflowName, bool allowUnparsed, out WorkflowName result)
        {
            gax::GaxPreconditions.CheckNotNull(workflowName, nameof(workflowName));
            gax::TemplatedResourceName resourceName;
            if (s_projectLocationWorkflow.TryParseName(workflowName, out resourceName))
            {
                result = FromProjectLocationWorkflow(resourceName[0], resourceName[1], resourceName[2]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(workflowName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private WorkflowName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string locationId = null, string projectId = null, string workflowId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            LocationId = locationId;
            ProjectId = projectId;
            WorkflowId = workflowId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="WorkflowName"/> class from the component parts of pattern
        /// <c>projects/{project}/locations/{location}/workflows/{workflow}</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="workflowId">The <c>Workflow</c> ID. Must not be <c>null</c> or empty.</param>
        public WorkflowName(string projectId, string locationId, string workflowId) : this(ResourceNameType.ProjectLocationWorkflow, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), workflowId: gax::GaxPreconditions.CheckNotNullOrEmpty(workflowId, nameof(workflowId)))
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
        /// The <c>Location</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string LocationId { get; }

        /// <summary>
        /// The <c>Project</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string ProjectId { get; }

        /// <summary>
        /// The <c>Workflow</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string WorkflowId { get; }

        /// <summary>Whether this instance contains a resource name with a known pattern.</summary>
        public bool IsKnownPattern => Type != ResourceNameType.Unparsed;

        /// <summary>The string representation of the resource name.</summary>
        /// <returns>The string representation of the resource name.</returns>
        public override string ToString()
        {
            switch (Type)
            {
                case ResourceNameType.Unparsed: return UnparsedResource.ToString();
                case ResourceNameType.ProjectLocationWorkflow: return s_projectLocationWorkflow.Expand(ProjectId, LocationId, WorkflowId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as WorkflowName);

        /// <inheritdoc/>
        public bool Equals(WorkflowName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(WorkflowName a, WorkflowName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(WorkflowName a, WorkflowName b) => !(a == b);
    }

    /// <summary>Resource name for the <c>NetworkAttachment</c> resource.</summary>
    public sealed partial class NetworkAttachmentName : gax::IResourceName, sys::IEquatable<NetworkAttachmentName>
    {
        /// <summary>The possible contents of <see cref="NetworkAttachmentName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern
            /// <c>projects/{project}/regions/{region}/networkAttachments/{networkattachment}</c>.
            /// </summary>
            ProjectRegionNetworkattachment = 1,
        }

        private static gax::PathTemplate s_projectRegionNetworkattachment = new gax::PathTemplate("projects/{project}/regions/{region}/networkAttachments/{networkattachment}");

        /// <summary>Creates a <see cref="NetworkAttachmentName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="NetworkAttachmentName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static NetworkAttachmentName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new NetworkAttachmentName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="NetworkAttachmentName"/> with the pattern
        /// <c>projects/{project}/regions/{region}/networkAttachments/{networkattachment}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="regionId">The <c>Region</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="networkattachmentId">The <c>Networkattachment</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="NetworkAttachmentName"/> constructed from the provided ids.</returns>
        public static NetworkAttachmentName FromProjectRegionNetworkattachment(string projectId, string regionId, string networkattachmentId) =>
            new NetworkAttachmentName(ResourceNameType.ProjectRegionNetworkattachment, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), regionId: gax::GaxPreconditions.CheckNotNullOrEmpty(regionId, nameof(regionId)), networkattachmentId: gax::GaxPreconditions.CheckNotNullOrEmpty(networkattachmentId, nameof(networkattachmentId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="NetworkAttachmentName"/> with pattern
        /// <c>projects/{project}/regions/{region}/networkAttachments/{networkattachment}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="regionId">The <c>Region</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="networkattachmentId">The <c>Networkattachment</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="NetworkAttachmentName"/> with pattern
        /// <c>projects/{project}/regions/{region}/networkAttachments/{networkattachment}</c>.
        /// </returns>
        public static string Format(string projectId, string regionId, string networkattachmentId) =>
            FormatProjectRegionNetworkattachment(projectId, regionId, networkattachmentId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="NetworkAttachmentName"/> with pattern
        /// <c>projects/{project}/regions/{region}/networkAttachments/{networkattachment}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="regionId">The <c>Region</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="networkattachmentId">The <c>Networkattachment</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="NetworkAttachmentName"/> with pattern
        /// <c>projects/{project}/regions/{region}/networkAttachments/{networkattachment}</c>.
        /// </returns>
        public static string FormatProjectRegionNetworkattachment(string projectId, string regionId, string networkattachmentId) =>
            s_projectRegionNetworkattachment.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(regionId, nameof(regionId)), gax::GaxPreconditions.CheckNotNullOrEmpty(networkattachmentId, nameof(networkattachmentId)));

        /// <summary>
        /// Parses the given resource name string into a new <see cref="NetworkAttachmentName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/regions/{region}/networkAttachments/{networkattachment}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="networkAttachmentName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="NetworkAttachmentName"/> if successful.</returns>
        public static NetworkAttachmentName Parse(string networkAttachmentName) => Parse(networkAttachmentName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="NetworkAttachmentName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/regions/{region}/networkAttachments/{networkattachment}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="networkAttachmentName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="NetworkAttachmentName"/> if successful.</returns>
        public static NetworkAttachmentName Parse(string networkAttachmentName, bool allowUnparsed) =>
            TryParse(networkAttachmentName, allowUnparsed, out NetworkAttachmentName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="NetworkAttachmentName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/regions/{region}/networkAttachments/{networkattachment}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="networkAttachmentName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="NetworkAttachmentName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string networkAttachmentName, out NetworkAttachmentName result) =>
            TryParse(networkAttachmentName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="NetworkAttachmentName"/> instance;
        /// optionally allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/regions/{region}/networkAttachments/{networkattachment}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="networkAttachmentName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="NetworkAttachmentName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string networkAttachmentName, bool allowUnparsed, out NetworkAttachmentName result)
        {
            gax::GaxPreconditions.CheckNotNull(networkAttachmentName, nameof(networkAttachmentName));
            gax::TemplatedResourceName resourceName;
            if (s_projectRegionNetworkattachment.TryParseName(networkAttachmentName, out resourceName))
            {
                result = FromProjectRegionNetworkattachment(resourceName[0], resourceName[1], resourceName[2]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(networkAttachmentName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private NetworkAttachmentName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string networkattachmentId = null, string projectId = null, string regionId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            NetworkattachmentId = networkattachmentId;
            ProjectId = projectId;
            RegionId = regionId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="NetworkAttachmentName"/> class from the component parts of pattern
        /// <c>projects/{project}/regions/{region}/networkAttachments/{networkattachment}</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="regionId">The <c>Region</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="networkattachmentId">The <c>Networkattachment</c> ID. Must not be <c>null</c> or empty.</param>
        public NetworkAttachmentName(string projectId, string regionId, string networkattachmentId) : this(ResourceNameType.ProjectRegionNetworkattachment, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), regionId: gax::GaxPreconditions.CheckNotNullOrEmpty(regionId, nameof(regionId)), networkattachmentId: gax::GaxPreconditions.CheckNotNullOrEmpty(networkattachmentId, nameof(networkattachmentId)))
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
        /// The <c>Networkattachment</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource
        /// name.
        /// </summary>
        public string NetworkattachmentId { get; }

        /// <summary>
        /// The <c>Project</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string ProjectId { get; }

        /// <summary>
        /// The <c>Region</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string RegionId { get; }

        /// <summary>Whether this instance contains a resource name with a known pattern.</summary>
        public bool IsKnownPattern => Type != ResourceNameType.Unparsed;

        /// <summary>The string representation of the resource name.</summary>
        /// <returns>The string representation of the resource name.</returns>
        public override string ToString()
        {
            switch (Type)
            {
                case ResourceNameType.Unparsed: return UnparsedResource.ToString();
                case ResourceNameType.ProjectRegionNetworkattachment: return s_projectRegionNetworkattachment.Expand(ProjectId, RegionId, NetworkattachmentId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as NetworkAttachmentName);

        /// <inheritdoc/>
        public bool Equals(NetworkAttachmentName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(NetworkAttachmentName a, NetworkAttachmentName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(NetworkAttachmentName a, NetworkAttachmentName b) => !(a == b);
    }

    public partial class Trigger
    {
        /// <summary>
        /// <see cref="gcev::TriggerName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcev::TriggerName TriggerName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcev::TriggerName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }

        /// <summary>
        /// <see cref="ServiceAccountName"/>-typed view over the <see cref="ServiceAccount"/> resource name property.
        /// </summary>
        public ServiceAccountName ServiceAccountAsServiceAccountName
        {
            get => string.IsNullOrEmpty(ServiceAccount) ? null : ServiceAccountName.Parse(ServiceAccount, allowUnparsed: true);
            set => ServiceAccount = value?.ToString() ?? "";
        }
    }

    public partial class Destination
    {
        /// <summary>
        /// <see cref="CloudFunctionName"/>-typed view over the <see cref="CloudFunction"/> resource name property.
        /// </summary>
        public CloudFunctionName CloudFunctionAsCloudFunctionName
        {
            get => string.IsNullOrEmpty(CloudFunction) ? null : CloudFunctionName.Parse(CloudFunction, allowUnparsed: true);
            set => CloudFunction = value?.ToString() ?? "";
        }

        /// <summary>
        /// <see cref="WorkflowName"/>-typed view over the <see cref="Workflow"/> resource name property.
        /// </summary>
        public WorkflowName WorkflowAsWorkflowName
        {
            get => string.IsNullOrEmpty(Workflow) ? null : WorkflowName.Parse(Workflow, allowUnparsed: true);
            set => Workflow = value?.ToString() ?? "";
        }
    }

    public partial class CloudRun
    {
        /// <summary>
        /// <see cref="gax::IResourceName"/>-typed view over the <see cref="Service"/> resource name property.
        /// </summary>
        public gax::IResourceName ServiceAsResourceName
        {
            get => string.IsNullOrEmpty(Service) ? null : gax::UnparsedResourceName.Parse(Service);
            set => Service = value?.ToString() ?? "";
        }
    }
}
