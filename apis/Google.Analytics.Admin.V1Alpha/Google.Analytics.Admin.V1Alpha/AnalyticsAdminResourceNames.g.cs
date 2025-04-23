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

    public partial class AcknowledgeUserDataCollectionRequest
    {
        /// <summary>
        /// <see cref="PropertyName"/>-typed view over the <see cref="Property"/> resource name property.
        /// </summary>
        public PropertyName PropertyAsPropertyName
        {
            get => string.IsNullOrEmpty(Property) ? null : PropertyName.Parse(Property, allowUnparsed: true);
            set => Property = value?.ToString() ?? "";
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

    public partial class GetMeasurementProtocolSecretRequest
    {
        /// <summary>
        /// <see cref="gaav::MeasurementProtocolSecretName"/>-typed view over the <see cref="Name"/> resource name
        /// property.
        /// </summary>
        public gaav::MeasurementProtocolSecretName MeasurementProtocolSecretName
        {
            get => string.IsNullOrEmpty(Name) ? null : gaav::MeasurementProtocolSecretName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class CreateMeasurementProtocolSecretRequest
    {
        /// <summary>
        /// <see cref="DataStreamName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public DataStreamName ParentAsDataStreamName
        {
            get => string.IsNullOrEmpty(Parent) ? null : DataStreamName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class DeleteMeasurementProtocolSecretRequest
    {
        /// <summary>
        /// <see cref="gaav::MeasurementProtocolSecretName"/>-typed view over the <see cref="Name"/> resource name
        /// property.
        /// </summary>
        public gaav::MeasurementProtocolSecretName MeasurementProtocolSecretName
        {
            get => string.IsNullOrEmpty(Name) ? null : gaav::MeasurementProtocolSecretName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class ListMeasurementProtocolSecretsRequest
    {
        /// <summary>
        /// <see cref="DataStreamName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public DataStreamName ParentAsDataStreamName
        {
            get => string.IsNullOrEmpty(Parent) ? null : DataStreamName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class GetSKAdNetworkConversionValueSchemaRequest
    {
        /// <summary>
        /// <see cref="gaav::SKAdNetworkConversionValueSchemaName"/>-typed view over the <see cref="Name"/> resource
        /// name property.
        /// </summary>
        public gaav::SKAdNetworkConversionValueSchemaName SKAdNetworkConversionValueSchemaName
        {
            get => string.IsNullOrEmpty(Name) ? null : gaav::SKAdNetworkConversionValueSchemaName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class CreateSKAdNetworkConversionValueSchemaRequest
    {
        /// <summary>
        /// <see cref="DataStreamName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public DataStreamName ParentAsDataStreamName
        {
            get => string.IsNullOrEmpty(Parent) ? null : DataStreamName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class DeleteSKAdNetworkConversionValueSchemaRequest
    {
        /// <summary>
        /// <see cref="gaav::SKAdNetworkConversionValueSchemaName"/>-typed view over the <see cref="Name"/> resource
        /// name property.
        /// </summary>
        public gaav::SKAdNetworkConversionValueSchemaName SKAdNetworkConversionValueSchemaName
        {
            get => string.IsNullOrEmpty(Name) ? null : gaav::SKAdNetworkConversionValueSchemaName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class ListSKAdNetworkConversionValueSchemasRequest
    {
        /// <summary>
        /// <see cref="DataStreamName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public DataStreamName ParentAsDataStreamName
        {
            get => string.IsNullOrEmpty(Parent) ? null : DataStreamName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class GetGoogleSignalsSettingsRequest
    {
        /// <summary>
        /// <see cref="gaav::GoogleSignalsSettingsName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gaav::GoogleSignalsSettingsName GoogleSignalsSettingsName
        {
            get => string.IsNullOrEmpty(Name) ? null : gaav::GoogleSignalsSettingsName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class CreateConversionEventRequest
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

    public partial class GetConversionEventRequest
    {
        /// <summary>
        /// <see cref="gaav::ConversionEventName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gaav::ConversionEventName ConversionEventName
        {
            get => string.IsNullOrEmpty(Name) ? null : gaav::ConversionEventName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class DeleteConversionEventRequest
    {
        /// <summary>
        /// <see cref="gaav::ConversionEventName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gaav::ConversionEventName ConversionEventName
        {
            get => string.IsNullOrEmpty(Name) ? null : gaav::ConversionEventName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class ListConversionEventsRequest
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

    public partial class CreateKeyEventRequest
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

    public partial class GetKeyEventRequest
    {
        /// <summary>
        /// <see cref="gaav::KeyEventName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gaav::KeyEventName KeyEventName
        {
            get => string.IsNullOrEmpty(Name) ? null : gaav::KeyEventName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class DeleteKeyEventRequest
    {
        /// <summary>
        /// <see cref="gaav::KeyEventName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gaav::KeyEventName KeyEventName
        {
            get => string.IsNullOrEmpty(Name) ? null : gaav::KeyEventName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class ListKeyEventsRequest
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

    public partial class GetDisplayVideo360AdvertiserLinkRequest
    {
        /// <summary>
        /// <see cref="gaav::DisplayVideo360AdvertiserLinkName"/>-typed view over the <see cref="Name"/> resource name
        /// property.
        /// </summary>
        public gaav::DisplayVideo360AdvertiserLinkName DisplayVideo360AdvertiserLinkName
        {
            get => string.IsNullOrEmpty(Name) ? null : gaav::DisplayVideo360AdvertiserLinkName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class ListDisplayVideo360AdvertiserLinksRequest
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

    public partial class CreateDisplayVideo360AdvertiserLinkRequest
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

    public partial class DeleteDisplayVideo360AdvertiserLinkRequest
    {
        /// <summary>
        /// <see cref="gaav::DisplayVideo360AdvertiserLinkName"/>-typed view over the <see cref="Name"/> resource name
        /// property.
        /// </summary>
        public gaav::DisplayVideo360AdvertiserLinkName DisplayVideo360AdvertiserLinkName
        {
            get => string.IsNullOrEmpty(Name) ? null : gaav::DisplayVideo360AdvertiserLinkName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class GetDisplayVideo360AdvertiserLinkProposalRequest
    {
        /// <summary>
        /// <see cref="gaav::DisplayVideo360AdvertiserLinkProposalName"/>-typed view over the <see cref="Name"/>
        /// resource name property.
        /// </summary>
        public gaav::DisplayVideo360AdvertiserLinkProposalName DisplayVideo360AdvertiserLinkProposalName
        {
            get => string.IsNullOrEmpty(Name) ? null : gaav::DisplayVideo360AdvertiserLinkProposalName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class ListDisplayVideo360AdvertiserLinkProposalsRequest
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

    public partial class CreateDisplayVideo360AdvertiserLinkProposalRequest
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

    public partial class DeleteDisplayVideo360AdvertiserLinkProposalRequest
    {
        /// <summary>
        /// <see cref="gaav::DisplayVideo360AdvertiserLinkProposalName"/>-typed view over the <see cref="Name"/>
        /// resource name property.
        /// </summary>
        public gaav::DisplayVideo360AdvertiserLinkProposalName DisplayVideo360AdvertiserLinkProposalName
        {
            get => string.IsNullOrEmpty(Name) ? null : gaav::DisplayVideo360AdvertiserLinkProposalName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class ApproveDisplayVideo360AdvertiserLinkProposalRequest
    {
        /// <summary>
        /// <see cref="gaav::DisplayVideo360AdvertiserLinkProposalName"/>-typed view over the <see cref="Name"/>
        /// resource name property.
        /// </summary>
        public gaav::DisplayVideo360AdvertiserLinkProposalName DisplayVideo360AdvertiserLinkProposalName
        {
            get => string.IsNullOrEmpty(Name) ? null : gaav::DisplayVideo360AdvertiserLinkProposalName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class CancelDisplayVideo360AdvertiserLinkProposalRequest
    {
        /// <summary>
        /// <see cref="gaav::DisplayVideo360AdvertiserLinkProposalName"/>-typed view over the <see cref="Name"/>
        /// resource name property.
        /// </summary>
        public gaav::DisplayVideo360AdvertiserLinkProposalName DisplayVideo360AdvertiserLinkProposalName
        {
            get => string.IsNullOrEmpty(Name) ? null : gaav::DisplayVideo360AdvertiserLinkProposalName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class GetSearchAds360LinkRequest
    {
        /// <summary>
        /// <see cref="gaav::SearchAds360LinkName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gaav::SearchAds360LinkName SearchAds360LinkName
        {
            get => string.IsNullOrEmpty(Name) ? null : gaav::SearchAds360LinkName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class ListSearchAds360LinksRequest
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

    public partial class CreateSearchAds360LinkRequest
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

    public partial class DeleteSearchAds360LinkRequest
    {
        /// <summary>
        /// <see cref="gaav::SearchAds360LinkName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gaav::SearchAds360LinkName SearchAds360LinkName
        {
            get => string.IsNullOrEmpty(Name) ? null : gaav::SearchAds360LinkName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class CreateCustomDimensionRequest
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

    public partial class ListCustomDimensionsRequest
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

    public partial class ArchiveCustomDimensionRequest
    {
        /// <summary>
        /// <see cref="gaav::CustomDimensionName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gaav::CustomDimensionName CustomDimensionName
        {
            get => string.IsNullOrEmpty(Name) ? null : gaav::CustomDimensionName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class GetCustomDimensionRequest
    {
        /// <summary>
        /// <see cref="gaav::CustomDimensionName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gaav::CustomDimensionName CustomDimensionName
        {
            get => string.IsNullOrEmpty(Name) ? null : gaav::CustomDimensionName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class CreateCustomMetricRequest
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

    public partial class ListCustomMetricsRequest
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

    public partial class ArchiveCustomMetricRequest
    {
        /// <summary>
        /// <see cref="gaav::CustomMetricName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gaav::CustomMetricName CustomMetricName
        {
            get => string.IsNullOrEmpty(Name) ? null : gaav::CustomMetricName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class GetCustomMetricRequest
    {
        /// <summary>
        /// <see cref="gaav::CustomMetricName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gaav::CustomMetricName CustomMetricName
        {
            get => string.IsNullOrEmpty(Name) ? null : gaav::CustomMetricName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class CreateCalculatedMetricRequest
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

    public partial class DeleteCalculatedMetricRequest
    {
        /// <summary>
        /// <see cref="gaav::CalculatedMetricName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gaav::CalculatedMetricName CalculatedMetricName
        {
            get => string.IsNullOrEmpty(Name) ? null : gaav::CalculatedMetricName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class ListCalculatedMetricsRequest
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

    public partial class GetCalculatedMetricRequest
    {
        /// <summary>
        /// <see cref="gaav::CalculatedMetricName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gaav::CalculatedMetricName CalculatedMetricName
        {
            get => string.IsNullOrEmpty(Name) ? null : gaav::CalculatedMetricName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class GetDataRetentionSettingsRequest
    {
        /// <summary>
        /// <see cref="gaav::DataRetentionSettingsName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gaav::DataRetentionSettingsName DataRetentionSettingsName
        {
            get => string.IsNullOrEmpty(Name) ? null : gaav::DataRetentionSettingsName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class CreateDataStreamRequest
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

    public partial class DeleteDataStreamRequest
    {
        /// <summary>
        /// <see cref="gaav::DataStreamName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gaav::DataStreamName DataStreamName
        {
            get => string.IsNullOrEmpty(Name) ? null : gaav::DataStreamName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class ListDataStreamsRequest
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

    public partial class GetDataStreamRequest
    {
        /// <summary>
        /// <see cref="gaav::DataStreamName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gaav::DataStreamName DataStreamName
        {
            get => string.IsNullOrEmpty(Name) ? null : gaav::DataStreamName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class GetAudienceRequest
    {
        /// <summary>
        /// <see cref="gaav::AudienceName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gaav::AudienceName AudienceName
        {
            get => string.IsNullOrEmpty(Name) ? null : gaav::AudienceName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class ListAudiencesRequest
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

    public partial class CreateAudienceRequest
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

    public partial class ArchiveAudienceRequest
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

    public partial class GetAttributionSettingsRequest
    {
        /// <summary>
        /// <see cref="gaav::AttributionSettingsName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gaav::AttributionSettingsName AttributionSettingsName
        {
            get => string.IsNullOrEmpty(Name) ? null : gaav::AttributionSettingsName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class GetAccessBindingRequest
    {
        /// <summary>
        /// <see cref="gaav::AccessBindingName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gaav::AccessBindingName AccessBindingName
        {
            get => string.IsNullOrEmpty(Name) ? null : gaav::AccessBindingName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class BatchGetAccessBindingsRequest
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
        /// <see cref="AccessBindingName"/>-typed view over the <see cref="Names"/> resource name property.
        /// </summary>
        public gax::ResourceNameList<AccessBindingName> AccessBindingNames
        {
            get => new gax::ResourceNameList<AccessBindingName>(Names, s => string.IsNullOrEmpty(s) ? null : AccessBindingName.Parse(s, allowUnparsed: true));
        }
    }

    public partial class ListAccessBindingsRequest
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

    public partial class CreateAccessBindingRequest
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

    public partial class BatchCreateAccessBindingsRequest
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

    public partial class BatchUpdateAccessBindingsRequest
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

    public partial class DeleteAccessBindingRequest
    {
        /// <summary>
        /// <see cref="gaav::AccessBindingName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gaav::AccessBindingName AccessBindingName
        {
            get => string.IsNullOrEmpty(Name) ? null : gaav::AccessBindingName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class BatchDeleteAccessBindingsRequest
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

    public partial class CreateExpandedDataSetRequest
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

    public partial class DeleteExpandedDataSetRequest
    {
        /// <summary>
        /// <see cref="gaav::ExpandedDataSetName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gaav::ExpandedDataSetName ExpandedDataSetName
        {
            get => string.IsNullOrEmpty(Name) ? null : gaav::ExpandedDataSetName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class GetExpandedDataSetRequest
    {
        /// <summary>
        /// <see cref="gaav::ExpandedDataSetName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gaav::ExpandedDataSetName ExpandedDataSetName
        {
            get => string.IsNullOrEmpty(Name) ? null : gaav::ExpandedDataSetName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class ListExpandedDataSetsRequest
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

    public partial class CreateChannelGroupRequest
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

    public partial class DeleteChannelGroupRequest
    {
        /// <summary>
        /// <see cref="gaav::ChannelGroupName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gaav::ChannelGroupName ChannelGroupName
        {
            get => string.IsNullOrEmpty(Name) ? null : gaav::ChannelGroupName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class GetChannelGroupRequest
    {
        /// <summary>
        /// <see cref="gaav::ChannelGroupName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gaav::ChannelGroupName ChannelGroupName
        {
            get => string.IsNullOrEmpty(Name) ? null : gaav::ChannelGroupName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class ListChannelGroupsRequest
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

    public partial class CreateBigQueryLinkRequest
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

    public partial class GetBigQueryLinkRequest
    {
        /// <summary>
        /// <see cref="gaav::BigQueryLinkName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gaav::BigQueryLinkName BigQueryLinkName
        {
            get => string.IsNullOrEmpty(Name) ? null : gaav::BigQueryLinkName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class ListBigQueryLinksRequest
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

    public partial class DeleteBigQueryLinkRequest
    {
        /// <summary>
        /// <see cref="gaav::BigQueryLinkName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gaav::BigQueryLinkName BigQueryLinkName
        {
            get => string.IsNullOrEmpty(Name) ? null : gaav::BigQueryLinkName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
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

    public partial class GetDataRedactionSettingsRequest
    {
        /// <summary>
        /// <see cref="gaav::DataRedactionSettingsName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gaav::DataRedactionSettingsName DataRedactionSettingsName
        {
            get => string.IsNullOrEmpty(Name) ? null : gaav::DataRedactionSettingsName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class CreateAdSenseLinkRequest
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

    public partial class GetAdSenseLinkRequest
    {
        /// <summary>
        /// <see cref="gaav::AdSenseLinkName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gaav::AdSenseLinkName AdSenseLinkName
        {
            get => string.IsNullOrEmpty(Name) ? null : gaav::AdSenseLinkName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class DeleteAdSenseLinkRequest
    {
        /// <summary>
        /// <see cref="gaav::AdSenseLinkName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gaav::AdSenseLinkName AdSenseLinkName
        {
            get => string.IsNullOrEmpty(Name) ? null : gaav::AdSenseLinkName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class ListAdSenseLinksRequest
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

    public partial class FetchConnectedGa4PropertyRequest
    {
        /// <summary>
        /// <see cref="PropertyName"/>-typed view over the <see cref="Property"/> resource name property.
        /// </summary>
        public PropertyName PropertyAsPropertyName
        {
            get => string.IsNullOrEmpty(Property) ? null : PropertyName.Parse(Property, allowUnparsed: true);
            set => Property = value?.ToString() ?? "";
        }
    }

    public partial class FetchConnectedGa4PropertyResponse
    {
        /// <summary>
        /// <see cref="PropertyName"/>-typed view over the <see cref="Property"/> resource name property.
        /// </summary>
        public PropertyName PropertyAsPropertyName
        {
            get => string.IsNullOrEmpty(Property) ? null : PropertyName.Parse(Property, allowUnparsed: true);
            set => Property = value?.ToString() ?? "";
        }
    }

    public partial class CreateEventCreateRuleRequest
    {
        /// <summary>
        /// <see cref="DataStreamName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public DataStreamName ParentAsDataStreamName
        {
            get => string.IsNullOrEmpty(Parent) ? null : DataStreamName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class DeleteEventCreateRuleRequest
    {
        /// <summary>
        /// <see cref="gaav::EventCreateRuleName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gaav::EventCreateRuleName EventCreateRuleName
        {
            get => string.IsNullOrEmpty(Name) ? null : gaav::EventCreateRuleName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class GetEventCreateRuleRequest
    {
        /// <summary>
        /// <see cref="gaav::EventCreateRuleName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gaav::EventCreateRuleName EventCreateRuleName
        {
            get => string.IsNullOrEmpty(Name) ? null : gaav::EventCreateRuleName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class ListEventCreateRulesRequest
    {
        /// <summary>
        /// <see cref="DataStreamName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public DataStreamName ParentAsDataStreamName
        {
            get => string.IsNullOrEmpty(Parent) ? null : DataStreamName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class CreateEventEditRuleRequest
    {
        /// <summary>
        /// <see cref="DataStreamName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public DataStreamName ParentAsDataStreamName
        {
            get => string.IsNullOrEmpty(Parent) ? null : DataStreamName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class DeleteEventEditRuleRequest
    {
        /// <summary>
        /// <see cref="gaav::EventEditRuleName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gaav::EventEditRuleName EventEditRuleName
        {
            get => string.IsNullOrEmpty(Name) ? null : gaav::EventEditRuleName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class GetEventEditRuleRequest
    {
        /// <summary>
        /// <see cref="gaav::EventEditRuleName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gaav::EventEditRuleName EventEditRuleName
        {
            get => string.IsNullOrEmpty(Name) ? null : gaav::EventEditRuleName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class ListEventEditRulesRequest
    {
        /// <summary>
        /// <see cref="DataStreamName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public DataStreamName ParentAsDataStreamName
        {
            get => string.IsNullOrEmpty(Parent) ? null : DataStreamName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class ReorderEventEditRulesRequest
    {
        /// <summary>
        /// <see cref="DataStreamName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public DataStreamName ParentAsDataStreamName
        {
            get => string.IsNullOrEmpty(Parent) ? null : DataStreamName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class GetRollupPropertySourceLinkRequest
    {
        /// <summary>
        /// <see cref="gaav::RollupPropertySourceLinkName"/>-typed view over the <see cref="Name"/> resource name
        /// property.
        /// </summary>
        public gaav::RollupPropertySourceLinkName RollupPropertySourceLinkName
        {
            get => string.IsNullOrEmpty(Name) ? null : gaav::RollupPropertySourceLinkName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class ListRollupPropertySourceLinksRequest
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

    public partial class CreateRollupPropertySourceLinkRequest
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

    public partial class DeleteRollupPropertySourceLinkRequest
    {
        /// <summary>
        /// <see cref="gaav::RollupPropertySourceLinkName"/>-typed view over the <see cref="Name"/> resource name
        /// property.
        /// </summary>
        public gaav::RollupPropertySourceLinkName RollupPropertySourceLinkName
        {
            get => string.IsNullOrEmpty(Name) ? null : gaav::RollupPropertySourceLinkName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class CreateSubpropertyEventFilterRequest
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

    public partial class GetSubpropertyEventFilterRequest
    {
        /// <summary>
        /// <see cref="gaav::SubpropertyEventFilterName"/>-typed view over the <see cref="Name"/> resource name
        /// property.
        /// </summary>
        public gaav::SubpropertyEventFilterName SubpropertyEventFilterName
        {
            get => string.IsNullOrEmpty(Name) ? null : gaav::SubpropertyEventFilterName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class ListSubpropertyEventFiltersRequest
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

    public partial class DeleteSubpropertyEventFilterRequest
    {
        /// <summary>
        /// <see cref="gaav::SubpropertyEventFilterName"/>-typed view over the <see cref="Name"/> resource name
        /// property.
        /// </summary>
        public gaav::SubpropertyEventFilterName SubpropertyEventFilterName
        {
            get => string.IsNullOrEmpty(Name) ? null : gaav::SubpropertyEventFilterName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class CreateReportingDataAnnotationRequest
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

    public partial class GetReportingDataAnnotationRequest
    {
        /// <summary>
        /// <see cref="gaav::ReportingDataAnnotationName"/>-typed view over the <see cref="Name"/> resource name
        /// property.
        /// </summary>
        public gaav::ReportingDataAnnotationName ReportingDataAnnotationName
        {
            get => string.IsNullOrEmpty(Name) ? null : gaav::ReportingDataAnnotationName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class ListReportingDataAnnotationsRequest
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

    public partial class DeleteReportingDataAnnotationRequest
    {
        /// <summary>
        /// <see cref="gaav::ReportingDataAnnotationName"/>-typed view over the <see cref="Name"/> resource name
        /// property.
        /// </summary>
        public gaav::ReportingDataAnnotationName ReportingDataAnnotationName
        {
            get => string.IsNullOrEmpty(Name) ? null : gaav::ReportingDataAnnotationName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class SubmitUserDeletionRequest
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
}
