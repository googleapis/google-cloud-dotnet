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
using gaav = Google.Analytics.Admin.V1Beta;

namespace Google.Analytics.Admin.V1Beta
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
}
