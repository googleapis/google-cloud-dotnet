// Copyright 2019 Google LLC
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

using gax = Google.Api.Gax;
using gagr = Google.Api.Gax.ResourceNames;
using gcsaiv = Google.Cloud.Spanner.Admin.Instance.V1;
using gcscv = Google.Cloud.Spanner.Common.V1;
using sys = System;

namespace Google.Cloud.Spanner.Admin.Instance.V1
{
    /// <summary>Resource name for the <c>InstanceConfig</c> resource.</summary>
    public sealed partial class InstanceConfigName : gax::IResourceName, sys::IEquatable<InstanceConfigName>
    {
        private static readonly gax::PathTemplate s_template = new gax::PathTemplate("projects/{project}/instanceConfigs/{instance_config}");

        /// <summary>
        /// Parses the given <c>InstanceConfig</c> resource name in string form into a new
        /// <see cref="InstanceConfigName"/> instance.
        /// </summary>
        /// <param name="instanceConfigName">
        /// The <c>InstanceConfig</c> resource name in string form. Must not be <c>null</c>.
        /// </param>
        /// <returns>The parsed <see cref="InstanceConfigName"/> if successful.</returns>
        public static InstanceConfigName Parse(string instanceConfigName)
        {
            gax::GaxPreconditions.CheckNotNull(instanceConfigName, nameof(instanceConfigName));
            gax::TemplatedResourceName resourceName = s_template.ParseName(instanceConfigName);
            return new InstanceConfigName(resourceName[0], resourceName[1]);
        }

        /// <summary>
        /// Tries to parse the given session resource name in string form into a new <see cref="InstanceConfigName"/>
        /// instance.
        /// </summary>
        /// <remarks>
        /// This method still throws <see cref="sys::ArgumentNullException"/> if <paramref name="instanceConfigName"/>
        /// is <c>null</c>, as this would usually indicate a programming error rather than a data error.
        /// </remarks>
        /// <param name="instanceConfigName">
        /// The <c>InstanceConfig</c> resource name in string form. Must not be <c>null</c>.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="InstanceConfigName"/>, or <c>null</c> if parsing fails.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string instanceConfigName, out InstanceConfigName result)
        {
            gax::GaxPreconditions.CheckNotNull(instanceConfigName, nameof(instanceConfigName));
            if (s_template.TryParseName(instanceConfigName, out gax::TemplatedResourceName resourceName))
            {
                result = new InstanceConfigName(resourceName[0], resourceName[1]);
                return true;
            }
            else
            {
                result = null;
                return false;
            }
        }

        /// <summary>Formats the IDs into the string representation of the <see cref="InstanceConfigName"/>.</summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c>.</param>
        /// <param name="instanceConfigId">The <c>InstanceConfig</c> ID. Must not be <c>null</c>.</param>
        /// <returns>The string representation of the <see cref="InstanceConfigName"/>.</returns>
        public static string Format(string projectId, string instanceConfigId) =>
            s_template.Expand(gax::GaxPreconditions.CheckNotNull(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNull(instanceConfigId, nameof(instanceConfigId)));

        /// <summary>
        /// Constructs a new instance of the <see cref="InstanceConfigName"/> resource name class from its component
        /// parts.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c>.</param>
        /// <param name="instanceConfigId">The <c>InstanceConfig</c> ID. Must not be <c>null</c>.</param>
        public InstanceConfigName(string projectId, string instanceConfigId)
        {
            ProjectId = gax::GaxPreconditions.CheckNotNull(projectId, nameof(projectId));
            InstanceConfigId = gax::GaxPreconditions.CheckNotNull(instanceConfigId, nameof(instanceConfigId));
        }

        /// <summary>The <c>Project</c> ID. Never <c>null</c>.</summary>
        public string ProjectId { get; }

        /// <summary>The <c>InstanceConfig</c> ID. Never <c>null</c>.</summary>
        public string InstanceConfigId { get; }

        /// <inheritdoc/>
        public gax::ResourceNameKind Kind => gax::ResourceNameKind.Simple;

        /// <inheritdoc/>
        public override string ToString() => s_template.Expand(ProjectId, InstanceConfigId);

        /// <inheritdoc/>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as InstanceConfigName);

        /// <inheritdoc/>
        public bool Equals(InstanceConfigName other) => ToString() == other?.ToString();

        /// <inheritdoc/>
        public static bool operator ==(InstanceConfigName a, InstanceConfigName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <inheritdoc/>
        public static bool operator !=(InstanceConfigName a, InstanceConfigName b) => !(a == b);
    }

    public partial class InstanceConfig
    {
        /// <summary>
        /// <see cref="gcsaiv::InstanceConfigName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcsaiv::InstanceConfigName InstanceConfigName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcsaiv::InstanceConfigName.Parse(Name);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class Instance
    {
        /// <summary>
        /// <see cref="gcscv::InstanceName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcscv::InstanceName InstanceName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcscv::InstanceName.Parse(Name);
            set => Name = value?.ToString() ?? "";
        }

        /// <summary>
        /// <see cref="InstanceConfigName"/>-typed view over the <see cref="Config"/> resource name property.
        /// </summary>
        public InstanceConfigName ConfigAsInstanceConfigName
        {
            get => string.IsNullOrEmpty(Config) ? null : InstanceConfigName.Parse(Config);
            set => Config = value?.ToString() ?? "";
        }
    }

    public partial class ListInstanceConfigsRequest
    {
        /// <summary>
        /// <see cref="gagr::ProjectName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public gagr::ProjectName ParentAsProjectName
        {
            get => string.IsNullOrEmpty(Parent) ? null : gagr::ProjectName.Parse(Parent);
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class GetInstanceConfigRequest
    {
        /// <summary>
        /// <see cref="gcsaiv::InstanceConfigName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcsaiv::InstanceConfigName InstanceConfigName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcsaiv::InstanceConfigName.Parse(Name);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class GetInstanceRequest
    {
        /// <summary>
        /// <see cref="gcscv::InstanceName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcscv::InstanceName InstanceName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcscv::InstanceName.Parse(Name);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class CreateInstanceRequest
    {
        /// <summary>
        /// <see cref="gagr::ProjectName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public gagr::ProjectName ParentAsProjectName
        {
            get => string.IsNullOrEmpty(Parent) ? null : gagr::ProjectName.Parse(Parent);
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class ListInstancesRequest
    {
        /// <summary>
        /// <see cref="gagr::ProjectName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public gagr::ProjectName ParentAsProjectName
        {
            get => string.IsNullOrEmpty(Parent) ? null : gagr::ProjectName.Parse(Parent);
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class DeleteInstanceRequest
    {
        /// <summary>
        /// <see cref="gcscv::InstanceName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcscv::InstanceName InstanceName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcscv::InstanceName.Parse(Name);
            set => Name = value?.ToString() ?? "";
        }
    }
}
