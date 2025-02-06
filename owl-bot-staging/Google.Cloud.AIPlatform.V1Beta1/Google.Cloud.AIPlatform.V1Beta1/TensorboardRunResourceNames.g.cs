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
using gcav = Google.Cloud.AIPlatform.V1Beta1;
using sys = System;

namespace Google.Cloud.AIPlatform.V1Beta1
{
    /// <summary>Resource name for the <c>TensorboardRun</c> resource.</summary>
    public sealed partial class TensorboardRunName : gax::IResourceName, sys::IEquatable<TensorboardRunName>
    {
        /// <summary>The possible contents of <see cref="TensorboardRunName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern
            /// <c>
            /// projects/{project}/locations/{location}/tensorboards/{tensorboard}/experiments/{experiment}/runs/{run}</c>
            /// .
            /// </summary>
            ProjectLocationTensorboardExperimentRun = 1,
        }

        private static gax::PathTemplate s_projectLocationTensorboardExperimentRun = new gax::PathTemplate("projects/{project}/locations/{location}/tensorboards/{tensorboard}/experiments/{experiment}/runs/{run}");

        /// <summary>Creates a <see cref="TensorboardRunName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="TensorboardRunName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static TensorboardRunName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new TensorboardRunName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="TensorboardRunName"/> with the pattern
        /// <c>projects/{project}/locations/{location}/tensorboards/{tensorboard}/experiments/{experiment}/runs/{run}</c>
        /// .
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="tensorboardId">The <c>Tensorboard</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="experimentId">The <c>Experiment</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="runId">The <c>Run</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="TensorboardRunName"/> constructed from the provided ids.</returns>
        public static TensorboardRunName FromProjectLocationTensorboardExperimentRun(string projectId, string locationId, string tensorboardId, string experimentId, string runId) =>
            new TensorboardRunName(ResourceNameType.ProjectLocationTensorboardExperimentRun, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), tensorboardId: gax::GaxPreconditions.CheckNotNullOrEmpty(tensorboardId, nameof(tensorboardId)), experimentId: gax::GaxPreconditions.CheckNotNullOrEmpty(experimentId, nameof(experimentId)), runId: gax::GaxPreconditions.CheckNotNullOrEmpty(runId, nameof(runId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="TensorboardRunName"/> with pattern
        /// <c>projects/{project}/locations/{location}/tensorboards/{tensorboard}/experiments/{experiment}/runs/{run}</c>
        /// .
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="tensorboardId">The <c>Tensorboard</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="experimentId">The <c>Experiment</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="runId">The <c>Run</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="TensorboardRunName"/> with pattern
        /// <c>projects/{project}/locations/{location}/tensorboards/{tensorboard}/experiments/{experiment}/runs/{run}</c>
        /// .
        /// </returns>
        public static string Format(string projectId, string locationId, string tensorboardId, string experimentId, string runId) =>
            FormatProjectLocationTensorboardExperimentRun(projectId, locationId, tensorboardId, experimentId, runId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="TensorboardRunName"/> with pattern
        /// <c>projects/{project}/locations/{location}/tensorboards/{tensorboard}/experiments/{experiment}/runs/{run}</c>
        /// .
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="tensorboardId">The <c>Tensorboard</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="experimentId">The <c>Experiment</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="runId">The <c>Run</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="TensorboardRunName"/> with pattern
        /// <c>projects/{project}/locations/{location}/tensorboards/{tensorboard}/experiments/{experiment}/runs/{run}</c>
        /// .
        /// </returns>
        public static string FormatProjectLocationTensorboardExperimentRun(string projectId, string locationId, string tensorboardId, string experimentId, string runId) =>
            s_projectLocationTensorboardExperimentRun.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(tensorboardId, nameof(tensorboardId)), gax::GaxPreconditions.CheckNotNullOrEmpty(experimentId, nameof(experimentId)), gax::GaxPreconditions.CheckNotNullOrEmpty(runId, nameof(runId)));

        /// <summary>
        /// Parses the given resource name string into a new <see cref="TensorboardRunName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/tensorboards/{tensorboard}/experiments/{experiment}/runs/{run}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="tensorboardRunName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="TensorboardRunName"/> if successful.</returns>
        public static TensorboardRunName Parse(string tensorboardRunName) => Parse(tensorboardRunName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="TensorboardRunName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/tensorboards/{tensorboard}/experiments/{experiment}/runs/{run}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="tensorboardRunName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="TensorboardRunName"/> if successful.</returns>
        public static TensorboardRunName Parse(string tensorboardRunName, bool allowUnparsed) =>
            TryParse(tensorboardRunName, allowUnparsed, out TensorboardRunName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="TensorboardRunName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/tensorboards/{tensorboard}/experiments/{experiment}/runs/{run}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="tensorboardRunName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="TensorboardRunName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string tensorboardRunName, out TensorboardRunName result) =>
            TryParse(tensorboardRunName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="TensorboardRunName"/> instance;
        /// optionally allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/tensorboards/{tensorboard}/experiments/{experiment}/runs/{run}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="tensorboardRunName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="TensorboardRunName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string tensorboardRunName, bool allowUnparsed, out TensorboardRunName result)
        {
            gax::GaxPreconditions.CheckNotNull(tensorboardRunName, nameof(tensorboardRunName));
            gax::TemplatedResourceName resourceName;
            if (s_projectLocationTensorboardExperimentRun.TryParseName(tensorboardRunName, out resourceName))
            {
                result = FromProjectLocationTensorboardExperimentRun(resourceName[0], resourceName[1], resourceName[2], resourceName[3], resourceName[4]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(tensorboardRunName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private TensorboardRunName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string experimentId = null, string locationId = null, string projectId = null, string runId = null, string tensorboardId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            ExperimentId = experimentId;
            LocationId = locationId;
            ProjectId = projectId;
            RunId = runId;
            TensorboardId = tensorboardId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="TensorboardRunName"/> class from the component parts of pattern
        /// <c>projects/{project}/locations/{location}/tensorboards/{tensorboard}/experiments/{experiment}/runs/{run}</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="tensorboardId">The <c>Tensorboard</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="experimentId">The <c>Experiment</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="runId">The <c>Run</c> ID. Must not be <c>null</c> or empty.</param>
        public TensorboardRunName(string projectId, string locationId, string tensorboardId, string experimentId, string runId) : this(ResourceNameType.ProjectLocationTensorboardExperimentRun, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), tensorboardId: gax::GaxPreconditions.CheckNotNullOrEmpty(tensorboardId, nameof(tensorboardId)), experimentId: gax::GaxPreconditions.CheckNotNullOrEmpty(experimentId, nameof(experimentId)), runId: gax::GaxPreconditions.CheckNotNullOrEmpty(runId, nameof(runId)))
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
        /// The <c>Experiment</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string ExperimentId { get; }

        /// <summary>
        /// The <c>Location</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string LocationId { get; }

        /// <summary>
        /// The <c>Project</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string ProjectId { get; }

        /// <summary>
        /// The <c>Run</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string RunId { get; }

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
                case ResourceNameType.ProjectLocationTensorboardExperimentRun: return s_projectLocationTensorboardExperimentRun.Expand(ProjectId, LocationId, TensorboardId, ExperimentId, RunId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as TensorboardRunName);

        /// <inheritdoc/>
        public bool Equals(TensorboardRunName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(TensorboardRunName a, TensorboardRunName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(TensorboardRunName a, TensorboardRunName b) => !(a == b);
    }

    public partial class TensorboardRun
    {
        /// <summary>
        /// <see cref="gcav::TensorboardRunName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcav::TensorboardRunName TensorboardRunName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcav::TensorboardRunName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }
}
