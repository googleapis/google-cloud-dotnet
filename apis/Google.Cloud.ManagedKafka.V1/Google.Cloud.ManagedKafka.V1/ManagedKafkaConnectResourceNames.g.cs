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
using gagr = Google.Api.Gax.ResourceNames;
using gcmv = Google.Cloud.ManagedKafka.V1;

namespace Google.Cloud.ManagedKafka.V1
{
    public partial class GetConnectClusterRequest
    {
        /// <summary>
        /// <see cref="gcmv::ConnectClusterName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcmv::ConnectClusterName ConnectClusterName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcmv::ConnectClusterName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class CreateConnectClusterRequest
    {
        /// <summary>
        /// <see cref="gagr::LocationName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public gagr::LocationName ParentAsLocationName
        {
            get => string.IsNullOrEmpty(Parent) ? null : gagr::LocationName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class DeleteConnectClusterRequest
    {
        /// <summary>
        /// <see cref="gcmv::ConnectClusterName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcmv::ConnectClusterName ConnectClusterName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcmv::ConnectClusterName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class ListConnectClustersRequest
    {
        /// <summary>
        /// <see cref="gagr::LocationName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public gagr::LocationName ParentAsLocationName
        {
            get => string.IsNullOrEmpty(Parent) ? null : gagr::LocationName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class GetConnectorRequest
    {
        /// <summary>
        /// <see cref="gcmv::ConnectorName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcmv::ConnectorName ConnectorName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcmv::ConnectorName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class CreateConnectorRequest
    {
        /// <summary>
        /// <see cref="ConnectClusterName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public ConnectClusterName ParentAsConnectClusterName
        {
            get => string.IsNullOrEmpty(Parent) ? null : ConnectClusterName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class DeleteConnectorRequest
    {
        /// <summary>
        /// <see cref="gcmv::ConnectorName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcmv::ConnectorName ConnectorName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcmv::ConnectorName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class ListConnectorsRequest
    {
        /// <summary>
        /// <see cref="ConnectClusterName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public ConnectClusterName ParentAsConnectClusterName
        {
            get => string.IsNullOrEmpty(Parent) ? null : ConnectClusterName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class PauseConnectorRequest
    {
        /// <summary>
        /// <see cref="gcmv::ConnectorName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcmv::ConnectorName ConnectorName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcmv::ConnectorName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class ResumeConnectorRequest
    {
        /// <summary>
        /// <see cref="gcmv::ConnectorName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcmv::ConnectorName ConnectorName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcmv::ConnectorName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class RestartConnectorRequest
    {
        /// <summary>
        /// <see cref="gcmv::ConnectorName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcmv::ConnectorName ConnectorName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcmv::ConnectorName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class StopConnectorRequest
    {
        /// <summary>
        /// <see cref="gcmv::ConnectorName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcmv::ConnectorName ConnectorName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcmv::ConnectorName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }
}
