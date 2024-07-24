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
using gcmv = Google.Cloud.Monitoring.V3;

namespace Google.Cloud.Monitoring.V3
{
    public partial class ListNotificationChannelDescriptorsRequest
    {
        /// <summary>
        /// <see cref="gagr::ProjectName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gagr::ProjectName ProjectName
        {
            get => string.IsNullOrEmpty(Name) ? null : gagr::ProjectName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }

        /// <summary>
        /// <see cref="gagr::OrganizationName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gagr::OrganizationName OrganizationName
        {
            get => string.IsNullOrEmpty(Name) ? null : gagr::OrganizationName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }

        /// <summary>
        /// <see cref="gagr::FolderName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gagr::FolderName FolderName
        {
            get => string.IsNullOrEmpty(Name) ? null : gagr::FolderName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }

        /// <summary>
        /// <see cref="gax::IResourceName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gax::IResourceName ResourceName
        {
            get
            {
                if (string.IsNullOrEmpty(Name))
                {
                    return null;
                }
                if (gagr::ProjectName.TryParse(Name, out gagr::ProjectName project))
                {
                    return project;
                }
                if (gagr::OrganizationName.TryParse(Name, out gagr::OrganizationName organization))
                {
                    return organization;
                }
                if (gagr::FolderName.TryParse(Name, out gagr::FolderName folder))
                {
                    return folder;
                }
                return gax::UnparsedResourceName.Parse(Name);
            }
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class GetNotificationChannelDescriptorRequest
    {
        /// <summary>
        /// <see cref="gcmv::NotificationChannelDescriptorName"/>-typed view over the <see cref="Name"/> resource name
        /// property.
        /// </summary>
        public gcmv::NotificationChannelDescriptorName NotificationChannelDescriptorName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcmv::NotificationChannelDescriptorName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }

        /// <summary>
        /// <see cref="gax::IResourceName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gax::IResourceName ResourceName
        {
            get
            {
                if (string.IsNullOrEmpty(Name))
                {
                    return null;
                }
                if (gcmv::NotificationChannelDescriptorName.TryParse(Name, out gcmv::NotificationChannelDescriptorName notificationChannelDescriptor))
                {
                    return notificationChannelDescriptor;
                }
                return gax::UnparsedResourceName.Parse(Name);
            }
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class CreateNotificationChannelRequest
    {
        /// <summary>
        /// <see cref="gagr::ProjectName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gagr::ProjectName ProjectName
        {
            get => string.IsNullOrEmpty(Name) ? null : gagr::ProjectName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }

        /// <summary>
        /// <see cref="gagr::OrganizationName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gagr::OrganizationName OrganizationName
        {
            get => string.IsNullOrEmpty(Name) ? null : gagr::OrganizationName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }

        /// <summary>
        /// <see cref="gagr::FolderName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gagr::FolderName FolderName
        {
            get => string.IsNullOrEmpty(Name) ? null : gagr::FolderName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }

        /// <summary>
        /// <see cref="gax::IResourceName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gax::IResourceName ResourceName
        {
            get
            {
                if (string.IsNullOrEmpty(Name))
                {
                    return null;
                }
                if (gagr::ProjectName.TryParse(Name, out gagr::ProjectName project))
                {
                    return project;
                }
                if (gagr::OrganizationName.TryParse(Name, out gagr::OrganizationName organization))
                {
                    return organization;
                }
                if (gagr::FolderName.TryParse(Name, out gagr::FolderName folder))
                {
                    return folder;
                }
                return gax::UnparsedResourceName.Parse(Name);
            }
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class ListNotificationChannelsRequest
    {
        /// <summary>
        /// <see cref="gagr::ProjectName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gagr::ProjectName ProjectName
        {
            get => string.IsNullOrEmpty(Name) ? null : gagr::ProjectName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }

        /// <summary>
        /// <see cref="gagr::OrganizationName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gagr::OrganizationName OrganizationName
        {
            get => string.IsNullOrEmpty(Name) ? null : gagr::OrganizationName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }

        /// <summary>
        /// <see cref="gagr::FolderName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gagr::FolderName FolderName
        {
            get => string.IsNullOrEmpty(Name) ? null : gagr::FolderName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }

        /// <summary>
        /// <see cref="gax::IResourceName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gax::IResourceName ResourceName
        {
            get
            {
                if (string.IsNullOrEmpty(Name))
                {
                    return null;
                }
                if (gagr::ProjectName.TryParse(Name, out gagr::ProjectName project))
                {
                    return project;
                }
                if (gagr::OrganizationName.TryParse(Name, out gagr::OrganizationName organization))
                {
                    return organization;
                }
                if (gagr::FolderName.TryParse(Name, out gagr::FolderName folder))
                {
                    return folder;
                }
                return gax::UnparsedResourceName.Parse(Name);
            }
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class GetNotificationChannelRequest
    {
        /// <summary>
        /// <see cref="gcmv::NotificationChannelName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcmv::NotificationChannelName NotificationChannelName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcmv::NotificationChannelName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }

        /// <summary>
        /// <see cref="gax::IResourceName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gax::IResourceName ResourceName
        {
            get
            {
                if (string.IsNullOrEmpty(Name))
                {
                    return null;
                }
                if (gcmv::NotificationChannelName.TryParse(Name, out gcmv::NotificationChannelName notificationChannel))
                {
                    return notificationChannel;
                }
                return gax::UnparsedResourceName.Parse(Name);
            }
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class DeleteNotificationChannelRequest
    {
        /// <summary>
        /// <see cref="gcmv::NotificationChannelName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcmv::NotificationChannelName NotificationChannelName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcmv::NotificationChannelName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }

        /// <summary>
        /// <see cref="gax::IResourceName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gax::IResourceName ResourceName
        {
            get
            {
                if (string.IsNullOrEmpty(Name))
                {
                    return null;
                }
                if (gcmv::NotificationChannelName.TryParse(Name, out gcmv::NotificationChannelName notificationChannel))
                {
                    return notificationChannel;
                }
                return gax::UnparsedResourceName.Parse(Name);
            }
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class SendNotificationChannelVerificationCodeRequest
    {
        /// <summary>
        /// <see cref="gcmv::NotificationChannelName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcmv::NotificationChannelName NotificationChannelName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcmv::NotificationChannelName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }

        /// <summary>
        /// <see cref="gax::IResourceName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gax::IResourceName ResourceName
        {
            get
            {
                if (string.IsNullOrEmpty(Name))
                {
                    return null;
                }
                if (gcmv::NotificationChannelName.TryParse(Name, out gcmv::NotificationChannelName notificationChannel))
                {
                    return notificationChannel;
                }
                return gax::UnparsedResourceName.Parse(Name);
            }
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class GetNotificationChannelVerificationCodeRequest
    {
        /// <summary>
        /// <see cref="gcmv::NotificationChannelName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcmv::NotificationChannelName NotificationChannelName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcmv::NotificationChannelName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }

        /// <summary>
        /// <see cref="gax::IResourceName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gax::IResourceName ResourceName
        {
            get
            {
                if (string.IsNullOrEmpty(Name))
                {
                    return null;
                }
                if (gcmv::NotificationChannelName.TryParse(Name, out gcmv::NotificationChannelName notificationChannel))
                {
                    return notificationChannel;
                }
                return gax::UnparsedResourceName.Parse(Name);
            }
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class VerifyNotificationChannelRequest
    {
        /// <summary>
        /// <see cref="gcmv::NotificationChannelName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcmv::NotificationChannelName NotificationChannelName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcmv::NotificationChannelName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }

        /// <summary>
        /// <see cref="gax::IResourceName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gax::IResourceName ResourceName
        {
            get
            {
                if (string.IsNullOrEmpty(Name))
                {
                    return null;
                }
                if (gcmv::NotificationChannelName.TryParse(Name, out gcmv::NotificationChannelName notificationChannel))
                {
                    return notificationChannel;
                }
                return gax::UnparsedResourceName.Parse(Name);
            }
            set => Name = value?.ToString() ?? "";
        }
    }
}
