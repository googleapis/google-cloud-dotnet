// Copyright 2021 Google LLC
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

using gaav = Google.Analytics.Admin.V1Alpha;
using gax = Google.Api.Gax;

namespace Google.Analytics.Admin.V1Alpha
{
    public partial class GetAccountRequest
    {
        /// <summary>
        /// <see cref="gaav::AccountName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gaav::AccountName AccountName
        {
            get => string.IsNullOrEmpty(Name) ? null : gaav::AccountName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class DeleteAccountRequest
    {
        /// <summary>
        /// <see cref="gaav::AccountName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gaav::AccountName AccountName
        {
            get => string.IsNullOrEmpty(Name) ? null : gaav::AccountName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class GetPropertyRequest
    {
        /// <summary>
        /// <see cref="gaav::PropertyName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gaav::PropertyName PropertyName
        {
            get => string.IsNullOrEmpty(Name) ? null : gaav::PropertyName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class DeletePropertyRequest
    {
        /// <summary>
        /// <see cref="gaav::PropertyName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gaav::PropertyName PropertyName
        {
            get => string.IsNullOrEmpty(Name) ? null : gaav::PropertyName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class GetUserLinkRequest
    {
        /// <summary>
        /// <see cref="gaav::UserLinkName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gaav::UserLinkName UserLinkName
        {
            get => string.IsNullOrEmpty(Name) ? null : gaav::UserLinkName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class BatchGetUserLinksRequest
    {
        /// <summary>
        /// <see cref="AccountName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public AccountName ParentAsAccountName
        {
            get => string.IsNullOrEmpty(Parent) ? null : AccountName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }

        /// <summary>
        /// <see cref="PropertyName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public PropertyName ParentAsPropertyName
        {
            get => string.IsNullOrEmpty(Parent) ? null : PropertyName.Parse(Parent, allowUnparsed: true);
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
                if (AccountName.TryParse(Parent, out AccountName account))
                {
                    return account;
                }
                if (PropertyName.TryParse(Parent, out PropertyName property))
                {
                    return property;
                }
                return gax::UnparsedResourceName.Parse(Parent);
            }
            set => Parent = value?.ToString() ?? "";
        }

        /// <summary>
        /// <see cref="UserLinkName"/>-typed view over the <see cref="Names"/> resource name property.
        /// </summary>
        public gax::ResourceNameList<UserLinkName> UserLinkNames
        {
            get => new gax::ResourceNameList<UserLinkName>(Names, s => string.IsNullOrEmpty(s) ? null : UserLinkName.Parse(s, allowUnparsed: true));
        }
    }

    public partial class ListUserLinksRequest
    {
        /// <summary>
        /// <see cref="AccountName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public AccountName ParentAsAccountName
        {
            get => string.IsNullOrEmpty(Parent) ? null : AccountName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }

        /// <summary>
        /// <see cref="PropertyName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public PropertyName ParentAsPropertyName
        {
            get => string.IsNullOrEmpty(Parent) ? null : PropertyName.Parse(Parent, allowUnparsed: true);
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
                if (AccountName.TryParse(Parent, out AccountName account))
                {
                    return account;
                }
                if (PropertyName.TryParse(Parent, out PropertyName property))
                {
                    return property;
                }
                return gax::UnparsedResourceName.Parse(Parent);
            }
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class AuditUserLinksRequest
    {
        /// <summary>
        /// <see cref="AccountName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public AccountName ParentAsAccountName
        {
            get => string.IsNullOrEmpty(Parent) ? null : AccountName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }

        /// <summary>
        /// <see cref="PropertyName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public PropertyName ParentAsPropertyName
        {
            get => string.IsNullOrEmpty(Parent) ? null : PropertyName.Parse(Parent, allowUnparsed: true);
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
                if (AccountName.TryParse(Parent, out AccountName account))
                {
                    return account;
                }
                if (PropertyName.TryParse(Parent, out PropertyName property))
                {
                    return property;
                }
                return gax::UnparsedResourceName.Parse(Parent);
            }
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class CreateUserLinkRequest
    {
        /// <summary>
        /// <see cref="AccountName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public AccountName ParentAsAccountName
        {
            get => string.IsNullOrEmpty(Parent) ? null : AccountName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }

        /// <summary>
        /// <see cref="PropertyName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public PropertyName ParentAsPropertyName
        {
            get => string.IsNullOrEmpty(Parent) ? null : PropertyName.Parse(Parent, allowUnparsed: true);
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
                if (AccountName.TryParse(Parent, out AccountName account))
                {
                    return account;
                }
                if (PropertyName.TryParse(Parent, out PropertyName property))
                {
                    return property;
                }
                return gax::UnparsedResourceName.Parse(Parent);
            }
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class BatchCreateUserLinksRequest
    {
        /// <summary>
        /// <see cref="AccountName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public AccountName ParentAsAccountName
        {
            get => string.IsNullOrEmpty(Parent) ? null : AccountName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }

        /// <summary>
        /// <see cref="PropertyName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public PropertyName ParentAsPropertyName
        {
            get => string.IsNullOrEmpty(Parent) ? null : PropertyName.Parse(Parent, allowUnparsed: true);
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
                if (AccountName.TryParse(Parent, out AccountName account))
                {
                    return account;
                }
                if (PropertyName.TryParse(Parent, out PropertyName property))
                {
                    return property;
                }
                return gax::UnparsedResourceName.Parse(Parent);
            }
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class BatchUpdateUserLinksRequest
    {
        /// <summary>
        /// <see cref="AccountName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public AccountName ParentAsAccountName
        {
            get => string.IsNullOrEmpty(Parent) ? null : AccountName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }

        /// <summary>
        /// <see cref="PropertyName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public PropertyName ParentAsPropertyName
        {
            get => string.IsNullOrEmpty(Parent) ? null : PropertyName.Parse(Parent, allowUnparsed: true);
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
                if (AccountName.TryParse(Parent, out AccountName account))
                {
                    return account;
                }
                if (PropertyName.TryParse(Parent, out PropertyName property))
                {
                    return property;
                }
                return gax::UnparsedResourceName.Parse(Parent);
            }
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class DeleteUserLinkRequest
    {
        /// <summary>
        /// <see cref="gaav::UserLinkName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gaav::UserLinkName UserLinkName
        {
            get => string.IsNullOrEmpty(Name) ? null : gaav::UserLinkName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class BatchDeleteUserLinksRequest
    {
        /// <summary>
        /// <see cref="AccountName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public AccountName ParentAsAccountName
        {
            get => string.IsNullOrEmpty(Parent) ? null : AccountName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }

        /// <summary>
        /// <see cref="PropertyName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public PropertyName ParentAsPropertyName
        {
            get => string.IsNullOrEmpty(Parent) ? null : PropertyName.Parse(Parent, allowUnparsed: true);
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
                if (AccountName.TryParse(Parent, out AccountName account))
                {
                    return account;
                }
                if (PropertyName.TryParse(Parent, out PropertyName property))
                {
                    return property;
                }
                return gax::UnparsedResourceName.Parse(Parent);
            }
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class GetWebDataStreamRequest
    {
        /// <summary>
        /// <see cref="gaav::WebDataStreamName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gaav::WebDataStreamName WebDataStreamName
        {
            get => string.IsNullOrEmpty(Name) ? null : gaav::WebDataStreamName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class DeleteWebDataStreamRequest
    {
        /// <summary>
        /// <see cref="gaav::WebDataStreamName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gaav::WebDataStreamName WebDataStreamName
        {
            get => string.IsNullOrEmpty(Name) ? null : gaav::WebDataStreamName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class CreateWebDataStreamRequest
    {
        /// <summary>
        /// <see cref="PropertyName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public PropertyName ParentAsPropertyName
        {
            get => string.IsNullOrEmpty(Parent) ? null : PropertyName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class ListWebDataStreamsRequest
    {
        /// <summary>
        /// <see cref="PropertyName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public PropertyName ParentAsPropertyName
        {
            get => string.IsNullOrEmpty(Parent) ? null : PropertyName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class GetIosAppDataStreamRequest
    {
        /// <summary>
        /// <see cref="gaav::IosAppDataStreamName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gaav::IosAppDataStreamName IosAppDataStreamName
        {
            get => string.IsNullOrEmpty(Name) ? null : gaav::IosAppDataStreamName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class DeleteIosAppDataStreamRequest
    {
        /// <summary>
        /// <see cref="gaav::IosAppDataStreamName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gaav::IosAppDataStreamName IosAppDataStreamName
        {
            get => string.IsNullOrEmpty(Name) ? null : gaav::IosAppDataStreamName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class ListIosAppDataStreamsRequest
    {
        /// <summary>
        /// <see cref="PropertyName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public PropertyName ParentAsPropertyName
        {
            get => string.IsNullOrEmpty(Parent) ? null : PropertyName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class GetAndroidAppDataStreamRequest
    {
        /// <summary>
        /// <see cref="gaav::AndroidAppDataStreamName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gaav::AndroidAppDataStreamName AndroidAppDataStreamName
        {
            get => string.IsNullOrEmpty(Name) ? null : gaav::AndroidAppDataStreamName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class DeleteAndroidAppDataStreamRequest
    {
        /// <summary>
        /// <see cref="gaav::AndroidAppDataStreamName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gaav::AndroidAppDataStreamName AndroidAppDataStreamName
        {
            get => string.IsNullOrEmpty(Name) ? null : gaav::AndroidAppDataStreamName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class ListAndroidAppDataStreamsRequest
    {
        /// <summary>
        /// <see cref="PropertyName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public PropertyName ParentAsPropertyName
        {
            get => string.IsNullOrEmpty(Parent) ? null : PropertyName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class GetEnhancedMeasurementSettingsRequest
    {
        /// <summary>
        /// <see cref="gaav::EnhancedMeasurementSettingsName"/>-typed view over the <see cref="Name"/> resource name
        /// property.
        /// </summary>
        public gaav::EnhancedMeasurementSettingsName EnhancedMeasurementSettingsName
        {
            get => string.IsNullOrEmpty(Name) ? null : gaav::EnhancedMeasurementSettingsName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class CreateFirebaseLinkRequest
    {
        /// <summary>
        /// <see cref="PropertyName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public PropertyName ParentAsPropertyName
        {
            get => string.IsNullOrEmpty(Parent) ? null : PropertyName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class DeleteFirebaseLinkRequest
    {
        /// <summary>
        /// <see cref="gaav::FirebaseLinkName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gaav::FirebaseLinkName FirebaseLinkName
        {
            get => string.IsNullOrEmpty(Name) ? null : gaav::FirebaseLinkName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class ListFirebaseLinksRequest
    {
        /// <summary>
        /// <see cref="PropertyName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public PropertyName ParentAsPropertyName
        {
            get => string.IsNullOrEmpty(Parent) ? null : PropertyName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class GetGlobalSiteTagRequest
    {
        /// <summary>
        /// <see cref="gaav::GlobalSiteTagName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gaav::GlobalSiteTagName GlobalSiteTagName
        {
            get => string.IsNullOrEmpty(Name) ? null : gaav::GlobalSiteTagName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class CreateGoogleAdsLinkRequest
    {
        /// <summary>
        /// <see cref="PropertyName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public PropertyName ParentAsPropertyName
        {
            get => string.IsNullOrEmpty(Parent) ? null : PropertyName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class DeleteGoogleAdsLinkRequest
    {
        /// <summary>
        /// <see cref="gaav::GoogleAdsLinkName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gaav::GoogleAdsLinkName GoogleAdsLinkName
        {
            get => string.IsNullOrEmpty(Name) ? null : gaav::GoogleAdsLinkName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class ListGoogleAdsLinksRequest
    {
        /// <summary>
        /// <see cref="PropertyName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public PropertyName ParentAsPropertyName
        {
            get => string.IsNullOrEmpty(Parent) ? null : PropertyName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class GetDataSharingSettingsRequest
    {
        /// <summary>
        /// <see cref="gaav::DataSharingSettingsName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gaav::DataSharingSettingsName DataSharingSettingsName
        {
            get => string.IsNullOrEmpty(Name) ? null : gaav::DataSharingSettingsName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class SearchChangeHistoryEventsRequest
    {
        /// <summary>
        /// <see cref="AccountName"/>-typed view over the <see cref="Account"/> resource name property.
        /// </summary>
        public AccountName AccountAsAccountName
        {
            get => string.IsNullOrEmpty(Account) ? null : AccountName.Parse(Account, allowUnparsed: true);
            set => Account = value?.ToString() ?? "";
        }

        /// <summary>
        /// <see cref="PropertyName"/>-typed view over the <see cref="Property"/> resource name property.
        /// </summary>
        public PropertyName PropertyAsPropertyName
        {
            get => string.IsNullOrEmpty(Property) ? null : PropertyName.Parse(Property, allowUnparsed: true);
            set => Property = value?.ToString() ?? "";
        }
    }
}
