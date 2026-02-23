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
using gadv = Google.Ads.DataManager.V1;

namespace Google.Ads.DataManager.V1
{
    public partial class CreateUserListGlobalLicenseRequest
    {
        /// <summary>
        /// <see cref="AccountName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public AccountName ParentAsAccountName
        {
            get => string.IsNullOrEmpty(Parent) ? null : AccountName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class GetUserListGlobalLicenseRequest
    {
        /// <summary>
        /// <see cref="gadv::UserListGlobalLicenseName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gadv::UserListGlobalLicenseName UserListGlobalLicenseName
        {
            get => string.IsNullOrEmpty(Name) ? null : gadv::UserListGlobalLicenseName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class ListUserListGlobalLicensesRequest
    {
        /// <summary>
        /// <see cref="AccountName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public AccountName ParentAsAccountName
        {
            get => string.IsNullOrEmpty(Parent) ? null : AccountName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class ListUserListGlobalLicenseCustomerInfosRequest
    {
        /// <summary>
        /// <see cref="UserListGlobalLicenseName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public UserListGlobalLicenseName ParentAsUserListGlobalLicenseName
        {
            get => string.IsNullOrEmpty(Parent) ? null : UserListGlobalLicenseName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }
}
