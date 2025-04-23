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
using gcfv = Google.Cloud.FinancialServices.V1;
using sys = System;

namespace Google.Cloud.FinancialServices.V1
{
    /// <summary>Resource name for the <c>BacktestResult</c> resource.</summary>
    public sealed partial class BacktestResultName : gax::IResourceName, sys::IEquatable<BacktestResultName>
    {
        /// <summary>The possible contents of <see cref="BacktestResultName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern
            /// <c>projects/{project_num}/locations/{location}/instances/{instance}/backtestResults/{backtest_result}</c>
            /// .
            /// </summary>
            ProjectNumLocationInstanceBacktestResult = 1,
        }

        private static gax::PathTemplate s_projectNumLocationInstanceBacktestResult = new gax::PathTemplate("projects/{project_num}/locations/{location}/instances/{instance}/backtestResults/{backtest_result}");

        /// <summary>Creates a <see cref="BacktestResultName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="BacktestResultName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static BacktestResultName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new BacktestResultName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="BacktestResultName"/> with the pattern
        /// <c>projects/{project_num}/locations/{location}/instances/{instance}/backtestResults/{backtest_result}</c>.
        /// </summary>
        /// <param name="projectNumId">The <c>ProjectNum</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="instanceId">The <c>Instance</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="backtestResultId">The <c>BacktestResult</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="BacktestResultName"/> constructed from the provided ids.</returns>
        public static BacktestResultName FromProjectNumLocationInstanceBacktestResult(string projectNumId, string locationId, string instanceId, string backtestResultId) =>
            new BacktestResultName(ResourceNameType.ProjectNumLocationInstanceBacktestResult, projectNumId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectNumId, nameof(projectNumId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), instanceId: gax::GaxPreconditions.CheckNotNullOrEmpty(instanceId, nameof(instanceId)), backtestResultId: gax::GaxPreconditions.CheckNotNullOrEmpty(backtestResultId, nameof(backtestResultId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="BacktestResultName"/> with pattern
        /// <c>projects/{project_num}/locations/{location}/instances/{instance}/backtestResults/{backtest_result}</c>.
        /// </summary>
        /// <param name="projectNumId">The <c>ProjectNum</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="instanceId">The <c>Instance</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="backtestResultId">The <c>BacktestResult</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="BacktestResultName"/> with pattern
        /// <c>projects/{project_num}/locations/{location}/instances/{instance}/backtestResults/{backtest_result}</c>.
        /// </returns>
        public static string Format(string projectNumId, string locationId, string instanceId, string backtestResultId) =>
            FormatProjectNumLocationInstanceBacktestResult(projectNumId, locationId, instanceId, backtestResultId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="BacktestResultName"/> with pattern
        /// <c>projects/{project_num}/locations/{location}/instances/{instance}/backtestResults/{backtest_result}</c>.
        /// </summary>
        /// <param name="projectNumId">The <c>ProjectNum</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="instanceId">The <c>Instance</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="backtestResultId">The <c>BacktestResult</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="BacktestResultName"/> with pattern
        /// <c>projects/{project_num}/locations/{location}/instances/{instance}/backtestResults/{backtest_result}</c>.
        /// </returns>
        public static string FormatProjectNumLocationInstanceBacktestResult(string projectNumId, string locationId, string instanceId, string backtestResultId) =>
            s_projectNumLocationInstanceBacktestResult.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectNumId, nameof(projectNumId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(instanceId, nameof(instanceId)), gax::GaxPreconditions.CheckNotNullOrEmpty(backtestResultId, nameof(backtestResultId)));

        /// <summary>
        /// Parses the given resource name string into a new <see cref="BacktestResultName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project_num}/locations/{location}/instances/{instance}/backtestResults/{backtest_result}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="backtestResultName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="BacktestResultName"/> if successful.</returns>
        public static BacktestResultName Parse(string backtestResultName) => Parse(backtestResultName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="BacktestResultName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project_num}/locations/{location}/instances/{instance}/backtestResults/{backtest_result}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="backtestResultName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="BacktestResultName"/> if successful.</returns>
        public static BacktestResultName Parse(string backtestResultName, bool allowUnparsed) =>
            TryParse(backtestResultName, allowUnparsed, out BacktestResultName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="BacktestResultName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project_num}/locations/{location}/instances/{instance}/backtestResults/{backtest_result}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="backtestResultName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="BacktestResultName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string backtestResultName, out BacktestResultName result) =>
            TryParse(backtestResultName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="BacktestResultName"/> instance;
        /// optionally allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project_num}/locations/{location}/instances/{instance}/backtestResults/{backtest_result}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="backtestResultName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="BacktestResultName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string backtestResultName, bool allowUnparsed, out BacktestResultName result)
        {
            gax::GaxPreconditions.CheckNotNull(backtestResultName, nameof(backtestResultName));
            gax::TemplatedResourceName resourceName;
            if (s_projectNumLocationInstanceBacktestResult.TryParseName(backtestResultName, out resourceName))
            {
                result = FromProjectNumLocationInstanceBacktestResult(resourceName[0], resourceName[1], resourceName[2], resourceName[3]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(backtestResultName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private BacktestResultName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string backtestResultId = null, string instanceId = null, string locationId = null, string projectNumId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            BacktestResultId = backtestResultId;
            InstanceId = instanceId;
            LocationId = locationId;
            ProjectNumId = projectNumId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="BacktestResultName"/> class from the component parts of pattern
        /// <c>projects/{project_num}/locations/{location}/instances/{instance}/backtestResults/{backtest_result}</c>
        /// </summary>
        /// <param name="projectNumId">The <c>ProjectNum</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="instanceId">The <c>Instance</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="backtestResultId">The <c>BacktestResult</c> ID. Must not be <c>null</c> or empty.</param>
        public BacktestResultName(string projectNumId, string locationId, string instanceId, string backtestResultId) : this(ResourceNameType.ProjectNumLocationInstanceBacktestResult, projectNumId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectNumId, nameof(projectNumId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), instanceId: gax::GaxPreconditions.CheckNotNullOrEmpty(instanceId, nameof(instanceId)), backtestResultId: gax::GaxPreconditions.CheckNotNullOrEmpty(backtestResultId, nameof(backtestResultId)))
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
        /// The <c>BacktestResult</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource
        /// name.
        /// </summary>
        public string BacktestResultId { get; }

        /// <summary>
        /// The <c>Instance</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string InstanceId { get; }

        /// <summary>
        /// The <c>Location</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string LocationId { get; }

        /// <summary>
        /// The <c>ProjectNum</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string ProjectNumId { get; }

        /// <summary>Whether this instance contains a resource name with a known pattern.</summary>
        public bool IsKnownPattern => Type != ResourceNameType.Unparsed;

        /// <summary>The string representation of the resource name.</summary>
        /// <returns>The string representation of the resource name.</returns>
        public override string ToString()
        {
            switch (Type)
            {
                case ResourceNameType.Unparsed: return UnparsedResource.ToString();
                case ResourceNameType.ProjectNumLocationInstanceBacktestResult: return s_projectNumLocationInstanceBacktestResult.Expand(ProjectNumId, LocationId, InstanceId, BacktestResultId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as BacktestResultName);

        /// <inheritdoc/>
        public bool Equals(BacktestResultName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(BacktestResultName a, BacktestResultName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(BacktestResultName a, BacktestResultName b) => !(a == b);
    }

    public partial class BacktestResult
    {
        /// <summary>
        /// <see cref="gcfv::BacktestResultName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcfv::BacktestResultName BacktestResultName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcfv::BacktestResultName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }

        /// <summary>
        /// <see cref="DatasetName"/>-typed view over the <see cref="Dataset"/> resource name property.
        /// </summary>
        public DatasetName DatasetAsDatasetName
        {
            get => string.IsNullOrEmpty(Dataset) ? null : DatasetName.Parse(Dataset, allowUnparsed: true);
            set => Dataset = value?.ToString() ?? "";
        }

        /// <summary><see cref="ModelName"/>-typed view over the <see cref="Model"/> resource name property.</summary>
        public ModelName ModelAsModelName
        {
            get => string.IsNullOrEmpty(Model) ? null : ModelName.Parse(Model, allowUnparsed: true);
            set => Model = value?.ToString() ?? "";
        }
    }

    public partial class ListBacktestResultsRequest
    {
        /// <summary>
        /// <see cref="InstanceName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public InstanceName ParentAsInstanceName
        {
            get => string.IsNullOrEmpty(Parent) ? null : InstanceName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class GetBacktestResultRequest
    {
        /// <summary>
        /// <see cref="gcfv::BacktestResultName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcfv::BacktestResultName BacktestResultName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcfv::BacktestResultName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class CreateBacktestResultRequest
    {
        /// <summary>
        /// <see cref="InstanceName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public InstanceName ParentAsInstanceName
        {
            get => string.IsNullOrEmpty(Parent) ? null : InstanceName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class DeleteBacktestResultRequest
    {
        /// <summary>
        /// <see cref="gcfv::BacktestResultName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcfv::BacktestResultName BacktestResultName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcfv::BacktestResultName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class ExportBacktestResultMetadataRequest
    {
        /// <summary>
        /// <see cref="BacktestResultName"/>-typed view over the <see cref="BacktestResult"/> resource name property.
        /// </summary>
        public BacktestResultName BacktestResultAsBacktestResultName
        {
            get => string.IsNullOrEmpty(BacktestResult) ? null : BacktestResultName.Parse(BacktestResult, allowUnparsed: true);
            set => BacktestResult = value?.ToString() ?? "";
        }
    }
}
