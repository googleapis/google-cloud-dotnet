// Copyright 2024 Google LLC
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

namespace Google.Cloud.Talent.V4
{
    public partial class CompleteQueryRequest
    {
        /// <summary><see cref="TenantName"/>-typed view over the <see cref="Tenant"/> resource name property.</summary>
        public TenantName TenantAsTenantName
        {
            get => string.IsNullOrEmpty(Tenant) ? null : TenantName.Parse(Tenant, allowUnparsed: true);
            set => Tenant = value?.ToString() ?? "";
        }

        /// <summary>
        /// <see cref="CompanyName"/>-typed view over the <see cref="Company"/> resource name property.
        /// </summary>
        public CompanyName CompanyAsCompanyName
        {
            get => string.IsNullOrEmpty(Company) ? null : CompanyName.Parse(Company, allowUnparsed: true);
            set => Company = value?.ToString() ?? "";
        }
    }
}
