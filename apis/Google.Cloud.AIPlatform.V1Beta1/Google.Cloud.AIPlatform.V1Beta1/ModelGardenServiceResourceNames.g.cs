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
using gcav = Google.Cloud.AIPlatform.V1Beta1;
using sys = System;

namespace Google.Cloud.AIPlatform.V1Beta1
{
    public partial class GetPublisherModelRequest
    {
        /// <summary>
        /// <see cref="gcav::PublisherModelName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcav::PublisherModelName PublisherModelName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcav::PublisherModelName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class DeployRequest
    {
        /// <summary>
        /// <see cref="gcav::PublisherModelName"/>-typed view over the <see cref="PublisherModelName"/> resource name
        /// property.
        /// </summary>
        public gcav::PublisherModelName PublisherModelNameAsPublisherModelName
        {
            get => string.IsNullOrEmpty(PublisherModelName) ? null : gcav::PublisherModelName.Parse(PublisherModelName, allowUnparsed: true);
            set => PublisherModelName = value?.ToString() ?? "";
        }

        /// <summary>
        /// <see cref="gagr::LocationName"/>-typed view over the <see cref="Destination"/> resource name property.
        /// </summary>
        public gagr::LocationName DestinationAsLocationName
        {
            get => string.IsNullOrEmpty(Destination) ? null : gagr::LocationName.Parse(Destination, allowUnparsed: true);
            set => Destination = value?.ToString() ?? "";
        }
    }

    public partial class DeployPublisherModelRequest
    {
        /// <summary>
        /// <see cref="gagr::LocationName"/>-typed view over the <see cref="Destination"/> resource name property.
        /// </summary>
        [sys::ObsoleteAttribute]
        public gagr::LocationName DestinationAsLocationName
        {
            get => string.IsNullOrEmpty(Destination) ? null : gagr::LocationName.Parse(Destination, allowUnparsed: true);
            set => Destination = value?.ToString() ?? "";
        }
    }

    public partial class DeployResponse
    {
        /// <summary>
        /// <see cref="PublisherModelName"/>-typed view over the <see cref="PublisherModel"/> resource name property.
        /// </summary>
        public PublisherModelName PublisherModelAsPublisherModelName
        {
            get => string.IsNullOrEmpty(PublisherModel) ? null : PublisherModelName.Parse(PublisherModel, allowUnparsed: true);
            set => PublisherModel = value?.ToString() ?? "";
        }

        /// <summary>
        /// <see cref="EndpointName"/>-typed view over the <see cref="Endpoint"/> resource name property.
        /// </summary>
        public EndpointName EndpointAsEndpointName
        {
            get => string.IsNullOrEmpty(Endpoint) ? null : EndpointName.Parse(Endpoint, allowUnparsed: true);
            set => Endpoint = value?.ToString() ?? "";
        }

        /// <summary><see cref="ModelName"/>-typed view over the <see cref="Model"/> resource name property.</summary>
        public ModelName ModelAsModelName
        {
            get => string.IsNullOrEmpty(Model) ? null : ModelName.Parse(Model, allowUnparsed: true);
            set => Model = value?.ToString() ?? "";
        }
    }

    public partial class DeployPublisherModelResponse
    {
        /// <summary>
        /// <see cref="PublisherModelName"/>-typed view over the <see cref="PublisherModel"/> resource name property.
        /// </summary>
        [sys::ObsoleteAttribute]
        public PublisherModelName PublisherModelAsPublisherModelName
        {
            get => string.IsNullOrEmpty(PublisherModel) ? null : PublisherModelName.Parse(PublisherModel, allowUnparsed: true);
            set => PublisherModel = value?.ToString() ?? "";
        }

        /// <summary>
        /// <see cref="EndpointName"/>-typed view over the <see cref="Endpoint"/> resource name property.
        /// </summary>
        [sys::ObsoleteAttribute]
        public EndpointName EndpointAsEndpointName
        {
            get => string.IsNullOrEmpty(Endpoint) ? null : EndpointName.Parse(Endpoint, allowUnparsed: true);
            set => Endpoint = value?.ToString() ?? "";
        }

        /// <summary><see cref="ModelName"/>-typed view over the <see cref="Model"/> resource name property.</summary>
        [sys::ObsoleteAttribute]
        public ModelName ModelAsModelName
        {
            get => string.IsNullOrEmpty(Model) ? null : ModelName.Parse(Model, allowUnparsed: true);
            set => Model = value?.ToString() ?? "";
        }
    }

    public partial class DeployOperationMetadata
    {
        /// <summary>
        /// <see cref="PublisherModelName"/>-typed view over the <see cref="PublisherModel"/> resource name property.
        /// </summary>
        public PublisherModelName PublisherModelAsPublisherModelName
        {
            get => string.IsNullOrEmpty(PublisherModel) ? null : PublisherModelName.Parse(PublisherModel, allowUnparsed: true);
            set => PublisherModel = value?.ToString() ?? "";
        }

        /// <summary>
        /// <see cref="gagr::LocationName"/>-typed view over the <see cref="Destination"/> resource name property.
        /// </summary>
        public gagr::LocationName DestinationAsLocationName
        {
            get => string.IsNullOrEmpty(Destination) ? null : gagr::LocationName.Parse(Destination, allowUnparsed: true);
            set => Destination = value?.ToString() ?? "";
        }
    }

    public partial class DeployPublisherModelOperationMetadata
    {
        /// <summary>
        /// <see cref="PublisherModelName"/>-typed view over the <see cref="PublisherModel"/> resource name property.
        /// </summary>
        [sys::ObsoleteAttribute]
        public PublisherModelName PublisherModelAsPublisherModelName
        {
            get => string.IsNullOrEmpty(PublisherModel) ? null : PublisherModelName.Parse(PublisherModel, allowUnparsed: true);
            set => PublisherModel = value?.ToString() ?? "";
        }

        /// <summary>
        /// <see cref="gagr::LocationName"/>-typed view over the <see cref="Destination"/> resource name property.
        /// </summary>
        [sys::ObsoleteAttribute]
        public gagr::LocationName DestinationAsLocationName
        {
            get => string.IsNullOrEmpty(Destination) ? null : gagr::LocationName.Parse(Destination, allowUnparsed: true);
            set => Destination = value?.ToString() ?? "";
        }
    }
}
