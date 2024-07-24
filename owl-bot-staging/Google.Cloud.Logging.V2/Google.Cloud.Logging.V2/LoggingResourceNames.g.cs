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
using gagr = Google.Api.Gax.ResourceNames;
using gax = Google.Api.Gax;
using gclv = Google.Cloud.Logging.V2;

namespace Google.Cloud.Logging.V2
{
    public partial class DeleteLogRequest
    {
        /// <summary>
        /// <see cref="gclv::LogName"/>-typed view over the <see cref="LogName"/> resource name property.
        /// </summary>
        public gclv::LogName LogNameAsLogName
        {
            get => string.IsNullOrEmpty(LogName) ? null : gclv::LogName.Parse(LogName, allowUnparsed: true);
            set => LogName = value?.ToString() ?? "";
        }
    }

    public partial class WriteLogEntriesRequest
    {
        /// <summary>
        /// <see cref="gclv::LogName"/>-typed view over the <see cref="LogName"/> resource name property.
        /// </summary>
        public gclv::LogName LogNameAsLogName
        {
            get => string.IsNullOrEmpty(LogName) ? null : gclv::LogName.Parse(LogName, allowUnparsed: true);
            set => LogName = value?.ToString() ?? "";
        }
    }

    public partial class ListLogEntriesRequest
    {
        /// <summary>
        /// <see cref="gagr::ProjectName"/>-typed view over the <see cref="ResourceNames"/> resource name property.
        /// </summary>
        public gax::ResourceNameList<gagr::ProjectName> ResourceNamesAsProjectNames
        {
            get => new gax::ResourceNameList<gagr::ProjectName>(ResourceNames, s => string.IsNullOrEmpty(s) ? null : gagr::ProjectName.Parse(s, allowUnparsed: true));
        }

        /// <summary>
        /// <see cref="gagr::OrganizationName"/>-typed view over the <see cref="ResourceNames"/> resource name property.
        /// </summary>
        public gax::ResourceNameList<gagr::OrganizationName> ResourceNamesAsOrganizationNames
        {
            get => new gax::ResourceNameList<gagr::OrganizationName>(ResourceNames, s => string.IsNullOrEmpty(s) ? null : gagr::OrganizationName.Parse(s, allowUnparsed: true));
        }

        /// <summary>
        /// <see cref="gagr::FolderName"/>-typed view over the <see cref="ResourceNames"/> resource name property.
        /// </summary>
        public gax::ResourceNameList<gagr::FolderName> ResourceNamesAsFolderNames
        {
            get => new gax::ResourceNameList<gagr::FolderName>(ResourceNames, s => string.IsNullOrEmpty(s) ? null : gagr::FolderName.Parse(s, allowUnparsed: true));
        }

        /// <summary>
        /// <see cref="gagr::BillingAccountName"/>-typed view over the <see cref="ResourceNames"/> resource name
        /// property.
        /// </summary>
        public gax::ResourceNameList<gagr::BillingAccountName> ResourceNamesAsBillingAccountNames
        {
            get => new gax::ResourceNameList<gagr::BillingAccountName>(ResourceNames, s => string.IsNullOrEmpty(s) ? null : gagr::BillingAccountName.Parse(s, allowUnparsed: true));
        }

        /// <summary>
        /// <see cref="gax::IResourceName"/>-typed view over the <see cref="ResourceNames"/> resource name property.
        /// </summary>
        public gax::ResourceNameList<gax::IResourceName> ResourceNamesAsResourceNames
        {
            get => new gax::ResourceNameList<gax::IResourceName>(ResourceNames, s =>
            {
                if (string.IsNullOrEmpty(s))
                {
                    return null;
                }
                if (gagr::ProjectName.TryParse(s, out gagr::ProjectName project))
                {
                    return project;
                }
                if (gagr::OrganizationName.TryParse(s, out gagr::OrganizationName organization))
                {
                    return organization;
                }
                if (gagr::FolderName.TryParse(s, out gagr::FolderName folder))
                {
                    return folder;
                }
                if (gagr::BillingAccountName.TryParse(s, out gagr::BillingAccountName billingAccount))
                {
                    return billingAccount;
                }
                return gax::UnparsedResourceName.Parse(s);
            });
        }
    }

    public partial class ListLogsRequest
    {
        /// <summary>
        /// <see cref="gagr::ProjectName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public gagr::ProjectName ParentAsProjectName
        {
            get => string.IsNullOrEmpty(Parent) ? null : gagr::ProjectName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }

        /// <summary>
        /// <see cref="gagr::OrganizationName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public gagr::OrganizationName ParentAsOrganizationName
        {
            get => string.IsNullOrEmpty(Parent) ? null : gagr::OrganizationName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }

        /// <summary>
        /// <see cref="gagr::FolderName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public gagr::FolderName ParentAsFolderName
        {
            get => string.IsNullOrEmpty(Parent) ? null : gagr::FolderName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }

        /// <summary>
        /// <see cref="gagr::BillingAccountName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public gagr::BillingAccountName ParentAsBillingAccountName
        {
            get => string.IsNullOrEmpty(Parent) ? null : gagr::BillingAccountName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }

        /// <summary>
        /// <see cref="gax::IResourceName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public gax::IResourceName ParentAsResourceName
        {
            get
            {
                if (string.IsNullOrEmpty(Parent))
                {
                    return null;
                }
                if (gagr::ProjectName.TryParse(Parent, out gagr::ProjectName project))
                {
                    return project;
                }
                if (gagr::OrganizationName.TryParse(Parent, out gagr::OrganizationName organization))
                {
                    return organization;
                }
                if (gagr::FolderName.TryParse(Parent, out gagr::FolderName folder))
                {
                    return folder;
                }
                if (gagr::BillingAccountName.TryParse(Parent, out gagr::BillingAccountName billingAccount))
                {
                    return billingAccount;
                }
                return gax::UnparsedResourceName.Parse(Parent);
            }
            set => Parent = value?.ToString() ?? "";
        }

        /// <summary>
        /// <see cref="gagr::ProjectName"/>-typed view over the <see cref="ResourceNames"/> resource name property.
        /// </summary>
        public gax::ResourceNameList<gagr::ProjectName> ResourceNamesAsProjectNames
        {
            get => new gax::ResourceNameList<gagr::ProjectName>(ResourceNames, s => string.IsNullOrEmpty(s) ? null : gagr::ProjectName.Parse(s, allowUnparsed: true));
        }

        /// <summary>
        /// <see cref="gagr::OrganizationName"/>-typed view over the <see cref="ResourceNames"/> resource name property.
        /// </summary>
        public gax::ResourceNameList<gagr::OrganizationName> ResourceNamesAsOrganizationNames
        {
            get => new gax::ResourceNameList<gagr::OrganizationName>(ResourceNames, s => string.IsNullOrEmpty(s) ? null : gagr::OrganizationName.Parse(s, allowUnparsed: true));
        }

        /// <summary>
        /// <see cref="gagr::FolderName"/>-typed view over the <see cref="ResourceNames"/> resource name property.
        /// </summary>
        public gax::ResourceNameList<gagr::FolderName> ResourceNamesAsFolderNames
        {
            get => new gax::ResourceNameList<gagr::FolderName>(ResourceNames, s => string.IsNullOrEmpty(s) ? null : gagr::FolderName.Parse(s, allowUnparsed: true));
        }

        /// <summary>
        /// <see cref="gagr::BillingAccountName"/>-typed view over the <see cref="ResourceNames"/> resource name
        /// property.
        /// </summary>
        public gax::ResourceNameList<gagr::BillingAccountName> ResourceNamesAsBillingAccountNames
        {
            get => new gax::ResourceNameList<gagr::BillingAccountName>(ResourceNames, s => string.IsNullOrEmpty(s) ? null : gagr::BillingAccountName.Parse(s, allowUnparsed: true));
        }

        /// <summary>
        /// <see cref="gax::IResourceName"/>-typed view over the <see cref="ResourceNames"/> resource name property.
        /// </summary>
        public gax::ResourceNameList<gax::IResourceName> ResourceNamesAsResourceNames
        {
            get => new gax::ResourceNameList<gax::IResourceName>(ResourceNames, s =>
            {
                if (string.IsNullOrEmpty(s))
                {
                    return null;
                }
                if (gagr::ProjectName.TryParse(s, out gagr::ProjectName project))
                {
                    return project;
                }
                if (gagr::OrganizationName.TryParse(s, out gagr::OrganizationName organization))
                {
                    return organization;
                }
                if (gagr::FolderName.TryParse(s, out gagr::FolderName folder))
                {
                    return folder;
                }
                if (gagr::BillingAccountName.TryParse(s, out gagr::BillingAccountName billingAccount))
                {
                    return billingAccount;
                }
                return gax::UnparsedResourceName.Parse(s);
            });
        }
    }
}
