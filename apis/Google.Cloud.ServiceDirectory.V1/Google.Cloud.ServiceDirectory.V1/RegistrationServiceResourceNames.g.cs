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
using gcsv = Google.Cloud.ServiceDirectory.V1;

namespace Google.Cloud.ServiceDirectory.V1
{
    public partial class CreateNamespaceRequest
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

    public partial class ListNamespacesRequest
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

    public partial class GetNamespaceRequest
    {
        /// <summary>
        /// <see cref="gcsv::NamespaceName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcsv::NamespaceName NamespaceName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcsv::NamespaceName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class DeleteNamespaceRequest
    {
        /// <summary>
        /// <see cref="gcsv::NamespaceName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcsv::NamespaceName NamespaceName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcsv::NamespaceName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class CreateServiceRequest
    {
        /// <summary>
        /// <see cref="NamespaceName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public NamespaceName ParentAsNamespaceName
        {
            get => string.IsNullOrEmpty(Parent) ? null : NamespaceName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class ListServicesRequest
    {
        /// <summary>
        /// <see cref="NamespaceName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public NamespaceName ParentAsNamespaceName
        {
            get => string.IsNullOrEmpty(Parent) ? null : NamespaceName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class GetServiceRequest
    {
        /// <summary>
        /// <see cref="gcsv::ServiceName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcsv::ServiceName ServiceName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcsv::ServiceName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class DeleteServiceRequest
    {
        /// <summary>
        /// <see cref="gcsv::ServiceName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcsv::ServiceName ServiceName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcsv::ServiceName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class CreateEndpointRequest
    {
        /// <summary>
        /// <see cref="ServiceName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public ServiceName ParentAsServiceName
        {
            get => string.IsNullOrEmpty(Parent) ? null : ServiceName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class ListEndpointsRequest
    {
        /// <summary>
        /// <see cref="ServiceName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public ServiceName ParentAsServiceName
        {
            get => string.IsNullOrEmpty(Parent) ? null : ServiceName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class GetEndpointRequest
    {
        /// <summary>
        /// <see cref="gcsv::EndpointName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcsv::EndpointName EndpointName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcsv::EndpointName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class DeleteEndpointRequest
    {
        /// <summary>
        /// <see cref="gcsv::EndpointName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcsv::EndpointName EndpointName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcsv::EndpointName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }
}
