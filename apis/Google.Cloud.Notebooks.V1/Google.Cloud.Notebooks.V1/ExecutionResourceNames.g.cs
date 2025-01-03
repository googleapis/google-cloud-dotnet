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
using gcnv = Google.Cloud.Notebooks.V1;
using sys = System;

namespace Google.Cloud.Notebooks.V1
{
    /// <summary>Resource name for the <c>Execution</c> resource.</summary>
    public sealed partial class ExecutionName : gax::IResourceName, sys::IEquatable<ExecutionName>
    {
        /// <summary>The possible contents of <see cref="ExecutionName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern <c>projects/{project}/location/{location}/executions/{execution}</c>.
            /// </summary>
            ProjectLocationExecution = 1,
        }

        private static gax::PathTemplate s_projectLocationExecution = new gax::PathTemplate("projects/{project}/location/{location}/executions/{execution}");

        /// <summary>Creates a <see cref="ExecutionName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="ExecutionName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static ExecutionName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new ExecutionName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="ExecutionName"/> with the pattern
        /// <c>projects/{project}/location/{location}/executions/{execution}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="executionId">The <c>Execution</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="ExecutionName"/> constructed from the provided ids.</returns>
        public static ExecutionName FromProjectLocationExecution(string projectId, string locationId, string executionId) =>
            new ExecutionName(ResourceNameType.ProjectLocationExecution, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), executionId: gax::GaxPreconditions.CheckNotNullOrEmpty(executionId, nameof(executionId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="ExecutionName"/> with pattern
        /// <c>projects/{project}/location/{location}/executions/{execution}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="executionId">The <c>Execution</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="ExecutionName"/> with pattern
        /// <c>projects/{project}/location/{location}/executions/{execution}</c>.
        /// </returns>
        public static string Format(string projectId, string locationId, string executionId) =>
            FormatProjectLocationExecution(projectId, locationId, executionId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="ExecutionName"/> with pattern
        /// <c>projects/{project}/location/{location}/executions/{execution}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="executionId">The <c>Execution</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="ExecutionName"/> with pattern
        /// <c>projects/{project}/location/{location}/executions/{execution}</c>.
        /// </returns>
        public static string FormatProjectLocationExecution(string projectId, string locationId, string executionId) =>
            s_projectLocationExecution.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(executionId, nameof(executionId)));

        /// <summary>Parses the given resource name string into a new <see cref="ExecutionName"/> instance.</summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>projects/{project}/location/{location}/executions/{execution}</c></description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="executionName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="ExecutionName"/> if successful.</returns>
        public static ExecutionName Parse(string executionName) => Parse(executionName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="ExecutionName"/> instance; optionally allowing
        /// an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>projects/{project}/location/{location}/executions/{execution}</c></description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="executionName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="ExecutionName"/> if successful.</returns>
        public static ExecutionName Parse(string executionName, bool allowUnparsed) =>
            TryParse(executionName, allowUnparsed, out ExecutionName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="ExecutionName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>projects/{project}/location/{location}/executions/{execution}</c></description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="executionName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="ExecutionName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string executionName, out ExecutionName result) => TryParse(executionName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="ExecutionName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>projects/{project}/location/{location}/executions/{execution}</c></description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="executionName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="ExecutionName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string executionName, bool allowUnparsed, out ExecutionName result)
        {
            gax::GaxPreconditions.CheckNotNull(executionName, nameof(executionName));
            gax::TemplatedResourceName resourceName;
            if (s_projectLocationExecution.TryParseName(executionName, out resourceName))
            {
                result = FromProjectLocationExecution(resourceName[0], resourceName[1], resourceName[2]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(executionName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private ExecutionName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string executionId = null, string locationId = null, string projectId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            ExecutionId = executionId;
            LocationId = locationId;
            ProjectId = projectId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="ExecutionName"/> class from the component parts of pattern
        /// <c>projects/{project}/location/{location}/executions/{execution}</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="executionId">The <c>Execution</c> ID. Must not be <c>null</c> or empty.</param>
        public ExecutionName(string projectId, string locationId, string executionId) : this(ResourceNameType.ProjectLocationExecution, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), executionId: gax::GaxPreconditions.CheckNotNullOrEmpty(executionId, nameof(executionId)))
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
        /// The <c>Execution</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string ExecutionId { get; }

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
                case ResourceNameType.ProjectLocationExecution: return s_projectLocationExecution.Expand(ProjectId, LocationId, ExecutionId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as ExecutionName);

        /// <inheritdoc/>
        public bool Equals(ExecutionName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(ExecutionName a, ExecutionName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(ExecutionName a, ExecutionName b) => !(a == b);
    }

    /// <summary>Resource name for the <c>Tensorboard</c> resource.</summary>
    public sealed partial class TensorboardName : gax::IResourceName, sys::IEquatable<TensorboardName>
    {
        /// <summary>The possible contents of <see cref="TensorboardName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern <c>projects/{project}/locations/{location}/tensorboards/{tensorboard}</c>.
            /// </summary>
            ProjectLocationTensorboard = 1,
        }

        private static gax::PathTemplate s_projectLocationTensorboard = new gax::PathTemplate("projects/{project}/locations/{location}/tensorboards/{tensorboard}");

        /// <summary>Creates a <see cref="TensorboardName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="TensorboardName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static TensorboardName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new TensorboardName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="TensorboardName"/> with the pattern
        /// <c>projects/{project}/locations/{location}/tensorboards/{tensorboard}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="tensorboardId">The <c>Tensorboard</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="TensorboardName"/> constructed from the provided ids.</returns>
        public static TensorboardName FromProjectLocationTensorboard(string projectId, string locationId, string tensorboardId) =>
            new TensorboardName(ResourceNameType.ProjectLocationTensorboard, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), tensorboardId: gax::GaxPreconditions.CheckNotNullOrEmpty(tensorboardId, nameof(tensorboardId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="TensorboardName"/> with pattern
        /// <c>projects/{project}/locations/{location}/tensorboards/{tensorboard}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="tensorboardId">The <c>Tensorboard</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="TensorboardName"/> with pattern
        /// <c>projects/{project}/locations/{location}/tensorboards/{tensorboard}</c>.
        /// </returns>
        public static string Format(string projectId, string locationId, string tensorboardId) =>
            FormatProjectLocationTensorboard(projectId, locationId, tensorboardId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="TensorboardName"/> with pattern
        /// <c>projects/{project}/locations/{location}/tensorboards/{tensorboard}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="tensorboardId">The <c>Tensorboard</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="TensorboardName"/> with pattern
        /// <c>projects/{project}/locations/{location}/tensorboards/{tensorboard}</c>.
        /// </returns>
        public static string FormatProjectLocationTensorboard(string projectId, string locationId, string tensorboardId) =>
            s_projectLocationTensorboard.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(tensorboardId, nameof(tensorboardId)));

        /// <summary>Parses the given resource name string into a new <see cref="TensorboardName"/> instance.</summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>projects/{project}/locations/{location}/tensorboards/{tensorboard}</c></description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="tensorboardName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="TensorboardName"/> if successful.</returns>
        public static TensorboardName Parse(string tensorboardName) => Parse(tensorboardName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="TensorboardName"/> instance; optionally allowing
        /// an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>projects/{project}/locations/{location}/tensorboards/{tensorboard}</c></description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="tensorboardName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="TensorboardName"/> if successful.</returns>
        public static TensorboardName Parse(string tensorboardName, bool allowUnparsed) =>
            TryParse(tensorboardName, allowUnparsed, out TensorboardName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="TensorboardName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>projects/{project}/locations/{location}/tensorboards/{tensorboard}</c></description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="tensorboardName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="TensorboardName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string tensorboardName, out TensorboardName result) =>
            TryParse(tensorboardName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="TensorboardName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>projects/{project}/locations/{location}/tensorboards/{tensorboard}</c></description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="tensorboardName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="TensorboardName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string tensorboardName, bool allowUnparsed, out TensorboardName result)
        {
            gax::GaxPreconditions.CheckNotNull(tensorboardName, nameof(tensorboardName));
            gax::TemplatedResourceName resourceName;
            if (s_projectLocationTensorboard.TryParseName(tensorboardName, out resourceName))
            {
                result = FromProjectLocationTensorboard(resourceName[0], resourceName[1], resourceName[2]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(tensorboardName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private TensorboardName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string locationId = null, string projectId = null, string tensorboardId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            LocationId = locationId;
            ProjectId = projectId;
            TensorboardId = tensorboardId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="TensorboardName"/> class from the component parts of pattern
        /// <c>projects/{project}/locations/{location}/tensorboards/{tensorboard}</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="tensorboardId">The <c>Tensorboard</c> ID. Must not be <c>null</c> or empty.</param>
        public TensorboardName(string projectId, string locationId, string tensorboardId) : this(ResourceNameType.ProjectLocationTensorboard, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), tensorboardId: gax::GaxPreconditions.CheckNotNullOrEmpty(tensorboardId, nameof(tensorboardId)))
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
        /// The <c>Tensorboard</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string TensorboardId { get; }

        /// <summary>Whether this instance contains a resource name with a known pattern.</summary>
        public bool IsKnownPattern => Type != ResourceNameType.Unparsed;

        /// <summary>The string representation of the resource name.</summary>
        /// <returns>The string representation of the resource name.</returns>
        public override string ToString()
        {
            switch (Type)
            {
                case ResourceNameType.Unparsed: return UnparsedResource.ToString();
                case ResourceNameType.ProjectLocationTensorboard: return s_projectLocationTensorboard.Expand(ProjectId, LocationId, TensorboardId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as TensorboardName);

        /// <inheritdoc/>
        public bool Equals(TensorboardName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(TensorboardName a, TensorboardName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(TensorboardName a, TensorboardName b) => !(a == b);
    }

    public partial class ExecutionTemplate
    {
        /// <summary>
        /// <see cref="TensorboardName"/>-typed view over the <see cref="Tensorboard"/> resource name property.
        /// </summary>
        public TensorboardName TensorboardAsTensorboardName
        {
            get => string.IsNullOrEmpty(Tensorboard) ? null : TensorboardName.Parse(Tensorboard, allowUnparsed: true);
            set => Tensorboard = value?.ToString() ?? "";
        }
    }

    public partial class Execution
    {
        /// <summary>
        /// <see cref="gcnv::ExecutionName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcnv::ExecutionName ExecutionName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcnv::ExecutionName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }
}
