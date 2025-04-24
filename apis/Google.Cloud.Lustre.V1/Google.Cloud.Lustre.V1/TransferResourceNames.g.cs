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
using gclv = Google.Cloud.Lustre.V1;

namespace Google.Cloud.Lustre.V1
{
    public partial class ImportDataRequest
    {
        /// <summary>
        /// <see cref="gclv::InstanceName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gclv::InstanceName InstanceName
        {
            get => string.IsNullOrEmpty(Name) ? null : gclv::InstanceName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }

        /// <summary>
        /// <see cref="ServiceAccountName"/>-typed view over the <see cref="ServiceAccount"/> resource name property.
        /// </summary>
        public ServiceAccountName ServiceAccountAsServiceAccountName
        {
            get => string.IsNullOrEmpty(ServiceAccount) ? null : ServiceAccountName.Parse(ServiceAccount, allowUnparsed: true);
            set => ServiceAccount = value?.ToString() ?? "";
        }
    }

    public partial class ExportDataRequest
    {
        /// <summary>
        /// <see cref="gclv::InstanceName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gclv::InstanceName InstanceName
        {
            get => string.IsNullOrEmpty(Name) ? null : gclv::InstanceName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }

        /// <summary>
        /// <see cref="ServiceAccountName"/>-typed view over the <see cref="ServiceAccount"/> resource name property.
        /// </summary>
        public ServiceAccountName ServiceAccountAsServiceAccountName
        {
            get => string.IsNullOrEmpty(ServiceAccount) ? null : ServiceAccountName.Parse(ServiceAccount, allowUnparsed: true);
            set => ServiceAccount = value?.ToString() ?? "";
        }
    }
}
