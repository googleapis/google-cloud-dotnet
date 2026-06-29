// Copyright 2026 Google LLC
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
using gcdv = Google.Cloud.DiscoveryEngine.V1Beta;

namespace Google.Cloud.DiscoveryEngine.V1Beta
{
    public partial class CreateLicenseConfigRequest
    {
        /// <summary>
        /// <see cref="LocationName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public LocationName ParentAsLocationName
        {
            get => string.IsNullOrEmpty(Parent) ? null : LocationName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class GetLicenseConfigRequest
    {
        /// <summary>
        /// <see cref="gcdv::LicenseConfigName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcdv::LicenseConfigName LicenseConfigName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcdv::LicenseConfigName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class ListLicenseConfigsRequest
    {
        /// <summary>
        /// <see cref="LocationName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public LocationName ParentAsLocationName
        {
            get => string.IsNullOrEmpty(Parent) ? null : LocationName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class DistributeLicenseConfigRequest
    {
        /// <summary>
        /// <see cref="BillingAccountLicenseConfigName"/>-typed view over the <see cref="BillingAccountLicenseConfig"/>
        /// resource name property.
        /// </summary>
        public BillingAccountLicenseConfigName BillingAccountLicenseConfigAsBillingAccountLicenseConfigName
        {
            get => string.IsNullOrEmpty(BillingAccountLicenseConfig) ? null : BillingAccountLicenseConfigName.Parse(BillingAccountLicenseConfig, allowUnparsed: true);
            set => BillingAccountLicenseConfig = value?.ToString() ?? "";
        }
    }

    public partial class RetractLicenseConfigRequest
    {
        /// <summary>
        /// <see cref="BillingAccountLicenseConfigName"/>-typed view over the <see cref="BillingAccountLicenseConfig"/>
        /// resource name property.
        /// </summary>
        public BillingAccountLicenseConfigName BillingAccountLicenseConfigAsBillingAccountLicenseConfigName
        {
            get => string.IsNullOrEmpty(BillingAccountLicenseConfig) ? null : BillingAccountLicenseConfigName.Parse(BillingAccountLicenseConfig, allowUnparsed: true);
            set => BillingAccountLicenseConfig = value?.ToString() ?? "";
        }

        /// <summary>
        /// <see cref="LicenseConfigName"/>-typed view over the <see cref="LicenseConfig"/> resource name property.
        /// </summary>
        public LicenseConfigName LicenseConfigAsLicenseConfigName
        {
            get => string.IsNullOrEmpty(LicenseConfig) ? null : LicenseConfigName.Parse(LicenseConfig, allowUnparsed: true);
            set => LicenseConfig = value?.ToString() ?? "";
        }
    }
}
