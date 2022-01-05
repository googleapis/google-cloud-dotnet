// Copyright 2022 Google LLC
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

using gagr = Google.Api.Gax.ResourceNames;
using gciv = Google.Cloud.Iot.V1;

namespace Google.Cloud.Iot.V1
{
    public partial class CreateDeviceRegistryRequest
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

    public partial class GetDeviceRegistryRequest
    {
        /// <summary>
        /// <see cref="gciv::RegistryName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gciv::RegistryName RegistryName
        {
            get => string.IsNullOrEmpty(Name) ? null : gciv::RegistryName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class DeleteDeviceRegistryRequest
    {
        /// <summary>
        /// <see cref="gciv::RegistryName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gciv::RegistryName RegistryName
        {
            get => string.IsNullOrEmpty(Name) ? null : gciv::RegistryName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class ListDeviceRegistriesRequest
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

    public partial class CreateDeviceRequest
    {
        /// <summary>
        /// <see cref="RegistryName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public RegistryName ParentAsRegistryName
        {
            get => string.IsNullOrEmpty(Parent) ? null : RegistryName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class GetDeviceRequest
    {
        /// <summary>
        /// <see cref="gciv::DeviceName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gciv::DeviceName DeviceName
        {
            get => string.IsNullOrEmpty(Name) ? null : gciv::DeviceName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class DeleteDeviceRequest
    {
        /// <summary>
        /// <see cref="gciv::DeviceName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gciv::DeviceName DeviceName
        {
            get => string.IsNullOrEmpty(Name) ? null : gciv::DeviceName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class ListDevicesRequest
    {
        /// <summary>
        /// <see cref="RegistryName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public RegistryName ParentAsRegistryName
        {
            get => string.IsNullOrEmpty(Parent) ? null : RegistryName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class ModifyCloudToDeviceConfigRequest
    {
        /// <summary>
        /// <see cref="gciv::DeviceName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gciv::DeviceName DeviceName
        {
            get => string.IsNullOrEmpty(Name) ? null : gciv::DeviceName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class ListDeviceConfigVersionsRequest
    {
        /// <summary>
        /// <see cref="gciv::DeviceName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gciv::DeviceName DeviceName
        {
            get => string.IsNullOrEmpty(Name) ? null : gciv::DeviceName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class ListDeviceStatesRequest
    {
        /// <summary>
        /// <see cref="gciv::DeviceName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gciv::DeviceName DeviceName
        {
            get => string.IsNullOrEmpty(Name) ? null : gciv::DeviceName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class SendCommandToDeviceRequest
    {
        /// <summary>
        /// <see cref="gciv::DeviceName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gciv::DeviceName DeviceName
        {
            get => string.IsNullOrEmpty(Name) ? null : gciv::DeviceName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class BindDeviceToGatewayRequest
    {
        /// <summary>
        /// <see cref="RegistryName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public RegistryName ParentAsRegistryName
        {
            get => string.IsNullOrEmpty(Parent) ? null : RegistryName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class UnbindDeviceFromGatewayRequest
    {
        /// <summary>
        /// <see cref="RegistryName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public RegistryName ParentAsRegistryName
        {
            get => string.IsNullOrEmpty(Parent) ? null : RegistryName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }
}
