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
using gagr = Google.Api.Gax.ResourceNames;
using gcsv = Google.Cloud.Support.V2Beta;

namespace Google.Cloud.Support.V2Beta
{
    public partial class CreateSupportEventSubscriptionRequest
    {
        /// <summary>
        /// <see cref="gagr::OrganizationName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public gagr::OrganizationName ParentAsOrganizationName
        {
            get => string.IsNullOrEmpty(Parent) ? null : gagr::OrganizationName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class GetSupportEventSubscriptionRequest
    {
        /// <summary>
        /// <see cref="gcsv::SupportEventSubscriptionName"/>-typed view over the <see cref="Name"/> resource name
        /// property.
        /// </summary>
        public gcsv::SupportEventSubscriptionName SupportEventSubscriptionName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcsv::SupportEventSubscriptionName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class ListSupportEventSubscriptionsRequest
    {
        /// <summary>
        /// <see cref="gagr::OrganizationName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public gagr::OrganizationName ParentAsOrganizationName
        {
            get => string.IsNullOrEmpty(Parent) ? null : gagr::OrganizationName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class DeleteSupportEventSubscriptionRequest
    {
        /// <summary>
        /// <see cref="gcsv::SupportEventSubscriptionName"/>-typed view over the <see cref="Name"/> resource name
        /// property.
        /// </summary>
        public gcsv::SupportEventSubscriptionName SupportEventSubscriptionName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcsv::SupportEventSubscriptionName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class UndeleteSupportEventSubscriptionRequest
    {
        /// <summary>
        /// <see cref="gcsv::SupportEventSubscriptionName"/>-typed view over the <see cref="Name"/> resource name
        /// property.
        /// </summary>
        public gcsv::SupportEventSubscriptionName SupportEventSubscriptionName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcsv::SupportEventSubscriptionName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }
}
