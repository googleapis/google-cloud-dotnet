// Copyright 2018 Google LLC
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
using gaxres = Google.Api.Gax.ResourceNames;
using gcscv = Google.Cloud.Spanner.Common.V1;
using sys = System;
using linq = System.Linq;

namespace Google.Cloud.Spanner.Admin.Instance.V1
{
    /// <summary>
    /// Resource name for the 'instance_config' resource.
    /// </summary>
    public sealed partial class InstanceConfigName : gax::IResourceName, sys::IEquatable<InstanceConfigName>
    {
        private static readonly gax::PathTemplate s_template = new gax::PathTemplate("projects/{project}/instanceConfigs/{instance_config}");

        /// <summary>
        /// Parses the given instance_config resource name in string form into a new
        /// <see cref="InstanceConfigName"/> instance.
        /// </summary>
        /// <param name="instanceConfigName">The instance_config resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="InstanceConfigName"/> if successful.</returns>
        public static InstanceConfigName Parse(string instanceConfigName)
        {
            gax::GaxPreconditions.CheckNotNull(instanceConfigName, nameof(instanceConfigName));
            gax::TemplatedResourceName resourceName = s_template.ParseName(instanceConfigName);
            return new InstanceConfigName(resourceName[0], resourceName[1]);
        }

        /// <summary>
        /// Tries to parse the given instance_config resource name in string form into a new
        /// <see cref="InstanceConfigName"/> instance.
        /// </summary>
        /// <remarks>
        /// This method still throws <see cref="sys::ArgumentNullException"/> if <paramref name="instanceConfigName"/> is null,
        /// as this would usually indicate a programming error rather than a data error.
        /// </remarks>
        /// <param name="instanceConfigName">The instance_config resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">When this method returns, the parsed <see cref="InstanceConfigName"/>,
        /// or <c>null</c> if parsing fails.</param>
        /// <returns><c>true</c> if the name was parsed succssfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string instanceConfigName, out InstanceConfigName result)
        {
            gax::GaxPreconditions.CheckNotNull(instanceConfigName, nameof(instanceConfigName));
            gax::TemplatedResourceName resourceName;
            if (s_template.TryParseName(instanceConfigName, out resourceName))
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

        /// <summary>
        /// Constructs a new instance of the <see cref="InstanceConfigName"/> resource name class
        /// from its component parts.
        /// </summary>
        /// <param name="projectId">The project ID. Must not be <c>null</c>.</param>
        /// <param name="instanceConfigId">The instanceConfig ID. Must not be <c>null</c>.</param>
        public InstanceConfigName(string projectId, string instanceConfigId)
        {
            ProjectId = gax::GaxPreconditions.CheckNotNull(projectId, nameof(projectId));
            InstanceConfigId = gax::GaxPreconditions.CheckNotNull(instanceConfigId, nameof(instanceConfigId));
        }

        /// <summary>
        /// The project ID. Never <c>null</c>.
        /// </summary>
        public string ProjectId { get; }

        /// <summary>
        /// The instanceConfig ID. Never <c>null</c>.
        /// </summary>
        public string InstanceConfigId { get; }

        /// <inheritdoc />
        public gax::ResourceNameKind Kind => gax::ResourceNameKind.Simple;

        /// <inheritdoc />
        public override string ToString() => s_template.Expand(ProjectId, InstanceConfigId);

        /// <inheritdoc />
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc />
        public override bool Equals(object obj) => Equals(obj as InstanceConfigName);

        /// <inheritdoc />
        public bool Equals(InstanceConfigName other) => ToString() == other?.ToString();

        /// <inheritdoc />
        public static bool operator ==(InstanceConfigName a, InstanceConfigName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <inheritdoc />
        public static bool operator !=(InstanceConfigName a, InstanceConfigName b) => !(a == b);
    }


    public partial class CreateInstanceRequest
    {
        /// <summary>
        /// <see cref="gaxres::ProjectName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public gaxres::ProjectName ParentAsProjectName
        {
            get { return string.IsNullOrEmpty(Parent) ? null : gaxres::ProjectName.Parse(Parent); }
            set { Parent = value != null ? value.ToString() : ""; }
        }

        /// <summary>
        /// <see cref="gcscv::InstanceName"/>-typed view over the <see cref="InstanceId"/> resource name property.
        /// </summary>
        public gcscv::InstanceName InstanceIdAsInstanceName
        {
            get { return string.IsNullOrEmpty(InstanceId) ? null : gcscv::InstanceName.Parse(InstanceId); }
            set { InstanceId = value != null ? value.ToString() : ""; }
        }

    }

    public partial class DeleteInstanceRequest
    {
        /// <summary>
        /// <see cref="gcscv::InstanceName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcscv::InstanceName InstanceName
        {
            get { return string.IsNullOrEmpty(Name) ? null : gcscv::InstanceName.Parse(Name); }
            set { Name = value != null ? value.ToString() : ""; }
        }

    }

    public partial class GetInstanceConfigRequest
    {
        /// <summary>
        /// <see cref="Google.Cloud.Spanner.Admin.Instance.V1.InstanceConfigName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public Google.Cloud.Spanner.Admin.Instance.V1.InstanceConfigName InstanceConfigName
        {
            get { return string.IsNullOrEmpty(Name) ? null : Google.Cloud.Spanner.Admin.Instance.V1.InstanceConfigName.Parse(Name); }
            set { Name = value != null ? value.ToString() : ""; }
        }

    }

    public partial class GetInstanceRequest
    {
        /// <summary>
        /// <see cref="gcscv::InstanceName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcscv::InstanceName InstanceName
        {
            get { return string.IsNullOrEmpty(Name) ? null : gcscv::InstanceName.Parse(Name); }
            set { Name = value != null ? value.ToString() : ""; }
        }

    }

    public partial class Instance
    {
        /// <summary>
        /// <see cref="gcscv::InstanceName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcscv::InstanceName InstanceName
        {
            get { return string.IsNullOrEmpty(Name) ? null : gcscv::InstanceName.Parse(Name); }
            set { Name = value != null ? value.ToString() : ""; }
        }

        /// <summary>
        /// <see cref="Google.Cloud.Spanner.Admin.Instance.V1.InstanceConfigName"/>-typed view over the <see cref="Config"/> resource name property.
        /// </summary>
        public Google.Cloud.Spanner.Admin.Instance.V1.InstanceConfigName ConfigAsInstanceConfigName
        {
            get { return string.IsNullOrEmpty(Config) ? null : Google.Cloud.Spanner.Admin.Instance.V1.InstanceConfigName.Parse(Config); }
            set { Config = value != null ? value.ToString() : ""; }
        }

    }

    public partial class InstanceConfig
    {
        /// <summary>
        /// <see cref="Google.Cloud.Spanner.Admin.Instance.V1.InstanceConfigName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public Google.Cloud.Spanner.Admin.Instance.V1.InstanceConfigName InstanceConfigName
        {
            get { return string.IsNullOrEmpty(Name) ? null : Google.Cloud.Spanner.Admin.Instance.V1.InstanceConfigName.Parse(Name); }
            set { Name = value != null ? value.ToString() : ""; }
        }

    }

    public partial class ListInstanceConfigsRequest
    {
        /// <summary>
        /// <see cref="gaxres::ProjectName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public gaxres::ProjectName ParentAsProjectName
        {
            get { return string.IsNullOrEmpty(Parent) ? null : gaxres::ProjectName.Parse(Parent); }
            set { Parent = value != null ? value.ToString() : ""; }
        }

    }

    public partial class ListInstancesRequest
    {
        /// <summary>
        /// <see cref="gaxres::ProjectName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public gaxres::ProjectName ParentAsProjectName
        {
            get { return string.IsNullOrEmpty(Parent) ? null : gaxres::ProjectName.Parse(Parent); }
            set { Parent = value != null ? value.ToString() : ""; }
        }

    }

}