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
using gcdv = Google.Cloud.Datastream.V1Alpha1;

namespace Google.Cloud.Datastream.V1Alpha1
{
    public partial class DiscoverConnectionProfileRequest
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

    public partial class FetchStaticIpsRequest
    {
        /// <summary>
        /// <see cref="gagr::LocationName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gagr::LocationName LocationName
        {
            get => string.IsNullOrEmpty(Name) ? null : gagr::LocationName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class FetchErrorsRequest
    {
        /// <summary><see cref="StreamName"/>-typed view over the <see cref="Stream"/> resource name property.</summary>
        public StreamName StreamAsStreamName
        {
            get => string.IsNullOrEmpty(Stream) ? null : StreamName.Parse(Stream, allowUnparsed: true);
            set => Stream = value?.ToString() ?? "";
        }
    }

    public partial class ListConnectionProfilesRequest
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

    public partial class GetConnectionProfileRequest
    {
        /// <summary>
        /// <see cref="gcdv::ConnectionProfileName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcdv::ConnectionProfileName ConnectionProfileName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcdv::ConnectionProfileName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class CreateConnectionProfileRequest
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

    public partial class DeleteConnectionProfileRequest
    {
        /// <summary>
        /// <see cref="gcdv::ConnectionProfileName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcdv::ConnectionProfileName ConnectionProfileName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcdv::ConnectionProfileName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class ListStreamsRequest
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

    public partial class GetStreamRequest
    {
        /// <summary>
        /// <see cref="gcdv::StreamName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcdv::StreamName StreamName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcdv::StreamName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class CreateStreamRequest
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

    public partial class DeleteStreamRequest
    {
        /// <summary>
        /// <see cref="gcdv::StreamName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcdv::StreamName StreamName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcdv::StreamName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class CreatePrivateConnectionRequest
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

    public partial class ListPrivateConnectionsRequest
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

    public partial class DeletePrivateConnectionRequest
    {
        /// <summary>
        /// <see cref="gcdv::PrivateConnectionName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcdv::PrivateConnectionName PrivateConnectionName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcdv::PrivateConnectionName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class GetPrivateConnectionRequest
    {
        /// <summary>
        /// <see cref="gcdv::PrivateConnectionName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcdv::PrivateConnectionName PrivateConnectionName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcdv::PrivateConnectionName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class CreateRouteRequest
    {
        /// <summary>
        /// <see cref="PrivateConnectionName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public PrivateConnectionName ParentAsPrivateConnectionName
        {
            get => string.IsNullOrEmpty(Parent) ? null : PrivateConnectionName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class ListRoutesRequest
    {
        /// <summary>
        /// <see cref="PrivateConnectionName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public PrivateConnectionName ParentAsPrivateConnectionName
        {
            get => string.IsNullOrEmpty(Parent) ? null : PrivateConnectionName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class DeleteRouteRequest
    {
        /// <summary>
        /// <see cref="gcdv::RouteName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcdv::RouteName RouteName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcdv::RouteName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class GetRouteRequest
    {
        /// <summary>
        /// <see cref="gcdv::RouteName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcdv::RouteName RouteName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcdv::RouteName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }
}
